Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class frmBalanceInquiry

    Private BalanceText As String

    Private Sub frmBalanceInquiry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBalance()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        updateBalance()
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

    ' ===== PRINT/PRINT PREVIEW =====
    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        ' Prepare balance text for printing
        BalanceText = "===== BALANCE INQUIRY =====" & vbCrLf &
                      "Account Number: " & LoggedInAccNum & vbCrLf &
                      "Current Balance: " & lblBalanceAmount.Text & vbCrLf &
                      "Date: " & DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") & vbCrLf &
                      "==========================="

        ' Show print preview
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Width = 800
        PrintPreviewDialog1.Height = 600
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Draw the balance inquiry receipt
        e.Graphics.DrawString(BalanceText, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 50, 50)
    End Sub

    Private Sub updateBalance()
        Call connection()
        sql = "SELECT BalanceAmount FROM tblaccountbalance WHERE AccountNumber = @acc"
        cmd = New MySqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@acc", LoggedInAccNum)

        Dim balanceUpdate As Object = cmd.ExecuteScalar()
        If balanceUpdate IsNot Nothing Then
            lblBalanceAmount.Text = "₱ " & Convert.ToDouble(balanceUpdate).ToString("N2")
        End If
        con.Close()

    End Sub

End Class
