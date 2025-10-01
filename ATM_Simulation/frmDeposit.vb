Imports System.Drawing.Printing
Imports System.Transactions
Imports MySql.Data.MySqlClient

Public Class frmDeposit

    Private receiptText As String
    Dim balanceAmount As Integer
    Private Sub Deposit()

        Dim depositAmount As Double

        ' ---------------- Input Validations ----------------
        If String.IsNullOrWhiteSpace(txtDepositAmount.Text) Then
            MessageBox.Show("Please enter an amount.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDepositAmount.Focus()
            Return
        End If

        If Not Double.TryParse(txtDepositAmount.Text.Trim(), depositAmount) Then
            MessageBox.Show("Please enter a valid numeric amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDepositAmount.Clear()
            txtDepositAmount.Focus()
            Return
        End If

        If depositAmount <= 0 Then
            MessageBox.Show("Deposit amount must be greater than 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDepositAmount.Clear()
            txtDepositAmount.Focus()
            Return
        End If

        ' Max 2 decimals
        If txtDepositAmount.Text.Contains(".") Then
            Dim decimals As String() = txtDepositAmount.Text.Split("."c)
            If decimals.Length > 1 AndAlso decimals(1).Length > 2 Then
                MessageBox.Show("Amount can only have up to 2 decimal places.", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtDepositAmount.Focus()
                Return
            End If
        End If

        ' Limits
        If depositAmount < 100 Then
            MessageBox.Show("Minimum deposit is 100.", "Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDepositAmount.Clear()
            txtDepositAmount.Focus()
            Return
        End If

        If depositAmount > 10000 Then
            MessageBox.Show("Deposit amount exceeds the maximum limit of 10,000.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDepositAmount.Clear()
            txtDepositAmount.Focus()
            Return
        End If

        If depositAmount Mod 100 <> 0 Then
            MessageBox.Show("Deposit must be in multiples of 100.", "Invalid Denomination", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDepositAmount.Focus()
            Return
        End If

        Try
            Call connection()

            ' Ensure account number is trimmed and padded to 10 characters
            Dim accNum As String = dbConnection.LoggedInAccNum.Trim()
            accNum = accNum.PadLeft(10, "0"c)


            Dim cmdAcc As New MySqlCommand("SELECT BalanceAmount, AccountStatus FROM tblaccountbalance WHERE TRIM(AccountNumber)=@acc", con)
            cmdAcc.Parameters.AddWithValue("@acc", accNum)
            Dim reader As MySqlDataReader = cmdAcc.ExecuteReader()

            If Not reader.Read() Then
                MessageBox.Show("Account not found. Make sure the Account Number exists in tblaccountbalance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                reader.Close()
                Return
            End If

            Dim accStatus As String = reader("AccountStatus").ToString()
            balanceAmount = Convert.ToDouble(reader("BalanceAmount"))
            reader.Close()

            If accStatus <> "Active" Then
                MessageBox.Show("Account is not active. Deposit denied.", "Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' ---------------- Daily Limit ----------------
            Dim cmdDaily As New MySqlCommand("
            SELECT IFNULL(SUM(Amount),0) 
            FROM tbltransaction_history 
            WHERE receiver_AccountNumber=@acc AND transaction_type='Deposit' AND DATE(`Date`)=CURDATE()", con)
            cmdDaily.Parameters.AddWithValue("@acc", accNum)
            Dim todayTotal As Double = Convert.ToDouble(cmdDaily.ExecuteScalar())

            If todayTotal + depositAmount > 50000 Then
                MessageBox.Show("Daily deposit limit of 50,000 exceeded.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtDepositAmount.Clear()
                txtDepositAmount.Focus()
                Return
            End If

            Dim cmdCount As New MySqlCommand("
            SELECT COUNT(*) 
            FROM tbltransaction_history
            WHERE receiver_AccountNumber=@acc AND transaction_type='Deposit' AND DATE(`Date`)=CURDATE()", con)
            cmdCount.Parameters.AddWithValue("@acc", accNum)
            Dim todayCount As Integer = Convert.ToInt32(cmdCount.ExecuteScalar())

            If todayCount >= 5 Then
                MessageBox.Show("You have reached the maximum of 5 deposits today.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' ---------------- Perform Deposit ----------------
            Dim transaction = con.BeginTransaction()
            Dim cmd As New MySqlCommand()
            cmd.Connection = con
            cmd.Transaction = transaction


            cmd.CommandText = "UPDATE tblaccountbalance SET BalanceAmount = BalanceAmount + @deposit WHERE TRIM(AccountNumber) = @acc"
            cmd.Parameters.AddWithValue("@BalanceAmount", balanceAmount)
            cmd.Parameters.AddWithValue("@deposit", depositAmount)
            cmd.Parameters.AddWithValue("@acc", accNum)
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                ' Insert transaction log
                Dim logCmd As New MySqlCommand("
                INSERT INTO tbltransaction_history (transaction_type, sender_AccountNumber, receiver_AccountNumber, Amount, Status, `Date`) 
                VALUES (@transactiontype, NULL, @receiverAcc, @amt, 'Success', NOW())", con, transaction)
                logCmd.Parameters.AddWithValue("@transactiontype", "Deposit")
                logCmd.Parameters.AddWithValue("@receiverAcc", accNum)
                logCmd.Parameters.AddWithValue("@amt", depositAmount)
                logCmd.ExecuteNonQuery()

                transaction.Commit()
                If MsgBox("Do you want to print your receipt?", vbQuestion + vbYesNo) = vbYes Then
                    ' FOR RECEIPT -----
                    receiptText = "===== ATM RECEIPT =====" & vbCrLf &
                                  "Account Number: " & LoggedInAccNum & vbCrLf &
                                  "Transaction: Deposit" & vbCrLf &
                                  "Amount Deposit: ₱" & depositAmount.ToString("N2") & vbCrLf &
                                  "Remaining Balance: ₱" & (balanceAmount + depositAmount).ToString("N2") & vbCrLf &
                                  "Date: " & DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") & vbCrLf &
                                  "======================="
                    PrintDocument1.Print()
                    PrintPreviewDialog1.Document = PrintDocument1
                    PrintPreviewDialog1.Width = 800
                    PrintPreviewDialog1.Height = 600
                    PrintPreviewDialog1.ShowDialog()
                End If
                MessageBox.Show("Deposit successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtDepositAmount.Clear()
            Else
                transaction.Rollback()
                MessageBox.Show("Deposit failed. Account not found.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDepositAmount.Clear()
            End If

        Catch ex As Exception
            MessageBox.Show("Error during deposit: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDepositAmount.Clear()
        Finally
            con.Close()
        End Try
        Me.Close()
        frmMain.Show()
    End Sub

    ' PrintDocument1 PrintPage event
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(receiptText, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 50, 50)
    End Sub

    ' ---------------- Button Handlers ----------------
    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click

        Dim pinForm As New frmVerification()
        pinForm.ShowDialog()

        If pinForm.maxAttemptsReached Then
            Me.Close()
            frmLogin.Show()
            Exit Sub
        End If

        If pinForm.IsPinCorrect Then
            Deposit()
        Else
            txtDepositAmount.Clear()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDepositAmount.Clear()
    End Sub

    ' ---------------- Keypad Button Handlers ----------------
    Private Sub lblNo0_Click(sender As Object, e As EventArgs) Handles lblNo0.Click
        txtDepositAmount.AppendText("0")
    End Sub

    Private Sub lblNo1_Click(sender As Object, e As EventArgs) Handles lblNo1.Click
        txtDepositAmount.AppendText("1")
    End Sub

    Private Sub lblNo2_Click(sender As Object, e As EventArgs) Handles lblNo2.Click
        txtDepositAmount.AppendText("2")
    End Sub

    Private Sub lblNo3_Click(sender As Object, e As EventArgs) Handles lblNo3.Click
        txtDepositAmount.AppendText("3")
    End Sub

    Private Sub lblNo4_Click(sender As Object, e As EventArgs) Handles lblNo4.Click
        txtDepositAmount.AppendText("4")
    End Sub

    Private Sub lblNo5_Click(sender As Object, e As EventArgs) Handles lblNo5.Click
        txtDepositAmount.AppendText("5")
    End Sub

    Private Sub lblNo6_Click(sender As Object, e As EventArgs) Handles lblNo6.Click
        txtDepositAmount.AppendText("6")
    End Sub

    Private Sub lblNo7_Click(sender As Object, e As EventArgs) Handles lblNo7.Click
        txtDepositAmount.AppendText("7")
    End Sub

    Private Sub lblNo8_Click(sender As Object, e As EventArgs) Handles lblNo8.Click
        txtDepositAmount.AppendText("8")
    End Sub

    Private Sub lblNo9_Click(sender As Object, e As EventArgs) Handles lblNo9.Click
        txtDepositAmount.AppendText("9")
    End Sub

    Private Sub lblDecimal_Click(sender As Object, e As EventArgs) Handles lblDecimal.Click
        If txtDepositAmount.Focused AndAlso Not txtDepositAmount.Text.Contains(".") Then
            txtDepositAmount.AppendText(".")
        End If
    End Sub

    Private Sub lblDel_Click(sender As Object, e As EventArgs) Handles lblDel.Click
        If txtDepositAmount.Text.Length > 0 Then
            txtDepositAmount.Text = txtDepositAmount.Text.Remove(txtDepositAmount.Text.Length - 1, 1)
        End If
    End Sub

    ' Format number on leave
    Private Sub txtDepositAmount_Leave(sender As Object, e As EventArgs) Handles txtDepositAmount.Leave
        Dim raw As String = txtDepositAmount.Text.Replace(",", "")
        Dim value As Double
        If Double.TryParse(raw, value) Then
            txtDepositAmount.Text = value.ToString("N2")
        Else
            txtDepositAmount.Text = "0.00"
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

End Class
