Public Class Developer_CE_Reports

    Private Sub CEExitButton_Click(sender As Object, e As EventArgs) Handles CEExitButton.Click
        Dim DevForm As DeveloperForm
        DevForm = New DeveloperForm()
        DevForm.Show()
        DevForm = Nothing
        Me.Close()
    End Sub

    Private Sub Fire_CE_Report_Button_Click(sender As Object, e As EventArgs) Handles Fire_CE_Button.Click
        Dim FireCEMenu As Dev_Fire_CE_Reports
        FireCEMenu = New Dev_Fire_CE_Reports()
        FireCEMenu.Show()
        FireCEMenu = Nothing
        Me.Close()
    End Sub


    Private Sub TCFP_CE_Button_Click(sender As Object, e As EventArgs) Handles TCFP_CE_Button.Click
        Dim TCFP_CE_Menu As Dev_TCFP_CE_Report
        TCFP_CE_Menu = New Dev_TCFP_CE_Report()
        TCFP_CE_Menu.Show()
        TCFP_CE_Menu = Nothing
        Me.Close()
    End Sub


    Private Sub HazMat_Report_Button_Click(sender As Object, e As EventArgs) Handles HazMat_Report_Button.Click
        Dim HazMatCE_Menu As Dev_HazMat_CE_Report
        HazMatCE_Menu = New Dev_HazMat_CE_Report()
        HazMatCE_Menu.Show()
        HazMatCE_Menu = Nothing
        Me.Close()
    End Sub

    Private Sub ARFF_Report_Button_Click(sender As Object, e As EventArgs) Handles ARFF_Report_Button.Click
        Dim ARFF_CE_Menu As Dev_ARFF_CE_Report
        ARFF_CE_Menu = New Dev_ARFF_CE_Report()
        ARFF_CE_Menu.Show()
        ARFF_CE_Menu = Nothing
        Me.Close()
    End Sub

    Private Sub EMS_CE_Report_Button_Click(sender As Object, e As EventArgs) Handles EMS_CE_Report_Button.Click
        Dim EMS_CE_Menu As Dev_EMS_CE_Report
        EMS_CE_Menu = New Dev_EMS_CE_Report()
        EMS_CE_Menu.Show()
        EMS_CE_Menu = Nothing
        Me.Close()
    End Sub

    Private Sub Safety_CE_Button_Click(sender As Object, e As EventArgs) Handles Safety_CE_Button.Click
        Dim Safety_CE_Menu As Dev_Safety_CE_Report
        Safety_CE_Menu = New Dev_Safety_CE_Report()
        Safety_CE_Menu.Show()
        Safety_CE_Menu = Nothing
        Me.Close()
    End Sub
End Class