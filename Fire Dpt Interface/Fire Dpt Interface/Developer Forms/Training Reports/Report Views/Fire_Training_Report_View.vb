Imports Microsoft.Reporting.WinForms

Public Class Fire_Training_Report_View

    Private Sub Fire_Training_Report_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim s_date As String = Dev_Fire_Training_Reports.str_date
        Dim e_date As String = Dev_Fire_Training_Reports.end_date
        Dim START_DATE As New ReportParameter("START", s_date)
        Dim END_DATE As New ReportParameter("END", e_date)
        'TODO: This line of code loads data into the 'Fire_Training_Report_Dataset.Query_Fire_Training_Report' table. You can move, or remove it, as needed.
        Me.Query_Fire_Training_ReportTableAdapter.Fill(Me.Fire_Training_Report_Dataset.Query_Fire_Training_Report, s_date, e_date)
        Me.Fire_ReportViewer.LocalReport.SetParameters(START_DATE)
        Me.Fire_ReportViewer.LocalReport.SetParameters(END_DATE)
        Me.Fire_ReportViewer.RefreshReport()
    End Sub

    Private Sub Safety_Training_Report_View_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim Fire_Form As New Dev_Fire_Training_Reports()
        Fire_Form.Show()
        Fire_Form = Nothing
        'Do not do me.close!!! (It will cause this function to enter an infinite loop)
    End Sub
End Class