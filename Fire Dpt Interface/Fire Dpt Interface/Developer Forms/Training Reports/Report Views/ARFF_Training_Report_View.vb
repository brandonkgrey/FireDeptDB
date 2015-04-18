Imports Microsoft.Reporting.WinForms


Public Class ARFF_Training_Report_View

    Private Sub ARFF_Training_Report_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ARFF_Training_Report_Dataset.Query_ARFF_Training_Report' table. You can move, or remove it, as needed.

        Dim startdate = Dev_ARFF_Training_Reports.startdate
        Dim enddate = Dev_ARFF_Training_Reports.enddate
        Dim START_DATE As New ReportParameter("START", startdate)
        Dim END_DATE As New ReportParameter("END", enddate)

        Me.Query_ARFF_Training_ReportTableAdapter.Fill(Me.ARFF_Training_Report_Dataset.Query_ARFF_Training_Report, startdate, enddate)
        Me.ARFF_ReportViewer.LocalReport.SetParameters(START_DATE)
        Me.ARFF_ReportViewer.LocalReport.SetParameters(END_DATE)
        Me.ARFF_ReportViewer.RefreshReport()
    End Sub

    Private Sub ARFF_Training_Report_View_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

        Dim ARFF_Form As Dev_ARFF_Training_Reports
        ARFF_Form = New Dev_ARFF_Training_Reports()
        ARFF_Form.Show()
        ARFF_Form = Nothing
        'Do not do me.close!!! (It will cause this function to enter an infinite loop)
    End Sub
End Class