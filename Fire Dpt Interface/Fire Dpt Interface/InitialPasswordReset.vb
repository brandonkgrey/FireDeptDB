Imports System.Text
Imports System.Data.OleDb
Imports System.Security.Cryptography


Public Class InitialPasswordReset

    Dim Dbstring As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + "C:\Users\Brandon\Desktop\Fire Department Project\ExampleDB.accdb"
       

    Public Function getHash(ByVal number As String) As String
        Dim ASCIIENC As New ASCIIEncoding
        Dim str_return As String
        str_return = vbNullString

        Dim bytesourcetext() As Byte = ASCIIENC.GetBytes(number)
        Dim SHA1Hash As New SHA1CryptoServiceProvider
        Dim bytehash() As Byte = SHA1Hash.ComputeHash(bytesourcetext)

        For Each b As Byte In bytehash
            str_return &= b.ToString("x2")
        Next
        Return str_return
    End Function


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles NewPassword.TextChanged

        If NewPassword.Text.Length < 1 Then
            ValidLable.Hide()
        End If

        If NewPassword.Text.Length > 5 Then
            ValidLable.Text = "Valid Password"
            ValidLable.ForeColor = Color.Green
        End If

        If NewPassword.Text.Length < 6 And NewPassword.Text.Length > 1 Then
            ValidLable.Show()
            ValidLable.Text = "Invalid Password"
            ValidLable.ForeColor = Color.Red
        End If

    End Sub

    Private Sub CancelButtonIPR_Click(sender As Object, e As EventArgs) Handles CancelButtonIPR.Click
        Dim loginMenu As Login
        loginMenu = New Login()


        loginMenu.Show()
        loginMenu = Nothing

        Me.Close()
    End Sub

    Private Sub SubmitButtonIPR_Click(sender As Object, e As EventArgs) Handles SubmitButtonIPR.Click
        'Checks for unmatching passwords
        If NewPassword.Text <> ConfirmPassword.Text Then
            MsgBox("Passwords Don't Match. Please input identical passwords.", MsgBoxStyle.Critical, "Error")

            'Checks for password length
        ElseIf NewPassword.Text.Length < 6 Then
            MsgBox("Password is not long enough. Please input a new password with at least 6 characters.", MsgBoxStyle.Critical, "Error")

            'Successful Password Change
        Else
            'Set up a connection to the access database
            Dim Dbconn As New OleDbConnection(Dbstring)
            Dbconn.Open()

            'Check to see if there is a connection to the database, exit app if there is none 
            Try
                If Dbconn.State = ConnectionState.Closed Then
                    MsgBox("Failed to connect to the database!", MsgBoxStyle.Critical, "Error")
                    System.Threading.Thread.Sleep(500)
                    Application.Exit()
                End If
            Catch ex As Exception
            End Try

            Dim loginMenu As Login
            loginMenu = New Login()

            Dim newPass As String = NewPassword.Text
            Dim newPassHash As String = getHash(newPass)

            Dim username As String
            username = "Brandon"


            Dim Command As New OleDbCommand("UPDATE [Employee Information] SET [Password] ='" + newPassHash + "'" + "WHERE [Username]='" + username + "'", Dbconn)
            Command.ExecuteScalar()

            MsgBox("Password has been changed! Please login with new password.", MsgBoxStyle.Information, "Password Update Success")

            loginMenu.Show()
            loginMenu = Nothing

            Me.Close()

        End If


    End Sub
End Class