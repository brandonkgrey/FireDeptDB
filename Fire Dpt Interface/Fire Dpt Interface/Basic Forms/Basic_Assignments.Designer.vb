﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Basic_Assignments
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
        Me.TypeLabel = New System.Windows.Forms.Label()
        Me.TextBox73 = New System.Windows.Forms.TextBox()
        Me.TextBox72 = New System.Windows.Forms.TextBox()
        Me.TextBox71 = New System.Windows.Forms.TextBox()
        Me.TextBox70 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CheckBox19 = New System.Windows.Forms.CheckBox()
        Me.CheckBox20 = New System.Windows.Forms.CheckBox()
        Me.CheckBox21 = New System.Windows.Forms.CheckBox()
        Me.CheckBox22 = New System.Windows.Forms.CheckBox()
        Me.Certificates = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Training_Records_EncryptedDataSet = New Fire_Dpt_Interface.Training_Records_EncryptedDataSet()
        Me.AssignmentPayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Assignment_PayTableAdapter = New Fire_Dpt_Interface.Training_Records_EncryptedDataSetTableAdapters.Assignment_PayTableAdapter()
        CType(Me.Training_Records_EncryptedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssignmentPayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TypeLabel
        '
        Me.TypeLabel.AutoSize = True
        Me.TypeLabel.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeLabel.Location = New System.Drawing.Point(51, 85)
        Me.TypeLabel.Name = "TypeLabel"
        Me.TypeLabel.Size = New System.Drawing.Size(63, 25)
        Me.TypeLabel.TabIndex = 43
        Me.TypeLabel.Text = "Type"
        '
        'TextBox73
        '
        Me.TextBox73.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssignmentPayBindingSource, "HazMat Received Date", True))
        Me.TextBox73.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox73.Location = New System.Drawing.Point(184, 139)
        Me.TextBox73.Name = "TextBox73"
        Me.TextBox73.Size = New System.Drawing.Size(163, 21)
        Me.TextBox73.TabIndex = 42
        '
        'TextBox72
        '
        Me.TextBox72.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssignmentPayBindingSource, "FAA Received Date", True))
        Me.TextBox72.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox72.Location = New System.Drawing.Point(184, 191)
        Me.TextBox72.Name = "TextBox72"
        Me.TextBox72.Size = New System.Drawing.Size(163, 21)
        Me.TextBox72.TabIndex = 41
        '
        'TextBox71
        '
        Me.TextBox71.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssignmentPayBindingSource, "Arson Received Date", True))
        Me.TextBox71.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox71.Location = New System.Drawing.Point(184, 165)
        Me.TextBox71.Name = "TextBox71"
        Me.TextBox71.Size = New System.Drawing.Size(163, 21)
        Me.TextBox71.TabIndex = 40
        '
        'TextBox70
        '
        Me.TextBox70.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssignmentPayBindingSource, "ARFF Received Date", True))
        Me.TextBox70.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox70.Location = New System.Drawing.Point(184, 113)
        Me.TextBox70.Name = "TextBox70"
        Me.TextBox70.Size = New System.Drawing.Size(163, 21)
        Me.TextBox70.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(215, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 25)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Received"
        '
        'CheckBox19
        '
        Me.CheckBox19.AutoSize = True
        Me.CheckBox19.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.AssignmentPayBindingSource, "FAA", True))
        Me.CheckBox19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox19.Location = New System.Drawing.Point(57, 193)
        Me.CheckBox19.Name = "CheckBox19"
        Me.CheckBox19.Size = New System.Drawing.Size(48, 17)
        Me.CheckBox19.TabIndex = 37
        Me.CheckBox19.Text = "FAA"
        Me.CheckBox19.UseVisualStyleBackColor = True
        '
        'CheckBox20
        '
        Me.CheckBox20.AutoSize = True
        Me.CheckBox20.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.AssignmentPayBindingSource, "Arson", True))
        Me.CheckBox20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox20.Location = New System.Drawing.Point(57, 167)
        Me.CheckBox20.Name = "CheckBox20"
        Me.CheckBox20.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox20.TabIndex = 36
        Me.CheckBox20.Text = "Arson"
        Me.CheckBox20.UseVisualStyleBackColor = True
        '
        'CheckBox21
        '
        Me.CheckBox21.AutoSize = True
        Me.CheckBox21.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.AssignmentPayBindingSource, "HazMat", True))
        Me.CheckBox21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox21.Location = New System.Drawing.Point(57, 141)
        Me.CheckBox21.Name = "CheckBox21"
        Me.CheckBox21.Size = New System.Drawing.Size(69, 17)
        Me.CheckBox21.TabIndex = 35
        Me.CheckBox21.Text = "Hazmat"
        Me.CheckBox21.UseVisualStyleBackColor = True
        '
        'CheckBox22
        '
        Me.CheckBox22.AutoSize = True
        Me.CheckBox22.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.AssignmentPayBindingSource, "ARFF", True))
        Me.CheckBox22.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox22.Location = New System.Drawing.Point(57, 115)
        Me.CheckBox22.Name = "CheckBox22"
        Me.CheckBox22.Size = New System.Drawing.Size(54, 17)
        Me.CheckBox22.TabIndex = 34
        Me.CheckBox22.Text = "ARFF"
        Me.CheckBox22.UseVisualStyleBackColor = True
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
        Me.Certificates.Location = New System.Drawing.Point(140, 248)
        Me.Certificates.Name = "Certificates"
        Me.Certificates.Size = New System.Drawing.Size(101, 43)
        Me.Certificates.TabIndex = 44
        Me.Certificates.Text = "Exit"
        Me.Certificates.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 38)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Assignments"
        '
        'Training_Records_EncryptedDataSet
        '
        Me.Training_Records_EncryptedDataSet.DataSetName = "Training_Records_EncryptedDataSet"
        Me.Training_Records_EncryptedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AssignmentPayBindingSource
        '
        Me.AssignmentPayBindingSource.DataMember = "Assignment Pay"
        Me.AssignmentPayBindingSource.DataSource = Me.Training_Records_EncryptedDataSet
        '
        'Assignment_PayTableAdapter
        '
        Me.Assignment_PayTableAdapter.ClearBeforeFill = True
        '
        'Basic_Assignments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(404, 321)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Certificates)
        Me.Controls.Add(Me.TypeLabel)
        Me.Controls.Add(Me.TextBox73)
        Me.Controls.Add(Me.TextBox72)
        Me.Controls.Add(Me.TextBox71)
        Me.Controls.Add(Me.TextBox70)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CheckBox19)
        Me.Controls.Add(Me.CheckBox20)
        Me.Controls.Add(Me.CheckBox21)
        Me.Controls.Add(Me.CheckBox22)
        Me.Name = "Basic_Assignments"
        Me.Text = "Basic_Assignments"
        CType(Me.Training_Records_EncryptedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssignmentPayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TypeLabel As System.Windows.Forms.Label
    Friend WithEvents TextBox73 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox72 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox71 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox70 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CheckBox19 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox20 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox21 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox22 As System.Windows.Forms.CheckBox
    Friend WithEvents Certificates As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Training_Records_EncryptedDataSet As Fire_Dpt_Interface.Training_Records_EncryptedDataSet
    Friend WithEvents AssignmentPayBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Assignment_PayTableAdapter As Fire_Dpt_Interface.Training_Records_EncryptedDataSetTableAdapters.Assignment_PayTableAdapter
End Class
