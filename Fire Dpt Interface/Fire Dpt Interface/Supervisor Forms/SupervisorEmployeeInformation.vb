Public Class SupervisorEmployeeInformation

    Friend Shared currentID
    Friend Shared sendingForm As Boolean = False
    Dim employeeID

    Private Sub AuthorizationFix(choice As Integer)

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
        ALL_EMP_ReportButton.Visible = False
        EmployeeSearch.Visible = False
        Employee_List.Visible = False

    End Sub

    Private Sub SupervisorEmployeeInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Training_Records_for_TAMUDataSet.Assignment_Pay' table. You can move, or remove it, as needed.
        Me.Assignment_PayTableAdapter.Fill(Me.Training_Records_for_TAMUDataSet.Assignment_Pay)
        'TODO: This line of code loads data into the 'Training_Records_for_TAMUDataSet.Other_Certifications' table. You can move, or remove it, as needed.
        Me.Other_CertificationsTableAdapter.Fill(Me.Training_Records_for_TAMUDataSet.Other_Certifications)
        'TODO: This line of code loads data into the 'Training_Records_for_TAMUDataSet.EMS_Certification_Type' table. You can move, or remove it, as needed.
        Me.EMS_Certification_TypeTableAdapter.Fill(Me.Training_Records_for_TAMUDataSet.EMS_Certification_Type)
        'TODO: This line of code loads data into the 'Training_Records_for_TAMUDataSet.EMS_Certifications' table. You can move, or remove it, as needed.
        Me.EMS_CertificationsTableAdapter.Fill(Me.Training_Records_for_TAMUDataSet.EMS_Certifications)
        'TODO: This line of code loads data into the 'Training_Records_for_TAMUDataSet.Fire_Certifications' table. You can move, or remove it, as needed.
        Me.Fire_CertificationsTableAdapter.Fill(Me.Training_Records_for_TAMUDataSet.Fire_Certifications)
        'TODO: This line of code loads data into the 'SupervisorFilterDataSet.Employee_Information' table. You can move, or remove it, as needed.
        Me.Employee_InformationTableAdapter.Fill(Me.SupervisorFilterDataSet.Employee_Information)

        EmployeeInformationBindingSource.Sort = "Name"

        If Login.Authorization_LVL = 1 Then
            employeeID = Login.sharedUsername
            AuthorizationFix(BasicForm.tabSelect)

        End If

        FireCertificationsBindingSource.Position = FireCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        EMSCertificationsBindingSource.Position = EMSCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        OtherCertificationsBindingSource.Position = OtherCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        AssignmentPayBindingSource.Position = AssignmentPayBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())



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
        FireCertificationsBindingSource.Position = FireCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        EMSCertificationsBindingSource.Position = EMSCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        OtherCertificationsBindingSource.Position = OtherCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        AssignmentPayBindingSource.Position = AssignmentPayBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())

        currentID = Emp_Textbox.Text
    End Sub


    Private Sub ALL_EMP_ReportButton_Click(sender As Object, e As EventArgs) Handles ALL_EMP_ReportButton.Click
        currentID = Convert.ToInt32(Emp_Textbox.Text)
        sendingForm = True
        Dim IndReport As Indivdual_Employee_Report_View
        IndReport = New Indivdual_Employee_Report_View()
        IndReport.Show()
        IndReport = Nothing
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        sendingForm = False

        If Login.Authorization_LVL = 1 Then
            Dim BasicMenu As New BasicForm()
            BasicMenu.Show()
            BasicMenu = Nothing
            Me.Close()

        Else
            Dim SupMenu As SupervisorForm = New SupervisorForm()
            SupMenu.Show()
            SupMenu = Nothing
            Me.Close()
        End If
        
    End Sub
End Class