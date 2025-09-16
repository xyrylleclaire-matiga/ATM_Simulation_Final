<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFundTransfer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFundTransfer))
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        txtAccountName = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        btnTransfer = New Button()
        txtAmountTransfer = New TextBox()
        txtTargetAccount = New TextBox()
        btnCancel = New Button()
        Button2 = New Button()
        Panel2 = New Panel()
        lblDel = New Label()
        lblClear = New Label()
        Button3 = New Button()
        Button4 = New Button()
        btnDel = New Button()
        btnClear = New Button()
        lblEmptyy = New Label()
        lblDecimal = New Label()
        lblNo0 = New Label()
        lblNo9 = New Label()
        lblNo8 = New Label()
        lblNo7 = New Label()
        lblNo4 = New Label()
        lblNo5 = New Label()
        lblNo6 = New Label()
        lblNo3 = New Label()
        lblNo2 = New Label()
        lblNo1 = New Label()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ATM_UI_UX___南街_西洋菜
        PictureBox1.Location = New Point(-3, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(853, 568)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Snow
        Panel1.Controls.Add(txtAccountName)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(btnTransfer)
        Panel1.Controls.Add(txtAmountTransfer)
        Panel1.Controls.Add(txtTargetAccount)
        Panel1.Controls.Add(btnCancel)
        Panel1.Controls.Add(Button2)
        Panel1.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel1.Location = New Point(84, 61)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(675, 438)
        Panel1.TabIndex = 10
        ' 
        ' txtAccountName
        ' 
        txtAccountName.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAccountName.Location = New Point(37, 177)
        txtAccountName.Name = "txtAccountName"
        txtAccountName.ReadOnly = True
        txtAccountName.Size = New Size(244, 29)
        txtAccountName.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(52), CByte(58), CByte(64))
        Label2.Location = New Point(17, 149)
        Label2.Name = "Label2"
        Label2.Size = New Size(155, 23)
        Label2.TabIndex = 51
        Label2.Text = "Account Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(52), CByte(58), CByte(64))
        Label1.Location = New Point(362, 111)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 23)
        Label1.TabIndex = 50
        Label1.Text = "Amount Transfer:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(52), CByte(58), CByte(64))
        Label3.Location = New Point(17, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(172, 23)
        Label3.TabIndex = 49
        Label3.Text = "Account Number:"
        ' 
        ' btnTransfer
        ' 
        btnTransfer.BackColor = Color.DarkSlateGray
        btnTransfer.FlatAppearance.BorderSize = 0
        btnTransfer.FlatStyle = FlatStyle.Flat
        btnTransfer.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTransfer.ForeColor = Color.White
        btnTransfer.Location = New Point(140, 221)
        btnTransfer.Name = "btnTransfer"
        btnTransfer.Size = New Size(178, 35)
        btnTransfer.TabIndex = 3
        btnTransfer.Text = "Transfer"
        btnTransfer.UseVisualStyleBackColor = False
        ' 
        ' txtAmountTransfer
        ' 
        txtAmountTransfer.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAmountTransfer.Location = New Point(391, 149)
        txtAmountTransfer.Name = "txtAmountTransfer"
        txtAmountTransfer.Size = New Size(244, 29)
        txtAmountTransfer.TabIndex = 1
        txtAmountTransfer.Text = " "
        ' 
        ' txtTargetAccount
        ' 
        txtTargetAccount.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTargetAccount.Location = New Point(37, 111)
        txtTargetAccount.Name = "txtTargetAccount"
        txtTargetAccount.Size = New Size(244, 29)
        txtTargetAccount.TabIndex = 0
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Brown
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(332, 221)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(178, 35)
        btnCancel.TabIndex = 4
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkSlateGray
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(-4, 18)
        Button2.Name = "Button2"
        Button2.Size = New Size(704, 51)
        Button2.TabIndex = 42
        Button2.Text = "  Fund Transfer"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkGray
        Panel2.Controls.Add(lblDel)
        Panel2.Controls.Add(lblClear)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(btnDel)
        Panel2.Controls.Add(btnClear)
        Panel2.Controls.Add(lblEmptyy)
        Panel2.Controls.Add(lblDecimal)
        Panel2.Controls.Add(lblNo0)
        Panel2.Controls.Add(lblNo9)
        Panel2.Controls.Add(lblNo8)
        Panel2.Controls.Add(lblNo7)
        Panel2.Controls.Add(lblNo4)
        Panel2.Controls.Add(lblNo5)
        Panel2.Controls.Add(lblNo6)
        Panel2.Controls.Add(lblNo3)
        Panel2.Controls.Add(lblNo2)
        Panel2.Controls.Add(lblNo1)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Location = New Point(84, 323)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(675, 176)
        Panel2.TabIndex = 67
        ' 
        ' lblDel
        ' 
        lblDel.AutoSize = True
        lblDel.BackColor = Color.DarkKhaki
        lblDel.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblDel.Location = New Point(391, 57)
        lblDel.Name = "lblDel"
        lblDel.Size = New Size(65, 18)
        lblDel.TabIndex = 71
        lblDel.Text = "   DEL   "
        ' 
        ' lblClear
        ' 
        lblClear.AutoSize = True
        lblClear.BackColor = Color.Yellow
        lblClear.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblClear.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblClear.Location = New Point(391, 16)
        lblClear.Name = "lblClear"
        lblClear.Size = New Size(65, 18)
        lblClear.TabIndex = 70
        lblClear.Text = "CLEAR"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.WhiteSmoke
        Button3.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button3.Location = New Point(386, 134)
        Button3.Name = "Button3"
        Button3.Size = New Size(76, 38)
        Button3.TabIndex = 69
        Button3.Text = " "
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.WhiteSmoke
        Button4.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button4.Location = New Point(386, 92)
        Button4.Name = "Button4"
        Button4.Size = New Size(76, 38)
        Button4.TabIndex = 68
        Button4.Text = " "
        Button4.UseVisualStyleBackColor = False
        ' 
        ' btnDel
        ' 
        btnDel.BackColor = Color.DarkKhaki
        btnDel.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnDel.Location = New Point(386, 47)
        btnDel.Name = "btnDel"
        btnDel.Size = New Size(76, 38)
        btnDel.TabIndex = 67
        btnDel.Text = "DEL"
        btnDel.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Yellow
        btnClear.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnClear.Location = New Point(386, 6)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(76, 38)
        btnClear.TabIndex = 66
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' lblEmptyy
        ' 
        lblEmptyy.AutoSize = True
        lblEmptyy.BackColor = Color.WhiteSmoke
        lblEmptyy.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmptyy.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblEmptyy.Location = New Point(342, 138)
        lblEmptyy.Name = "lblEmptyy"
        lblEmptyy.Size = New Size(20, 22)
        lblEmptyy.TabIndex = 63
        lblEmptyy.Text = "  "
        ' 
        ' lblDecimal
        ' 
        lblDecimal.AutoSize = True
        lblDecimal.BackColor = Color.WhiteSmoke
        lblDecimal.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDecimal.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblDecimal.Location = New Point(250, 138)
        lblDecimal.Name = "lblDecimal"
        lblDecimal.Size = New Size(31, 22)
        lblDecimal.TabIndex = 62
        lblDecimal.Text = "  . "
        ' 
        ' lblNo0
        ' 
        lblNo0.AutoSize = True
        lblNo0.BackColor = Color.WhiteSmoke
        lblNo0.Font = New Font("Arial Rounded MT Bold", 15.75F)
        lblNo0.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo0.Location = New Point(301, 138)
        lblNo0.Name = "lblNo0"
        lblNo0.Size = New Size(22, 24)
        lblNo0.TabIndex = 61
        lblNo0.Text = "0"
        ' 
        ' lblNo9
        ' 
        lblNo9.AutoSize = True
        lblNo9.BackColor = Color.WhiteSmoke
        lblNo9.Font = New Font("Arial Rounded MT Bold", 15.75F)
        lblNo9.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo9.Location = New Point(348, 96)
        lblNo9.Name = "lblNo9"
        lblNo9.Size = New Size(22, 24)
        lblNo9.TabIndex = 60
        lblNo9.Text = "9"
        ' 
        ' lblNo8
        ' 
        lblNo8.AutoSize = True
        lblNo8.BackColor = Color.WhiteSmoke
        lblNo8.Font = New Font("Arial Rounded MT Bold", 15.75F)
        lblNo8.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo8.Location = New Point(302, 96)
        lblNo8.Name = "lblNo8"
        lblNo8.Size = New Size(22, 24)
        lblNo8.TabIndex = 59
        lblNo8.Text = "8"
        ' 
        ' lblNo7
        ' 
        lblNo7.AutoSize = True
        lblNo7.BackColor = Color.WhiteSmoke
        lblNo7.Font = New Font("Arial Rounded MT Bold", 15.75F)
        lblNo7.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo7.Location = New Point(255, 96)
        lblNo7.Name = "lblNo7"
        lblNo7.Size = New Size(22, 24)
        lblNo7.TabIndex = 58
        lblNo7.Text = "7"
        ' 
        ' lblNo4
        ' 
        lblNo4.AutoSize = True
        lblNo4.BackColor = Color.WhiteSmoke
        lblNo4.Font = New Font("Arial Rounded MT Bold", 15.75F)
        lblNo4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo4.Location = New Point(255, 55)
        lblNo4.Name = "lblNo4"
        lblNo4.Size = New Size(22, 24)
        lblNo4.TabIndex = 55
        lblNo4.Text = "4"
        ' 
        ' lblNo5
        ' 
        lblNo5.AutoSize = True
        lblNo5.BackColor = Color.WhiteSmoke
        lblNo5.Font = New Font("Arial Rounded MT Bold", 15.75F)
        lblNo5.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo5.Location = New Point(301, 55)
        lblNo5.Name = "lblNo5"
        lblNo5.Size = New Size(22, 24)
        lblNo5.TabIndex = 56
        lblNo5.Text = "5"
        ' 
        ' lblNo6
        ' 
        lblNo6.AutoSize = True
        lblNo6.BackColor = Color.WhiteSmoke
        lblNo6.Font = New Font("Arial Rounded MT Bold", 15.75F)
        lblNo6.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo6.Location = New Point(348, 55)
        lblNo6.Name = "lblNo6"
        lblNo6.Size = New Size(22, 24)
        lblNo6.TabIndex = 57
        lblNo6.Text = "6"
        ' 
        ' lblNo3
        ' 
        lblNo3.AutoSize = True
        lblNo3.BackColor = Color.WhiteSmoke
        lblNo3.Font = New Font("Arial Rounded MT Bold", 15.75F)
        lblNo3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo3.Location = New Point(348, 13)
        lblNo3.Name = "lblNo3"
        lblNo3.Size = New Size(22, 24)
        lblNo3.TabIndex = 54
        lblNo3.Text = "3"
        ' 
        ' lblNo2
        ' 
        lblNo2.AutoSize = True
        lblNo2.BackColor = Color.WhiteSmoke
        lblNo2.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNo2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo2.Location = New Point(301, 13)
        lblNo2.Name = "lblNo2"
        lblNo2.Size = New Size(22, 24)
        lblNo2.TabIndex = 53
        lblNo2.Text = "2"
        ' 
        ' lblNo1
        ' 
        lblNo1.AutoSize = True
        lblNo1.BackColor = Color.WhiteSmoke
        lblNo1.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNo1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo1.Location = New Point(255, 13)
        lblNo1.Name = "lblNo1"
        lblNo1.Size = New Size(22, 24)
        lblNo1.TabIndex = 35
        lblNo1.Text = "1"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(242, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(140, 169)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 52
        PictureBox2.TabStop = False
        ' 
        ' frmFundTransfer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(846, 562)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Name = "frmFundTransfer"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmFundTransfer"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtTargetAccount As TextBox
    Friend WithEvents txtAmountTransfer As TextBox
    Friend WithEvents btnTransfer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblEmptyy As Label
    Friend WithEvents lblDecimal As Label
    Friend WithEvents lblNo0 As Label
    Friend WithEvents lblNo9 As Label
    Friend WithEvents lblNo8 As Label
    Friend WithEvents lblNo7 As Label
    Friend WithEvents lblNo4 As Label
    Friend WithEvents lblNo5 As Label
    Friend WithEvents lblNo6 As Label
    Friend WithEvents lblNo3 As Label
    Friend WithEvents lblNo2 As Label
    Friend WithEvents lblNo1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblClear As Label
    Friend WithEvents lblDel As Label
    Friend WithEvents txtAccountName As TextBox
    Friend WithEvents Label2 As Label
End Class
