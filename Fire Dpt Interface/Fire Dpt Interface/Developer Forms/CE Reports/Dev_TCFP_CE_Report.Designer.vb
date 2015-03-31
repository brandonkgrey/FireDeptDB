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
        Me.TCFP_CE_Preview_Button = New System.Windows.Forms.Button()
        Me.TCFP_CE_Print_Button = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.FireCE_EndDate_Textbox = New System.Windows.Forms.TextBox()
        Me.FireCE_StartDate_Textbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SelectEmp_ComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'TCFP_CE_Preview_Button
        '
        Me.TCFP_CE_Preview_Button.Location = New System.Drawing.Point(315, 154)
        Me.TCFP_CE_Preview_Button.Name = "TCFP_CE_Preview_Button"
        Me.TCFP_CE_Preview_Button.Size = New System.Drawing.Size(81, 25)
        Me.TCFP_CE_Preview_Button.TabIndex = 86
        Me.TCFP_CE_Preview_Button.Text = "Preview"
        Me.TCFP_CE_Preview_Button.UseVisualStyleBackColor = True
        '
        'TCFP_CE_Print_Button
        '
        Me.TCFP_CE_Print_Button.Location = New System.Drawing.Point(188, 154)
        Me.TCFP_CE_Print_Button.Name = "TCFP_CE_Print_Button"
        Me.TCFP_CE_Print_Button.Size = New System.Drawing.Size(81, 25)
        Me.TCFP_CE_Print_Button.TabIndex = 85
        Me.TCFP_CE_Print_Button.Text = "Print"
        Me.TCFP_CE_Print_Button.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(458, 154)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(81, 25)
        Me.ExitButton.TabIndex = 80
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'FireCE_EndDate_Textbox
        '
        Me.FireCE_EndDate_Textbox.Location = New System.Drawing.Point(188, 112)
        Me.FireCE_EndDate_Textbox.Name = "FireCE_EndDate_Textbox"
        Me.FireCE_EndDate_Textbox.Size = New System.Drawing.Size(297, 20)
        Me.FireCE_EndDate_Textbox.TabIndex = 92
        '
        'FireCE_StartDate_Textbox
        '
        Me.FireCE_StartDate_Textbox.Location = New System.Drawing.Point(188, 68)
        Me.FireCE_StartDate_Textbox.Name = "FireCE_StartDate_Textbox"
        Me.FireCE_StartDate_Textbox.Size = New System.Drawing.Size(297, 20)
        Me.FireCE_StartDate_Textbox.TabIndex = 91
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "End Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Start Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 20)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Select Employee:"
        '
        'SelectEmp_ComboBox
        '
        Me.SelectEmp_ComboBox.FormattingEnabled = True
        Me.SelectEmp_ComboBox.Location = New System.Drawing.Point(188, 23)
        Me.SelectEmp_ComboBox.Name = "SelectEmp_ComboBox"
        Me.SelectEmp_ComboBox.Size = New System.Drawing.Size(297, 21)
        Me.SelectEmp_ComboBox.TabIndex = 87
        '
        'Dev_TCFP_CE_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 191)
        Me.Controls.Add(Me.FireCE_EndDate_Textbox)
        Me.Controls.Add(Me.FireCE_StartDate_Textbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SelectEmp_ComboBox)
        Me.Controls.Add(Me.TCFP_CE_Preview_Button)
        Me.Controls.Add(Me.TCFP_CE_Print_Button)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "Dev_TCFP_CE_Report"
        Me.Text = "TCFP CE Report Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TCFP_CE_Preview_Button As System.Windows.Forms.Button
    Friend WithEvents TCFP_CE_Print_Button As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents FireCE_EndDate_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents FireCE_StartDate_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SelectEmp_ComboBox As System.Windows.Forms.ComboBox
End Class
