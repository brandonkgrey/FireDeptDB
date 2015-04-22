Public Class SupervisorEmployeeInformation

    Friend Shared currentID
    Friend Shared sendingForm As Boolean = False

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

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

    End Sub

    Private Sub Save_Button_Click(sender As Object, e As EventArgs) Handles Save_Button.Click

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
        Dim SupMenu As SupervisorForm = New SupervisorForm()
        SupMenu.Show()
        SupMenu = Nothing
        Me.Close()
    End Sub
End Class