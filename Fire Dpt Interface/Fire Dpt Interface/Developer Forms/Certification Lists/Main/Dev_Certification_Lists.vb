Imports System.Data.OleDb

Public Class Dev_Certification_Lists
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim DevForm As DeveloperForm
        DevForm = New DeveloperForm()
        DevForm.Show()
        DevForm = Nothing
        Me.Close()
    End Sub

    Private Sub EMS_Cert_Report_Button_Click(sender As Object, e As EventArgs) Handles EMS_Cert_Report_Button.Click
        Dim EMSReport As EMS_All_Certifications_View
        EMSReport = New EMS_All_Certifications_View()
        EMSReport.Show()
        EMSReport = Nothing
        Me.Close()
    End Sub

    Private Sub EMTB_Cert_Report_Button_Click(sender As Object, e As EventArgs) Handles EMTB_Cert_Report_Button.Click
        Dim EMTBReport As EMTB_Report_View
        EMTBReport = New EMTB_Report_View()
        EMTBReport.Show()
        EMTBReport = Nothing
        Me.Close()
    End Sub

    Private Sub EMTI_Cert_Report_Button_Click(sender As Object, e As EventArgs) Handles EMTI_Cert_Report_Button.Click
        Dim EMTIReport As EMTI_Report_View
        EMTIReport = New EMTI_Report_View()
        EMTIReport.Show()
        EMTIReport = Nothing
        Me.Close()
    End Sub

    Private Sub Paramed_Cert_Report_Button_Click(sender As Object, e As EventArgs) Handles Paramed_Cert_Report_Button.Click
        Dim ParaReport As EMS_Paramedic_Certificates_Report_View
        ParaReport = New EMS_Paramedic_Certificates_Report_View()
        ParaReport.Show()
        ParaReport = Nothing
        Me.Close()
    End Sub

    Private Sub TCFP_Wild_Report_Button_Click(sender As Object, e As EventArgs) Handles TCFP_Wild_Report_Button.Click
        Dim WildReport As TCFP_Wildlife_Certifications_View
        WildReport = New TCFP_Wildlife_Certifications_View()
        WildReport.Show()
        WildReport = Nothing
        Me.Close()
    End Sub

    Private Sub TCFP_Ins_List_Report_Button_Click(sender As Object, e As EventArgs) Handles TCFP_Ins_List_Report_Button.Click
        Dim InsReport As TCFP_Instructor_Certifications_Report_View
        InsReport = New TCFP_Instructor_Certifications_Report_View()
        InsReport.Show()
        InsReport = Nothing
        Me.Close()
    End Sub

    Private Sub TCFP_Haz_IC_List_Report_Button_Click(sender As Object, e As EventArgs) Handles TCFP_Haz_IC_List_Report_Button.Click
        Dim HMICReport As TCFP_HMIC_Certifications_Report_View
        HMICReport = New TCFP_HMIC_Certifications_Report_View()
        HMICReport.Show()
        HMICReport = Nothing
        Me.Close()
    End Sub

    Private Sub TCFP_Haz_Tec_Report_Button_Click(sender As Object, e As EventArgs) Handles TCFP_Haz_Tec_Report_Button.Click
        Dim TechReport As TCFP_HMTech_Certifications_Report_View
        TechReport = New TCFP_HMTech_Certifications_Report_View()
        TechReport.Show()
        TechReport = Nothing
        Me.Close()
    End Sub
End Class