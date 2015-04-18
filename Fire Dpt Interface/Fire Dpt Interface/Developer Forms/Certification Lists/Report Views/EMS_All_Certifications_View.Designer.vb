<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMS_All_Certifications_View
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
        Me.All_Cert_ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.All_EMS_Cert_Datasetxsd = New Fire_Dpt_Interface.All_EMS_Cert_Datasetxsd()
        Me.Query_All_EMS_CertBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Query_All_EMS_CertTableAdapter = New Fire_Dpt_Interface.All_EMS_Cert_DatasetxsdTableAdapters.Query_All_EMS_CertTableAdapter()
        CType(Me.All_EMS_Cert_Datasetxsd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query_All_EMS_CertBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'All_Cert_ReportViewer
        '
        Me.All_Cert_ReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "All_EMS_Certifications_Report"
        ReportDataSource1.Value = Me.Query_All_EMS_CertBindingSource
        Me.All_Cert_ReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.All_Cert_ReportViewer.LocalReport.ReportEmbeddedResource = "Fire_Dpt_Interface.All_EMS_Certifications_Report.rdlc"
        Me.All_Cert_ReportViewer.Location = New System.Drawing.Point(12, 22)
        Me.All_Cert_ReportViewer.Name = "All_Cert_ReportViewer"
        Me.All_Cert_ReportViewer.Size = New System.Drawing.Size(734, 258)
        Me.All_Cert_ReportViewer.TabIndex = 0
        '
        'All_EMS_Cert_Datasetxsd
        '
        Me.All_EMS_Cert_Datasetxsd.DataSetName = "All_EMS_Cert_Datasetxsd"
        Me.All_EMS_Cert_Datasetxsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Query_All_EMS_CertBindingSource
        '
        Me.Query_All_EMS_CertBindingSource.DataMember = "Query_All_EMS_Cert"
        Me.Query_All_EMS_CertBindingSource.DataSource = Me.All_EMS_Cert_Datasetxsd
        '
        'Query_All_EMS_CertTableAdapter
        '
        Me.Query_All_EMS_CertTableAdapter.ClearBeforeFill = True
        '
        'EMS_All_Certifications_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 292)
        Me.Controls.Add(Me.All_Cert_ReportViewer)
        Me.Name = "EMS_All_Certifications_View"
        Me.Text = "EMS All Certifications Report View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.All_EMS_Cert_Datasetxsd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query_All_EMS_CertBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents All_Cert_ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Query_All_EMS_CertBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents All_EMS_Cert_Datasetxsd As Fire_Dpt_Interface.All_EMS_Cert_Datasetxsd
    Friend WithEvents Query_All_EMS_CertTableAdapter As Fire_Dpt_Interface.All_EMS_Cert_DatasetxsdTableAdapters.Query_All_EMS_CertTableAdapter
End Class
