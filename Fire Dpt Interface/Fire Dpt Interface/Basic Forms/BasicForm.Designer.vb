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
        CType(Me.ExampleDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Employee_InformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Personal_Info
        '
        Me.Personal_Info.BackColor = System.Drawing.Color.Transparent
        Me.Personal_Info.Location = New System.Drawing.Point(137, 92)
        Me.Personal_Info.Name = "Personal_Info"
        Me.Personal_Info.Size = New System.Drawing.Size(101, 43)
        Me.Personal_Info.TabIndex = 0
        Me.Personal_Info.Text = "Personal Information"
        Me.Personal_Info.UseVisualStyleBackColor = False
        '
        'Certificates
        '
        Me.Certificates.Location = New System.Drawing.Point(137, 149)
        Me.Certificates.Name = "Certificates"
        Me.Certificates.Size = New System.Drawing.Size(101, 43)
        Me.Certificates.TabIndex = 1
        Me.Certificates.Text = "My Certificates"
        Me.Certificates.UseVisualStyleBackColor = True
        '
        'Logout
        '
        Me.Logout.Location = New System.Drawing.Point(349, 153)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(101, 39)
        Me.Logout.TabIndex = 2
        Me.Logout.Text = "Log Out "
        Me.Logout.UseVisualStyleBackColor = True
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(33, 19)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(392, 37)
        Me.UsernameLabel.TabIndex = 3
        Me.UsernameLabel.Text = "Welcome: Username Here"
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
        Me.CollegeInfoButton.Location = New System.Drawing.Point(349, 92)
        Me.CollegeInfoButton.Name = "CollegeInfoButton"
        Me.CollegeInfoButton.Size = New System.Drawing.Size(101, 41)
        Me.CollegeInfoButton.TabIndex = 4
        Me.CollegeInfoButton.Text = "College Information"
        Me.CollegeInfoButton.UseVisualStyleBackColor = True
        '
        'AssignmentsButton
        '
        Me.AssignmentsButton.Location = New System.Drawing.Point(137, 211)
        Me.AssignmentsButton.Name = "AssignmentsButton"
        Me.AssignmentsButton.Size = New System.Drawing.Size(101, 41)
        Me.AssignmentsButton.TabIndex = 5
        Me.AssignmentsButton.Text = "My Assignments"
        Me.AssignmentsButton.UseVisualStyleBackColor = True
        '
        'BasicForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 339)
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
End Class
