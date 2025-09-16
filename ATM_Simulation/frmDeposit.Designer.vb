<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDeposit
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer  
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeposit))
        Label1 = New Label()
        txtDepositAmount = New TextBox()
        btnDeposit = New Button()
        btnCancel = New Button()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Panel1 = New Panel()
        lblDecimal = New Label()
        lblDel = New Label()
        btnClear = New Label()
        Button3 = New Button()
        Button2 = New Button()
        btnClickDel = New Button()
        btnClickClear = New Button()
        lblEmptyy = New Label()
        lblEmpty = New Label()
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
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(52), CByte(58), CByte(64))
        Label1.Location = New Point(254, 103)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 23)
        Label1.TabIndex = 1
        Label1.Text = "Deposit Amount:"
        ' 
        ' txtDepositAmount
        ' 
        txtDepositAmount.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDepositAmount.Location = New Point(232, 145)
        txtDepositAmount.Name = "txtDepositAmount"
        txtDepositAmount.Size = New Size(200, 29)
        txtDepositAmount.TabIndex = 2
        txtDepositAmount.Text = " "
        ' 
        ' btnDeposit
        ' 
        btnDeposit.BackColor = Color.DarkSlateGray
        btnDeposit.FlatAppearance.BorderSize = 0
        btnDeposit.FlatStyle = FlatStyle.Flat
        btnDeposit.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnDeposit.ForeColor = Color.White
        btnDeposit.Location = New Point(146, 198)
        btnDeposit.Name = "btnDeposit"
        btnDeposit.Size = New Size(178, 35)
        btnDeposit.TabIndex = 3
        btnDeposit.Text = "Deposit"
        btnDeposit.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Brown
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(330, 198)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(178, 35)
        btnCancel.TabIndex = 4
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ATM_UI_UX___南街_西洋菜
        PictureBox1.Location = New Point(0, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(817, 527)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 41
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel1)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(txtDepositAmount)
        Panel2.Controls.Add(btnDeposit)
        Panel2.Controls.Add(btnCancel)
        Panel2.Location = New Point(84, 56)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(648, 410)
        Panel2.TabIndex = 42
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkGray
        Panel1.Controls.Add(lblDecimal)
        Panel1.Controls.Add(lblDel)
        Panel1.Controls.Add(btnClear)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(btnClickDel)
        Panel1.Controls.Add(btnClickClear)
        Panel1.Controls.Add(lblEmptyy)
        Panel1.Controls.Add(lblEmpty)
        Panel1.Controls.Add(lblNo0)
        Panel1.Controls.Add(lblNo9)
        Panel1.Controls.Add(lblNo8)
        Panel1.Controls.Add(lblNo7)
        Panel1.Controls.Add(lblNo4)
        Panel1.Controls.Add(lblNo5)
        Panel1.Controls.Add(lblNo6)
        Panel1.Controls.Add(lblNo3)
        Panel1.Controls.Add(lblNo2)
        Panel1.Controls.Add(lblNo1)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(0, 244)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(648, 166)
        Panel1.TabIndex = 66
        ' 
        ' lblDecimal
        ' 
        lblDecimal.AutoSize = True
        lblDecimal.BackColor = Color.WhiteSmoke
        lblDecimal.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDecimal.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblDecimal.Location = New Point(241, 137)
        lblDecimal.Name = "lblDecimal"
        lblDecimal.Size = New Size(31, 22)
        lblDecimal.TabIndex = 67
        lblDecimal.Text = "  . "
        ' 
        ' lblDel
        ' 
        lblDel.AutoSize = True
        lblDel.BackColor = Color.DarkKhaki
        lblDel.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblDel.Location = New Point(382, 53)
        lblDel.Name = "lblDel"
        lblDel.Size = New Size(65, 18)
        lblDel.TabIndex = 70
        lblDel.Text = "   DEL   "
        ' 
        ' btnClear
        ' 
        btnClear.AutoSize = True
        btnClear.BackColor = Color.Yellow
        btnClear.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnClear.Location = New Point(382, 11)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(65, 18)
        btnClear.TabIndex = 43
        btnClear.Text = "CLEAR"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.WhiteSmoke
        Button3.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button3.Location = New Point(376, 125)
        Button3.Name = "Button3"
        Button3.Size = New Size(76, 38)
        Button3.TabIndex = 69
        Button3.Text = " "
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.WhiteSmoke
        Button2.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button2.Location = New Point(376, 85)
        Button2.Name = "Button2"
        Button2.Size = New Size(76, 38)
        Button2.TabIndex = 68
        Button2.Text = " "
        Button2.UseVisualStyleBackColor = False
        ' 
        ' btnClickDel
        ' 
        btnClickDel.BackColor = Color.DarkKhaki
        btnClickDel.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClickDel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnClickDel.Location = New Point(376, 43)
        btnClickDel.Name = "btnClickDel"
        btnClickDel.Size = New Size(76, 38)
        btnClickDel.TabIndex = 67
        btnClickDel.Text = "DEL"
        btnClickDel.UseVisualStyleBackColor = False
        ' 
        ' btnClickClear
        ' 
        btnClickClear.BackColor = Color.Yellow
        btnClickClear.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClickClear.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnClickClear.Location = New Point(376, 2)
        btnClickClear.Name = "btnClickClear"
        btnClickClear.Size = New Size(76, 38)
        btnClickClear.TabIndex = 66
        btnClickClear.Text = "CLEAR"
        btnClickClear.UseVisualStyleBackColor = False
        ' 
        ' lblEmptyy
        ' 
        lblEmptyy.AutoSize = True
        lblEmptyy.BackColor = Color.WhiteSmoke
        lblEmptyy.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmptyy.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblEmptyy.Location = New Point(332, 134)
        lblEmptyy.Name = "lblEmptyy"
        lblEmptyy.Size = New Size(20, 22)
        lblEmptyy.TabIndex = 63
        lblEmptyy.Text = "  "
        ' 
        ' lblEmpty
        ' 
        lblEmpty.AutoSize = True
        lblEmpty.BackColor = Color.WhiteSmoke
        lblEmpty.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmpty.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblEmpty.Location = New Point(250, 134)
        lblEmpty.Name = "lblEmpty"
        lblEmpty.Size = New Size(20, 22)
        lblEmpty.TabIndex = 62
        lblEmpty.Text = "  "
        ' 
        ' lblNo0
        ' 
        lblNo0.AutoSize = True
        lblNo0.BackColor = Color.WhiteSmoke
        lblNo0.Font = New Font("Arial Rounded MT Bold", 15.75F)
        lblNo0.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblNo0.Location = New Point(292, 134)
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
        lblNo9.Location = New Point(339, 92)
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
        lblNo8.Location = New Point(292, 92)
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
        lblNo7.Location = New Point(245, 92)
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
        lblNo4.Location = New Point(245, 51)
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
        lblNo5.Location = New Point(292, 51)
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
        lblNo6.Location = New Point(338, 51)
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
        lblNo3.Location = New Point(338, 9)
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
        lblNo2.Location = New Point(292, 9)
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
        lblNo1.Location = New Point(245, 9)
        lblNo1.Name = "lblNo1"
        lblNo1.Size = New Size(22, 24)
        lblNo1.TabIndex = 35
        lblNo1.Text = "1"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(232, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(140, 169)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 52
        PictureBox2.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkSlateGray
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(-15, 18)
        Button1.Name = "Button1"
        Button1.Size = New Size(674, 51)
        Button1.TabIndex = 41
        Button1.Text = "   Deposit"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' frmDeposit
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Snow
        ClientSize = New Size(815, 523)
        Controls.Add(Panel2)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmDeposit"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Deposit"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDepositAmount As TextBox
    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblClear As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblEmptyy As Label
    Friend WithEvents lblEmpty As Label
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
    Friend WithEvents btnClickClear As Button
    Friend WithEvents btnClickDel As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnClear As Label
    Friend WithEvents lblDel As Label
    Friend WithEvents lblDecimal As Label

End Class
