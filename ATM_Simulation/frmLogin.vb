Imports MySql.Data.MySqlClient

Public Class frmLogin

    Private Sub loginEnter()
        Try
            dbConnection.connection()

            Dim query As String = "SELECT * FROM tbluserinfo WHERE AccountNumber = @accNum AND PIN = @pin"
            dbConnection.cmd = New MySqlCommand(query, dbConnection.con)
            dbConnection.cmd.Parameters.AddWithValue("@accNum", txtAccNum.Text.Trim())
            dbConnection.cmd.Parameters.AddWithValue("@pin", txtPIN.Text.Trim())

            dbConnection.dr = dbConnection.cmd.ExecuteReader()

            If dbConnection.dr.Read() Then
                dbConnection.LoggedInAccNum = txtAccNum.Text.Trim()
                Dim userRole As String = dbConnection.dr("Role").ToString()
                lblRole.Text = userRole
                dbConnection.dr.Close()
                dbConnection.con.Close()
                If userRole = "Admin" Then
                    frmAdminDashboard.Show()
                Else
                    Dim mainForm As New frmMain()
                    mainForm.Show()
                End If

                Me.Hide()
                txtAccNum.Clear()
                txtPIN.Clear()
            Else
                dbConnection.dr.Close()
                dbConnection.con.Close()
                MessageBox.Show("Invalid Account Number or PIN.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If String.IsNullOrEmpty(lblAttempts.Text) Then
                    lblAttempts.Text = "3"
                End If
                lblAttempts.Text = (Val(lblAttempts.Text) - 1).ToString()
                updateAttempts()
                If lblAttempts.Text = 0 Then
                    MessageBox.Show("Your account has been locked due to multiple failed login attempts. Please contact the bank.", "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Call connection()
                    sql = "UPDATE tbluserinfo SET attempts = '0' WHERE AccountNumber = '" & txtAccNum.Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                    If dbConnection.con.State = ConnectionState.Open Then
                        dbConnection.con.Close()
                    End If
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

    Private Sub updateAttempts()
        Call connection()
        sql = "UPDATE tbluserinfo SET attempts = '" & lblAttempts.Text & "' WHERE AccountNumber = '" & txtAccNum.Text & "'"
        cmd = New MySqlCommand(sql, con)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        loginEnter()
    End Sub


    Private Sub lblEnter_Click(sender As Object, e As EventArgs) Handles lblEnter.Click
        loginEnter()
    End Sub

    Private Sub lblDel_Click(sender As Object, e As EventArgs) Handles lblDel.Click
        If txtAccNum.Focused Then
            If txtAccNum.Text.Length > 0 Then
                txtAccNum.Text = txtAccNum.Text.Substring(0, txtAccNum.Text.Length - 1)
                txtAccNum.SelectionStart = txtAccNum.Text.Length
            End If
        ElseIf txtPIN.Focused Then
            If txtPIN.Text.Length > 0 Then
                txtPIN.Text = txtPIN.Text.Substring(0, txtPIN.Text.Length - 1)
                txtPIN.SelectionStart = txtPIN.Text.Length
            End If
        End If
    End Sub

    Private Sub lblClear_Click(sender As Object, e As EventArgs) Handles lblClear.Click
        If txtAccNum.Focused Then
            txtAccNum.Clear()
        ElseIf txtPIN.Focused Then
            txtPIN.Clear()
        End If
    End Sub

    Private Sub lblCancel_Click(sender As Object, e As EventArgs) Handles lblCancel.Click
        Me.Close()
    End Sub


    'NUMPAD BUTTONS
    Private Sub lblNo1_Click(sender As Object, e As EventArgs) Handles lblNo1.Click
        If txtAccNum.Focused Then
            txtAccNum.AppendText("1")
        ElseIf txtPIN.Focused Then
            txtPIN.AppendText("1")
        End If
    End Sub
    Private Sub lblNo2_Click(sender As Object, e As EventArgs) Handles lblNo2.Click
        If txtAccNum.Focused Then
            txtAccNum.AppendText("2")
        ElseIf txtPIN.Focused Then
            txtPIN.AppendText("2")
        End If
    End Sub
    Private Sub lblNo3_Click(sender As Object, e As EventArgs) Handles lblNo3.Click
        If txtAccNum.Focused Then
            txtAccNum.AppendText("3")
        ElseIf txtPIN.Focused Then
            txtPIN.AppendText("3")
        End If
    End Sub
    Private Sub lblNo4_Click(sender As Object, e As EventArgs) Handles lblNo4.Click
        If txtAccNum.Focused Then
            txtAccNum.AppendText("4")
        ElseIf txtPIN.Focused Then
            txtPIN.AppendText("4")
        End If
    End Sub
    Private Sub lblNo5_Click(sender As Object, e As EventArgs) Handles lblNo5.Click
        If txtAccNum.Focused Then
            txtAccNum.AppendText("5")
        ElseIf txtPIN.Focused Then
            txtPIN.AppendText("5")
        End If
    End Sub
    Private Sub lblNo6_Click(sender As Object, e As EventArgs) Handles lblNo6.Click
        If txtAccNum.Focused Then
            txtAccNum.AppendText("6")
        ElseIf txtPIN.Focused Then
            txtPIN.AppendText("6")
        End If
    End Sub
    Private Sub lblNo7_Click(sender As Object, e As EventArgs) Handles lblNo7.Click
        If txtAccNum.Focused Then
            txtAccNum.AppendText("7")
        ElseIf txtPIN.Focused Then
            txtPIN.AppendText("7")
        End If
    End Sub
    Private Sub lblNo8_Click(sender As Object, e As EventArgs) Handles lblNo8.Click
        If txtAccNum.Focused Then
            txtAccNum.AppendText("8")
        ElseIf txtPIN.Focused Then
            txtPIN.AppendText("8")
        End If
    End Sub
    Private Sub lblNo9_Click(sender As Object, e As EventArgs) Handles lblNo9.Click
        If txtAccNum.Focused Then
            txtAccNum.AppendText("9")
        ElseIf txtPIN.Focused Then
            txtPIN.AppendText("9")
        End If
    End Sub
    Private Sub lblNo0_Click(sender As Object, e As EventArgs) Handles lblNo0.Click
        If txtAccNum.Focused Then
            txtAccNum.AppendText("0")
        ElseIf txtPIN.Focused Then
            txtPIN.AppendText("0")
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAttempts.Text = 3
    End Sub

End Class
