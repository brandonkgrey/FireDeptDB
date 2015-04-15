Public Class Dev_EMS_CE_Report
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim DevForm As Developer_CE_Reports
        DevForm = New Developer_CE_Reports()
        DevForm.Show()
        DevForm = Nothing
        Me.Close()
    End Sub

    Private Sub EMS_CE_Outputfile_Button_Click(sender As Object, e As EventArgs) Handles EMS_CE_Outputfile_Button.Click

    End Sub

    Private Sub EMS_CE_Preview_Button_Click(sender As Object, e As EventArgs) Handles EMS_CE_Preview_Button.Click

    End Sub


End Class