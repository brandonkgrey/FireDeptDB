Public Class CE_EMS_Report_View

    Private Sub CE_EMS_Report_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CE_EMS_Dataset.Query_EMS_CE_Report' table. You can move, or remove it, as needed.
        Me.Query_EMS_CE_ReportTableAdapter.Fill(Me.CE_EMS_Dataset.Query_EMS_CE_Report, 111195971, "1/1/2014", "1/1/2015")

        Me.EMS_CE_ReportViewer.RefreshReport()
    End Sub
End Class