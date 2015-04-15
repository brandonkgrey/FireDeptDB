Imports Microsoft.Office.Interop.Access
Imports Microsoft.Reporting.WinForms


Public Class CE_ARFF_Report_View

    Private Sub ARFF_CE_Report_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CE_ARFF_Dataset.Query_CE_ARFF_Report' table. You can move, or remove it, as needed.
        Me.Query_CE_ARFF_ReportTableAdapter.Fill(Me.CE_ARFF_Dataset.Query_CE_ARFF_Report, 103147821, "1/1/2014", "1/1/2015")
        Me.ARFF_CE_ReportViewer.RefreshReport()
    End Sub
End Class