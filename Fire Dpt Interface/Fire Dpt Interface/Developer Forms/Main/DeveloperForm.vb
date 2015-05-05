

Public Class DeveloperForm

    Dim EmpMenu As All_Employees = New All_Employees()

    Private Sub DeveloperForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Welcome " + Login.sharedName + "  ---  Authorization:  Developer (4)"

    End Sub

    Private Sub Emp_Info_Button_Click(sender As Object, e As EventArgs) Handles Emp_Info_Button.Click

        EmpMenu.Show()
        EmpMenu = Nothing
        Me.Close()
    End Sub

    Private Sub LogOut_Button_Click(sender As Object, e As EventArgs) Handles LogOut_Button.Click
        Dim LoginMenu As Login
        LoginMenu = New Login()
        LoginMenu.Show()
        LoginMenu = Nothing
        Me.Close()
    End Sub

    Private Sub Class_Information_Button_Click(sender As Object, e As EventArgs) Handles Class_Information_Button.Click
        Dim ClassInfoMenu As Developer_Class_Information = New Developer_Class_Information()
        ClassInfoMenu.Show()
        ClassInfoMenu = Nothing
        Me.Close()
    End Sub

    Private Sub OpenAccessFileDFButton_Click(sender As Object, e As EventArgs) Handles OpenAccessFileDFButton.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim CEReport As Developer_CE_Reports = New Developer_CE_Reports()
        CEReport.Show()
        CEReport = Nothing
        Me.Close()
    End Sub

    Private Sub EMSCertExpButton_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim EMSCertExp As Dev_EMS_Certifications_Expirations = New Dev_EMS_Certifications_Expirations()
        EMSCertExp.Show()
        EMSCertExp = Nothing
        Me.Close()
    End Sub

    Private Sub CertListButton_Click(sender As Object, e As EventArgs) Handles CertListButton.Click
        Dim CertLists As Dev_Certification_Lists = New Dev_Certification_Lists()
        CertLists.Show()
        CertLists = Nothing
        Me.Close()
    End Sub

    Private Sub TrainingReportsButton_Click(sender As Object, e As EventArgs) Handles TrainingReportsButton.Click
        Dim TrainReports As Developer_Training_Reports = New Developer_Training_Reports()
        TrainReports.Show()
        TrainReports = Nothing
        Me.Close()
    End Sub
End Class