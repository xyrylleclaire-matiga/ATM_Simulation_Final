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
        btnSignUp = New Button()
        Label3 = New Label()
        txtEmailAdd = New TextBox()
        Label2 = New Label()
        txtContactNumber = New TextBox()
        txtLastName = New TextBox()
        lblLastName = New Label()
        txtMiddleName = New TextBox()
        lblMiddleName = New Label()
        lblFirstName = New Label()
        txtFirstName = New TextBox()
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
        PictureBox1.Size = New Size(803, 584)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(btnSignUp)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(txtEmailAdd)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(txtContactNumber)
        Panel2.Controls.Add(txtLastName)
        Panel2.Controls.Add(lblLastName)
        Panel2.Controls.Add(txtMiddleName)
        Panel2.Controls.Add(lblMiddleName)
        Panel2.Controls.Add(lblFirstName)
        Panel2.Controls.Add(txtFirstName)
        Panel2.Location = New Point(258, 114)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(297, 383)
        Panel2.TabIndex = 12
        ' 
        ' btnSignUp
        ' 
        btnSignUp.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSignUp.Location = New Point(89, 329)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(118, 41)
        btnSignUp.TabIndex = 14
        btnSignUp.Text = "SignUp"
        btnSignUp.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 11.25F)
        Label3.ForeColor = Color.Gray
        Label3.Location = New Point(27, 265)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 17)
        Label3.TabIndex = 9
        Label3.Text = "Email Address:"
        ' 
        ' txtEmailAdd
        ' 
        txtEmailAdd.BackColor = Color.Gray
        txtEmailAdd.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmailAdd.ForeColor = Color.Black
        txtEmailAdd.Location = New Point(27, 285)
        txtEmailAdd.Name = "txtEmailAdd"
        txtEmailAdd.Size = New Size(236, 23)
        txtEmailAdd.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 11.25F)
        Label2.ForeColor = Color.Gray
        Label2.Location = New Point(27, 201)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 17)
        Label2.TabIndex = 7
        Label2.Text = "Contact Number:"
        ' 
        ' txtContactNumber
        ' 
        txtContactNumber.BackColor = Color.Gray
        txtContactNumber.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtContactNumber.ForeColor = Color.Black
        txtContactNumber.Location = New Point(27, 221)
        txtContactNumber.Name = "txtContactNumber"
        txtContactNumber.Size = New Size(236, 23)
        txtContactNumber.TabIndex = 6
        ' 
        ' txtLastName
        ' 
        txtLastName.BackColor = Color.Gray
        txtLastName.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtLastName.ForeColor = Color.Black
        txtLastName.Location = New Point(27, 161)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(236, 23)
        txtLastName.TabIndex = 5
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Font = New Font("Arial Rounded MT Bold", 11.25F)
        lblLastName.ForeColor = Color.Gray
        lblLastName.Location = New Point(27, 141)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(90, 17)
        lblLastName.TabIndex = 4
        lblLastName.Text = "Last Name:"
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.BackColor = Color.Gray
        txtMiddleName.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtMiddleName.ForeColor = Color.Black
        txtMiddleName.Location = New Point(27, 99)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(236, 23)
        txtMiddleName.TabIndex = 3
        ' 
        ' lblMiddleName
        ' 
        lblMiddleName.AutoSize = True
        lblMiddleName.Font = New Font("Arial Rounded MT Bold", 11.25F)
        lblMiddleName.ForeColor = Color.Gray
        lblMiddleName.Location = New Point(25, 79)
        lblMiddleName.Name = "lblMiddleName"
        lblMiddleName.Size = New Size(106, 17)
        lblMiddleName.TabIndex = 2
        lblMiddleName.Text = "Middle Name:"
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.BackColor = Color.Black
        lblFirstName.Font = New Font("Arial Rounded MT Bold", 11.25F)
        lblFirstName.ForeColor = Color.Gray
        lblFirstName.Location = New Point(27, 17)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(92, 17)
        lblFirstName.TabIndex = 1
        lblFirstName.Text = "First Name:"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.BackColor = Color.DimGray
        txtFirstName.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFirstName.ForeColor = Color.Black
        txtFirstName.Location = New Point(25, 37)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(238, 23)
        txtFirstName.TabIndex = 0
        ' 
        ' btnBackground
        ' 
        btnBackground.BackColor = Color.DarkSlateGray
        btnBackground.FlatStyle = FlatStyle.Popup
        btnBackground.ForeColor = Color.White
        btnBackground.Location = New Point(79, 55)
        btnBackground.Name = "btnBackground"
        btnBackground.Size = New Size(634, 457)
        btnBackground.TabIndex = 13
        btnBackground.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DarkSlateGray
        Label1.Font = New Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(338, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 40)
        Label1.TabIndex = 1
        Label1.Text = "SignUp"
        ' 
        ' frmSignUp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(799, 581)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(btnBackground)
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
    Friend WithEvents btnBackground As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmailAdd As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents btnSignUp As Button
End Class
