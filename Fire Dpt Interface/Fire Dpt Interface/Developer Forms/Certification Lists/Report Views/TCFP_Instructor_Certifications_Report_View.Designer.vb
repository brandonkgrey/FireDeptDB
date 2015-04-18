<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TCFP_Instructor_Certifications_Report_View
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
        Me.TCFP_Instructor_ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TCFP_Instructor_Certifications_Dataset = New Fire_Dpt_Interface.TCFP_Instructor_Certifications_Dataset()
        Me.Query_Instructor_CertificationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Query_Instructor_CertificationsTableAdapter = New Fire_Dpt_Interface.TCFP_Instructor_Certifications_DatasetTableAdapters.Query_Instructor_CertificationsTableAdapter()
        CType(Me.TCFP_Instructor_Certifications_Dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query_Instructor_CertificationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TCFP_Instructor_ReportViewer
        '
        Me.TCFP_Instructor_ReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "TCFP_Instructor_Certifications_Report"
        ReportDataSource1.Value = Me.Query_Instructor_CertificationsBindingSource
        Me.TCFP_Instructor_ReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.TCFP_Instructor_ReportViewer.LocalReport.ReportEmbeddedResource = "Fire_Dpt_Interface.TCFP_Instructor_Certifications_Report.rdlc"
        Me.TCFP_Instructor_ReportViewer.Location = New System.Drawing.Point(12, 12)
        Me.TCFP_Instructor_ReportViewer.Name = "TCFP_Instructor_ReportViewer"
        Me.TCFP_Instructor_ReportViewer.Size = New System.Drawing.Size(791, 246)
        Me.TCFP_Instructor_ReportViewer.TabIndex = 0
        '
        'TCFP_Instructor_Certifications_Dataset
        '
        Me.TCFP_Instructor_Certifications_Dataset.DataSetName = "TCFP_Instructor_Certifications_Dataset"
        Me.TCFP_Instructor_Certifications_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Query_Instructor_CertificationsBindingSource
        '
        Me.Query_Instructor_CertificationsBindingSource.DataMember = "Query_Instructor_Certifications"
        Me.Query_Instructor_CertificationsBindingSource.DataSource = Me.TCFP_Instructor_Certifications_Dataset
        '
        'Query_Instructor_CertificationsTableAdapter
        '
        Me.Query_Instructor_CertificationsTableAdapter.ClearBeforeFill = True
        '
        'TCFP_Instructor_Certifications_Report_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 261)
        Me.Controls.Add(Me.TCFP_Instructor_ReportViewer)
        Me.Name = "TCFP_Instructor_Certifications_Report_View"
        Me.Text = "TCFP Instructor Certifications Report View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TCFP_Instructor_Certifications_Dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query_Instructor_CertificationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TCFP_Instructor_ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Query_Instructor_CertificationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TCFP_Instructor_Certifications_Dataset As Fire_Dpt_Interface.TCFP_Instructor_Certifications_Dataset
    Friend WithEvents Query_Instructor_CertificationsTableAdapter As Fire_Dpt_Interface.TCFP_Instructor_Certifications_DatasetTableAdapters.Query_Instructor_CertificationsTableAdapter
End Class
