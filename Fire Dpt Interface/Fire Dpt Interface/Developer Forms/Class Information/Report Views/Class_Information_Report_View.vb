Public Class Class_Information_Report_View

    Private Sub Class_Information_Report_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClassInformation_Dataset.Query_ClassInfo_ReportDataTable' table. You can move, or remove it, as needed.
        ''needs dynamic class number
        Me.Query_ClassInfo_ReportTableAdapter.Fill(Me.ClassInformation_Dataset.Query_ClassInfo_ReportDataTable, "01062006S2A")
        Me.Class_Info_ReportViewer.RefreshReport()
    End Sub

    Private Sub ClassInformation_Report_View_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

        Dim ClassInfo As Developer_Class_Information
        ClassInfo = New Developer_Class_Information()
        ClassInfo.Show()
        ClassInfo = Nothing
        'Do not do me.close!!! (It will cause this function to enter an infinite loop)
    End Sub

End Class