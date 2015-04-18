<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Class_Information_Report_View
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
        Me.Class_Info_ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ClassInformation_Dataset = New Fire_Dpt_Interface.ClassInformation_Dataset()
        Me.Query_ClassInfo_ReportDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Query_ClassInfo_ReportTableAdapter = New Fire_Dpt_Interface.ClassInformation_DatasetTableAdapters.Query_ClassInfo_ReportTableAdapter()
        CType(Me.ClassInformation_Dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query_ClassInfo_ReportDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Class_Info_ReportViewer
        '
        Me.Class_Info_ReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "Class_Information_Report"
        ReportDataSource1.Value = Me.Query_ClassInfo_ReportDataTableBindingSource
        Me.Class_Info_ReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Class_Info_ReportViewer.LocalReport.ReportEmbeddedResource = "Fire_Dpt_Interface.Class_Information_Report.rdlc"
        Me.Class_Info_ReportViewer.Location = New System.Drawing.Point(1, 3)
        Me.Class_Info_ReportViewer.Name = "Class_Info_ReportViewer"
        Me.Class_Info_ReportViewer.Size = New System.Drawing.Size(739, 258)
        Me.Class_Info_ReportViewer.TabIndex = 0
        '
        'ClassInformation_Dataset
        '
        Me.ClassInformation_Dataset.DataSetName = "ClassInformation_Dataset"
        Me.ClassInformation_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Query_ClassInfo_ReportDataTableBindingSource
        '
        Me.Query_ClassInfo_ReportDataTableBindingSource.DataMember = "Query_ClassInfo_ReportDataTable"
        Me.Query_ClassInfo_ReportDataTableBindingSource.DataSource = Me.ClassInformation_Dataset
        '
        'Query_ClassInfo_ReportTableAdapter
        '
        Me.Query_ClassInfo_ReportTableAdapter.ClearBeforeFill = True
        '
        'Class_Information_Report_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 261)
        Me.Controls.Add(Me.Class_Info_ReportViewer)
        Me.Name = "Class_Information_Report_View"
        Me.Text = "Class Information Report View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ClassInformation_Dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query_ClassInfo_ReportDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Class_Info_ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Query_ClassInfo_ReportDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClassInformation_Dataset As Fire_Dpt_Interface.ClassInformation_Dataset
    Friend WithEvents Query_ClassInfo_ReportTableAdapter As Fire_Dpt_Interface.ClassInformation_DatasetTableAdapters.Query_ClassInfo_ReportTableAdapter
End Class
