<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMS_Training_Report_View
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
        Me.Query_EMS_Training_ReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMS_Training_Report_Dataset = New Fire_Dpt_Interface.EMS_Training_Report_Dataset()
        Me.EMS_Training_ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Query_EMS_Training_ReportTableAdapter = New Fire_Dpt_Interface.EMS_Training_Report_DatasetTableAdapters.Query_EMS_Training_ReportTableAdapter()
        CType(Me.Query_EMS_Training_ReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMS_Training_Report_Dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Query_EMS_Training_ReportBindingSource
        '
        Me.Query_EMS_Training_ReportBindingSource.DataMember = "Query_EMS_Training_Report"
        Me.Query_EMS_Training_ReportBindingSource.DataSource = Me.EMS_Training_Report_Dataset
        '
        'EMS_Training_Report_Dataset
        '
        Me.EMS_Training_Report_Dataset.DataSetName = "EMS_Training_Report_Dataset"
        Me.EMS_Training_Report_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMS_Training_ReportViewer
        '
        Me.EMS_Training_ReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "EMS_Training_Report"
        ReportDataSource1.Value = Me.Query_EMS_Training_ReportBindingSource
        Me.EMS_Training_ReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.EMS_Training_ReportViewer.LocalReport.ReportEmbeddedResource = "Fire_Dpt_Interface.EMS_Training_Report.rdlc"
        Me.EMS_Training_ReportViewer.Location = New System.Drawing.Point(1, 13)
        Me.EMS_Training_ReportViewer.Name = "EMS_Training_ReportViewer"
        Me.EMS_Training_ReportViewer.Size = New System.Drawing.Size(859, 246)
        Me.EMS_Training_ReportViewer.TabIndex = 0
        '
        'Query_EMS_Training_ReportTableAdapter
        '
        Me.Query_EMS_Training_ReportTableAdapter.ClearBeforeFill = True
        '
        'EMS_Training_Report_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 261)
        Me.Controls.Add(Me.EMS_Training_ReportViewer)
        Me.Name = "EMS_Training_Report_View"
        Me.Text = "EMS Training Report View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Query_EMS_Training_ReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMS_Training_Report_Dataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EMS_Training_ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Query_EMS_Training_ReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMS_Training_Report_Dataset As Fire_Dpt_Interface.EMS_Training_Report_Dataset
    Friend WithEvents Query_EMS_Training_ReportTableAdapter As Fire_Dpt_Interface.EMS_Training_Report_DatasetTableAdapters.Query_EMS_Training_ReportTableAdapter
End Class
