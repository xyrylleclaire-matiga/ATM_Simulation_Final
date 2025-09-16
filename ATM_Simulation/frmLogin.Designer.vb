<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Label1 = New Label()
        Label2 = New Label()
        txtAccNum = New TextBox()
        txtPIN = New TextBox()
        btnLogin = New Button()
        Panel1 = New Panel()
        lblCancel = New Label()
        lblEmptyy = New Label()
        lblEnter = New Label()
        lblDel = New Label()
        Label3 = New Label()
        lblClear = New Label()
        lblNo0 = New Label()
        Button3 = New Button()
        lblNo9 = New Label()
        Button4 = New Button()
        lblNo8 = New Label()
        Button1 = New Button()
        lblNo7 = New Label()
        btnClickClear = New Button()
        lblNo4 = New Label()
        lblNo5 = New Label()
        lblNo6 = New Label()
        lblNo3 = New Label()
        lblNo2 = New Label()
        lblNo1 = New Label()
        PictureBox5 = New PictureBox()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        lblAttempts = New Label()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        Label4 = New Label()
        PictureBox2 = New PictureBox()
        lblRole = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(133, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 19)
        Label1.TabIndex = 0
        Label1.Text = "Account Number:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(134, 140)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 19)
        Label2.TabIndex = 1
        Label2.Text = "PIN:"
        ' 
        ' txtAccNum
        ' 
        txtAccNum.Font = New Font("Lucida Fax", 11.25F, FontStyle.Bold)
        txtAccNum.Location = New Point(293, 90)
        txtAccNum.Name = "txtAccNum"
        txtAccNum.Size = New Size(200, 25)
        txtAccNum.TabIndex = 2
        ' 
        ' txtPIN
        ' 
        txtPIN.Font = New Font("Lucida Fax", 11.25F, FontStyle.Bold)
        txtPIN.Location = New Point(293, 140)
        txtPIN.Name = "txtPIN"
        txtPIN.PasswordChar = "*"c
        txtPIN.Size = New Size(200, 25)
        txtPIN.TabIndex = 3
        txtPIN.UseSystemPasswordChar = True
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.DarkSlateGray
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(293, 186)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(200, 35)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(lblCancel)
        Panel1.Controls.Add(lblEmptyy)
        Panel1.Controls.Add(lblEnter)
        Panel1.Controls.Add(lblDel)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(lblClear)
        Panel1.Controls.Add(lblNo0)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(lblNo9)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(lblNo8)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(lblNo7)
        Panel1.Controls.Add(btnClickClear)
        Panel1.Controls.Add(lblNo4)
        Panel1.Controls.Add(lblNo5)
        Panel1.Controls.Add(lblNo6)
        Panel1.Controls.Add(lblNo3)
        Panel1.Controls.Add(lblNo2)
        Panel1.Controls.Add(lblNo1)
        Panel1.Controls.Add(PictureBox5)
        Panel1.Location = New Point(0, 227)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(620, 172)
        Panel1.TabIndex = 8
        ' 
        ' lblCancel
        ' 
        lblCancel.AutoSize = True
        lblCancel.BackColor = Color.Brown
        lblCancel.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCancel.ForeColor = Color.White
        lblCancel.Location = New Point(328, 139)
        lblCancel.Name = "lblCancel"
        lblCancel.Size = New Size(97, 18)
        lblCancel.TabIndex = 81
        lblCancel.Text = "  CANCEL   "
        ' 
        ' lblEmptyy
        ' 
        lblEmptyy.AutoSize = True
        lblEmptyy.BackColor = Color.WhiteSmoke
        lblEmptyy.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmptyy.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblEmptyy.Location = New Point(278, 135)
        lblEmptyy.Name = "lblEmptyy"
        lblEmptyy.Size = New Size(20, 22)
        lblEmptyy.TabIndex = 87
        lblEmptyy.Text = "  "
        ' 
        ' lblEnter
        ' 
        lblEnter.AutoSize = True
        lblEnter.BackColor = Color.ForestGreen
        lblEnter.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEnter.ForeColor = Color.White
        lblEnter.Location = New Point(324, 16)
        lblEnter.Name = "lblEnter"
        lblEnter.Size = New Size(96, 18)
        lblEnter.TabIndex = 80
        lblEnter.Text = "      ENTER  "
        ' 
        ' lblDel
        ' 
        lblDel.AutoSize = True
        lblDel.BackColor = Color.DarkKhaki
        lblDel.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblDel.Location = New Point(327, 58)
        lblDel.Name = "lblDel"
        lblDel.Size = New Size(101, 18)
        lblDel.TabIndex = 79
        lblDel.Text = "        DEL       "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.WhiteSmoke
        Label3.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Location = New Point(196, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(20, 22)
        Label3.TabIndex = 86
        Label3.Text = "  "
        ' 
        ' lblClear
        ' 
        lblClear.AutoSize = True
        lblClear.BackColor = Color.Yellow
        lblClear.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblClear.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblClear.Location = New Point(324, 99)
        lblClear.Name = "lblClear"
        lblClear.Size = New Size(109, 18)
        lblClear.TabIndex = 74
        lblClear.Text = "      CLEAR     "
        ' 
        ' lblNo0
        ' 
        lblNo0.AutoSize = True
        lblNo0.BackColor = Color.WhiteSmoke
        lblNo0.Font = New Font("Arial Rounded MT Bold", 15.75F)
        lblNo0.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo0.Location = New Point(237, 135)
        lblNo0.Name = "lblNo0"
        lblNo0.Size = New Size(22, 24)
        lblNo0.TabIndex = 85
        lblNo0.Text = "0"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Brown
        Button3.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button3.Location = New Point(320, 130)
        Button3.Name = "Button3"
        Button3.Size = New Size(116, 38)
        Button3.TabIndex = 78
        Button3.Text = " "
        Button3.UseVisualStyleBackColor = False
        ' 
        ' lblNo9
        ' 
        lblNo9.AutoSize = True
        lblNo9.BackColor = Color.WhiteSmoke
        lblNo9.Font = New Font("Arial Rounded MT Bold", 15.75F)
        lblNo9.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo9.Location = New Point(284, 93)
        lblNo9.Name = "lblNo9"
        lblNo9.Size = New Size(22, 24)
        lblNo9.TabIndex = 84
        lblNo9.Text = "9"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.ForestGreen
        Button4.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button4.Location = New Point(320, 7)
        Button4.Name = "Button4"
        Button4.Size = New Size(116, 38)
        Button4.TabIndex = 77
        Button4.Text = " "
        Button4.UseVisualStyleBackColor = False
        ' 
        ' lblNo8
        ' 
        lblNo8.AutoSize = True
        lblNo8.BackColor = Color.WhiteSmoke
        lblNo8.Font = New Font("Arial Rounded MT Bold", 15.75F)
        lblNo8.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo8.Location = New Point(238, 93)
        lblNo8.Name = "lblNo8"
        lblNo8.Size = New Size(22, 24)
        lblNo8.TabIndex = 83
        lblNo8.Text = "8"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkKhaki
        Button1.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.Location = New Point(320, 48)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 38)
        Button1.TabIndex = 76
        Button1.Text = "DEL"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' lblNo7
        ' 
        lblNo7.AutoSize = True
        lblNo7.BackColor = Color.WhiteSmoke
        lblNo7.Font = New Font("Arial Rounded MT Bold", 15.75F)
        lblNo7.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo7.Location = New Point(191, 93)
        lblNo7.Name = "lblNo7"
        lblNo7.Size = New Size(22, 24)
        lblNo7.TabIndex = 82
        lblNo7.Text = "7"
        ' 
        ' btnClickClear
        ' 
        btnClickClear.BackColor = Color.Yellow
        btnClickClear.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClickClear.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnClickClear.Location = New Point(320, 90)
        btnClickClear.Name = "btnClickClear"
        btnClickClear.Size = New Size(116, 38)
        btnClickClear.TabIndex = 75
        btnClickClear.Text = "CLEAR"
        btnClickClear.UseVisualStyleBackColor = False
        ' 
        ' lblNo4
        ' 
        lblNo4.AutoSize = True
        lblNo4.BackColor = Color.WhiteSmoke
        lblNo4.Font = New Font("Arial Rounded MT Bold", 15.75F)
        lblNo4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo4.Location = New Point(191, 52)
        lblNo4.Name = "lblNo4"
        lblNo4.Size = New Size(22, 24)
        lblNo4.TabIndex = 79
        lblNo4.Text = "4"
        ' 
        ' lblNo5
        ' 
        lblNo5.AutoSize = True
        lblNo5.BackColor = Color.WhiteSmoke
        lblNo5.Font = New Font("Arial Rounded MT Bold", 15.75F)
        lblNo5.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo5.Location = New Point(237, 52)
        lblNo5.Name = "lblNo5"
        lblNo5.Size = New Size(22, 24)
        lblNo5.TabIndex = 80
        lblNo5.Text = "5"
        ' 
        ' lblNo6
        ' 
        lblNo6.AutoSize = True
        lblNo6.BackColor = Color.WhiteSmoke
        lblNo6.Font = New Font("Arial Rounded MT Bold", 15.75F)
        lblNo6.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo6.Location = New Point(284, 52)
        lblNo6.Name = "lblNo6"
        lblNo6.Size = New Size(22, 24)
        lblNo6.TabIndex = 81
        lblNo6.Text = "6"
        ' 
        ' lblNo3
        ' 
        lblNo3.AutoSize = True
        lblNo3.BackColor = Color.WhiteSmoke
        lblNo3.Font = New Font("Arial Rounded MT Bold", 15.75F)
        lblNo3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo3.Location = New Point(284, 10)
        lblNo3.Name = "lblNo3"
        lblNo3.Size = New Size(22, 24)
        lblNo3.TabIndex = 78
        lblNo3.Text = "3"
        ' 
        ' lblNo2
        ' 
        lblNo2.AutoSize = True
        lblNo2.BackColor = Color.WhiteSmoke
        lblNo2.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNo2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo2.Location = New Point(237, 10)
        lblNo2.Name = "lblNo2"
        lblNo2.Size = New Size(22, 24)
        lblNo2.TabIndex = 77
        lblNo2.Text = "2"
        ' 
        ' lblNo1
        ' 
        lblNo1.AutoSize = True
        lblNo1.BackColor = Color.WhiteSmoke
        lblNo1.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNo1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo1.Location = New Point(191, 10)
        lblNo1.Name = "lblNo1"
        lblNo1.Size = New Size(22, 24)
        lblNo1.TabIndex = 74
        lblNo1.Text = "1"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(178, 1)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(140, 169)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 76
        PictureBox5.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ATM_UI_UX___南街_西洋菜
        PictureBox1.Location = New Point(0, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(769, 482)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.CornflowerBlue
        Panel2.Controls.Add(lblRole)
        Panel2.Controls.Add(lblAttempts)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(PictureBox4)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(btnLogin)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Panel1)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(txtAccNum)
        Panel2.Controls.Add(txtPIN)
        Panel2.Location = New Point(79, 53)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(604, 399)
        Panel2.TabIndex = 37
        ' 
        ' lblAttempts
        ' 
        lblAttempts.AutoSize = True
        lblAttempts.Location = New Point(580, 209)
        lblAttempts.Name = "lblAttempts"
        lblAttempts.Size = New Size(12, 15)
        lblAttempts.TabIndex = 15
        lblAttempts.Text = "-"
        lblAttempts.Visible = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.Window
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(471, 91)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(21, 22)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 14
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(-7, -8)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(103, 94)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(93, 20)
        Label4.Name = "Label4"
        Label4.Size = New Size(483, 37)
        Label4.TabIndex = 13
        Label4.Text = "Welcome to QUICKCASH ATM"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.Window
        PictureBox2.Image = My.Resources.Resources.Security_Green_Icon_removebg_preview
        PictureBox2.Location = New Point(471, 141)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(21, 22)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Location = New Point(499, 197)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(30, 15)
        lblRole.TabIndex = 16
        lblRole.Text = "Role"
        lblRole.Visible = False
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkOliveGreen
        ClientSize = New Size(765, 479)
        Controls.Add(Panel2)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ATM Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAccNum As TextBox
    Friend WithEvents txtPIN As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblEmptyy As Label
    Friend WithEvents Label3 As Label
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
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lblCancel As Label
    Friend WithEvents lblEnter As Label
    Friend WithEvents lblDel As Label
    Friend WithEvents lblClear As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnClickClear As Button
    Friend WithEvents lblAttempts As Label
    Friend WithEvents lblRole As Label
End Class
