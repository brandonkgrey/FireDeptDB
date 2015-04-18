Imports Microsoft.Reporting.WinForms

Public Class HazMat_Training_Report_View
    Dim report_startdate As String
    Dim report_enddate As String
    Dim report_firecredit As Integer
    Dim report_filter As Integer
    Dim report_empID As Integer
    Private Sub HazMat_Training_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HazMat_Training_Report_Dataset.Query_HazMat_Training_Report' table. You can move, or remove it, as needed.

        report_startdate = Dev_HazMat_Training_Reports.HazMat_StartDate
        report_enddate = Dev_HazMat_Training_Reports.HazMat_EndDate
        report_firecredit = Dev_HazMat_Training_Reports.firecredit_filter
        report_filter = Dev_HazMat_Training_Reports.Nofilter
        report_empID = Dev_HazMat_Training_Reports.emp_id

        Dim START_DATE As New ReportParameter("START", report_startdate)
        Dim END_DATE As New ReportParameter("END", report_enddate)

        If report_filter = 1 Then
            Me.Query_HazMat_Training_ReportTableAdapter.FillByNoFilter(Me.HazMat_Training_Report_Dataset.Query_HazMat_Training_Report, report_startdate, report_enddate)
        ElseIf report_firecredit = 1 Then
            Me.Query_HazMat_Training_ReportTableAdapter.FillbyFilter(Me.HazMat_Training_Report_Dataset.Query_HazMat_Training_Report, report_startdate, report_enddate, report_firecredit)
        ElseIf report_firecredit = 0 Then
            Me.Query_HazMat_Training_ReportTableAdapter.FillbyFilter(Me.HazMat_Training_Report_Dataset.Query_HazMat_Training_Report, report_startdate, report_enddate, report_firecredit)
        End If

        Me.HM_Training_ReportViewer.LocalReport.SetParameters(START_DATE)
        Me.HM_Training_ReportViewer.LocalReport.SetParameters(END_DATE)
        Me.HM_Training_ReportViewer.RefreshReport()

    End Sub

    Private Sub HazMat_Training_Report_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

        Dim HMForm As Dev_HazMat_Training_Reports
        HMForm = New Dev_HazMat_Training_Reports()
        HMForm.Show()
        HMForm = Nothing
        'Do not do me.close!!! (It will cause this function to enter an infinite loop)
    End Sub


End Class