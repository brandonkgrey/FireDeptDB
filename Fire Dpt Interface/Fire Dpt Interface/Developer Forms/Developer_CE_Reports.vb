Public Class Developer_CE_Reports

    Private Sub CEExitButton_Click(sender As Object, e As EventArgs) Handles CEExitButton.Click
        Dim DevForm As DeveloperForm
        DevForm = New DeveloperForm()
        DevForm.Show()
        DevForm = Nothing
        Me.Close()
    End Sub

    Private Sub Ind_Report_Button_Click(sender As Object, e As EventArgs) Handles Ind_Report_Button.Click

    End Sub

End Class