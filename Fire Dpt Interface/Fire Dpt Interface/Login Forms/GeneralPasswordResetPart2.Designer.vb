<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeneralPasswordResetPart2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GeneralPasswordResetPart2))
        Me.LogoGPR2 = New System.Windows.Forms.PictureBox()
        Me.TitleGPR2 = New System.Windows.Forms.Label()
        Me.CancelButtonGPR2 = New System.Windows.Forms.Button()
        Me.OKButtonGPR2 = New System.Windows.Forms.Button()
        Me.TempPassGPR2 = New System.Windows.Forms.TextBox()
        Me.TempPassLableGPR = New System.Windows.Forms.Label()
        Me.PasswordBox1GPR2 = New System.Windows.Forms.TextBox()
        Me.PasswordBox2GPR2 = New System.Windows.Forms.TextBox()
        Me.NewPasswordLableGPR2 = New System.Windows.Forms.Label()
        Me.ConfirmPasswordLableGPR2 = New System.Windows.Forms.Label()
        Me.ValidLableGPR2 = New System.Windows.Forms.Label()
        CType(Me.LogoGPR2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoGPR2
        '
        Me.LogoGPR2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LogoGPR2.Image = CType(resources.GetObject("LogoGPR2.Image"), System.Drawing.Image)
        Me.LogoGPR2.Location = New System.Drawing.Point(12, 68)
        Me.LogoGPR2.Name = "LogoGPR2"
        Me.LogoGPR2.Size = New System.Drawing.Size(127, 120)
        Me.LogoGPR2.TabIndex = 0
        Me.LogoGPR2.TabStop = False
        '
        'TitleGPR2
        '
        Me.TitleGPR2.AutoSize = True
        Me.TitleGPR2.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleGPR2.Location = New System.Drawing.Point(147, 9)
        Me.TitleGPR2.Name = "TitleGPR2"
        Me.TitleGPR2.Size = New System.Drawing.Size(256, 32)
        Me.TitleGPR2.TabIndex = 1
        Me.TitleGPR2.Text = "Reset Password"
        '
        'CancelButtonGPR2
        '
        Me.CancelButtonGPR2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButtonGPR2.FlatAppearance.BorderSize = 2
        Me.CancelButtonGPR2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CancelButtonGPR2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButtonGPR2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButtonGPR2.Location = New System.Drawing.Point(213, 185)
        Me.CancelButtonGPR2.Name = "CancelButtonGPR2"
        Me.CancelButtonGPR2.Size = New System.Drawing.Size(94, 23)
        Me.CancelButtonGPR2.TabIndex = 2
        Me.CancelButtonGPR2.Text = "Cancel"
        Me.CancelButtonGPR2.UseVisualStyleBackColor = True
        '
        'OKButtonGPR2
        '
        Me.OKButtonGPR2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OKButtonGPR2.FlatAppearance.BorderSize = 2
        Me.OKButtonGPR2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.OKButtonGPR2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OKButtonGPR2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OKButtonGPR2.Location = New System.Drawing.Point(334, 185)
        Me.OKButtonGPR2.Name = "OKButtonGPR2"
        Me.OKButtonGPR2.Size = New System.Drawing.Size(94, 23)
        Me.OKButtonGPR2.TabIndex = 3
        Me.OKButtonGPR2.Text = "&OK"
        Me.OKButtonGPR2.UseVisualStyleBackColor = True
        '
        'TempPassGPR2
        '
        Me.TempPassGPR2.Location = New System.Drawing.Point(285, 68)
        Me.TempPassGPR2.Name = "TempPassGPR2"
        Me.TempPassGPR2.Size = New System.Drawing.Size(188, 21)
        Me.TempPassGPR2.TabIndex = 4
        '
        'TempPassLableGPR
        '
        Me.TempPassLableGPR.AutoSize = True
        Me.TempPassLableGPR.Location = New System.Drawing.Point(151, 71)
        Me.TempPassLableGPR.Name = "TempPassLableGPR"
        Me.TempPassLableGPR.Size = New System.Drawing.Size(128, 13)
        Me.TempPassLableGPR.TabIndex = 5
        Me.TempPassLableGPR.Text = "Temporary Password"
        '
        'PasswordBox1GPR2
        '
        Me.PasswordBox1GPR2.Location = New System.Drawing.Point(285, 95)
        Me.PasswordBox1GPR2.Name = "PasswordBox1GPR2"
        Me.PasswordBox1GPR2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordBox1GPR2.Size = New System.Drawing.Size(188, 21)
        Me.PasswordBox1GPR2.TabIndex = 6
        '
        'PasswordBox2GPR2
        '
        Me.PasswordBox2GPR2.Location = New System.Drawing.Point(286, 143)
        Me.PasswordBox2GPR2.Name = "PasswordBox2GPR2"
        Me.PasswordBox2GPR2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordBox2GPR2.Size = New System.Drawing.Size(187, 21)
        Me.PasswordBox2GPR2.TabIndex = 7
        '
        'NewPasswordLableGPR2
        '
        Me.NewPasswordLableGPR2.AutoSize = True
        Me.NewPasswordLableGPR2.Location = New System.Drawing.Point(193, 98)
        Me.NewPasswordLableGPR2.Name = "NewPasswordLableGPR2"
        Me.NewPasswordLableGPR2.Size = New System.Drawing.Size(89, 13)
        Me.NewPasswordLableGPR2.TabIndex = 8
        Me.NewPasswordLableGPR2.Text = "New Password"
        '
        'ConfirmPasswordLableGPR2
        '
        Me.ConfirmPasswordLableGPR2.AutoSize = True
        Me.ConfirmPasswordLableGPR2.Location = New System.Drawing.Point(171, 146)
        Me.ConfirmPasswordLableGPR2.Name = "ConfirmPasswordLableGPR2"
        Me.ConfirmPasswordLableGPR2.Size = New System.Drawing.Size(111, 13)
        Me.ConfirmPasswordLableGPR2.TabIndex = 9
        Me.ConfirmPasswordLableGPR2.Text = "Confirm Password"
        '
        'ValidLableGPR2
        '
        Me.ValidLableGPR2.AutoSize = True
        Me.ValidLableGPR2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValidLableGPR2.ForeColor = System.Drawing.Color.Red
        Me.ValidLableGPR2.Location = New System.Drawing.Point(321, 119)
        Me.ValidLableGPR2.Name = "ValidLableGPR2"
        Me.ValidLableGPR2.Size = New System.Drawing.Size(119, 13)
        Me.ValidLableGPR2.TabIndex = 10
        Me.ValidLableGPR2.Text = "Invalid Password"
        Me.ValidLableGPR2.Visible = False
        '
        'GeneralPasswordResetPart2
        '
        Me.AcceptButton = Me.OKButtonGPR2
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(511, 232)
        Me.Controls.Add(Me.ValidLableGPR2)
        Me.Controls.Add(Me.ConfirmPasswordLableGPR2)
        Me.Controls.Add(Me.NewPasswordLableGPR2)
        Me.Controls.Add(Me.PasswordBox2GPR2)
        Me.Controls.Add(Me.PasswordBox1GPR2)
        Me.Controls.Add(Me.TempPassLableGPR)
        Me.Controls.Add(Me.TempPassGPR2)
        Me.Controls.Add(Me.OKButtonGPR2)
        Me.Controls.Add(Me.CancelButtonGPR2)
        Me.Controls.Add(Me.TitleGPR2)
        Me.Controls.Add(Me.LogoGPR2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "GeneralPasswordResetPart2"
        Me.Text = "Reset Password"
        CType(Me.LogoGPR2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LogoGPR2 As System.Windows.Forms.PictureBox
    Friend WithEvents TitleGPR2 As System.Windows.Forms.Label
    Friend WithEvents CancelButtonGPR2 As System.Windows.Forms.Button
    Friend WithEvents OKButtonGPR2 As System.Windows.Forms.Button
    Friend WithEvents TempPassGPR2 As System.Windows.Forms.TextBox
    Friend WithEvents TempPassLableGPR As System.Windows.Forms.Label
    Friend WithEvents PasswordBox1GPR2 As System.Windows.Forms.TextBox
    Friend WithEvents PasswordBox2GPR2 As System.Windows.Forms.TextBox
    Friend WithEvents NewPasswordLableGPR2 As System.Windows.Forms.Label
    Friend WithEvents ConfirmPasswordLableGPR2 As System.Windows.Forms.Label
    Friend WithEvents ValidLableGPR2 As System.Windows.Forms.Label
End Class
