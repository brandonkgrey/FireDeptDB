Public Class BasicForm

    Friend Shared tabSelect As Integer
    Dim MyInfoMenu As SupervisorEmployeeInformation


    Private Sub BasicForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Welcome " + Login.sharedUsername + "  ---  Authorization:  Basic (1)"

        MyInfoMenu = New SupervisorEmployeeInformation()

    End Sub


    Private Sub Personal_InfoBFButton_Click(sender As Object, e As EventArgs) Handles Personal_InfoBFButton.Click
        tabSelect = 0

        MyInfoMenu.Show()
        MyInfoMenu = Nothing
        Me.Close()
    End Sub

    Private Sub FireCertsBFButton_Click(sender As Object, e As EventArgs) Handles FireCertsBFButton.Click
        tabSelect = 1

        MyInfoMenu.Show()
        MyInfoMenu = Nothing
        Me.Close()
    End Sub

    Private Sub EMSCertsBFButton_Click(sender As Object, e As EventArgs) Handles EMSCertsBFButton.Click
        tabSelect = 2

        MyInfoMenu.Show()
        MyInfoMenu = Nothing
        Me.Close()
    End Sub

    Private Sub OtherCertsBFButton_Click(sender As Object, e As EventArgs) Handles OtherCertsBFButton.Click
        tabSelect = 3

        MyInfoMenu.Show()
        MyInfoMenu = Nothing
        Me.Close()
    End Sub

    Private Sub MyCertifcatesBFButton_Click(sender As Object, e As EventArgs) Handles MyCertifcatesBFButton.Click
        tabSelect = 4

        MyInfoMenu.Show()
        MyInfoMenu = Nothing
        Me.Close()
    End Sub

    Private Sub AssignmentsBFButton_Click(sender As Object, e As EventArgs) Handles AssignmentsBFButton.Click
        tabSelect = 5

        MyInfoMenu.Show()
        MyInfoMenu = Nothing
        Me.Close()
    End Sub

    Private Sub LogoutBFButton_Click(sender As Object, e As EventArgs) Handles LogoutBFButton.Click
        Dim LoginMenu As Login
        LoginMenu = New Login()
        LoginMenu.Show()
        LoginMenu = Nothing
        Me.Close()
    End Sub
End Class