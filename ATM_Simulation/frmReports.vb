Imports MySql.Data.MySqlClient
Imports System.Data

Public Class frmReports

    Private dtReports As New DataTable

    Private Sub frmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReports()
    End Sub

    Private Sub LoadReports()
        dtReports.Clear()
        Try
            dbConnection.connection() ' open connection
            Dim sql As String = "SELECT transaction_number, transaction_type, sender_AccountNumber, receiver_AccountNumber, Amount, Status, Date FROM tbltransaction_history"
            Dim da As New MySqlDataAdapter(sql, dbConnection.con)
            da.Fill(dtReports)

            dgvReports.DataSource = dtReports
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            UpdateCounters()

        Catch ex As Exception
            MsgBox("Error loading reports: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateCounters()
        Dim total As Integer = dtReports.Rows.Count
        Dim successCount As Integer = dtReports.Select("Status='Success'").Length
        Dim failedCount As Integer = dtReports.Select("Status<>'Success'").Length

        lblTotalTransactions.Text = $"Total Transactions: {total}"
        lblCompleted.Text = $"Success: {successCount}"
        lblFailed.Text = $"Failed: {failedCount}"
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim filter As String = txtSearch.Text.Trim().Replace("'", "''")
        If String.IsNullOrEmpty(filter) Then
            dgvReports.DataSource = dtReports
        Else
            Dim dv As New DataView(dtReports)
            dv.RowFilter = $"transaction_number LIKE '%{filter}%' OR transaction_type LIKE '%{filter}%' OR sender_AccountNumber LIKE '%{filter}%' OR receiver_AccountNumber LIKE '%{filter}%'"
            dgvReports.DataSource = dv
        End If
    End Sub

End Class
