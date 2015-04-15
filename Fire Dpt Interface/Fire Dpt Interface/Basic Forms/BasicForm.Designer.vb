<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BasicForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BasicForm))
        Me.Personal_InfoBFButton = New System.Windows.Forms.Button()
        Me.MyCertifcatesBFButton = New System.Windows.Forms.Button()
        Me.LogoutBFButton = New System.Windows.Forms.Button()
        Me.ExampleDBDataSet = New Fire_Dpt_Interface.ExampleDBDataSet()
        Me.Employee_InformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Employee_InformationTableAdapter = New Fire_Dpt_Interface.ExampleDBDataSetTableAdapters.Employee_InformationTableAdapter()
        Me.TableAdapterManager = New Fire_Dpt_Interface.ExampleDBDataSetTableAdapters.TableAdapterManager()
        Me.OtherCertsBFButton = New System.Windows.Forms.Button()
        Me.AssignmentsBFButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FireCertsBFButton = New System.Windows.Forms.Button()
        Me.EMSCertsBFButton = New System.Windows.Forms.Button()
        Me.BasicMenuTitle = New System.Windows.Forms.Label()
        CType(Me.ExampleDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Employee_InformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Personal_InfoBFButton
        '
        Me.Personal_InfoBFButton.BackColor = System.Drawing.Color.Transparent
        Me.Personal_InfoBFButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Personal_InfoBFButton.FlatAppearance.BorderSize = 2
        Me.Personal_InfoBFButton.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Personal_InfoBFButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Personal_InfoBFButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Personal_InfoBFButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Personal_InfoBFButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Personal_InfoBFButton.Location = New System.Drawing.Point(23, 73)
        Me.Personal_InfoBFButton.Name = "Personal_InfoBFButton"
        Me.Personal_InfoBFButton.Size = New System.Drawing.Size(101, 43)
        Me.Personal_InfoBFButton.TabIndex = 0
        Me.Personal_InfoBFButton.Text = "Personal Information"
        Me.Personal_InfoBFButton.UseVisualStyleBackColor = False
        '
        'MyCertifcatesBFButton
        '
        Me.MyCertifcatesBFButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MyCertifcatesBFButton.FlatAppearance.BorderSize = 2
        Me.MyCertifcatesBFButton.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MyCertifcatesBFButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MyCertifcatesBFButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MyCertifcatesBFButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyCertifcatesBFButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyCertifcatesBFButton.Location = New System.Drawing.Point(296, 120)
        Me.MyCertifcatesBFButton.Name = "MyCertifcatesBFButton"
        Me.MyCertifcatesBFButton.Size = New System.Drawing.Size(101, 43)
        Me.MyCertifcatesBFButton.TabIndex = 1
        Me.MyCertifcatesBFButton.Text = "My Certificates"
        Me.MyCertifcatesBFButton.UseVisualStyleBackColor = True
        '
        'LogoutBFButton
        '
        Me.LogoutBFButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LogoutBFButton.FlatAppearance.BorderSize = 2
        Me.LogoutBFButton.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LogoutBFButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LogoutBFButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LogoutBFButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutBFButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutBFButton.ForeColor = System.Drawing.Color.Red
        Me.LogoutBFButton.Location = New System.Drawing.Point(162, 217)
        Me.LogoutBFButton.Name = "LogoutBFButton"
        Me.LogoutBFButton.Size = New System.Drawing.Size(101, 39)
        Me.LogoutBFButton.TabIndex = 2
        Me.LogoutBFButton.Text = "Log Out "
        Me.LogoutBFButton.UseVisualStyleBackColor = True
        '
        'ExampleDBDataSet
        '
        Me.ExampleDBDataSet.DataSetName = "ExampleDBDataSet"
        Me.ExampleDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Employee_InformationBindingSource
        '
        Me.Employee_InformationBindingSource.DataMember = "Employee Information"
        Me.Employee_InformationBindingSource.DataSource = Me.ExampleDBDataSet
        '
        'Employee_InformationTableAdapter
        '
        Me.Employee_InformationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Employee_InformationTableAdapter = Me.Employee_InformationTableAdapter
        Me.TableAdapterManager.UpdateOrder = Fire_Dpt_Interface.ExampleDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OtherCertsBFButton
        '
        Me.OtherCertsBFButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OtherCertsBFButton.FlatAppearance.BorderSize = 2
        Me.OtherCertsBFButton.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.OtherCertsBFButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.OtherCertsBFButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OtherCertsBFButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OtherCertsBFButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OtherCertsBFButton.Location = New System.Drawing.Point(296, 73)
        Me.OtherCertsBFButton.Name = "OtherCertsBFButton"
        Me.OtherCertsBFButton.Size = New System.Drawing.Size(101, 41)
        Me.OtherCertsBFButton.TabIndex = 4
        Me.OtherCertsBFButton.Text = "Other Certifications"
        Me.OtherCertsBFButton.UseVisualStyleBackColor = True
        '
        'AssignmentsBFButton
        '
        Me.AssignmentsBFButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AssignmentsBFButton.FlatAppearance.BorderSize = 2
        Me.AssignmentsBFButton.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.AssignmentsBFButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.AssignmentsBFButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AssignmentsBFButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AssignmentsBFButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AssignmentsBFButton.Location = New System.Drawing.Point(296, 169)
        Me.AssignmentsBFButton.Name = "AssignmentsBFButton"
        Me.AssignmentsBFButton.Size = New System.Drawing.Size(101, 41)
        Me.AssignmentsBFButton.TabIndex = 5
        Me.AssignmentsBFButton.Text = "My Assignments"
        Me.AssignmentsBFButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(148, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 120)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'FireCertsBFButton
        '
        Me.FireCertsBFButton.BackColor = System.Drawing.Color.Transparent
        Me.FireCertsBFButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FireCertsBFButton.FlatAppearance.BorderSize = 2
        Me.FireCertsBFButton.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.FireCertsBFButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.FireCertsBFButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FireCertsBFButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FireCertsBFButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FireCertsBFButton.Location = New System.Drawing.Point(23, 122)
        Me.FireCertsBFButton.Name = "FireCertsBFButton"
        Me.FireCertsBFButton.Size = New System.Drawing.Size(101, 43)
        Me.FireCertsBFButton.TabIndex = 7
        Me.FireCertsBFButton.Text = "Fire Certifications"
        Me.FireCertsBFButton.UseVisualStyleBackColor = False
        '
        'EMSCertsBFButton
        '
        Me.EMSCertsBFButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EMSCertsBFButton.FlatAppearance.BorderSize = 2
        Me.EMSCertsBFButton.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.EMSCertsBFButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.EMSCertsBFButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EMSCertsBFButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EMSCertsBFButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMSCertsBFButton.Location = New System.Drawing.Point(23, 171)
        Me.EMSCertsBFButton.Name = "EMSCertsBFButton"
        Me.EMSCertsBFButton.Size = New System.Drawing.Size(101, 41)
        Me.EMSCertsBFButton.TabIndex = 8
        Me.EMSCertsBFButton.Text = "EMS Certifications"
        Me.EMSCertsBFButton.UseVisualStyleBackColor = True
        '
        'BasicMenuTitle
        '
        Me.BasicMenuTitle.AutoSize = True
        Me.BasicMenuTitle.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicMenuTitle.Location = New System.Drawing.Point(117, 9)
        Me.BasicMenuTitle.Name = "BasicMenuTitle"
        Me.BasicMenuTitle.Size = New System.Drawing.Size(189, 38)
        Me.BasicMenuTitle.TabIndex = 9
        Me.BasicMenuTitle.Text = "Main Menu"
        '
        'BasicForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(439, 289)
        Me.Controls.Add(Me.BasicMenuTitle)
        Me.Controls.Add(Me.EMSCertsBFButton)
        Me.Controls.Add(Me.FireCertsBFButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AssignmentsBFButton)
        Me.Controls.Add(Me.OtherCertsBFButton)
        Me.Controls.Add(Me.LogoutBFButton)
        Me.Controls.Add(Me.MyCertifcatesBFButton)
        Me.Controls.Add(Me.Personal_InfoBFButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "BasicForm"
        Me.Text = "Main Menu"
        CType(Me.ExampleDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Employee_InformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Personal_InfoBFButton As System.Windows.Forms.Button
    Friend WithEvents MyCertifcatesBFButton As System.Windows.Forms.Button
    Friend WithEvents LogoutBFButton As System.Windows.Forms.Button
    Friend WithEvents ExampleDBDataSet As Fire_Dpt_Interface.ExampleDBDataSet
    Friend WithEvents Employee_InformationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Employee_InformationTableAdapter As Fire_Dpt_Interface.ExampleDBDataSetTableAdapters.Employee_InformationTableAdapter
    Friend WithEvents TableAdapterManager As Fire_Dpt_Interface.ExampleDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OtherCertsBFButton As System.Windows.Forms.Button
    Friend WithEvents AssignmentsBFButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents FireCertsBFButton As System.Windows.Forms.Button
    Friend WithEvents EMSCertsBFButton As System.Windows.Forms.Button
    Friend WithEvents BasicMenuTitle As System.Windows.Forms.Label
End Class
