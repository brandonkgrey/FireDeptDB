Imports System.Text
Imports System.Data.OleDb
Imports System.Security.Cryptography

Public Class Login
    'Provider=Microsoft.ACE.OLEDB.12.0;Data Source="C:\Users\Alejandro\Desktop\Fire Department DB\Backup\Training Records.accdb"
    'Dim Dbstring As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + "C:\Users\Alejandro\Desktop\Fire Department DB\Backup\Training Records.accdb"
    Dim Dbstring As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + "C:\Users\Alejandro\Desktop\Fire Department DB\ExampleDb.accdb"
    Public Shared sharedUsername As String
    Friend Shared Authorization_LVL As Integer

    'check if the password in the database is/isnt hashed already (in hex)
    Public Function IsHex(password As String) As Boolean
        Dim I As Long = 0
        Dim J As Long = 0
        Dim hex As Boolean = False

        If Len(password) = 0 Then
            Return hex
        End If
        I = 1
        J = Len(password)
        Do Until I > J
            If Not (Mid$(password, I, 1) Like "[0-9a-hA-H]") Then
                Return hex
            End If
            I = I + 1
        Loop
        hex = True
        Return hex
    End Function

    'The SHA1 encryption function 
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

    Public Function checkFirst(ByVal username As String) As String
        'Value to be returned
        Dim check As Boolean = False

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

        'Get user's password
        Dim command As New OleDbCommand("SELECT [Password] FROM [Employee Information] WHERE [Username] ='" + username + "'", Dbconn)
        Dim currPass As Object = command.ExecuteScalar()

        Dim usernameHash As String = getHash(username)

        If currPass = usernameHash Then
            check = True
        End If

        Return check
    End Function

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        'retrieve the input from the username and password text box 
        Dim username As String = UsernameTextBox.Text
        Dim password As String = PasswordTextBox.Text
        Dim hashedPass As String = getHash(password)
        Dim accessobj As Object = ""
        Dim accesslvl As String = "x"

        'Flags for login in procedure 
        Dim successLogin As Integer = 0
        Dim verifyHex As Boolean = False

        'menu for developers
        Dim DevMenu As DeveloperForm
        DevMenu = New DeveloperForm()

        'share the username with other forms
        sharedUsername = username

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

        'Check whether you can access the username and password entered
        Try
            Dim authUser As String = "x"
            Dim authPass As String = "x"


            'Checks for authentic password with correspoding username 
            Dim command As New OleDbCommand("SELECT [Password] FROM [Employee Information] WHERE [Username] ='" + username + "'", Dbconn)
            Dim authobj As Object = command.ExecuteScalar()
            authPass = authobj.ToString()

            'check if the password is already hashed
            'if for some reason there is still a plaintext password in the database, we will hash it!
            verifyHex = IsHex(authPass)
            If verifyHex = False And authPass = password Then
                Dim hashentry As String = getHash(authPass)

                'Hash the plaintext password and update it in the database 
                command = New OleDbCommand("UPDATE [Employee Information] SET [Password] ='" + hashentry + "'" + "WHERE [Username]='" + username + "'", Dbconn)
                command.ExecuteScalar()

                'Check if the update was successful by retrieving username associated with it 
                command = New OleDbCommand("SELECT [Username] FROM [Employee Information] WHERE [Password] ='" + hashentry + "'" + "AND" + "[Username] ='" + username + "'", Dbconn)
                authobj = command.ExecuteScalar()

                'store the user who was retrieved from the query command 
                authUser = authobj.ToString()

                'Get users authorization level Authorization
                command = New OleDbCommand("SELECT [Authorization] FROM [Employee Information] WHERE [Password] ='" + hashentry + "'" + "AND" + "[Username] ='" + username + "'", Dbconn)
                accessobj = command.ExecuteScalar()
                accesslvl = accessobj.ToString()
                Authorization_LVL = CInt(accesslvl)


            Else
                'the password is already hashed, to we issue a query with the hashed password 
                command = New OleDbCommand("SELECT [Username] FROM [Employee Information] WHERE [Password] ='" + hashedPass + "'" + "AND" + "[Username] ='" + username + "'", Dbconn)
                authobj = command.ExecuteScalar()
                command = New OleDbCommand("SELECT [Authorization] FROM [Employee Information] WHERE [Password] ='" + hashedPass + "'" + "AND" + "[Username] ='" + username + "'", Dbconn)
                accessobj = command.ExecuteScalar()

                'store the user who was retrieved from the query command 
                authUser = authobj.ToString()
                accesslvl = accessobj.ToString()
                Authorization_LVL = accessobj

            End If

            'was the username retrieved the same as the one entered in the form? if they are successful login 
            If authUser = username Then
                successLogin = 1
            End If

        Catch ex As Exception
        End Try

        Dim firstLogin As Boolean = checkFirst(username)

        'It's the users first login
        If firstLogin And successLogin = 1 Then
            Dim initialReset As InitialPasswordReset = New InitialPasswordReset()
            initialReset.Show()
            initialReset = Nothing
            Me.Close()

            'correct credentials were entered 
        ElseIf successLogin And accesslvl = "1" Then
            'Successful login, launch the basic menu 
            Dim BasicMenu As BasicForm
            BasicMenu = New BasicForm()
            BasicMenu.Show()
            BasicMenu = Nothing
            Me.Close()
            Dbconn.Close()

        ElseIf successLogin And accesslvl = "2" Then
            'Successful login, launch the supervisor menu 
            Dim SupervisorMenu As SupervisorForm
            SupervisorMenu = New SupervisorForm()
            SupervisorMenu.Show()
            SupervisorMenu = Nothing
            Me.Close()
            Dbconn.Close()

        ElseIf successLogin And accesslvl = "3" Then
            'Successful login, launch the admin menu 
            Dim AdminMenu As AdministratorForm
            AdminMenu = New AdministratorForm()
            AdminMenu.Show()
            AdminMenu = Nothing
            Me.Close()
            Dbconn.Close()

        ElseIf successLogin And accesslvl = "4" Then
            'Successful login, launch the developer menu 
            DevMenu.Show()
            DevMenu = Nothing
            Me.Close()
            Dbconn.Close()

        Else
            Invalid_Cred.Visible = True
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs)
        Invalid_Cred.Hide()
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs)
        Invalid_Cred.Hide()
    End Sub

    Private Sub ForgotPassLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ForgotPassLink.LinkClicked
        Dim PassReset As GeneralPasswordReset = New GeneralPasswordReset()
        PassReset.Show()
        PassReset = Nothing
        Me.Close()
    End Sub
End Class
