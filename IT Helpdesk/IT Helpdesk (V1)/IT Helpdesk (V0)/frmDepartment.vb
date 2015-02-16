Imports System.Text.RegularExpressions
Public Class frmDepartment
    Dim ID As Integer
    Dim Employees() As Integer
    Dim MyEmployees As Integer
    Dim Valid As Boolean
    Dim InvalidString As String

    Private Sub DepartmentEdit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If frmMain.Cause = "NEW" Then
            Me.Text = "New Department"
            txtID.Text = NoOfDepartments + 1
            txtID.Enabled = False
        ElseIf frmMain.Cause = "EDIT" Then
            ID = frmMain.RecordN
            If NoOfEmployees = 0 Then
                Me.Text = "New Department"
                frmMain.Cause = "NEW"
                txtID.Text = NoOfEmployees + 1
                txtID.Enabled = False
            Else
                Me.Text = "Employee Edit"
                txtID.Text = Department(ID).ID
                txtDepName.Text = Department(ID).Name
                txtPhoneNo.Text = Department(ID).PhoneNo
                txtAddress.Text = Department(ID).Address
                txtTown.Text = Department(ID).Town
                txtCounty.Text = Department(ID).County
                txtPostCode.Text = Department(ID).Postcode
                If Department(ID).Internal = "True" Then
                    cbInternal.Checked = True
                Else
                    cbInternal.Checked = False
                End If
                MyEmployees = 0
                lbMemb.Items.Clear()
                For C = 1 To NoOfEmployees
                    If Employee(C).DepartmentID = ID Then
                        MyEmployees += 1
                        ReDim Employees(MyEmployees)
                        Employees(MyEmployees) = C
                        lbMemb.Items.Add(Employee(C).FirstName & " " & Employee(C).LastName)
                    End If
                Next
            End If
        ElseIf frmMain.Cause = "VIEW" Then
            ID = frmMain.RecordN
            Me.Text = "Employee View"
            txtID.Text = Department(ID).ID
            txtDepName.Text = Department(ID).Name
            txtPhoneNo.Text = Department(ID).PhoneNo
            txtAddress.Text = Department(ID).Address
            txtTown.Text = Department(ID).Town
            txtCounty.Text = Department(ID).County
            txtPostCode.Text = Department(ID).Postcode
            If Department(ID).Internal = "True" Then
                cbInternal.Checked = True
            Else
                cbInternal.Checked = False
            End If
            MyEmployees = 0
            lbMemb.Items.Clear()
            For C = 1 To NoOfEmployees
                If Employee(C).DepartmentID = ID Then
                    MyEmployees += 1
                    ReDim Employees(MyEmployees)
                    Employees(MyEmployees) = C
                    lbMemb.Items.Add(Employee(C).FirstName & " " & Employee(C).LastName)
                End If
            Next
            txtID.Enabled = True
            txtDepName.Enabled = False
            txtPhoneNo.Enabled = False
            txtAddress.Enabled = False
            txtTown.Enabled = False
            txtCounty.Enabled = False
            txtPostCode.Enabled = False
            cbInternal.Enabled = False
            btnDepArchive.Enabled = False
            btnDepSave.Enabled = False
        End If
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDepSave.Click
        If frmMain.Cause = "NEW" Then
            ValidateMe()
            If Valid Then
                AddDepartment(txtDepName.Text, txtPhoneNo.Text, txtAddress.Text, txtTown.Text, txtCounty.Text, txtPostCode.Text, cbInternal.Checked)
                Me.Close()
            Else
                MsgBox("One or more items of data you are trying to input is invalid. The errors are listed below..." & vbNewLine & vbNewLine & InvalidString, MsgBoxStyle.Exclamation, "Data is Invalid")
            End If
        Else
            ValidateMe()
            If Valid = False Then
                Department(ID).Name = txtDepName.Text
                Department(ID).PhoneNo = txtPhoneNo.Text
                Department(ID).Address = txtAddress.Text
                Department(ID).Town = txtTown.Text
                Department(ID).County = txtCounty.Text
                Department(ID).Postcode = txtPostCode.Text
                Department(ID).Internal = cbInternal.Checked
                SaveDepartments()
            Else
                MsgBox("One or more items of data you are trying to input is invalid. The errors are listed below..." & vbNewLine & vbNewLine & InvalidString, MsgBoxStyle.Exclamation, "Data is Invalid")
            End If
        End If
    End Sub
    Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.TextChanged
        If Val(txtID.Text) = 0 Then
        ElseIf Val(txtID.Text) <= NoOfDepartments Then
            Try
                ID = Val(txtID.Text)
                txtID.Text = Department(ID).ID
                txtDepName.Text = Department(ID).Name
                txtPhoneNo.Text = Department(ID).PhoneNo
                txtAddress.Text = Department(ID).Address
                txtTown.Text = Department(ID).Town
                txtCounty.Text = Department(ID).County
                txtPostCode.Text = Department(ID).Postcode
                If Department(ID).Internal = "True" Then
                    cbInternal.Checked = True
                Else
                    cbInternal.Checked = False
                End If
                MyEmployees = 0
                lbMemb.Items.Clear()
                For C = 1 To NoOfEmployees
                    If Employee(C).DepartmentID = ID Then
                        MyEmployees += 1
                        ReDim Employees(MyEmployees)
                        Employees(MyEmployees) = C
                        lbMemb.Items.Add(Employee(C).FirstName & " " & Employee(C).LastName)
                    End If
                Next
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub btnDepArchive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDepArchive.Click
        Department(ID).Archived = True
        SaveDepartments()
    End Sub
    Sub ValidateMe()
        Valid = True
        InvalidString = ""
        'Checks to see if all the required information has been inputted
        If txtDepName.Text = "" Then
            InvalidString = InvalidString & "No Department Name Provided" & vbNewLine
            Valid = False
        End If
        If txtPhoneNo.Text = "" Then
            InvalidString = InvalidString & "No Phone Number Provided" & vbNewLine
            Valid = False
        Else
            If Not IsNumeric(Replace(txtPhoneNo.Text, " ", "")) Or (txtPhoneNo.Text.Length < 11 Or txtPhoneNo.Text.Length > 12) Then
                InvalidString = InvalidString & "Phone Number Provided Is Not Valid" & vbNewLine
                Valid = False
            End If
        End If
        If txtAddress.Text = "" Then
            InvalidString = InvalidString & "No Address Provided" & vbNewLine
            Valid = False
        End If
        If txtTown.Text = "" Then
            InvalidString = InvalidString & "No Town Provided" & vbNewLine
            Valid = False
        End If
        If txtTown.Text = "" Then
            InvalidString = InvalidString & "No Town Provided" & vbNewLine
            Valid = False
        End If
        If txtCounty.Text = "" Then
            InvalidString = InvalidString & "No County Provided" & vbNewLine
            Valid = False
        End If
        If txtPostCode.Text = "" Then
            InvalidString = InvalidString & "No Postcode Provided" & vbNewLine
            Valid = False
        Else
            Dim Criteria As String = "[A-Z][A-Z][0-9][0-9][A-Z][A-Z]"
            If Not Regex.IsMatch(Replace(UCase(txtPostCode.Text), " ", ""), Criteria) Then
                InvalidString = InvalidString & "Postcode Provided Is Not Valid" & vbNewLine
                Valid = False
            End If
        End If
    End Sub
End Class