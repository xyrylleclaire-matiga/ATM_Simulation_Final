Imports MySql.Data.MySqlClient

Public Class frmTransactions

    Private Sub frmTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTransactions()
    End Sub

    ' ----------------- Load Transactions -----------------
    Private Sub LoadTransactions(Optional searchTerm As String = "")
        Try
            dbConnection.connection()

            Dim query As String = "SELECT transaction_number, sender_AccountNumber, receiver_AccountNumber, Amount, Status, Date FROM tbltransaction_history"
            If searchTerm <> "" Then
                query &= " WHERE transaction_number LIKE @search OR sender_AccountNumber LIKE @search OR receiver_AccountNumber LIKE @search OR Status LIKE @search"
            End If

            Dim cmd As New MySqlCommand(query, dbConnection.con)
            If searchTerm <> "" Then
                cmd.Parameters.AddWithValue("@search", $"%{searchTerm}%")
            End If

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            dgvTransactions.DataSource = dt

            UpdateSummary(dt)

        Catch ex As Exception
            MessageBox.Show("Error loading transactions: " & ex.Message)
        End Try
    End Sub

    ' ----------------- Update Summary Panels -----------------
    Private Sub UpdateSummary(dt As DataTable)
        Dim successCount As Integer = 0
        Dim failedCount As Integer = 0

        For Each r As DataRow In dt.Rows
            Dim status As String = r("Status").ToString().Trim().ToLower()
            If status = "success" Or status = "successful" Then
                successCount += 1
            ElseIf status = "failed" Then
                failedCount += 1
            End If
        Next

        lblTotal.Text = dt.Rows.Count.ToString()
        lblSuccessful.Text = successCount.ToString()
        lblFailed.Text = failedCount.ToString()
    End Sub





    ' ----------------- Search Functionality -----------------
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadTransactions(txtSearch.Text.Trim())
    End Sub

End Class
