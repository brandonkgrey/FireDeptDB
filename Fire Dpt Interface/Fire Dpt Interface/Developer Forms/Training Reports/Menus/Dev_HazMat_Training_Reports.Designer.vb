<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dev_HazMat_Training_Reports
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
        Me.Safety_TR_Report_Button = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FilterGroupBox = New System.Windows.Forms.GroupBox()
        Me.Fire_Credit_ComboBox = New System.Windows.Forms.ComboBox()
        Me.HMTR_Start_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.HMTR_End_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FilterGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Safety_TR_Report_Button
        '
        Me.Safety_TR_Report_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Safety_TR_Report_Button.FlatAppearance.BorderSize = 2
        Me.Safety_TR_Report_Button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Safety_TR_Report_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Safety_TR_Report_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Safety_TR_Report_Button.Location = New System.Drawing.Point(330, 156)
        Me.Safety_TR_Report_Button.Name = "Safety_TR_Report_Button"
        Me.Safety_TR_Report_Button.Size = New System.Drawing.Size(81, 25)
        Me.Safety_TR_Report_Button.TabIndex = 106
        Me.Safety_TR_Report_Button.Text = "Report"
        Me.Safety_TR_Report_Button.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ExitButton.FlatAppearance.BorderSize = 2
        Me.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Location = New System.Drawing.Point(458, 156)
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
        Me.Label3.Location = New System.Drawing.Point(138, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(247, 20)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Enter Date Range For Report"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "End:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Start:"
        '
        'FilterGroupBox
        '
        Me.FilterGroupBox.Controls.Add(Me.Fire_Credit_ComboBox)
        Me.FilterGroupBox.ForeColor = System.Drawing.Color.Black
        Me.FilterGroupBox.Location = New System.Drawing.Point(2, 142)
        Me.FilterGroupBox.Name = "FilterGroupBox"
        Me.FilterGroupBox.Size = New System.Drawing.Size(133, 48)
        Me.FilterGroupBox.TabIndex = 108
        Me.FilterGroupBox.TabStop = False
        Me.FilterGroupBox.Text = "Fire Credit Offered?"
        '
        'Fire_Credit_ComboBox
        '
        Me.Fire_Credit_ComboBox.FormattingEnabled = True
        Me.Fire_Credit_ComboBox.Items.AddRange(New Object() {"Yes", "No", "No Filter  ", ""})
        Me.Fire_Credit_ComboBox.Location = New System.Drawing.Point(6, 19)
        Me.Fire_Credit_ComboBox.Name = "Fire_Credit_ComboBox"
        Me.Fire_Credit_ComboBox.Size = New System.Drawing.Size(111, 21)
        Me.Fire_Credit_ComboBox.TabIndex = 0
        '
        'HMTR_Start_DateTimePicker
        '
        Me.HMTR_Start_DateTimePicker.Location = New System.Drawing.Point(160, 69)
        Me.HMTR_Start_DateTimePicker.Name = "HMTR_Start_DateTimePicker"
        Me.HMTR_Start_DateTimePicker.Size = New System.Drawing.Size(251, 20)
        Me.HMTR_Start_DateTimePicker.TabIndex = 109
        '
        'HMTR_End_DateTimePicker
        '
        Me.HMTR_End_DateTimePicker.Location = New System.Drawing.Point(160, 109)
        Me.HMTR_End_DateTimePicker.Name = "HMTR_End_DateTimePicker"
        Me.HMTR_End_DateTimePicker.Size = New System.Drawing.Size(251, 20)
        Me.HMTR_End_DateTimePicker.TabIndex = 110
        '
        'Dev_HazMat_Training_Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(551, 191)
        Me.Controls.Add(Me.HMTR_End_DateTimePicker)
        Me.Controls.Add(Me.HMTR_Start_DateTimePicker)
        Me.Controls.Add(Me.Safety_TR_Report_Button)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FilterGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Dev_HazMat_Training_Reports"
        Me.Text = "HazMat Training Reports Menu"
        Me.FilterGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Safety_TR_Report_Button As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FilterGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Fire_Credit_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents HMTR_Start_DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents HMTR_End_DateTimePicker As System.Windows.Forms.DateTimePicker
End Class
