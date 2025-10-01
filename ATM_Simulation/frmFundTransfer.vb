Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class frmFundTransfer

    ' ------------------- PRINT VARIABLES -------------------
    Private receiptAmount As Double
    Private receiptSender As String
    Private receiptReceiver As String
    Private receiptAccNum As String

    ' ---------------- BALANCE CHECK ----------------
    Private Function balanceCheck() As Boolean
        Dim transferAmount As Double

        If String.IsNullOrWhiteSpace(txtAmountTransfer.Text) OrElse
           Not Double.TryParse(txtAmountTransfer.Text.Replace(",", ""), transferAmount) OrElse
           transferAmount <= 0 Then
            MessageBox.Show("Please enter a valid transfer amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmountTransfer.Clear()
            txtAmountTransfer.Focus()
            Return False
        End If

        If transferAmount < 100 Then
            MessageBox.Show("Minimum transfer amount is 100.", "Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmountTransfer.Clear()
            txtAmountTransfer.Focus()
            Return False
        End If

        If transferAmount > 10000 Then
            MessageBox.Show("Transfer amount exceeds the maximum limit of 10,000.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmountTransfer.Clear()
            txtAmountTransfer.Focus()
            Return False
        End If

        If transferAmount Mod 100 <> 0 Then
            MessageBox.Show("Transfer amount must be in multiples of 100.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmountTransfer.Focus()
            Return False
        End If

        Try
            Call connection()
            sql = "SELECT BalanceAmount FROM tblaccountbalance WHERE AccountNumber = @acc"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@acc", LoggedInAccNum)

            Dim myBalance As Double = Convert.ToDouble(cmd.ExecuteScalar())
            If transferAmount > myBalance Then
                MessageBox.Show("Insufficient balance for this transfer.", "Insufficient Balance", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAmountTransfer.Clear()
                txtAmountTransfer.Focus()
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Balance Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        Return True
    End Function

    ' ---------------- CHECK ACCOUNT (REFACTORED) ----------------
    Private Function checkAccount() As Boolean
        ' Clear previous name
        txtAccountName.Clear()

        ' Check if textbox is empty
        If String.IsNullOrWhiteSpace(txtTargetAccount.Text) Then
            MessageBox.Show("Please enter target account number.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTargetAccount.Focus()
            Return False
        End If

        ' Check if numeric
        If Not IsNumeric(txtTargetAccount.Text) Then
            MessageBox.Show("Account number must be numeric.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTargetAccount.Clear()
            txtTargetAccount.Focus()
            Return False
        End If

        ' Check length
        If txtTargetAccount.Text.Trim().Length <> 10 Then
            MessageBox.Show("Account number must be 10 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTargetAccount.Clear()
            txtTargetAccount.Focus()
            Return False
        End If

        ' Transfer to your own account
        If txtTargetAccount.Text.Trim() = LoggedInAccNum Then
            MessageBox.Show("You cannot transfer to your own account.", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTargetAccount.Clear()
            txtAccountName.Clear()
            txtTargetAccount.Focus()
            Return False
        End If

        Try
            ' Ensure connection is fresh
            If con Is Nothing Then
                Call connection()
            ElseIf con.State = ConnectionState.Closed Then
                con.Open()
            End If

            ' TARGET ACCOUNT CHECKINGGG
            sql = "SELECT CONCAT(u.FirstName, ' ', u.MiddleName, ' ', u.LastName) AS FullName, " &
                  "b.AccountStatus " &
                  "FROM tbluserinfo u " &
                  "INNER JOIN tblaccountbalance b ON u.AccountNumber = b.AccountNumber " &
                  "WHERE TRIM(u.AccountNumber) = @accTarget LIMIT 1"

            Using cmd As New MySqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@accTarget", txtTargetAccount.Text.Trim())

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        txtAccountName.Text = dr("FullName").ToString().Trim()
                        Dim status As String = dr("AccountStatus").ToString().Trim()
                        If status = "Deactivated" Then
                            MsgBox("This account is deactivated. Transfer is not allowed", MsgBoxStyle.Exclamation)
                            txtAccountName.Text = "Deactivated Account"
                            Return False
                        ElseIf status = "Inactive" Then
                            MsgBox("This account is inactive. Transfer is not allowed", MsgBoxStyle.Exclamation)
                            txtAccountName.Text = "Inactive Account"
                            Return False
                        Else
                            Return True
                        End If

                    Else
                        txtAccountName.Text = "Account Not Found"
                        Return False
                    End If

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error checking account: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Function



    ' ---------- TRANSFER TRANSACTION ----------------
    Private Sub transferTransaction()
        Dim transferAmount As Double
        If Not Double.TryParse(txtAmountTransfer.Text.Replace(",", ""), transferAmount) OrElse transferAmount <= 0 Then
            MessageBox.Show("Invalid transfer amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmountTransfer.Focus()
            Return
        End If

        If MessageBox.Show("Are you sure you want to transfer ₱" & transferAmount.ToString("N2") &
                           " to account " & txtTargetAccount.Text & " : " & txtAccountName.Text & "?", "Confirm Transfer",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            txtAccountName.Clear()
            txtTargetAccount.Clear()
            txtAmountTransfer.Clear()
            Return
        End If

        Try
            Call connection()
            Dim transaction As MySqlTransaction = con.BeginTransaction()

            ' Update target account
            sql = "UPDATE tblaccountbalance SET BalanceAmount = BalanceAmount + @transfer WHERE AccountNumber = @accTarget"
            cmd = New MySqlCommand(sql, con, transaction)
            cmd.Parameters.AddWithValue("@transfer", transferAmount)
            cmd.Parameters.AddWithValue("@accTarget", txtTargetAccount.Text)
            Dim rowsAffectedTarget As Integer = cmd.ExecuteNonQuery

            ' Deduct from sender
            sql = "UPDATE tblaccountbalance SET BalanceAmount = BalanceAmount - @transfer WHERE AccountNumber = @acc"
            cmd = New MySqlCommand(sql, con, transaction)
            cmd.Parameters.AddWithValue("@transfer", transferAmount)
            cmd.Parameters.AddWithValue("@acc", LoggedInAccNum)
            Dim rowsAffectedSender As Integer = cmd.ExecuteNonQuery

            If rowsAffectedSender > 0 AndAlso rowsAffectedTarget > 0 Then
                ' Log transaction
                Dim logCmd As New MySqlCommand("
                    INSERT INTO tbltransaction_history (transaction_type, sender_AccountNumber, receiver_AccountNumber, Amount, Status, `Date`) 
                    VALUES (@transactiontype, @senderAcc, @receiverAcc, @transfer, 'Success', NOW())", con, transaction)
                logCmd.Parameters.AddWithValue("@transactiontype", "Fund_Transfer")
                logCmd.Parameters.AddWithValue("@senderAcc", LoggedInAccNum)
                logCmd.Parameters.AddWithValue("@receiverAcc", txtTargetAccount.Text)
                logCmd.Parameters.AddWithValue("@transfer", transferAmount)
                logCmd.ExecuteNonQuery()

                transaction.Commit()

                ' Set receipt values
                receiptAmount = transferAmount
                receiptSender = LoggedInAccNum
                receiptReceiver = txtTargetAccount.Text
                receiptAccNum = txtAccountName.Text

                If MsgBox("Do you want to print receipt?", vbQuestion + vbYesNo) = vbYes Then
                    'FOR RECEIPTTTT
                    PrintPreviewDialog1.ShowDialog()
                End If


                MessageBox.Show("Transaction Complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAmountTransfer.Clear()
                txtTargetAccount.Clear()
                txtAccountName.Clear()
            Else
                transaction.Rollback()
                MessageBox.Show("Transaction Failed. Please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Transfer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Close()
        frmMain.Show()
    End Sub

    '------------------------------ BUTTONS --------------------
    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        Dim pinForm As New frmVerification()
        pinForm.ShowDialog()

        If pinForm.maxAttemptsReached Then
            Me.Close()
            frmLogin.Show()
            Exit Sub
        End If

        If pinForm.IsPinCorrect Then
            If balanceCheck() = False Then Exit Sub
            If checkAccount() = False Then
                MessageBox.Show("The target account number does not exist. Please check and try again.", "Account Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtTargetAccount.Focus()
                txtTargetAccount.Clear()
                txtAmountTransfer.Clear()
                txtAccountName.Clear()
                Exit Sub
            End If
            transferTransaction()
        Else
            txtTargetAccount.Clear()
            txtAmountTransfer.Clear()
            txtAccountName.Clear()
        End If
    End Sub

    ' Auto-format amount
    Private Sub txtAmountTransfer_Leave(sender As Object, e As EventArgs) Handles txtAmountTransfer.Leave
        Dim raw As String = txtAmountTransfer.Text.Replace(",", "")
        Dim value As Double
        If Double.TryParse(raw, value) Then
            txtAmountTransfer.Text = value.ToString("N2")
        Else
            txtAmountTransfer.Text = "0.00"
        End If
    End Sub

    ' Cancel button
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmMain.Show()
        Me.Close()
    End Sub

    ' Target account auto-check
    Private Sub txtTargetAccount_Leave(sender As Object, e As EventArgs) Handles txtTargetAccount.Leave
        If txtTargetAccount.Text.Trim() <> "" Then
            checkAccount()
        End If
    End Sub

    ' ----------------- PRINT DOCUMENT -----------------
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fontTitle As New Font("Arial", 14, FontStyle.Bold)
        Dim fontBody As New Font("Arial", 10)
        Dim y As Integer = 20
        Dim lineHeight As Integer = 20

        ' Bank Name
        e.Graphics.DrawString("QuickCash ATM", fontTitle, Brushes.Black, 100, y)
        y += lineHeight * 2

        ' Receipt title
        e.Graphics.DrawString("FUND TRANSFER RECEIPT", fontTitle, Brushes.Black, 80, y)
        y += lineHeight * 2

        ' Details
        e.Graphics.DrawString("Date: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), fontBody, Brushes.Black, 20, y)
        y += lineHeight
        e.Graphics.DrawString("Sender Account #: " & receiptSender, fontBody, Brushes.Black, 20, y)
        y += lineHeight
        e.Graphics.DrawString("Receiver Account #: " & receiptReceiver, fontBody, Brushes.Black, 20, y)
        y += lineHeight
        e.Graphics.DrawString("Receiver Name: " & receiptAccNum, fontBody, Brushes.Black, 20, y)
        y += lineHeight
        e.Graphics.DrawString("Amount Transferred: ₱" & receiptAmount.ToString("N2"), fontBody, Brushes.Black, 20, y)
        y += lineHeight
        e.Graphics.DrawString("Status: Success", fontBody, Brushes.Black, 20, y)
        y += lineHeight * 2

        e.Graphics.DrawString("Thank you for banking with us!", fontBody, Brushes.Black, 20, y)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If txtAccountName.Focused Then
            txtAccountName.Clear()
            txtTargetAccount.Clear()
        ElseIf txtAmountTransfer.focused Then
            txtAmountTransfer.Clear()
        Else

        End If
    End Sub

    Private Sub btnDell_Click(sender As Object, e As EventArgs) Handles btnDell.Click
        If txtTargetAccount.Text.Length > 0 Then
            txtTargetAccount.Text = txtTargetAccount.Text.Remove(txtTargetAccount.Text.Length - 1, 1)
        ElseIf txtAmountTransfer.Text.Length > 0 Then
            txtAmountTransfer.Text = txtAmountTransfer.Text.Remove(txtAmountTransfer.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        If txtTargetAccount.Focused Then
            txtTargetAccount.AppendText("1")
        Else
            txtAmountTransfer.AppendText("1")
        End If
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        If txtTargetAccount.Focused Then
            txtTargetAccount.AppendText("2")
        Else
            txtAmountTransfer.AppendText("2")
        End If
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        If txtTargetAccount.Focused Then
            txtTargetAccount.AppendText("3")
        Else
            txtAmountTransfer.AppendText("3")
        End If
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        If txtTargetAccount.Focused Then
            txtTargetAccount.AppendText("4")
        Else
            txtAmountTransfer.AppendText("4")
        End If
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        If txtTargetAccount.Focused Then
            txtTargetAccount.AppendText("5")
        Else
            txtAmountTransfer.AppendText("5")
        End If
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        If txtTargetAccount.Focused Then
            txtTargetAccount.AppendText("6")
        Else
            txtAmountTransfer.AppendText("6")
        End If
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        If txtTargetAccount.Focused Then
            txtTargetAccount.AppendText("7")
        Else
            txtAmountTransfer.AppendText("7")
        End If
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        If txtTargetAccount.Focused Then
            txtTargetAccount.AppendText("8")
        Else
            txtAmountTransfer.AppendText("8")
        End If
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        If txtTargetAccount.Focused Then
            txtTargetAccount.AppendText("9")
        Else
            txtAmountTransfer.AppendText("9")
        End If
    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        If txtTargetAccount.Focused Then
            txtTargetAccount.AppendText("0")
        Else
            txtAmountTransfer.AppendText("0")
        End If
    End Sub
End Class
