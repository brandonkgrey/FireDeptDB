<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TCFP_Wildlife_Certifications_View
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
        Me.TCFP_Wildlife_ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TCFP_Wildlife_Certifications_Dataset = New Fire_Dpt_Interface.TCFP_Wildlife_Certifications_Dataset()
        Me.Query_TCFP_Wildlife_CertificationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Query_TCFP_Wildlife_CertificationsTableAdapter = New Fire_Dpt_Interface.TCFP_Wildlife_Certifications_DatasetTableAdapters.Query_TCFP_Wildlife_CertificationsTableAdapter()
        CType(Me.TCFP_Wildlife_Certifications_Dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query_TCFP_Wildlife_CertificationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TCFP_Wildlife_ReportViewer
        '
        Me.TCFP_Wildlife_ReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "TCFP_Wildlife_Certifications_Report"
        ReportDataSource1.Value = Me.Query_TCFP_Wildlife_CertificationsBindingSource
        Me.TCFP_Wildlife_ReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.TCFP_Wildlife_ReportViewer.LocalReport.ReportEmbeddedResource = "Fire_Dpt_Interface.TCFP_Wildlife_Certifications_Report.rdlc"
        Me.TCFP_Wildlife_ReportViewer.Location = New System.Drawing.Point(3, 13)
        Me.TCFP_Wildlife_ReportViewer.Name = "TCFP_Wildlife_ReportViewer"
        Me.TCFP_Wildlife_ReportViewer.Size = New System.Drawing.Size(776, 246)
        Me.TCFP_Wildlife_ReportViewer.TabIndex = 0
        '
        'TCFP_Wildlife_Certifications_Dataset
        '
        Me.TCFP_Wildlife_Certifications_Dataset.DataSetName = "TCFP_Wildlife_Certifications_Dataset"
        Me.TCFP_Wildlife_Certifications_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Query_TCFP_Wildlife_CertificationsBindingSource
        '
        Me.Query_TCFP_Wildlife_CertificationsBindingSource.DataMember = "Query_TCFP_Wildlife_Certifications"
        Me.Query_TCFP_Wildlife_CertificationsBindingSource.DataSource = Me.TCFP_Wildlife_Certifications_Dataset
        '
        'Query_TCFP_Wildlife_CertificationsTableAdapter
        '
        Me.Query_TCFP_Wildlife_CertificationsTableAdapter.ClearBeforeFill = True
        '
        'TCFP_Wildlife_Certifications_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 261)
        Me.Controls.Add(Me.TCFP_Wildlife_ReportViewer)
        Me.Name = "TCFP_Wildlife_Certifications_View"
        Me.Text = "TCFP Wildlife Certifications View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TCFP_Wildlife_Certifications_Dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query_TCFP_Wildlife_CertificationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TCFP_Wildlife_ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Query_TCFP_Wildlife_CertificationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TCFP_Wildlife_Certifications_Dataset As Fire_Dpt_Interface.TCFP_Wildlife_Certifications_Dataset
    Friend WithEvents Query_TCFP_Wildlife_CertificationsTableAdapter As Fire_Dpt_Interface.TCFP_Wildlife_Certifications_DatasetTableAdapters.Query_TCFP_Wildlife_CertificationsTableAdapter
End Class
