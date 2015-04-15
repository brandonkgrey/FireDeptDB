Public Class Dev_Safety_CE_Report
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim DevForm As Developer_CE_Reports
        DevForm = New Developer_CE_Reports()
        DevForm.Show()
        DevForm = Nothing
        Me.Close()
    End Sub

    Private Sub Dev_Safety_CE_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class