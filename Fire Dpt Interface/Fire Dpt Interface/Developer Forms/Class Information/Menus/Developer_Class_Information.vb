Public Class Developer_Class_Information

    Friend Shared class_number As String
    Dim AuthLvl
    Dim start_time As String
    Dim end_time As String
    Dim strTime As DateTime
    Dim endTime As DateTime


    Private Sub Prev_Button_Click(sender As Object, e As EventArgs) Handles Prev_Button.Click
        ClassInformationBindingSource.MovePrevious()
        start_time = TextBox18.Text
        end_time = TextBox19.Text
        strTime = DateTime.Parse(start_time)
        endTime = DateTime.Parse(end_time)
        TextBox18.Text = TimeValue(strTime)
        TextBox19.Text = TimeValue(endTime)
    End Sub

    Private Sub Next_Button_Click(sender As Object, e As EventArgs) Handles Next_Button.Click
        ClassInformationBindingSource.MoveNext()
        start_time = TextBox18.Text
        end_time = TextBox19.Text
        strTime = DateTime.Parse(start_time)
        endTime = DateTime.Parse(end_time)
        TextBox18.Text = TimeValue(strTime)
        TextBox19.Text = TimeValue(endTime)
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

    End Sub

    Private Sub Save_Button_Click(sender As Object, e As EventArgs) Handles Save_Button.Click

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        If (AuthLVL = 4) Then
            Dim DevForm As DeveloperForm
            DevForm = New DeveloperForm()
            DevForm.Show()
            DevForm = Nothing
            Me.Close()
        ElseIf (AuthLvl = 3) Then
            Dim Adminform As New AdministratorForm
            Adminform.show()
            Adminform = Nothing
            Me.Close()
        ElseIf (AuthLvl = 2) Then
            Dim SupForm As New SupervisorForm
            SupForm.Show()
            SupForm = Nothing
            Me.Close()
        End If

    End Sub

    Private Sub ReportButton_Click(sender As Object, e As EventArgs) Handles ReportButton.Click
        class_number = Class_Number_Textbox.Text
        Dim repview As New Class_Information_Report_View()
        repview.Show()
        repview = Nothing
        Me.Close()
    End Sub

    Private Sub Developer_Class_Information_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Training_Records_for_TAMUDataSet.Class_Attendance_Information' table. You can move, or remove it, as needed.
        Me.Class_Attendance_InformationTableAdapter.FillBy(Me.Training_Records_for_TAMUDataSet.Class_Attendance_Information, Class_Number_Textbox.Text)
        'TODO: This line of code loads data into the 'Training_Records_for_TAMUDataSet.Class_Information' table. You can move, or remove it, as needed.
        Me.Class_InformationTableAdapter.Fill(Me.Training_Records_for_TAMUDataSet.Class_Information)

        start_time = TextBox18.Text
        end_time = TextBox19.Text
        strTime = DateTime.Parse(start_time)
        endTime = DateTime.Parse(end_time)
        TextBox18.Text = TimeValue(strTime)
        TextBox19.Text = TimeValue(endTime)
        AuthLvl = Login.Authorization_LVL
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Class_Number_Textbox.TextChanged
        Me.Class_Attendance_InformationTableAdapter.FillBy(Me.Training_Records_for_TAMUDataSet.Class_Attendance_Information, Class_Number_Textbox.Text)
    End Sub
End Class