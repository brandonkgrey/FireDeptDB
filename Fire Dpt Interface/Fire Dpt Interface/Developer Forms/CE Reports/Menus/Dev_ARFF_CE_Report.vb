Public Class Dev_ARFF_CE_Report

    Friend Shared emp_id As Integer
    Friend Shared startdate As String
    Friend Shared enddate As String

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim DevForm As Developer_CE_Reports
        DevForm = New Developer_CE_Reports()
        DevForm.Show()
        DevForm = Nothing
        Me.Close()
    End Sub

    Private Sub ARFF_CE_Report_Button_Click(sender As Object, e As EventArgs) Handles ARFF_CE_Report_Button.Click

        startdate = Start_Date_DateTimePicker.Value.ToShortDateString
        enddate = End_Date_DateTimePicker.Value.ToShortDateString
        Dim RepView As New CE_ARFF_Report_View()
        RepView.Show()
        RepView = Nothing
        'Send these var to new window to execute query 
    End Sub

End Class