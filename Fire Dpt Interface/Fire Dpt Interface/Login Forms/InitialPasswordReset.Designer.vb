﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.CancelButtonIPR = New System.Windows.Forms.Button()
        Me.SubmitButtonIPR = New System.Windows.Forms.Button()
        Me.LogoIPR = New System.Windows.Forms.PictureBox()
        Me.ValidLable = New System.Windows.Forms.Label()
        Me.ConfirmPassword = New System.Windows.Forms.TextBox()
        Me.ConfirmPasswordIPR = New System.Windows.Forms.Label()
        Me.NewPasswordIPR = New System.Windows.Forms.Label()
        Me.NewPassword = New System.Windows.Forms.TextBox()
        Me.PasswordRequirementsIPR = New System.Windows.Forms.Label()
        Me.DescriptionIPR = New System.Windows.Forms.Label()
        CType(Me.LogoIPR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CancelButtonIPR
        '
        Me.CancelButtonIPR.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButtonIPR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButtonIPR.FlatAppearance.BorderSize = 2
        Me.CancelButtonIPR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CancelButtonIPR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButtonIPR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButtonIPR.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButtonIPR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CancelButtonIPR.Location = New System.Drawing.Point(178, 155)
        Me.CancelButtonIPR.Name = "CancelButtonIPR"
        Me.CancelButtonIPR.Size = New System.Drawing.Size(94, 23)
        Me.CancelButtonIPR.TabIndex = 19
        Me.CancelButtonIPR.Text = "Cancel"
        Me.CancelButtonIPR.UseVisualStyleBackColor = True
        '
        'SubmitButtonIPR
        '
        Me.SubmitButtonIPR.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SubmitButtonIPR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubmitButtonIPR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SubmitButtonIPR.FlatAppearance.BorderSize = 2
        Me.SubmitButtonIPR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SubmitButtonIPR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SubmitButtonIPR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SubmitButtonIPR.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitButtonIPR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SubmitButtonIPR.Location = New System.Drawing.Point(292, 155)
        Me.SubmitButtonIPR.Name = "SubmitButtonIPR"
        Me.SubmitButtonIPR.Size = New System.Drawing.Size(94, 23)
        Me.SubmitButtonIPR.TabIndex = 18
        Me.SubmitButtonIPR.Text = "&OK"
        Me.SubmitButtonIPR.UseVisualStyleBackColor = False
        '
        'LogoIPR
        '
        Me.LogoIPR.Image = CType(resources.GetObject("LogoIPR.Image"), System.Drawing.Image)
        Me.LogoIPR.Location = New System.Drawing.Point(11, 31)
        Me.LogoIPR.Name = "LogoIPR"
        Me.LogoIPR.Size = New System.Drawing.Size(127, 121)
        Me.LogoIPR.TabIndex = 17
        Me.LogoIPR.TabStop = False
        '
        'ValidLable
        '
        Me.ValidLable.AutoSize = True
        Me.ValidLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValidLable.ForeColor = System.Drawing.Color.Red
        Me.ValidLable.Location = New System.Drawing.Point(289, 87)
        Me.ValidLable.Name = "ValidLable"
        Me.ValidLable.Size = New System.Drawing.Size(103, 13)
        Me.ValidLable.TabIndex = 16
        Me.ValidLable.Text = "Invalid Password"
        Me.ValidLable.Visible = False
        '
        'ConfirmPassword
        '
        Me.ConfirmPassword.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPassword.Location = New System.Drawing.Point(257, 115)
        Me.ConfirmPassword.Name = "ConfirmPassword"
        Me.ConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPassword.Size = New System.Drawing.Size(175, 21)
        Me.ConfirmPassword.TabIndex = 15
        '
        'ConfirmPasswordIPR
        '
        Me.ConfirmPasswordIPR.AutoSize = True
        Me.ConfirmPasswordIPR.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPasswordIPR.Location = New System.Drawing.Point(144, 118)
        Me.ConfirmPasswordIPR.Name = "ConfirmPasswordIPR"
        Me.ConfirmPasswordIPR.Size = New System.Drawing.Size(111, 13)
        Me.ConfirmPasswordIPR.TabIndex = 14
        Me.ConfirmPasswordIPR.Text = "&Confirm Password"
        '
        'NewPasswordIPR
        '
        Me.NewPasswordIPR.AutoSize = True
        Me.NewPasswordIPR.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPasswordIPR.Location = New System.Drawing.Point(153, 66)
        Me.NewPasswordIPR.Name = "NewPasswordIPR"
        Me.NewPasswordIPR.Size = New System.Drawing.Size(89, 13)
        Me.NewPasswordIPR.TabIndex = 13
        Me.NewPasswordIPR.Text = "&New Password"
        '
        'NewPassword
        '
        Me.NewPassword.AcceptsReturn = True
        Me.NewPassword.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPassword.Location = New System.Drawing.Point(257, 63)
        Me.NewPassword.Name = "NewPassword"
        Me.NewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPassword.Size = New System.Drawing.Size(175, 21)
        Me.NewPassword.TabIndex = 12
        '
        'PasswordRequirementsIPR
        '
        Me.PasswordRequirementsIPR.AutoSize = True
        Me.PasswordRequirementsIPR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordRequirementsIPR.Location = New System.Drawing.Point(175, 31)
        Me.PasswordRequirementsIPR.Name = "PasswordRequirementsIPR"
        Me.PasswordRequirementsIPR.Size = New System.Drawing.Size(217, 13)
        Me.PasswordRequirementsIPR.TabIndex = 11
        Me.PasswordRequirementsIPR.Text = "New Password must be at least 6 characters"
        '
        'DescriptionIPR
        '
        Me.DescriptionIPR.AutoSize = True
        Me.DescriptionIPR.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionIPR.Location = New System.Drawing.Point(14, 11)
        Me.DescriptionIPR.Name = "DescriptionIPR"
        Me.DescriptionIPR.Size = New System.Drawing.Size(406, 16)
        Me.DescriptionIPR.TabIndex = 10
        Me.DescriptionIPR.Text = "Welcome first time user, please change your password"
        '
        'InitialPasswordReset
        '
        Me.AcceptButton = Me.SubmitButtonIPR
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CancelButton = Me.CancelButtonIPR
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "InitialPasswordReset"
        Me.Text = "Initial Password Reset"
        CType(Me.LogoIPR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CancelButtonIPR As System.Windows.Forms.Button
    Friend WithEvents SubmitButtonIPR As System.Windows.Forms.Button
    Friend WithEvents LogoIPR As System.Windows.Forms.PictureBox
    Friend WithEvents ValidLable As System.Windows.Forms.Label
    Friend WithEvents ConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents ConfirmPasswordIPR As System.Windows.Forms.Label
    Friend WithEvents NewPasswordIPR As System.Windows.Forms.Label
    Friend WithEvents NewPassword As System.Windows.Forms.TextBox
    Friend WithEvents PasswordRequirementsIPR As System.Windows.Forms.Label
    Friend WithEvents DescriptionIPR As System.Windows.Forms.Label
End Class
