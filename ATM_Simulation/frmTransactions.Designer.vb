<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransactions
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer
    Private WithEvents lblTitle As Label
    Private WithEvents dgvTransactions As DataGridView
    Private WithEvents txtSearch As TextBox
    Private WithEvents pnlTotal As Panel
    Private WithEvents pnlSuccessful As Panel
    Private WithEvents pnlFailed As Panel
    Private WithEvents lblTotal As Label
    Private WithEvents lblSuccessful As Label
    Private WithEvents lblFailed As Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitle = New Label()
        pnlTotal = New Panel()
        lblTotal = New Label()
        pnlSuccessful = New Panel()
        lblSuccessful = New Label()
        pnlFailed = New Panel()
        lblFailed = New Label()
        txtSearch = New TextBox()
        dgvTransactions = New DataGridView()
        pnlTotal.SuspendLayout()
        pnlSuccessful.SuspendLayout()
        pnlFailed.SuspendLayout()
        CType(dgvTransactions, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        lblTitle.Location = New Point(20, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(142, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Transactions"
        ' 
        ' pnlTotal
        ' 
        pnlTotal.BackColor = Color.White
        pnlTotal.BorderStyle = BorderStyle.FixedSingle
        pnlTotal.Controls.Add(lblTotal)
        pnlTotal.Location = New Point(20, 70)
        pnlTotal.Name = "pnlTotal"
        pnlTotal.Size = New Size(220, 100)
        pnlTotal.TabIndex = 1
        ' 
        ' lblTotal
        ' 
        lblTotal.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblTotal.ForeColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        lblTotal.Location = New Point(15, 20)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(100, 23)
        lblTotal.TabIndex = 0
        lblTotal.Text = "Total: 0"
        ' 
        ' pnlSuccessful
        ' 
        pnlSuccessful.BackColor = Color.White
        pnlSuccessful.BorderStyle = BorderStyle.FixedSingle
        pnlSuccessful.Controls.Add(lblSuccessful)
        pnlSuccessful.Location = New Point(260, 70)
        pnlSuccessful.Name = "pnlSuccessful"
        pnlSuccessful.Size = New Size(220, 100)
        pnlSuccessful.TabIndex = 2
        ' 
        ' lblSuccessful
        ' 
        lblSuccessful.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblSuccessful.ForeColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        lblSuccessful.Location = New Point(15, 20)
        lblSuccessful.Name = "lblSuccessful"
        lblSuccessful.Size = New Size(100, 23)
        lblSuccessful.TabIndex = 0
        lblSuccessful.Text = "Successful: 0"
        ' 
        ' pnlFailed
        ' 
        pnlFailed.BackColor = Color.White
        pnlFailed.BorderStyle = BorderStyle.FixedSingle
        pnlFailed.Controls.Add(lblFailed)
        pnlFailed.Location = New Point(500, 70)
        pnlFailed.Name = "pnlFailed"
        pnlFailed.Size = New Size(220, 100)
        pnlFailed.TabIndex = 3
        ' 
        ' lblFailed
        ' 
        lblFailed.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblFailed.ForeColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        lblFailed.Location = New Point(15, 20)
        lblFailed.Name = "lblFailed"
        lblFailed.Size = New Size(100, 23)
        lblFailed.TabIndex = 0
        lblFailed.Text = "Failed: 0"
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 10F)
        txtSearch.Location = New Point(20, 190)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search transactions..."
        txtSearch.Size = New Size(250, 25)
        txtSearch.TabIndex = 4
        ' 
        ' dgvTransactions
        ' 
        dgvTransactions.AllowUserToAddRows = False
        dgvTransactions.AllowUserToDeleteRows = False
        dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTransactions.BackgroundColor = Color.White
        dgvTransactions.Location = New Point(20, 230)
        dgvTransactions.Name = "dgvTransactions"
        dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTransactions.Size = New Size(760, 290)
        dgvTransactions.TabIndex = 5
        ' 
        ' frmTransactions
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1386, 650)
        Controls.Add(lblTitle)
        Controls.Add(pnlTotal)
        Controls.Add(pnlSuccessful)
        Controls.Add(pnlFailed)
        Controls.Add(txtSearch)
        Controls.Add(dgvTransactions)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmTransactions"
        Text = "Transactions"
        pnlTotal.ResumeLayout(False)
        pnlSuccessful.ResumeLayout(False)
        pnlFailed.ResumeLayout(False)
        CType(dgvTransactions, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
End Class
