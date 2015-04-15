Public Class Dev_ARFF_CE_Report
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim DevForm As Developer_CE_Reports
        DevForm = New Developer_CE_Reports()
        DevForm.Show()
        DevForm = Nothing
        Me.Close()
    End Sub

    Private Sub ARFF_CE_Report_Button_Click(sender As Object, e As EventArgs) Handles ARFF_CE_Report_Button.Click

        Dim name As String = "Doe,John"
        Dim startdate As String = Start_Date_DateTimePicker.Value.ToShortDateString
        Dim enddate As String = End_Date_DateTimePicker.Value.ToShortDateString
        'Send these var to new window to execute query 
    End Sub

    Private Sub Dev_ARFF_CE_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class