Imports System.Data.OleDb


Public Class Dev_ARFF_CE_Report

    Friend Shared emp_id As Integer
    Friend Shared startdate As String
    Friend Shared enddate As String
    Friend Shared employeeName As String
    Dim Dbstring As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + "C:\Users\Alejandro\Desktop\Fire Department DB\new\Training Records for TAMU.accdb;Jet OLEDB:Database Password=fdtrain;"

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim DevForm As Developer_CE_Reports
        DevForm = New Developer_CE_Reports()
        DevForm.Show()
        DevForm = Nothing
        Me.Close()
    End Sub

    Private Sub ARFF_CE_Report_Button_Click(sender As Object, e As EventArgs) Handles ARFF_CE_Report_Button.Click
        employeeName = SelectEmp_ComboBox.Text
        'Set up a connection to the access database

        Dim Dbconn As New OleDbConnection(Dbstring)
        Dbconn.Open()

        Dim command As New OleDbCommand("SELECT [Employee_ID] FROM [Employee Information] WHERE [Name] ='" + employeeName + "'", Dbconn)
        Dim obj As Object = command.ExecuteScalar()
        emp_id = obj.ToString

        startdate = Start_Date_DateTimePicker.Value.ToShortDateString
        enddate = End_Date_DateTimePicker.Value.ToShortDateString
        Dim RepView As New CE_ARFF_Report_View()
        RepView.Show()
        RepView = Nothing
        Me.Close()
        'Send these var to new window to execute query 
    End Sub

    Private Sub Dev_ARFF_CE_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Training_Records_for_TAMUDataSet.Employee_Information' table. You can move, or remove it, as needed.
        Me.Employee_InformationTableAdapter.Fill(Me.Training_Records_for_TAMUDataSet.Employee_Information)

        EmployeeInformationBindingSource.Sort = "Name"

    End Sub
End Class