<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dev_EMS_Training_Reports
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
        Me.EMS_TR_Report_Button = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EMS_TR_SDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EMS_TR_EDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'EMS_TR_Report_Button
        '
        Me.EMS_TR_Report_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EMS_TR_Report_Button.FlatAppearance.BorderSize = 2
        Me.EMS_TR_Report_Button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.EMS_TR_Report_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EMS_TR_Report_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EMS_TR_Report_Button.Location = New System.Drawing.Point(330, 154)
        Me.EMS_TR_Report_Button.Name = "EMS_TR_Report_Button"
        Me.EMS_TR_Report_Button.Size = New System.Drawing.Size(81, 25)
        Me.EMS_TR_Report_Button.TabIndex = 106
        Me.EMS_TR_Report_Button.Text = "Report"
        Me.EMS_TR_Report_Button.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ExitButton.FlatAppearance.BorderSize = 2
        Me.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Location = New System.Drawing.Point(458, 154)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(81, 25)
        Me.ExitButton.TabIndex = 104
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(136, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(247, 20)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Enter Date Range For Report"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(97, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "End:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Start:"
        '
        'EMS_TR_SDateTimePicker
        '
        Me.EMS_TR_SDateTimePicker.Location = New System.Drawing.Point(158, 67)
        Me.EMS_TR_SDateTimePicker.Name = "EMS_TR_SDateTimePicker"
        Me.EMS_TR_SDateTimePicker.Size = New System.Drawing.Size(253, 20)
        Me.EMS_TR_SDateTimePicker.TabIndex = 107
        '
        'EMS_TR_EDateTimePicker
        '
        Me.EMS_TR_EDateTimePicker.Location = New System.Drawing.Point(158, 113)
        Me.EMS_TR_EDateTimePicker.Name = "EMS_TR_EDateTimePicker"
        Me.EMS_TR_EDateTimePicker.Size = New System.Drawing.Size(253, 20)
        Me.EMS_TR_EDateTimePicker.TabIndex = 108
        '
        'Dev_EMS_Training_Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(551, 191)
        Me.Controls.Add(Me.EMS_TR_EDateTimePicker)
        Me.Controls.Add(Me.EMS_TR_SDateTimePicker)
        Me.Controls.Add(Me.EMS_TR_Report_Button)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Dev_EMS_Training_Reports"
        Me.Text = "EMS Training Reports Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EMS_TR_Report_Button As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EMS_TR_SDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EMS_TR_EDateTimePicker As System.Windows.Forms.DateTimePicker
End Class
