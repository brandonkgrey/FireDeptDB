Public Class All_Employees


    Private Sub All_Employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Employee_InformationTableAdapter.Fill(Me.Training_RecordsDataSet.Employee_Information)
    End Sub


    Private Sub Emp_Name_Click(sender As Object, e As EventArgs) Handles Emp_Name.Click

    End Sub

    Private Sub Emp_ID_Click(sender As Object, e As EventArgs) Handles Emp_ID.Click

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

    End Sub

    Private Sub Next_Button_Click(sender As Object, e As EventArgs) Handles Next_Button.Click
        EmployeeInformationBindingSource.MoveNext()       
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        EmployeeInformationBindingSource.RemoveCurrent()
        MessageBox.Show("Deletion Complete!")
    End Sub


    Private Sub FireCertifications_Click(sender As Object, e As EventArgs) Handles AeroOpsCheckbox.Click

    End Sub

    Private Sub EndDate_Textbox_TextChanged(sender As Object, e As EventArgs) Handles EndDate_Textbox.TextChanged

    End Sub

    Private Sub EndDateLabel_Click(sender As Object, e As EventArgs) Handles EndDateLabel.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TCFP_PIN_Label_Click(sender As Object, e As EventArgs) Handles TCFP_PIN_Label.Click

    End Sub









End Class