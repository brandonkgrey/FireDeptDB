Imports System.Text
Imports System.Data.OleDb

Public Class All_Employees
    Dim Dbstring As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + "C:\Users\Alejandro\Desktop\Fire Department DB\ExampleDb.accdb"
    Dim Authorization_Level
    Dim employeeID
    Dim HiddenTabs As Stack(Of TabPage) = New Stack(Of TabPage)
    Dim choice As Integer
    Dim employeeName As String
    Friend Shared currentID
    Friend Shared sendingForm As Boolean = False

    Private Sub AuthorizationFix(choice As Integer, AuthLvl As Integer)
        'Basic Authorization
        If (AuthLvl = 1) Then

            EmployeeInformationBindingSource.Position = EmployeeInformationBindingSource.Find("Employee_ID", employeeID)



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
            Next_Button.Visible = False
            Prev_Button.Visible = False
            DeleteButton.Visible = False
            Save_Button.Visible = False
            ALL_EMP_ReportButton.Visible = False
            EmployeeSearch.Visible = False
            Employee_List.Visible = False

        End If



    End Sub

    Private Sub All_Employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Training_Records_for_TAMUDataSet.Assignment_Pay' table. You can move, or remove it, as needed.
        Me.Assignment_PayTableAdapter.Fill(Me.Training_Records_for_TAMUDataSet.Assignment_Pay)
        'TODO: This line of code loads data into the 'Training_Records_for_TAMUDataSet.Other_Certifications' table. You can move, or remove it, as needed.
        Me.Other_CertificationsTableAdapter.Fill(Me.Training_Records_for_TAMUDataSet.Other_Certifications)
        'TODO: This line of code loads data into the 'Training_Records_for_TAMUDataSet.EMS_Certifications' table. You can move, or remove it, as needed.
        Me.EMS_CertificationsTableAdapter.Fill(Me.Training_Records_for_TAMUDataSet.EMS_Certifications)
        'TODO: This line of code loads data into the 'Training_Records_for_TAMUDataSet.Fire_Certifications' table. You can move, or remove it, as needed.
        Me.Fire_CertificationsTableAdapter.Fill(Me.Training_Records_for_TAMUDataSet.Fire_Certifications)
        'TODO: This line of code loads data into the 'Training_Records_for_TAMUDataSet.Employee_Information' table. You can move, or remove it, as needed.
        Me.Employee_InformationTableAdapter.Fill(Me.Training_Records_for_TAMUDataSet.Employee_Information)


        Authorization_Level = Login.Authorization_LVL
        employeeID = Login.sharedUsername
        choice = BasicForm.tabSelect
        employeeName = Login.sharedName
        'Add this when we connect to the Fire Dept. DB

        EmployeeInformationBindingSource.Sort = "Name"

        AuthorizationFix(choice, Authorization_Level)

        'EmployeeInformationBindingSource.Position = EmployeeInformationBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString)
        FireCertificationsBindingSource.Position = FireCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        EMSCertificationsBindingSource.Position = EMSCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        OtherCertificationsBindingSource.Position = OtherCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        AssignmentPayBindingSource.Position = AssignmentPayBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())

    End Sub


    Private Sub Emp_Name_Click(sender As Object, e As EventArgs)
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
        Employee_InformationTableAdapter.Update(Training_Records_for_TAMUDataSet)
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

        currentID = Emp_Textbox.Text

    End Sub

    Private Sub Next_Button_Click(sender As Object, e As EventArgs) Handles Next_Button.Click
        EmployeeInformationBindingSource.MoveNext()
        'EmployeeInformationBindingSource2.MoveNext()

        'While AuthText.Text <> Authorization_Level.ToString
        'EmployeeInformationBindingSource.MoveNext()
        'EmployeeInformationBindingSource2.MoveNext()
        'End While

        FireCertificationsBindingSource.Position = FireCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        EMSCertificationsBindingSource.Position = EMSCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        OtherCertificationsBindingSource.Position = OtherCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        AssignmentPayBindingSource.Position = AssignmentPayBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())

        currentID = Emp_Textbox.Text
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        'EmployeeInformationBindingSource.RemoveCurrent()
        MessageBox.Show("Deletion Complete!")
    End Sub

    Private Sub ALL_EMP_ReportButton_Click(sender As Object, e As EventArgs) Handles ALL_EMP_ReportButton.Click
        currentID = Convert.ToInt32(Emp_Textbox.Text)
        sendingForm = True
        Dim IndReport As Indivdual_Employee_Report_View
        IndReport = New Indivdual_Employee_Report_View()
        IndReport.Show()
        IndReport = Nothing
        sendingForm = True
    End Sub

End Class