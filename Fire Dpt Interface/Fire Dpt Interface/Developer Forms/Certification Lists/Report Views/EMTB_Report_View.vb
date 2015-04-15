Imports Microsoft.Reporting.WinForms

Public Class EMTB_Report_View

    Private Sub EMTB_Report_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EMTB_Certifications_Dataset.Query_EMTB_Certifications' table. You can move, or remove it, as needed.
        Me.Query_EMTB_CertificationsTableAdapter.Fill(Me.EMTB_Certifications_Dataset.Query_EMTB_Certifications)

        Dim timeparam As ReportParameter
        Dim todays_date As Date = Date.Now()
        Dim timestamp As String = todays_date.ToString("MM\/dd\/yyyy")
        timeparam = New ReportParameter("TimeStamp", timestamp)

        Me.EMTB_ReportViewer.LocalReport.SetParameters(timeparam)
        Me.EMTB_ReportViewer.RefreshReport()
        Me.EMTB_ReportViewer.RefreshReport()
    End Sub

    Private Sub EMTB_Report_View_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

        Dim CertsForm As Dev_Certification_Lists
        CertsForm = New Dev_Certification_Lists()
        CertsForm.Show()
        CertsForm = Nothing
        'Do not do me.close!!! (It will cause this function to enter an infinite loop)
    End Sub
End Class