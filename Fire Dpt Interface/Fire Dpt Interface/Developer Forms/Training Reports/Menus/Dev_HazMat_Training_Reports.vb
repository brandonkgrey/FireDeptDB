
Public Class Dev_HazMat_Training_Reports

    Friend Shared firecredit_filter As Integer
    Friend Shared HazMat_StartDate As String
    Friend Shared HazMat_EndDate As String
    Friend Shared Nofilter As Integer
    Friend Shared emp_id As Integer

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim DevForm As Developer_Training_Reports
        DevForm = New Developer_Training_Reports()
        DevForm.Show()
        DevForm = Nothing
        Me.Close()
    End Sub

   

    Private Sub Safety_TR_Report_Button_Click(sender As Object, e As EventArgs) Handles Safety_TR_Report_Button.Click

        Dim HazMat_TR_Menu As HazMat_Training_Report_View

        If Fire_Credit_ComboBox.Text = "Yes" Then
            firecredit_filter = 1
        ElseIf Fire_Credit_ComboBox.Text = "No" Then
            firecredit_filter = 0
        Else
            MessageBox.Show("Default Case: Displaying Report With No Filter")
            Nofilter = 1
        End If

        HazMat_StartDate = HMTR_Start_DateTimePicker.Value.ToShortDateString
        HazMat_EndDate = HMTR_End_DateTimePicker.Value.ToShortDateString
        HazMat_TR_Menu = New HazMat_Training_Report_View()
        HazMat_TR_Menu.Show()
        HazMat_TR_Menu = Nothing
        Me.Close()

    End Sub
End Class