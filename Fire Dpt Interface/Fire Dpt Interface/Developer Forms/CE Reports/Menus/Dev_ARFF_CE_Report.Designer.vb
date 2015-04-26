<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dev_ARFF_CE_Report
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
        Me.components = New System.ComponentModel.Container()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SelectEmp_ComboBox = New System.Windows.Forms.ComboBox()
        Me.EmployeeInformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Training_Records_for_TAMUDataSet = New Fire_Dpt_Interface.Training_Records_for_TAMUDataSet()
        Me.ARFF_CE_Report_Button = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Start_Date_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.End_Date_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Employee_InformationTableAdapter = New Fire_Dpt_Interface.Training_Records_for_TAMUDataSetTableAdapters.Employee_InformationTableAdapter()
        CType(Me.EmployeeInformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Training_Records_for_TAMUDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "End Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Start Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 20)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Select Employee:"
        '
        'SelectEmp_ComboBox
        '
        Me.SelectEmp_ComboBox.DataSource = Me.EmployeeInformationBindingSource
        Me.SelectEmp_ComboBox.DisplayMember = "Name"
        Me.SelectEmp_ComboBox.FormattingEnabled = True
        Me.SelectEmp_ComboBox.Location = New System.Drawing.Point(194, 27)
        Me.SelectEmp_ComboBox.Name = "SelectEmp_ComboBox"
        Me.SelectEmp_ComboBox.Size = New System.Drawing.Size(297, 21)
        Me.SelectEmp_ComboBox.TabIndex = 96
        '
        'EmployeeInformationBindingSource
        '
        Me.EmployeeInformationBindingSource.DataMember = "Employee Information"
        Me.EmployeeInformationBindingSource.DataSource = Me.Training_Records_for_TAMUDataSet
        '
        'Training_Records_for_TAMUDataSet
        '
        Me.Training_Records_for_TAMUDataSet.DataSetName = "Training_Records_for_TAMUDataSet"
        Me.Training_Records_for_TAMUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ARFF_CE_Report_Button
        '
        Me.ARFF_CE_Report_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ARFF_CE_Report_Button.FlatAppearance.BorderSize = 2
        Me.ARFF_CE_Report_Button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ARFF_CE_Report_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ARFF_CE_Report_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ARFF_CE_Report_Button.Location = New System.Drawing.Point(352, 158)
        Me.ARFF_CE_Report_Button.Name = "ARFF_CE_Report_Button"
        Me.ARFF_CE_Report_Button.Size = New System.Drawing.Size(81, 25)
        Me.ARFF_CE_Report_Button.TabIndex = 95
        Me.ARFF_CE_Report_Button.Text = "Report"
        Me.ARFF_CE_Report_Button.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ExitButton.FlatAppearance.BorderSize = 2
        Me.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Location = New System.Drawing.Point(464, 158)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(81, 25)
        Me.ExitButton.TabIndex = 93
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Start_Date_DateTimePicker
        '
        Me.Start_Date_DateTimePicker.CustomFormat = ""
        Me.Start_Date_DateTimePicker.Location = New System.Drawing.Point(194, 70)
        Me.Start_Date_DateTimePicker.Name = "Start_Date_DateTimePicker"
        Me.Start_Date_DateTimePicker.Size = New System.Drawing.Size(297, 20)
        Me.Start_Date_DateTimePicker.TabIndex = 100
        '
        'End_Date_DateTimePicker
        '
        Me.End_Date_DateTimePicker.Location = New System.Drawing.Point(194, 113)
        Me.End_Date_DateTimePicker.Name = "End_Date_DateTimePicker"
        Me.End_Date_DateTimePicker.Size = New System.Drawing.Size(297, 20)
        Me.End_Date_DateTimePicker.TabIndex = 101
        '
        'Employee_InformationTableAdapter
        '
        Me.Employee_InformationTableAdapter.ClearBeforeFill = True
        '
        'Dev_ARFF_CE_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(551, 191)
        Me.Controls.Add(Me.End_Date_DateTimePicker)
        Me.Controls.Add(Me.Start_Date_DateTimePicker)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SelectEmp_ComboBox)
        Me.Controls.Add(Me.ARFF_CE_Report_Button)
        Me.Controls.Add(Me.ExitButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Dev_ARFF_CE_Report"
        Me.Text = "ARFF CE Report Menu"
        CType(Me.EmployeeInformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Training_Records_for_TAMUDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SelectEmp_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ARFF_CE_Report_Button As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Start_Date_DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents End_Date_DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Training_Records_for_TAMUDataSet As Fire_Dpt_Interface.Training_Records_for_TAMUDataSet
    Friend WithEvents EmployeeInformationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Employee_InformationTableAdapter As Fire_Dpt_Interface.Training_Records_for_TAMUDataSetTableAdapters.Employee_InformationTableAdapter
End Class
