Public Class EMS_Paramedic_Certificates_Report_View

    Private Sub EMT_Paramedic_Certificates_Report_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EMS_Paramedic_Certifications_Dataset.Query_EMS_Paramedic_Certifications' table. You can move, or remove it, as needed.
        Me.Query_EMS_Paramedic_CertificationsTableAdapter.Fill(Me.EMS_Paramedic_Certifications_Dataset.Query_EMS_Paramedic_Certifications)

        Me.Paramedic_ReportViewer.RefreshReport()
    End Sub

    Private Sub EMT_Paramedic_Certificates_Report_View_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

        Dim CertsForm As Dev_Certification_Lists
        CertsForm = New Dev_Certification_Lists()
        CertsForm.Show()
        CertsForm = Nothing
        'Do not do me.close!!! (It will cause this function to enter an infinite loop)
    End Sub
End Class