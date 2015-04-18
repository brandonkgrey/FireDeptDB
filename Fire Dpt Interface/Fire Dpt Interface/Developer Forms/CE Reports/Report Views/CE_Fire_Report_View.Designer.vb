<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CE_Fire_Report_View
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
        Me.CE_Fire_ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CE_Fire_Dataset = New Fire_Dpt_Interface.CE_Fire_Dataset()
        Me.Query_CE_Fire_ReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Query_CE_Fire_ReportTableAdapter = New Fire_Dpt_Interface.CE_Fire_DatasetTableAdapters.Query_CE_Fire_ReportTableAdapter()
        CType(Me.CE_Fire_Dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query_CE_Fire_ReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CE_Fire_ReportViewer
        '
        Me.CE_Fire_ReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "CE_Fire_Report"
        ReportDataSource1.Value = Me.Query_CE_Fire_ReportBindingSource
        Me.CE_Fire_ReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.CE_Fire_ReportViewer.LocalReport.ReportEmbeddedResource = "Fire_Dpt_Interface.Fire_CE_Individual_Report.rdlc"
        Me.CE_Fire_ReportViewer.Location = New System.Drawing.Point(0, 3)
        Me.CE_Fire_ReportViewer.Name = "CE_Fire_ReportViewer"
        Me.CE_Fire_ReportViewer.Size = New System.Drawing.Size(733, 246)
        Me.CE_Fire_ReportViewer.TabIndex = 0
        '
        'CE_Fire_Dataset
        '
        Me.CE_Fire_Dataset.DataSetName = "CE_Fire_Dataset"
        Me.CE_Fire_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Query_CE_Fire_ReportBindingSource
        '
        Me.Query_CE_Fire_ReportBindingSource.DataMember = "Query_CE_Fire_Report"
        Me.Query_CE_Fire_ReportBindingSource.DataSource = Me.CE_Fire_Dataset
        '
        'Query_CE_Fire_ReportTableAdapter
        '
        Me.Query_CE_Fire_ReportTableAdapter.ClearBeforeFill = True
        '
        'CE_Fire_Report_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 261)
        Me.Controls.Add(Me.CE_Fire_ReportViewer)
        Me.Name = "CE_Fire_Report_View"
        Me.Text = "CE Fire Report View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CE_Fire_Dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query_CE_Fire_ReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CE_Fire_ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Query_CE_Fire_ReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CE_Fire_Dataset As Fire_Dpt_Interface.CE_Fire_Dataset
    Friend WithEvents Query_CE_Fire_ReportTableAdapter As Fire_Dpt_Interface.CE_Fire_DatasetTableAdapters.Query_CE_Fire_ReportTableAdapter
End Class
