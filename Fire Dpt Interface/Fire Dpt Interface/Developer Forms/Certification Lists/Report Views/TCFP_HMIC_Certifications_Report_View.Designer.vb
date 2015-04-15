<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TCFP_HMIC_Certifications_Report_View
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
        Me.TCFP_HMIC_ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TCFP_HMIC_Certifications_Dataset = New Fire_Dpt_Interface.TCFP_HMIC_Certifications_Dataset()
        Me.Query_TCFP_HMIC_CertificationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Query_TCFP_HMIC_CertificationsTableAdapter = New Fire_Dpt_Interface.TCFP_HMIC_Certifications_DatasetTableAdapters.Query_TCFP_HMIC_CertificationsTableAdapter()
        CType(Me.TCFP_HMIC_Certifications_Dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query_TCFP_HMIC_CertificationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TCFP_HMIC_ReportViewer
        '
        Me.TCFP_HMIC_ReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "TCFP_HMIC_Certifications_Report"
        ReportDataSource1.Value = Me.Query_TCFP_HMIC_CertificationsBindingSource
        Me.TCFP_HMIC_ReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.TCFP_HMIC_ReportViewer.LocalReport.ReportEmbeddedResource = "Fire_Dpt_Interface.TCFP_HMIC_Certification_Report.rdlc"
        Me.TCFP_HMIC_ReportViewer.Location = New System.Drawing.Point(2, 13)
        Me.TCFP_HMIC_ReportViewer.Name = "TCFP_HMIC_ReportViewer"
        Me.TCFP_HMIC_ReportViewer.Size = New System.Drawing.Size(802, 246)
        Me.TCFP_HMIC_ReportViewer.TabIndex = 0
        '
        'TCFP_HMIC_Certifications_Dataset
        '
        Me.TCFP_HMIC_Certifications_Dataset.DataSetName = "TCFP_HMIC_Certifications_Dataset"
        Me.TCFP_HMIC_Certifications_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Query_TCFP_HMIC_CertificationsBindingSource
        '
        Me.Query_TCFP_HMIC_CertificationsBindingSource.DataMember = "Query_TCFP_HMIC_Certifications"
        Me.Query_TCFP_HMIC_CertificationsBindingSource.DataSource = Me.TCFP_HMIC_Certifications_Dataset
        '
        'Query_TCFP_HMIC_CertificationsTableAdapter
        '
        Me.Query_TCFP_HMIC_CertificationsTableAdapter.ClearBeforeFill = True
        '
        'TCFP_HMIC_Certifications_Report_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 261)
        Me.Controls.Add(Me.TCFP_HMIC_ReportViewer)
        Me.Name = "TCFP_HMIC_Certifications_Report_View"
        Me.Text = "TCFP HMIC Certifications Report View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TCFP_HMIC_Certifications_Dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query_TCFP_HMIC_CertificationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TCFP_HMIC_ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Query_TCFP_HMIC_CertificationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TCFP_HMIC_Certifications_Dataset As Fire_Dpt_Interface.TCFP_HMIC_Certifications_Dataset
    Friend WithEvents Query_TCFP_HMIC_CertificationsTableAdapter As Fire_Dpt_Interface.TCFP_HMIC_Certifications_DatasetTableAdapters.Query_TCFP_HMIC_CertificationsTableAdapter
End Class
