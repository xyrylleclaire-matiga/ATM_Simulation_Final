<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBalanceInquiry
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
        Label1 = New Label()
        lblBalanceAmount = New Label()
        btnCancel = New Button()
        btnRefresh = New Button()
        Timer1 = New Timer(components)
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        Label1.Location = New Point(124, 153)
        Label1.Name = "Label1"
        Label1.Size = New Size(201, 32)
        Label1.TabIndex = 0
        Label1.Text = "Account Balance:"
        ' 
        ' lblBalanceAmount
        ' 
        lblBalanceAmount.AutoSize = True
        lblBalanceAmount.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lblBalanceAmount.ForeColor = Color.DarkSlateGray
        lblBalanceAmount.Location = New Point(315, 149)
        lblBalanceAmount.Name = "lblBalanceAmount"
        lblBalanceAmount.Size = New Size(85, 45)
        lblBalanceAmount.TabIndex = 1
        lblBalanceAmount.Text = "-----"
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(331, 221)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(131, 35)
        btnCancel.TabIndex = 5
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.DarkSlateGray
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(191, 221)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(134, 35)
        btnRefresh.TabIndex = 6
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 10000
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ATM_UI_UX___南街_西洋菜
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(770, 482)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(lblBalanceAmount)
        Panel1.Controls.Add(btnRefresh)
        Panel1.Controls.Add(btnCancel)
        Panel1.Location = New Point(81, 48)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(631, 383)
        Panel1.TabIndex = 8
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkSlateGray
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(-1, 18)
        Button2.Name = "Button2"
        Button2.Size = New Size(642, 51)
        Button2.TabIndex = 42
        Button2.Text = "   Balance Inquiry"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = False
        ' 
        ' frmBalanceInquiry
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(767, 480)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmBalanceInquiry"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Balance Inquiry"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblBalanceAmount As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
End Class
