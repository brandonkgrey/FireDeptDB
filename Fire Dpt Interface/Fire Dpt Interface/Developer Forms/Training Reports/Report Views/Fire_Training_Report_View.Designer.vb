<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fire_Training_Report_View
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
        Me.Fire_ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Fire_Training_Report_Dataset = New Fire_Dpt_Interface.Fire_Training_Report_Dataset()
        Me.Query_Fire_Training_ReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Query_Fire_Training_ReportTableAdapter = New Fire_Dpt_Interface.Fire_Training_Report_DatasetTableAdapters.Query_Fire_Training_ReportTableAdapter()
        CType(Me.Fire_Training_Report_Dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query_Fire_Training_ReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Fire_ReportViewer
        '
        Me.Fire_ReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "Fire_Training_Report"
        ReportDataSource1.Value = Me.Query_Fire_Training_ReportBindingSource
        Me.Fire_ReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Fire_ReportViewer.LocalReport.ReportEmbeddedResource = "Fire_Dpt_Interface.Fire_Training_Report.rdlc"
        Me.Fire_ReportViewer.Location = New System.Drawing.Point(1, 2)
        Me.Fire_ReportViewer.Name = "Fire_ReportViewer"
        Me.Fire_ReportViewer.Size = New System.Drawing.Size(683, 257)
        Me.Fire_ReportViewer.TabIndex = 0
        '
        'Fire_Training_Report_Dataset
        '
        Me.Fire_Training_Report_Dataset.DataSetName = "Fire_Training_Report_Dataset"
        Me.Fire_Training_Report_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Query_Fire_Training_ReportBindingSource
        '
        Me.Query_Fire_Training_ReportBindingSource.DataMember = "Query_Fire_Training_Report"
        Me.Query_Fire_Training_ReportBindingSource.DataSource = Me.Fire_Training_Report_Dataset
        '
        'Query_Fire_Training_ReportTableAdapter
        '
        Me.Query_Fire_Training_ReportTableAdapter.ClearBeforeFill = True
        '
        'Fire_Training_Report_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 261)
        Me.Controls.Add(Me.Fire_ReportViewer)
        Me.Name = "Fire_Training_Report_View"
        Me.Text = "Fire Training Report View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Fire_Training_Report_Dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query_Fire_Training_ReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fire_ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Query_Fire_Training_ReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Fire_Training_Report_Dataset As Fire_Dpt_Interface.Fire_Training_Report_Dataset
    Friend WithEvents Query_Fire_Training_ReportTableAdapter As Fire_Dpt_Interface.Fire_Training_Report_DatasetTableAdapters.Query_Fire_Training_ReportTableAdapter
End Class
