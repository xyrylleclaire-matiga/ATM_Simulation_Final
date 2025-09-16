<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer
    Private WithEvents lblTitle As Label
    Private WithEvents pnlSystem As Panel
    Private WithEvents pnlSecurity As Panel
    Private WithEvents pnlAppearance As Panel
    Private WithEvents btnSave As Button
    Private WithEvents chkEnableNotifications As CheckBox
    Private WithEvents chkDarkMode As CheckBox

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitle = New Label()
        pnlSystem = New Panel()
        lblSystem = New Label()
        pnlSecurity = New Panel()
        lblSecurity = New Label()
        pnlAppearance = New Panel()
        lblAppearance = New Label()
        chkEnableNotifications = New CheckBox()
        chkDarkMode = New CheckBox()
        btnSave = New Button()
        pnlSystem.SuspendLayout()
        pnlSecurity.SuspendLayout()
        pnlAppearance.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        lblTitle.Location = New Point(20, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(98, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Settings"
        ' 
        ' pnlSystem
        ' 
        pnlSystem.BackColor = Color.White
        pnlSystem.BorderStyle = BorderStyle.FixedSingle
        pnlSystem.Controls.Add(lblSystem)
        pnlSystem.Location = New Point(20, 70)
        pnlSystem.Name = "pnlSystem"
        pnlSystem.Size = New Size(220, 100)
        pnlSystem.TabIndex = 1
        ' 
        ' lblSystem
        ' 
        lblSystem.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblSystem.Location = New Point(10, 10)
        lblSystem.Name = "lblSystem"
        lblSystem.Size = New Size(100, 23)
        lblSystem.TabIndex = 0
        lblSystem.Text = "System Settings"
        ' 
        ' pnlSecurity
        ' 
        pnlSecurity.BackColor = Color.White
        pnlSecurity.BorderStyle = BorderStyle.FixedSingle
        pnlSecurity.Controls.Add(lblSecurity)
        pnlSecurity.Location = New Point(260, 70)
        pnlSecurity.Name = "pnlSecurity"
        pnlSecurity.Size = New Size(220, 100)
        pnlSecurity.TabIndex = 2
        ' 
        ' lblSecurity
        ' 
        lblSecurity.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblSecurity.Location = New Point(10, 10)
        lblSecurity.Name = "lblSecurity"
        lblSecurity.Size = New Size(100, 23)
        lblSecurity.TabIndex = 0
        lblSecurity.Text = "Security Settings"
        ' 
        ' pnlAppearance
        ' 
        pnlAppearance.BackColor = Color.White
        pnlAppearance.BorderStyle = BorderStyle.FixedSingle
        pnlAppearance.Controls.Add(lblAppearance)
        pnlAppearance.Location = New Point(500, 70)
        pnlAppearance.Name = "pnlAppearance"
        pnlAppearance.Size = New Size(220, 100)
        pnlAppearance.TabIndex = 3
        ' 
        ' lblAppearance
        ' 
        lblAppearance.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblAppearance.Location = New Point(10, 10)
        lblAppearance.Name = "lblAppearance"
        lblAppearance.Size = New Size(100, 23)
        lblAppearance.TabIndex = 0
        lblAppearance.Text = "Appearance"
        ' 
        ' chkEnableNotifications
        ' 
        chkEnableNotifications.Font = New Font("Segoe UI", 10F)
        chkEnableNotifications.Location = New Point(30, 190)
        chkEnableNotifications.Name = "chkEnableNotifications"
        chkEnableNotifications.Size = New Size(104, 24)
        chkEnableNotifications.TabIndex = 4
        chkEnableNotifications.Text = "Enable Notifications"
        ' 
        ' chkDarkMode
        ' 
        chkDarkMode.Font = New Font("Segoe UI", 10F)
        chkDarkMode.Location = New Point(30, 220)
        chkDarkMode.Name = "chkDarkMode"
        chkDarkMode.Size = New Size(104, 24)
        chkDarkMode.TabIndex = 5
        chkDarkMode.Text = "Enable Dark Mode"
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(30, 270)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(120, 35)
        btnSave.TabIndex = 6
        btnSave.Text = "Save Settings"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' frmSettings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1502, 650)
        Controls.Add(lblTitle)
        Controls.Add(pnlSystem)
        Controls.Add(pnlSecurity)
        Controls.Add(pnlAppearance)
        Controls.Add(chkEnableNotifications)
        Controls.Add(chkDarkMode)
        Controls.Add(btnSave)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmSettings"
        Text = "Settings"
        pnlSystem.ResumeLayout(False)
        pnlSecurity.ResumeLayout(False)
        pnlAppearance.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblSystem As Label
    Friend WithEvents lblSecurity As Label
    Friend WithEvents lblAppearance As Label
End Class
