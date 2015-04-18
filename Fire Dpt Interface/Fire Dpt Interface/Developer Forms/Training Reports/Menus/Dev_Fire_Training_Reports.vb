Public Class Dev_Fire_Training_Reports

    Friend Shared str_date As String
    Friend Shared end_date As String


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim DevForm As Developer_Training_Reports
        DevForm = New Developer_Training_Reports()
        DevForm.Show()
        DevForm = Nothing
        Me.Close()
    End Sub


    Private Sub Fire_TR_Report_Button_Click(sender As Object, e As EventArgs) Handles Fire_TR_Report_Button.Click
        str_date = Fire_TR_SDateTimePicker.Value.ToShortDateString()
        end_date = Fire_TR_EDateTimePicker.Value.ToShortDateString()
        Dim RepView As New Fire_Training_Report_View()
        RepView.Show()
        RepView = Nothing
        Me.Close()
    End Sub
End Class