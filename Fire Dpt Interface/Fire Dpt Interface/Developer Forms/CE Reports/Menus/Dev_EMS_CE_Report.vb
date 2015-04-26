Imports System.Data.OleDb

Public Class Dev_EMS_CE_Report

    Friend Shared emp_id As Integer
    Friend Shared start_date As String
    Friend Shared end_date As String
    Friend Shared employeeName As String
    Friend Shared TDH_ID As String
    Dim Dbstring As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + "C:\Users\Alejandro\Desktop\Fire Department DB\new\Training Records for TAMU.accdb;Jet OLEDB:Database Password=fdtrain;"

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim DevForm As Developer_CE_Reports
        DevForm = New Developer_CE_Reports()
        DevForm.Show()
        DevForm = Nothing
        Me.Close()
    End Sub

    Private Sub EMS_CE_Report_Button_Click(sender As Object, e As EventArgs) Handles EMS_CE_Report_Button.Click
        employeeName = SelectEmp_ComboBox.Text
        'Set up a connection to the access database

        Dim Dbconn As New OleDbConnection(Dbstring)
        Dbconn.Open()

        Dim command As New OleDbCommand("SELECT [Employee_ID] FROM [Employee Information] WHERE [Name] ='" + employeeName + "'", Dbconn)
        Dim obj As Object = command.ExecuteScalar()
        emp_id = obj.ToString

        Dim command2 As New OleDbCommand("SELECT [TDH ID] FROM [Employee Information] WHERE [Name] ='" + employeeName + "'", Dbconn)
        Dim obj2 As Object = command2.ExecuteScalar()
        TDH_ID = obj2.ToString

        start_date = EMS_CE_SDateTimePicker.Value.ToShortDateString()
        end_date = EMS_CE_EDateTimePicker.Value.ToShortDateString()
        Dim RepView As New CE_EMS_Report_View()
        RepView.Show()
        RepView = Nothing
        Me.Close()
    End Sub


    Private Sub Dev_EMS_CE_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Training_Records_for_TAMUDataSet.Employee_Information' table. You can move, or remove it, as needed.
        Me.Employee_InformationTableAdapter.Fill(Me.Training_Records_for_TAMUDataSet.Employee_Information)

        EmployeeInformationBindingSource.Sort = "Name"
    End Sub
End Class