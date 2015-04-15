Public Class ARFF_Training_Report_View

    Private Sub ARFF_Training_Report_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ARFF_Training_Report_Dataset.Query_ARFF_Training_Report' table. You can move, or remove it, as needed.
        Me.Query_ARFF_Training_ReportTableAdapter.Fill(Me.ARFF_Training_Report_Dataset.Query_ARFF_Training_Report, "1/1/2014", "1/1/2015")
        Me.ARFF_ReportViewer.RefreshReport()
    End Sub

    Private Sub ARFF_Training_Report_View_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

        Dim ARFF_Form As Dev_ARFF_Training_Reports
        ARFF_Form = New Dev_ARFF_Training_Reports()
        ARFF_Form.Show()
        ARFF_Form = Nothing
        'Do not do me.close!!! (It will cause this function to enter an infinite loop)
    End Sub
End Class