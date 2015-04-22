<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupervisorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SupervisorForm))
        Me.BasicMenuTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LogoutBFButton = New System.Windows.Forms.Button()
        Me.Class_Information_Button = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Emp_Info_Button = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BasicMenuTitle
        '
        Me.BasicMenuTitle.AutoSize = True
        Me.BasicMenuTitle.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicMenuTitle.Location = New System.Drawing.Point(12, 21)
        Me.BasicMenuTitle.Name = "BasicMenuTitle"
        Me.BasicMenuTitle.Size = New System.Drawing.Size(189, 38)
        Me.BasicMenuTitle.TabIndex = 27
        Me.BasicMenuTitle.Text = "Main Menu"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(41, 96)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 120)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'LogoutBFButton
        '
        Me.LogoutBFButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.LogoutBFButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LogoutBFButton.FlatAppearance.BorderSize = 2
        Me.LogoutBFButton.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LogoutBFButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LogoutBFButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LogoutBFButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutBFButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutBFButton.ForeColor = System.Drawing.Color.Red
        Me.LogoutBFButton.Location = New System.Drawing.Point(222, 218)
        Me.LogoutBFButton.Name = "LogoutBFButton"
        Me.LogoutBFButton.Size = New System.Drawing.Size(101, 39)
        Me.LogoutBFButton.TabIndex = 21
        Me.LogoutBFButton.Text = "Log Out "
        Me.LogoutBFButton.UseVisualStyleBackColor = True
        '
        'Class_Information_Button
        '
        Me.Class_Information_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Class_Information_Button.FlatAppearance.BorderSize = 2
        Me.Class_Information_Button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Class_Information_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Class_Information_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Class_Information_Button.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Class_Information_Button.Location = New System.Drawing.Point(222, 75)
        Me.Class_Information_Button.Name = "Class_Information_Button"
        Me.Class_Information_Button.Size = New System.Drawing.Size(103, 46)
        Me.Class_Information_Button.TabIndex = 30
        Me.Class_Information_Button.Text = "Class Information"
        Me.Class_Information_Button.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 2
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(222, 127)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 67)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "EMS Certification Expiration"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Emp_Info_Button
        '
        Me.Emp_Info_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Emp_Info_Button.FlatAppearance.BorderSize = 2
        Me.Emp_Info_Button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Emp_Info_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Emp_Info_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Emp_Info_Button.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_Info_Button.Location = New System.Drawing.Point(222, 23)
        Me.Emp_Info_Button.Name = "Emp_Info_Button"
        Me.Emp_Info_Button.Size = New System.Drawing.Size(103, 46)
        Me.Emp_Info_Button.TabIndex = 28
        Me.Emp_Info_Button.Text = "Employee Information"
        Me.Emp_Info_Button.UseVisualStyleBackColor = True
        '
        'SupervisorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(337, 285)
        Me.Controls.Add(Me.Class_Information_Button)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Emp_Info_Button)
        Me.Controls.Add(Me.BasicMenuTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LogoutBFButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "SupervisorForm"
        Me.Text = "SupervisorForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BasicMenuTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LogoutBFButton As System.Windows.Forms.Button
    Friend WithEvents Class_Information_Button As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Emp_Info_Button As System.Windows.Forms.Button
End Class
