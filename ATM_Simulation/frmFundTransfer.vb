Imports MySql.Data.MySqlClient

Public Class frmFundTransfer

    ' ---------------- BALANCE CHECK () --------------
    Private Function balanceCheck() As Boolean
        Dim transferAmount As Double

        ' ✅ Empty / numeric / positive
        If String.IsNullOrWhiteSpace(txtAmountTransfer.Text) OrElse
           Not Double.TryParse(txtAmountTransfer.Text.Replace(",", ""), transferAmount) OrElse
           transferAmount <= 0 Then
            MessageBox.Show("Please enter a valid transfer amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmountTransfer.Clear()
            txtAmountTransfer.Focus()
            Return False
        End If

        ' ✅ Minimum transfer
        If transferAmount < 100 Then
            MessageBox.Show("Minimum transfer amount is 100.", "Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmountTransfer.Clear()
            txtAmountTransfer.Focus()
            Return False
        End If

        ' ✅ Maximum transfer
        If transferAmount > 10000 Then
            MessageBox.Show("Transfer amount exceeds the maximum limit of 10,000.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmountTransfer.Clear()
            txtAmountTransfer.Focus()
            Return False
        End If

        ' ✅ Optional multiples check
        If transferAmount Mod 100 <> 0 Then
            MessageBox.Show("Transfer amount must be in multiples of 100.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmountTransfer.Focus()
            Return False
        End If

        ' ✅ Balance check
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


    ' ---------------- CHECK ACCOUNT () --------------
    Private Function checkAccount() As Boolean
        ' ✅ Empty check
        If String.IsNullOrWhiteSpace(txtTargetAccount.Text) Then
            MessageBox.Show("Please enter target account number.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTargetAccount.Focus()
            Return False
        End If

        ' ✅ Digits only
        If Not IsNumeric(txtTargetAccount.Text) Then
            MessageBox.Show("Account number must be numeric.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTargetAccount.Clear()
            txtTargetAccount.Focus()
            Return False
        End If

        ' ✅ Length check (e.g. 10 digits)
        If txtTargetAccount.Text.Length <> 10 Then
            MessageBox.Show("Account number must be 10 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTargetAccount.Clear()
            txtTargetAccount.Focus()
            Return False
        End If

        ' ✅ Not own account
        If txtTargetAccount.Text = LoggedInAccNum Then
            MessageBox.Show("You cannot transfer to your own account.", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTargetAccount.Clear()
            txtAccountName.Clear()
            txtTargetAccount.Focus()
            Return False
        End If

        ' ✅ Check existence in DB
        Call connection()
        sql = "SELECT CONCAT(FirstName, ' ', MiddleName, ' ', LastName) as FullName 
               FROM tbluserinfo WHERE AccountNumber = @accTarget"
        cmd = New MySqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@accTarget", txtTargetAccount.Text)

        Using dr As MySqlDataReader = cmd.ExecuteReader()
            If dr.Read Then
                txtAccountName.Text = dr("FullName").ToString().Trim()
                Return True
            Else
                txtAccountName.Text = "Account Not Found"
                Return False
            End If
        End Using
    End Function


    ' ---------- TRANSFER TRANSACTION () --------------
    Private Sub transferTransaction()
        Dim transferAmount As Double
        If Not Double.TryParse(txtAmountTransfer.Text.Replace(",", ""), transferAmount) OrElse transferAmount <= 0 Then
            MessageBox.Show("Invalid transfer amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmountTransfer.Focus()
            Return
        End If

        ' ✅ Confirmation bago mag-proceed
        If MessageBox.Show("Are you sure you want to transfer ₱" & transferAmount.ToString("N2") &
                           " to account " & txtTargetAccount.Text & "?", "Confirm Transfer",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Try
            Call connection()
            Dim transaction As MySqlTransaction = con.BeginTransaction()

            ' Add to target
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
                transaction.Commit()
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
    End Sub


    '------------------------------ BUTTONS --------------------
    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
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
            If checkAccount() = False Then
                txtTargetAccount.Focus()
            End If
        End If
    End Sub

End Class
