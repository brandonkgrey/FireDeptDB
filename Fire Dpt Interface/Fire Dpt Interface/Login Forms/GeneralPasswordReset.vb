Imports System.Text
Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Net.Mail


Public Class GeneralPasswordReset

    Dim Dbstring As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + "C:\Users\Brandon\Desktop\Fire Department Project\ExampleDB.accdb"
    Public Shared tempPass As String
    Public Shared tempUsername As String

    Private Sub CancelButtonGPR_Click(sender As Object, e As EventArgs) Handles CancelButtonGPR.Click
        Dim loginMenu As Login
        loginMenu = New Login()


        loginMenu.Show()
        loginMenu = Nothing

        Me.Close()
    End Sub

    Private Sub SubmitButtonGPR_Click(sender As Object, e As EventArgs) Handles SubmitButtonGPR.Click
        Dim inputUsername As String = UsernameGPR.Text
        tempUsername = inputUsername

        'Set up a connection to the access database
        Dim Dbconn As New OleDbConnection(Dbstring)
        Dbconn.Open()

        Dim command As New OleDbCommand("SELECT [username] FROM [Employee Information] WHERE [Username] ='" + inputUsername + "'", Dbconn)
        Dim authobj As Object = command.ExecuteScalar()

        If authobj = Nothing Then
            invalidUsernameGPR.show()

        Else
            Dim email As String = "x"
            InvalidUsernameGPR.Visible = False

            'get email connected to username'
            command = New OleDbCommand("SELECT [Email] FROM [Employee Information] WHERE [Username] ='" + inputUsername + "'", Dbconn)
            authobj = command.ExecuteScalar()
            email = authobj.ToString()
            'MsgBox(email.ToString())

            Try
                'establishing email server to send messages through
                Dim Smtp_Server As New SmtpClient
                Dim e_mail As New MailMessage()
                Smtp_Server.UseDefaultCredentials = False
                Smtp_Server.Credentials = New Net.NetworkCredential("dbcsce483@gmail.com", "abacsce483")
                Smtp_Server.Port = 587
                Smtp_Server.EnableSsl = True
                Smtp_Server.Host = "smtp.gmail.com"

                'the random number to be used to reset the password
                Dim startDate As New DateTime(1970, 1, 1)
                Dim currentDate As DateTime = DateTime.Now()
                Dim numOfSeconds = (currentDate - startDate).TotalSeconds
                tempPass = CStr(numOfSeconds)

                'sends the email containing the temporary password
                e_mail = New MailMessage()
                e_mail.From = New MailAddress("dbcsce483@gmail.com")
                e_mail.To.Add(email.ToString())
                e_mail.Subject = "Password Reset"
                e_mail.IsBodyHtml = False
                e_mail.Body = "Use the temporary password '" + tempPass + "' to change your password."
                Smtp_Server.Send(e_mail)
                'MsgBox("Mail Sent")

            Catch error_t As Exception
                MsgBox(error_t.ToString)
            End Try

            MsgBox("A temporary password has been sent to the email associated with your account.", MsgBoxStyle.Information, "Success")

            'load next form in password reset procedure
            Dim ResetPassword As GeneralPasswordResetPart2 = New GeneralPasswordResetPart2()
            ResetPassword.Show()
            ResetPassword = Nothing

            Me.Close()

        End If

    End Sub

    Private Sub UsernameGPR_TextChanged(sender As Object, e As EventArgs) Handles UsernameGPR.TextChanged
        InvalidUsernameGPR.Hide()
    End Sub
End Class