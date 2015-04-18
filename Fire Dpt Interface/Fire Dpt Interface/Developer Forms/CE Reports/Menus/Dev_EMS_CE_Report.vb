Public Class Dev_EMS_CE_Report

    Friend Shared emp_id As Integer
    Friend Shared start_date As String
    Friend Shared end_date As String
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim DevForm As Developer_CE_Reports
        DevForm = New Developer_CE_Reports()
        DevForm.Show()
        DevForm = Nothing
        Me.Close()
    End Sub

    Private Sub EMS_CE_Report_Button_Click(sender As Object, e As EventArgs) Handles EMS_CE_Report_Button.Click
        start_date = EMS_CE_SDateTimePicker.Value.ToShortDateString()
        end_date = EMS_CE_EDateTimePicker.Value.ToShortDateString()
        Dim RepView As New CE_EMS_Report_View()
        RepView.Show()
        RepView = Nothing
        Me.Close()
    End Sub


End Class