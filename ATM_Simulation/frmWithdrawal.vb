Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class frmWithdrawal

    Private ReceiptText As String
    Dim currentAmount As Double

    ' Withdraw logic
    Private Sub Withdraw()
        Dim withdrawAmount As Double

        ' Validation ----------
        If String.IsNullOrWhiteSpace(txtAmount.Text) Then
            MessageBox.Show("Please enter an amount.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmount.Focus()
            Return
        End If
        If Not Double.TryParse(txtAmount.Text.Trim(), withdrawAmount) Then
            MessageBox.Show("Please enter a valid numeric amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmount.Clear()
            txtAmount.Focus()
            Return
        End If
        If withdrawAmount <= 0 Then
            MessageBox.Show("Withdrawal amount must be greater than 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmount.Clear()
            txtAmount.Focus()
            Return
        End If
        If txtAmount.Text.Contains(".") Then
            Dim decimals As String() = txtAmount.Text.Split("."c)
            If decimals.Length > 1 AndAlso decimals(1).Length > 2 Then
                MessageBox.Show("Amount can only have up to 2 decimal places.", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAmount.Focus()
                Return
            End If
        End If
        If withdrawAmount > 99999999.99 Then
            MessageBox.Show("Amount entered is too large.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmount.Clear()
            txtAmount.Focus()
            Return
        End If
        If withdrawAmount < 100 Then
            MessageBox.Show("Minimum withdrawal is 100.", "Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmount.Clear()
            txtAmount.Focus()
            Return
        End If
        If withdrawAmount > 10000 Then
            MessageBox.Show("Maximum withdrawal per transaction is 10,000.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmount.Clear()
            txtAmount.Focus()
            Return
        End If
        If withdrawAmount Mod 100 <> 0 Then
            MessageBox.Show("Withdrawal must be in multiples of 100.", "Invalid Denomination", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmount.Focus()
            Return
        End If

        ' Check Account Balance and Status
        Try
            Call connection()

            Dim cmdAcc As New MySqlCommand("SELECT BalanceAmount, AccountStatus FROM tblaccountbalance WHERE AccountNumber=@acc", con)
            cmdAcc.Parameters.AddWithValue("@acc", LoggedInAccNum.Trim())
            Dim reader = cmdAcc.ExecuteReader()

            If Not reader.Read() Then
                MessageBox.Show("Account not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                reader.Close()
                Return
            End If

            Dim currentBalance As Double = Convert.ToDouble(reader("BalanceAmount"))
            Dim accStatus As String = reader("AccountStatus").ToString()
            reader.Close()

            If accStatus <> "Active" Then
                MessageBox.Show("Account is not active. Withdrawal denied.", "Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If withdrawAmount > currentBalance Then
                MessageBox.Show("Insufficient balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAmount.Clear()
                txtAmount.Focus()
                Return
            End If

            If currentBalance - withdrawAmount < 500 Then
                MessageBox.Show("You must maintain a minimum balance of 500.", "Minimum Balance Rule", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAmount.Clear()
                txtAmount.Focus()
                Return
            End If

            Dim cmdDaily As New MySqlCommand("
                SELECT IFNULL(SUM(Amount),0) 
                FROM tbltransaction_history 
                WHERE sender_AccountNumber=@acc AND transaction_type='Withdraw' AND DATE(Date)=CURDATE()", con)
            cmdDaily.Parameters.AddWithValue("@acc", LoggedInAccNum.Trim())
            Dim todayTotal As Double = Convert.ToDouble(cmdDaily.ExecuteScalar())

            If todayTotal + withdrawAmount > 20000 Then
                MessageBox.Show("Daily withdrawal limit of 20,000 exceeded.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAmount.Clear()
                txtAmount.Focus()
                Return
            End If

            Dim cmdCount As New MySqlCommand("
                SELECT COUNT(*) FROM tbltransaction_history 
                WHERE sender_AccountNumber=@acc AND transaction_type='Withdraw' AND DATE(Date)=CURDATE()", con)
            cmdCount.Parameters.AddWithValue("@acc", LoggedInAccNum.Trim())
            Dim todayCount As Integer = Convert.ToInt32(cmdCount.ExecuteScalar())

            If todayCount >= 3 Then
                MessageBox.Show("You have reached the maximum of 3 withdrawals today.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim transaction = con.BeginTransaction()
            Dim cmd As New MySqlCommand()
            cmd.Connection = con
            cmd.Transaction = transaction

            sql = "UPDATE tblaccountbalance SET BalanceAmount = BalanceAmount - @withdraw WHERE AccountNumber = @acc"
            cmd.CommandText = sql
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@withdraw", withdrawAmount)
            cmd.Parameters.AddWithValue("@acc", LoggedInAccNum)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                ' Insert transaction logs
                Dim logCmd As New MySqlCommand("INSERT INTO tbltransaction_history (transaction_type, sender_AccountNumber, receiver_AccountNumber, Amount, Status, `Date`) VALUES (@transactiontype, @senderAcc, NULL, @amt, 'Success', NOW())", con, transaction)
                logCmd.Parameters.AddWithValue("@transactiontype", "Withdrawal")
                logCmd.Parameters.AddWithValue("@senderAcc", LoggedInAccNum.Trim())
                logCmd.Parameters.AddWithValue("@amt", withdrawAmount)
                logCmd.ExecuteNonQuery()

                transaction.Commit()

                ' FOR RECEIPT -----
                If MsgBox("Do you want to print receipt?", vbQuestion + vbYesNo) = vbYes Then
                    ReceiptText = "===== ATM RECEIPT =====" & vbCrLf &
                              "Account Number: " & LoggedInAccNum & vbCrLf &
                              "Transaction: Withdrawal" & vbCrLf &
                              "Amount Withdrawn: ₱" & withdrawAmount.ToString("N2") & vbCrLf &
                              "Remaining Balance: ₱" & (currentBalance - withdrawAmount).ToString("N2") & vbCrLf &
                              "Date: " & DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") & vbCrLf &
                              "======================="
                    PrintDocument1.Print()
                    PrintPreviewDialog1.Document = PrintDocument1
                    PrintPreviewDialog1.Width = 800
                    PrintPreviewDialog1.Height = 600
                    PrintPreviewDialog1.ShowDialog()
                End If
                MessageBox.Show("Withdrawal successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAmount.Clear()
            Else
                transaction.Rollback()
                MessageBox.Show("Withdrawal failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error during withdraw: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        Me.Hide()
        frmMain.Show()


    End Sub

    ' PrintDocument1 PrintPage event
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(ReceiptText, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 50, 50)
    End Sub

    ' Clear button
    Private Sub lblClear_Click_1(sender As Object, e As EventArgs) Handles lblClear.Click
        txtAmount.Clear()
    End Sub

    ' Delete button
    Private Sub lblDel_Click(sender As Object, e As EventArgs) Handles lblDel.Click
        Dim pos As String = txtAmount.Text.Length
        If pos > 0 Then
            txtAmount.Text = txtAmount.Text.Remove(pos - 1, 1)
            txtAmount.SelectionStart = txtAmount.Text.Length
        End If
    End Sub

    ' Withdraw button
    Private Sub lblWithdraw_Click(sender As Object, e As EventArgs) Handles lblWithdraw.Click
        Dim pinForm As New frmVerification()
        pinForm.ShowDialog()
        If pinForm.IsPinCorrect Then
            Withdraw()
            pctNumpad.Enabled = False
        Else
            txtAmount.Clear()
        End If
    End Sub

    ' Cancel button
    Private Sub lblCancel_Click(sender As Object, e As EventArgs) Handles lblCancel.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    ' Amount leave formatting
    Private Sub txtWithdraw_Leave(sender As Object, e As EventArgs) Handles txtAmount.Leave
        Dim raw As String = txtAmount.Text.Replace(",", "")
        Dim value As Double
        If Double.TryParse(raw, value) Then
            txtAmount.Text = value.ToString("N2")
        End If
    End Sub

    ' Decimal button
    Private Sub lblDecimal_Click(sender As Object, e As EventArgs) Handles lblDecimal.Click
        If txtAmount.Focused AndAlso Not txtAmount.Text.Contains(".") Then
            txtAmount.AppendText(".")
        End If
    End Sub

    ' NUMPAD BUTTONS
    Private Sub lblNo1_Click(sender As Object, e As EventArgs) Handles lblNo1.Click
        txtAmount.AppendText("1")
    End Sub
    Private Sub lblNo2_Click(sender As Object, e As EventArgs) Handles lblNo2.Click
        txtAmount.AppendText("2")
    End Sub
    Private Sub lblNo3_Click(sender As Object, e As EventArgs) Handles lblNo3.Click
        txtAmount.AppendText("3")
    End Sub
    Private Sub lblNo4_Click(sender As Object, e As EventArgs) Handles lblNo4.Click
        txtAmount.AppendText("4")
    End Sub
    Private Sub lblNo5_Click(sender As Object, e As EventArgs) Handles lblNo5.Click
        txtAmount.AppendText("5")
    End Sub
    Private Sub lblNo6_Click(sender As Object, e As EventArgs) Handles lblNo6.Click
        txtAmount.AppendText("6")
    End Sub
    Private Sub lblNo7_Click(sender As Object, e As EventArgs) Handles lblNo7.Click
        txtAmount.AppendText("7")
    End Sub
    Private Sub lblNo8_Click(sender As Object, e As EventArgs) Handles lblNo8.Click
        txtAmount.AppendText("8")
    End Sub
    Private Sub lblNo9_Click(sender As Object, e As EventArgs) Handles lblNo9.Click
        txtAmount.AppendText("9")
    End Sub
    Private Sub lblNo0_Click(sender As Object, e As EventArgs) Handles lblNo0.Click
        txtAmount.AppendText("0")
    End Sub

    ' Quick amount buttons
    Private Sub btn500_Click(sender As Object, e As EventArgs) Handles btn500.Click
        UpdateAmount(500)
    End Sub
    Private Sub btn1000_Click(sender As Object, e As EventArgs) Handles btn1000.Click
        UpdateAmount(1000)
    End Sub
    Private Sub btn2000_Click(sender As Object, e As EventArgs) Handles btn2000.Click
        UpdateAmount(2000)
    End Sub
    Private Sub btn5000_Click(sender As Object, e As EventArgs) Handles btn5000.Click
        UpdateAmount(5000)
    End Sub
    Private Sub btn10000_Click(sender As Object, e As EventArgs) Handles btn10000.Click
        UpdateAmount(10000)
    End Sub

    Private Sub UpdateAmount(amount As Double)
        If Double.TryParse(txtAmount.Text.Replace(",", ""), currentAmount) Then
            currentAmount += amount
            txtAmount.Text = currentAmount.ToString("N2")
        Else
            txtAmount.Text = amount.ToString("N2")
        End If
    End Sub

    Private Sub btnOtherAmount_Click(sender As Object, e As EventArgs) Handles btnOtherAmount.Click
        txtAmount.Focus()
    End Sub

End Class
