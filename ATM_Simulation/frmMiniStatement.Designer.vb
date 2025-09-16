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
        cmbReportType = New ComboBox()
        lblReportType = New Label()
        lblFrom = New Label()
        lblTo = New Label()
        dtFrom = New DateTimePicker()
        dtTo = New DateTimePicker()
        btnFilter = New Button()
        DataGridView1 = New DataGridView()
        Button2 = New Button()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        ' lblHeader
        '
        lblHeader.AutoSize = True
        lblHeader.Font = New Font("Segoe UI Semibold", 20.0F, FontStyle.Bold)
        lblHeader.ForeColor = Color.FromArgb(0, 123, 255)
        lblHeader.Location = New Point(300, 20)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(205, 37)
        lblHeader.Text = "Mini Statement"
        '
        ' lstMiniStatement
        '
        lstMiniStatement.Font = New Font("Segoe UI", 12.0F)
        lstMiniStatement.FormattingEnabled = True
        lstMiniStatement.ItemHeight = 21
        lstMiniStatement.Location = New Point(50, 80)
        lstMiniStatement.Name = "lstMiniStatement"
        lstMiniStatement.Size = New Size(700, 340)
        '
        ' PictureBox1
        '
        PictureBox1.Image = My.Resources.Resources.ATM_UI_UX___南街_西洋菜
        PictureBox1.Location = New Point(-3, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(821, 529)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabStop = False
        '
        ' Panel1
        '
        Panel1.BackColor = Color.FromArgb(224, 224, 224)
        Panel1.Controls.Add(cmbReportType)
        Panel1.Controls.Add(lblReportType)
        Panel1.Controls.Add(lblFrom)
        Panel1.Controls.Add(lblTo)
        Panel1.Controls.Add(dtFrom)
        Panel1.Controls.Add(dtTo)
        Panel1.Controls.Add(btnFilter)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(87, 60)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(643, 406)
        '
        ' cmbReportType
        '
        cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbReportType.Font = New Font("Segoe UI", 10.0!)
        cmbReportType.Items.AddRange(New Object() {"User Reports", "Transaction Reports"})
        cmbReportType.Location = New Point(120, 80)
        cmbReportType.Name = "cmbReportType"
        cmbReportType.Size = New Size(180, 25)
        '
        ' lblReportType
        '
        lblReportType.AutoSize = True
        lblReportType.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        lblReportType.Location = New Point(40, 84)
        lblReportType.Name = "lblReportType"
        lblReportType.Size = New Size(74, 19)
        lblReportType.Text = "Report:"
        '
        ' lblFrom
        '
        lblFrom.AutoSize = True
        lblFrom.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        lblFrom.Location = New Point(320, 84)
        lblFrom.Name = "lblFrom"
        lblFrom.Size = New Size(47, 19)
        lblFrom.Text = "From:"
        '
        ' lblTo
        '
        lblTo.AutoSize = True
        lblTo.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        lblTo.Location = New Point(500, 84)
        lblTo.Name = "lblTo"
        lblTo.Size = New Size(28, 19)
        lblTo.Text = "To:"
        '
        ' dtFrom
        '
        dtFrom.Format = DateTimePickerFormat.[Short]
        dtFrom.Location = New Point(370, 82)
        dtFrom.Name = "dtFrom"
        dtFrom.Size = New Size(110, 23)
        '
        ' dtTo
        '
        dtTo.Format = DateTimePickerFormat.[Short]
        dtTo.Location = New Point(530, 82)
        dtTo.Name = "dtTo"
        dtTo.Size = New Size(110, 23)
        '
        ' btnFilter
        '
        btnFilter.BackColor = Color.FromArgb(0, 123, 255)
        btnFilter.FlatStyle = FlatStyle.Flat
        btnFilter.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        btnFilter.ForeColor = Color.White
        btnFilter.Location = New Point(260, 350)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(120, 30)
        btnFilter.Text = "Apply Filter"
        btnFilter.UseVisualStyleBackColor = False
        '
        ' DataGridView1
        '
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(43, 122)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(546, 220)
        '
        ' Button2
        '
        Button2.BackColor = Color.FromArgb(108, 117, 125)
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial Rounded MT Bold", 12.0!)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(502, 363)
        Button2.Name = "Button2"
        Button2.Size = New Size(131, 35)
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = False
        '
        ' Button1
        '
        Button1.BackColor = Color.DarkSlateGray
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 14.25!, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(-11, 32)
        Button1.Name = "Button1"
        Button1.Size = New Size(655, 37)
        Button1.Text = "   Mini Statement:"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        '
        ' frmMiniStatement
        '
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(248, 249, 250)
        ClientSize = New Size(815, 523)
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
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lstMiniStatement As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmbReportType As ComboBox
    Friend WithEvents lblReportType As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents dtFrom As DateTimePicker
    Friend WithEvents dtTo As DateTimePicker
    Friend WithEvents btnFilter As Button
End Class
