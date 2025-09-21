<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMiniStatement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblHeader = New Label()
        lstMiniStatement = New ListBox()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        lblUser = New Label()
        lblAccountNumberDisplay = New Label()
        lbl = New Label()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        cboReportType = New ComboBox()
        lblTransactionType = New Label()
        lblFrom = New Label()
        lblTo = New Label()
        dtFrom = New DateTimePicker()
        dtTo = New DateTimePicker()
        btnFilter = New Button()
        Button2 = New Button()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        lblHeader.ForeColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        lblHeader.Location = New Point(300, 20)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(205, 37)
        lblHeader.TabIndex = 3
        lblHeader.Text = "Mini Statement"
        ' 
        ' lstMiniStatement
        ' 
        lstMiniStatement.Font = New Font("Segoe UI", 12F)
        lstMiniStatement.FormattingEnabled = True
        lstMiniStatement.ItemHeight = 21
        lstMiniStatement.Location = New Point(50, 80)
        lstMiniStatement.Name = "lstMiniStatement"
        lstMiniStatement.Size = New Size(700, 340)
        lstMiniStatement.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ATM_UI_UX___南街_西洋菜
        PictureBox1.Location = New Point(-3, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(990, 579)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel1.Controls.Add(lblUser)
        Panel1.Controls.Add(lblAccountNumberDisplay)
        Panel1.Controls.Add(lbl)
        Panel1.Controls.Add(ListView1)
        Panel1.Controls.Add(cboReportType)
        Panel1.Controls.Add(lblTransactionType)
        Panel1.Controls.Add(lblFrom)
        Panel1.Controls.Add(lblTo)
        Panel1.Controls.Add(dtFrom)
        Panel1.Controls.Add(dtTo)
        Panel1.Controls.Add(btnFilter)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(87, 60)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(796, 451)
        Panel1.TabIndex = 0
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.BackColor = Color.DarkSlateGray
        lblUser.Font = New Font("Century Schoolbook", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUser.ForeColor = Color.White
        lblUser.Location = New Point(588, 28)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(18, 25)
        lblUser.TabIndex = 21
        lblUser.Text = " "
        ' 
        ' lblAccountNumberDisplay
        ' 
        lblAccountNumberDisplay.AutoSize = True
        lblAccountNumberDisplay.BackColor = Color.DarkSlateGray
        lblAccountNumberDisplay.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAccountNumberDisplay.ForeColor = Color.White
        lblAccountNumberDisplay.Location = New Point(660, 62)
        lblAccountNumberDisplay.Name = "lblAccountNumberDisplay"
        lblAccountNumberDisplay.Size = New Size(12, 18)
        lblAccountNumberDisplay.TabIndex = 23
        lblAccountNumberDisplay.Text = " "
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.BackColor = Color.DarkSlateGray
        lbl.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        lbl.ForeColor = Color.White
        lbl.Location = New Point(534, 62)
        lbl.Name = "lbl"
        lbl.Size = New Size(125, 16)
        lbl.TabIndex = 22
        lbl.Text = "Account Number: "
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader3, ColumnHeader4, ColumnHeader2, ColumnHeader5})
        ListView1.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListView1.GridLines = True
        ListView1.Location = New Point(17, 170)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(764, 207)
        ListView1.TabIndex = 11
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Transaction Type"
        ColumnHeader1.Width = 150
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "To"
        ColumnHeader3.TextAlign = HorizontalAlignment.Center
        ColumnHeader3.Width = 130
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "From"
        ColumnHeader4.TextAlign = HorizontalAlignment.Center
        ColumnHeader4.Width = 130
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Amount"
        ColumnHeader2.TextAlign = HorizontalAlignment.Center
        ColumnHeader2.Width = 150
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Date"
        ColumnHeader5.TextAlign = HorizontalAlignment.Center
        ColumnHeader5.Width = 200
        ' 
        ' cboReportType
        ' 
        cboReportType.DropDownStyle = ComboBoxStyle.DropDownList
        cboReportType.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboReportType.Items.AddRange(New Object() {"Withdrawal", "Deposit", "Fund_Transfer"})
        cboReportType.Location = New Point(148, 111)
        cboReportType.Name = "cboReportType"
        cboReportType.Size = New Size(180, 25)
        cboReportType.TabIndex = 0
        ' 
        ' lblTransactionType
        ' 
        lblTransactionType.AutoSize = True
        lblTransactionType.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblTransactionType.Location = New Point(17, 114)
        lblTransactionType.Name = "lblTransactionType"
        lblTransactionType.Size = New Size(125, 19)
        lblTransactionType.TabIndex = 1
        lblTransactionType.Text = "Transaction Type:"
        ' 
        ' lblFrom
        ' 
        lblFrom.AutoSize = True
        lblFrom.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblFrom.Location = New Point(433, 114)
        lblFrom.Name = "lblFrom"
        lblFrom.Size = New Size(48, 19)
        lblFrom.TabIndex = 2
        lblFrom.Text = "From:"
        ' 
        ' lblTo
        ' 
        lblTo.AutoSize = True
        lblTo.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblTo.Location = New Point(641, 112)
        lblTo.Name = "lblTo"
        lblTo.Size = New Size(29, 19)
        lblTo.TabIndex = 3
        lblTo.Text = "To:"
        ' 
        ' dtFrom
        ' 
        dtFrom.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtFrom.Format = DateTimePickerFormat.Short
        dtFrom.Location = New Point(483, 112)
        dtFrom.Name = "dtFrom"
        dtFrom.Size = New Size(110, 23)
        dtFrom.TabIndex = 4
        ' 
        ' dtTo
        ' 
        dtTo.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtTo.Format = DateTimePickerFormat.Short
        dtTo.Location = New Point(671, 110)
        dtTo.Name = "dtTo"
        dtTo.Size = New Size(110, 23)
        dtTo.TabIndex = 5
        ' 
        ' btnFilter
        ' 
        btnFilter.BackColor = Color.DarkSlateGray
        btnFilter.FlatStyle = FlatStyle.Flat
        btnFilter.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnFilter.ForeColor = Color.White
        btnFilter.Location = New Point(262, 394)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(149, 43)
        btnFilter.TabIndex = 6
        btnFilter.Text = "Apply Filter"
        btnFilter.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Brown
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(417, 394)
        Button2.Name = "Button2"
        Button2.Size = New Size(131, 43)
        Button2.TabIndex = 8
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkSlateGray
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(-12, 20)
        Button1.Name = "Button1"
        Button1.Size = New Size(817, 69)
        Button1.TabIndex = 9
        Button1.Text = "   Mini Statement:"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' frmMiniStatement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        ClientSize = New Size(983, 573)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Controls.Add(lstMiniStatement)
        Controls.Add(lblHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmMiniStatement"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mini Statement"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lstMiniStatement As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cboReportType As ComboBox
    Friend WithEvents lblTransactionType As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents dtFrom As DateTimePicker
    Friend WithEvents dtTo As DateTimePicker
    Friend WithEvents btnFilter As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents lblUser As Label
    Friend WithEvents lblAccountNumberDisplay As Label
    Friend WithEvents lbl As Label
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
End Class
