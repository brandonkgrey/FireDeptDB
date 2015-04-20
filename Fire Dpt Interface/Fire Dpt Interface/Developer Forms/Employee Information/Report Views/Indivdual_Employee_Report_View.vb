Imports Microsoft.Office.Interop.Access
Imports Microsoft.Reporting.WinForms



Public Class Indivdual_Employee_Report_View

    Private Sub Indivdual_Employee_Report_View(sender As Object, e As EventArgs) Handles MyBase.Load
        'temp value needs to be SSN or ID of the user (pass through global variable)
        Dim ID As Integer = All_Employees.currentID
        Me.QueryEmployeeInformationTableAdapter.FillEmployeeName(Me.Query_Indivual_Employee.QueryEmployeeInformation, ID)
        Me.Emp_InfoReportViewer.RefreshReport()
    End Sub

    Private Sub Indivdual_Employee_Report_View_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim EmpView As New All_Employees()
        EmpView.Show()
        EmpView = Nothing
        'Do not do me.close!!! (It will cause this function to enter an infinite loop)
    End Sub

End Class