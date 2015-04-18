Imports Microsoft.Reporting.WinForms

Public Class CE_EMS_Report_View

    Private Sub CE_EMS_Report_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CE_EMS_Dataset.Query_EMS_CE_Report' table. You can move, or remove it, as needed.
        Dim s_date = Dev_EMS_CE_Report.start_date
        Dim e_date = Dev_EMS_CE_Report.end_date
        Dim START_DATE As New ReportParameter("START", s_date)
        Dim END_DATE As New ReportParameter("END", e_date)

        Dim currdate As DateTime = DateTime.Now
        Dim timestamp As String = currdate.ToShortDateString
        Dim Timesig As New ReportParameter("TimeStamp", timestamp)

        'needs dynamic emp id 
        Me.Query_EMS_CE_ReportTableAdapter.Fill(Me.CE_EMS_Dataset.Query_EMS_CE_Report, 111195971, s_date, e_date)
        Me.EMS_CE_ReportViewer.LocalReport.SetParameters(START_DATE)
        Me.EMS_CE_ReportViewer.LocalReport.SetParameters(END_DATE)
        Me.EMS_CE_ReportViewer.LocalReport.SetParameters(Timesig)
        Me.EMS_CE_ReportViewer.RefreshReport()
    End Sub

    Private Sub CE_EMS_Report_View_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim CEForm As New Dev_EMS_CE_Report()
        CEForm = New Dev_EMS_CE_Report()
        CEForm.Show()
        CEForm = Nothing
        'Do not do me.close!!! (It will cause this function to enter an infinite loop)
    End Sub

End Class