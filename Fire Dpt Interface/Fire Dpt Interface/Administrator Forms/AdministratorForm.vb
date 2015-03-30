Public Class AdministratorForm

    Private Sub AdministratorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Welcome " + Login.sharedUsername
    End Sub
End Class