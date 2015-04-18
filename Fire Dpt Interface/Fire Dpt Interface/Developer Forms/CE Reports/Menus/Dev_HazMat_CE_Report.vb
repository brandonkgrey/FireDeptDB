Public Class Dev_HazMat_CE_Report
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim DevForm As Developer_CE_Reports
        DevForm = New Developer_CE_Reports()
        DevForm.Show()
        DevForm = Nothing
        Me.Close()
    End Sub

    Private Sub HazMat_CE_Report_Button_Click(sender As Object, e As EventArgs) Handles HazMat_CE_Report_Button.Click

    End Sub
End Class