<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupervisorEMSCertificationExpiration
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
        Me.SupervisorEMSXDataset = New Fire_Dpt_Interface.SupervisorEMSXDataset()
        Me.SupervisorEMSX_FilterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupervisorEMSX_FilterTableAdapter = New Fire_Dpt_Interface.SupervisorEMSXDatasetTableAdapters.SupervisorEMSX_FilterTableAdapter()
        Me.TableAdapterManager = New Fire_Dpt_Interface.SupervisorEMSXDatasetTableAdapters.TableAdapterManager()
        Me.SupervisorEMSX_FilterDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CSFD = New System.Windows.Forms.Label()
        Me.ExpString = New System.Windows.Forms.Label()
        Me.Personnel = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Instructor = New System.Windows.Forms.Label()
        Me.SupervisorEMS_Instruct_X_Dataset = New Fire_Dpt_Interface.SupervisorEMS_Instruct_X_Dataset()
        Me.SupervisorEMS_InstructXBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupervisorEMS_InstructXTableAdapter = New Fire_Dpt_Interface.SupervisorEMS_Instruct_X_DatasetTableAdapters.SupervisorEMS_InstructXTableAdapter()
        Me.TableAdapterManager1 = New Fire_Dpt_Interface.SupervisorEMS_Instruct_X_DatasetTableAdapters.TableAdapterManager()
        Me.SupervisorEMS_InstructXDataGridView = New System.Windows.Forms.DataGridView()
        Me.SupervisorFilterDataSet1 = New Fire_Dpt_Interface.SupervisorFilterDataSet()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SupervisorEMSXDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupervisorEMSX_FilterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupervisorEMSX_FilterDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupervisorEMS_Instruct_X_Dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupervisorEMS_InstructXBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupervisorEMS_InstructXDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupervisorFilterDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SupervisorEMSXDataset
        '
        Me.SupervisorEMSXDataset.DataSetName = "SupervisorEMSXDataset"
        Me.SupervisorEMSXDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupervisorEMSX_FilterBindingSource
        '
        Me.SupervisorEMSX_FilterBindingSource.DataMember = "SupervisorEMSX_Filter"
        Me.SupervisorEMSX_FilterBindingSource.DataSource = Me.SupervisorEMSXDataset
        '
        'SupervisorEMSX_FilterTableAdapter
        '
        Me.SupervisorEMSX_FilterTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = Fire_Dpt_Interface.SupervisorEMSXDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SupervisorEMSX_FilterDataGridView
        '
        Me.SupervisorEMSX_FilterDataGridView.AutoGenerateColumns = False
        Me.SupervisorEMSX_FilterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SupervisorEMSX_FilterDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.SupervisorEMSX_FilterDataGridView.DataSource = Me.SupervisorEMSX_FilterBindingSource
        Me.SupervisorEMSX_FilterDataGridView.Location = New System.Drawing.Point(12, 126)
        Me.SupervisorEMSX_FilterDataGridView.Name = "SupervisorEMSX_FilterDataGridView"
        Me.SupervisorEMSX_FilterDataGridView.Size = New System.Drawing.Size(548, 156)
        Me.SupervisorEMSX_FilterDataGridView.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(235, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 18)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "EMS Certification: Expiration"
        '
        'CSFD
        '
        Me.CSFD.AutoSize = True
        Me.CSFD.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CSFD.Location = New System.Drawing.Point(226, 18)
        Me.CSFD.Name = "CSFD"
        Me.CSFD.Size = New System.Drawing.Size(254, 18)
        Me.CSFD.TabIndex = 69
        Me.CSFD.Text = "College Station Fire Department "
        '
        'ExpString
        '
        Me.ExpString.AutoSize = True
        Me.ExpString.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpString.Location = New System.Drawing.Point(81, 82)
        Me.ExpString.Name = "ExpString"
        Me.ExpString.Size = New System.Drawing.Size(562, 17)
        Me.ExpString.TabIndex = 68
        Me.ExpString.Text = "This List is Compromised of Personnel whose EMS Certification will Expire within " & _
    "90 days"
        '
        'Personnel
        '
        Me.Personnel.AutoSize = True
        Me.Personnel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Personnel.Location = New System.Drawing.Point(12, 99)
        Me.Personnel.Name = "Personnel"
        Me.Personnel.Size = New System.Drawing.Size(96, 24)
        Me.Personnel.TabIndex = 67
        Me.Personnel.Text = "Personnel"
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
        'Instructor
        '
        Me.Instructor.AutoSize = True
        Me.Instructor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Instructor.Location = New System.Drawing.Point(12, 285)
        Me.Instructor.Name = "Instructor"
        Me.Instructor.Size = New System.Drawing.Size(86, 24)
        Me.Instructor.TabIndex = 71
        Me.Instructor.Text = "Instructor"
        '
        'SupervisorEMS_Instruct_X_Dataset
        '
        Me.SupervisorEMS_Instruct_X_Dataset.DataSetName = "SupervisorEMS_Instruct_X_Dataset"
        Me.SupervisorEMS_Instruct_X_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupervisorEMS_InstructXBindingSource
        '
        Me.SupervisorEMS_InstructXBindingSource.DataMember = "SupervisorEMS_InstructX"
        Me.SupervisorEMS_InstructXBindingSource.DataSource = Me.SupervisorEMS_Instruct_X_Dataset
        '
        'SupervisorEMS_InstructXTableAdapter
        '
        Me.SupervisorEMS_InstructXTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = Fire_Dpt_Interface.SupervisorEMS_Instruct_X_DatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SupervisorEMS_InstructXDataGridView
        '
        Me.SupervisorEMS_InstructXDataGridView.AutoGenerateColumns = False
        Me.SupervisorEMS_InstructXDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SupervisorEMS_InstructXDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.SupervisorEMS_InstructXDataGridView.DataSource = Me.SupervisorEMS_InstructXBindingSource
        Me.SupervisorEMS_InstructXDataGridView.Location = New System.Drawing.Point(12, 325)
        Me.SupervisorEMS_InstructXDataGridView.Name = "SupervisorEMS_InstructXDataGridView"
        Me.SupervisorEMS_InstructXDataGridView.Size = New System.Drawing.Size(548, 156)
        Me.SupervisorEMS_InstructXDataGridView.TabIndex = 71
        '
        'SupervisorFilterDataSet1
        '
        Me.SupervisorFilterDataSet1.DataSetName = "SupervisorFilterDataSet"
        Me.SupervisorFilterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(631, 473)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(81, 25)
        Me.ExitButton.TabIndex = 72
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
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
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TDH Instructor Expiration Date"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Expiration Date"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Expr1"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Days to Expiration"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'SupervisorEMSCertificationExpiration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(724, 510)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SupervisorEMS_InstructXDataGridView)
        Me.Controls.Add(Me.Instructor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CSFD)
        Me.Controls.Add(Me.ExpString)
        Me.Controls.Add(Me.Personnel)
        Me.Controls.Add(Me.SupervisorEMSX_FilterDataGridView)
        Me.Name = "SupervisorEMSCertificationExpiration"
        Me.Text = "SupervisorEMSCertificationExpirationFilter"
        CType(Me.SupervisorEMSXDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupervisorEMSX_FilterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupervisorEMSX_FilterDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupervisorEMS_Instruct_X_Dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupervisorEMS_InstructXBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupervisorEMS_InstructXDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupervisorFilterDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SupervisorEMSXDataset As Fire_Dpt_Interface.SupervisorEMSXDataset
    Friend WithEvents SupervisorEMSX_FilterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupervisorEMSX_FilterTableAdapter As Fire_Dpt_Interface.SupervisorEMSXDatasetTableAdapters.SupervisorEMSX_FilterTableAdapter
    Friend WithEvents TableAdapterManager As Fire_Dpt_Interface.SupervisorEMSXDatasetTableAdapters.TableAdapterManager
    Friend WithEvents SupervisorEMSX_FilterDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CSFD As System.Windows.Forms.Label
    Friend WithEvents ExpString As System.Windows.Forms.Label
    Friend WithEvents Personnel As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Instructor As System.Windows.Forms.Label
    Friend WithEvents SupervisorEMS_Instruct_X_Dataset As Fire_Dpt_Interface.SupervisorEMS_Instruct_X_Dataset
    Friend WithEvents SupervisorEMS_InstructXBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupervisorEMS_InstructXTableAdapter As Fire_Dpt_Interface.SupervisorEMS_Instruct_X_DatasetTableAdapters.SupervisorEMS_InstructXTableAdapter
    Friend WithEvents TableAdapterManager1 As Fire_Dpt_Interface.SupervisorEMS_Instruct_X_DatasetTableAdapters.TableAdapterManager
    Friend WithEvents SupervisorEMS_InstructXDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SupervisorFilterDataSet1 As Fire_Dpt_Interface.SupervisorFilterDataSet
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
