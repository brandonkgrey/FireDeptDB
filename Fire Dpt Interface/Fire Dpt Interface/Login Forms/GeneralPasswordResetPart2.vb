Imports System.Text
Imports System.Data.OleDb
Imports System.Security.Cryptography

Public Class GeneralPasswordResetPart2

    Dim Dbstring As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + "C:\Users\Alejandro\Desktop\Fire Department DB\new\Training Records for TAMU.accdb;Jet OLEDB:Database Password=fdtrain;"
    Dim tempPassAttemptsCount As Integer = 0

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

    Private Sub CancelButtonGPR2_Click(sender As Object, e As EventArgs) Handles CancelButtonGPR2.Click
        Dim loginMenu As Login
        loginMenu = New Login()


        loginMenu.Show()
        loginMenu = Nothing

        Me.Close()
    End Sub



    Private Sub SubmitButtonGPR2_Click(sender As Object, e As EventArgs) Handles OKButtonGPR2.Click

        If TempPassGPR2.Text <> GeneralPasswordReset.tempPass Then
            'count the number of times they attempt to try to guess the temporary password
            tempPassAttemptsCount += 1

            'If they attempt to input the temporary password too many times it kicks them out and they have to start over with a new password
            If tempPassAttemptsCount > 2 Then
                MsgBox("Mistyped temporary password too many times. Please request a new temporary password.", MsgBoxStyle.Critical, "Error")

                Dim loginMenu As Login
                loginMenu = New Login()
                loginMenu.Show()
                loginMenu = Nothing
                Me.Close()

            Else
                MsgBox("The temporary password is incorrect. Please make sure you copied it correctly.", MsgBoxStyle.Critical, "Error")
            End If

            'Checks for unidentical password input
        ElseIf PasswordBox1GPR2.Text <> PasswordBox2GPR2.Text Then
            MsgBox("Passwords Don't Match. Please input identical passwords.", MsgBoxStyle.Critical, "Error")

            'Checks for password length
        ElseIf PasswordBox2GPR2.Text.Length < 6 Then
            MsgBox("Password is not long enough. Please input a new password with at least 6 characters.", MsgBoxStyle.Critical, "Error")


            'Successful Password Change

        ElseIf PasswordBox1GPR2.Text = GeneralPasswordReset.tempUsername Then
            MsgBox("Password cannot be the same as the username.", MsgBoxStyle.Critical, "Error")
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

            'start new login
            Dim loginMenu As Login
            loginMenu = New Login()

            'grab and hash inputted password
            Dim newPass As String = PasswordBox1GPR2.Text
            Dim newPassHash As String = getHash(newPass)

            'update the password in database with inputted password after a hash
            Dim Command As New OleDbCommand("UPDATE [Employee Information] SET [Password] ='" + newPassHash + "'" + "WHERE [Employee_ID]=" + GeneralPasswordReset.tempUsername, Dbconn)
            Command.ExecuteScalar()

            MsgBox("Password has been changed! Please login with new password.", MsgBoxStyle.Information, "Password Update Success")

            'diplay login
            loginMenu.Show()
            loginMenu = Nothing

            Me.Close()
        End If
    End Sub

    Private Sub PasswordBox1GPR2_TextChanged(sender As Object, e As EventArgs) Handles PasswordBox1GPR2.TextChanged
        If PasswordBox1GPR2.Text.Length < 1 Then
            ValidLableGPR2.Hide()
        End If

        If PasswordBox1GPR2.Text.Length > 5 Then
            ValidLableGPR2.Text = "Valid Password"
            ValidLableGPR2.ForeColor = Color.Green
        End If

        If PasswordBox1GPR2.Text.Length < 6 And PasswordBox1GPR2.Text.Length > 1 Then
            ValidLableGPR2.Show()
            ValidLableGPR2.Text = "Invalid Password"
            ValidLableGPR2.ForeColor = Color.Red
        End If
    End Sub
End Class