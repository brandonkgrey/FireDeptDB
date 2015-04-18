Public Class Class_Information_Report_View

    Private Sub Class_Information_Report_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClassInformation_Dataset.Query_ClassInfo_ReportDataTable' table. You can move, or remove it, as needed.
        ''needs dynamic class number
        Me.Query_ClassInfo_ReportTableAdapter.Fill(Me.ClassInformation_Dataset.Query_ClassInfo_ReportDataTable, "01062006S2A")
        Me.Class_Info_ReportViewer.RefreshReport()
    End Sub
End Class