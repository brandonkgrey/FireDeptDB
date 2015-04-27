Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.OleDb

Public Class Developer_Class_Information
    Dim Dbstring As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + "C:\Users\Alejandro\Desktop\Fire Department DB\new\Training Records for TAMU.accdb;Jet OLEDB:Database Password=fdtrain;"
    Friend Shared class_number As String
    Dim AuthLvl
    Dim start_time As String
    Dim end_time As String
    Dim strTime As DateTime
    Dim endTime As DateTime



    Private Sub Prev_Button_Click(sender As Object, e As EventArgs) Handles Prev_Button.Click
        ClassInformationBindingSource.MovePrevious()
        start_time = TextBox18.Text
        end_time = TextBox19.Text
        If start_time <> "" Then
            strTime = DateTime.Parse(start_time)
            TextBox18.Text = TimeValue(strTime)
        End If
        If end_time <> "" Then
            endTime = DateTime.Parse(end_time)
            TextBox19.Text = TimeValue(endTime)
        End If


    End Sub

    Private Sub Next_Button_Click(sender As Object, e As EventArgs) Handles Next_Button.Click
        ClassInformationBindingSource.MoveNext()
        start_time = TextBox18.Text
        end_time = TextBox19.Text
        If start_time <> "" Then
            strTime = DateTime.Parse(start_time)
            TextBox18.Text = TimeValue(strTime)
        End If
        If end_time <> "" Then
            endTime = DateTime.Parse(end_time)
            TextBox19.Text = TimeValue(endTime)
        End If



    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to delete the current class's record from the database?", " Confirm Deletion", MessageBoxButtons.YesNo)

        If result = DialogResult.No Then
            MessageBox.Show("The record has NOT been deleted")
        ElseIf result = DialogResult.Yes Then

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

            Dim class_id = Class_Number_Textbox.Text

            Try
                Dim Command = New OleDbCommand("DELETE FROM [Class Information] WHERE [Class Number]= '" + class_id + "'", Dbconn)
                Command.ExecuteScalar()

            Catch ex As Exception
            End Try

            MessageBox.Show("The record has been deleted. Please wait while the form reloads.")

            Dim refreshDelete As New Developer_Class_Information()
            refreshDelete.Show()
            refreshDelete = Nothing
            Me.Close()

        End If
    End Sub

    Function generateTrainInfoQueryString() As String
        Dim strCommand As String

        strCommand = "UPDATE [Class Information] SET "

        '1
        If CheckBox8.Checked = True Then
            strCommand += "[Certification]= 1"
        End If
        If CheckBox8.Checked = False Then
            strCommand += "[Certification]= 0"
        End If

        '2
        If MultiJurCheckbox.Checked = True Then
            strCommand += ", [Joint Training]= 1"
        End If
        If MultiJurCheckbox.Checked = False Then
            strCommand += ", [Joint Training]= 0"
        End If
        '3
        If CheckBox1.Checked = True Then
            strCommand += ", [Station 1 Involved]= 1"
        End If
        If CheckBox1.Checked = False Then
            strCommand += ", [Station 1 Involved]= 0"
        End If
        '4
        If CheckBox10.Checked = True Then
            strCommand += ", [Station 2 Involved]= 1"
        End If
        If CheckBox10.Checked = False Then
            strCommand += ", [Station 2 Involved]= 0"
        End If
        '5
        If CheckBox19.Checked = True Then
            strCommand += ", [Station 3 Involved]= 1"
        End If
        If CheckBox19.Checked = False Then
            strCommand += ", [Station 3 Involved]= 0"
        End If
        '6
        If CheckBox18.Checked = True Then
            strCommand += ", [Station 4 Involved]= 1"
        End If
        If CheckBox18.Checked = False Then
            strCommand += ", [Station 4 Involved]= 0"
        End If
        '7
        If CheckBox17.Checked = True Then
            strCommand += ", [Station 5 Involved]= 1"
        End If
        If CheckBox17.Checked = False Then
            strCommand += ", [Station 5 Involved]= 0"
        End If
        '8'
        If CheckBox15.Checked = True Then
            strCommand += ", [Station 6 Involved]= 1"
        End If
        If CheckBox15.Checked = False Then
            strCommand += ", [Station 6 Involved]= 0"
        End If
        '9
        If CheckBox9.Checked = True Then
            strCommand += ", [Station 7 Involved]= 1"
        End If
        If CheckBox9.Checked = False Then
            strCommand += ", [Station 7 Involved]= 0"
        End If
        '10
        If CheckBox15.Checked = True Then
            strCommand += ", [Station FA Involved]= 1"
        End If
        If CheckBox15.Checked = False Then
            strCommand += ", [Station FA Involved]= 0"
        End If
        '11
        If CheckBox14.Checked = True Then
            strCommand += ", [Agency Inv Bryan]= 1"
        End If
        If CheckBox14.Checked = False Then
            strCommand += ", [Agency Inv Bryan]= 0"
        End If
        '12
        If CheckBox12.Checked = True Then
            strCommand += ", [Agency Inv SBCVFD]= 1"
        End If
        If CheckBox12.Checked = False Then
            strCommand += ", [Agency Inv SBCVFD]= 0"
        End If
        '13
        If CheckBox11.Checked = True Then
            strCommand += ", [Agency Inv District 2 VFD]= 1"
        End If
        If CheckBox11.Checked = False Then
            strCommand += ", [Agency Inv District 2 VFD]= 0"
        End If
        '14
        If CheckBox4.Checked = True Then
            strCommand += ", [Agency Inv Precinct 3 VFD]= 1"
        End If
        If CheckBox4.Checked = False Then
            strCommand += ", [Agency Inv Precinct 3 VFD]= 0"
        End If
        '15'
        If CheckBox6.Checked = True Then
            strCommand += ", [Agency Inv Precinct 4 VFD]= 1"
        End If
        If CheckBox6.Checked = False Then
            strCommand += ", [Agency Inv Precinct 4 VFD]= 0"
        End If
        '16
        If CheckBox13.Checked = True Then
            strCommand += ", [Agency Inv TAMU HS]= 1"
        End If
        If CheckBox13.Checked = False Then
            strCommand += ", [Agency Inv TAMU HS]= 0"
        End If
        '17
        If CheckBox5.Checked = True Then
            strCommand += ", [Agency Inv TAMU EMS]= 1"
        End If
        If CheckBox5.Checked = False Then
            strCommand += ", [Agency Inv TAMU EMS]= 0"
        End If
        '18
        If CheckBox2.Checked = True Then
            strCommand += ", [Agency Inv STJ EMS]= 1"
        End If
        If CheckBox2.Checked = False Then
            strCommand += ", [Agency Inv STJ EMS]= 0"
        End If
        '19
        If CheckBox7.Checked = True Then
            strCommand += ", [SOG Credit]= 1"
        End If
        If CheckBox7.Checked = False Then
            strCommand += ", [SOG Credit]= 0"
        End If
        '20
        If CheckBox3.Checked = True Then
            strCommand += ", [Protocol Credit]= 1"
        End If
        If CheckBox3.Checked = False Then
            strCommand += ", [Protocol Credit]= 0"
        End If

        If ComboBox1.Text <> "" Then
            strCommand += ", [Track] = '" + ComboBox1.Text + "'"
        End If

        If ComboBox2.Text <> "" Then
            strCommand += ", [PDG] = '" + ComboBox2.Text + "'"
        End If

        If TextBox4.Text <> "" Then
            strCommand += ", [Agency Inv Other] = '" + TextBox4.Text + "'"
        End If
        If TextBox5.Text <> "" Then
            strCommand += ", [Objective 1] = '" + TextBox5.Text + "'"
        End If
        If TextBox6.Text <> "" Then
            strCommand += ", [Objective 2] = '" + TextBox6.Text + "'"
        End If
        If TextBox7.Text <> "" Then
            strCommand += ", [Objective 3] = '" + TextBox7.Text + "'"
        End If
        If TextBox9.Text <> "" Then
            strCommand += ", [Objective 4] = '" + TextBox9.Text + "'"
        End If
        If TextBox8.Text <> "" Then
            strCommand += ", [Objective 5] = '" + TextBox8.Text + "'"
        End If

        strCommand += " WHERE [Class Number] ='" + Class_Number_Textbox.Text + "'"
        Return strCommand

    End Function
    Function generateCourseContentQuertString() As String
        Dim commandStr As String
        commandStr = "UPDATE [Class Information] SET "

        If CheckBox20.Checked = True Then
            commandStr += "[Live Fire Training]= 1"
        End If
        If CheckBox20.Checked = False Then
            commandStr += " [Live Fire Training]= 0"
        End If

        If CheckBox21.Checked = True Then
            commandStr += ", [Night]= 1"
        End If
        If CheckBox21.Checked = False Then
            commandStr += ", [Night]= 0"
        End If
        If CheckBox22.Checked = True Then
            commandStr += ", [Drill]= 1"
        End If
        If CheckBox22.Checked = False Then
            commandStr += ", [Drill]= 0"
        End If
        If CheckBox23.Checked = True Then
            commandStr += ", [CTT ISO Credit]= 1"
        End If
        If CheckBox23.Checked = False Then
            commandStr += ", [CTT ISO Credit]= 0"
        End If

        If ComboBox3.Text <> "" Then
            commandStr += ", [HM Subject Area] = '" + ComboBox3.Text + "'"
        End If
        If ComboBox4.Text <> "" Then
            commandStr += ", [FAA Subject Area] = '" + ComboBox4.Text + "'"
        End If
        If ComboBox6.Text <> "" Then
            commandStr += ", [TCLEOSE Subject Area] = '" + ComboBox6.Text + "'"
        End If
        If ComboBox5.Text <> "" Then
            commandStr += ", [NIMS] = '" + ComboBox5.Text + "'"
        End If
        If ComboBox7.Text <> "" Then
            commandStr += ", [Drill Type] = '" + ComboBox7.Text + "'"
        End If
        If ComboBox8.Text <> "" Then
            commandStr += ", [TCFP Subject Area] = '" + ComboBox8.Text + "'"
        End If
        If ComboBox9.Text <> "" Then
            commandStr += ", [EMS Subject Area] = '" + ComboBox9.Text + "'"
        End If


        If TextBox10.Text <> "" Then
            commandStr += "[Structural FF Hours] = '" + TextBox10.Text + "'"
        End If
        If TextBox11.Text <> "" Then
            commandStr += "[Driver Hours] = '" + TextBox11.Text + "'"
        End If
        If TextBox12.Text <> "" Then
            commandStr += "[Fire Officer Hours] = '" + TextBox12.Text + "'"
        End If
        If TextBox22.Text <> "" Then
            commandStr += "[HazMat Hours] = '" + TextBox22.Text + "'"
        End If
        If TextBox23.Text <> "" Then
            commandStr += "[ARFF Hours] = '" + TextBox23.Text + "'"
        End If
        If TextBox24.Text <> "" Then
            commandStr += "[Rescue Hours] = '" + TextBox24.Text + "'"
        End If
        If TextBox25.Text <> "" Then
            commandStr += "[Inspector Hours] = '" + TextBox25.Text + "'"
        End If
        If TextBox26.Text <> "" Then
            commandStr += "[Investigator Hours] = '" + TextBox26.Text + "'"
        End If
        If TextBox27.Text <> "" Then
            commandStr += "[Wildland Hours] = '" + TextBox27.Text + "'"
        End If
        If TextBox28.Text <> "" Then
            commandStr += "[Safety Hours] = '" + TextBox28.Text + "'"
        End If
        If TextBox29.Text <> "" Then
            commandStr += "[Instructor Hours] = '" + TextBox29.Text + "'"
        End If
        If TextBox30.Text <> "" Then
            commandStr += "[Head of Department Hours] = '" + TextBox30.Text + "'"
        End If
        If TextBox36.Text <> "" Then
            commandStr += "[Preparatory] = '" + TextBox36.Text + "'"
        End If
        If TextBox35.Text <> "" Then
            commandStr += "[Airway Mgmt/Vent] = '" + TextBox35.Text + "'"
        End If
        If TextBox34.Text <> "" Then
            commandStr += "[Patient Assessment] = '" + TextBox34.Text + "'"
        End If
        If TextBox33.Text <> "" Then
            commandStr += "[Medical] = '" + TextBox33.Text + "'"
        End If
        If TextBox32.Text <> "" Then
            commandStr += "[Trauma] = '" + TextBox32.Text + "'"
        End If
        If TextBox32.Text <> "" Then
            commandStr += "[Special Considerations] = '" + TextBox32.Text + "'"
        End If
        If TextBox38.Text <> "" Then
            commandStr += "[Clinical Operations] = '" + TextBox38.Text + "'"
        End If
        If TextBox37.Text <> "" Then
            commandStr += "[Pediatrics] = '" + TextBox37.Text + "'"
        End If

        commandStr += " WHERE [Class Number] ='" + Class_Number_Textbox.Text + "'"
        Return commandStr
    End Function
    Function generateClassInfoQueryString() As String
        Dim commandStr As String

        commandStr = "UPDATE [Class Information] SET "

        If TextBox1.Text <> "" Then
            commandStr += "[Class Name] = '" + TextBox1.Text + "'"
        End If

        If TextBox13.Text <> "" Then
            commandStr += ", [Class Location] = '" + TextBox13.Text + "'"
        End If

        If TextBox17.Text <> "" Then
            commandStr += ", [CE Hours] = '" + TextBox17.Text + "'"
        End If

        If TextBox21.Text <> "" Then
            commandStr += ", [Start Date] = '" + TextBox21.Text + "'"
        End If

        If TextBox20.Text <> "" Then
            commandStr += ", [End Date] = '" + TextBox20.Text + "'"
        End If

        If TextBox18.Text <> "" Then
            commandStr += ", [Start Time] = '" + TextBox18.Text + "'"
        End If

        If TextBox19.Text <> "" Then
            commandStr += ", [End Time] = '" + TextBox19.Text + "'"
        End If

        If Class_Number_Textbox.Text <> "" Then
            commandStr += ", [Class Number] = '" + Class_Number_Textbox.Text + "'"
        End If

        If ComboBox10.Text <> "" Then
            commandStr += ", [Approval Number] = '" + ComboBox10.Text + "'"
        End If

        If TextBox16.Text <> "" Then
            commandStr += ", [Number Of Days] = '" + TextBox16.Text + "'"
        End If

        If ComboBox15.Text <> "" Then
            commandStr += ", [Inhouse] = '" + ComboBox15.Text + "'"
        End If

        If ComboBox14.Text <> "" Then
            commandStr += ", [Shift] = '" + ComboBox14.Text + "'"
        End If

        If ComboBox18.Text <> "" Then
            commandStr += ", [Lead Instructor] = '" + ComboBox18.Text + "'"
        End If

        If ComboBox16.Text <> "" Then
            commandStr += ", [Officer in Charge] = '" + ComboBox16.Text + "'"
        End If

        If ComboBox17.Text <> "" Then
            commandStr += ", [Class Host] = '" + ComboBox17.Text + "'"
        End If

        If TextBox14.Text <> "" Then
            commandStr += ", [Number of Students] = '" + TextBox14.Text + "'"
        End If

        If TextBox15.Text <> "" Then
            commandStr += ", [Contact Hours] = '" + TextBox15.Text + "'"
        End If

        If TextBox39.Text <> "" Then
            commandStr += ", [Date Entered] = '" + TextBox39.Text + "'"
        End If

        If ComboBox13.Text <> "" Then
            commandStr += ", [Entered By] = '" + ComboBox13.Text + "'"
        End If

        If ComboBox12.Text <> "" Then
            commandStr += ", [Paperwork Filed] = '" + ComboBox12.Text + "'"
        End If

        If CheckBox24.Checked = True Then
            commandStr += ", [QI]= 1"
        End If
        If CheckBox24.Checked = False Then
            commandStr += ", [QI]= 0"
        End If

        If CheckBox25.Checked = True Then
            commandStr += ", [Credit]= 1"
        End If
        If CheckBox25.Checked = False Then
            commandStr += ", [Credit]= 0"
        End If

        If RadioButton2.Checked = True Then
            commandStr += ", [EMS Credit]= 1"
        End If
        If RadioButton2.Checked = False Then
            commandStr += ", [EMS Credit]= 0"
        End If

        If RadioButton1.Checked = True Then
            commandStr += ", [Fire Credit]= 1"
        End If
        If RadioButton1.Checked = False Then
            commandStr += ", [Fire Credit]= 0"
        End If

        commandStr += " WHERE [Class Number] ='" + Class_Number_Textbox.Text + "'"
        Return commandStr

    End Function

    Private Sub Save_Button_Click(sender As Object, e As EventArgs) Handles Save_Button.Click
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

        Dim cmdString As String = generateClassInfoQueryString()
        Dim trainString As String = generateTrainInfoQueryString()

        Try
            Dim Command = New OleDbCommand(cmdString, Dbconn)
            Command.ExecuteScalar()

            Command = New OleDbCommand(trainString, Dbconn)
            Command.ExecuteScalar()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Dbconn.Close()

        MsgBox("Your changes were successfully saved!!", MsgBoxStyle.Information, "Saved Changes")
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        If (AuthLvl = 4) Then
            Dim DevForm As DeveloperForm
            DevForm = New DeveloperForm()
            DevForm.Show()
            DevForm = Nothing
            Me.Close()
        ElseIf (AuthLvl = 3) Then
            Dim Adminform As New AdministratorForm
            Adminform.Show()
            Adminform = Nothing
            Me.Close()
        ElseIf (AuthLvl = 2) Then
            Dim SupForm As New SupervisorForm
            SupForm.Show()
            SupForm = Nothing
            Me.Close()
        End If

    End Sub

    Private Sub ReportButton_Click(sender As Object, e As EventArgs) Handles ReportButton.Click
        class_number = Class_Number_Textbox.Text
        Dim repview As New Class_Information_Report_View()
        repview.Show()
        repview = Nothing
        Me.Close()
    End Sub

    Private Sub Developer_Class_Information_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Training_Records_for_TAMUDataSet.Class_Attendance_Information' table. You can move, or remove it, as needed.
        Me.Class_Attendance_InformationTableAdapter.FillBy(Me.Training_Records_for_TAMUDataSet.Class_Attendance_Information, Class_Number_Textbox.Text)
        'TODO: This line of code loads data into the 'Training_Records_for_TAMUDataSet.Class_Information' table. You can move, or remove it, as needed.
        Me.Class_InformationTableAdapter.Fill(Me.Training_Records_for_TAMUDataSet.Class_Information)

        start_time = TextBox18.Text
        end_time = TextBox19.Text
        If start_time <> "" Then
            strTime = DateTime.Parse(start_time)
            TextBox18.Text = TimeValue(strTime)
        End If
        If end_time <> "" Then
            endTime = DateTime.Parse(end_time)
            TextBox19.Text = TimeValue(endTime)
        End If



        AuthLvl = Login.Authorization_LVL

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Class_Number_Textbox.TextChanged
        Me.Class_Attendance_InformationTableAdapter.FillBy(Me.Training_Records_for_TAMUDataSet.Class_Attendance_Information, Class_Number_Textbox.Text)
    End Sub

    Private Sub CINewButton_Click(sender As Object, e As EventArgs) Handles CINewButton.Click

        Dim newclass As String

        newclass = InputBox("Please input the class number for the new class.")

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

        Try
            Dim Command = New OleDbCommand("INSERT INTO [Class Information] ([Class Number]) VALUES ('" + newclass + "')", Dbconn)
            Command.ExecuteScalar()
            
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        MsgBox("Please wait for the form to reload, find the new class using its class number in the dropdown box, and use the save button to input new information.")

        Dbconn.Close()

        Dim refreshCI As New Developer_Class_Information
        refreshCI.Show()
        refreshCI = Nothing
        Me.Close()

        

    End Sub
End Class