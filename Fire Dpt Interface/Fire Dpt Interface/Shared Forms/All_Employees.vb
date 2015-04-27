Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.OleDb

Public Class All_Employees
    Dim Dbstring As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + "C:\Users\Alejandro\Desktop\Fire Department DB\new\Training Records for TAMU.accdb;Jet OLEDB:Database Password=fdtrain;"
    Dim Authorization_Level
    Dim employeeID
    Dim HiddenTabs As Stack(Of TabPage) = New Stack(Of TabPage)
    Dim choice As Integer
    Dim employeeName As String
    Friend Shared currentID
    Friend Shared sendingForm As Boolean = False

    Function generateEmpInfoQueryString() As String
        Dim commandStr As String
        commandStr = "UPDATE [Employee Information] SET "

        If Emp_Name.Text <> "" Then
            commandStr += "[Name] = '" + Name_Textbox.Text + "'"
        End If
        If Address_Textbox.Text <> "" Then
            commandStr += ", [Address]='" + Address_Textbox.Text + "'"
        End If
        If City_Textbox.Text <> "" Then
            commandStr += ", [City]='" + City_Textbox.Text + "'"
        End If
        If State_Textbox.Text <> "" Then
            commandStr += ", [State]='" + State_Textbox.Text + "'"
        End If
        If Zip_Textbox.Text <> "" Then
            commandStr += ", [Zip]='" + Zip_Textbox.Text + "'"
        End If
        If Phone_Textbox.Text <> "" Then
            commandStr += ", [Phone]='" + Phone_Textbox.Text + "'"
        End If
        If TDL_Textbox.Text <> "" Then
            commandStr += ", [TDL]='" + TDL_Textbox.Text + "'"
        End If
        If CDL_CheckBox.Checked = True Then
            commandStr += ", [CDL]= 1"
        End If
        If CDL_CheckBox.Checked = False Then
            commandStr += ", [CDL]= 0"
        End If
        If TextBox2.Text <> "" Then
            commandStr += ", [DL CLass]='" + TextBox2.Text + "'"
        End If
        If TextBox3.Text <> "" Then
            commandStr += ", [TDH ID]='" + TextBox3.Text + "'"
        End If
        If TextBox4.Text <> "" Then
            commandStr += ", [TCFP PIN]='" + TextBox4.Text + "'"
        End If
        If DOB_Textbox.Text <> "" Then
            commandStr += ", [Date of Birth]='" + DOB_Textbox.Text + "'"
        End If
        If Shift_TextBox.Text <> "" Then
            commandStr += ", [Shift]='" + Shift_TextBox.Text + "'"
        End If
        If HireDate_Textbox.Text <> "" Then
            commandStr += ", [Hire Date]='" + HireDate_Textbox.Text + "'"
        End If
        If Rank_Textbox.Text <> "" Then
            commandStr += ", [Rank]='" + Rank_Textbox.Text + "'"
        End If
        If RankDate_Textbox.Text <> "" Then
            commandStr += ", [Rank Date]='" + RankDate_Textbox.Text + "'"
        End If
        If EndDate_Textbox.Text <> "" Then
            commandStr += ", [End Date]='" + EndDate_Textbox.Text + "'"
        End If
        If NonOpsCheckbox.Checked = False Then
            commandStr += ", [Ops]= 0"
        End If
        If NonOpsCheckbox.Checked = True Then
            commandStr += ", [Ops]= 1"
        End If
        If Division_Textbox.Text <> "" Then
            commandStr += ", [Division]='" + Division_Textbox.Text + "'"
        End If




        commandStr += " WHERE [Employee_ID] =" + Emp_Textbox.Text
        Return commandStr
    End Function

    Function generateFireCertQueryString() As String
        Dim commandStr As String
        commandStr = "UPDATE [Fire Certifications] SET "

        If StructuredFirefighterCheckBox.Checked = False Then
            commandStr += "[Structure Firefighter] =0"
        End If
        If StructuredFirefighterCheckBox.Checked = True Then
            commandStr += "[Structure Firefighter] =1"
        End If

        If ComboBox1.Text <> "" Then
            commandStr += ", [SF Level] ='" + ComboBox1.Text + "'"
        End If

        If TextBox1.Text <> "" Then
            commandStr += ", [SF Received] ='" + TextBox1.Text + "'"
        End If

        If TextBox31.Text <> "" Then
            commandStr += ", [SF Expiration] ='" + TextBox31.Text + "'"
        End If

        ''''''
        If ARFFCheckBox.Checked = False Then
            commandStr += ", [ARFF Cert] =0"
        End If
        If ARFFCheckBox.Checked = True Then
            commandStr += ", [ARFF Cert] =1"
        End If

        If ComboBox2.Text <> "" Then
            commandStr += ", [ARFF Level] ='" + ComboBox2.Text + "'"
        End If

        If TextBox5.Text <> "" Then
            commandStr += ", [ARFF Received] ='" + TextBox5.Text + "'"
        End If

        If TextBox30.Text <> "" Then
            commandStr += ", [ARFF Expiration] ='" + TextBox30.Text + "'"
        End If

        ''''''''
        If FireArsonCheckBox.Checked = False Then
            commandStr += ", [Fire and Arson Investigator] =0"
        End If
        If FireArsonCheckBox.Checked = True Then
            commandStr += ", [Fire and Arson Investigator] =1"
        End If

        If ComboBox6.Text <> "" Then
            commandStr += ", [FAI Level] ='" + ComboBox6.Text + "'"
        End If

        If TextBox8.Text <> "" Then
            commandStr += ", [FAI Received Date] ='" + TextBox8.Text + "'"
        End If

        If TextBox27.Text <> "" Then
            commandStr += ", [FAI Expiration Date] ='" + TextBox27.Text + "'"
        End If
        ''''''''
        If FireOriginCheckBox.Checked = False Then
            commandStr += ", [Fire Cause and Origin Investigator] =0"
        End If
        If FireOriginCheckBox.Checked = True Then
            commandStr += ", [Fire Cause and Origin Investigator] =1"
        End If

        If ComboBox5.Text <> "" Then
            commandStr += ", [FCOI Level] ='" + ComboBox5.Text + "'"
        End If

        If TextBox9.Text <> "" Then
            commandStr += ", [FCOI Received Date] ='" + TextBox8.Text + "'"
        End If

        If TextBox26.Text <> "" Then
            commandStr += ", [FCOI Expiration Date] ='" + TextBox26.Text + "'"
        End If
        '''''''
        If FireInspectorCheckBox.Checked = False Then
            commandStr += ", [Fire Inspector] =0"
        End If
        If FireInspectorCheckBox.Checked = True Then
            commandStr += ", [Fire Inspector] =1"
        End If

        If ComboBox4.Text <> "" Then
            commandStr += ", [Fire Inspector Level] ='" + ComboBox4.Text + "'"
        End If

        If TextBox10.Text <> "" Then
            commandStr += ", [Fire Inspector Received Date] ='" + TextBox10.Text + "'"
        End If

        If TextBox25.Text <> "" Then
            commandStr += ", [Fire Inspector Expiration Date] ='" + TextBox25.Text + "'"
        End If
        '''''''''''
        If HazMatCheckBox.Checked = False Then
            commandStr += ", [HazMat] =0"
        End If
        If HazMatCheckBox.Checked = True Then
            commandStr += ", [HazMat] =1"
        End If

        If ComboBox7.Text <> "" Then
            commandStr += ", [HazMat Level] ='" + ComboBox7.Text + "'"
        End If

        If TextBox11.Text <> "" Then
            commandStr += ", [HazMat Received Date] ='" + TextBox11.Text + "'"
        End If

        If TextBox24.Text <> "" Then
            commandStr += ", [HazMat Expiration Date] ='" + TextBox24.Text + "'"
        End If
        '''''''''''
        If HazMatIncCheckBox.Checked = False Then
            commandStr += ", [HazMat IC] =0"
        End If
        If HazMatIncCheckBox.Checked = True Then
            commandStr += ", [HazMat IC] =1"
        End If
        If TextBox12.Text <> "" Then
            commandStr += ", [HazMat IC Rdate] ='" + TextBox32.Text + "'"
        End If
        If TextBox23.Text <> "" Then
            commandStr += ", [HazMat IC Edate] ='" + TextBox23.Text + "'"
        End If
            '''''''''''''

        If IncidentSafetyCheckBox.Checked = False Then
            commandStr += ", [Incident Safety Officer] =0"
        End If
        If IncidentSafetyCheckBox.Checked = True Then
            commandStr += ", [Incident Safety Officer] =1"
        End If
        If TextBox16.Text <> "" Then
            commandStr += ", [ISO Received Date] ='" + TextBox16.Text + "'"
        End If

        If TextBox19.Text <> "" Then
            commandStr += ", [ISO Expiration Date] ='" + TextBox19.Text + "'"
        End If

        ''''''''''
        If SafetyOffCheckBox.Checked = False Then
            commandStr += ", [Safety Officer] =0"
        End If
        If SafetyOffCheckBox.Checked = True Then
            commandStr += ", [Safety Officer] =1"
        End If

        If TextBox33.Text <> "" Then
            commandStr += ", [SO Received Date] ='" + TextBox33.Text + "'"
        End If
        ''''''''
        If DriverOpCheckBox.Checked = False Then
            commandStr += ", [Driver/Operator] =0"
        End If
        If DriverOpCheckBox.Checked = True Then
            commandStr += ", [Driver/Operator] =1"
        End If

        If TextBox13.Text <> "" Then
            commandStr += ", [D/O Received Date] ='" + TextBox13.Text + "'"
        End If

        If TextBox22.Text <> "" Then
            commandStr += ", [D/O Expiration Date] ='" + TextBox22.Text + "'"
        End If

        '''''''''
        If FireOfficerICheckBox.Checked = False Then
            commandStr += ", [TCFP Officer I] =0"
        End If
        If FireOfficerICheckBox.Checked = True Then
            commandStr += ", [TCFP Officer I] =1"
        End If

        If TextBox14.Text <> "" Then
            commandStr += ", [TCFP Officer I RDate] ='" + TextBox14.Text + "'"
        End If

        If TextBox21.Text <> "" Then
            commandStr += ", [TCFP Officer I EDate] ='" + TextBox21.Text + "'"
        End If
        ''''''''''
        If FireOfficerIICheckBox.Checked = False Then
            commandStr += ", [TCFP Officer II] =0"
        End If
        If FireOfficerIICheckBox.Checked = True Then
            commandStr += ", [TCFP Officer II] =1"
        End If

        If TextBox15.Text <> "" Then
            commandStr += ", [TCFP Officer II RDate] ='" + TextBox15.Text + "'"
        End If

        If TextBox20.Text <> "" Then
            commandStr += ", [TCFP Officer II EDate] ='" + TextBox20.Text + "'"
        End If

        If WildlandFireCheckBox.Checked = False Then
            commandStr += ", [TCFP Wildland Firefighter] = 0"
        End If

        If WildlandFireCheckBox.Checked = True Then
            commandStr += ", [TCFP Wildland Firefighter] = 1"
        End If

        If ComboBox8.Text <> "" Then
            commandStr += ", [TCFP Wildland FF Level] ='" + ComboBox8.Text + "'"
        End If

        If TextBox17.Text <> "" Then
            commandStr += ", [TCFP Wildland FF RDate] ='" + TextBox17.Text + "'"
        End If

        If TextBox18.Text <> "" Then
            commandStr += ", [TCFP Wildland FF EDate] ='" + TextBox18.Text + "'"
        End If

        If FirefighterICheckBox.Checked = True Then
            commandStr += ", [IFSAC FI]=1"
        End If
        If FirefighterICheckBox.Checked = False Then
            commandStr += ", [IFSAC FI]=0"
        End If

        If FirefighterIICheckBox.Checked = True Then
            commandStr += ", [IFSAC FII]=1"
        End If
        If FirefighterIICheckBox.Checked = False Then
            commandStr += ", [IFSAC FII]=0"
        End If

        If HMAwareCheckBox.Checked = True Then
            commandStr += ", [IFSAC HMA]=1"
        End If
        If HMAwareCheckBox.Checked = False Then
            commandStr += ", [IFSAC HMA]=0"
        End If
        If HMOperationsCheckBox.Checked = True Then
            commandStr += ", [IFSAC HMO]=1"
        End If
        If HMOperationsCheckBox.Checked = False Then
            commandStr += ", [IFSAC HMO]=0"
        End If

        If HMTechCheckBox.Checked = True Then
            commandStr += ", [IFSAC HMT]=1"
        End If
        If HMTechCheckBox.Checked = False Then
            commandStr += ", [IFSAC HMT]=0"
        End If

        If DriverOpCheckBox.Checked = True Then
            commandStr += ", [IFSAC DO]=1"
        End If
        If DriverOpCheckBox.Checked = False Then
            commandStr += ", [IFSAC DO]=0"
        End If

        If ARFFSealsCheckBox.Checked = True Then
            commandStr += ", [IFSAC ARFF]=1"
        End If
        If ARFFSealsCheckBox.Checked = False Then
            commandStr += ", [IFSAC ARFF]=0"
        End If

        If OfficerICheckBox.Checked = True Then
            commandStr += ", [IFSAC FOI]=1"
        End If
        If OfficerICheckBox.Checked = False Then
            commandStr += ", [IFSAC FOI]=0"
        End If

        If OfficerIICheckBox.Checked = True Then
            commandStr += ", [IFSAC FOII]=1"
        End If
        If OfficerIICheckBox.Checked = False Then
            commandStr += ", [IFSAC FOII]=0"
        End If

        If FireInvSealsCheckbox.Checked = True Then
            commandStr += ", [IFSAC FINV]=1"
        End If
        If FireInvSealsCheckbox.Checked = False Then
            commandStr += ", [IFSAC FINV]=0"
        End If

        If SwiftWaterCheckBox.Checked = True Then
            commandStr += ", [Swiftwater]=1"
        End If
        If SwiftWaterCheckBox.Checked = False Then
            commandStr += ", [Swiftwater]=0"
        End If

        If ConfinedSpaceCheckBox.Checked = True Then
            commandStr += ", [Confined Space Rescue]=1"
        End If
        If ConfinedSpaceCheckBox.Checked = False Then
            commandStr += ", [Confined Space Rescue]=0"
        End If

        If TrenchCheckBox.Checked = True Then
            commandStr += ", [Trench Rescue]=1"
        End If
        If TrenchCheckBox.Checked = False Then
            commandStr += ", [Trench Rescue]=0"
        End If

        If RopeAngleCheckBox.Checked = True Then
            commandStr += ", [Rope Rescue]=1"
        End If
        If RopeAngleCheckBox.Checked = False Then
            commandStr += ", [Rope Rescue]=0"
        End If

        If PumpOpsCheckBox.Checked = True Then
            commandStr += ", [Pump Ops]=1"
        End If
        If PumpOpsCheckBox.Checked = False Then
            commandStr += ", [Pump Ops]=0"
        End If

        If CheckBox13.Checked = True Then
            commandStr += ", [Aerial Ops]=1"
        End If
        If CheckBox13.Checked = False Then
            commandStr += ", [Aerial Ops]=0"
        End If


        '''''''''''
        If HazMatICSCheckBox.Checked = False Then
            commandStr += ", [HazMat ICS] =0"
        End If
        If HazMatICSCheckBox.Checked = True Then
            commandStr += ", [HazMat ICS] =1"
        End If
        If TextBox32.Text <> "" Then
            commandStr += ", [HazMat ICS Received Date] ='" + TextBox32.Text + "'"
        End If
        ''''''''''





        commandStr += " WHERE [Employee_ID] =" + Emp_Textbox.Text
        Return commandStr
    End Function

    Function generateEMSCertQueryString() As String
        Dim commandStr As String
        commandStr = "UPDATE [EMS Certifications] SET "

        If CheckBox1.Checked = False Then
            commandStr += " [TDH Instructor] =0"
        End If
        If CheckBox1.Checked = True Then
            commandStr += " [TDH Instructor] =1"
        End If

        If ComboBox9.Text <> "" Then
            commandStr += ", [TDH Level] ='" + ComboBox9.Text + "'"
        End If

        If TextBox34.Text <> "" Then
            commandStr += ", [TDH Level Received Date] ='" + TextBox34.Text + "'"
        End If

        If TextBox35.Text <> "" Then
            commandStr += ", [TDH Level Expiration Date] ='" + TextBox35.Text + "'"
        End If

        If TextBox36.Text <> "" Then
            commandStr += ", [TDH Instructor Received Date] ='" + TextBox37.Text + "'"
        End If

        If TextBox37.Text <> "" Then
            commandStr += ", [TDH Instructor Expiration Date] ='" + TextBox37.Text + "'"
        End If

        If CheckBox2.Checked = False Then
            commandStr += ", [TDH Coordinator] =0"
        End If
        If CheckBox2.Checked = True Then
            commandStr += ", [TDH Coordinator] =1"
        End If

        If TextBox39.Text <> "" Then
            commandStr += ", [TDH C Received Date] ='" + TextBox39.Text + "'"
        End If

        If TextBox38.Text <> "" Then
            commandStr += ", [TDH C Expiration Date] ='" + TextBox38.Text + "'"
        End If

        If CheckBox3.Checked = False Then
            commandStr += ", [CPR] =0"
        End If
        If CheckBox3.Checked = True Then
            commandStr += ", [CPR] =1"
        End If

        If TextBox41.Text <> "" Then
            commandStr += ", [CPR Received Date] ='" + TextBox41.Text + "'"
        End If

        If TextBox40.Text <> "" Then
            commandStr += ", [CPR Expiration Date] ='" + TextBox40.Text + "'"
        End If

        If CheckBox4.Checked = False Then
            commandStr += ", [CPR Instructor] =0"
        End If
        If CheckBox4.Checked = True Then
            commandStr += ", [CPR Instructor] =1"
        End If

        If TextBox43.Text <> "" Then
            commandStr += ", [CPR I Received Date] ='" + TextBox43.Text + "'"
        End If

        If TextBox42.Text <> "" Then
            commandStr += ", [CPR I Expiration Date] ='" + TextBox42.Text + "'"
        End If

        If CheckBox5.Checked = False Then
            commandStr += ", [CPR I/T] =0"
        End If
        If CheckBox5.Checked = True Then
            commandStr += ", [CPR I/T] =1"
        End If

        If TextBox45.Text <> "" Then
            commandStr += ", [CPR I/T Received Date] ='" + TextBox45.Text + "'"
        End If

        If TextBox44.Text <> "" Then
            commandStr += ", [CPR I/T Expiration Date] ='" + TextBox44.Text + "'"
        End If

        If CheckBox6.Checked = False Then
            commandStr += ", [ACLS] =0"
        End If
        If CheckBox6.Checked = True Then
            commandStr += ", [ACLS] =1"
        End If

        If TextBox47.Text <> "" Then
            commandStr += ", [ACLS Received Date] ='" + TextBox47.Text + "'"
        End If

        If TextBox46.Text <> "" Then
            commandStr += ", [ACLS Expiration Date] ='" + TextBox46.Text + "'"
        End If

        If CheckBox7.Checked = False Then
            commandStr += ", [ACLS Instructor] =0"
        End If
        If CheckBox7.Checked = True Then
            commandStr += ", [ACLS Instructor] =1"
        End If

        If TextBox49.Text <> "" Then
            commandStr += ", [ACLS I Received Date] ='" + TextBox49.Text + "'"
        End If

        If TextBox48.Text <> "" Then
            commandStr += ", [ACLS I Expiration Date] ='" + TextBox48.Text + "'"
        End If

        If CheckBox14.Checked = False Then
            commandStr += ", [PALS] =0"
        End If
        If CheckBox14.Checked = True Then
            commandStr += ", [PALS] =1"
        End If

        If TextBox61.Text <> "" Then
            commandStr += ", [PALS Received Date] ='" + TextBox61.Text + "'"
        End If

        If TextBox60.Text <> "" Then
            commandStr += ", [PALS Expiration Date] ='" + TextBox60.Text + "'"
        End If

        If CheckBox12.Checked = False Then
            commandStr += ", [PPPC] =0"
        End If
        If CheckBox12.Checked = True Then
            commandStr += ", [PPPC] =1"
        End If

        If TextBox59.Text <> "" Then
            commandStr += ", [PPPC Received Date] ='" + TextBox59.Text + "'"
        End If

        If TextBox58.Text <> "" Then
            commandStr += ", [PPPC Expiration Date] ='" + TextBox58.Text + "'"
        End If

        If CheckBox11.Checked = False Then
            commandStr += ", [PHTLS] =0"
        End If
        If CheckBox11.Checked = True Then
            commandStr += ", [PHTLS] =1"
        End If

        If TextBox57.Text <> "" Then
            commandStr += ", [PHTLS Received Date] ='" + TextBox57.Text + "'"
        End If

        If TextBox56.Text <> "" Then
            commandStr += ", [PHTLS Expiration Date] ='" + TextBox56.Text + "'"
        End If

        If CheckBox10.Checked = False Then
            commandStr += ", [PHTLS Instructor] =0"
        End If
        If CheckBox10.Checked = True Then
            commandStr += ", [PHTLS Instructor] =1"
        End If

        If TextBox55.Text <> "" Then
            commandStr += ", [PHTLS Instructor Received Date] ='" + TextBox55.Text + "'"
        End If

        If TextBox54.Text <> "" Then
            commandStr += ", [PHTLS Instructor Expiration Date] ='" + TextBox54.Text + "'"
        End If

        If CheckBox9.Checked = False Then
            commandStr += ", [BTLS Provider] =0"
        End If
        If CheckBox9.Checked = True Then
            commandStr += ", [BTLS Provider] =1"
        End If

        If TextBox53.Text <> "" Then
            commandStr += ", [BTLS Provider Received Date] ='" + TextBox53.Text + "'"
        End If

        If TextBox52.Text <> "" Then
            commandStr += ", [BTLS Provider Expiration Date] ='" + TextBox52.Text + "'"
        End If

        If CheckBox8.Checked = False Then
            commandStr += ", [BTLS Instructor] =0"
        End If
        If CheckBox8.Checked = True Then
            commandStr += ", [BTLS Instructor] =1"
        End If

        If TextBox51.Text <> "" Then
            commandStr += ", [BTLS Instructor Received Date] ='" + TextBox51.Text + "'"
        End If

        If TextBox50.Text <> "" Then
            commandStr += ", [BTLS Instructor Expiration Date] ='" + TextBox50.Text + "'"
        End If

        commandStr += " WHERE [Employee_ID] =" + Emp_Textbox.Text
        Return commandStr
    End Function

    Function generateOtherCertQueryString() As String
        Dim commandStr As String
        commandStr = "UPDATE [Other Certifications] SET "

        If CheckBox18.Checked = False Then
            commandStr += "[TCLEOSE] =0"
        End If
        If CheckBox18.Checked = True Then
            commandStr += "[TCLEOSE] =1"
        End If

        If ComboBox10.Text <> "" Then
            commandStr += ", [TCLEOSE Level] = '" + ComboBox10.Text + "'"
        End If

        If TextBox63.Text <> "" Then
            commandStr += ", [TCLEOSE Received Date] = '" + TextBox63.Text + "'"
        End If

        If TextBox62.Text <> "" Then
            commandStr += ", [TCLEOSE Expiration Date] = '" + TextBox62.Text + "'"
        End If

        If CheckBox17.Checked = False Then
            commandStr += ", [SCUBA] =0"
        End If
        If CheckBox17.Checked = True Then
            commandStr += ", [SCUBA] =1"
        End If

        If ComboBox11.Text <> "" Then
            commandStr += ", [SCUBA Level] = '" + ComboBox11.Text + "'"
        End If

        If TextBox65.Text <> "" Then
            commandStr += ", [SCUBA Received Date] = '" + TextBox65.Text + "'"
        End If

        If TextBox64.Text <> "" Then
            commandStr += ", [SCUBA Expiration Date] = '" + TextBox64.Text + "'"
        End If

        If CheckBox16.Checked = False Then
            commandStr += ", [SCUBA Instructor] =0"
        End If
        If CheckBox16.Checked = True Then
            commandStr += ", [SCUBA Instructor] =1"
        End If

        If ComboBox12.Text <> "" Then
            commandStr += ", [SCUBA I Level] = '" + ComboBox12.Text + "'"
        End If

        If TextBox67.Text <> "" Then
            commandStr += ", [SCUBA I Received Date] = '" + TextBox67.Text + "'"
        End If

        If TextBox66.Text <> "" Then
            commandStr += ", [SCUBA I Expiration Date] = '" + TextBox66.Text + "'"
        End If

        If CheckBox15.Checked = False Then
            commandStr += ", [Rescue] =0"
        End If
        If CheckBox1.Checked = True Then
            commandStr += ", [Rescue] =1"
        End If

        If ComboBox13.Text <> "" Then
            commandStr += ", [Rescue Level] = '" + ComboBox13.Text + "'"
        End If

        If TextBox69.Text <> "" Then
            commandStr += ", [Rescue Received Date] = '" + TextBox69.Text + "'"
        End If

        If TextBox68.Text <> "" Then
            commandStr += ", [Rescue Expiration Date] = '" + TextBox68.Text + "'"
        End If

        commandStr += " WHERE [Employee_ID] = " + Emp_Textbox.Text
        Return commandStr
    End Function

    Function generateAssignmentQueryString() As String
        Dim commandStr As String
        commandStr = "UPDATE [Assignment Pay] SET "

        If CheckBox22.Checked = False Then
            commandStr += "[ARFF] =0"
        End If
        If CheckBox22.Checked = True Then
            commandStr += "[ARFF]=1"
        End If

        If TextBox70.Text <> "" Then
            commandStr += "[ARFF Received Date] = '" + TextBox70.Text + "'"
        End If

        If CheckBox21.Checked = False Then
            commandStr += ", [HazMat] =0"
        End If
        If CheckBox21.Checked = True Then
            commandStr += ", [HazMat]=1"
        End If

        If TextBox73.Text <> "" Then
            commandStr += ", [HazMat Received Date] = '" + TextBox73.Text + "'"
        End If

        If CheckBox20.Checked = False Then
            commandStr += ", [Arson] =0"
        End If
        If CheckBox20.Checked = True Then
            commandStr += ", [Arson]=1"
        End If

        If TextBox71.Text <> "" Then
            commandStr += ", [Arson Received Date] = '" + TextBox71.Text + "'"
        End If

        If CheckBox19.Checked = False Then
            commandStr += ", [FAA] =0"
        End If
        If CheckBox19.Checked = True Then
            commandStr += ", [FAA]=1"
        End If

        If TextBox72.Text <> "" Then
            commandStr += ", [FAA Received Date] = '" + TextBox72.Text + "'"
        End If

        commandStr += " WHERE [Employee_ID] =" + Emp_Textbox.Text
        Return commandStr
    End Function

    Private Sub AuthorizationFix(choice As Integer, AuthLvl As Integer)
        'Basic Authorization
        If (AuthLvl = 1) Then

            EmployeeInformationBindingSource.Position = EmployeeInformationBindingSource.Find("Employee_ID", employeeID)



            If choice = 0 Then
                EmpInfo.TabPages.RemoveAt(6)
                EmpInfo.TabPages.RemoveAt(5)
                EmpInfo.TabPages.RemoveAt(4)
                EmpInfo.TabPages.RemoveAt(3)
                EmpInfo.TabPages.RemoveAt(2)
                EmpInfo.TabPages.RemoveAt(1)

            ElseIf choice = 1 Then
                EmpInfo.TabPages.RemoveAt(6)
                EmpInfo.TabPages.RemoveAt(5)
                EmpInfo.TabPages.RemoveAt(4)
                EmpInfo.TabPages.RemoveAt(3)
                EmpInfo.TabPages.RemoveAt(2)
                EmpInfo.TabPages.RemoveAt(0)

            ElseIf choice = 2 Then
                EmpInfo.TabPages.RemoveAt(6)
                EmpInfo.TabPages.RemoveAt(5)
                EmpInfo.TabPages.RemoveAt(4)
                EmpInfo.TabPages.RemoveAt(3)
                EmpInfo.TabPages.RemoveAt(1)
                EmpInfo.TabPages.RemoveAt(0)

            ElseIf choice = 3 Then
                EmpInfo.TabPages.RemoveAt(6)
                EmpInfo.TabPages.RemoveAt(5)
                EmpInfo.TabPages.RemoveAt(4)
                EmpInfo.TabPages.RemoveAt(2)
                EmpInfo.TabPages.RemoveAt(1)
                EmpInfo.TabPages.RemoveAt(0)

            ElseIf choice = 4 Then
                EmpInfo.TabPages.RemoveAt(6)
                EmpInfo.TabPages.RemoveAt(5)
                EmpInfo.TabPages.RemoveAt(3)
                EmpInfo.TabPages.RemoveAt(2)
                EmpInfo.TabPages.RemoveAt(1)
                EmpInfo.TabPages.RemoveAt(0)

            ElseIf choice = 5 Then
                EmpInfo.TabPages.RemoveAt(6)
                EmpInfo.TabPages.RemoveAt(4)
                EmpInfo.TabPages.RemoveAt(3)
                EmpInfo.TabPages.RemoveAt(2)
                EmpInfo.TabPages.RemoveAt(1)
                EmpInfo.TabPages.RemoveAt(0)

            End If

            'get rid of their ability to edit data
            Next_Button.Visible = False
            Prev_Button.Visible = False
            DeleteButton.Visible = False
            Save_Button.Visible = False
            ALL_EMP_ReportButton.Visible = False
            EmployeeSearch.Visible = False
            Employee_List.Visible = False

        End If



    End Sub

    Private Sub All_Employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Assignment_PayTableAdapter.Fill(Me.Training_Records_for_TAMUDataSet.Assignment_Pay)
        Me.Other_CertificationsTableAdapter.Fill(Me.Training_Records_for_TAMUDataSet.Other_Certifications)
        Me.EMS_CertificationsTableAdapter.Fill(Me.Training_Records_for_TAMUDataSet.EMS_Certifications)
        Me.Fire_CertificationsTableAdapter.Fill(Me.Training_Records_for_TAMUDataSet.Fire_Certifications)
        Me.Employee_InformationTableAdapter.Fill(Me.Training_Records_for_TAMUDataSet.Employee_Information)


        Authorization_Level = Login.Authorization_LVL
        employeeID = Login.sharedUsername
        choice = BasicForm.tabSelect
        employeeName = Login.sharedName
        'Add this when we connect to the Fire Dept. DB

        EmployeeInformationBindingSource.Sort = "Name"

        AuthorizationFix(choice, Authorization_Level)

        'EmployeeInformationBindingSource.Position = EmployeeInformationBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString)
        FireCertificationsBindingSource.Position = FireCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        EMSCertificationsBindingSource.Position = EMSCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        OtherCertificationsBindingSource.Position = OtherCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        AssignmentPayBindingSource.Position = AssignmentPayBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        Me.CertificatesTableAdapter.FillByID(Me.Training_Records_for_TAMUDataSet.Certificates, Emp_Textbox.Text)


    End Sub


    Private Sub Emp_Name_Click(sender As Object, e As EventArgs)
        MsgBox("Access Level: " + Authorization_Level.ToString, MsgBoxStyle.Critical)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click

        If Authorization_Level = 4 Then
            Dim DevForm As DeveloperForm
            DevForm = New DeveloperForm()
            DevForm.Show()
            DevForm = Nothing
            Me.Close()
        ElseIf Authorization_Level = 3 Then
        ElseIf Authorization_Level = 2 Then
        ElseIf Authorization_Level = 1 Then
            Dim BaseForm As New BasicForm
            BaseForm = New BasicForm
            BaseForm.Show()
            BaseForm = Nothing
            Me.Close()
        End If

    End Sub


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

        Dim cmdString = generateEmpInfoQueryString()
        Dim fireString = generateFireCertQueryString()
        Dim EMSString = generateEMSCertQueryString()
        Dim OtherString = generateOtherCertQueryString()

        Try
            Dim Command = New OleDbCommand(cmdString, Dbconn)
            Command.ExecuteScalar()
            Command = New OleDbCommand(fireString, Dbconn)
            Command.ExecuteScalar()
            Command = New OleDbCommand(EMSString, Dbconn)
            Command.ExecuteScalar()
            Command = New OleDbCommand(OtherString, Dbconn)
            Command.ExecuteScalar()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Dbconn.Close()

        MsgBox("Your changes were successfully saved!!", MsgBoxStyle.Information, "Saved Changes")

    End Sub

    Private Sub Prev_Button_Click(sender As Object, e As EventArgs) Handles Prev_Button.Click
        EmployeeInformationBindingSource.MovePrevious()
        FireCertificationsBindingSource.Position = FireCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        EMSCertificationsBindingSource.Position = EMSCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        OtherCertificationsBindingSource.Position = OtherCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        AssignmentPayBindingSource.Position = AssignmentPayBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())

        currentID = Emp_Textbox.Text

    End Sub

    Private Sub Next_Button_Click(sender As Object, e As EventArgs) Handles Next_Button.Click
        EmployeeInformationBindingSource.MoveNext()
       
        FireCertificationsBindingSource.Position = FireCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        EMSCertificationsBindingSource.Position = EMSCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        OtherCertificationsBindingSource.Position = OtherCertificationsBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())
        AssignmentPayBindingSource.Position = AssignmentPayBindingSource.Find("Employee_ID", Emp_Textbox.Text.ToString())

        currentID = Emp_Textbox.Text
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

        Dim result As Integer = MessageBox.Show("Are you sure you want to delete the current record from the database?", " Confirm Deletion", MessageBoxButtons.YesNo)

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

            Dim emp_id = Emp_Textbox.Text

            Try
                Dim Command = New OleDbCommand("DELETE FROM [Employee Information] WHERE [Employee_ID]= " + emp_id, Dbconn)
                Command.ExecuteScalar()
                Command = New OleDbCommand("DELETE FROM [Fire Certifications] WHERE [Employee_ID]= " + emp_id, Dbconn)
                Command.ExecuteScalar()
                Command = New OleDbCommand("DELETE FROM [EMS Certifications] WHERE [Employee_ID]= " + emp_id, Dbconn)
                Command.ExecuteScalar()
                Command = New OleDbCommand("DELETE FROM [Other Certifications] WHERE [Employee_ID]= " + emp_id, Dbconn)
                Command.ExecuteScalar()
                Command = New OleDbCommand("DELETE FROM [Assignment Pay] WHERE [Employee_ID]= " + emp_id, Dbconn)
                Command.ExecuteScalar()
                Command = New OleDbCommand("DELETE FROM [Certificates] WHERE [Employee_ID]= " + emp_id, Dbconn)
                Command.ExecuteScalar()
                Command = New OleDbCommand("DELETE FROM [College] WHERE [Employee_ID]= " + emp_id, Dbconn)
                Command.ExecuteScalar()
            Catch ex As Exception
            End Try

            MessageBox.Show("The current record has been deleted.")

            Dim refreshDelete As New All_Employees()
            refreshDelete.Show()
            refreshDelete = Nothing
            Me.Close()

        End If


    End Sub

    Private Sub ALL_EMP_ReportButton_Click(sender As Object, e As EventArgs) Handles ALL_EMP_ReportButton.Click
        currentID = Convert.ToInt32(Emp_Textbox.Text)
        sendingForm = True
        Dim IndReport As Indivdual_Employee_Report_View
        IndReport = New Indivdual_Employee_Report_View()
        IndReport.Show()
        IndReport = Nothing
        sendingForm = True
    End Sub

    Private Sub NewItem_Click(sender As Object, e As EventArgs) Handles NewItem.Click
        Dim newID As String

        newID = InputBox("Please input the employee ID for the new user.")

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
            Dim Command = New OleDbCommand("INSERT INTO [Employee Information] ([Employee_ID]) VALUES ('" + newID + "')", Dbconn)
            Command.ExecuteScalar()
            Command = New OleDbCommand("INSERT INTO [Fire Certifications] ([Employee_ID]) VALUES ('" + newID + "')", Dbconn)
            Command.ExecuteScalar()
            Command = New OleDbCommand("INSERT INTO [EMS Certifications] ([Employee_ID]) VALUES ('" + newID + "')", Dbconn)
            Command.ExecuteScalar()
            Command = New OleDbCommand("INSERT INTO [Other Certifications] ([Employee_ID]) VALUES ('" + newID + "')", Dbconn)
            Command.ExecuteScalar()
            Command = New OleDbCommand("INSERT INTO [Assignment Pay] ([Employee_ID]) VALUES ('" + newID + "')", Dbconn)
            Command.ExecuteScalar()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        MsgBox("Please use the save button to enter information")

        Dbconn.Close()

        Dim refresh As New All_Employees
        refresh.Show()
        refresh = Nothing
        Me.Close()


    End Sub

    Private Sub Emp_Textbox_TextChanged(sender As Object, e As EventArgs) Handles Emp_Textbox.TextChanged
        If Emp_Textbox.Text <> "" Then
            Me.CertificatesTableAdapter.FillByID(Me.Training_Records_for_TAMUDataSet.Certificates, Emp_Textbox.Text)
        End If
    End Sub
End Class