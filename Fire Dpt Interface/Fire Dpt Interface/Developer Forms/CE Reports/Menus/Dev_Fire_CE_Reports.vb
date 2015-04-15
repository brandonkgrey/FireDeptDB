Public Class Dev_Fire_CE_Reports

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim DevForm As Developer_CE_Reports
        DevForm = New Developer_CE_Reports()
        DevForm.Show()
        DevForm = Nothing
        Me.Close()
    End Sub

    Private Sub FireCE_Preview_Button_Click(sender As Object, e As EventArgs) Handles FireCE_Preview_Button.Click

    End Sub

    Private Sub FireCE_Print_Button_Click(sender As Object, e As EventArgs) Handles FireCE_Print_Button.Click

    End Sub
End Class