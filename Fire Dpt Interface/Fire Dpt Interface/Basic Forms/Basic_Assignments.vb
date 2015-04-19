Public Class Basic_Assignments

    Dim username

    Private Sub Certificates_Click(sender As Object, e As EventArgs) Handles Certificates.Click

        Dim BasicMenu As BasicForm = New BasicForm()
        BasicMenu.Show()
        BasicMenu = Nothing
        Me.Close()

    End Sub

    Private Sub Basic_Assignments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Training_Records_EncryptedDataSet.Assignment_Pay' table. You can move, or remove it, as needed.
        'Me.Assignment_PayTableAdapter.Fill(Me.Training_Records_EncryptedDataSet.Assignment_Pay)

        username = Login.sharedUsername
        BasicForm.Text = "Welcome " + username

    End Sub
End Class