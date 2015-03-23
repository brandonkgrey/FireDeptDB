Imports System.Text
Imports System.Data.OleDb
Imports System.Security.Cryptography


Public Class InitialPasswordReset



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles NewPassword.TextChanged
        If NewPassword.Text.Length > 5 Then
            ValidLable.Text = "Valid Password"
            ValidLable.ForeColor = Color.Green
        End If

        If NewPassword.Text.Length < 6 Then
            ValidLable.Text = "Invalid Password"
            ValidLable.ForeColor = Color.Red
        End If

    End Sub
End Class