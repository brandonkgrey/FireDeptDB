<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Indivdual_Employee_Report_View
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.QueryEmployeeInformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Query_Indivual_Employee = New Fire_Dpt_Interface.Query_Indivual_Employee()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.QueryEmployeeInformationTableAdapter = New Fire_Dpt_Interface.Query_Indivual_EmployeeTableAdapters.QueryEmployeeInformationTableAdapter()
        Me.TableAdapterManager = New Fire_Dpt_Interface.Query_Indivual_EmployeeTableAdapters.TableAdapterManager()
        CType(Me.QueryEmployeeInformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query_Indivual_Employee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QueryEmployeeInformationBindingSource
        '
        Me.QueryEmployeeInformationBindingSource.DataMember = "QueryEmployeeInformation"
        Me.QueryEmployeeInformationBindingSource.DataSource = Me.Query_Indivual_Employee
        '
        'Query_Indivual_Employee
        '
        Me.Query_Indivual_Employee.DataSetName = "Query_Indivual_Employee"
        Me.Query_Indivual_Employee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource2.Name = "TestReport"
        ReportDataSource2.Value = Me.QueryEmployeeInformationBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Fire_Dpt_Interface.Individual_Employee_Report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-1, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(843, 263)
        Me.ReportViewer1.TabIndex = 0
        '
        'QueryEmployeeInformationTableAdapter
        '
        Me.QueryEmployeeInformationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = Fire_Dpt_Interface.Query_Indivual_EmployeeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Indivdual_Employee_Report_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 278)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Indivdual_Employee_Report_View"
        Me.Text = "Individual Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.QueryEmployeeInformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query_Indivual_Employee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Query_Indivual_Employee As Fire_Dpt_Interface.Query_Indivual_Employee
    Friend WithEvents QueryEmployeeInformationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QueryEmployeeInformationTableAdapter As Fire_Dpt_Interface.Query_Indivual_EmployeeTableAdapters.QueryEmployeeInformationTableAdapter
    Friend WithEvents TableAdapterManager As Fire_Dpt_Interface.Query_Indivual_EmployeeTableAdapters.TableAdapterManager
End Class
