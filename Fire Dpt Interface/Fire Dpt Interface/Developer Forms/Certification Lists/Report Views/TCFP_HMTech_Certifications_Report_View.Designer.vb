<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TCFP_HMTech_Certifications_Report_View
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
        Me.TCFP_HMTech_ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TCFP_HMTech_Certifications = New Fire_Dpt_Interface.TCFP_HMTech_Certifications()
        Me.Query_HMTech_CertificationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Query_HMTech_CertificationsTableAdapter = New Fire_Dpt_Interface.TCFP_HMTech_CertificationsTableAdapters.Query_HMTech_CertificationsTableAdapter()
        CType(Me.TCFP_HMTech_Certifications, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query_HMTech_CertificationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TCFP_HMTech_ReportViewer
        '
        Me.TCFP_HMTech_ReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "TCFP_HazMat_Techinican_Certification_Report"
        ReportDataSource1.Value = Me.Query_HMTech_CertificationsBindingSource
        Me.TCFP_HMTech_ReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.TCFP_HMTech_ReportViewer.LocalReport.ReportEmbeddedResource = "Fire_Dpt_Interface.TCFP_HMTech_Certification_Report.rdlc"
        Me.TCFP_HMTech_ReportViewer.Location = New System.Drawing.Point(2, 6)
        Me.TCFP_HMTech_ReportViewer.Name = "TCFP_HMTech_ReportViewer"
        Me.TCFP_HMTech_ReportViewer.Size = New System.Drawing.Size(783, 252)
        Me.TCFP_HMTech_ReportViewer.TabIndex = 0
        '
        'TCFP_HMTech_Certifications
        '
        Me.TCFP_HMTech_Certifications.DataSetName = "TCFP_HMTech_Certifications"
        Me.TCFP_HMTech_Certifications.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Query_HMTech_CertificationsBindingSource
        '
        Me.Query_HMTech_CertificationsBindingSource.DataMember = "Query_HMTech_Certifications"
        Me.Query_HMTech_CertificationsBindingSource.DataSource = Me.TCFP_HMTech_Certifications
        '
        'Query_HMTech_CertificationsTableAdapter
        '
        Me.Query_HMTech_CertificationsTableAdapter.ClearBeforeFill = True
        '
        'TCFP_HMTech_Certifications_Report_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 261)
        Me.Controls.Add(Me.TCFP_HMTech_ReportViewer)
        Me.Name = "TCFP_HMTech_Certifications_Report_View"
        Me.Text = "TCFP HazMat Technician Certifications Report View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TCFP_HMTech_Certifications, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query_HMTech_CertificationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TCFP_HMTech_ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Query_HMTech_CertificationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TCFP_HMTech_Certifications As Fire_Dpt_Interface.TCFP_HMTech_Certifications
    Friend WithEvents Query_HMTech_CertificationsTableAdapter As Fire_Dpt_Interface.TCFP_HMTech_CertificationsTableAdapters.Query_HMTech_CertificationsTableAdapter
End Class
