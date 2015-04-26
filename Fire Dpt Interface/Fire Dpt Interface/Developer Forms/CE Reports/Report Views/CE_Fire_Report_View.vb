Imports Microsoft.Reporting.WinForms

Public Class CE_Fire_Report_View

    Private Sub CE_Fire_Report_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim s_date As String = Dev_Fire_CE_Reports.start_date
        Dim e_date As String = Dev_Fire_CE_Reports.end_date
        Dim START_DATE As New ReportParameter("START", s_date)
        Dim END_DATE As New ReportParameter("END", e_date)


        Dim currdate As DateTime = DateTime.Now
        Dim timestamp As String = currdate.ToShortDateString
        Dim Timesig As New ReportParameter("TimeStamp", timestamp)

        Dim e_id = Dev_Fire_CE_Reports.emp_id
        Dim e_name = Dev_Fire_CE_Reports.employeeName
        Dim e_TCFP = Dev_Fire_CE_Reports.TCFP

        Dim NAME As New ReportParameter("NAME", e_name)
        Dim TCFP As New ReportParameter("TCFP", e_TCFP)

        Me.Query_CE_Fire_ReportTableAdapter.Fill(Me.CE_Fire_Dataset.Query_CE_Fire_Report, e_id, s_date, e_date)
        Me.CE_Fire_ReportViewer.LocalReport.SetParameters(START_DATE)
        Me.CE_Fire_ReportViewer.LocalReport.SetParameters(END_DATE)
        Me.CE_Fire_ReportViewer.LocalReport.SetParameters(Timesig)
        Me.CE_Fire_ReportViewer.LocalReport.SetParameters(NAME)
        Me.CE_Fire_ReportViewer.LocalReport.SetParameters(TCFP)
        Me.CE_Fire_ReportViewer.RefreshReport()
    End Sub

    Private Sub CE_Fire_Report_View_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim CEForm As New Dev_Fire_CE_Reports()
        CEForm = New Dev_Fire_CE_Reports()
        CEForm.Show()
        CEForm = Nothing
        'Do not do me.close!!! (It will cause this function to enter an infinite loop)
    End Sub
End Class