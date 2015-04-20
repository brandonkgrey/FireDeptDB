Public Class SupervisorEmployeeInformation

    Private Sub SupervisorEmployeeInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SupervisorFilterDataSet.Employee_Information' table. You can move, or remove it, as needed.
        Me.Employee_InformationTableAdapter.Fill(Me.SupervisorFilterDataSet.Employee_Information)

    End Sub
End Class