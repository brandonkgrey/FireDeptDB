Public Class EMS_Training_Report_View

    Private Sub EMS_Training_Report_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EMS_Training_Report_Dataset.Query_EMS_Training_Report' table. You can move, or remove it, as needed.
        Me.Query_EMS_Training_ReportTableAdapter.Fill(Me.EMS_Training_Report_Dataset.Query_EMS_Training_Report, "01/01/2014", "01/01/2015")
        Me.EMS_Training_ReportViewer.RefreshReport()
    End Sub

    Private Sub EMS_Training_Report_View_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

        Dim EMS_Form As Dev_EMS_Training_Reports
        EMS_Form = New Dev_EMS_Training_Reports()
        EMS_Form.Show()
        EMS_Form = Nothing
        'Do not do me.close!!! (It will cause this function to enter an infinite loop)
    End Sub
End Class