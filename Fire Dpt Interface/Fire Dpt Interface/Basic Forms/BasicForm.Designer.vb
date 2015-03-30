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
        Me.Personal_Info = New System.Windows.Forms.Button()
        Me.Certificates = New System.Windows.Forms.Button()
        Me.Logout = New System.Windows.Forms.Button()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.ExampleDBDataSet = New Fire_Dpt_Interface.ExampleDBDataSet()
        Me.Employee_InformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Employee_InformationTableAdapter = New Fire_Dpt_Interface.ExampleDBDataSetTableAdapters.Employee_InformationTableAdapter()
        Me.TableAdapterManager = New Fire_Dpt_Interface.ExampleDBDataSetTableAdapters.TableAdapterManager()
        Me.CollegeInfoButton = New System.Windows.Forms.Button()
        Me.AssignmentsButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.ExampleDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Employee_InformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Personal_Info
        '
        Me.Personal_Info.BackColor = System.Drawing.Color.Transparent
        Me.Personal_Info.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Personal_Info.FlatAppearance.BorderSize = 2
        Me.Personal_Info.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Personal_Info.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Personal_Info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Personal_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Personal_Info.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Personal_Info.Location = New System.Drawing.Point(27, 83)
        Me.Personal_Info.Name = "Personal_Info"
        Me.Personal_Info.Size = New System.Drawing.Size(101, 43)
        Me.Personal_Info.TabIndex = 0
        Me.Personal_Info.Text = "Personal Information"
        Me.Personal_Info.UseVisualStyleBackColor = False
        '
        'Certificates
        '
        Me.Certificates.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Certificates.FlatAppearance.BorderSize = 2
        Me.Certificates.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Certificates.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Certificates.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Certificates.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Certificates.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Certificates.Location = New System.Drawing.Point(27, 140)
        Me.Certificates.Name = "Certificates"
        Me.Certificates.Size = New System.Drawing.Size(101, 43)
        Me.Certificates.TabIndex = 1
        Me.Certificates.Text = "My Certificates"
        Me.Certificates.UseVisualStyleBackColor = True
        '
        'Logout
        '
        Me.Logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Logout.FlatAppearance.BorderSize = 2
        Me.Logout.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Logout.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Logout.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout.ForeColor = System.Drawing.Color.Red
        Me.Logout.Location = New System.Drawing.Point(162, 217)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(101, 39)
        Me.Logout.TabIndex = 2
        Me.Logout.Text = "Log Out "
        Me.Logout.UseVisualStyleBackColor = True
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(116, 9)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(189, 38)
        Me.UsernameLabel.TabIndex = 3
        Me.UsernameLabel.Text = "Main Menu"
        Me.UsernameLabel.Visible = False
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
        'CollegeInfoButton
        '
        Me.CollegeInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CollegeInfoButton.FlatAppearance.BorderSize = 2
        Me.CollegeInfoButton.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CollegeInfoButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CollegeInfoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CollegeInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CollegeInfoButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CollegeInfoButton.Location = New System.Drawing.Point(296, 83)
        Me.CollegeInfoButton.Name = "CollegeInfoButton"
        Me.CollegeInfoButton.Size = New System.Drawing.Size(101, 41)
        Me.CollegeInfoButton.TabIndex = 4
        Me.CollegeInfoButton.Text = "College Information"
        Me.CollegeInfoButton.UseVisualStyleBackColor = True
        '
        'AssignmentsButton
        '
        Me.AssignmentsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AssignmentsButton.FlatAppearance.BorderSize = 2
        Me.AssignmentsButton.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.AssignmentsButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.AssignmentsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AssignmentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AssignmentsButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AssignmentsButton.Location = New System.Drawing.Point(296, 140)
        Me.AssignmentsButton.Name = "AssignmentsButton"
        Me.AssignmentsButton.Size = New System.Drawing.Size(101, 41)
        Me.AssignmentsButton.TabIndex = 5
        Me.AssignmentsButton.Text = "My Assignments"
        Me.AssignmentsButton.UseVisualStyleBackColor = True
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
        'BasicForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(439, 289)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AssignmentsButton)
        Me.Controls.Add(Me.CollegeInfoButton)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.Certificates)
        Me.Controls.Add(Me.Personal_Info)
        Me.Name = "BasicForm"
        Me.Text = "Main Menu"
        CType(Me.ExampleDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Employee_InformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Personal_Info As System.Windows.Forms.Button
    Friend WithEvents Certificates As System.Windows.Forms.Button
    Friend WithEvents Logout As System.Windows.Forms.Button
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents ExampleDBDataSet As Fire_Dpt_Interface.ExampleDBDataSet
    Friend WithEvents Employee_InformationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Employee_InformationTableAdapter As Fire_Dpt_Interface.ExampleDBDataSetTableAdapters.Employee_InformationTableAdapter
    Friend WithEvents TableAdapterManager As Fire_Dpt_Interface.ExampleDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CollegeInfoButton As System.Windows.Forms.Button
    Friend WithEvents AssignmentsButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
