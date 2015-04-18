Public Class Dev_ARFF_Training_Reports

    Friend Shared startdate As String
    Friend Shared enddate As String

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim DevForm As Developer_Training_Reports
        DevForm = New Developer_Training_Reports()
        DevForm.Show()
        DevForm = Nothing
        Me.Close()
    End Sub

    
    Private Sub ARFF_TR_Report_Button_Click(sender As Object, e As EventArgs) Handles ARFF_TR_Report_Button.Click

        startdate = ARFF_TR_Start_DateTimePicker.Value.ToShortDateString
        enddate = ARFF_TR_End_DateTimePicker.Value.ToShortDateString
        Dim RepView As New ARFF_Training_Report_View()
        RepView.Show()
        RepView = Nothing
        Me.Close()
    End Sub
End Class