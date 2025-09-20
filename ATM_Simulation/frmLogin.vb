Imports MySql.Data.MySqlClient

Public Class frmLogin

    ' LOGIN FUNCTION
    Private Sub loginEnter()
        Try
            dbConnection.connection()

            ' 1. Try Admin Login
            Dim adminQuery As String = "SELECT * FROM tbladmin_users WHERE Username = @username AND Password = @password"
            Dim adminCmd As New MySqlCommand(adminQuery, dbConnection.con)
            adminCmd.Parameters.AddWithValue("@username", txtAccNum.Text.Trim())
            adminCmd.Parameters.AddWithValue("@password", txtPIN.Text.Trim())

            Dim adminDr As MySqlDataReader = adminCmd.ExecuteReader()

            If adminDr.Read() Then
                ' --- ADMIN LOGIN SUCCESS ---
                adminDr.Close()
                dbConnection.con.Close()
                frmAdminDashboard.Show()
                Me.Hide()
                txtAccNum.Clear()
                txtPIN.Clear()
                Exit Sub
            End If

            adminDr.Close()
            dbConnection.con.Close()

            ' 2. Try User Login
            dbConnection.connection()
            Dim userQuery As String = "SELECT * FROM tbluserinfo WHERE AccountNumber = @accNum AND PIN = @pin"
            Dim userCmd As New MySqlCommand(userQuery, dbConnection.con)
            userCmd.Parameters.AddWithValue("@accNum", txtAccNum.Text.Trim())
            userCmd.Parameters.AddWithValue("@pin", txtPIN.Text.Trim())

            Dim userDr As MySqlDataReader = userCmd.ExecuteReader()

            If userDr.Read() Then
                ' --- USER LOGIN SUCCESS ---
                dbConnection.LoggedInAccNum = txtAccNum.Text.Trim()
                lblRole.Text = userDr("Role").ToString()
                userDr.Close()
                dbConnection.con.Close()

                Dim mainForm As New frmMain()
                mainForm.Show()
                Me.Hide()
                txtAccNum.Clear()
                txtPIN.Clear()

            Else
                userDr.Close()
                dbConnection.con.Close()

                ' --- FAILED LOGIN ---
                MessageBox.Show("Invalid Account Number or PIN.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

                If String.IsNullOrEmpty(lblAttempts.Text) Then
                    lblAttempts.Text = "3"
                End If

                lblAttempts.Text = (Val(lblAttempts.Text) - 1).ToString()
                updateAttempts()

                If Val(lblAttempts.Text) <= 0 Then
                    MessageBox.Show("Your account has been locked due to multiple failed login attempts. Please contact the bank.", "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    dbConnection.connection()
                    Dim lockSql As String = "UPDATE tbluserinfo SET attempts = 0 WHERE AccountNumber = @accNum"
                    Dim lockCmd As New MySqlCommand(lockSql, dbConnection.con)
                    lockCmd.Parameters.AddWithValue("@accNum", txtAccNum.Text.Trim())
                    lockCmd.ExecuteNonQuery()
                    dbConnection.con.Close()

                    Me.Close()
                End If

                txtAccNum.Clear()
                txtPIN.Clear()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            If dbConnection.con.State = ConnectionState.Open Then
                dbConnection.con.Close()
            End If
        End Try
    End Sub

    ' UPDATE NG ATTEMPTS
    Private Sub updateAttempts()
        dbConnection.connection()
        Dim sql As String = "UPDATE tbluserinfo SET attempts = @attempts WHERE AccountNumber = @accNum"
        Dim cmd As New MySqlCommand(sql, dbConnection.con)
        cmd.Parameters.AddWithValue("@attempts", lblAttempts.Text)
        cmd.Parameters.AddWithValue("@accNum", txtAccNum.Text.Trim())
        cmd.ExecuteNonQuery()
        dbConnection.con.Close()
    End Sub

    ' LOGIN BUTTON
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        loginEnter()
    End Sub

    ' ENTER LABEL
    Private Sub lblEnter_Click(sender As Object, e As EventArgs) Handles lblEnter.Click
        loginEnter()
    End Sub

    ' DELETE LABEL
    Private Sub lblDel_Click(sender As Object, e As EventArgs) Handles lblDel.Click
        If txtAccNum.Focused AndAlso txtAccNum.Text.Length > 0 Then
            txtAccNum.Text = txtAccNum.Text.Substring(0, txtAccNum.Text.Length - 1)
            txtAccNum.SelectionStart = txtAccNum.Text.Length
        ElseIf txtPIN.Focused AndAlso txtPIN.Text.Length > 0 Then
            txtPIN.Text = txtPIN.Text.Substring(0, txtPIN.Text.Length - 1)
            txtPIN.SelectionStart = txtPIN.Text.Length
        End If
    End Sub

    ' CLEAR LABEL
    Private Sub lblClear_Click(sender As Object, e As EventArgs) Handles lblClear.Click
        If txtAccNum.Focused Then
            txtAccNum.Clear()
        ElseIf txtPIN.Focused Then
            txtPIN.Clear()
        End If
    End Sub

    ' CANCEL LABEL
    Private Sub lblCancel_Click(sender As Object, e As EventArgs) Handles lblCancel.Click
        Me.Close()
    End Sub

    ' === NUMPAD HANDLER PARA SA 0–9 ===
    Private Sub lblNo_Click(sender As Object, e As EventArgs) _
        Handles lblNo0.Click, lblNo1.Click, lblNo2.Click, lblNo3.Click,
                lblNo4.Click, lblNo5.Click, lblNo6.Click, lblNo7.Click,
                lblNo8.Click, lblNo9.Click

        Dim number As String = DirectCast(sender, Label).Text
        If txtAccNum.Focused Then
            txtAccNum.AppendText(number)
        ElseIf txtPIN.Focused Then
            txtPIN.AppendText(number)
        End If
    End Sub

    ' FORM LOAD
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAttempts.Text = "3"
    End Sub

End Class
