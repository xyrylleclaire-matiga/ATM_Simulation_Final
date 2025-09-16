<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReports
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Friend WithEvents dgvReports As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTotalTransactions As Label
    Friend WithEvents lblCompleted As Label
    Friend WithEvents lblFailed As Label
    Friend WithEvents pnlTotalTransactions As Panel
    Friend WithEvents pnlCompleted As Panel
    Friend WithEvents pnlFailed As Panel

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgvReports = New DataGridView()
        txtSearch = New TextBox()
        lblTitle = New Label()
        lblTotalTransactions = New Label()
        lblCompleted = New Label()
        lblFailed = New Label()
        pnlTotalTransactions = New Panel()
        pnlCompleted = New Panel()
        pnlFailed = New Panel()
        CType(dgvReports, ComponentModel.ISupportInitialize).BeginInit()
        pnlTotalTransactions.SuspendLayout()
        pnlCompleted.SuspendLayout()
        pnlFailed.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvReports
        ' 
        dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReports.BackgroundColor = Color.White
        dgvReports.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(52), CByte(58), CByte(64))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvReports.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvReports.EnableHeadersVisualStyles = False
        dgvReports.GridColor = Color.LightGray
        dgvReports.Location = New Point(20, 100)
        dgvReports.Name = "dgvReports"
        dgvReports.RowTemplate.Height = 30
        dgvReports.Size = New Size(612, 380)
        dgvReports.TabIndex = 2
        ' 
        ' txtSearch
        ' 
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10.0F)
        txtSearch.Location = New Point(20, 60)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search reports..."
        txtSearch.Size = New Size(250, 25)
        txtSearch.TabIndex = 1
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        lblTitle.Location = New Point(20, 10)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(234, 32)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Reports Dashboard"
        ' 
        ' lblTotalTransactions
        ' 
        lblTotalTransactions.Dock = DockStyle.Fill
        lblTotalTransactions.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblTotalTransactions.ForeColor = Color.White
        lblTotalTransactions.Location = New Point(10, 10)
        lblTotalTransactions.Name = "lblTotalTransactions"
        lblTotalTransactions.Size = New Size(178, 25)
        lblTotalTransactions.TabIndex = 0
        lblTotalTransactions.Text = "Total Transactions: 0"
        lblTotalTransactions.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCompleted
        ' 
        lblCompleted.Dock = DockStyle.Fill
        lblCompleted.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblCompleted.ForeColor = Color.White
        lblCompleted.Location = New Point(10, 10)
        lblCompleted.Name = "lblCompleted"
        lblCompleted.Size = New Size(178, 32)
        lblCompleted.TabIndex = 0
        lblCompleted.Text = "Completed: 0"
        lblCompleted.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblFailed
        ' 
        lblFailed.Dock = DockStyle.Fill
        lblFailed.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblFailed.ForeColor = Color.White
        lblFailed.Location = New Point(10, 10)
        lblFailed.Name = "lblFailed"
        lblFailed.Size = New Size(178, 26)
        lblFailed.TabIndex = 0
        lblFailed.Text = "Failed: 0"
        lblFailed.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlTotalTransactions
        ' 
        pnlTotalTransactions.BackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        pnlTotalTransactions.Controls.Add(lblTotalTransactions)
        pnlTotalTransactions.Location = New Point(638, 199)
        pnlTotalTransactions.Name = "pnlTotalTransactions"
        pnlTotalTransactions.Padding = New Padding(10)
        pnlTotalTransactions.Size = New Size(198, 45)
        pnlTotalTransactions.TabIndex = 3
        ' 
        ' pnlCompleted
        ' 
        pnlCompleted.BackColor = Color.FromArgb(CByte(40), CByte(167), CByte(69))
        pnlCompleted.Controls.Add(lblCompleted)
        pnlCompleted.Location = New Point(638, 141)
        pnlCompleted.Name = "pnlCompleted"
        pnlCompleted.Padding = New Padding(10)
        pnlCompleted.Size = New Size(198, 52)
        pnlCompleted.TabIndex = 4
        ' 
        ' pnlFailed
        ' 
        pnlFailed.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        pnlFailed.Controls.Add(lblFailed)
        pnlFailed.Location = New Point(638, 89)
        pnlFailed.Name = "pnlFailed"
        pnlFailed.Padding = New Padding(10)
        pnlFailed.Size = New Size(198, 46)
        pnlFailed.TabIndex = 5
        ' 
        ' frmReports
        ' 
        BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        ClientSize = New Size(1000, 500)
        Controls.Add(lblTitle)
        Controls.Add(txtSearch)
        Controls.Add(dgvReports)
        Controls.Add(pnlTotalTransactions)
        Controls.Add(pnlCompleted)
        Controls.Add(pnlFailed)
        Name = "frmReports"
        Text = "Reports"
        CType(dgvReports, ComponentModel.ISupportInitialize).EndInit()
        pnlTotalTransactions.ResumeLayout(False)
        pnlCompleted.ResumeLayout(False)
        pnlFailed.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    ' Function for rounded corners
    Private Declare Function CreateRoundRectRgn Lib "Gdi32.dll" (
        ByVal nLeftRect As Integer, ByVal nTopRect As Integer,
        ByVal nRightRect As Integer, ByVal nBottomRect As Integer,
        ByVal nWidthEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr
End Class
