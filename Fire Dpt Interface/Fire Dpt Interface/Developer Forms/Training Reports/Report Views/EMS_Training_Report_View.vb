Imports Microsoft.Reporting.WinForms

Public Class EMS_Training_Report_View
    Private Sub EMS_Training_Report_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim d_start As String = Dev_EMS_Training_Reports.startdate
        Dim d_end As String = Dev_EMS_Training_Reports.enddate
        Dim START_DATE As New ReportParameter("START", d_start)
        Dim END_DATE As New ReportParameter("END", d_end)
        Me.Query_EMS_Training_ReportTableAdapter.Fill(Me.EMS_Training_Report_Dataset.Query_EMS_Training_Report, d_start, d_end)
        Me.EMS_Training_ReportViewer.LocalReport.SetParameters(START_DATE)
        Me.EMS_Training_ReportViewer.LocalReport.SetParameters(END_DATE)
        Me.EMS_Training_ReportViewer.RefreshReport()
    End Sub

    Private Sub EMS_Training_Report_View_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

        Dim EMS_Form As Dev_EMS_Training_Reports
        EMS_Form = New Dev_EMS_Training_Reports()
        EMS_Form.Show()
        EMS_Form = Nothing
        'Do not do me.close!!! (It will cause this function to enter an infinite loop)
    End Sub
End Class