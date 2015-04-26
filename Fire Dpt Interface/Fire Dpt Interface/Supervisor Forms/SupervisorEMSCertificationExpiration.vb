Public Class SupervisorEMSCertificationExpiration

    Private Sub SupervisorEMSCertificationExpiration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SupervisorEMS_Instruct_X_Dataset.SupervisorEMS_InstructX' table. You can move, or remove it, as needed.
        Me.SupervisorEMS_InstructXTableAdapter.Fill(Me.SupervisorEMS_Instruct_X_Dataset.SupervisorEMS_InstructX)
        'TODO: This line of code loads data into the 'SupervisorEMSXDataset.SupervisorEMSX_Filter' table. You can move, or remove it, as needed.
        Me.SupervisorEMSX_FilterTableAdapter.Fill(Me.SupervisorEMSXDataset.SupervisorEMSX_Filter)

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim SupMenu As SupervisorForm = New SupervisorForm()
        SupMenu.Show()
        SupMenu = Nothing
        Me.Close()
    End Sub
End Class