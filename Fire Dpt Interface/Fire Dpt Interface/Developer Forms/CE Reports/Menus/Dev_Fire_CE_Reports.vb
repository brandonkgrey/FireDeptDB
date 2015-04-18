Public Class Dev_Fire_CE_Reports

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

   
    Private Sub FireCE_Report_Button_Click(sender As Object, e As EventArgs) Handles FireCE_Report_Button.Click
        start_date = FireCE_SDateTimePicker.Value.ToShortDateString
        end_date = FireCE_EDateTimePicker.Value.ToShortDateString
        Dim repview As New CE_Fire_Report_View()
        repview.Show()
        repview = Nothing
        Me.Close()
    End Sub
End Class