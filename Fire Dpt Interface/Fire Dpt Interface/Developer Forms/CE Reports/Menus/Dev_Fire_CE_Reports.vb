Imports System.Data.OleDb

Public Class Dev_Fire_CE_Reports

    Friend Shared emp_id As Integer
    Friend Shared start_date As String
    Friend Shared end_date As String
    Friend Shared employeeName As String
    Friend Shared TCFP As String
    Dim Dbstring As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + "C:\Users\Alejandro\Desktop\Fire Department DB\new\Training Records for TAMU.accdb;Jet OLEDB:Database Password=fdtrain;"

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim DevForm As Developer_CE_Reports
        DevForm = New Developer_CE_Reports()
        DevForm.Show()
        DevForm = Nothing
        Me.Close()
    End Sub


    Private Sub FireCE_Report_Button_Click(sender As Object, e As EventArgs) Handles FireCE_Report_Button.Click
        employeeName = SelectEmp_ComboBox.Text

        Dim Dbconn As New OleDbConnection(Dbstring)
        Dbconn.Open()

        Dim command As New OleDbCommand("SELECT [Employee_ID] FROM [Employee Information] WHERE [Name] ='" + employeeName + "'", Dbconn)
        Dim obj As Object = command.ExecuteScalar()
        emp_id = obj.ToString

        Dim command2 As New OleDbCommand("SELECT [TCFP PIN] FROM [Employee Information] WHERE [Name] ='" + employeeName + "'", Dbconn)
        Dim obj2 As Object = command2.ExecuteScalar()
        TCFP = obj2.ToString

        start_date = FireCE_SDateTimePicker.Value.ToShortDateString
        end_date = FireCE_EDateTimePicker.Value.ToShortDateString
        Dim repview As New CE_Fire_Report_View()
        repview.Show()
        repview = Nothing
        Me.Close()
    End Sub

    Private Sub Dev_Fire_CE_Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Training_Records_for_TAMUDataSet.Employee_Information' table. You can move, or remove it, as needed.
        Me.Employee_InformationTableAdapter.Fill(Me.Training_Records_for_TAMUDataSet.Employee_Information)

        EmployeeInformationBindingSource.Sort = "Name"

    End Sub
End Class