<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmcustomermanagment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlHeader = New Panel()
        lblTitle = New Label()
        pnlLeft = New Panel()
        grpForm = New GroupBox()
        Label1 = New Label()
        txtattempts = New TextBox()
        lblAccountNumber = New Label()
        txtAccountNumber = New TextBox()
        lblFirstName = New Label()
        txtFirstName = New TextBox()
        lblLastName = New Label()
        txtLastName = New TextBox()
        lblMiddleName = New Label()
        txtMiddleName = New TextBox()
        lblPIN = New Label()
        txtPIN = New TextBox()
        lblRole = New Label()
        cmbRole = New ComboBox()
        lblEmail = New Label()
        txtEmail = New TextBox()
        lblContact = New Label()
        txtContact = New TextBox()
        grpActions = New GroupBox()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        PanelSeparator = New Panel()
        pnlRight = New Panel()
        lblSearch = New Label()
        txtSearch = New TextBox()
        dgvCustomers = New DataGridView()
        pnlHeader.SuspendLayout()
        pnlLeft.SuspendLayout()
        grpForm.SuspendLayout()
        grpActions.SuspendLayout()
        pnlRight.SuspendLayout()
        CType(dgvCustomers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(880, 38)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(0, 3)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(247, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Customer Management"
        ' 
        ' pnlLeft
        ' 
        pnlLeft.BackColor = Color.White
        pnlLeft.Controls.Add(grpForm)
        pnlLeft.Dock = DockStyle.Left
        pnlLeft.Location = New Point(0, 38)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Padding = New Padding(8)
        pnlLeft.Size = New Size(320, 519)
        pnlLeft.TabIndex = 1
        ' 
        ' grpForm
        ' 
        grpForm.Controls.Add(Label1)
        grpForm.Controls.Add(txtattempts)
        grpForm.Controls.Add(lblAccountNumber)
        grpForm.Controls.Add(txtAccountNumber)
        grpForm.Controls.Add(lblFirstName)
        grpForm.Controls.Add(txtFirstName)
        grpForm.Controls.Add(lblLastName)
        grpForm.Controls.Add(txtLastName)
        grpForm.Controls.Add(lblMiddleName)
        grpForm.Controls.Add(txtMiddleName)
        grpForm.Controls.Add(lblPIN)
        grpForm.Controls.Add(txtPIN)
        grpForm.Controls.Add(lblRole)
        grpForm.Controls.Add(cmbRole)
        grpForm.Controls.Add(lblEmail)
        grpForm.Controls.Add(txtEmail)
        grpForm.Controls.Add(lblContact)
        grpForm.Controls.Add(txtContact)
        grpForm.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grpForm.Location = New Point(8, 8)
        grpForm.Name = "grpForm"
        grpForm.Size = New Size(304, 445)
        grpForm.TabIndex = 0
        grpForm.TabStop = False
        grpForm.Text = "Customer Details"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(11, 381)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 15)
        Label1.TabIndex = 17
        Label1.Text = "Attempts"
        ' 
        ' txtattempts
        ' 
        txtattempts.Location = New Point(12, 399)
        txtattempts.Name = "txtattempts"
        txtattempts.Size = New Size(276, 23)
        txtattempts.TabIndex = 16
        ' 
        ' lblAccountNumber
        ' 
        lblAccountNumber.AutoSize = True
        lblAccountNumber.Location = New Point(11, 27)
        lblAccountNumber.Name = "lblAccountNumber"
        lblAccountNumber.Size = New Size(116, 15)
        lblAccountNumber.TabIndex = 0
        lblAccountNumber.Text = "Account Number"
        ' 
        ' txtAccountNumber
        ' 
        txtAccountNumber.Location = New Point(11, 45)
        txtAccountNumber.Name = "txtAccountNumber"
        txtAccountNumber.ReadOnly = True
        txtAccountNumber.Size = New Size(276, 23)
        txtAccountNumber.TabIndex = 1
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Location = New Point(11, 71)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(78, 15)
        lblFirstName.TabIndex = 2
        lblFirstName.Text = "First Name"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(11, 89)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(276, 23)
        txtFirstName.TabIndex = 3
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Location = New Point(12, 115)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(76, 15)
        lblLastName.TabIndex = 4
        lblLastName.Text = "Last Name"
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(12, 133)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(276, 23)
        txtLastName.TabIndex = 5
        ' 
        ' lblMiddleName
        ' 
        lblMiddleName.AutoSize = True
        lblMiddleName.Location = New Point(12, 159)
        lblMiddleName.Name = "lblMiddleName"
        lblMiddleName.Size = New Size(91, 15)
        lblMiddleName.TabIndex = 6
        lblMiddleName.Text = "Middle Name"
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Location = New Point(12, 177)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(276, 23)
        txtMiddleName.TabIndex = 7
        ' 
        ' lblPIN
        ' 
        lblPIN.AutoSize = True
        lblPIN.Location = New Point(12, 203)
        lblPIN.Name = "lblPIN"
        lblPIN.Size = New Size(30, 15)
        lblPIN.TabIndex = 8
        lblPIN.Text = "PIN"
        ' 
        ' txtPIN
        ' 
        txtPIN.Location = New Point(11, 221)
        txtPIN.Name = "txtPIN"
        txtPIN.Size = New Size(276, 23)
        txtPIN.TabIndex = 9
        txtPIN.UseSystemPasswordChar = True
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Location = New Point(11, 247)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(36, 15)
        lblRole.TabIndex = 10
        lblRole.Text = "Role"
        ' 
        ' cmbRole
        ' 
        cmbRole.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRole.Items.AddRange(New Object() {"User", "Admin"})
        cmbRole.Location = New Point(11, 265)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(276, 23)
        cmbRole.TabIndex = 11
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(11, 291)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(44, 15)
        lblEmail.TabIndex = 12
        lblEmail.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(11, 309)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(276, 23)
        txtEmail.TabIndex = 13
        ' 
        ' lblContact
        ' 
        lblContact.AutoSize = True
        lblContact.Location = New Point(11, 335)
        lblContact.Name = "lblContact"
        lblContact.Size = New Size(59, 15)
        lblContact.TabIndex = 14
        lblContact.Text = "Contact"
        ' 
        ' txtContact
        ' 
        txtContact.Location = New Point(11, 353)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(276, 23)
        txtContact.TabIndex = 15
        ' 
        ' grpActions
        ' 
        grpActions.Controls.Add(btnAdd)
        grpActions.Controls.Add(btnUpdate)
        grpActions.Controls.Add(btnDelete)
        grpActions.Controls.Add(btnClear)
        grpActions.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grpActions.Location = New Point(16, 381)
        grpActions.Name = "grpActions"
        grpActions.Size = New Size(507, 92)
        grpActions.TabIndex = 1
        grpActions.TabStop = False
        grpActions.Text = "Actions"
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Arial Rounded MT Bold", 9F)
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(6, 55)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(120, 36)
        btnAdd.TabIndex = 0
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Arial Rounded MT Bold", 9F)
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(132, 55)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(120, 36)
        btnUpdate.TabIndex = 1
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Arial Rounded MT Bold", 9F)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(381, 55)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(120, 36)
        btnDelete.TabIndex = 2
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(149), CByte(165), CByte(166))
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Arial Rounded MT Bold", 9F)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(258, 55)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(120, 36)
        btnClear.TabIndex = 3
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' PanelSeparator
        ' 
        PanelSeparator.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        PanelSeparator.Dock = DockStyle.Left
        PanelSeparator.Location = New Point(320, 38)
        PanelSeparator.Name = "PanelSeparator"
        PanelSeparator.Size = New Size(2, 519)
        PanelSeparator.TabIndex = 3
        ' 
        ' pnlRight
        ' 
        pnlRight.BackColor = Color.White
        pnlRight.Controls.Add(lblSearch)
        pnlRight.Controls.Add(grpActions)
        pnlRight.Controls.Add(txtSearch)
        pnlRight.Controls.Add(dgvCustomers)
        pnlRight.Dock = DockStyle.Fill
        pnlRight.Location = New Point(322, 38)
        pnlRight.Name = "pnlRight"
        pnlRight.Size = New Size(558, 519)
        pnlRight.TabIndex = 2
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSearch.Location = New Point(16, 18)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(48, 14)
        lblSearch.TabIndex = 0
        lblSearch.Text = "Search"
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(70, 14)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(440, 21)
        txtSearch.TabIndex = 1
        ' 
        ' dgvCustomers
        ' 
        dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCustomers.BackgroundColor = Color.WhiteSmoke
        dgvCustomers.BorderStyle = BorderStyle.None
        dgvCustomers.Location = New Point(6, 41)
        dgvCustomers.Name = "dgvCustomers"
        dgvCustomers.ReadOnly = True
        dgvCustomers.RowHeadersVisible = False
        dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCustomers.Size = New Size(579, 340)
        dgvCustomers.TabIndex = 2
        ' 
        ' Frmcustomermanagment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(880, 557)
        Controls.Add(pnlRight)
        Controls.Add(PanelSeparator)
        Controls.Add(pnlLeft)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "Frmcustomermanagment"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Customer Management"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlLeft.ResumeLayout(False)
        grpForm.ResumeLayout(False)
        grpForm.PerformLayout()
        grpActions.ResumeLayout(False)
        pnlRight.ResumeLayout(False)
        pnlRight.PerformLayout()
        CType(dgvCustomers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    ' Declarations
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents grpForm As System.Windows.Forms.GroupBox
    Friend WithEvents lblAccountNumber As System.Windows.Forms.Label
    Friend WithEvents txtAccountNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblMiddleName As System.Windows.Forms.Label
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents lblPIN As System.Windows.Forms.Label
    Friend WithEvents txtPIN As System.Windows.Forms.TextBox
    Friend WithEvents lblRole As System.Windows.Forms.Label
    Friend WithEvents cmbRole As System.Windows.Forms.ComboBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblContact As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents grpActions As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents PanelSeparator As System.Windows.Forms.Panel
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgvCustomers As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtattempts As TextBox

End Class
