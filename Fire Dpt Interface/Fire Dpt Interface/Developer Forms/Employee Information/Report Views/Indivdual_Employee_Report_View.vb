Imports Microsoft.Office.Interop.Access
Imports Microsoft.Reporting.WinForms



Public Class Indivdual_Employee_Report_View

    Private Sub TestReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'temp value needs to be SSN or ID of the user (pass through global variable)
        Dim ID As Integer = 106017362
        Dim nameparam As ReportParameter
        Dim addrparam As ReportParameter
        Dim phoneparam As ReportParameter
        Dim shiftparam As ReportParameter
        Dim dobparam As ReportParameter
        Dim ssnparam As ReportParameter
        Dim tdlparam As ReportParameter
        Dim dl_class_param As ReportParameter
        Dim cdlparam As ReportParameter
        Dim rankdateparam As ReportParameter
        Dim hiredateparam As ReportParameter
        Dim employee_data As DataTable

        Dim name As String
        Dim addr As String
        Dim phone As String
        Dim shift As String
        Dim dob As String
        Dim ssn As String
        Dim tdl As String
        Dim dl_class As String
        Dim cdl As String
        Dim rankdate As String
        Dim hiredate As String

        QueryEmployeeInformationTableAdapter.FillEmployeeName(Me.Query_Indivual_Employee.QueryEmployeeInformation, ID)
        employee_data = QueryEmployeeInformationTableAdapter.GetEmployeeName(ID)

        name = employee_data.Rows(0).Item(0).ToString()
        addr = employee_data.Rows(0).Item(1).ToString()
        phone = employee_data.Rows(0).Item(10).ToString()
        shift = employee_data.Rows(0).Item(6).ToString()
        dob = employee_data.Rows(0).Item(5).ToString()
        ssn = employee_data.Rows(0).Item(9).ToString()
        tdl = employee_data.Rows(0).Item(2).ToString()
        dl_class = employee_data.Rows(0).Item(4).ToString()
        cdl = employee_data.Rows(0).Item(3).ToString()
        rankdate = employee_data.Rows(0).Item(8).ToString()
        hiredate = employee_data.Rows(0).Item(7).ToString()


        If name = Nothing Then
            nameparam = New ReportParameter("EmployeeName", "null")
        Else
            nameparam = New ReportParameter("EmployeeName", name)
        End If

        If addr = Nothing Then
            addrparam = New ReportParameter("Address", "null")
        Else
            addrparam = New ReportParameter("Address", addr)
        End If

        If phone = Nothing Then
            phoneparam = New ReportParameter("Phone", "null")
        Else
            phoneparam = New ReportParameter("Phone", phone)
        End If

        If shift = Nothing Then
            shiftparam = New ReportParameter("Shift", "null")
        Else
            shiftparam = New ReportParameter("Shift", shift)
        End If

        If dob = Nothing Then
            dobparam = New ReportParameter("DOB", "null")
        Else
            dobparam = New ReportParameter("DOB", dob)
        End If

        If ssn = Nothing Then
            ssnparam = New ReportParameter("SSN", "null")
        Else
            ssnparam = New ReportParameter("SSN", ssn)
        End If

        If tdl = Nothing Then
            tdlparam = New ReportParameter("TDL", "null")
        Else
            tdlparam = New ReportParameter("TDL", tdl)
        End If

        If phone = Nothing Then
            dl_class_param = New ReportParameter("DLCLASS", "null")
        Else
            dl_class_param = New ReportParameter("DLCLASS", dl_class)
        End If

        If cdl = Nothing Then
            cdlparam = New ReportParameter("CDL", "null")
        Else
            cdlparam = New ReportParameter("CDL", cdl)
        End If

        If rankdate = Nothing Then
            rankdateparam = New ReportParameter("RankDate", "null")
        Else
            rankdateparam = New ReportParameter("RankDate", rankdate)
        End If

        If hiredate = Nothing Then
            hiredateparam = New ReportParameter("HireDate", "null")
        Else
            hiredateparam = New ReportParameter("HireDate", hiredate)
        End If


        Me.ReportViewer1.LocalReport.SetParameters(nameparam)
        Me.ReportViewer1.LocalReport.SetParameters(addrparam)
        Me.ReportViewer1.LocalReport.SetParameters(phoneparam)
        Me.ReportViewer1.LocalReport.SetParameters(shiftparam)
        Me.ReportViewer1.LocalReport.SetParameters(dobparam)
        Me.ReportViewer1.LocalReport.SetParameters(ssnparam)
        Me.ReportViewer1.LocalReport.SetParameters(tdlparam)
        Me.ReportViewer1.LocalReport.SetParameters(dl_class_param)
        Me.ReportViewer1.LocalReport.SetParameters(cdlparam)
        Me.ReportViewer1.LocalReport.SetParameters(rankdateparam)
        Me.ReportViewer1.LocalReport.SetParameters(hiredateparam)
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class