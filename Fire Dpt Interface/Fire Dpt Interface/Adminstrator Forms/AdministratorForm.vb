Public Class AdministratorForm

    Dim EmpMenu As All_Employees = New All_Employees()

    Private Sub AdministratorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Welcome " + Login.sharedUsername + "  ---  Authorization:  Administrator (3)"
    End Sub

    Private Sub Emp_Info_ButtonAF_Click(sender As Object, e As EventArgs) Handles Emp_Info_ButtonAF.Click
        EmpMenu.Show()
        EmpMenu = Nothing
        Me.Close()
    End Sub

    Private Sub Class_Information_ButtonAF_Click(sender As Object, e As EventArgs) Handles Class_Information_ButtonAF.Click
        Dim ClassInfoMenu As Developer_Class_Information = New Developer_Class_Information()
        ClassInfoMenu.Show()
        ClassInfoMenu = Nothing
        Me.Close()
    End Sub

    Private Sub CEReportsAFButton_Click(sender As Object, e As EventArgs) Handles CEReportsAFButton.Click

    End Sub

    Private Sub EMSCertsAFButton_Click(sender As Object, e As EventArgs) Handles EMSCertsAFButton.Click

    End Sub

    Private Sub CertListsButtonAF_Click(sender As Object, e As EventArgs) Handles CertListsButtonAF.Click

    End Sub

    Private Sub LogOut_Button_Click(sender As Object, e As EventArgs) Handles LogOut_Button.Click
        Dim LoginMenu As Login
        LoginMenu = New Login()
        LoginMenu.Show()
        LoginMenu = Nothing
        Me.Close()
    End Sub
End Class