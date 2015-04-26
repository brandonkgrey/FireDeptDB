<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dev_EMS_Certifications_Expirations
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.EMS_Instructor_ExpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Training_Records_for_TAMUDataSet = New Fire_Dpt_Interface.Training_Records_for_TAMUDataSet()
        Me.EMS_XBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMS_XTableAdapter = New Fire_Dpt_Interface.Training_Records_for_TAMUDataSetTableAdapters.EMS_XTableAdapter()
        Me.TableAdapterManager = New Fire_Dpt_Interface.Training_Records_for_TAMUDataSetTableAdapters.TableAdapterManager()
        Me.EMS_Instructor_ExpTableAdapter = New Fire_Dpt_Interface.Training_Records_for_TAMUDataSetTableAdapters.EMS_Instructor_ExpTableAdapter()
        Me.Instructor = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.EMS_Instructor_ExpDataGridView = New System.Windows.Forms.DataGridView()
        Me.Personnel = New System.Windows.Forms.Label()
        Me.EMS_XDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpString = New System.Windows.Forms.Label()
        Me.CSFD = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.EMS_Instructor_ExpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Training_Records_for_TAMUDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMS_XBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.EMS_Instructor_ExpDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMS_XDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(641, 480)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(81, 25)
        Me.ExitButton.TabIndex = 56
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'EMS_Instructor_ExpBindingSource
        '
        Me.EMS_Instructor_ExpBindingSource.DataMember = "EMS Instructor Exp"
        Me.EMS_Instructor_ExpBindingSource.DataSource = Me.Training_Records_for_TAMUDataSet
        '
        'Training_Records_for_TAMUDataSet
        '
        Me.Training_Records_for_TAMUDataSet.DataSetName = "Training_Records_for_TAMUDataSet"
        Me.Training_Records_for_TAMUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMS_XBindingSource
        '
        Me.EMS_XBindingSource.DataMember = "EMS X"
        Me.EMS_XBindingSource.DataSource = Me.Training_Records_for_TAMUDataSet
        '
        'EMS_XTableAdapter
        '
        Me.EMS_XTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ARFF_Subject_AreaTableAdapter = Nothing
        Me.TableAdapterManager.Assignment_PayTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CertificatesTableAdapter = Nothing
        Me.TableAdapterManager.Certification_Name_ListTableAdapter = Nothing
        Me.TableAdapterManager.Class_Attendance_InformationTableAdapter = Nothing
        Me.TableAdapterManager.Class_InformationTableAdapter = Nothing
        Me.TableAdapterManager.CollegeTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.Employee_InformationTableAdapter = Nothing
        Me.TableAdapterManager.EMS_Certification_TypeTableAdapter = Nothing
        Me.TableAdapterManager.EMS_CertificationsTableAdapter = Nothing
        Me.TableAdapterManager.EMS_Content_AreaTableAdapter = Nothing
        Me.TableAdapterManager.EMS_OrientationTableAdapter = Nothing
        Me.TableAdapterManager.FFIII_OrientationTableAdapter = Nothing
        Me.TableAdapterManager.Fire_and_EMS_OrganizationsTableAdapter = Nothing
        Me.TableAdapterManager.Fire_CertificationsTableAdapter = Nothing
        Me.TableAdapterManager.HM_Content_AreaTableAdapter = Nothing
        Me.TableAdapterManager.Non_FD_AttendanceTableAdapter = Nothing
        Me.TableAdapterManager.Other_CertificationsTableAdapter = Nothing
        Me.TableAdapterManager.TCFP_Subject_AreaTableAdapter = Nothing
        Me.TableAdapterManager.TCLEOSE_Subject_AreaTableAdapter = Nothing
        Me.TableAdapterManager.Training_AgenciesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Fire_Dpt_Interface.Training_Records_for_TAMUDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EMS_Instructor_ExpTableAdapter
        '
        Me.EMS_Instructor_ExpTableAdapter.ClearBeforeFill = True
        '
        'Instructor
        '
        Me.Instructor.AutoSize = True
        Me.Instructor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Instructor.Location = New System.Drawing.Point(8, 285)
        Me.Instructor.Name = "Instructor"
        Me.Instructor.Size = New System.Drawing.Size(86, 24)
        Me.Instructor.TabIndex = 63
        Me.Instructor.Text = "Instructor"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.EMS_Instructor_ExpDataGridView)
        Me.Panel2.Location = New System.Drawing.Point(12, 312)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(548, 178)
        Me.Panel2.TabIndex = 62
        '
        'EMS_Instructor_ExpDataGridView
        '
        Me.EMS_Instructor_ExpDataGridView.AutoGenerateColumns = False
        Me.EMS_Instructor_ExpDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EMS_Instructor_ExpDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9})
        Me.EMS_Instructor_ExpDataGridView.DataSource = Me.EMS_Instructor_ExpBindingSource
        Me.EMS_Instructor_ExpDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EMS_Instructor_ExpDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.EMS_Instructor_ExpDataGridView.Name = "EMS_Instructor_ExpDataGridView"
        Me.EMS_Instructor_ExpDataGridView.Size = New System.Drawing.Size(548, 178)
        Me.EMS_Instructor_ExpDataGridView.TabIndex = 0
        '
        'Personnel
        '
        Me.Personnel.AutoSize = True
        Me.Personnel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Personnel.Location = New System.Drawing.Point(8, 99)
        Me.Personnel.Name = "Personnel"
        Me.Personnel.Size = New System.Drawing.Size(96, 24)
        Me.Personnel.TabIndex = 61
        Me.Personnel.Text = "Personnel"
        '
        'EMS_XDataGridView
        '
        Me.EMS_XDataGridView.AutoGenerateColumns = False
        Me.EMS_XDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EMS_XDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.EMS_XDataGridView.DataSource = Me.EMS_XBindingSource
        Me.EMS_XDataGridView.Location = New System.Drawing.Point(12, 126)
        Me.EMS_XDataGridView.Name = "EMS_XDataGridView"
        Me.EMS_XDataGridView.Size = New System.Drawing.Size(548, 156)
        Me.EMS_XDataGridView.TabIndex = 60
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Employee_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Employee ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TDH Level"
        Me.DataGridViewTextBoxColumn3.HeaderText = "TDH Level"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TDH Level Expiration Date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Expiration Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Expr1"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Days to Expiration"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Employee_ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Employee ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Expr1"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Days to Expiration"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'ExpString
        '
        Me.ExpString.AutoSize = True
        Me.ExpString.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpString.Location = New System.Drawing.Point(57, 82)
        Me.ExpString.Name = "ExpString"
        Me.ExpString.Size = New System.Drawing.Size(562, 17)
        Me.ExpString.TabIndex = 64
        Me.ExpString.Text = "This List is Compromised of Personnel whose EMS Certification will Expire within " & _
    "90 days"
        '
        'CSFD
        '
        Me.CSFD.AutoSize = True
        Me.CSFD.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CSFD.Location = New System.Drawing.Point(202, 18)
        Me.CSFD.Name = "CSFD"
        Me.CSFD.Size = New System.Drawing.Size(254, 18)
        Me.CSFD.TabIndex = 65
        Me.CSFD.Text = "College Station Fire Department "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(211, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 18)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "EMS Certification: Expiration"
        '
        'Dev_EMS_Certifications_Expirations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(724, 510)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CSFD)
        Me.Controls.Add(Me.ExpString)
        Me.Controls.Add(Me.Instructor)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Personnel)
        Me.Controls.Add(Me.EMS_XDataGridView)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "Dev_EMS_Certifications_Expirations"
        Me.Text = "EMS Certifications Expirations"
        CType(Me.EMS_Instructor_ExpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Training_Records_for_TAMUDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMS_XBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.EMS_Instructor_ExpDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMS_XDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Training_Records_for_TAMUDataSet As Fire_Dpt_Interface.Training_Records_for_TAMUDataSet
    Friend WithEvents EMS_XBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMS_XTableAdapter As Fire_Dpt_Interface.Training_Records_for_TAMUDataSetTableAdapters.EMS_XTableAdapter
    Friend WithEvents TableAdapterManager As Fire_Dpt_Interface.Training_Records_for_TAMUDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EMS_Instructor_ExpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMS_Instructor_ExpTableAdapter As Fire_Dpt_Interface.Training_Records_for_TAMUDataSetTableAdapters.EMS_Instructor_ExpTableAdapter
    Friend WithEvents Instructor As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents EMS_Instructor_ExpDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Personnel As System.Windows.Forms.Label
    Friend WithEvents EMS_XDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpString As System.Windows.Forms.Label
    Friend WithEvents CSFD As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
