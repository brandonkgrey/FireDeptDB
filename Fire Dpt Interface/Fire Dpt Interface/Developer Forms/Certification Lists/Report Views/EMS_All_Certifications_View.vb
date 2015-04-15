Public Class EMS_All_Certifications_View

    Private Sub EMS_All_Certifications_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'All_EMS_Cert_Datasetxsd.Query_All_EMS_Cert' table. You can move, or remove it, as needed.
        Me.Query_All_EMS_CertTableAdapter.Fill(Me.All_EMS_Cert_Datasetxsd.Query_All_EMS_Cert)
        Me.All_Cert_ReportViewer.RefreshReport()
    End Sub

    Private Sub EMS_All_Certifications_View_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

        Dim CertsForm As Dev_Certification_Lists
        CertsForm = New Dev_Certification_Lists()
        CertsForm.Show()
        CertsForm = Nothing
        'Do not do me.close!!! (It will cause this function to enter an infinite loop)
    End Sub
End Class