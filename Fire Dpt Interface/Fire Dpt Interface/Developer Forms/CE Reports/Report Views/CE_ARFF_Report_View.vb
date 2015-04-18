Imports Microsoft.Reporting.WinForms


Public Class CE_ARFF_Report_View

    Private Sub ARFF_CE_Report_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim s_date = Dev_ARFF_CE_Report.startdate
        Dim e_date = Dev_ARFF_CE_Report.enddate
        Dim START_DATE As New ReportParameter("START", s_date)
        Dim END_DATE As New ReportParameter("END", s_date)

        'TODO: This line of code loads data into the 'CE_ARFF_Dataset.Query_CE_ARFF_Report' table. You can move, or remove it, as needed.
        Me.Query_CE_ARFF_ReportTableAdapter.Fill(Me.CE_ARFF_Dataset.Query_CE_ARFF_Report, 103147821, s_date, e_date)
        Me.ARFF_CE_ReportViewer.LocalReport.SetParameters(START_DATE)
        Me.ARFF_CE_ReportViewer.LocalReport.SetParameters(END_DATE)
        Me.ARFF_CE_ReportViewer.RefreshReport()
    End Sub

    Private Sub ARFF_CE_Report_View_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim CEForm As New Dev_ARFF_CE_Report()
        CEForm = New Dev_ARFF_CE_Report()
        CEForm.Show()
        CEForm = Nothing
        'Do not do me.close!!! (It will cause this function to enter an infinite loop)
    End Sub
End Class