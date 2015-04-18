Public Class CE_Safety_Report_View

    Private Sub CE_Safety_Report_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Safety_CE_ReportReportViewer.RefreshReport()
    End Sub

    Private Sub CE_EMS_Report_View_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim CEForm As New Dev_Safety_CE_Report()
        CEForm = New Dev_Safety_CE_Report()
        CEForm.Show()
        CEForm = Nothing
        'Do not do me.close!!! (It will cause this function to enter an infinite loop)
    End Sub
End Class