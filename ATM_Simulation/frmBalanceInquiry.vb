Imports MySql.Data.MySqlClient

Public Class frmBalanceInquiry

    Private Sub frmBalanceInquiry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBalance()

        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadBalance()
    End Sub

    Public Sub LoadBalance()
        Try
            If con Is Nothing Then
                connection()
            ElseIf con.State = ConnectionState.Closed Then
                con.Open()
            End If

            sql = "SELECT BalanceAmount FROM tblaccountbalance WHERE AccountNumber = @acc"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@acc", LoggedInAccNum)

            dr = cmd.ExecuteReader()

            If dr.Read() Then
                lblBalanceAmount.Text = "₱" & Format(CDbl(dr("BalanceAmount")), "N2")
            Else
                lblBalanceAmount.Text = "No balance found"
            End If

            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Load Balance Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadBalance()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Timer1.Stop()
        frmMain.Show()
        Me.Hide()
    End Sub
End Class
