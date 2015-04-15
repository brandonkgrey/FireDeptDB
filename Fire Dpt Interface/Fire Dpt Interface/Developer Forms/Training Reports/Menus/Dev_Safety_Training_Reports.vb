Public Class Dev_Safety_Training_Reports

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim TrainMenu As Developer_Training_Reports
        TrainMenu = New Developer_Training_Reports()
        TrainMenu.Show()
        TrainMenu = Nothing
        Me.Close()
    End Sub

    Private Sub Dev_Safety_Training_Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Safety_TR_Report_Button_Click(sender As Object, e As EventArgs) Handles Safety_TR_Report_Button.Click
        Dim startdate As String = StartDate_DateTimePicker.Value.ToShortDateString
        Dim enddate As String = EndDate_DateTimePicker.Value.ToShortDateString
        'Send these var to new window to execute query 
    End Sub
End Class