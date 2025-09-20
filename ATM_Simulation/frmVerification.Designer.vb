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
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        btnCancel = New Button()
        btnEnter = New Button()
        PictureBox2 = New PictureBox()
        txtPIN = New TextBox()
        Label1 = New Label()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ATM_UI_UX___南街_西洋菜
        PictureBox1.Location = New Point(-5, -4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(804, 454)
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
        Panel2.Size = New Size(629, 346)
        Panel2.TabIndex = 12
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Firebrick
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(306, 206)
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
        btnEnter.Location = New Point(100, 206)
        btnEnter.Name = "btnEnter"
        btnEnter.Size = New Size(200, 35)
        btnEnter.TabIndex = 13
        btnEnter.Text = "Enter"
        btnEnter.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.Window
        PictureBox2.Image = My.Resources.Resources.Security_Green_Icon_removebg_preview
        PictureBox2.Location = New Point(405, 162)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(21, 22)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 45
        PictureBox2.TabStop = False
        ' 
        ' txtPIN
        ' 
        txtPIN.Font = New Font("Lucida Fax", 11.25F, FontStyle.Bold)
        txtPIN.Location = New Point(214, 162)
        txtPIN.Name = "txtPIN"
        txtPIN.PasswordChar = "*"c
        txtPIN.Size = New Size(212, 25)
        txtPIN.TabIndex = 44
        txtPIN.UseSystemPasswordChar = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(237, 118)
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
        Button1.Size = New Size(674, 51)
        Button1.TabIndex = 42
        Button1.Text = "   Pin Verification"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' frmVerification
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel2)
        Controls.Add(PictureBox1)
        Name = "frmVerification"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmVerification"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
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
End Class
