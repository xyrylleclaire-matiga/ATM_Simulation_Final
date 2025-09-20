Imports MySql.Data.MySqlClient
Public Class frmMiniStatement

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Public Sub callTransaction()
        Call connection()
        sql = "SELECT sender_AccountNumber, receiver_AccountNumber, Amount,  transaction_type, Date
            FROM tbltransaction_history WHERE sender_AccountNumber = @acc OR receiver_AccountNumber = @acc
            ORDER BY `Date` DESC LIMIT 5"
        cmd = New MySqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@acc", LoggedInAccNum)

        dr = cmd.ExecuteReader
        ListView1.Items.Clear()
        While dr.Read()
            Dim x As New ListViewItem(dr("transaction_type").ToString())
            x.SubItems.Add(Convert.ToDouble(dr("Amount")).ToString("N2"))
            x.SubItems.Add(Convert.ToDateTime(dr("Date")).ToString("g"))
            ListView1.Items.Add(x)
        End While
        dr.Close()
    End Sub


    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub frmMiniStatement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        callTransaction()
        userDetails()
    End Sub

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

End Class