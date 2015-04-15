<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HazMat_Training_Report_View
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
        Me.HM_Training_ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.HazMat_Training_Report_Dataset = New Fire_Dpt_Interface.HazMat_Training_Report_Dataset()
        Me.Query_HazMat_Training_ReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Query_HazMat_Training_ReportTableAdapter = New Fire_Dpt_Interface.HazMat_Training_Report_DatasetTableAdapters.Query_HazMat_Training_ReportTableAdapter()
        CType(Me.HazMat_Training_Report_Dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query_HazMat_Training_ReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HM_Training_ReportViewer
        '
        Me.HM_Training_ReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "HM_Training_Report"
        ReportDataSource1.Value = Me.Query_HazMat_Training_ReportBindingSource
        Me.HM_Training_ReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.HM_Training_ReportViewer.LocalReport.ReportEmbeddedResource = "Fire_Dpt_Interface.HM_Training_Report.rdlc"
        Me.HM_Training_ReportViewer.Location = New System.Drawing.Point(4, 13)
        Me.HM_Training_ReportViewer.Name = "HM_Training_ReportViewer"
        Me.HM_Training_ReportViewer.Size = New System.Drawing.Size(585, 246)
        Me.HM_Training_ReportViewer.TabIndex = 0
        '
        'HazMat_Training_Report_Dataset
        '
        Me.HazMat_Training_Report_Dataset.DataSetName = "HazMat_Training_Report_Dataset"
        Me.HazMat_Training_Report_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Query_HazMat_Training_ReportBindingSource
        '
        Me.Query_HazMat_Training_ReportBindingSource.DataMember = "Query_HazMat_Training_Report"
        Me.Query_HazMat_Training_ReportBindingSource.DataSource = Me.HazMat_Training_Report_Dataset
        '
        'Query_HazMat_Training_ReportTableAdapter
        '
        Me.Query_HazMat_Training_ReportTableAdapter.ClearBeforeFill = True
        '
        'HazMat_Training_Report_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 261)
        Me.Controls.Add(Me.HM_Training_ReportViewer)
        Me.Name = "HazMat_Training_Report_View"
        Me.Text = "HazMat_Training_Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.HazMat_Training_Report_Dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query_HazMat_Training_ReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HM_Training_ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Query_HazMat_Training_ReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HazMat_Training_Report_Dataset As Fire_Dpt_Interface.HazMat_Training_Report_Dataset
    Friend WithEvents Query_HazMat_Training_ReportTableAdapter As Fire_Dpt_Interface.HazMat_Training_Report_DatasetTableAdapters.Query_HazMat_Training_ReportTableAdapter
End Class
