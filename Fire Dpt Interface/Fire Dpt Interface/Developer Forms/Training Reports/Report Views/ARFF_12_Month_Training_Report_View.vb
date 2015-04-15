Public Class ARFF_12_Month_Training_Report_View
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim DevForm As Developer_Training_Reports
        DevForm = New Developer_Training_Reports()
        DevForm.Show()
        DevForm = Nothing
        Me.Close()
    End Sub

    Private Sub Dev_ARFF_12_Month_Training_Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ARFFTwelveMonthDataset.ARFF12Month' table. You can move, or remove it, as needed.
        Me.ARFF12MonthTableAdapter.Fill(Me.ARFFTwelveMonthDataset.ARFF12Month)

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