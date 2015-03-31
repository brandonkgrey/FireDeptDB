

Public Class DeveloperForm

    Private Sub DeveloperForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Emp_Info_Button_Click(sender As Object, e As EventArgs) Handles Emp_Info_Button.Click
        Dim EmpMenu As All_Employees
        EmpMenu = New All_Employees()
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
        Dim ClassInfoMenu As Developer_Class_Information
        ClassInfoMenu = New Developer_Class_Information()
        ClassInfoMenu.Show()
        ClassInfoMenu = Nothing
        Me.Close()
    End Sub

    Private Sub Dev_CE_Reports_Button_Click(sender As Object, e As EventArgs) Handles Dev_CE_Reports_Button.Click
        Dim CEReportsMenu As Developer_CE_Reports
        CEReportsMenu = New Developer_CE_Reports()
        CEReportsMenu.Show()
        CEReportsMenu = Nothing
        Me.Close()
    End Sub

    Private Sub Dev_Cert_List_Button_Click(sender As Object, e As EventArgs) Handles Dev_Cert_List_Button.Click
        Dim CertListsMenu As Dev_Certification_Lists
        CertListsMenu = New Dev_Certification_Lists()
        CertListsMenu.Show()
        CertListsMenu = Nothing
        Me.Close()
    End Sub

    Private Sub Dev_EMS_Cert_Button_Click(sender As Object, e As EventArgs) Handles Dev_EMS_Cert_Button.Click
        Dim EMSCertMenu As Dev_EMS_Certifications_Expirations
        EMSCertMenu = New Dev_EMS_Certifications_Expirations()
        EMSCertMenu.Show()
        EMSCertMenu = Nothing
        Me.Close()
    End Sub

    Private Sub Dev_Train_Reports_Button_Click(sender As Object, e As EventArgs) Handles Dev_Train_Reports_Button.Click
        Dim TrainReportsMenu As Developer_Training_Reports
        TrainReportsMenu = New Developer_Training_Reports()
        TrainReportsMenu.Show()
        TrainReportsMenu = Nothing
        Me.Close()
    End Sub
End Class