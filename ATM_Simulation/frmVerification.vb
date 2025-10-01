Imports MySql.Data.MySqlClient
Public Class frmVerification
    Public IsPinCorrect As Boolean = False
    Dim verificationAttempts As Integer = 3
    Public maxAttemptsReached As Boolean = False

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        If txtPIN.Text = "" Then
            MessageBox.Show("Please enter your PIN.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPIN.Focus()
            Exit Sub
        End If


        If con.State <> ConnectionState.Open Then
            con.Open()
        End If

        Dim sql As String = "SELECT AccountNumber FROM tbluserinfo WHERE AccountNumber = @accNum AND PIN = @pin"
        Dim cmd As New MySqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@accNum", LoggedInAccNum.Trim())
        cmd.Parameters.AddWithValue("@pin", txtPIN.Text.Trim())

        Dim resultObj As Object = cmd.ExecuteScalar()


        If resultObj IsNot Nothing AndAlso resultObj IsNot DBNull.Value Then
            IsPinCorrect = True
            verificationAttempts = 3
            MessageBox.Show("PIN is correct. Access granted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            IsPinCorrect = False
            verificationAttempts -= 1
            If verificationAttempts > 0 Then
                MessageBox.Show("Invalid PIN. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPIN.Clear()
                txtPIN.Focus()
            Else
                MessageBox.Show("You have exceeded the maximum number of attempts", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                maxAttemptsReached = True
                Me.Close()
            End If
            txtPIN.Clear()
            txtPIN.Focus()
        End If

        dr.Close()
        con.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPIN.Clear()
    End Sub

    Private Sub btnDell_Click(sender As Object, e As EventArgs) Handles btnDell.Click
        If txtPIN.Text.Length < 0 Then
            txtPIN.Text = txtPIN.Text.Remove(txtPIN.Text.Length - 1, 1)
        End If
    End Sub


    'NUMPADDDD ----------------
    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        txtPIN.AppendText("1")
    End Sub
    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        txtPIN.AppendText("2")
    End Sub
    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        txtPIN.AppendText("3")
    End Sub
    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        txtPIN.AppendText("4")
    End Sub
    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        txtPIN.AppendText("5")
    End Sub
    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        txtPIN.AppendText("6")
    End Sub
    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        txtPIN.AppendText("7")
    End Sub
    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        txtPIN.AppendText("8")
    End Sub
    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        txtPIN.AppendText("9")
    End Sub
    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        txtPIN.AppendText("0")
    End Sub
End Class