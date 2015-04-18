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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.QueryEmployeeInformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Query_Indivual_Employee = New Fire_Dpt_Interface.Query_Indivual_Employee()
        Me.TableAdapterManager = New Fire_Dpt_Interface.Query_Indivual_EmployeeTableAdapters.TableAdapterManager()
        Me.QueryEmployeeInformationTableAdapter = New Fire_Dpt_Interface.Query_Indivual_EmployeeTableAdapters.QueryEmployeeInformationTableAdapter()
        Me.Emp_InfoReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = Fire_Dpt_Interface.Query_Indivual_EmployeeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'QueryEmployeeInformationTableAdapter
        '
        Me.QueryEmployeeInformationTableAdapter.ClearBeforeFill = True
        '
        'Emp_InfoReportViewer
        '
        Me.Emp_InfoReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "Individual_Employee_Info_Report"
        ReportDataSource1.Value = Me.QueryEmployeeInformationBindingSource
        Me.Emp_InfoReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Emp_InfoReportViewer.LocalReport.ReportEmbeddedResource = "Fire_Dpt_Interface.Employee_Inidividual_Information_Report.rdlc"
        Me.Emp_InfoReportViewer.Location = New System.Drawing.Point(1, 6)
        Me.Emp_InfoReportViewer.Name = "Emp_InfoReportViewer"
        Me.Emp_InfoReportViewer.Size = New System.Drawing.Size(852, 253)
        Me.Emp_InfoReportViewer.TabIndex = 0
        '
        'Indivdual_Employee_Report_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 278)
        Me.Controls.Add(Me.Emp_InfoReportViewer)
        Me.Name = "Indivdual_Employee_Report_View"
        Me.Text = "Individual Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.QueryEmployeeInformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query_Indivual_Employee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableAdapterManager As Fire_Dpt_Interface.Query_Indivual_EmployeeTableAdapters.TableAdapterManager
    Friend WithEvents QueryEmployeeInformationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Query_Indivual_Employee As Fire_Dpt_Interface.Query_Indivual_Employee
    Friend WithEvents QueryEmployeeInformationTableAdapter As Fire_Dpt_Interface.Query_Indivual_EmployeeTableAdapters.QueryEmployeeInformationTableAdapter
    Friend WithEvents Emp_InfoReportViewer As Microsoft.Reporting.WinForms.ReportViewer
End Class
