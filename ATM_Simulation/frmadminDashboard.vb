Imports MySql.Data.MySqlClient
Public Class frmAdminDashboard

    Private Sub frmAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadSummaryCards()
    End Sub

    ' ----------------- Load Summary Cards -----------------
    Private Sub LoadSummaryCards()

        Dim totalUsers As Integer
        Dim totalTransactions As Integer

        Call connection()
        sql = "SELECT COUNT(*) FROM tbluserinfo"
        cmd = New MySqlCommand(sql, con)
        totalUsers = Convert.ToInt32(cmd.ExecuteScalar())

        sql = "SELECT COUNT(*) FROM tbltransaction_history"
        cmd = New MySqlCommand(sql, con)
        totalTransactions = Convert.ToInt32(cmd.ExecuteScalar())

        Dim systemStatus As String = "OK"

        ' Update labels
        lblTotalUsers.Text = $"Total Users: {totalUsers}"
        lblTotalTransactions.Text = $"Total Transactions: {totalTransactions}"
        lblSystemStatus.Text = $"System Status: {systemStatus}"
    End Sub

    ' ----------------- Sidebar Button Clicks -----------------
    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        ' Open User Management Form inside PanelMain
        OpenChildForm(New frmUserManagement)
    End Sub

    Private Sub btnTransactions_Click(sender As Object, e As EventArgs) Handles btnTransactions.Click
        ' Open Transactions Form inside PanelMain
        OpenChildForm(New frmTransactions())
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        ' Open Reports Form inside PanelMain
        OpenChildForm(New frmReports())
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        ' Open Settings Form inside PanelMain
        OpenChildForm(New frmSettings())
    End Sub

    ' ----------------- Open Child Form in PanelMain -----------------
    Private currentChild As Form = Nothing
    Private Sub OpenChildForm(child As Form)
        ' Close previous child
        If currentChild IsNot Nothing Then
            currentChild.Close()
        End If

        currentChild = child
        child.TopLevel = False
        child.FormBorderStyle = FormBorderStyle.None
        child.Dock = DockStyle.Fill
        PanelMain.Controls.Clear()
        PanelMain.Controls.Add(child)
        child.Show()
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub pctbxLogout_Click(sender As Object, e As EventArgs) Handles pctbxLogout.Click
        If MsgBox("Are you sure you want to logout?", vbQuestion + vbYesNo) = vbYes Then
            frmLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenChildForm(New Frmcustomermanagment)
    End Sub

End Class
