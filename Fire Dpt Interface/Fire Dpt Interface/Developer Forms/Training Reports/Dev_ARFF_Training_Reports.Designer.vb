<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dev_ARFF_Training_Reports
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
        Me.Safety_TR_Preview_Button = New System.Windows.Forms.Button()
        Me.Safety_TR_Print_Button = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ARFF_TR_End_Textbox = New System.Windows.Forms.TextBox()
        Me.ARFF_TR_Start_Textbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Safety_TR_Preview_Button
        '
        Me.Safety_TR_Preview_Button.Location = New System.Drawing.Point(329, 156)
        Me.Safety_TR_Preview_Button.Name = "Safety_TR_Preview_Button"
        Me.Safety_TR_Preview_Button.Size = New System.Drawing.Size(81, 25)
        Me.Safety_TR_Preview_Button.TabIndex = 106
        Me.Safety_TR_Preview_Button.Text = "Preview"
        Me.Safety_TR_Preview_Button.UseVisualStyleBackColor = True
        '
        'Safety_TR_Print_Button
        '
        Me.Safety_TR_Print_Button.Location = New System.Drawing.Point(201, 156)
        Me.Safety_TR_Print_Button.Name = "Safety_TR_Print_Button"
        Me.Safety_TR_Print_Button.Size = New System.Drawing.Size(81, 25)
        Me.Safety_TR_Print_Button.TabIndex = 105
        Me.Safety_TR_Print_Button.Text = "Print"
        Me.Safety_TR_Print_Button.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(457, 156)
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
        Me.Label3.Location = New System.Drawing.Point(137, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(247, 20)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Enter Date Range For Report"
        '
        'ARFF_TR_End_Textbox
        '
        Me.ARFF_TR_End_Textbox.Location = New System.Drawing.Point(201, 110)
        Me.ARFF_TR_End_Textbox.Name = "ARFF_TR_End_Textbox"
        Me.ARFF_TR_End_Textbox.Size = New System.Drawing.Size(209, 20)
        Me.ARFF_TR_End_Textbox.TabIndex = 102
        '
        'ARFF_TR_Start_Textbox
        '
        Me.ARFF_TR_Start_Textbox.Location = New System.Drawing.Point(201, 70)
        Me.ARFF_TR_Start_Textbox.Name = "ARFF_TR_Start_Textbox"
        Me.ARFF_TR_Start_Textbox.Size = New System.Drawing.Size(209, 20)
        Me.ARFF_TR_Start_Textbox.TabIndex = 101
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "End:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Start:"
        '
        'Dev_ARFF_Training_Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 191)
        Me.Controls.Add(Me.Safety_TR_Preview_Button)
        Me.Controls.Add(Me.Safety_TR_Print_Button)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ARFF_TR_End_Textbox)
        Me.Controls.Add(Me.ARFF_TR_Start_Textbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Dev_ARFF_Training_Reports"
        Me.Text = "ARFF Training Reports Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Safety_TR_Preview_Button As System.Windows.Forms.Button
    Friend WithEvents Safety_TR_Print_Button As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ARFF_TR_End_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents ARFF_TR_Start_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
