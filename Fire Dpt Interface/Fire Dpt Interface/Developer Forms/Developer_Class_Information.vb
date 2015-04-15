Public Class Developer_Class_Information

    Private Sub Developer_Class_Information_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Training_Records_EncryptedDataSet.Class_Attendance_Information' table. You can move, or remove it, as needed.
        Me.Class_Attendance_InformationTableAdapter.Fill(Me.Training_Records_EncryptedDataSet.Class_Attendance_Information)
        'TODO: This line of code loads data into the 'Training_Records_EncryptedDataSet.Class_Information' table. You can move, or remove it, as needed.
        Me.Class_InformationTableAdapter.Fill(Me.Training_Records_EncryptedDataSet.Class_Information)
        'TODO: This line of code loads data into the 'Training_Records_EncryptedDataSet.Employee_Information' table. You can move, or remove it, as needed.
        Me.Employee_InformationTableAdapter.Fill(Me.Training_Records_EncryptedDataSet.Employee_Information)

    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub TCFP_PIN_Label_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub EndDateLabel_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub EndDate_Textbox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ClassSearchbyName_Click(sender As Object, e As EventArgs) Handles ClassSearchbyName.Click

    End Sub

    Private Sub Prev_Button_Click(sender As Object, e As EventArgs) Handles Prev_Button.Click
        ClassInformationBindingSource.MovePrevious()
    End Sub

    Private Sub Next_Button_Click(sender As Object, e As EventArgs) Handles Next_Button.Click
        ClassInformationBindingSource.MoveNext()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

    End Sub

    Private Sub Save_Button_Click(sender As Object, e As EventArgs) Handles Save_Button.Click

    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim DevForm As DeveloperForm
        DevForm = New DeveloperForm()
        DevForm.Show()
        DevForm = Nothing
        Me.Close()
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MultiJurCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles MultiJurCheckbox.CheckedChanged

    End Sub

End Class