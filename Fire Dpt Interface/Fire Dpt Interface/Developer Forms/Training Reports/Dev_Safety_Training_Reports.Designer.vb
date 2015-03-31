<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dev_Safety_Training_Reports
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Safe_TR_Start_Textbox = New System.Windows.Forms.TextBox()
        Me.Safe_TR_End_Textbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Safety_TR_Preview_Button = New System.Windows.Forms.Button()
        Me.Safety_TR_Print_Button = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Start:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "End:"
        '
        'Safe_TR_Start_Textbox
        '
        Me.Safe_TR_Start_Textbox.Location = New System.Drawing.Point(202, 68)
        Me.Safe_TR_Start_Textbox.Name = "Safe_TR_Start_Textbox"
        Me.Safe_TR_Start_Textbox.Size = New System.Drawing.Size(209, 20)
        Me.Safe_TR_Start_Textbox.TabIndex = 2
        '
        'Safe_TR_End_Textbox
        '
        Me.Safe_TR_End_Textbox.Location = New System.Drawing.Point(202, 108)
        Me.Safe_TR_End_Textbox.Name = "Safe_TR_End_Textbox"
        Me.Safe_TR_End_Textbox.Size = New System.Drawing.Size(209, 20)
        Me.Safe_TR_End_Textbox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(138, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(247, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Enter Date Range For Report"
        '
        'Safety_TR_Preview_Button
        '
        Me.Safety_TR_Preview_Button.Location = New System.Drawing.Point(330, 154)
        Me.Safety_TR_Preview_Button.Name = "Safety_TR_Preview_Button"
        Me.Safety_TR_Preview_Button.Size = New System.Drawing.Size(81, 25)
        Me.Safety_TR_Preview_Button.TabIndex = 98
        Me.Safety_TR_Preview_Button.Text = "Preview"
        Me.Safety_TR_Preview_Button.UseVisualStyleBackColor = True
        '
        'Safety_TR_Print_Button
        '
        Me.Safety_TR_Print_Button.Location = New System.Drawing.Point(202, 154)
        Me.Safety_TR_Print_Button.Name = "Safety_TR_Print_Button"
        Me.Safety_TR_Print_Button.Size = New System.Drawing.Size(81, 25)
        Me.Safety_TR_Print_Button.TabIndex = 97
        Me.Safety_TR_Print_Button.Text = "Print"
        Me.Safety_TR_Print_Button.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(458, 154)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(81, 25)
        Me.ExitButton.TabIndex = 96
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Dev_Safety_Training_Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 191)
        Me.Controls.Add(Me.Safety_TR_Preview_Button)
        Me.Controls.Add(Me.Safety_TR_Print_Button)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Safe_TR_End_Textbox)
        Me.Controls.Add(Me.Safe_TR_Start_Textbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Dev_Safety_Training_Reports"
        Me.Text = "Safety Training Reports"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Safe_TR_Start_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Safe_TR_End_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Safety_TR_Preview_Button As System.Windows.Forms.Button
    Friend WithEvents Safety_TR_Print_Button As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
End Class
