Imports MySql.Data.MySqlClient

Public Class frmWithdrawal

    'Function ng withdraw logic
    Private Sub Withdraw()
        Dim withdrawAmount As Double

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

        Try
            Call connection()

            Dim cmdAcc As New MySqlCommand("SELECT BalanceAmount, AccountStatus FROM tblaccountbalance WHERE AccountNumber=@acc", con)
            cmdAcc.Parameters.AddWithValue("@acc", LoggedInAccNum)
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
            FROM tbltransactions 
            WHERE AccountNumber=@acc AND TransactionType='Withdraw' AND DATE(TransactionDate)=CURDATE()", con)
            cmdDaily.Parameters.AddWithValue("@acc", LoggedInAccNum)
            Dim todayTotal As Double = Convert.ToDouble(cmdDaily.ExecuteScalar())

            If todayTotal + withdrawAmount > 20000 Then
                MessageBox.Show("Daily withdrawal limit of 20,000 exceeded.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAmount.Clear()
                txtAmount.Focus()
                Return
            End If


            Dim cmdCount As New MySqlCommand("
            SELECT COUNT(*) FROM tbltransactions 
            WHERE AccountNumber=@acc AND TransactionType='Withdraw' AND DATE(TransactionDate)=CURDATE()", con)
            cmdCount.Parameters.AddWithValue("@acc", LoggedInAccNum)
            Dim todayCount As Integer = Convert.ToInt32(cmdCount.ExecuteScalar())

            If todayCount >= 3 Then
                MessageBox.Show("You have reached the maximum of 3 withdrawals today.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If


            Dim transaction = con.BeginTransaction()
            cmd = New MySqlCommand()
            cmd.Connection = con
            cmd.Transaction = transaction

            sql = "UPDATE tblaccountbalance SET BalanceAmount = BalanceAmount - @withdraw WHERE AccountNumber = @acc"
            cmd.CommandText = sql
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@withdraw", withdrawAmount)
            cmd.Parameters.AddWithValue("@acc", LoggedInAccNum)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                ' Insert into transaction logs
                Dim logCmd As New MySqlCommand("
                INSERT INTO tbltransactions (AccountNumber, TransactionType, Amount, TransactionDate) 
                VALUES (@acc, 'Withdraw', @amt, NOW())", con, transaction)
                logCmd.Parameters.AddWithValue("@acc", LoggedInAccNum)
                logCmd.Parameters.AddWithValue("@amt", withdrawAmount)
                logCmd.ExecuteNonQuery()

                transaction.Commit()
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
    End Sub

    ''FORMAT 0,000
    'Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
    '    Dim raw As String = txtAmount.Text.Replace(",", "")
    '    Dim value As Double
    '    If Double.TryParse(raw, value) Then
    '        txtAmount.Text = String.Format("{0:N2}", value)
    '        txtAmount.SelectionStart = txtAmount.Text.Length
    '    End If
    'End Sub

    'Clear Button
    Private Sub lblClear_Click_1(sender As Object, e As EventArgs) Handles lblClear.Click
        txtAmount.Clear()
    End Sub

    'Delete Button
    Private Sub lblDel_Click(sender As Object, e As EventArgs) Handles lblDel.Click
        Dim pos As String = txtAmount.Text.Length
        If pos > 0 Then
            txtAmount.Text = txtAmount.Text.Remove(pos - 1, 1)
            txtAmount.SelectionStart = txtAmount.Text.Length
        End If
    End Sub

    'Withdraw Button
    Private Sub lblWithdraw_Click(sender As Object, e As EventArgs) Handles lblWithdraw.Click
        Withdraw()
    End Sub

    'Cancel Button
    Private Sub lblCancel_Click(sender As Object, e As EventArgs) Handles lblCancel.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub txtWithdraw_Leave(sender As Object, e As EventArgs) Handles txtAmount.Leave
        Dim raw As String = txtAmount.Text.Replace(",", "")
        Dim value As Double
        If Double.TryParse(raw, value) Then
            txtAmount.Text = value.ToString("N2")
        End If
    End Sub


    'Decimal 'to
    Private Sub lblDecimal_Click(sender As Object, e As EventArgs) Handles lblDecimal.Click
        If txtAmount.Focused AndAlso Not txtAmount.Text.Contains(".") Then
            txtAmount.AppendText(".")
        End If
    End Sub

    'NUMPAD BUTTONS
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

    Private Sub btn500_Click(sender As Object, e As EventArgs) Handles btn500.Click
        txtAmount.Text = "500.00"
    End Sub

    Private Sub btn1000_Click(sender As Object, e As EventArgs) Handles btn1000.Click
        txtAmount.Text = "1000.00"
    End Sub

    Private Sub btn2000_Click(sender As Object, e As EventArgs) Handles btn2000.Click
        txtAmount.Text = "2000.00"
    End Sub

    Private Sub btn5000_Click(sender As Object, e As EventArgs) Handles btn5000.Click
        txtAmount.Text = "5000.00"
    End Sub

    Private Sub btn10000_Click(sender As Object, e As EventArgs) Handles btn10000.Click
        txtAmount.Text = "10000.00"
    End Sub

    Private Sub btnOtherAmount_Click(sender As Object, e As EventArgs) Handles btnOtherAmount.Click
        txtAmount.Focus()
    End Sub
End Class