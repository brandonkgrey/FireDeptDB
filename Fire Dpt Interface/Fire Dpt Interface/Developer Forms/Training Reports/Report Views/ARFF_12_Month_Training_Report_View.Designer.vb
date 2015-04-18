<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ARFF_12_Month_Training_Report_View
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ARFF_12M_Report = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ARFFTwelveMonthDataset = New Fire_Dpt_Interface.ARFFTwelveMonthDataset()
        Me.ARFF12MonthBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ARFF12MonthTableAdapter = New Fire_Dpt_Interface.ARFFTwelveMonthDatasetTableAdapters.ARFF12MonthTableAdapter()
        CType(Me.ARFFTwelveMonthDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARFF12MonthBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(613, 293)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(81, 25)
        Me.ExitButton.TabIndex = 97
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ARFF_12M_Report
        '
        Me.ARFF_12M_Report.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "ARFF_12_Month_Training_Report"
        ReportDataSource1.Value = Me.ARFF12MonthBindingSource
        Me.ARFF_12M_Report.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ARFF_12M_Report.LocalReport.ReportEmbeddedResource = "Fire_Dpt_Interface.ARFF_12_Month_Training_Report.rdlc"
        Me.ARFF_12M_Report.Location = New System.Drawing.Point(12, 27)
        Me.ARFF_12M_Report.Name = "ARFF_12M_Report"
        Me.ARFF_12M_Report.Size = New System.Drawing.Size(682, 260)
        Me.ARFF_12M_Report.TabIndex = 98
        '
        'ARFFTwelveMonthDataset
        '
        Me.ARFFTwelveMonthDataset.DataSetName = "ARFFTwelveMonthDataset"
        Me.ARFFTwelveMonthDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ARFF12MonthBindingSource
        '
        Me.ARFF12MonthBindingSource.DataMember = "ARFF12Month"
        Me.ARFF12MonthBindingSource.DataSource = Me.ARFFTwelveMonthDataset
        '
        'ARFF12MonthTableAdapter
        '
        Me.ARFF12MonthTableAdapter.ClearBeforeFill = True
        '
        'ARFF_12_Month_Training_Report_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 321)
        Me.Controls.Add(Me.ARFF_12M_Report)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "ARFF_12_Month_Training_Report_View"
        Me.Text = "ARFF 12 Month Training Report View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ARFFTwelveMonthDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARFF12MonthBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents ARFF_12M_Report As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ARFF12MonthBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ARFFTwelveMonthDataset As Fire_Dpt_Interface.ARFFTwelveMonthDataset
    Friend WithEvents ARFF12MonthTableAdapter As Fire_Dpt_Interface.ARFFTwelveMonthDatasetTableAdapters.ARFF12MonthTableAdapter
End Class
