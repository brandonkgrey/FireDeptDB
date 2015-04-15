Public Class Single_User_Information


    Private Sub Single_User_Information_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Training_RecordsDataSet.Employee_Information' table. You can move, or remove it, as needed.
        Me.Employee_InformationTableAdapter.Fill(Me.Training_RecordsDataSet.Employee_Information)

    End Sub

    
    Private Sub Emp_Name_Click(sender As Object, e As EventArgs) Handles Emp_Name.Click

    End Sub

    Private Sub Emp_ID_Click(sender As Object, e As EventArgs) Handles Emp_ID.Click

    End Sub

    
    Private Sub MainMenuButton_Click(sender As Object, e As EventArgs) Handles MainMenuButton.Click
        Dim BasicMenu As BasicForm
        BasicMenu = New BasicForm()
        BasicMenu.Show()
        BasicMenu = Nothing
        Me.Close()
    End Sub
End Class