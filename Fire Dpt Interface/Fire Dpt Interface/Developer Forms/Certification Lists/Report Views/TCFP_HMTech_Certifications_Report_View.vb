Public Class TCFP_HMTech_Certifications_Report_View

    Private Sub TCFP_HMTech_Certifications_Report_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TCFP_HMTech_Certifications.Query_HMTech_Certifications' table. You can move, or remove it, as needed.
        Me.Query_HMTech_CertificationsTableAdapter.Fill(Me.TCFP_HMTech_Certifications.Query_HMTech_Certifications)

        Me.TCFP_HMTech_ReportViewer.RefreshReport()
    End Sub
    Private Sub TCFP_HMTech_Certifications_Report_View_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

        Dim CertsForm As Dev_Certification_Lists
        CertsForm = New Dev_Certification_Lists()
        CertsForm.Show()
        CertsForm = Nothing
        'Do not do me.close!!! (It will cause this function to enter an infinite loop)
    End Sub
End Class