<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeveloperForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeveloperForm))
        Me.Training_RecordsDataSet = New Fire_Dpt_Interface.Training_RecordsDataSet()
        Me.Emp_Info_AllBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Emp_Info_AllTableAdapter = New Fire_Dpt_Interface.Training_RecordsDataSetTableAdapters.Emp_Info_AllTableAdapter()
        Me.TableAdapterManager = New Fire_Dpt_Interface.Training_RecordsDataSetTableAdapters.TableAdapterManager()
        Me.OpenAccessFileDFButton = New System.Windows.Forms.Button()
        Me.EMSCertExpButton = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrainingReportsButton = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Class_Information_Button = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CertListButton = New System.Windows.Forms.Button()
        Me.LogOut_Button = New System.Windows.Forms.Button()
        Me.Emp_Info_Button = New System.Windows.Forms.Button()
        CType(Me.Training_RecordsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Emp_Info_AllBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EMSCertExpButton.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Training_RecordsDataSet
        '
        Me.Training_RecordsDataSet.DataSetName = "Training_RecordsDataSet"
        Me.Training_RecordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Emp_Info_AllBindingSource
        '
        Me.Emp_Info_AllBindingSource.DataMember = "Emp Info All"
        Me.Emp_Info_AllBindingSource.DataSource = Me.Training_RecordsDataSet
        '
        'Emp_Info_AllTableAdapter
        '
        Me.Emp_Info_AllTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Fire_and_EMS_OrganizationsTableAdapter = Nothing
        Me.TableAdapterManager.Fire_CertificationsTableAdapter = Nothing
        Me.TableAdapterManager.HM_Content_AreaTableAdapter = Nothing
        Me.TableAdapterManager.Non_FD_AttendanceTableAdapter = Nothing
        Me.TableAdapterManager.Other_CertificationsTableAdapter = Nothing
        Me.TableAdapterManager.Paul_File_ExportErrorsTableAdapter = Nothing
        Me.TableAdapterManager.TCFP_Subject_AreaTableAdapter = Nothing
        Me.TableAdapterManager.TCLEOSE_Subject_AreaTableAdapter = Nothing
        Me.TableAdapterManager.Training_AgenciesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Fire_Dpt_Interface.Training_RecordsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OpenAccessFileDFButton
        '
        Me.OpenAccessFileDFButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OpenAccessFileDFButton.FlatAppearance.BorderSize = 2
        Me.OpenAccessFileDFButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.OpenAccessFileDFButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OpenAccessFileDFButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OpenAccessFileDFButton.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenAccessFileDFButton.ForeColor = System.Drawing.Color.Blue
        Me.OpenAccessFileDFButton.Location = New System.Drawing.Point(182, 293)
        Me.OpenAccessFileDFButton.Name = "OpenAccessFileDFButton"
        Me.OpenAccessFileDFButton.Size = New System.Drawing.Size(103, 46)
        Me.OpenAccessFileDFButton.TabIndex = 23
        Me.OpenAccessFileDFButton.Text = "Open Access DB"
        Me.OpenAccessFileDFButton.UseVisualStyleBackColor = True
        '
        'EMSCertExpButton
        '
        Me.EMSCertExpButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.EMSCertExpButton.Controls.Add(Me.PictureBox1)
        Me.EMSCertExpButton.Controls.Add(Me.Label1)
        Me.EMSCertExpButton.Location = New System.Drawing.Point(0, 0)
        Me.EMSCertExpButton.Name = "EMSCertExpButton"
        Me.EMSCertExpButton.Size = New System.Drawing.Size(741, 145)
        Me.EMSCertExpButton.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 116)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(193, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(421, 59)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Training Records"
        '
        'TrainingReportsButton
        '
        Me.TrainingReportsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TrainingReportsButton.FlatAppearance.BorderSize = 2
        Me.TrainingReportsButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TrainingReportsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TrainingReportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TrainingReportsButton.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrainingReportsButton.Location = New System.Drawing.Point(624, 222)
        Me.TrainingReportsButton.Name = "TrainingReportsButton"
        Me.TrainingReportsButton.Size = New System.Drawing.Size(103, 46)
        Me.TrainingReportsButton.TabIndex = 21
        Me.TrainingReportsButton.Text = "Training Reports"
        Me.TrainingReportsButton.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 2
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(325, 170)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(103, 46)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "CE Reports"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Class_Information_Button
        '
        Me.Class_Information_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Class_Information_Button.FlatAppearance.BorderSize = 2
        Me.Class_Information_Button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Class_Information_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Class_Information_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Class_Information_Button.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Class_Information_Button.Location = New System.Drawing.Point(38, 222)
        Me.Class_Information_Button.Name = "Class_Information_Button"
        Me.Class_Information_Button.Size = New System.Drawing.Size(103, 46)
        Me.Class_Information_Button.TabIndex = 19
        Me.Class_Information_Button.Text = "Class Information"
        Me.Class_Information_Button.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 2
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(325, 222)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 67)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "EMS Certification Expiration"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CertListButton
        '
        Me.CertListButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CertListButton.FlatAppearance.BorderSize = 2
        Me.CertListButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CertListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CertListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CertListButton.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CertListButton.Location = New System.Drawing.Point(624, 170)
        Me.CertListButton.Name = "CertListButton"
        Me.CertListButton.Size = New System.Drawing.Size(103, 46)
        Me.CertListButton.TabIndex = 17
        Me.CertListButton.Text = "Certification Lists"
        Me.CertListButton.UseVisualStyleBackColor = True
        '
        'LogOut_Button
        '
        Me.LogOut_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LogOut_Button.FlatAppearance.BorderSize = 2
        Me.LogOut_Button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LogOut_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LogOut_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogOut_Button.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOut_Button.ForeColor = System.Drawing.Color.Red
        Me.LogOut_Button.Location = New System.Drawing.Point(483, 293)
        Me.LogOut_Button.Name = "LogOut_Button"
        Me.LogOut_Button.Size = New System.Drawing.Size(103, 46)
        Me.LogOut_Button.TabIndex = 16
        Me.LogOut_Button.Text = "Log Out"
        Me.LogOut_Button.UseVisualStyleBackColor = True
        '
        'Emp_Info_Button
        '
        Me.Emp_Info_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Emp_Info_Button.FlatAppearance.BorderSize = 2
        Me.Emp_Info_Button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Emp_Info_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Emp_Info_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Emp_Info_Button.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_Info_Button.Location = New System.Drawing.Point(38, 170)
        Me.Emp_Info_Button.Name = "Emp_Info_Button"
        Me.Emp_Info_Button.Size = New System.Drawing.Size(103, 46)
        Me.Emp_Info_Button.TabIndex = 15
        Me.Emp_Info_Button.Text = "Employee Information"
        Me.Emp_Info_Button.UseVisualStyleBackColor = True
        '
        'DeveloperForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(739, 351)
        Me.Controls.Add(Me.OpenAccessFileDFButton)
        Me.Controls.Add(Me.EMSCertExpButton)
        Me.Controls.Add(Me.TrainingReportsButton)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Class_Information_Button)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.CertListButton)
        Me.Controls.Add(Me.LogOut_Button)
        Me.Controls.Add(Me.Emp_Info_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "DeveloperForm"
        Me.Text = "Main Menu"
        CType(Me.Training_RecordsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Emp_Info_AllBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EMSCertExpButton.ResumeLayout(False)
        Me.EMSCertExpButton.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Training_RecordsDataSet As Fire_Dpt_Interface.Training_RecordsDataSet
    Friend WithEvents Emp_Info_AllBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Emp_Info_AllTableAdapter As Fire_Dpt_Interface.Training_RecordsDataSetTableAdapters.Emp_Info_AllTableAdapter
    Friend WithEvents TableAdapterManager As Fire_Dpt_Interface.Training_RecordsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OpenAccessFileDFButton As System.Windows.Forms.Button
    Friend WithEvents EMSCertExpButton As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TrainingReportsButton As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Class_Information_Button As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CertListButton As System.Windows.Forms.Button
    Friend WithEvents LogOut_Button As System.Windows.Forms.Button
    Friend WithEvents Emp_Info_Button As System.Windows.Forms.Button
End Class
