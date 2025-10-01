Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class Frmcustomermanagment

    Private connStr As String = "server=localhost;userid=root;password=;database=dbatm_simulation"
    Private conn As New MySqlConnection(connStr)

    ' Form Load
    Private Sub Frmcustomermanagment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAccountNumber.Text = generateAccountNumberr()
        LoadCustomers()
        txtPIN.Text = GeneratePIN()

    End Sub

    Private Function isDuplicate(email As String, contact As String) As Boolean
        Try
            Call connection()
            sql = "SELECT COUNT(*) FROM tbluserinfo WHERE EmailAddress = @emailadd OR ContactNumber = @contactno"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@emailadd", email.Trim())
            cmd.Parameters.AddWithValue("@contactno", contact.Trim())


            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            MsgBox("Error checking duplicates : ", ex.Message)
            Return True
        Finally
            con.Close()

        End Try
    End Function

    'FOR ACCOUNT NUMBER GENERATORRRRR ----------------
    Private Function generateAccountNumberr() As String
        Dim rndm As New Random()
        Dim accountNo As String
        Dim isDuplicate As Boolean

        Do
            accountNo = rndm.Next(1000000000, Integer.MaxValue).ToString()

            Call connection()
            sql = "SELECT COUNT(*) FROM tbluserinfo WHERE AccountNumber = @accNo"
            cmd = New MySqlCommand(sql, con)

            cmd.Parameters.AddWithValue("@accNo", accountNo)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            con.Close()

            isDuplicate = (count > 0)

        Loop While isDuplicate
        Return accountNo
    End Function

    Private Function GeneratePIN() As String
        Dim rndm As New Random()
        Dim pinNumber As String
        Dim isDuplicate As Boolean
        Do
            pinNumber = rndm.Next(100000, 1000000).ToString()

            Call connection()
            sql = "SELECT COUNT(*) FROM tbluserinfo WHERE PIN = @pin"
            cmd = New MySqlCommand(sql, con)

            cmd.Parameters.AddWithValue("@pin", pinNumber)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            con.Close()

            isDuplicate = (count > 0)
        Loop While isDuplicate
        Return pinNumber
    End Function

    ' Load customers
    Private Sub LoadCustomers()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = "SELECT u.AccountNumber, u.FirstName, u.LastName, u.MiddleName, u.EmailAddress, u.ContactNumber, u.attempts, u.Role, a.AccountStatus FROM tbluserinfo u INNER JOIN tblaccountbalance a ON u.AccountNumber = a.AccountNumber ORDER BY u.AccountNumber"
            Dim da As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvCustomers.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading customers: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Validations
    Private Function ValidateForm() As Boolean
        If String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse String.IsNullOrWhiteSpace(txtLastName.Text) Then
            MessageBox.Show("First Name and Last Name are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPIN.Text) OrElse txtPIN.Text.Length < 6 Then
            MessageBox.Show("PIN is required and must be at least 6 digits.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If Not String.IsNullOrWhiteSpace(txtEmail.Text) Then
            Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
            If Not Regex.IsMatch(txtEmail.Text.Trim(), emailPattern) Then
                MessageBox.Show("Invalid email format.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
        End If

        If Not String.IsNullOrWhiteSpace(txtContact.Text) Then
            If Not Regex.IsMatch(txtContact.Text.Trim(), "^\d+$") Then
                MessageBox.Show("Contact number must be numeric.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
        End If

        Return True
    End Function

    ' ---------------- ADD CUSTOMER ----------------
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not ValidateForm() Then Return

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim transaction As MySqlTransaction = conn.BeginTransaction()

            ' Insert into tbluserinfo
            Dim queryUser As String = "INSERT INTO tbluserinfo (AccountNumber, FirstName, LastName, MiddleName, EmailAddress, ContactNumber, PIN, attempts, Role) " &
                                      "VALUES (@acc, @fn, @ln, @mn, @email, @contact, @pin, @attempts, @role)"
            Dim cmdUser As New MySqlCommand(queryUser, conn, transaction)
            cmdUser.Parameters.AddWithValue("@acc", txtAccountNumber.Text)
            cmdUser.Parameters.AddWithValue("@fn", txtFirstName.Text.Trim())
            cmdUser.Parameters.AddWithValue("@ln", txtLastName.Text.Trim())
            cmdUser.Parameters.AddWithValue("@mn", txtMiddleName.Text.Trim())
            cmdUser.Parameters.AddWithValue("@email", txtEmail.Text.Trim())
            cmdUser.Parameters.AddWithValue("@contact", txtContact.Text.Trim())
            cmdUser.Parameters.AddWithValue("@pin", txtPIN.Text.Trim())
            cmdUser.Parameters.AddWithValue("@attempts", 3)
            cmdUser.Parameters.AddWithValue("@role", If(String.IsNullOrWhiteSpace(cmbRole.Text), "User", cmbRole.Text))
            cmdUser.ExecuteNonQuery()

            ' Insert initial balance into tblaccountbalance
            Dim queryBalance As String = "INSERT INTO tblaccountbalance (AccountNumber, AccountStatus, BalanceAmount) VALUES (@acc, 'Active', 0)"
            Dim cmdBalance As New MySqlCommand(queryBalance, conn, transaction)
            cmdBalance.Parameters.AddWithValue("@acc", txtAccountNumber.Text)
            cmdBalance.ExecuteNonQuery()

            transaction.Commit()
            MessageBox.Show("Customer added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCustomers()
            ClearForm()
            txtAccountNumber.Text = generateAccountNumberr()
            txtPIN.Text = GeneratePIN()
        Catch ex As Exception
            MessageBox.Show("Error adding customer: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' ---------------- DELETE CUSTOMER ----------------
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(txtAccountNumber.Text) Then
            MessageBox.Show("Select a customer to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete this customer and their account balance?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            Return
        End If

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim checkBalancecmd As New MySqlCommand("SELECT BalanceAmount FROM tblaccountbalance WHERE AccountNumber = @acc", conn)
            checkBalancecmd.Parameters.AddWithValue("@acc", txtAccountNumber.Text)
            Dim balance As Object = checkBalancecmd.ExecuteScalar()
            If balance IsNot Nothing AndAlso Convert.ToDecimal(balance) >= 500 Then
                MessageBox.Show("This account cannot be deleted because the balance is 500 or more.", "Delete Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ClearForm()
                Return
            End If

            Dim transaction As MySqlTransaction = conn.BeginTransaction()


            ' Delete from tblaccountbalance
            Dim cmdBalance As New MySqlCommand("DELETE FROM tblaccountbalance WHERE AccountNumber=@acc", conn, transaction)
            cmdBalance.Parameters.AddWithValue("@acc", txtAccountNumber.Text)
            cmdBalance.ExecuteNonQuery()

            ' Delete from tbluserinfo
            Dim cmdUser As New MySqlCommand("DELETE FROM tbluserinfo WHERE AccountNumber=@acc", conn, transaction)
            cmdUser.Parameters.AddWithValue("@acc", txtAccountNumber.Text)
            cmdUser.ExecuteNonQuery()

            transaction.Commit()
            MessageBox.Show("Customer and their account balance deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCustomers()
            ClearForm()
            txtAccountNumber.Text = generateAccountNumberr()
        Catch ex As Exception
            MessageBox.Show("Error deleting customer: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' ---------------- UPDATE CUSTOMER ----------------
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtAccountNumber.Text) Then
            MessageBox.Show("Select a customer to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If Not ValidateForm() Then Return

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = "UPDATE tbluserinfo SET FirstName=@fn, LastName=@ln, MiddleName=@mn, EmailAddress=@email, ContactNumber=@contact, PIN=@pin, attempts = @attempts, Role=@role WHERE AccountNumber=@acc"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@acc", txtAccountNumber.Text)
            cmd.Parameters.AddWithValue("@fn", txtFirstName.Text.Trim())
            cmd.Parameters.AddWithValue("@ln", txtLastName.Text.Trim())
            cmd.Parameters.AddWithValue("@mn", txtMiddleName.Text.Trim())
            cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim())
            cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim())
            cmd.Parameters.AddWithValue("@pin", txtPIN.Text.Trim())
            cmd.Parameters.AddWithValue("@attempts", txtattempts.Text.Trim())
            cmd.Parameters.AddWithValue("@role", If(String.IsNullOrWhiteSpace(cmbRole.Text), "User", cmbRole.Text))
            cmd.ExecuteNonQuery()

            Dim query2 As String = "UPDATE tblaccountbalance SET AccountStatus = @status WHERE AccountNumber = @acc"
            Dim cmd2 As New MySqlCommand(query2, conn)
            cmd2.Parameters.AddWithValue("@status", cboStatus.Text.Trim())
            cmd2.Parameters.AddWithValue("@acc", txtAccountNumber.Text.Trim)
            cmd2.ExecuteNonQuery()

            MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCustomers()
            ClearForm()
            txtAccountNumber.Text = generateAccountNumberr()

        Catch ex As Exception
            MessageBox.Show("Error updating customer: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' ---------------- CLEAR FORM ----------------
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
        txtAccountNumber.Text = generateAccountNumberr()
    End Sub

    Private Sub ClearForm()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtMiddleName.Clear()
        txtPIN.Clear()
        txtEmail.Clear()
        txtContact.Clear()
        cmbRole.SelectedIndex = -1
        cboStatus.SelectedItem = 1
    End Sub

    ' ---------------- GRID CLICK ----------------
    Private Sub dgvCustomers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellClick
        If e.RowIndex < 0 Then Return
        Dim row As DataGridViewRow = dgvCustomers.Rows(e.RowIndex)

        txtAccountNumber.Text = If(row.Cells("AccountNumber").Value IsNot Nothing, row.Cells("AccountNumber").Value.ToString(), "")
        txtFirstName.Text = If(row.Cells("FirstName").Value IsNot Nothing, row.Cells("FirstName").Value.ToString(), "")
        txtLastName.Text = If(row.Cells("LastName").Value IsNot Nothing, row.Cells("LastName").Value.ToString(), "")
        txtMiddleName.Text = If(row.Cells("MiddleName").Value IsNot Nothing, row.Cells("MiddleName").Value.ToString(), "")
        txtEmail.Text = If(row.Cells("EmailAddress").Value IsNot Nothing, row.Cells("EmailAddress").Value.ToString(), "")
        txtContact.Text = If(row.Cells("ContactNumber").Value IsNot Nothing, row.Cells("ContactNumber").Value.ToString(), "")
        txtPIN.Text = "******"
        txtattempts.Text = If(row.Cells("attempts").Value IsNot Nothing, row.Cells("attempts").Value.ToString(), "")
        cmbRole.Text = If(row.Cells("Role").Value IsNot Nothing, row.Cells("Role").Value.ToString(), "")
        cboStatus.Text = If(row.Cells("AccountStatus").Value IsNot Nothing, row.Cells("AccountStatus").Value.ToString(), "")
    End Sub

    ' ---------------- LIVE SEARCH ----------------
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = "SELECT AccountNumber, FirstName, LastName, MiddleName, EmailAddress, ContactNumber, PIN, attempts, Role FROM tbluserinfo " &
                                  "WHERE AccountNumber LIKE @s OR FirstName LIKE @s OR LastName LIKE @s OR EmailAddress LIKE @s OR ContactNumber LIKE @s " &
                                  "ORDER BY AccountNumber"
            Dim da As New MySqlDataAdapter(query, conn)
            da.SelectCommand.Parameters.AddWithValue("@s", "%" & txtSearch.Text.Trim() & "%")
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvCustomers.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error searching: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub dgvCustomers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellContentClick
    End Sub

End Class