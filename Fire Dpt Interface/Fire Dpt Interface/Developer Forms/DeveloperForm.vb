﻿

Public Class DeveloperForm

    Dim EmpMenu As All_Employees = New All_Employees()

    Private Sub DeveloperForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Welcome " + Login.sharedUsername

    End Sub

    Private Sub Emp_Info_Button_Click(sender As Object, e As EventArgs) Handles Emp_Info_Button.Click

        EmpMenu.Show()
        EmpMenu = Nothing
        Me.Close()
    End Sub

    Private Sub LogOut_Button_Click(sender As Object, e As EventArgs) Handles LogOut_Button.Click
        Dim LoginMenu As Login
        LoginMenu = New Login()
        LoginMenu.Show()
        LoginMenu = Nothing
        Me.Close()
    End Sub

    Private Sub Class_Information_Button_Click(sender As Object, e As EventArgs) Handles Class_Information_Button.Click
        Dim ClassInfoMenu As Developer_Class_Information = New Developer_Class_Information()
        ClassInfoMenu.Show()
        ClassInfoMenu = Nothing
        Me.Close()
    End Sub

    Private Sub OpenAccessFileDFButton_Click(sender As Object, e As EventArgs) Handles OpenAccessFileDFButton.Click

    End Sub
End Class