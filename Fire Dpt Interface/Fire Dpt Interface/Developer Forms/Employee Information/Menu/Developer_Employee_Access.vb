Public Class All_Employees
    Friend Shared employeeID As Integer

    Private Sub All_Employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Fire_CertificationsTableAdapter.Fill(Me.Training_RecordsDataSet.Fire_Certifications)
        Me.Employee_InformationTableAdapter.Fill(Me.Training_RecordsDataSet.Employee_Information)
        FireCertificationsBindingSource.Position = FireCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
    End Sub


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim DevForm As DeveloperForm
        DevForm = New DeveloperForm()
        DevForm.Show()
        DevForm = Nothing
        Me.Close()
    End Sub


    Private Sub Save_Button_Click(sender As Object, e As EventArgs) Handles Save_Button.Click
        On Error GoTo SaveErr
        EmployeeInformationBindingSource.EndEdit()
        Employee_InformationTableAdapter.Update(Training_RecordsDataSet.Employee_Information)
        MessageBox.Show("Your modifications were saved!")
SaveErr:
        Exit Sub
    End Sub

    Private Sub Prev_Button_Click(sender As Object, e As EventArgs) Handles Prev_Button.Click
        EmployeeInformationBindingSource.MovePrevious()
        FireCertificationsBindingSource.Position = FireCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())

    End Sub

    Private Sub Next_Button_Click(sender As Object, e As EventArgs) Handles Next_Button.Click
        EmployeeInformationBindingSource.MoveNext()
        'FireCertificationsBindingSource.Position = FireCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        EmployeeInformationBindingSource.RemoveCurrent()
        MessageBox.Show("Deletion Complete!")
    End Sub


    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles ReportButton.Click

        employeeID = Convert.ToInt32(Emp_Textbox.Text)
        Dim IndReport As Indivdual_Employee_Report_View
        IndReport = New Indivdual_Employee_Report_View()
        IndReport.Show()
        IndReport = Nothing
        Me.Close()

    End Sub


   
End Class