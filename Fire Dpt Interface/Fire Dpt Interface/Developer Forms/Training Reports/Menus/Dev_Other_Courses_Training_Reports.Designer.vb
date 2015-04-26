<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dev_Other_Courses_Training_Reports
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
        Me.OC_TR_End_Textbox = New System.Windows.Forms.TextBox()
        Me.OC_TR_Start_Textbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OC_TR_ComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Safety_TR_Report_Button
        '
        Me.Safety_TR_Report_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Safety_TR_Report_Button.FlatAppearance.BorderSize = 2
        Me.Safety_TR_Report_Button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Safety_TR_Report_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Safety_TR_Report_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Safety_TR_Report_Button.Location = New System.Drawing.Point(333, 170)
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
        Me.ExitButton.Location = New System.Drawing.Point(461, 170)
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
        Me.Label3.Location = New System.Drawing.Point(139, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(247, 20)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Enter Date Range For Report"
        '
        'OC_TR_End_Textbox
        '
        Me.OC_TR_End_Textbox.Location = New System.Drawing.Point(203, 94)
        Me.OC_TR_End_Textbox.Name = "OC_TR_End_Textbox"
        Me.OC_TR_End_Textbox.Size = New System.Drawing.Size(209, 20)
        Me.OC_TR_End_Textbox.TabIndex = 102
        '
        'OC_TR_Start_Textbox
        '
        Me.OC_TR_Start_Textbox.Location = New System.Drawing.Point(203, 58)
        Me.OC_TR_Start_Textbox.Name = "OC_TR_Start_Textbox"
        Me.OC_TR_Start_Textbox.Size = New System.Drawing.Size(209, 20)
        Me.OC_TR_Start_Textbox.TabIndex = 101
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "End:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Start:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(100, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 20)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Type:"
        '
        'OC_TR_ComboBox
        '
        Me.OC_TR_ComboBox.FormattingEnabled = True
        Me.OC_TR_ComboBox.Location = New System.Drawing.Point(203, 131)
        Me.OC_TR_ComboBox.Name = "OC_TR_ComboBox"
        Me.OC_TR_ComboBox.Size = New System.Drawing.Size(211, 21)
        Me.OC_TR_ComboBox.TabIndex = 108
        '
        'Dev_Other_Courses_Training_Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(554, 207)
        Me.Controls.Add(Me.OC_TR_ComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Safety_TR_Report_Button)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.OC_TR_End_Textbox)
        Me.Controls.Add(Me.OC_TR_Start_Textbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Dev_Other_Courses_Training_Reports"
        Me.Text = "Other Courses Training Reports Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Safety_TR_Report_Button As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OC_TR_End_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents OC_TR_Start_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OC_TR_ComboBox As System.Windows.Forms.ComboBox
End Class
