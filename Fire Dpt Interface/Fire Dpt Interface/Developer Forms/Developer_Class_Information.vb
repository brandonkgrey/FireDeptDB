Public Class Developer_Class_Information

    Dim AuthLvl

    Private Sub Developer_Class_Information_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Training_Records_EncryptedDataSet.Class_Attendance_Information' table. You can move, or remove it, as needed.
        Me.Class_Attendance_InformationTableAdapter.Fill(Me.Training_Records_EncryptedDataSet.Class_Attendance_Information)
        'TODO: This line of code loads data into the 'Training_Records_EncryptedDataSet.Class_Information' table. You can move, or remove it, as needed.
        Me.Class_InformationTableAdapter.Fill(Me.Training_Records_EncryptedDataSet.Class_Information)
        'TODO: This line of code loads data into the 'Training_Records_EncryptedDataSet.Employee_Information' table. You can move, or remove it, as needed.
        Me.Employee_InformationTableAdapter.Fill(Me.Training_Records_EncryptedDataSet.Employee_Information)

        AuthLvl = Login.Authorization_LVL
    End Sub


    Private Sub Prev_Button_Click(sender As Object, e As EventArgs) Handles Prev_Button.Click
        ClassInformationBindingSource.MovePrevious()
    End Sub

    Private Sub Next_Button_Click(sender As Object, e As EventArgs) Handles Next_Button.Click
        ClassInformationBindingSource.MoveNext()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        ClassInformationBindingSource.RemoveCurrent()
        MessageBox.Show("Deletion Complete!")
    End Sub

    Private Sub Save_Button_Click(sender As Object, e As EventArgs) Handles Save_Button.Click
        On Error GoTo SaveErr
        ClassInformationBindingSource.EndEdit()
        Class_InformationTableAdapter.Update(Training_Records_EncryptedDataSet.Class_Information)
        MessageBox.Show("Your modifications were saved!")
SaveErr:
        Exit Sub
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        If AuthLvl = 4 Then
            Dim DevForm As DeveloperForm
            DevForm = New DeveloperForm()
            DevForm.Show()
            DevForm = Nothing
            Me.Close()
        ElseIf AuthLvl = 3 Then
            Dim AdminForm As AdministratorForm = New AdministratorForm()
            AdminForm.Show()
            AdminForm = Nothing
            Me.Close()
        End If
    End Sub

End Class