Public Class BasicForm

    Private Sub Personal_Info_Click(sender As Object, e As EventArgs) Handles Personal_Info.Click
        Dim MyInfoMenu As Single_User_Information
        MyInfoMenu = New Single_User_Information()
        MyInfoMenu.Show()
        MyInfoMenu = Nothing
        Me.Close()
    End Sub

    Private Sub Certificates_Click(sender As Object, e As EventArgs) Handles Certificates.Click
        'Dim MyInfoMenu As Single_User_Information
        'MyInfoMenu = New Single_User_Information()
        'MyInfoMenu.Show()
        'MyInfoMenu = Nothing
        'Me.Close()
    End Sub

    Private Sub BasicForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Welcome " + Login.sharedUsername
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Dim LoginMenu As Login
        LoginMenu = New Login()
        LoginMenu.Show()
        LoginMenu = Nothing
        Me.Close()
    End Sub

    Private Sub Username_Display_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub

End Class