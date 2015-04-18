<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMTB_Report_View
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
        Me.EMTB_ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EMTB_Certifications_Dataset = New Fire_Dpt_Interface.EMTB_Certifications_Dataset()
        Me.Query_EMTB_CertificationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Query_EMTB_CertificationsTableAdapter = New Fire_Dpt_Interface.EMTB_Certifications_DatasetTableAdapters.Query_EMTB_CertificationsTableAdapter()
        CType(Me.EMTB_Certifications_Dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query_EMTB_CertificationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EMTB_ReportViewer
        '
        Me.EMTB_ReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "Query_EMTB_Certification_Report"
        ReportDataSource1.Value = Me.Query_EMTB_CertificationsBindingSource
        Me.EMTB_ReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.EMTB_ReportViewer.LocalReport.ReportEmbeddedResource = "Fire_Dpt_Interface.EMTB_Certificates_Report.rdlc"
        Me.EMTB_ReportViewer.Location = New System.Drawing.Point(13, 13)
        Me.EMTB_ReportViewer.Name = "EMTB_ReportViewer"
        Me.EMTB_ReportViewer.Size = New System.Drawing.Size(810, 277)
        Me.EMTB_ReportViewer.TabIndex = 0
        '
        'EMTB_Certifications_Dataset
        '
        Me.EMTB_Certifications_Dataset.DataSetName = "EMTB_Certifications_Dataset"
        Me.EMTB_Certifications_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Query_EMTB_CertificationsBindingSource
        '
        Me.Query_EMTB_CertificationsBindingSource.DataMember = "Query_EMTB_Certifications"
        Me.Query_EMTB_CertificationsBindingSource.DataSource = Me.EMTB_Certifications_Dataset
        '
        'Query_EMTB_CertificationsTableAdapter
        '
        Me.Query_EMTB_CertificationsTableAdapter.ClearBeforeFill = True
        '
        'EMTB_Report_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 302)
        Me.Controls.Add(Me.EMTB_ReportViewer)
        Me.Name = "EMTB_Report_View"
        Me.Text = " EMTB Certification Report View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.EMTB_Certifications_Dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query_EMTB_CertificationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EMTB_ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Query_EMTB_CertificationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMTB_Certifications_Dataset As Fire_Dpt_Interface.EMTB_Certifications_Dataset
    Friend WithEvents Query_EMTB_CertificationsTableAdapter As Fire_Dpt_Interface.EMTB_Certifications_DatasetTableAdapters.Query_EMTB_CertificationsTableAdapter
End Class
