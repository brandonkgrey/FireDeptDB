Public Class Dev_Safety_Training_Reports

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim TrainMenu As Developer_Training_Reports
        TrainMenu = New Developer_Training_Reports()
        TrainMenu.Show()
        TrainMenu = Nothing
        Me.Close()
    End Sub
End Class