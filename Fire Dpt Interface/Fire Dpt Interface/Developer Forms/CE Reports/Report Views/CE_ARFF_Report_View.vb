Imports Microsoft.Reporting.WinForms


Public Class CE_ARFF_Report_View

    Private Sub ARFF_CE_Report_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim s_date = Dev_ARFF_CE_Report.startdate
        Dim e_date = Dev_ARFF_CE_Report.enddate
        Dim e_id = Dev_ARFF_CE_Report.emp_id
        Dim e_name = Dev_ARFF_CE_Report.employeeName
        Dim START_DATE As New ReportParameter("START", s_date)
        Dim END_DATE As New ReportParameter("END", s_date)
        Dim EMPLOYEE_NAME As New ReportParameter("NAME", e_name)
        e_id = Convert.ToInt32(e_id)

        Me.Query_CE_ARFF_ReportTableAdapter.Fill(Me.CE_ARFF_Dataset.Query_CE_ARFF_Report, e_id, s_date, e_date)
        Me.ARFF_CE_ReportViewer.LocalReport.SetParameters(START_DATE)
        Me.ARFF_CE_ReportViewer.LocalReport.SetParameters(END_DATE)
        Me.ARFF_CE_ReportViewer.LocalReport.SetParameters(EMPLOYEE_NAME)
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