Public Class EMTI_Report_View

    Private Sub EMTI_Report_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EMTI_Certifications_Dataset.Query_EMTI_Cert' table. You can move, or remove it, as needed.
        Me.Query_EMTI_CertTableAdapter.Fill(Me.EMTI_Certifications_Dataset.Query_EMTI_Cert)
        Me.EMTI_ReportViewer.RefreshReport()
    End Sub

    Private Sub EMTI_Report_View_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

        Dim CertsForm As Dev_Certification_Lists
        CertsForm = New Dev_Certification_Lists()
        CertsForm.Show()
        CertsForm = Nothing
        'Do not do me.close!!! (It will cause this function to enter an infinite loop)
    End Sub
End Class