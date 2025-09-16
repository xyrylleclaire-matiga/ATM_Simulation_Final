Imports MySql.Data.MySqlClient

Public Class frmUserManagement

    Private SelectedUserID As Integer = -1

    Private Sub frmUserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
        ClearFields()
    End Sub

    ' Load all users into DataGridView
    Private Sub LoadUsers()
        Try
            connection()
            Dim dt As New DataTable
            sql = "SELECT UserID, Username, FullName, Role FROM tbladmin_users"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()
            dt.Load(dr)
            dr.Close()
            dgvUsers.DataSource = dt
            dgvUsers.ClearSelection()
        Catch ex As Exception
            MessageBox.Show("Error loading users: " & ex.Message)
        End Try
    End Sub

    ' Clear input fields
    Private Sub ClearFields()
        txtUsernameInput.Text = ""
        txtFullNameInput.Text = ""
        txtRoleInput.Text = ""
        SelectedUserID = -1
        btnSave.Text = "Add User"
        btnDelete.Enabled = False
    End Sub

    ' Fill inputs when a row is clicked
    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        If e.RowIndex >= 0 Then
            SelectedUserID = CInt(dgvUsers.Rows(e.RowIndex).Cells("UserID").Value)
            txtUsernameInput.Text = dgvUsers.Rows(e.RowIndex).Cells("Username").Value.ToString()
            txtFullNameInput.Text = dgvUsers.Rows(e.RowIndex).Cells("FullName").Value.ToString()
            txtRoleInput.Text = dgvUsers.Rows(e.RowIndex).Cells("Role").Value.ToString()
            btnSave.Text = "Update User"
            btnDelete.Enabled = True
        End If
    End Sub

    ' Add or Update user
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtUsernameInput.Text = "" Or txtFullNameInput.Text = "" Or txtRoleInput.Text = "" Then
            MessageBox.Show("Please fill all fields.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Try
            connection()
            If SelectedUserID = -1 Then
                ' Add new user
                sql = "INSERT INTO Users (Username, FullName, Role, Password) VALUES (@Username, @FullName, @Role, @Password)"
                cmd = New MySqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@Username", txtUsernameInput.Text)
                cmd.Parameters.AddWithValue("@FullName", txtFullNameInput.Text)
                cmd.Parameters.AddWithValue("@Role", txtRoleInput.Text)
                cmd.Parameters.AddWithValue("@Password", "1234") ' default password
            Else
                ' Update existing user
                sql = "UPDATE Users SET Username=@Username, FullName=@FullName, Role=@Role WHERE UserID=@UserID"
                cmd = New MySqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@Username", txtUsernameInput.Text)
                cmd.Parameters.AddWithValue("@FullName", txtFullNameInput.Text)
                cmd.Parameters.AddWithValue("@Role", txtRoleInput.Text)
                cmd.Parameters.AddWithValue("@UserID", SelectedUserID)
            End If
            cmd.ExecuteNonQuery()
            LoadUsers()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error saving user: " & ex.Message)
        End Try
    End Sub

    ' Delete selected user
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If SelectedUserID = -1 Then Exit Sub

        If MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                connection()
                sql = "DELETE FROM Users WHERE UserID=@UserID"
                cmd = New MySqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@UserID", SelectedUserID)
                cmd.ExecuteNonQuery()
                LoadUsers()
                ClearFields()
            Catch ex As Exception
                MessageBox.Show("Error deleting user: " & ex.Message)
            End Try
        End If
    End Sub

    ' Clear input fields
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    ' Search/filter users dynamically
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If dgvUsers.DataSource Is Nothing Then Exit Sub
        Dim dv As DataView = CType(dgvUsers.DataSource, DataTable).DefaultView
        dv.RowFilter = $"Username LIKE '%{txtSearch.Text}%' OR FullName LIKE '%{txtSearch.Text}%' OR Role LIKE '%{txtSearch.Text}%'"
    End Sub

    Private Sub dgvUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellContentClick

    End Sub
End Class
