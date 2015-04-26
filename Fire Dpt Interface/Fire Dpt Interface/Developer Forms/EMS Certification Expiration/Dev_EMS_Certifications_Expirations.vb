Public Class Dev_EMS_Certifications_Expirations
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim DevForm As DeveloperForm
        DevForm = New DeveloperForm()
        DevForm.Show()
        DevForm = Nothing
        Me.Close()
    End Sub

    Private Sub Dev_EMS_Certifications_Expirations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Training_Records_for_TAMUDataSet.EMS_Instructor_Exp' table. You can move, or remove it, as needed.
        Me.EMS_Instructor_ExpTableAdapter.Fill(Me.Training_Records_for_TAMUDataSet.EMS_Instructor_Exp)
        'TODO: This line of code loads data into the 'Training_Records_for_TAMUDataSet.EMS_X' table. You can move, or remove it, as needed.
        Me.EMS_XTableAdapter.Fill(Me.Training_Records_for_TAMUDataSet.EMS_X)

    End Sub

   
End Class