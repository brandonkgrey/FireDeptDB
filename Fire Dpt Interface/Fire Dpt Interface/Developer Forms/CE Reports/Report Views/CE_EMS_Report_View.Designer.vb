<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CE_EMS_Report_View
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
        Me.EMS_CE_ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CE_EMS_Dataset = New Fire_Dpt_Interface.CE_EMS_Dataset()
        Me.Query_EMS_CE_ReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Query_EMS_CE_ReportTableAdapter = New Fire_Dpt_Interface.CE_EMS_DatasetTableAdapters.Query_EMS_CE_ReportTableAdapter()
        CType(Me.CE_EMS_Dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query_EMS_CE_ReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EMS_CE_ReportViewer
        '
        Me.EMS_CE_ReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "CE_EMS_Report"
        ReportDataSource1.Value = Me.Query_EMS_CE_ReportBindingSource
        Me.EMS_CE_ReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.EMS_CE_ReportViewer.LocalReport.ReportEmbeddedResource = "Fire_Dpt_Interface.EMS_CE_Individual_Report.rdlc"
        Me.EMS_CE_ReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.EMS_CE_ReportViewer.Name = "EMS_CE_ReportViewer"
        Me.EMS_CE_ReportViewer.Size = New System.Drawing.Size(626, 261)
        Me.EMS_CE_ReportViewer.TabIndex = 0
        '
        'CE_EMS_Dataset
        '
        Me.CE_EMS_Dataset.DataSetName = "CE_EMS_Dataset"
        Me.CE_EMS_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Query_EMS_CE_ReportBindingSource
        '
        Me.Query_EMS_CE_ReportBindingSource.DataMember = "Query_EMS_CE_Report"
        Me.Query_EMS_CE_ReportBindingSource.DataSource = Me.CE_EMS_Dataset
        '
        'Query_EMS_CE_ReportTableAdapter
        '
        Me.Query_EMS_CE_ReportTableAdapter.ClearBeforeFill = True
        '
        'CE_EMS_Report_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 261)
        Me.Controls.Add(Me.EMS_CE_ReportViewer)
        Me.Name = "CE_EMS_Report_View"
        Me.Text = "EMS CE Report View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CE_EMS_Dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query_EMS_CE_ReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EMS_CE_ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Query_EMS_CE_ReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CE_EMS_Dataset As Fire_Dpt_Interface.CE_EMS_Dataset
    Friend WithEvents Query_EMS_CE_ReportTableAdapter As Fire_Dpt_Interface.CE_EMS_DatasetTableAdapters.Query_EMS_CE_ReportTableAdapter
End Class
