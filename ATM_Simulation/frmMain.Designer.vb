<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        TextBox1 = New TextBox()
        btnLogout = New Button()
        btnBalanceInquiry = New Button()
        btnDeposit = New Button()
        btnWithdrawal = New Button()
        btnMiniStatement = New Button()
        btnFundTransfer = New Button()
        TextBox2 = New TextBox()
        lblUserAccountNumber = New Label()
        Panel1 = New Panel()
        Panel3 = New Panel()
        lblDateTime = New Label()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        lblUser = New Label()
        lblAccountNumberDisplay = New Label()
        lbl = New Label()
        timer1 = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ATM_UI_UX___南街_西洋菜
        PictureBox1.Location = New Point(0, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(818, 529)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(btnLogout)
        Panel2.Controls.Add(btnBalanceInquiry)
        Panel2.Controls.Add(btnDeposit)
        Panel2.Controls.Add(btnWithdrawal)
        Panel2.Controls.Add(btnMiniStatement)
        Panel2.Controls.Add(btnFundTransfer)
        Panel2.Location = New Point(54, 130)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(550, 263)
        Panel2.TabIndex = 8
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(14, -17)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(128, 20)
        TextBox1.TabIndex = 10
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Brown
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(298, 180)
        btnLogout.Margin = New Padding(3, 4, 3, 4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(232, 51)
        btnLogout.TabIndex = 5
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnBalanceInquiry
        ' 
        btnBalanceInquiry.BackColor = Color.DarkSlateGray
        btnBalanceInquiry.FlatAppearance.BorderSize = 0
        btnBalanceInquiry.FlatStyle = FlatStyle.Flat
        btnBalanceInquiry.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBalanceInquiry.ForeColor = Color.White
        btnBalanceInquiry.Location = New Point(14, 28)
        btnBalanceInquiry.Margin = New Padding(3, 4, 3, 4)
        btnBalanceInquiry.Name = "btnBalanceInquiry"
        btnBalanceInquiry.Size = New Size(232, 51)
        btnBalanceInquiry.TabIndex = 0
        btnBalanceInquiry.Text = "Balance Inquiry"
        btnBalanceInquiry.UseVisualStyleBackColor = False
        ' 
        ' btnDeposit
        ' 
        btnDeposit.BackColor = Color.DarkSlateGray
        btnDeposit.FlatAppearance.BorderSize = 0
        btnDeposit.FlatStyle = FlatStyle.Flat
        btnDeposit.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDeposit.ForeColor = Color.White
        btnDeposit.Location = New Point(298, 28)
        btnDeposit.Margin = New Padding(3, 4, 3, 4)
        btnDeposit.Name = "btnDeposit"
        btnDeposit.Size = New Size(232, 51)
        btnDeposit.TabIndex = 3
        btnDeposit.Text = "Deposit"
        btnDeposit.UseVisualStyleBackColor = False
        ' 
        ' btnWithdrawal
        ' 
        btnWithdrawal.BackColor = Color.DarkSlateGray
        btnWithdrawal.FlatAppearance.BorderSize = 0
        btnWithdrawal.FlatStyle = FlatStyle.Flat
        btnWithdrawal.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnWithdrawal.ForeColor = Color.White
        btnWithdrawal.Location = New Point(14, 104)
        btnWithdrawal.Margin = New Padding(3, 4, 3, 4)
        btnWithdrawal.Name = "btnWithdrawal"
        btnWithdrawal.Size = New Size(232, 51)
        btnWithdrawal.TabIndex = 1
        btnWithdrawal.Text = "Withdrawal"
        btnWithdrawal.UseVisualStyleBackColor = False
        ' 
        ' btnMiniStatement
        ' 
        btnMiniStatement.BackColor = Color.DarkSlateGray
        btnMiniStatement.FlatAppearance.BorderSize = 0
        btnMiniStatement.FlatStyle = FlatStyle.Flat
        btnMiniStatement.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMiniStatement.ForeColor = Color.White
        btnMiniStatement.Location = New Point(14, 180)
        btnMiniStatement.Margin = New Padding(3, 4, 3, 4)
        btnMiniStatement.Name = "btnMiniStatement"
        btnMiniStatement.Size = New Size(232, 51)
        btnMiniStatement.TabIndex = 2
        btnMiniStatement.Text = "Mini Statement"
        btnMiniStatement.UseVisualStyleBackColor = False
        ' 
        ' btnFundTransfer
        ' 
        btnFundTransfer.BackColor = Color.DarkSlateGray
        btnFundTransfer.FlatAppearance.BorderSize = 0
        btnFundTransfer.FlatStyle = FlatStyle.Flat
        btnFundTransfer.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnFundTransfer.ForeColor = Color.White
        btnFundTransfer.Location = New Point(298, 104)
        btnFundTransfer.Margin = New Padding(3, 4, 3, 4)
        btnFundTransfer.Name = "btnFundTransfer"
        btnFundTransfer.Size = New Size(232, 51)
        btnFundTransfer.TabIndex = 4
        btnFundTransfer.Text = "Fund Transfer"
        btnFundTransfer.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.White
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Location = New Point(263, 115)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(118, 20)
        TextBox2.TabIndex = 11
        TextBox2.Text = "    Transaction"
        ' 
        ' lblUserAccountNumber
        ' 
        lblUserAccountNumber.AutoSize = True
        lblUserAccountNumber.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUserAccountNumber.Location = New Point(310, 385)
        lblUserAccountNumber.Name = "lblUserAccountNumber"
        lblUserAccountNumber.Size = New Size(15, 23)
        lblUserAccountNumber.TabIndex = 15
        lblUserAccountNumber.Text = " "
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(lblUserAccountNumber)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(82, 54)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(648, 408)
        Panel1.TabIndex = 7
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkSlateGray
        Panel3.Controls.Add(lblDateTime)
        Panel3.Controls.Add(PictureBox5)
        Panel3.Controls.Add(PictureBox4)
        Panel3.Controls.Add(lblUser)
        Panel3.Controls.Add(lblAccountNumberDisplay)
        Panel3.Controls.Add(lbl)
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(648, 63)
        Panel3.TabIndex = 16
        ' 
        ' lblDateTime
        ' 
        lblDateTime.AutoSize = True
        lblDateTime.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDateTime.ForeColor = Color.White
        lblDateTime.Location = New Point(423, 5)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(11, 15)
        lblDateTime.TabIndex = 17
        lblDateTime.Text = "-"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(77, 38)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(33, 25)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 20
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(-9, -9)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(83, 85)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 20
        PictureBox4.TabStop = False
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.BackColor = Color.Transparent
        lblUser.Font = New Font("Century Schoolbook", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUser.ForeColor = Color.White
        lblUser.Location = New Point(76, 9)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(18, 25)
        lblUser.TabIndex = 13
        lblUser.Text = " "
        ' 
        ' lblAccountNumberDisplay
        ' 
        lblAccountNumberDisplay.AutoSize = True
        lblAccountNumberDisplay.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        lblAccountNumberDisplay.ForeColor = Color.White
        lblAccountNumberDisplay.Location = New Point(229, 42)
        lblAccountNumberDisplay.Name = "lblAccountNumberDisplay"
        lblAccountNumberDisplay.Size = New Size(11, 16)
        lblAccountNumberDisplay.TabIndex = 16
        lblAccountNumberDisplay.Text = " "
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        lbl.ForeColor = Color.White
        lbl.Location = New Point(106, 42)
        lbl.Name = "lbl"
        lbl.Size = New Size(125, 16)
        lbl.TabIndex = 14
        lbl.Text = "Account Number: "
        ' 
        ' timer1
        ' 
        timer1.Interval = 1000
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AntiqueWhite
        ClientSize = New Size(815, 523)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Banking Operations"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnBalanceInquiry As Button
    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnWithdrawal As Button
    Friend WithEvents btnMiniStatement As Button
    Friend WithEvents btnFundTransfer As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblUserAccountNumber As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents timer1 As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl As Label
    Friend WithEvents lblAccountNumberDisplay As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lblDateTime As Label

End Class
