Imports System.Text
Imports System.Data.OleDb
Imports System.Security.Cryptography

Public Class Login
																				'Change to the path where the database is located at 
    Dim Dbstring As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + ""

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

        'menu for basic users 
        Dim BasicMenu As BasicForm
        BasicMenu = New BasicForm()

        'menu for supervisors 
        Dim SupervisorMenu As SupervisorForm
        SupervisorMenu = New SupervisorForm()

        'menu for administrators
        Dim AdminMenu As AdministratorForm
        AdminMenu = New AdministratorForm()

        'menu for developers
        Dim DevMenu As DeveloperForm
        DevMenu = New DeveloperForm()

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
            Else
                'the password is already hashed, to we issue a query with the hashed password 
                command = New OleDbCommand("SELECT [Username] FROM [Employee Information] WHERE [Password] ='" + hashedPass + "'" + "AND" + "[Username] ='" + username + "'", Dbconn)
                authobj = command.ExecuteScalar()
                command = New OleDbCommand("SELECT [Authorization] FROM [Employee Information] WHERE [Password] ='" + hashedPass + "'" + "AND" + "[Username] ='" + username + "'", Dbconn)
                accessobj = command.ExecuteScalar()
                'store the user who was retrieved from the query command 
                authUser = authobj.ToString()
                accesslvl = accessobj.ToString()
            End If

            'was the username retrieved the same as the one entered in the form? if they are successful login 
            If authUser = username Then
                successLogin = 1
            End If

        Catch ex As Exception
        End Try

        'correct credentials were entered 
        If successLogin And accesslvl = "1" Then
            'Successful login, launch the basic menu 
            BasicMenu.Show()
            BasicMenu = Nothing
            Me.Close()
            Dbconn.Close()
        ElseIf successLogin And accesslvl = "2" Then
            'Successful login, launch the supervisor menu 
            SupervisorMenu.Show()
            SupervisorMenu = Nothing
            Me.Close()
            Dbconn.Close()
        ElseIf successLogin And accesslvl = "3" Then
            'Successful login, launch the admin menu 
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

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Invalid_Cred.Click

    End Sub

End Class


