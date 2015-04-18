Public Class passwordReset

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Dim LoginMenu As Login
        LoginMenu = New Login()


        LoginMenu.Show()
        Login = Nothing
        Me.Close()
    End Sub
End Class