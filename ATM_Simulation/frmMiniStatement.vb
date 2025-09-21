Imports MySql.Data.MySqlClient
Public Class frmMiniStatement

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    'FOR TRANSACTIONNNN ------------
    Public Sub callTransaction()
        Call connection()
        sql = "SELECT sender_AccountNumber, receiver_AccountNumber, Amount,  transaction_type, Date
            FROM tbltransaction_history WHERE sender_AccountNumber = @acc OR receiver_AccountNumber = @acc AND Date BETWEEN @startDate AND @endDate 
            ORDER BY `Date` DESC LIMIT 5"
        cmd = New MySqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@acc", LoggedInAccNum)
        cmd.Parameters.AddWithValue("@startDate", dtFrom.Value.Date)
        cmd.Parameters.AddWithValue("@endDate", dtTo.Value.Date)

        dr = cmd.ExecuteReader
        ListView1.Items.Clear()
        While dr.Read()
            Dim x As New ListViewItem(dr("transaction_type").ToString())
            If dr("transaction_type").ToString = "Withdrawal" Then
                x.SubItems.Add(dr("sender_AccountNumber").ToString())
                x.SubItems.Add("-")
            ElseIf dr("transaction_type").ToString = "Deposit" Then
                x.SubItems.Add("-")
                x.SubItems.Add(dr("receiver_AccountNumber").ToString())
            Else
                x.SubItems.Add(dr("sender_AccountNumber").ToString())
                x.SubItems.Add(dr("receiver_AccountNumber").ToString())
            End If
            x.SubItems.Add(Convert.ToDouble(dr("Amount")).ToString("N2"))
            x.SubItems.Add(Convert.ToDateTime(dr("Date")).ToString("g"))
            ListView1.Items.Add(x)
        End While
        dr.Close()
    End Sub



    'FOR FILTERINGGGGGGG ---------------
    Private Sub forFiltering()
        Call connection()
        Dim sql As String

        If cboReportType.SelectedItem Is Nothing Then
            MsgBox("Please select a report type.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If cboReportType.SelectedItem.ToString() = "Withdrawal" Then
            sql = "SELECT sender_AccountNumber, Amount, transaction_type, Date " &
              "FROM tbltransaction_history " &
              "WHERE sender_AccountNumber = @acc AND transaction_type = 'Withdrawal' " &
               "AND Date BETWEEN @startDate AND @endDate " &
              "ORDER BY `Date` DESC LIMIT 5"

        ElseIf cboReportType.SelectedItem.ToString() = "Deposit" Then
            sql = "SELECT receiver_AccountNumber, Amount, transaction_type, Date " &
              "FROM tbltransaction_history " &
              "WHERE receiver_AccountNumber = @acc AND transaction_type = 'Deposit' " &
               "AND Date BETWEEN @startDate AND @endDate " &
              "ORDER BY `Date` DESC LIMIT 5"

        ElseIf cboReportType.SelectedItem.ToString() = "Fund_Transfer" Then
            sql = "SELECT sender_AccountNumber, receiver_AccountNumber, Amount, transaction_type, Date " &
              "FROM tbltransaction_history " &
              "WHERE (sender_AccountNumber = @acc OR receiver_AccountNumber = @acc) " &
              "AND transaction_type = 'Fund_Transfer' " &
               "AND Date BETWEEN @startDate AND @endDate " &
              "ORDER BY `Date` DESC LIMIT 5"


        End If
        cmd = New MySqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@acc", LoggedInAccNum)
        cmd.Parameters.AddWithValue("@startDate", dtFrom.Value.Date)
        cmd.Parameters.AddWithValue("@endDate", dtTo.Value.Date)
        dr = cmd.ExecuteReader

        ListView1.Items.Clear()
        While dr.Read()
            Dim y As New ListViewItem(dr("transaction_type").ToString())
            If cboReportType.SelectedItem.ToString = "Withdrawal" Then
                y.SubItems.Add(dr("sender_AccountNumber").ToString())
                y.SubItems.Add("-")
            ElseIf cboReportType.SelectedItem.ToString = "Deposit" Then
                y.SubItems.Add("-")
                y.SubItems.Add(dr("receiver_AccountNumber").ToString())
            Else
                y.SubItems.Add(dr("sender_AccountNumber").ToString())
                y.SubItems.Add(dr("receiver_AccountNumber").ToString())
            End If
            y.SubItems.Add(Convert.ToDouble(dr("Amount")).ToString("N2"))
            y.SubItems.Add(Convert.ToDateTime(dr("Date")).ToString("g"))
            ListView1.Items.Add(y)
        End While
        dr.Close()
        con.Close()

    End Sub


    Private Sub frmMiniStatement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        callTransaction()
        userDetails()
    End Sub

    'DETAILS NI USERRRRR ----------------
    Private Sub userDetails()
        Try
            dbConnection.connection()
            Dim query As String = "SELECT * FROM tbluserinfo WHERE AccountNumber = @accNum"
            dbConnection.cmd = New MySqlCommand(query, dbConnection.con)
            dbConnection.cmd.Parameters.AddWithValue("@accNum", dbConnection.LoggedInAccNum)
            dbConnection.dr = dbConnection.cmd.ExecuteReader()
            If dbConnection.dr.Read() Then
                lblUser.Text = dbConnection.dr("LastName").ToString().ToUpper() & ", " &
                dbConnection.dr("FirstName").ToString().ToUpper() & " " &
                dbConnection.dr("MiddleName").ToString().ToUpper()

                Dim lastTwo As String = LoggedInAccNum.Substring(LoggedInAccNum.Length - 2)
                lblAccountNumberDisplay.Text = "**** - **** - " & lastTwo

            End If
            dbConnection.dr.Close()
            dbConnection.con.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            If dbConnection.con.State = ConnectionState.Open Then
                dbConnection.con.Close()
            End If
        End Try
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        forFiltering()
    End Sub
End Class