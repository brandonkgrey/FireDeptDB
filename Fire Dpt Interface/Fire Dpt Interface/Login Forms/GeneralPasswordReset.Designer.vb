<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeneralPasswordReset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GeneralPasswordReset))
        Me.CancelButtonGPR = New System.Windows.Forms.Button()
        Me.OKButtonGPR = New System.Windows.Forms.Button()
        Me.LogoGPR = New System.Windows.Forms.PictureBox()
        Me.TitleGPR = New System.Windows.Forms.Label()
        Me.DescriptionGPR = New System.Windows.Forms.Label()
        Me.UsernameGPR = New System.Windows.Forms.TextBox()
        Me.UsernameLableGPR = New System.Windows.Forms.Label()
        Me.InvalidUsernameGPR = New System.Windows.Forms.Label()
        CType(Me.LogoGPR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CancelButtonGPR
        '
        Me.CancelButtonGPR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButtonGPR.FlatAppearance.BorderSize = 2
        Me.CancelButtonGPR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CancelButtonGPR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButtonGPR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButtonGPR.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButtonGPR.Location = New System.Drawing.Point(158, 132)
        Me.CancelButtonGPR.Name = "CancelButtonGPR"
        Me.CancelButtonGPR.Size = New System.Drawing.Size(94, 23)
        Me.CancelButtonGPR.TabIndex = 0
        Me.CancelButtonGPR.Text = "Cancel"
        Me.CancelButtonGPR.UseVisualStyleBackColor = True
        '
        'OKButtonGPR
        '
        Me.OKButtonGPR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OKButtonGPR.FlatAppearance.BorderSize = 2
        Me.OKButtonGPR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.OKButtonGPR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OKButtonGPR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OKButtonGPR.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OKButtonGPR.Location = New System.Drawing.Point(270, 132)
        Me.OKButtonGPR.Name = "OKButtonGPR"
        Me.OKButtonGPR.Size = New System.Drawing.Size(94, 23)
        Me.OKButtonGPR.TabIndex = 1
        Me.OKButtonGPR.Text = "&OK"
        Me.OKButtonGPR.UseVisualStyleBackColor = True
        '
        'LogoGPR
        '
        Me.LogoGPR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LogoGPR.Image = CType(resources.GetObject("LogoGPR.Image"), System.Drawing.Image)
        Me.LogoGPR.Location = New System.Drawing.Point(12, 12)
        Me.LogoGPR.Name = "LogoGPR"
        Me.LogoGPR.Size = New System.Drawing.Size(128, 121)
        Me.LogoGPR.TabIndex = 2
        Me.LogoGPR.TabStop = False
        '
        'TitleGPR
        '
        Me.TitleGPR.AutoSize = True
        Me.TitleGPR.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleGPR.Location = New System.Drawing.Point(166, 12)
        Me.TitleGPR.Name = "TitleGPR"
        Me.TitleGPR.Size = New System.Drawing.Size(202, 29)
        Me.TitleGPR.TabIndex = 3
        Me.TitleGPR.Text = "Reset Password"
        '
        'DescriptionGPR
        '
        Me.DescriptionGPR.AutoSize = True
        Me.DescriptionGPR.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionGPR.Location = New System.Drawing.Point(168, 41)
        Me.DescriptionGPR.Name = "DescriptionGPR"
        Me.DescriptionGPR.Size = New System.Drawing.Size(196, 16)
        Me.DescriptionGPR.TabIndex = 4
        Me.DescriptionGPR.Text = "Please enter your username"
        '
        'UsernameGPR
        '
        Me.UsernameGPR.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameGPR.Location = New System.Drawing.Point(171, 84)
        Me.UsernameGPR.Name = "UsernameGPR"
        Me.UsernameGPR.Size = New System.Drawing.Size(188, 21)
        Me.UsernameGPR.TabIndex = 5
        '
        'UsernameLableGPR
        '
        Me.UsernameLableGPR.AutoSize = True
        Me.UsernameLableGPR.Location = New System.Drawing.Point(168, 68)
        Me.UsernameLableGPR.Name = "UsernameLableGPR"
        Me.UsernameLableGPR.Size = New System.Drawing.Size(55, 13)
        Me.UsernameLableGPR.TabIndex = 6
        Me.UsernameLableGPR.Text = "&Username"
        '
        'InvalidUsernameGPR
        '
        Me.InvalidUsernameGPR.AutoSize = True
        Me.InvalidUsernameGPR.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InvalidUsernameGPR.ForeColor = System.Drawing.Color.Red
        Me.InvalidUsernameGPR.Location = New System.Drawing.Point(201, 108)
        Me.InvalidUsernameGPR.Name = "InvalidUsernameGPR"
        Me.InvalidUsernameGPR.Size = New System.Drawing.Size(123, 13)
        Me.InvalidUsernameGPR.TabIndex = 7
        Me.InvalidUsernameGPR.Text = "Invalid Username"
        Me.InvalidUsernameGPR.Visible = False
        '
        'GeneralPasswordReset
        '
        Me.AcceptButton = Me.OKButtonGPR
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(380, 167)
        Me.Controls.Add(Me.InvalidUsernameGPR)
        Me.Controls.Add(Me.UsernameLableGPR)
        Me.Controls.Add(Me.UsernameGPR)
        Me.Controls.Add(Me.DescriptionGPR)
        Me.Controls.Add(Me.TitleGPR)
        Me.Controls.Add(Me.LogoGPR)
        Me.Controls.Add(Me.OKButtonGPR)
        Me.Controls.Add(Me.CancelButtonGPR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "GeneralPasswordReset"
        Me.Text = "Reset Password"
        CType(Me.LogoGPR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CancelButtonGPR As System.Windows.Forms.Button
    Friend WithEvents OKButtonGPR As System.Windows.Forms.Button
    Friend WithEvents LogoGPR As System.Windows.Forms.PictureBox
    Friend WithEvents TitleGPR As System.Windows.Forms.Label
    Friend WithEvents DescriptionGPR As System.Windows.Forms.Label
    Friend WithEvents UsernameGPR As System.Windows.Forms.TextBox
    Friend WithEvents UsernameLableGPR As System.Windows.Forms.Label
    Friend WithEvents InvalidUsernameGPR As System.Windows.Forms.Label
End Class
