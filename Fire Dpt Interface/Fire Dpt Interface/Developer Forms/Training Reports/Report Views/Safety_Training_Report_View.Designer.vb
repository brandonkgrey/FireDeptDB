<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Safety_Training_Report_View
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
        Me.TR_Safety_ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Training_Reports_Safety_Dataset = New Fire_Dpt_Interface.Training_Reports_Safety_Dataset()
        Me.Query_Training_Report_SafetyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Query_Training_Report_SafetyTableAdapter = New Fire_Dpt_Interface.Training_Reports_Safety_DatasetTableAdapters.Query_Training_Report_SafetyTableAdapter()
        CType(Me.Training_Reports_Safety_Dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query_Training_Report_SafetyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TR_Safety_ReportViewer
        '
        Me.TR_Safety_ReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource2.Name = "Safety_Training_Report"
        ReportDataSource2.Value = Me.Query_Training_Report_SafetyBindingSource
        Me.TR_Safety_ReportViewer.LocalReport.DataSources.Add(ReportDataSource2)
        Me.TR_Safety_ReportViewer.LocalReport.ReportEmbeddedResource = "Fire_Dpt_Interface.Safety_Training_Report.rdlc"
        Me.TR_Safety_ReportViewer.Location = New System.Drawing.Point(2, 4)
        Me.TR_Safety_ReportViewer.Name = "TR_Safety_ReportViewer"
        Me.TR_Safety_ReportViewer.Size = New System.Drawing.Size(801, 255)
        Me.TR_Safety_ReportViewer.TabIndex = 0
        '
        'Training_Reports_Safety_Dataset
        '
        Me.Training_Reports_Safety_Dataset.DataSetName = "Training_Reports_Safety_Dataset"
        Me.Training_Reports_Safety_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Query_Training_Report_SafetyBindingSource
        '
        Me.Query_Training_Report_SafetyBindingSource.DataMember = "Query_Training_Report_Safety"
        Me.Query_Training_Report_SafetyBindingSource.DataSource = Me.Training_Reports_Safety_Dataset
        '
        'Query_Training_Report_SafetyTableAdapter
        '
        Me.Query_Training_Report_SafetyTableAdapter.ClearBeforeFill = True
        '
        'Safety_Training_Report_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 261)
        Me.Controls.Add(Me.TR_Safety_ReportViewer)
        Me.Name = "Safety_Training_Report_View"
        Me.Text = "Safety Training Report View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Training_Reports_Safety_Dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query_Training_Report_SafetyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TR_Safety_ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Query_Training_Report_SafetyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Training_Reports_Safety_Dataset As Fire_Dpt_Interface.Training_Reports_Safety_Dataset
    Friend WithEvents Query_Training_Report_SafetyTableAdapter As Fire_Dpt_Interface.Training_Reports_Safety_DatasetTableAdapters.Query_Training_Report_SafetyTableAdapter
End Class
