Public Class Developer_Class_Information

    Friend Shared class_number As Integer

    Private Sub Prev_Button_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Next_Button_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Save_Button_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs)
        Dim DevForm As DeveloperForm
        DevForm = New DeveloperForm()
        DevForm.Show()
        DevForm = Nothing
        Me.Close()
    End Sub

    Private Sub ReportButton_Click(sender As Object, e As EventArgs)

        ''class_number = classtextbox
        Dim repview As New Class_Information_Report_View()
        repview.Show()
        repview = Nothing
        Me.Close()
    End Sub

    Private Sub Developer_Class_Information_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Training_Records_for_TAMUDataSet.Class_Information' table. You can move, or remove it, as needed.
        Me.Class_InformationTableAdapter.Fill(Me.Training_Records_for_TAMUDataSet.Class_Information)

    End Sub
End Class