<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSignUp
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        txtLastName = New TextBox()
        lblLastName = New Label()
        txtMiddleName = New TextBox()
        lblMiddleName = New Label()
        lblFirstName = New Label()
        txtFirstName = New TextBox()
        Button1 = New Button()
        btnBackground = New Button()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ATM_UI_UX___南街_西洋菜
        PictureBox1.Location = New Point(-3, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(785, 559)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(txtLastName)
        Panel2.Controls.Add(lblLastName)
        Panel2.Controls.Add(txtMiddleName)
        Panel2.Controls.Add(lblMiddleName)
        Panel2.Controls.Add(lblFirstName)
        Panel2.Controls.Add(txtFirstName)
        Panel2.Location = New Point(123, 141)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(534, 283)
        Panel2.TabIndex = 12
        ' 
        ' txtLastName
        ' 
        txtLastName.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtLastName.ForeColor = Color.Black
        txtLastName.Location = New Point(40, 138)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(192, 23)
        txtLastName.TabIndex = 5
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLastName.Location = New Point(15, 118)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(80, 15)
        lblLastName.TabIndex = 4
        lblLastName.Text = "Last Name:"
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtMiddleName.ForeColor = Color.Black
        txtMiddleName.Location = New Point(40, 88)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(192, 23)
        txtMiddleName.TabIndex = 3
        ' 
        ' lblMiddleName
        ' 
        lblMiddleName.AutoSize = True
        lblMiddleName.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMiddleName.Location = New Point(15, 68)
        lblMiddleName.Name = "lblMiddleName"
        lblMiddleName.Size = New Size(95, 15)
        lblMiddleName.TabIndex = 2
        lblMiddleName.Text = "Middle Name:"
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFirstName.Location = New Point(15, 20)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(82, 15)
        lblFirstName.TabIndex = 1
        lblFirstName.Text = "First Name:"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFirstName.ForeColor = Color.Black
        txtFirstName.Location = New Point(40, 39)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(192, 23)
        txtFirstName.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(79, 223)
        Button1.Name = "Button1"
        Button1.Size = New Size(621, 271)
        Button1.TabIndex = 12
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnBackground
        ' 
        btnBackground.BackColor = Color.DarkSlateGray
        btnBackground.FlatStyle = FlatStyle.Flat
        btnBackground.ForeColor = Color.DarkSlateGray
        btnBackground.Location = New Point(79, 55)
        btnBackground.Name = "btnBackground"
        btnBackground.Size = New Size(621, 228)
        btnBackground.TabIndex = 13
        btnBackground.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DarkSlateGray
        Label1.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(324, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 32)
        Label1.TabIndex = 1
        Label1.Text = "SignUp"
        ' 
        ' frmSignUp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(779, 558)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(btnBackground)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Name = "frmSignUp"
        Text = "frmSignUp"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnBackground As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtMiddleName As TextBox
End Class
