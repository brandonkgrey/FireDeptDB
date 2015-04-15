<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMTI_Report_View
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
        Me.EMTI_ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EMTI_Certifications_Dataset = New Fire_Dpt_Interface.EMTI_Certifications_Dataset()
        Me.Query_EMTI_CertBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Query_EMTI_CertTableAdapter = New Fire_Dpt_Interface.EMTI_Certifications_DatasetTableAdapters.Query_EMTI_CertTableAdapter()
        CType(Me.EMTI_Certifications_Dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query_EMTI_CertBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EMTI_ReportViewer
        '
        Me.EMTI_ReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "EMTI_Certifications_Report"
        ReportDataSource1.Value = Me.Query_EMTI_CertBindingSource
        Me.EMTI_ReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.EMTI_ReportViewer.LocalReport.ReportEmbeddedResource = "Fire_Dpt_Interface.EMTI_Certifications_Report.rdlc"
        Me.EMTI_ReportViewer.Location = New System.Drawing.Point(13, 13)
        Me.EMTI_ReportViewer.Name = "EMTI_ReportViewer"
        Me.EMTI_ReportViewer.Size = New System.Drawing.Size(758, 246)
        Me.EMTI_ReportViewer.TabIndex = 0
        '
        'EMTI_Certifications_Dataset
        '
        Me.EMTI_Certifications_Dataset.DataSetName = "EMTI_Certifications_Dataset"
        Me.EMTI_Certifications_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Query_EMTI_CertBindingSource
        '
        Me.Query_EMTI_CertBindingSource.DataMember = "Query_EMTI_Cert"
        Me.Query_EMTI_CertBindingSource.DataSource = Me.EMTI_Certifications_Dataset
        '
        'Query_EMTI_CertTableAdapter
        '
        Me.Query_EMTI_CertTableAdapter.ClearBeforeFill = True
        '
        'EMTI_Report_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 274)
        Me.Controls.Add(Me.EMTI_ReportViewer)
        Me.Name = "EMTI_Report_View"
        Me.Text = "EMT-I Report View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.EMTI_Certifications_Dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query_EMTI_CertBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EMTI_ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Query_EMTI_CertBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMTI_Certifications_Dataset As Fire_Dpt_Interface.EMTI_Certifications_Dataset
    Friend WithEvents Query_EMTI_CertTableAdapter As Fire_Dpt_Interface.EMTI_Certifications_DatasetTableAdapters.Query_EMTI_CertTableAdapter
End Class
