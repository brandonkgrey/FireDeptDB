<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dev_TCFP_CE_Report
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
        Me.TCFP_CE_Report_Button = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SelectEmp_ComboBox = New System.Windows.Forms.ComboBox()
        Me.TCFP_CE_SDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TCFP_CE_EDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'TCFP_CE_Report_Button
        '
        Me.TCFP_CE_Report_Button.Location = New System.Drawing.Point(349, 161)
        Me.TCFP_CE_Report_Button.Name = "TCFP_CE_Report_Button"
        Me.TCFP_CE_Report_Button.Size = New System.Drawing.Size(81, 25)
        Me.TCFP_CE_Report_Button.TabIndex = 86
        Me.TCFP_CE_Report_Button.Text = "Report"
        Me.TCFP_CE_Report_Button.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(464, 161)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(81, 25)
        Me.ExitButton.TabIndex = 80
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "End Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Start Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 20)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Select Employee:"
        '
        'SelectEmp_ComboBox
        '
        Me.SelectEmp_ComboBox.FormattingEnabled = True
        Me.SelectEmp_ComboBox.Location = New System.Drawing.Point(194, 30)
        Me.SelectEmp_ComboBox.Name = "SelectEmp_ComboBox"
        Me.SelectEmp_ComboBox.Size = New System.Drawing.Size(297, 21)
        Me.SelectEmp_ComboBox.TabIndex = 87
        '
        'TCFP_CE_SDateTimePicker
        '
        Me.TCFP_CE_SDateTimePicker.Location = New System.Drawing.Point(194, 72)
        Me.TCFP_CE_SDateTimePicker.Name = "TCFP_CE_SDateTimePicker"
        Me.TCFP_CE_SDateTimePicker.Size = New System.Drawing.Size(297, 20)
        Me.TCFP_CE_SDateTimePicker.TabIndex = 91
        '
        'TCFP_CE_EDateTimePicker
        '
        Me.TCFP_CE_EDateTimePicker.Location = New System.Drawing.Point(194, 116)
        Me.TCFP_CE_EDateTimePicker.Name = "TCFP_CE_EDateTimePicker"
        Me.TCFP_CE_EDateTimePicker.Size = New System.Drawing.Size(297, 20)
        Me.TCFP_CE_EDateTimePicker.TabIndex = 92
        '
        'Dev_TCFP_CE_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 191)
        Me.Controls.Add(Me.TCFP_CE_EDateTimePicker)
        Me.Controls.Add(Me.TCFP_CE_SDateTimePicker)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SelectEmp_ComboBox)
        Me.Controls.Add(Me.TCFP_CE_Report_Button)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "Dev_TCFP_CE_Report"
        Me.Text = "TCFP CE Report Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TCFP_CE_Report_Button As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SelectEmp_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TCFP_CE_SDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TCFP_CE_EDateTimePicker As System.Windows.Forms.DateTimePicker
End Class
