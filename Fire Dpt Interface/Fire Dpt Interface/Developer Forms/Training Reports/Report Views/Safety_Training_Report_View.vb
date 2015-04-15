Public Class Safety_Training_Report_View

    Private Sub Safety_Training_Report_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Training_Reports_Safety_Dataset.Query_Training_Report_Safety' table. You can move, or remove it, as needed.
        'need to place shared variables inside of this paramater !!!!!!!!!!!!!!!!!!!!!!

        Me.Query_Training_Report_SafetyTableAdapter.Fill(Me.Training_Reports_Safety_Dataset.Query_Training_Report_Safety, "01/01/2014", "01/01/2015")
        Me.TR_Safety_ReportViewer.RefreshReport()
    End Sub

    Private Sub Safety_Training_Report_View_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

        Dim Safety_Form As Dev_Safety_Training_Reports
        Safety_Form = New Dev_Safety_Training_Reports()
        Safety_Form.Show()
        Safety_Form = Nothing
        'Do not do me.close!!! (It will cause this function to enter an infinite loop)
    End Sub
End Class