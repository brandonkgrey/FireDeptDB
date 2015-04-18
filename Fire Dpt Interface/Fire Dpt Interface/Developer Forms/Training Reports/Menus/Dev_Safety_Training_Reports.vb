Public Class Dev_Safety_Training_Reports
    Friend Shared startdate As String
    Friend Shared enddate As String
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
        startdate = Safety_TR_SDateTimePicker.Value.ToShortDateString
        enddate = Safety_TR_EDateTimePicker.Value.ToShortDateString
        Dim RepView As New Safety_Training_Report_View()
        RepView.Show()
        RepView = Nothing
        Me.Close()
        'Send these var to new window to execute query 
    End Sub
End Class