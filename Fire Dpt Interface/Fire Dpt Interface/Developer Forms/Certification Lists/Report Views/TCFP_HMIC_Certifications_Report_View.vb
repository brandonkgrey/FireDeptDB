Public Class TCFP_HMIC_Certifications_Report_View

    Private Sub TCFP_HMIC_Certifications_Report_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TCFP_HMIC_Certifications_Dataset.Query_TCFP_HMIC_Certifications' table. You can move, or remove it, as needed.
        Me.Query_TCFP_HMIC_CertificationsTableAdapter.Fill(Me.TCFP_HMIC_Certifications_Dataset.Query_TCFP_HMIC_Certifications)

        Me.TCFP_HMIC_ReportViewer.RefreshReport()
    End Sub

    Private Sub TCFP_HMIC_Certifications_Report_View_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

        Dim CertsForm As Dev_Certification_Lists
        CertsForm = New Dev_Certification_Lists()
        CertsForm.Show()
        CertsForm = Nothing
        'Do not do me.close!!! (It will cause this function to enter an infinite loop)
    End Sub
End Class