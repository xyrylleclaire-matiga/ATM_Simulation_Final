Imports MySql.Data.MySqlClient

Public Class frmTransactions

    Private Sub frmTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTransactions()
    End Sub

    ' ----------------- Load Transactions -----------------
    Private Sub LoadTransactions(Optional searchTerm As String = "")
        Try
            dbConnection.connection() ' Open DB connection

            Dim query As String = "SELECT transaction_number, sender_AccountNumber, receiver_AccountNumber, Amount, Status, Date FROM tbltransaction_history"
            If searchTerm <> "" Then
                query &= " WHERE transaction_number LIKE @search OR UserID LIKE @search OR Status LIKE @search"
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
        lblTotal.Text = "Total: " & dt.Rows.Count
        lblSuccessful.Text = "Successful: " & dt.AsEnumerable().Count(Function(r) r.Field(Of String)("Status") = "Successful")
        lblFailed.Text = "Failed: " & dt.AsEnumerable().Count(Function(r) r.Field(Of String)("Status") = "Failed")
    End Sub

    ' ----------------- Search Functionality -----------------
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadTransactions(txtSearch.Text.Trim())
    End Sub

End Class
