﻿Public Class TCFP_Instructor_Certifications_Report_View

    Private Sub TCFP_Instructor_Certifications_Report_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TCFP_Instructor_Certifications_Dataset.Query_Instructor_Certifications' table. You can move, or remove it, as needed.
        Me.Query_Instructor_CertificationsTableAdapter.Fill(Me.TCFP_Instructor_Certifications_Dataset.Query_Instructor_Certifications)

        Me.TCFP_Instructor_ReportViewer.RefreshReport()
    End Sub

    Private Sub TCFP_Instructor_Certifications_Report_View_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

        Dim CertsForm As Dev_Certification_Lists
        CertsForm = New Dev_Certification_Lists()
        CertsForm.Show()
        CertsForm = Nothing
        'Do not do me.close!!! (It will cause this function to enter an infinite loop)
    End Sub

End Class