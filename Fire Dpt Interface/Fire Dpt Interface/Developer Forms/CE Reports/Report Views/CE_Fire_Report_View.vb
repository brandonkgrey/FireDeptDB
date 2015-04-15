Public Class CE_Fire_Report_View

    Private Sub CE_Fire_Report_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CE_Fire_Dataset.Query_CE_Fire_Report' table. You can move, or remove it, as needed.
        Me.Query_CE_Fire_ReportTableAdapter.Fill(Me.CE_Fire_Dataset.Query_CE_Fire_Report, 103147821, "1/1/2014", "1/1/2015")

        Me.CE_Fire_ReportViewer.RefreshReport()
    End Sub
End Class