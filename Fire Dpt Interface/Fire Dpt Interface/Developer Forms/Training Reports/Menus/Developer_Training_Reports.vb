Public Class Developer_Training_Reports
   
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles TRExitButton.Click
        Dim DevForm As DeveloperForm
        DevForm = New DeveloperForm()
        DevForm.Show()
        DevForm = Nothing
        Me.Close()
    End Sub

    Private Sub Fire_TR_Button_Click(sender As Object, e As EventArgs) Handles Fire_TR_Button.Click
        Dim Fire_TR_Menu As Dev_Fire_Training_Reports
        Fire_TR_Menu = New Dev_Fire_Training_Reports()
        Fire_TR_Menu.Show()
        Fire_TR_Menu = Nothing
        Me.Close()
    End Sub

    Private Sub HazMat_AT_TR_Click(sender As Object, e As EventArgs) Handles HazMat_AT_TR.Click
        Dim HazMat_AT_Menu As Dev_HazMat_All_Techs_Training_Reports
        HazMat_AT_Menu = New Dev_HazMat_All_Techs_Training_Reports()
        HazMat_AT_Menu.Show()
        HazMat_AT_Menu = Nothing
        Me.Close()
    End Sub

    Private Sub HazMat_TR_Button_Click(sender As Object, e As EventArgs) Handles HazMat_TR_Button.Click
        Dim HazMat_TR_Menu As Dev_HazMat_Training_Reports
        HazMat_TR_Menu = New Dev_HazMat_Training_Reports()
        HazMat_TR_Menu.Show()
        HazMat_TR_Menu = Nothing
        Me.Close()
    End Sub

    Private Sub ARFF_TR_Button_Click(sender As Object, e As EventArgs) Handles ARFF_TR_Button.Click
        Dim ARFF_TR_Menu As Dev_ARFF_Training_Reports
        ARFF_TR_Menu = New Dev_ARFF_Training_Reports()
        ARFF_TR_Menu.Show()
        ARFF_TR_Menu = Nothing
        Me.Close()
    End Sub

    Private Sub ARFF_12_TR_Button_Click(sender As Object, e As EventArgs) Handles ARFF_12_TR_Button.Click
        Dim ARFF_12_TR_Menu As ARFF_12_Month_Training_Report_View
        ARFF_12_TR_Menu = New ARFF_12_Month_Training_Report_View()
        ARFF_12_TR_Menu.Show()
        ARFF_12_TR_Menu = Nothing
        Me.Close()
    End Sub

    Private Sub EMS_TR_Button_Click(sender As Object, e As EventArgs) Handles EMS_TR_Button.Click
        Dim EMS_TR_Menu As Dev_EMS_Training_Reports
        EMS_TR_Menu = New Dev_EMS_Training_Reports()
        EMS_TR_Menu.Show()
        EMS_TR_Menu = Nothing
        Me.Close()
    End Sub

    Private Sub Safety_TR_Button_Click(sender As Object, e As EventArgs) Handles Safety_TR_Button.Click
        Dim Safety_TR_Menu As Dev_Safety_Training_Reports
        Safety_TR_Menu = New Dev_Safety_Training_Reports()
        Safety_TR_Menu.Show()
        Safety_TR_Menu = Nothing
        Me.Close()
    End Sub

    Private Sub OtherCourses_TR_Button_Click(sender As Object, e As EventArgs) Handles OtherCourses_TR_Button.Click
        Dim OtherCourses_TR_Menu As Dev_Other_Courses_Training_Reports
        OtherCourses_TR_Menu = New Dev_Other_Courses_Training_Reports()
        OtherCourses_TR_Menu.Show()
        OtherCourses_TR_Menu = Nothing
        Me.Close()
    End Sub

    Private Sub ARFF_12_Preview_Button_Click(sender As Object, e As EventArgs) Handles ARFF_12_Preview_Button.Click

    End Sub
End Class