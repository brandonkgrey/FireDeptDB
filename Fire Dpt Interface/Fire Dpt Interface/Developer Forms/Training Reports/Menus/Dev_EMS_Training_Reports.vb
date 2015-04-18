Public Class Dev_EMS_Training_Reports

    Friend Shared startdate As String
    Friend Shared enddate As String

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim DevForm As Developer_Training_Reports
        DevForm = New Developer_Training_Reports()
        DevForm.Show()
        DevForm = Nothing
        Me.Close()
    End Sub

    Private Sub EMS_TR_Report_Button_Click(sender As Object, e As EventArgs) Handles EMS_TR_Report_Button.Click
        startdate = EMS_TR_SDateTimePicker.Value.ToShortDateString()
        enddate = EMS_TR_EDateTimePicker.Value.ToShortDateString()
        Dim RepView As New EMS_Training_Report_View()
        RepView.Show()
        RepView = Nothing
        Me.Close()
    End Sub
End Class