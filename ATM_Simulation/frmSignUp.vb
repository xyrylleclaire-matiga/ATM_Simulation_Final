Imports MySql.Data.MySqlClient

Public Class frmSignUp
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        createAccount()
    End Sub

    'FOR DUPLICATEEEEEEE ----------------------
    Private Function isDuplicate(email As String, contact As String) As Boolean
        Try
            Call connection()
            sql = "SELECT COUNT(*) FROM tbluserinfo WHERE EmailAddress = @emailadd OR ContactNumber = @contactno"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@emailadd", email.Trim())
            cmd.Parameters.AddWithValue("@contactno", contact.Trim())


            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            MsgBox("Error checking duplicates : ", ex.Message)
            Return True
        Finally
            con.Close()

        End Try
    End Function


    'FOR ACCOUNT NUMBER GENERATORRRRR ----------------
    Private Function generateAccountNumberr() As String
        Dim rndm As New Random()
        Dim accountNo As String
        Dim isDuplicate As Boolean

        Do
            accountNo = rndm.Next(1000000000, Integer.MaxValue).ToString()

            Call connection()
            sql = "SELECT COUNT(*) FROM tbluserinfo WHERE AccountNumber = @accNo"
            cmd = New MySqlCommand(sql, con)

            cmd.Parameters.AddWithValue("@accNo", accountNo)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            con.Close()

            isDuplicate = (count > 0)

        Loop While isDuplicate
        Return accountNo

    End Function


    'CREATE ACCOUNTTT FUNCTIONNNNNNNNNNNNNNN -------------
    Private Sub createAccount()
        Dim newAccountNo As String = generateAccountNumberr()

        If isDuplicate(txtEmailAdd.Text, txtContactNumber.Text) Then
            MsgBox("Email or Contact Number already exists!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Call connection()
        sql = "INSERT INTO tbluserinfo (AccountNumber, FirstName, LastName, MiddleName, EmailAddress, ContactNumber, PIN, attempts, Role) VALUES (@accNo, @firstname, @lastname, @middlename, @emailadd, @contactno, @pin, @attempts, @role)"
        cmd = New MySqlCommand(sql, con)

        cmd.Parameters.AddWithValue("@accNo", newAccountNo)
        cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text.Trim())
        cmd.Parameters.AddWithValue("@lastname", txtLastName.Text.Trim())
        cmd.Parameters.AddWithValue("@middlename", txtMiddleName.Text.Trim())
        cmd.Parameters.AddWithValue("@emailadd", txtEmailAdd.Text.Trim())
        cmd.Parameters.AddWithValue("@contactno", txtContactNumber.Text.Trim())
        cmd.Parameters.AddWithValue("@pin", 123456)
        cmd.Parameters.AddWithValue("@attempts", 3)
        cmd.Parameters.AddWithValue("@role", "User")
        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

        If rowsAffected > 0 Then
            MsgBox("Account Created Successfully", MsgBoxStyle.Information)
            Dim sqlAccountBalance = "INSERT INTO tblaccountbalance (AccountNumber, AccountStatus, BalanceAmount) VALUES (@accNo, @status, @balanceAmount)"
            Dim cmdAccountBalance = New MySqlCommand(sqlAccountBalance, con)

            cmdAccountBalance.Parameters.AddWithValue("@accNo", newAccountNo)
            cmdAccountBalance.Parameters.AddWithValue("@status", "Active")
            cmdAccountBalance.Parameters.AddWithValue("@balanceAmount", 0.00)
            cmdAccountBalance.ExecuteNonQuery()
        Else
            MsgBox("May error boi", MsgBoxStyle.Exclamation)
        End If

        con.Close()
    End Sub
End Class