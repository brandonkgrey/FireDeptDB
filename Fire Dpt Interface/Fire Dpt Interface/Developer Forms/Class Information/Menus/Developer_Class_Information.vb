Public Class Developer_Class_Information

    Friend Shared class_number As Integer

    Private Sub Prev_Button_Click(sender As Object, e As EventArgs) Handles Prev_Button.Click

    End Sub

    Private Sub Next_Button_Click(sender As Object, e As EventArgs) Handles Next_Button.Click

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

    End Sub

    Private Sub Save_Button_Click(sender As Object, e As EventArgs) Handles Save_Button.Click

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim DevForm As DeveloperForm
        DevForm = New DeveloperForm()
        DevForm.Show()
        DevForm = Nothing
        Me.Close()
    End Sub

    Private Sub ReportButton_Click(sender As Object, e As EventArgs) Handles ReportButton.Click

        ''class_number = classtextbox
        Dim repview As New Class_Information_Report_View()
        repview.Show()
        repview = Nothing
        Me.Close()
    End Sub
End Class