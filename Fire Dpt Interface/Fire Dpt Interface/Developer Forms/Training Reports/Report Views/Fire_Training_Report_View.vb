Public Class Fire_Training_Report_View

    Private Sub Fire_Training_Report_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Fire_Training_Report_Dataset.Query_Fire_Training_Report' table. You can move, or remove it, as needed.
        Me.Query_Fire_Training_ReportTableAdapter.Fill(Me.Fire_Training_Report_Dataset.Query_Fire_Training_Report, "1/1/2014", "1/1/2015")
        Me.Fire_ReportViewer.RefreshReport()
    End Sub

    Private Sub Safety_Training_Report_View_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim Fire_Form As New Dev_Safety_Training_Reports()
        Fire_Form.Show()
        Fire_Form = Nothing
        'Do not do me.close!!! (It will cause this function to enter an infinite loop)
    End Sub
End Class