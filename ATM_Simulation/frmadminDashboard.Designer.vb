<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminDashboard
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    ' Panels
    Private WithEvents PanelSidebar As Panel
    Private WithEvents PanelHeader As Panel
    Private WithEvents PanelMain As Panel

    ' Sidebar Buttons
    Private WithEvents btnUsers As Button
    Private WithEvents btnTransactions As Button
    Private WithEvents btnReports As Button
    Private WithEvents btnSettings As Button

    ' Header Label
    Private WithEvents lblHeader As Label
    Private WithEvents btnLogout As Button

    ' Main Panel Cards
    Private WithEvents pnlTotalUsers As Panel
    Private WithEvents pnlTotalTransactions As Panel
    Private WithEvents pnlSystemStatus As Panel
    Private WithEvents lblTotalUsers As Label
    Private WithEvents lblTotalTransactions As Label
    Private WithEvents lblSystemStatus As Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PanelSidebar = New Panel()
        pctbxLogout = New PictureBox()
        btnUsers = New Button()
        btnTransactions = New Button()
        btnReports = New Button()
        btnSettings = New Button()
        PanelHeader = New Panel()
        lblHeader = New Label()
        btnLogout = New Button()
        PanelMain = New Panel()
        pnlTotalUsers = New Panel()
        lblTotalUsers = New Label()
        pnlTotalTransactions = New Panel()
        lblTotalTransactions = New Label()
        pnlSystemStatus = New Panel()
        lblSystemStatus = New Label()
        PanelSidebar.SuspendLayout()
        CType(pctbxLogout, ComponentModel.ISupportInitialize).BeginInit()
        PanelHeader.SuspendLayout()
        PanelMain.SuspendLayout()
        pnlTotalUsers.SuspendLayout()
        pnlTotalTransactions.SuspendLayout()
        pnlSystemStatus.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelSidebar
        ' 
        PanelSidebar.BackColor = Color.FromArgb(CByte(34), CByte(49), CByte(63))
        PanelSidebar.Controls.Add(pctbxLogout)
        PanelSidebar.Controls.Add(btnUsers)
        PanelSidebar.Controls.Add(btnTransactions)
        PanelSidebar.Controls.Add(btnReports)
        PanelSidebar.Controls.Add(btnSettings)
        PanelSidebar.Dock = DockStyle.Left
        PanelSidebar.Location = New Point(0, 0)
        PanelSidebar.Name = "PanelSidebar"
        PanelSidebar.Size = New Size(220, 650)
        PanelSidebar.TabIndex = 2
        ' 
        ' pctbxLogout
        ' 
        pctbxLogout.Image = My.Resources.Resources.download__38__removebg_preview
        pctbxLogout.Location = New Point(0, 600)
        pctbxLogout.Name = "pctbxLogout"
        pctbxLogout.Size = New Size(53, 50)
        pctbxLogout.SizeMode = PictureBoxSizeMode.StretchImage
        pctbxLogout.TabIndex = 3
        pctbxLogout.TabStop = False
        ' 
        ' btnUsers
        ' 
        btnUsers.Dock = DockStyle.Top
        btnUsers.FlatAppearance.BorderSize = 0
        btnUsers.FlatStyle = FlatStyle.Flat
        btnUsers.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnUsers.ForeColor = Color.White
        btnUsers.Location = New Point(0, 180)
        btnUsers.Name = "btnUsers"
        btnUsers.Padding = New Padding(25, 0, 0, 0)
        btnUsers.Size = New Size(220, 60)
        btnUsers.TabIndex = 0
        btnUsers.Text = "User Management"
        btnUsers.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnTransactions
        ' 
        btnTransactions.Dock = DockStyle.Top
        btnTransactions.FlatAppearance.BorderSize = 0
        btnTransactions.FlatStyle = FlatStyle.Flat
        btnTransactions.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnTransactions.ForeColor = Color.White
        btnTransactions.Location = New Point(0, 120)
        btnTransactions.Name = "btnTransactions"
        btnTransactions.Padding = New Padding(25, 0, 0, 0)
        btnTransactions.Size = New Size(220, 60)
        btnTransactions.TabIndex = 1
        btnTransactions.Text = "Transaction Records"
        btnTransactions.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnReports
        ' 
        btnReports.Dock = DockStyle.Top
        btnReports.FlatAppearance.BorderSize = 0
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnReports.ForeColor = Color.White
        btnReports.Location = New Point(0, 60)
        btnReports.Name = "btnReports"
        btnReports.Padding = New Padding(25, 0, 0, 0)
        btnReports.Size = New Size(220, 60)
        btnReports.TabIndex = 2
        btnReports.Text = "Reports"
        btnReports.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnSettings
        ' 
        btnSettings.Dock = DockStyle.Top
        btnSettings.FlatAppearance.BorderSize = 0
        btnSettings.FlatStyle = FlatStyle.Flat
        btnSettings.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnSettings.ForeColor = Color.White
        btnSettings.Location = New Point(0, 0)
        btnSettings.Name = "btnSettings"
        btnSettings.Padding = New Padding(25, 0, 0, 0)
        btnSettings.Size = New Size(220, 60)
        btnSettings.TabIndex = 3
        btnSettings.Text = "Settings"
        btnSettings.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        PanelHeader.Controls.Add(lblHeader)
        PanelHeader.Controls.Add(btnLogout)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(220, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(880, 70)
        PanelHeader.TabIndex = 1
        ' 
        ' lblHeader
        ' 
        lblHeader.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        lblHeader.ForeColor = Color.White
        lblHeader.Location = New Point(20, 20)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(300, 40)
        lblHeader.TabIndex = 0
        lblHeader.Text = "Admin Dashboard"
        ' 
        ' btnLogout
        ' 
        btnLogout.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnLogout.BackColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(880, 20)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(90, 35)
        btnLogout.TabIndex = 1
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' PanelMain
        ' 
        PanelMain.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        PanelMain.Controls.Add(pnlTotalUsers)
        PanelMain.Controls.Add(pnlTotalTransactions)
        PanelMain.Controls.Add(pnlSystemStatus)
        PanelMain.Dock = DockStyle.Fill
        PanelMain.Location = New Point(220, 70)
        PanelMain.Name = "PanelMain"
        PanelMain.Padding = New Padding(30)
        PanelMain.Size = New Size(880, 580)
        PanelMain.TabIndex = 0
        ' 
        ' pnlTotalUsers
        ' 
        pnlTotalUsers.BackColor = Color.White
        pnlTotalUsers.BorderStyle = BorderStyle.FixedSingle
        pnlTotalUsers.Controls.Add(lblTotalUsers)
        pnlTotalUsers.Location = New Point(30, 30)
        pnlTotalUsers.Name = "pnlTotalUsers"
        pnlTotalUsers.Size = New Size(250, 130)
        pnlTotalUsers.TabIndex = 0
        ' 
        ' lblTotalUsers
        ' 
        lblTotalUsers.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblTotalUsers.ForeColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        lblTotalUsers.Location = New Point(20, 20)
        lblTotalUsers.Name = "lblTotalUsers"
        lblTotalUsers.Size = New Size(200, 23)
        lblTotalUsers.TabIndex = 0
        lblTotalUsers.Text = "Total Users: 0"
        ' 
        ' pnlTotalTransactions
        ' 
        pnlTotalTransactions.BackColor = Color.White
        pnlTotalTransactions.BorderStyle = BorderStyle.FixedSingle
        pnlTotalTransactions.Controls.Add(lblTotalTransactions)
        pnlTotalTransactions.Location = New Point(310, 30)
        pnlTotalTransactions.Name = "pnlTotalTransactions"
        pnlTotalTransactions.Size = New Size(250, 130)
        pnlTotalTransactions.TabIndex = 1
        ' 
        ' lblTotalTransactions
        ' 
        lblTotalTransactions.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblTotalTransactions.ForeColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        lblTotalTransactions.Location = New Point(20, 20)
        lblTotalTransactions.Name = "lblTotalTransactions"
        lblTotalTransactions.Size = New Size(200, 23)
        lblTotalTransactions.TabIndex = 0
        lblTotalTransactions.Text = "Total Transactions: 0"
        ' 
        ' pnlSystemStatus
        ' 
        pnlSystemStatus.BackColor = Color.White
        pnlSystemStatus.BorderStyle = BorderStyle.FixedSingle
        pnlSystemStatus.Controls.Add(lblSystemStatus)
        pnlSystemStatus.Location = New Point(590, 30)
        pnlSystemStatus.Name = "pnlSystemStatus"
        pnlSystemStatus.Size = New Size(250, 130)
        pnlSystemStatus.TabIndex = 2
        ' 
        ' lblSystemStatus
        ' 
        lblSystemStatus.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblSystemStatus.ForeColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        lblSystemStatus.Location = New Point(20, 20)
        lblSystemStatus.Name = "lblSystemStatus"
        lblSystemStatus.Size = New Size(200, 23)
        lblSystemStatus.TabIndex = 0
        lblSystemStatus.Text = "System Status: OK"
        ' 
        ' frmAdminDashboard
        ' 
        ClientSize = New Size(1100, 650)
        Controls.Add(PanelMain)
        Controls.Add(PanelHeader)
        Controls.Add(PanelSidebar)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmAdminDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin Dashboard"
        PanelSidebar.ResumeLayout(False)
        CType(pctbxLogout, ComponentModel.ISupportInitialize).EndInit()
        PanelHeader.ResumeLayout(False)
        PanelMain.ResumeLayout(False)
        pnlTotalUsers.ResumeLayout(False)
        pnlTotalTransactions.ResumeLayout(False)
        pnlSystemStatus.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pctbxLogout As PictureBox
End Class