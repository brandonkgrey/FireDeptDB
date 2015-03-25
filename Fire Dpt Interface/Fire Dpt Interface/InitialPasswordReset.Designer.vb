<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InitialPasswordReset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InitialPasswordReset))
        Me.DescriptionIPR = New System.Windows.Forms.Label()
        Me.PasswordRequirementsIPR = New System.Windows.Forms.Label()
        Me.NewPassword = New System.Windows.Forms.TextBox()
        Me.NewPasswordIPR = New System.Windows.Forms.Label()
        Me.ConfirmPasswordIPR = New System.Windows.Forms.Label()
        Me.ConfirmPassword = New System.Windows.Forms.TextBox()
        Me.ValidLable = New System.Windows.Forms.Label()
        Me.LogoIPR = New System.Windows.Forms.PictureBox()
        Me.SubmitButtonIPR = New System.Windows.Forms.Button()
        Me.CancelButtonIPR = New System.Windows.Forms.Button()
        CType(Me.LogoIPR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescriptionIPR
        '
        Me.DescriptionIPR.AutoSize = True
        Me.DescriptionIPR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionIPR.Location = New System.Drawing.Point(151, 9)
        Me.DescriptionIPR.Name = "DescriptionIPR"
        Me.DescriptionIPR.Size = New System.Drawing.Size(269, 20)
        Me.DescriptionIPR.TabIndex = 0
        Me.DescriptionIPR.Text = "You must change your password"
        '
        'PasswordRequirementsIPR
        '
        Me.PasswordRequirementsIPR.AutoSize = True
        Me.PasswordRequirementsIPR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordRequirementsIPR.Location = New System.Drawing.Point(173, 29)
        Me.PasswordRequirementsIPR.Name = "PasswordRequirementsIPR"
        Me.PasswordRequirementsIPR.Size = New System.Drawing.Size(217, 13)
        Me.PasswordRequirementsIPR.TabIndex = 1
        Me.PasswordRequirementsIPR.Text = "New Password must be at least 6 characters"
        '
        'NewPassword
        '
        Me.NewPassword.AcceptsReturn = True
        Me.NewPassword.Location = New System.Drawing.Point(245, 61)
        Me.NewPassword.Name = "NewPassword"
        Me.NewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPassword.Size = New System.Drawing.Size(175, 20)
        Me.NewPassword.TabIndex = 2
        '
        'NewPasswordIPR
        '
        Me.NewPasswordIPR.AutoSize = True
        Me.NewPasswordIPR.Location = New System.Drawing.Point(142, 64)
        Me.NewPasswordIPR.Name = "NewPasswordIPR"
        Me.NewPasswordIPR.Size = New System.Drawing.Size(84, 13)
        Me.NewPasswordIPR.TabIndex = 3
        Me.NewPasswordIPR.Text = "New Password: "
        '
        'ConfirmPasswordIPR
        '
        Me.ConfirmPasswordIPR.AutoSize = True
        Me.ConfirmPasswordIPR.Location = New System.Drawing.Point(142, 116)
        Me.ConfirmPasswordIPR.Name = "ConfirmPasswordIPR"
        Me.ConfirmPasswordIPR.Size = New System.Drawing.Size(97, 13)
        Me.ConfirmPasswordIPR.TabIndex = 4
        Me.ConfirmPasswordIPR.Text = "Confirm Password: "
        '
        'ConfirmPassword
        '
        Me.ConfirmPassword.Location = New System.Drawing.Point(245, 109)
        Me.ConfirmPassword.Name = "ConfirmPassword"
        Me.ConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPassword.Size = New System.Drawing.Size(175, 20)
        Me.ConfirmPassword.TabIndex = 5
        '
        'ValidLable
        '
        Me.ValidLable.AutoSize = True
        Me.ValidLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValidLable.ForeColor = System.Drawing.Color.Red
        Me.ValidLable.Location = New System.Drawing.Point(277, 84)
        Me.ValidLable.Name = "ValidLable"
        Me.ValidLable.Size = New System.Drawing.Size(103, 13)
        Me.ValidLable.TabIndex = 6
        Me.ValidLable.Text = "Invalid Password"
        Me.ValidLable.Visible = False
        '
        'LogoIPR
        '
        Me.LogoIPR.Image = CType(resources.GetObject("LogoIPR.Image"), System.Drawing.Image)
        Me.LogoIPR.Location = New System.Drawing.Point(9, 29)
        Me.LogoIPR.Name = "LogoIPR"
        Me.LogoIPR.Size = New System.Drawing.Size(127, 121)
        Me.LogoIPR.TabIndex = 7
        Me.LogoIPR.TabStop = False
        '
        'SubmitButtonIPR
        '
        Me.SubmitButtonIPR.Location = New System.Drawing.Point(186, 152)
        Me.SubmitButtonIPR.Name = "SubmitButtonIPR"
        Me.SubmitButtonIPR.Size = New System.Drawing.Size(94, 23)
        Me.SubmitButtonIPR.TabIndex = 8
        Me.SubmitButtonIPR.Text = "Submit"
        Me.SubmitButtonIPR.UseVisualStyleBackColor = True
        '
        'CancelButtonIPR
        '
        Me.CancelButtonIPR.Location = New System.Drawing.Point(286, 152)
        Me.CancelButtonIPR.Name = "CancelButtonIPR"
        Me.CancelButtonIPR.Size = New System.Drawing.Size(94, 23)
        Me.CancelButtonIPR.TabIndex = 9
        Me.CancelButtonIPR.Text = "Cancel"
        Me.CancelButtonIPR.UseVisualStyleBackColor = True
        '
        'InitialPasswordReset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(442, 188)
        Me.Controls.Add(Me.CancelButtonIPR)
        Me.Controls.Add(Me.SubmitButtonIPR)
        Me.Controls.Add(Me.LogoIPR)
        Me.Controls.Add(Me.ValidLable)
        Me.Controls.Add(Me.ConfirmPassword)
        Me.Controls.Add(Me.ConfirmPasswordIPR)
        Me.Controls.Add(Me.NewPasswordIPR)
        Me.Controls.Add(Me.NewPassword)
        Me.Controls.Add(Me.PasswordRequirementsIPR)
        Me.Controls.Add(Me.DescriptionIPR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "InitialPasswordReset"
        Me.Text = "InitialPasswordReset"
        CType(Me.LogoIPR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DescriptionIPR As System.Windows.Forms.Label
    Friend WithEvents PasswordRequirementsIPR As System.Windows.Forms.Label
    Friend WithEvents NewPassword As System.Windows.Forms.TextBox
    Friend WithEvents NewPasswordIPR As System.Windows.Forms.Label
    Friend WithEvents ConfirmPasswordIPR As System.Windows.Forms.Label
    Friend WithEvents ConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents ValidLable As System.Windows.Forms.Label
    Friend WithEvents LogoIPR As System.Windows.Forms.PictureBox
    Friend WithEvents SubmitButtonIPR As System.Windows.Forms.Button
    Friend WithEvents CancelButtonIPR As System.Windows.Forms.Button
End Class
