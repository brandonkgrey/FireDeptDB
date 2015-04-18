Imports Microsoft.Reporting.WinForms

Public Class ARFF_12_Month_Training_Report_View
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim DevForm As Developer_Training_Reports
        DevForm = New Developer_Training_Reports()
        DevForm.Show()
        DevForm = Nothing
        Me.Close()
    End Sub

    Private Sub Dev_ARFF_12_Month_Training_Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim currdate As DateTime = DateAdd("m", -12, DateTime.Now)
        Dim startdate As String = currdate.ToString("MM/dd/yyyy")
        Dim enddate As String = DateTime.Now.ToString("MM/dd/yyyy")
        Dim START_DATE As New ReportParameter("START", startdate)
        Dim END_DATE As New ReportParameter("END", enddate)

        Me.ARFF12MonthTableAdapter.Fill(Me.ARFFTwelveMonthDataset.ARFF12Month)
        Me.ARFF_12M_Report.LocalReport.SetParameters(START_DATE)
        Me.ARFF_12M_Report.LocalReport.SetParameters(END_DATE)
        Me.ARFF_12M_Report.RefreshReport()
    End Sub

    Private Sub ARFF_12_Month_Training_Report_View_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim TRForm As Developer_Training_Reports
        TRForm = New Developer_Training_Reports()
        TRForm.Show()
        TRForm = Nothing
        'Do not do me.close!!! (It will cause this function to enter an infinite loop)
    End Sub

End Class