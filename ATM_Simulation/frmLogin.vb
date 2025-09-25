Imports MySql.Data.MySqlClient

Public Class frmLogin

    ' LOGIN FUNCTION
    Private Sub loginEnter()
        Try
            Call connection()

            Dim adminQuery As String = "SELECT * FROM tbladmin_users WHERE Username = @username AND Password = @password"
            Dim adminCmd As New MySqlCommand(adminQuery, con)
            adminCmd.Parameters.AddWithValue("@username", txtAccNum.Text.Trim())
            adminCmd.Parameters.AddWithValue("@password", txtPIN.Text.Trim())

            Dim adminDr As MySqlDataReader = adminCmd.ExecuteReader()

            If adminDr.Read() Then
                ' --- ADMIN LOGIN SUCCESS ---
                adminDr.Close()
                con.Close()
                frmAdminDashboard.Show()
                Me.Hide()
                txtAccNum.Clear()
                txtPIN.Clear()
                Exit Sub
            End If

            adminDr.Close()
            con.Close()

            ' CHECK ATTEMPT FIRST
            Call connection()
            Dim checkAttempt As String = "SELECT attempts FROM tbluserinfo WHERE AccountNumber = @accNum"
            Dim checkCMD As New MySqlCommand(checkAttempt, con)
            checkCMD.Parameters.AddWithValue("@accNum", txtAccNum.Text.Trim())
            Dim currentAttempts = checkCMD.ExecuteScalar()

            If currentAttempts IsNot Nothing AndAlso currentAttempts IsNot DBNull.Value Then
                If Convert.ToInt32(currentAttempts) <= 0 Then
                    MessageBox.Show("Your account is locked. Please contact the bank.", "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtAccNum.Clear()
                    txtPIN.Clear()
                    con.Close()
                    Return
                End If
            End If


            Call connection()
            Dim userQuery As String = "SELECT * FROM tbluserinfo WHERE AccountNumber = @accNum AND PIN = @pin"
            Dim userCmd As New MySqlCommand(userQuery, con)
            userCmd.Parameters.AddWithValue("@accNum", txtAccNum.Text.Trim())
            userCmd.Parameters.AddWithValue("@pin", txtPIN.Text.Trim())

            Dim userDr As MySqlDataReader = userCmd.ExecuteReader()

            If userDr.Read() Then
                ' --- USER LOGIN SUCCESS ---
                dbConnection.LoggedInAccNum = txtAccNum.Text.Trim()
                lblRole.Text = userDr("Role").ToString()
                userDr.Close()
                con.Close()

                Dim mainForm As New frmMain()
                mainForm.Show()
                Me.Hide()
                txtAccNum.Clear()
                txtPIN.Clear()

            Else
                userDr.Close()
                con.Close()


                ' --- FAILED LOGIN ---
                MessageBox.Show("Invalid Account Number or PIN.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                updateAttempts()
                refreshAttempts()

                If Val(lblAttempts.Text) <= 0 Then
                    MessageBox.Show("Your account has been locked due to multiple failed login attempts. Please contact the bank.", "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    ' FOR DEACTIVATEEEEEE ------------
                    Call connection()
                    sql = "UPDATE tblaccountbalance SET AccountStatus = 'Deactivated' WHERE AccountNumber = @accNum"
                    cmd = New MySqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("accNum", txtAccNum.Text.Trim())
                    cmd.ExecuteNonQuery()

                    txtAccNum.Clear()
                    txtPIN.Clear()
                    con.Close()

                    ' FOR RESET ATTEMPTSSS ---------
                    Call connection()
                    Dim lockSql As String = "UPDATE tbluserinfo SET attempts = 0 WHERE AccountNumber = @accNum"
                    Dim lockCmd As New MySqlCommand(lockSql, con)
                    lockCmd.Parameters.AddWithValue("@accNum", txtAccNum.Text.Trim())
                    lockCmd.ExecuteNonQuery()
                    con.Close()

                    Me.Close()
                End If

                txtAccNum.Clear()
                txtPIN.Clear()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub refreshAttempts()
        Call connection()
        Dim sql As String = "SELECT attempts FROM tbluserinfo WHERE AccountNumber = @accNum"
        cmd = New MySqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@accNum", txtAccNum.Text.Trim())
        Dim newAttempts = cmd.ExecuteScalar()
        If newAttempts IsNot Nothing Then
            lblAttempts.Text = newAttempts.ToString
        End If
        con.Close()
    End Sub

    ' UPDATE NG ATTEMPTS
    Private Sub updateAttempts()
        Call connection()
        Dim sql As String = "UPDATE tbluserinfo SET attempts = attempts - 1 WHERE AccountNumber = @accNum"
        Dim cmd As New MySqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@accNum", txtAccNum.Text.Trim())
        cmd.ExecuteNonQuery()
        con.Close()
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



End Class
