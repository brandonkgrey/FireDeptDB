<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Single_User_Information
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Training_RecordsDataSet = New Fire_Dpt_Interface.Training_RecordsDataSet()
        Me.Emp_Name = New System.Windows.Forms.Label()
        Me.Emp_ID = New System.Windows.Forms.Label()
        Me.Name_Textbox = New System.Windows.Forms.TextBox()
        Me.Emp_Textbox = New System.Windows.Forms.TextBox()
        Me.Address_Label = New System.Windows.Forms.Label()
        Me.Address_TextBox = New System.Windows.Forms.TextBox()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.City_Textbox = New System.Windows.Forms.TextBox()
        Me.State_Label = New System.Windows.Forms.Label()
        Me.State_Textbox = New System.Windows.Forms.TextBox()
        Me.Zip_Label = New System.Windows.Forms.Label()
        Me.Zip_Textbox = New System.Windows.Forms.TextBox()
        Me.Phone_Label = New System.Windows.Forms.Label()
        Me.Phone_Textbox = New System.Windows.Forms.TextBox()
        Me.DOB_Label = New System.Windows.Forms.Label()
        Me.DOB_Textbox = New System.Windows.Forms.TextBox()
        Me.TDL_Label = New System.Windows.Forms.Label()
        Me.TDL_Textbox = New System.Windows.Forms.TextBox()
        Me.DL_Class_Label = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.CDL_Label = New System.Windows.Forms.Label()
        Me.CDL_Checkbox = New System.Windows.Forms.CheckBox()
        Me.ShiftLabel = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TCFP_PIN_Label = New System.Windows.Forms.Label()
        Me.HireDateLabel = New System.Windows.Forms.Label()
        Me.RankLabel = New System.Windows.Forms.Label()
        Me.RankDateLabel = New System.Windows.Forms.Label()
        Me.TDH_ID_Label = New System.Windows.Forms.Label()
        Me.DivisionLabel = New System.Windows.Forms.Label()
        Me.NonOpsLabel = New System.Windows.Forms.Label()
        Me.MainMenuButton = New System.Windows.Forms.Button()
        Me.HireDate_Textbox = New System.Windows.Forms.TextBox()
        Me.Rank_Textbox = New System.Windows.Forms.TextBox()
        Me.RankDate_Textbox = New System.Windows.Forms.TextBox()
        Me.EndDateLabel = New System.Windows.Forms.Label()
        Me.EndDate_Textbox = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Shift_TextBox = New System.Windows.Forms.TextBox()
        Me.Division_Textbox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.Training_RecordsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Training_RecordsDataSet
        '
        Me.Training_RecordsDataSet.DataSetName = "Training_RecordsDataSet"
        Me.Training_RecordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Emp_Name
        '
        Me.Emp_Name.AutoSize = True
        Me.Emp_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_Name.Location = New System.Drawing.Point(24, 22)
        Me.Emp_Name.Name = "Emp_Name"
        Me.Emp_Name.Size = New System.Drawing.Size(86, 31)
        Me.Emp_Name.TabIndex = 0
        Me.Emp_Name.Text = "Name"
        '
        'Emp_ID
        '
        Me.Emp_ID.AutoSize = True
        Me.Emp_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_ID.Location = New System.Drawing.Point(475, 22)
        Me.Emp_ID.Name = "Emp_ID"
        Me.Emp_ID.Size = New System.Drawing.Size(169, 31)
        Me.Emp_ID.TabIndex = 1
        Me.Emp_ID.Text = "Employee ID"
        '
        'Name_Textbox
        '
        Me.Name_Textbox.BackColor = System.Drawing.SystemColors.Window
        Me.Name_Textbox.Location = New System.Drawing.Point(106, 33)
        Me.Name_Textbox.Name = "Name_Textbox"
        Me.Name_Textbox.ReadOnly = True
        Me.Name_Textbox.Size = New System.Drawing.Size(208, 20)
        Me.Name_Textbox.TabIndex = 2
        '
        'Emp_Textbox
        '
        Me.Emp_Textbox.BackColor = System.Drawing.SystemColors.Window
        Me.Emp_Textbox.Location = New System.Drawing.Point(650, 33)
        Me.Emp_Textbox.Name = "Emp_Textbox"
        Me.Emp_Textbox.ReadOnly = True
        Me.Emp_Textbox.Size = New System.Drawing.Size(208, 20)
        Me.Emp_Textbox.TabIndex = 3
        '
        'Address_Label
        '
        Me.Address_Label.AutoSize = True
        Me.Address_Label.BackColor = System.Drawing.Color.Silver
        Me.Address_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address_Label.Location = New System.Drawing.Point(25, 83)
        Me.Address_Label.Name = "Address_Label"
        Me.Address_Label.Size = New System.Drawing.Size(91, 25)
        Me.Address_Label.TabIndex = 4
        Me.Address_Label.Text = "Address"
        '
        'Address_TextBox
        '
        Me.Address_TextBox.BackColor = System.Drawing.SystemColors.Window
        Me.Address_TextBox.Location = New System.Drawing.Point(142, 88)
        Me.Address_TextBox.Name = "Address_TextBox"
        Me.Address_TextBox.ReadOnly = True
        Me.Address_TextBox.Size = New System.Drawing.Size(172, 20)
        Me.Address_TextBox.TabIndex = 5
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityLabel.Location = New System.Drawing.Point(332, 27)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(49, 25)
        Me.CityLabel.TabIndex = 6
        Me.CityLabel.Text = "City"
        '
        'City_Textbox
        '
        Me.City_Textbox.BackColor = System.Drawing.SystemColors.Window
        Me.City_Textbox.Location = New System.Drawing.Point(447, 28)
        Me.City_Textbox.Name = "City_Textbox"
        Me.City_Textbox.ReadOnly = True
        Me.City_Textbox.Size = New System.Drawing.Size(114, 20)
        Me.City_Textbox.TabIndex = 7
        '
        'State_Label
        '
        Me.State_Label.AutoSize = True
        Me.State_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.State_Label.Location = New System.Drawing.Point(634, 28)
        Me.State_Label.Name = "State_Label"
        Me.State_Label.Size = New System.Drawing.Size(62, 25)
        Me.State_Label.TabIndex = 8
        Me.State_Label.Text = "State"
        '
        'State_Textbox
        '
        Me.State_Textbox.BackColor = System.Drawing.SystemColors.Window
        Me.State_Textbox.Location = New System.Drawing.Point(771, 33)
        Me.State_Textbox.Name = "State_Textbox"
        Me.State_Textbox.ReadOnly = True
        Me.State_Textbox.Size = New System.Drawing.Size(101, 20)
        Me.State_Textbox.TabIndex = 9
        '
        'Zip_Label
        '
        Me.Zip_Label.AutoSize = True
        Me.Zip_Label.BackColor = System.Drawing.Color.Silver
        Me.Zip_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Zip_Label.Location = New System.Drawing.Point(25, 128)
        Me.Zip_Label.Name = "Zip_Label"
        Me.Zip_Label.Size = New System.Drawing.Size(99, 25)
        Me.Zip_Label.TabIndex = 10
        Me.Zip_Label.Text = "Zip Code"
        '
        'Zip_Textbox
        '
        Me.Zip_Textbox.BackColor = System.Drawing.SystemColors.Window
        Me.Zip_Textbox.Location = New System.Drawing.Point(119, 72)
        Me.Zip_Textbox.Name = "Zip_Textbox"
        Me.Zip_Textbox.ReadOnly = True
        Me.Zip_Textbox.Size = New System.Drawing.Size(119, 20)
        Me.Zip_Textbox.TabIndex = 11
        '
        'Phone_Label
        '
        Me.Phone_Label.AutoSize = True
        Me.Phone_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone_Label.Location = New System.Drawing.Point(332, 67)
        Me.Phone_Label.Name = "Phone_Label"
        Me.Phone_Label.Size = New System.Drawing.Size(74, 25)
        Me.Phone_Label.TabIndex = 12
        Me.Phone_Label.Text = "Phone"
        '
        'Phone_Textbox
        '
        Me.Phone_Textbox.BackColor = System.Drawing.SystemColors.Window
        Me.Phone_Textbox.Location = New System.Drawing.Point(447, 73)
        Me.Phone_Textbox.Name = "Phone_Textbox"
        Me.Phone_Textbox.ReadOnly = True
        Me.Phone_Textbox.Size = New System.Drawing.Size(114, 20)
        Me.Phone_Textbox.TabIndex = 13
        '
        'DOB_Label
        '
        Me.DOB_Label.AutoSize = True
        Me.DOB_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOB_Label.Location = New System.Drawing.Point(634, 72)
        Me.DOB_Label.Name = "DOB_Label"
        Me.DOB_Label.Size = New System.Drawing.Size(131, 25)
        Me.DOB_Label.TabIndex = 14
        Me.DOB_Label.Text = "Date of Birth"
        '
        'DOB_Textbox
        '
        Me.DOB_Textbox.BackColor = System.Drawing.SystemColors.Window
        Me.DOB_Textbox.Location = New System.Drawing.Point(771, 72)
        Me.DOB_Textbox.Name = "DOB_Textbox"
        Me.DOB_Textbox.ReadOnly = True
        Me.DOB_Textbox.Size = New System.Drawing.Size(101, 20)
        Me.DOB_Textbox.TabIndex = 15
        '
        'TDL_Label
        '
        Me.TDL_Label.AutoSize = True
        Me.TDL_Label.BackColor = System.Drawing.Color.Silver
        Me.TDL_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDL_Label.Location = New System.Drawing.Point(25, 180)
        Me.TDL_Label.Name = "TDL_Label"
        Me.TDL_Label.Size = New System.Drawing.Size(52, 25)
        Me.TDL_Label.TabIndex = 16
        Me.TDL_Label.Text = "TDL"
        '
        'TDL_Textbox
        '
        Me.TDL_Textbox.BackColor = System.Drawing.SystemColors.Window
        Me.TDL_Textbox.Location = New System.Drawing.Point(120, 124)
        Me.TDL_Textbox.Name = "TDL_Textbox"
        Me.TDL_Textbox.ReadOnly = True
        Me.TDL_Textbox.Size = New System.Drawing.Size(118, 20)
        Me.TDL_Textbox.TabIndex = 17
        '
        'DL_Class_Label
        '
        Me.DL_Class_Label.AutoSize = True
        Me.DL_Class_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DL_Class_Label.Location = New System.Drawing.Point(332, 118)
        Me.DL_Class_Label.Name = "DL_Class_Label"
        Me.DL_Class_Label.Size = New System.Drawing.Size(99, 25)
        Me.DL_Class_Label.TabIndex = 18
        Me.DL_Class_Label.Text = "DL Class"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox2.Location = New System.Drawing.Point(447, 123)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(114, 20)
        Me.TextBox2.TabIndex = 19
        '
        'CDL_Label
        '
        Me.CDL_Label.AutoSize = True
        Me.CDL_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CDL_Label.Location = New System.Drawing.Point(634, 124)
        Me.CDL_Label.Name = "CDL_Label"
        Me.CDL_Label.Size = New System.Drawing.Size(54, 25)
        Me.CDL_Label.TabIndex = 20
        Me.CDL_Label.Text = "CDL"
        '
        'CDL_Checkbox
        '
        Me.CDL_Checkbox.AutoCheck = False
        Me.CDL_Checkbox.AutoSize = True
        Me.CDL_Checkbox.Location = New System.Drawing.Point(772, 129)
        Me.CDL_Checkbox.Name = "CDL_Checkbox"
        Me.CDL_Checkbox.Size = New System.Drawing.Size(15, 14)
        Me.CDL_Checkbox.TabIndex = 21
        Me.CDL_Checkbox.UseVisualStyleBackColor = True
        '
        'ShiftLabel
        '
        Me.ShiftLabel.AutoSize = True
        Me.ShiftLabel.BackColor = System.Drawing.Color.Silver
        Me.ShiftLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShiftLabel.Location = New System.Drawing.Point(3, 272)
        Me.ShiftLabel.Name = "ShiftLabel"
        Me.ShiftLabel.Size = New System.Drawing.Size(55, 25)
        Me.ShiftLabel.TabIndex = 22
        Me.ShiftLabel.Text = "Shift"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox3.Location = New System.Drawing.Point(120, 176)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(118, 20)
        Me.TextBox3.TabIndex = 23
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox4.Location = New System.Drawing.Point(447, 175)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(114, 20)
        Me.TextBox4.TabIndex = 24
        '
        'TCFP_PIN_Label
        '
        Me.TCFP_PIN_Label.AutoSize = True
        Me.TCFP_PIN_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCFP_PIN_Label.Location = New System.Drawing.Point(332, 170)
        Me.TCFP_PIN_Label.Name = "TCFP_PIN_Label"
        Me.TCFP_PIN_Label.Size = New System.Drawing.Size(107, 25)
        Me.TCFP_PIN_Label.TabIndex = 25
        Me.TCFP_PIN_Label.Text = "TCFP PIN"
        '
        'HireDateLabel
        '
        Me.HireDateLabel.AutoSize = True
        Me.HireDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HireDateLabel.Location = New System.Drawing.Point(634, 171)
        Me.HireDateLabel.Name = "HireDateLabel"
        Me.HireDateLabel.Size = New System.Drawing.Size(102, 25)
        Me.HireDateLabel.TabIndex = 26
        Me.HireDateLabel.Text = "Hire Date"
        '
        'RankLabel
        '
        Me.RankLabel.AutoSize = True
        Me.RankLabel.BackColor = System.Drawing.Color.Silver
        Me.RankLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RankLabel.Location = New System.Drawing.Point(3, 220)
        Me.RankLabel.Name = "RankLabel"
        Me.RankLabel.Size = New System.Drawing.Size(62, 25)
        Me.RankLabel.TabIndex = 29
        Me.RankLabel.Text = "Rank"
        '
        'RankDateLabel
        '
        Me.RankDateLabel.AutoSize = True
        Me.RankDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RankDateLabel.Location = New System.Drawing.Point(333, 217)
        Me.RankDateLabel.Name = "RankDateLabel"
        Me.RankDateLabel.Size = New System.Drawing.Size(113, 25)
        Me.RankDateLabel.TabIndex = 30
        Me.RankDateLabel.Text = "Rank Date"
        '
        'TDH_ID_Label
        '
        Me.TDH_ID_Label.AutoSize = True
        Me.TDH_ID_Label.BackColor = System.Drawing.Color.Silver
        Me.TDH_ID_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDH_ID_Label.Location = New System.Drawing.Point(25, 232)
        Me.TDH_ID_Label.Name = "TDH_ID_Label"
        Me.TDH_ID_Label.Size = New System.Drawing.Size(81, 25)
        Me.TDH_ID_Label.TabIndex = 31
        Me.TDH_ID_Label.Text = "TDH ID"
        '
        'DivisionLabel
        '
        Me.DivisionLabel.AutoSize = True
        Me.DivisionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DivisionLabel.Location = New System.Drawing.Point(333, 272)
        Me.DivisionLabel.Name = "DivisionLabel"
        Me.DivisionLabel.Size = New System.Drawing.Size(88, 25)
        Me.DivisionLabel.TabIndex = 32
        Me.DivisionLabel.Text = "Division"
        '
        'NonOpsLabel
        '
        Me.NonOpsLabel.AutoSize = True
        Me.NonOpsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NonOpsLabel.Location = New System.Drawing.Point(639, 272)
        Me.NonOpsLabel.Name = "NonOpsLabel"
        Me.NonOpsLabel.Size = New System.Drawing.Size(97, 25)
        Me.NonOpsLabel.TabIndex = 33
        Me.NonOpsLabel.Text = "Non-Ops"
        '
        'MainMenuButton
        '
        Me.MainMenuButton.Location = New System.Drawing.Point(895, 416)
        Me.MainMenuButton.Name = "MainMenuButton"
        Me.MainMenuButton.Size = New System.Drawing.Size(82, 25)
        Me.MainMenuButton.TabIndex = 36
        Me.MainMenuButton.Text = "Back"
        Me.MainMenuButton.UseVisualStyleBackColor = True
        '
        'HireDate_Textbox
        '
        Me.HireDate_Textbox.BackColor = System.Drawing.SystemColors.Window
        Me.HireDate_Textbox.Location = New System.Drawing.Point(771, 177)
        Me.HireDate_Textbox.Name = "HireDate_Textbox"
        Me.HireDate_Textbox.ReadOnly = True
        Me.HireDate_Textbox.Size = New System.Drawing.Size(101, 20)
        Me.HireDate_Textbox.TabIndex = 37
        '
        'Rank_Textbox
        '
        Me.Rank_Textbox.BackColor = System.Drawing.SystemColors.Window
        Me.Rank_Textbox.Location = New System.Drawing.Point(121, 223)
        Me.Rank_Textbox.Name = "Rank_Textbox"
        Me.Rank_Textbox.ReadOnly = True
        Me.Rank_Textbox.Size = New System.Drawing.Size(117, 20)
        Me.Rank_Textbox.TabIndex = 38
        '
        'RankDate_Textbox
        '
        Me.RankDate_Textbox.BackColor = System.Drawing.SystemColors.Window
        Me.RankDate_Textbox.Location = New System.Drawing.Point(448, 220)
        Me.RankDate_Textbox.Name = "RankDate_Textbox"
        Me.RankDate_Textbox.ReadOnly = True
        Me.RankDate_Textbox.Size = New System.Drawing.Size(114, 20)
        Me.RankDate_Textbox.TabIndex = 39
        '
        'EndDateLabel
        '
        Me.EndDateLabel.AutoSize = True
        Me.EndDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndDateLabel.Location = New System.Drawing.Point(635, 217)
        Me.EndDateLabel.Name = "EndDateLabel"
        Me.EndDateLabel.Size = New System.Drawing.Size(101, 25)
        Me.EndDateLabel.TabIndex = 40
        Me.EndDateLabel.Text = "End Date"
        '
        'EndDate_Textbox
        '
        Me.EndDate_Textbox.BackColor = System.Drawing.SystemColors.Window
        Me.EndDate_Textbox.Location = New System.Drawing.Point(772, 220)
        Me.EndDate_Textbox.Name = "EndDate_Textbox"
        Me.EndDate_Textbox.ReadOnly = True
        Me.EndDate_Textbox.Size = New System.Drawing.Size(101, 20)
        Me.EndDate_Textbox.TabIndex = 41
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoCheck = False
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(771, 278)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 42
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Shift_TextBox
        '
        Me.Shift_TextBox.BackColor = System.Drawing.SystemColors.Window
        Me.Shift_TextBox.Location = New System.Drawing.Point(121, 275)
        Me.Shift_TextBox.Name = "Shift_TextBox"
        Me.Shift_TextBox.ReadOnly = True
        Me.Shift_TextBox.Size = New System.Drawing.Size(117, 20)
        Me.Shift_TextBox.TabIndex = 43
        '
        'Division_Textbox
        '
        Me.Division_Textbox.BackColor = System.Drawing.SystemColors.Window
        Me.Division_Textbox.Location = New System.Drawing.Point(447, 275)
        Me.Division_Textbox.Name = "Division_Textbox"
        Me.Division_Textbox.ReadOnly = True
        Me.Division_Textbox.Size = New System.Drawing.Size(114, 20)
        Me.Division_Textbox.TabIndex = 44
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Division_Textbox)
        Me.Panel1.Controls.Add(Me.State_Label)
        Me.Panel1.Controls.Add(Me.ShiftLabel)
        Me.Panel1.Controls.Add(Me.Zip_Textbox)
        Me.Panel1.Controls.Add(Me.RankLabel)
        Me.Panel1.Controls.Add(Me.RankDate_Textbox)
        Me.Panel1.Controls.Add(Me.EndDateLabel)
        Me.Panel1.Controls.Add(Me.EndDate_Textbox)
        Me.Panel1.Controls.Add(Me.DivisionLabel)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.Shift_TextBox)
        Me.Panel1.Controls.Add(Me.RankDateLabel)
        Me.Panel1.Controls.Add(Me.State_Textbox)
        Me.Panel1.Controls.Add(Me.HireDate_Textbox)
        Me.Panel1.Controls.Add(Me.TCFP_PIN_Label)
        Me.Panel1.Controls.Add(Me.DOB_Label)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.DOB_Textbox)
        Me.Panel1.Controls.Add(Me.TDL_Textbox)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.DL_Class_Label)
        Me.Panel1.Controls.Add(Me.NonOpsLabel)
        Me.Panel1.Controls.Add(Me.Rank_Textbox)
        Me.Panel1.Controls.Add(Me.Phone_Textbox)
        Me.Panel1.Controls.Add(Me.HireDateLabel)
        Me.Panel1.Controls.Add(Me.Phone_Label)
        Me.Panel1.Controls.Add(Me.CDL_Label)
        Me.Panel1.Controls.Add(Me.CDL_Checkbox)
        Me.Panel1.Controls.Add(Me.CityLabel)
        Me.Panel1.Controls.Add(Me.City_Textbox)
        Me.Panel1.Location = New System.Drawing.Point(21, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(956, 333)
        Me.Panel1.TabIndex = 45
        '
        'Single_User_Information
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 453)
        Me.Controls.Add(Me.MainMenuButton)
        Me.Controls.Add(Me.TDH_ID_Label)
        Me.Controls.Add(Me.TDL_Label)
        Me.Controls.Add(Me.Zip_Label)
        Me.Controls.Add(Me.Address_TextBox)
        Me.Controls.Add(Me.Address_Label)
        Me.Controls.Add(Me.Emp_Textbox)
        Me.Controls.Add(Me.Name_Textbox)
        Me.Controls.Add(Me.Emp_ID)
        Me.Controls.Add(Me.Emp_Name)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Single_User_Information"
        Me.Text = "My Information"
        CType(Me.Training_RecordsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Training_RecordsDataSet As Fire_Dpt_Interface.Training_RecordsDataSet
    Friend WithEvents Emp_Name As System.Windows.Forms.Label
    Friend WithEvents Emp_ID As System.Windows.Forms.Label
    Friend WithEvents Name_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Emp_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Address_Label As System.Windows.Forms.Label
    Friend WithEvents Address_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityLabel As System.Windows.Forms.Label
    Friend WithEvents City_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents State_Label As System.Windows.Forms.Label
    Friend WithEvents State_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Zip_Label As System.Windows.Forms.Label
    Friend WithEvents Zip_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Phone_Label As System.Windows.Forms.Label
    Friend WithEvents Phone_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents DOB_Label As System.Windows.Forms.Label
    Friend WithEvents DOB_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents TDL_Label As System.Windows.Forms.Label
    Friend WithEvents TDL_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents DL_Class_Label As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents CDL_Label As System.Windows.Forms.Label
    Friend WithEvents CDL_Checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents ShiftLabel As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TCFP_PIN_Label As System.Windows.Forms.Label
    Friend WithEvents HireDateLabel As System.Windows.Forms.Label
    Friend WithEvents RankLabel As System.Windows.Forms.Label
    Friend WithEvents RankDateLabel As System.Windows.Forms.Label
    Friend WithEvents TDH_ID_Label As System.Windows.Forms.Label
    Friend WithEvents DivisionLabel As System.Windows.Forms.Label
    Friend WithEvents NonOpsLabel As System.Windows.Forms.Label
    Friend WithEvents MainMenuButton As System.Windows.Forms.Button
    Friend WithEvents HireDate_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Rank_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents RankDate_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents EndDateLabel As System.Windows.Forms.Label
    Friend WithEvents EndDate_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Shift_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Division_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
