Imports Microsoft.Reporting.WinForms
Public Class Safety_Training_Report_View


    Private Sub Safety_Training_Report_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Training_Reports_Safety_Dataset.Query_Training_Report_Safety' table. You can move, or remove it, as needed.
        'need to place shared variables inside of this paramater !!!!!!!!!!!!!!!!!!!!!!
        Dim s_date As String = Dev_Safety_Training_Reports.startdate
        Dim e_date As String = Dev_Safety_Training_Reports.enddate
        Dim START_DATE As New ReportParameter("START", s_date)
        Dim END_DATE As New ReportParameter("END", e_date)
        Me.Query_Training_Report_SafetyTableAdapter.Fill(Me.Training_Reports_Safety_Dataset.Query_Training_Report_Safety, s_date, e_date)
        Me.TR_Safety_ReportViewer.LocalReport.SetParameters(START_DATE)
        Me.TR_Safety_ReportViewer.LocalReport.SetParameters(END_DATE)
        Me.TR_Safety_ReportViewer.RefreshReport()
    End Sub

    Private Sub Safety_Training_Report_View_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

        Dim Safety_Form As Dev_Safety_Training_Reports
        Safety_Form = New Dev_Safety_Training_Reports()
        Safety_Form.Show()
        Safety_Form = Nothing
        'Do not do me.close!!! (It will cause this function to enter an infinite loop)
    End Sub
End Class