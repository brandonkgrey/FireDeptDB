Imports System.Text
Imports System.Data.OleDb

Public Class All_Employees
    Dim Dbstring As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + "C:\Users\Brandon\Desktop\Fire Department Project\ExampleDB.accdb"
    Dim Authorization_Level
    Dim EmployeeID
    Dim username
    Dim HiddenTabs As Stack(Of TabPage) = New Stack(Of TabPage)
    Dim choice As Integer

    Private Sub AuthorizationFix(choice As Integer, AuthLvl As Integer)
        'Basic Authorization
        If (AuthLvl = 1) Then

            If choice = 0 Then
                EmpInfo.TabPages.RemoveAt(6)
                EmpInfo.TabPages.RemoveAt(5)
                EmpInfo.TabPages.RemoveAt(4)
                EmpInfo.TabPages.RemoveAt(3)
                EmpInfo.TabPages.RemoveAt(2)
                EmpInfo.TabPages.RemoveAt(1)

            ElseIf choice = 1 Then
                EmpInfo.TabPages.RemoveAt(6)
                EmpInfo.TabPages.RemoveAt(5)
                EmpInfo.TabPages.RemoveAt(4)
                EmpInfo.TabPages.RemoveAt(3)
                EmpInfo.TabPages.RemoveAt(2)
                EmpInfo.TabPages.RemoveAt(0)

            ElseIf choice = 2 Then
                EmpInfo.TabPages.RemoveAt(6)
                EmpInfo.TabPages.RemoveAt(5)
                EmpInfo.TabPages.RemoveAt(4)
                EmpInfo.TabPages.RemoveAt(3)
                EmpInfo.TabPages.RemoveAt(1)
                EmpInfo.TabPages.RemoveAt(0)

            ElseIf choice = 3 Then
                EmpInfo.TabPages.RemoveAt(6)
                EmpInfo.TabPages.RemoveAt(5)
                EmpInfo.TabPages.RemoveAt(4)
                EmpInfo.TabPages.RemoveAt(2)
                EmpInfo.TabPages.RemoveAt(1)
                EmpInfo.TabPages.RemoveAt(0)

            ElseIf choice = 4 Then
                EmpInfo.TabPages.RemoveAt(6)
                EmpInfo.TabPages.RemoveAt(5)
                EmpInfo.TabPages.RemoveAt(3)
                EmpInfo.TabPages.RemoveAt(2)
                EmpInfo.TabPages.RemoveAt(1)
                EmpInfo.TabPages.RemoveAt(0)

            ElseIf choice = 5 Then
                EmpInfo.TabPages.RemoveAt(6)
                EmpInfo.TabPages.RemoveAt(4)
                EmpInfo.TabPages.RemoveAt(3)
                EmpInfo.TabPages.RemoveAt(2)
                EmpInfo.TabPages.RemoveAt(1)
                EmpInfo.TabPages.RemoveAt(0)

            End If

            'get rid of their ability to edit data
            'Next_Button.Visible = False
            Prev_Button.Visible = False
            DeleteButton.Visible = False
            Save_Button.Visible = False
            PrintButton.Visible = False
            EmployeeSearch.Visible = False
            Employee_List.Visible = False

        End If



    End Sub

    Private Sub All_Employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Assignment_PayTableAdapter.Fill(Me.Training_Records_EncryptedDataSet.Assignment_Pay)
        Me.Other_CertificationsTableAdapter.Fill(Me.Training_Records_EncryptedDataSet.Other_Certifications)
        Me.EMS_Certification_TypeTableAdapter.Fill(Me.Training_Records_EncryptedDataSet.EMS_Certification_Type)
        Me.EMS_CertificationsTableAdapter.Fill(Me.Training_Records_EncryptedDataSet.EMS_Certifications)
        Me.Employee_InformationTableAdapter.Fill(Me.Training_Records_EncryptedDataSet.Employee_Information)
        Me.Fire_CertificationsTableAdapter.Fill(Me.Training_Records_EncryptedDataSet.Fire_Certifications)
        Try
            Me.Employee_InformationTableAdapter1.Fill(Me.AuthLevelDataSet.Employee_Information)
        Catch ex As Exception
        End Try

        Authorization_Level = Login.Authorization_LVL
        username = Login.sharedUsername
        choice = BasicForm.tabSelect
        'EmployeeID = Login.EmployeeIdentification
        'Add this when we connect to the Fire Dept. DB

        EmployeeInformationBindingSource.Sort = "Name"

        AuthorizationFix(choice, Authorization_Level)

        EmployeeInformationBindingSource.Position = EmployeeInformationBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString)
        FireCertificationsBindingSource.Position = FireCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        EMSCertificationsBindingSource.Position = EMSCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        OtherCertificationsBindingSource.Position = OtherCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        AssignmentPayBindingSource.Position = AssignmentPayBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())

    End Sub


    Private Sub Emp_Name_Click(sender As Object, e As EventArgs) Handles Emp_Name.Click
        MsgBox("Access Level: " + Authorization_Level.ToString, MsgBoxStyle.Critical)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click

        If Authorization_Level = 4 Then
            Dim DevForm As DeveloperForm
            DevForm = New DeveloperForm()
            DevForm.Show()
            DevForm = Nothing
            Me.Close()
        ElseIf Authorization_Level = 3 Then
        ElseIf Authorization_Level = 2 Then
        ElseIf Authorization_Level = 1 Then
            Dim BaseForm As New BasicForm
            BaseForm = New BasicForm
            BaseForm.Show()
            BaseForm = Nothing
            Me.Close()
        End If

    End Sub


    Private Sub Save_Button_Click(sender As Object, e As EventArgs) Handles Save_Button.Click
        On Error GoTo SaveErr
        EmployeeInformationBindingSource.EndEdit()
        Employee_InformationTableAdapter.Update(Training_Records_EncryptedDataSet.Employee_Information)
        MessageBox.Show("Your modifications were saved!")
SaveErr:
        Exit Sub
    End Sub

    Private Sub Prev_Button_Click(sender As Object, e As EventArgs) Handles Prev_Button.Click
        EmployeeInformationBindingSource.MovePrevious()
        FireCertificationsBindingSource.Position = FireCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        EMSCertificationsBindingSource.Position = EMSCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        OtherCertificationsBindingSource.Position = OtherCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        AssignmentPayBindingSource.Position = AssignmentPayBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())

    End Sub

    Private Sub Next_Button_Click(sender As Object, e As EventArgs) Handles Next_Button.Click
        EmployeeInformationBindingSource.MoveNext()
        EmployeeInformationBindingSource2.MoveNext()

        'While AuthText.Text <> Authorization_Level.ToString
        'EmployeeInformationBindingSource.MoveNext()
        'EmployeeInformationBindingSource2.MoveNext()
        'End While

        FireCertificationsBindingSource.Position = FireCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        EMSCertificationsBindingSource.Position = EMSCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        OtherCertificationsBindingSource.Position = OtherCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        AssignmentPayBindingSource.Position = AssignmentPayBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())


    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        EmployeeInformationBindingSource.RemoveCurrent()
        MessageBox.Show("Deletion Complete!")
    End Sub

End Class