Public Class SupervisorForm

    Private Sub SupervisorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Welcome " + Login.sharedUsername
    End Sub

    Private Sub Emp_Info_Button_Click(sender As Object, e As EventArgs) Handles Emp_Info_Button.Click
        Dim SupInfo As New SupervisorEmployeeInformation()
        SupInfo.Show()
        SupInfo = Nothing
        Me.Close()
    End Sub

    Private Sub LogoutBFButton_Click(sender As Object, e As EventArgs) Handles LogoutBFButton.Click
        Dim loginMenu As New Login()
        loginMenu.Show()
        loginMenu = Nothing
        Me.Close()
    End Sub

    Private Sub Class_Information_Button_Click(sender As Object, e As EventArgs) Handles Class_Information_Button.Click
        Dim ClassInfo As New Developer_Class_Information
        ClassInfo.Show()
        ClassInfo = Nothing
        Me.Close()
    End Sub
End Class