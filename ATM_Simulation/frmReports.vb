Imports System.Data

Public Class frmReports

    Private dtReports As New DataTable

    Private Sub frmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup DataGridView
        dgvReports.DataSource = dtReports
        dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        ' Create sample columns
        dtReports.Columns.Add("ID")
        dtReports.Columns.Add("Status")
        dtReports.Columns.Add("Description")

        ' Add sample data
        dtReports.Rows.Add(1, "Completed", "Report 1")
        dtReports.Rows.Add(2, "Failed", "Report 2")
        dtReports.Rows.Add(3, "Completed", "Report 3")
        dtReports.Rows.Add(4, "Completed", "Report 4")
        dtReports.Rows.Add(5, "Failed", "Report 5")

        ' Update counters
        UpdateCounters()
    End Sub

    Private Sub UpdateCounters()
        Dim total As Integer = dtReports.Rows.Count
        Dim completed As Integer = dtReports.Select("Status='Completed'").Length
        Dim failed As Integer = dtReports.Select("Status='Failed'").Length

        lblTotalTransactions.Text = $"Total Transactions: {total}"
        lblCompleted.Text = $"Completed: {completed}"
        lblFailed.Text = $"Failed: {failed}"
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim filter As String = txtSearch.Text.Trim().Replace("'", "''")
        If String.IsNullOrEmpty(filter) Then
            dgvReports.DataSource = dtReports
        Else
            Dim dv As New DataView(dtReports)
            dv.RowFilter = $"Description LIKE '%{filter}%' OR Status LIKE '%{filter}%'"
            dgvReports.DataSource = dv
        End If
    End Sub

End Class
