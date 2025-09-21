<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVerification))
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        btnCancel = New Button()
        btnEnter = New Button()
        PictureBox2 = New PictureBox()
        txtPIN = New TextBox()
        Label1 = New Label()
        Button1 = New Button()
        Panel1 = New Panel()
        Label4 = New Label()
        btnDell = New Label()
        btnClear = New Label()
        Button2 = New Button()
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
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ATM_UI_UX___南街_西洋菜
        PictureBox1.Location = New Point(-5, -4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(852, 566)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnCancel)
        Panel2.Controls.Add(btnEnter)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(txtPIN)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Button1)
        Panel2.Location = New Point(83, 49)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(672, 450)
        Panel2.TabIndex = 10
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Brown
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(330, 226)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(200, 35)
        btnCancel.TabIndex = 46
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnEnter
        ' 
        btnEnter.BackColor = Color.DarkSlateGray
        btnEnter.FlatStyle = FlatStyle.Flat
        btnEnter.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEnter.ForeColor = Color.White
        btnEnter.Location = New Point(124, 226)
        btnEnter.Name = "btnEnter"
        btnEnter.Size = New Size(200, 35)
        btnEnter.TabIndex = 1
        btnEnter.Text = "Enter"
        btnEnter.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.Window
        PictureBox2.Image = My.Resources.Resources.Security_Green_Icon_removebg_preview
        PictureBox2.Location = New Point(414, 177)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(21, 22)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 45
        PictureBox2.TabStop = False
        ' 
        ' txtPIN
        ' 
        txtPIN.Font = New Font("Lucida Fax", 11.25F, FontStyle.Bold)
        txtPIN.Location = New Point(225, 176)
        txtPIN.Name = "txtPIN"
        txtPIN.PasswordChar = "*"c
        txtPIN.Size = New Size(212, 25)
        txtPIN.TabIndex = 0
        txtPIN.UseSystemPasswordChar = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(254, 127)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 25)
        Label1.TabIndex = 43
        Label1.Text = "Enter your PIN:"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkSlateGray
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(-11, 16)
        Button1.Name = "Button1"
        Button1.Size = New Size(717, 51)
        Button1.TabIndex = 42
        Button1.Text = "   Pin Verification"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkGray
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(btnDell)
        Panel1.Controls.Add(btnClear)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(btnClickDel)
        Panel1.Controls.Add(btnClickClear)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(lblEmpty)
        Panel1.Controls.Add(btnZero)
        Panel1.Controls.Add(btnNine)
        Panel1.Controls.Add(btnEight)
        Panel1.Controls.Add(btnSeven)
        Panel1.Controls.Add(btnFour)
        Panel1.Controls.Add(btnFive)
        Panel1.Controls.Add(btnSix)
        Panel1.Controls.Add(btnThree)
        Panel1.Controls.Add(btnTwo)
        Panel1.Controls.Add(btnOne)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Location = New Point(83, 333)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(672, 166)
        Panel1.TabIndex = 68
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.WhiteSmoke
        Label4.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label4.Location = New Point(249, 133)
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
        btnDell.Location = New Point(391, 54)
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
        btnClear.Location = New Point(391, 12)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(65, 18)
        btnClear.TabIndex = 43
        btnClear.Text = "CLEAR"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.WhiteSmoke
        Button2.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button2.Location = New Point(385, 125)
        Button2.Name = "Button2"
        Button2.Size = New Size(76, 38)
        Button2.TabIndex = 69
        Button2.Text = " "
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.WhiteSmoke
        Button5.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button5.Location = New Point(385, 86)
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
        btnClickDel.Location = New Point(385, 44)
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
        btnClickClear.Location = New Point(385, 3)
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
        Label7.Location = New Point(341, 135)
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
        lblEmpty.Location = New Point(259, 135)
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
        btnZero.Location = New Point(301, 132)
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
        btnNine.Location = New Point(348, 91)
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
        btnEight.Location = New Point(301, 91)
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
        btnSeven.Location = New Point(254, 91)
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
        btnFour.Location = New Point(254, 51)
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
        btnFive.Location = New Point(301, 51)
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
        btnSix.Location = New Point(348, 51)
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
        btnThree.Location = New Point(347, 10)
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
        btnTwo.Location = New Point(301, 10)
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
        btnOne.Location = New Point(254, 10)
        btnOne.Name = "btnOne"
        btnOne.Size = New Size(22, 24)
        btnOne.TabIndex = 35
        btnOne.Text = "1"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(241, 1)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(140, 165)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 52
        PictureBox3.TabStop = False
        ' 
        ' frmVerification
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(846, 562)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(PictureBox1)
        Name = "frmVerification"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmVerification"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtPIN As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDell As Label
    Friend WithEvents btnClear As Label
    Friend WithEvents Button2 As Button
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
