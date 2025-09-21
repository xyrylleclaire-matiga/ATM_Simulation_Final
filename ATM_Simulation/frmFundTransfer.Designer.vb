<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFundTransfer
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
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFundTransfer))
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label4 = New Label()
        btnDell = New Label()
        btnClear = New Label()
        Button1 = New Button()
        Button5 = New Button()
        btnClickDel = New Button()
        btnClickClear = New Button()
        Label7 = New Label()
        lblEmpty = New Label()
        btnZero = New Label()
        btnNine = New Label()
        btnEight = New Label()
        btnSeven = New Label()
        btnFour = New Label()
        btnFive = New Label()
        btnSix = New Label()
        btnThree = New Label()
        btnTwo = New Label()
        btnOne = New Label()
        PictureBox3 = New PictureBox()
        txtAccountName = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        btnTransfer = New Button()
        txtAmountTransfer = New TextBox()
        txtTargetAccount = New TextBox()
        btnCancel = New Button()
        Button2 = New Button()
        lblDel = New Label()
        lblClear = New Label()
        Button3 = New Button()
        Button4 = New Button()
        btnDel = New Button()
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
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
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
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkGray
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(btnDell)
        Panel2.Controls.Add(btnClear)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Button5)
        Panel2.Controls.Add(btnClickDel)
        Panel2.Controls.Add(btnClickClear)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(lblEmpty)
        Panel2.Controls.Add(btnZero)
        Panel2.Controls.Add(btnNine)
        Panel2.Controls.Add(btnEight)
        Panel2.Controls.Add(btnSeven)
        Panel2.Controls.Add(btnFour)
        Panel2.Controls.Add(btnFive)
        Panel2.Controls.Add(btnSix)
        Panel2.Controls.Add(btnThree)
        Panel2.Controls.Add(btnTwo)
        Panel2.Controls.Add(btnOne)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Location = New Point(84, 333)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(675, 166)
        Panel2.TabIndex = 67
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.WhiteSmoke
        Label4.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label4.Location = New Point(220, 133)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 22)
        Label4.TabIndex = 67
        Label4.Text = "  . "
        ' 
        ' btnDell
        ' 
        btnDell.AutoSize = True
        btnDell.BackColor = Color.DarkKhaki
        btnDell.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDell.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnDell.Location = New Point(362, 54)
        btnDell.Name = "btnDell"
        btnDell.Size = New Size(65, 18)
        btnDell.TabIndex = 70
        btnDell.Text = "   DEL   "
        ' 
        ' btnClear
        ' 
        btnClear.AutoSize = True
        btnClear.BackColor = Color.Yellow
        btnClear.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnClear.Location = New Point(362, 12)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(65, 18)
        btnClear.TabIndex = 43
        btnClear.Text = "CLEAR"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.WhiteSmoke
        Button1.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.Location = New Point(356, 125)
        Button1.Name = "Button1"
        Button1.Size = New Size(76, 38)
        Button1.TabIndex = 69
        Button1.Text = " "
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.WhiteSmoke
        Button5.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button5.Location = New Point(356, 86)
        Button5.Name = "Button5"
        Button5.Size = New Size(76, 38)
        Button5.TabIndex = 68
        Button5.Text = " "
        Button5.UseVisualStyleBackColor = False
        ' 
        ' btnClickDel
        ' 
        btnClickDel.BackColor = Color.DarkKhaki
        btnClickDel.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClickDel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnClickDel.Location = New Point(356, 44)
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
        btnClickClear.Location = New Point(356, 3)
        btnClickClear.Name = "btnClickClear"
        btnClickClear.Size = New Size(76, 38)
        btnClickClear.TabIndex = 66
        btnClickClear.Text = "CLEAR"
        btnClickClear.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.WhiteSmoke
        Label7.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label7.Location = New Point(312, 135)
        Label7.Name = "Label7"
        Label7.Size = New Size(20, 22)
        Label7.TabIndex = 63
        Label7.Text = "  "
        ' 
        ' lblEmpty
        ' 
        lblEmpty.AutoSize = True
        lblEmpty.BackColor = Color.WhiteSmoke
        lblEmpty.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmpty.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblEmpty.Location = New Point(230, 135)
        lblEmpty.Name = "lblEmpty"
        lblEmpty.Size = New Size(20, 22)
        lblEmpty.TabIndex = 62
        lblEmpty.Text = "  "
        ' 
        ' btnZero
        ' 
        btnZero.AutoSize = True
        btnZero.BackColor = Color.WhiteSmoke
        btnZero.Font = New Font("Arial Rounded MT Bold", 15.75F)
        btnZero.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnZero.Location = New Point(272, 132)
        btnZero.Name = "btnZero"
        btnZero.Size = New Size(22, 24)
        btnZero.TabIndex = 61
        btnZero.Text = "0"
        ' 
        ' btnNine
        ' 
        btnNine.AutoSize = True
        btnNine.BackColor = Color.WhiteSmoke
        btnNine.Font = New Font("Arial Rounded MT Bold", 15.75F)
        btnNine.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnNine.Location = New Point(319, 91)
        btnNine.Name = "btnNine"
        btnNine.Size = New Size(22, 24)
        btnNine.TabIndex = 60
        btnNine.Text = "9"
        ' 
        ' btnEight
        ' 
        btnEight.AutoSize = True
        btnEight.BackColor = Color.WhiteSmoke
        btnEight.Font = New Font("Arial Rounded MT Bold", 15.75F)
        btnEight.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnEight.Location = New Point(272, 91)
        btnEight.Name = "btnEight"
        btnEight.Size = New Size(22, 24)
        btnEight.TabIndex = 59
        btnEight.Text = "8"
        ' 
        ' btnSeven
        ' 
        btnSeven.AutoSize = True
        btnSeven.BackColor = Color.WhiteSmoke
        btnSeven.Font = New Font("Arial Rounded MT Bold", 15.75F)
        btnSeven.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnSeven.Location = New Point(225, 91)
        btnSeven.Name = "btnSeven"
        btnSeven.Size = New Size(22, 24)
        btnSeven.TabIndex = 58
        btnSeven.Text = "7"
        ' 
        ' btnFour
        ' 
        btnFour.AutoSize = True
        btnFour.BackColor = Color.WhiteSmoke
        btnFour.Font = New Font("Arial Rounded MT Bold", 15.75F)
        btnFour.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnFour.Location = New Point(225, 50)
        btnFour.Name = "btnFour"
        btnFour.Size = New Size(22, 24)
        btnFour.TabIndex = 55
        btnFour.Text = "4"
        ' 
        ' btnFive
        ' 
        btnFive.AutoSize = True
        btnFive.BackColor = Color.WhiteSmoke
        btnFive.Font = New Font("Arial Rounded MT Bold", 15.75F)
        btnFive.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnFive.Location = New Point(272, 50)
        btnFive.Name = "btnFive"
        btnFive.Size = New Size(22, 24)
        btnFive.TabIndex = 56
        btnFive.Text = "5"
        ' 
        ' btnSix
        ' 
        btnSix.AutoSize = True
        btnSix.BackColor = Color.WhiteSmoke
        btnSix.Font = New Font("Arial Rounded MT Bold", 15.75F)
        btnSix.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnSix.Location = New Point(318, 50)
        btnSix.Name = "btnSix"
        btnSix.Size = New Size(22, 24)
        btnSix.TabIndex = 57
        btnSix.Text = "6"
        ' 
        ' btnThree
        ' 
        btnThree.AutoSize = True
        btnThree.BackColor = Color.WhiteSmoke
        btnThree.Font = New Font("Arial Rounded MT Bold", 15.75F)
        btnThree.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnThree.Location = New Point(318, 10)
        btnThree.Name = "btnThree"
        btnThree.Size = New Size(22, 24)
        btnThree.TabIndex = 54
        btnThree.Text = "3"
        ' 
        ' btnTwo
        ' 
        btnTwo.AutoSize = True
        btnTwo.BackColor = Color.WhiteSmoke
        btnTwo.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTwo.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnTwo.Location = New Point(272, 10)
        btnTwo.Name = "btnTwo"
        btnTwo.Size = New Size(22, 24)
        btnTwo.TabIndex = 53
        btnTwo.Text = "2"
        ' 
        ' btnOne
        ' 
        btnOne.AutoSize = True
        btnOne.BackColor = Color.WhiteSmoke
        btnOne.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnOne.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnOne.Location = New Point(225, 10)
        btnOne.Name = "btnOne"
        btnOne.Size = New Size(22, 24)
        btnOne.TabIndex = 35
        btnOne.Text = "1"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(212, 1)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(140, 165)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 52
        PictureBox3.TabStop = False
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
        ' lblDel
        ' 
        lblDel.Location = New Point(0, 0)
        lblDel.Name = "lblDel"
        lblDel.Size = New Size(100, 23)
        lblDel.TabIndex = 0
        ' 
        ' lblClear
        ' 
        lblClear.Location = New Point(0, 0)
        lblClear.Name = "lblClear"
        lblClear.Size = New Size(100, 23)
        lblClear.TabIndex = 0
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(0, 0)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 0
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(0, 0)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 0
        ' 
        ' btnDel
        ' 
        btnDel.Location = New Point(0, 0)
        btnDel.Name = "btnDel"
        btnDel.Size = New Size(75, 23)
        btnDel.TabIndex = 0
        ' 
        ' lblEmptyy
        ' 
        lblEmptyy.Location = New Point(0, 0)
        lblEmptyy.Name = "lblEmptyy"
        lblEmptyy.Size = New Size(100, 23)
        lblEmptyy.TabIndex = 0
        ' 
        ' lblDecimal
        ' 
        lblDecimal.Location = New Point(0, 0)
        lblDecimal.Name = "lblDecimal"
        lblDecimal.Size = New Size(100, 23)
        lblDecimal.TabIndex = 0
        ' 
        ' lblNo0
        ' 
        lblNo0.Location = New Point(0, 0)
        lblNo0.Name = "lblNo0"
        lblNo0.Size = New Size(100, 23)
        lblNo0.TabIndex = 0
        ' 
        ' lblNo9
        ' 
        lblNo9.Location = New Point(0, 0)
        lblNo9.Name = "lblNo9"
        lblNo9.Size = New Size(100, 23)
        lblNo9.TabIndex = 0
        ' 
        ' lblNo8
        ' 
        lblNo8.Location = New Point(0, 0)
        lblNo8.Name = "lblNo8"
        lblNo8.Size = New Size(100, 23)
        lblNo8.TabIndex = 0
        ' 
        ' lblNo7
        ' 
        lblNo7.Location = New Point(0, 0)
        lblNo7.Name = "lblNo7"
        lblNo7.Size = New Size(100, 23)
        lblNo7.TabIndex = 0
        ' 
        ' lblNo4
        ' 
        lblNo4.Location = New Point(0, 0)
        lblNo4.Name = "lblNo4"
        lblNo4.Size = New Size(100, 23)
        lblNo4.TabIndex = 0
        ' 
        ' lblNo5
        ' 
        lblNo5.Location = New Point(0, 0)
        lblNo5.Name = "lblNo5"
        lblNo5.Size = New Size(100, 23)
        lblNo5.TabIndex = 0
        ' 
        ' lblNo6
        ' 
        lblNo6.Location = New Point(0, 0)
        lblNo6.Name = "lblNo6"
        lblNo6.Size = New Size(100, 23)
        lblNo6.TabIndex = 0
        ' 
        ' lblNo3
        ' 
        lblNo3.Location = New Point(0, 0)
        lblNo3.Name = "lblNo3"
        lblNo3.Size = New Size(100, 23)
        lblNo3.TabIndex = 0
        ' 
        ' lblNo2
        ' 
        lblNo2.Location = New Point(0, 0)
        lblNo2.Name = "lblNo2"
        lblNo2.Size = New Size(100, 23)
        lblNo2.TabIndex = 0
        ' 
        ' lblNo1
        ' 
        lblNo1.Location = New Point(0, 0)
        lblNo1.Name = "lblNo1"
        lblNo1.Size = New Size(100, 23)
        lblNo1.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(100, 50)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.UseAntiAlias = True
        PrintPreviewDialog1.Visible = False
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
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnDel As Button
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
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDell As Label
    Friend WithEvents btnClear As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btnClickDel As Button
    Friend WithEvents btnClickClear As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lblEmpty As Label
    Friend WithEvents btnZero As Label
    Friend WithEvents btnNine As Label
    Friend WithEvents btnEight As Label
    Friend WithEvents btnSeven As Label
    Friend WithEvents btnFour As Label
    Friend WithEvents btnFive As Label
    Friend WithEvents btnSix As Label
    Friend WithEvents btnThree As Label
    Friend WithEvents btnTwo As Label
    Friend WithEvents btnOne As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
