Imports MySql.Data.MySqlClient
Public Class frmVerification
    Public IsPinCorrect As Boolean = False

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Call connection()
        Dim sql As String = "SELECT AccountNumber FROM tbluserinfo WHERE AccountNumber = @accNum AND PIN = @pin"
        Dim cmd As New MySqlCommand(sql, dbConnection.con)
        cmd.Parameters.AddWithValue("@accNum", LoggedInAccNum.Trim())
        cmd.Parameters.AddWithValue("@pin", txtPIN.Text.Trim())

        dr = cmd.ExecuteReader()
        If dr.Read() Then
            Me.IsPinCorrect = True
            MessageBox.Show("PIN is correct. Access granted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            Me.IsPinCorrect = False
            MessageBox.Show("Invalid PIN. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPIN.Clear()
            Me.Close()
        End If

        dr.Close()
        con.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmMain.Show()
        Me.Close()
    End Sub
End Class