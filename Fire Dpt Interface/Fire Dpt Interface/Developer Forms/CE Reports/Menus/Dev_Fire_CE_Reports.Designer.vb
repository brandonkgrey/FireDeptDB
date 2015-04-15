<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dev_Fire_CE_Reports
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SelectEmp_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FireCE_Print_Button = New System.Windows.Forms.Button()
        Me.FireCE_Preview_Button = New System.Windows.Forms.Button()
        Me.FireCE_StartDate_Textbox = New System.Windows.Forms.TextBox()
        Me.FireCE_EndDate_Textbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(458, 157)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(81, 25)
        Me.ExitButton.TabIndex = 71
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SelectEmp_ComboBox
        '
        Me.SelectEmp_ComboBox.FormattingEnabled = True
        Me.SelectEmp_ComboBox.Location = New System.Drawing.Point(189, 22)
        Me.SelectEmp_ComboBox.Name = "SelectEmp_ComboBox"
        Me.SelectEmp_ComboBox.Size = New System.Drawing.Size(297, 21)
        Me.SelectEmp_ComboBox.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 20)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Select Employee:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Start Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "End Date:"
        '
        'FireCE_Print_Button
        '
        Me.FireCE_Print_Button.Location = New System.Drawing.Point(189, 157)
        Me.FireCE_Print_Button.Name = "FireCE_Print_Button"
        Me.FireCE_Print_Button.Size = New System.Drawing.Size(81, 25)
        Me.FireCE_Print_Button.TabIndex = 76
        Me.FireCE_Print_Button.Text = "Print"
        Me.FireCE_Print_Button.UseVisualStyleBackColor = True
        '
        'FireCE_Preview_Button
        '
        Me.FireCE_Preview_Button.Location = New System.Drawing.Point(311, 157)
        Me.FireCE_Preview_Button.Name = "FireCE_Preview_Button"
        Me.FireCE_Preview_Button.Size = New System.Drawing.Size(81, 25)
        Me.FireCE_Preview_Button.TabIndex = 77
        Me.FireCE_Preview_Button.Text = "Preview"
        Me.FireCE_Preview_Button.UseVisualStyleBackColor = True
        '
        'FireCE_StartDate_Textbox
        '
        Me.FireCE_StartDate_Textbox.Location = New System.Drawing.Point(189, 67)
        Me.FireCE_StartDate_Textbox.Name = "FireCE_StartDate_Textbox"
        Me.FireCE_StartDate_Textbox.Size = New System.Drawing.Size(297, 20)
        Me.FireCE_StartDate_Textbox.TabIndex = 78
        '
        'FireCE_EndDate_Textbox
        '
        Me.FireCE_EndDate_Textbox.Location = New System.Drawing.Point(189, 111)
        Me.FireCE_EndDate_Textbox.Name = "FireCE_EndDate_Textbox"
        Me.FireCE_EndDate_Textbox.Size = New System.Drawing.Size(297, 20)
        Me.FireCE_EndDate_Textbox.TabIndex = 79
        '
        'Dev_Fire_CE_Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 191)
        Me.Controls.Add(Me.FireCE_EndDate_Textbox)
        Me.Controls.Add(Me.FireCE_StartDate_Textbox)
        Me.Controls.Add(Me.FireCE_Preview_Button)
        Me.Controls.Add(Me.FireCE_Print_Button)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SelectEmp_ComboBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "Dev_Fire_CE_Reports"
        Me.Text = "Fire CE Report Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents SelectEmp_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FireCE_Print_Button As System.Windows.Forms.Button
    Friend WithEvents FireCE_Preview_Button As System.Windows.Forms.Button
    Friend WithEvents FireCE_StartDate_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents FireCE_EndDate_Textbox As System.Windows.Forms.TextBox
End Class
