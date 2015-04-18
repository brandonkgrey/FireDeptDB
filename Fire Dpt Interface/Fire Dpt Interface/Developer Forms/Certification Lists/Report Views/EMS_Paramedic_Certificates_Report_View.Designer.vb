<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMS_Paramedic_Certificates_Report_View
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
        Me.Paramedic_ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EMS_Paramedic_Certifications_Dataset = New Fire_Dpt_Interface.EMS_Paramedic_Certifications_Dataset()
        Me.Query_EMS_Paramedic_CertificationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Query_EMS_Paramedic_CertificationsTableAdapter = New Fire_Dpt_Interface.EMS_Paramedic_Certifications_DatasetTableAdapters.Query_EMS_Paramedic_CertificationsTableAdapter()
        CType(Me.EMS_Paramedic_Certifications_Dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query_EMS_Paramedic_CertificationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Paramedic_ReportViewer
        '
        Me.Paramedic_ReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "EMS_Paramedic_Certifications_Report"
        ReportDataSource1.Value = Me.Query_EMS_Paramedic_CertificationsBindingSource
        Me.Paramedic_ReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Paramedic_ReportViewer.LocalReport.ReportEmbeddedResource = "Fire_Dpt_Interface.EMS_Paramedic_Certifications_Report.rdlc"
        Me.Paramedic_ReportViewer.Location = New System.Drawing.Point(12, 12)
        Me.Paramedic_ReportViewer.Name = "Paramedic_ReportViewer"
        Me.Paramedic_ReportViewer.Size = New System.Drawing.Size(778, 246)
        Me.Paramedic_ReportViewer.TabIndex = 0
        '
        'EMS_Paramedic_Certifications_Dataset
        '
        Me.EMS_Paramedic_Certifications_Dataset.DataSetName = "EMS_Paramedic_Certifications_Dataset"
        Me.EMS_Paramedic_Certifications_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Query_EMS_Paramedic_CertificationsBindingSource
        '
        Me.Query_EMS_Paramedic_CertificationsBindingSource.DataMember = "Query_EMS_Paramedic_Certifications"
        Me.Query_EMS_Paramedic_CertificationsBindingSource.DataSource = Me.EMS_Paramedic_Certifications_Dataset
        '
        'Query_EMS_Paramedic_CertificationsTableAdapter
        '
        Me.Query_EMS_Paramedic_CertificationsTableAdapter.ClearBeforeFill = True
        '
        'EMS_Paramedic_Certificates_Report_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 261)
        Me.Controls.Add(Me.Paramedic_ReportViewer)
        Me.Name = "EMS_Paramedic_Certificates_Report_View"
        Me.Text = "EMS Certificate List- Paramedic Report View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.EMS_Paramedic_Certifications_Dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query_EMS_Paramedic_CertificationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Paramedic_ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Query_EMS_Paramedic_CertificationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMS_Paramedic_Certifications_Dataset As Fire_Dpt_Interface.EMS_Paramedic_Certifications_Dataset
    Friend WithEvents Query_EMS_Paramedic_CertificationsTableAdapter As Fire_Dpt_Interface.EMS_Paramedic_Certifications_DatasetTableAdapters.Query_EMS_Paramedic_CertificationsTableAdapter
End Class
