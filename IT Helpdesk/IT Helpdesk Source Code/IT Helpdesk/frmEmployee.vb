Public Class frmEmployee
    Dim N As Integer = 1
    Dim Count As Integer
    Dim MyAssets() As Assets
    Dim NoOfMyAssets As Integer = 0
    Dim CurrentAsset As Integer = 1
    Dim Valid As Boolean
    Dim InvalidString As String

    'Employee Related Subroutines
    Private Sub Form_EmployeeEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Decides Based On The "Cause" What it Should Do
        If frmMain.Cause = "NEW" Then
            'This sets it up to create a new employee - note no record is created until save
            Me.Text = "New Employee"
            'Up issues the ID number for reference
            txtID.Text = NoOfEmployees + 1
            'Disables the txtID so that you can't look at another record whilst creating a new one
            txtID.Enabled = False
            'Loads in departments
            PopulateDepartments()
        ElseIf frmMain.Cause = "EDIT" Then
            'N is used to pass over to Record we are going to edit
            N = frmMain.RecordN
            'Decides again if there is a need to create a new employee
            If NoOfEmployees = 0 Then
                Me.Text = "New Employee"
                frmMain.Cause = "NEW"
                txtID.Text = NoOfEmployees + 1
                txtID.Enabled = False
                PopulateDepartments()
            Else
                'Loads in the employee details
                Me.Text = "Employee Edit"
                txtID.Enabled = True
                txtID.Text = Employee(N).ID
                txtFirstName.Text = Employee(N).FirstName
                txtLastName.Text = Employee(N).LastName
                cmbGender.Text = Employee(N).Gender
                txtEmail.Text = Employee(N).Email
                txtPhoneExt.Text = Employee(N).PhoneExt
                txtMobile.Text = Employee(N).Mobile
                PopulateDepartments()
                cmbDepartment.SelectedIndex = Employee(N).DepartmentID - 1
                cmbPriority.SelectedIndex = Employee(N).PriorityRanking - 1
                txtWage.Text = Format(Employee(N).Wage, "currency")
                FindAssets()
            End If
        ElseIf frmMain.Cause = "VIEW" Then
            'Loads in the employee Details
            N = frmMain.RecordN
            Me.Text = "Employee View"
            txtID.Text = Employee(N).ID
            txtFirstName.Text = Employee(N).FirstName
            txtLastName.Text = Employee(N).LastName
            cmbGender.Text = Employee(N).Gender
            txtEmail.Text = Employee(N).Email
            txtPhoneExt.Text = Employee(N).PhoneExt
            txtMobile.Text = Employee(N).Mobile
            PopulateDepartments()
            cmbDepartment.SelectedIndex = Employee(N).DepartmentID - 1
            cmbPriority.SelectedIndex = Employee(N).PriorityRanking - 1
            txtWage.Text = Format(Employee(N).Wage, "currency")
            FindAssets()
            'Disables all editable fields and buttons so no changes can be made
            txtID.Enabled = True
            txtFirstName.Enabled = False
            txtLastName.Enabled = False
            cmbGender.Enabled = False
            txtEmail.Enabled = False
            txtPhoneExt.Enabled = False
            txtMobile.Enabled = False
            cmbDepartment.Enabled = False
            cmbPriority.Enabled = False
            txtWage.Enabled = False
            btnEmpSave.Enabled = False
            btnAstSave.Enabled = False
            btnEmpArchive.Enabled = False
            btnAstArchive.Enabled = False
            btnNew.Enabled = False
            txtAssetsDes.Enabled = False
            cmbCategory.Enabled = False
        End If
    End Sub
    Sub PopulateDepartments()
        'This loads in the departments
        For C = 1 To NoOfDepartments
            cmbDepartment.Items.Add(Department(C).Name)
        Next
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpSave.Click
        'If the cause is new then it will create a new record
        If frmMain.Cause = "NEW" Then
            ValidateMe()
            If Valid = True Then
                NewEmployee(txtFirstName.Text, txtLastName.Text, cmbGender.Text, txtEmail.Text, txtPhoneExt.Text, txtMobile.Text, (cmbDepartment.SelectedIndex + 1), (cmbPriority.SelectedIndex + 1), Employee(N).Wage = Replace(txtWage.Text, "£", ""))
                Me.Close()
            Else
                MsgBox("One or more items of data you are trying to input is invalid. The errors are listed below..." & vbNewLine & vbNewLine & InvalidString, MsgBoxStyle.Exclamation, "Data is Invalid")
            End If
        Else
            ValidateMe()
            If Valid = True Then
                Employee(N).FirstName = txtFirstName.Text
                Employee(N).LastName = txtLastName.Text
                Employee(N).Gender = cmbGender.Text
                Employee(N).Email = txtEmail.Text
                Employee(N).PhoneExt = txtPhoneExt.Text
                Employee(N).Mobile = txtMobile.Text
                Employee(N).DepartmentID = cmbDepartment.SelectedIndex + 1
                Employee(N).PriorityRanking = cmbPriority.SelectedIndex + 1

                Employee(N).Wage = Replace(txtWage.Text, "£", "")
                SaveEmployee()
            Else
                MsgBox("One or more items of data you are trying to input is invalid. The errors are listed below..." & vbNewLine & vbNewLine & InvalidString, MsgBoxStyle.Exclamation, "Data is Invalid")
            End If
        End If
    End Sub
    Private Sub btnArchive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpArchive.Click
        Employee(N).Archived = True
        SaveEmployee()
        Me.Close()
    End Sub
    Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.TextChanged
        If Val(txtID.Text) = 0 Then
        ElseIf Val(txtID.Text) <= NoOfEmployees Then
            Try
                N = Val(txtID.Text)
                txtID.Text = Employee(N).ID
                txtFirstName.Text = Employee(N).FirstName
                txtLastName.Text = Employee(N).LastName
                cmbGender.Text = Employee(N).Gender
                txtEmail.Text = Employee(N).Email
                txtPhoneExt.Text = Employee(N).PhoneExt
                txtMobile.Text = Employee(N).Mobile
                cmbDepartment.SelectedIndex = Employee(N).DepartmentID - 1
                cmbPriority.SelectedIndex = Employee(N).PriorityRanking - 1
                txtWage.Text = Format(Employee(N).Wage, "currency")
                FindAssets()
            Catch ex As Exception

            End Try
        End If
    End Sub
    Sub ValidateMe()
        'Checks to see whether the data entered is valid
        Valid = True
        InvalidString = ""
        If txtFirstName.Text = "" Then
            InvalidString = InvalidString & "No First Name Provided" & vbNewLine
            Valid = False
        End If
        If txtLastName.Text = "" Then
            InvalidString = InvalidString & "No Last Name Provided" & vbNewLine
            Valid = False
        End If
        If cmbGender.SelectedIndex = -1 Then
            InvalidString = InvalidString & "No Gender Selected" & vbNewLine
            Valid = False
        End If
        If txtEmail.Text = "" Then
            InvalidString = InvalidString & "No Email Provided" & vbNewLine
            Valid = False
        End If
        If txtPhoneExt.Text = "" Then
            InvalidString = InvalidString & "No Phone Extension Provided" & vbNewLine
            Valid = False
        End If
        If txtPhoneExt.Text = "" Then
            InvalidString = InvalidString & "No Mobile Number Provided" & vbNewLine
            Valid = False
        End If
        If cmbDepartment.SelectedIndex = -1 Then
            InvalidString = InvalidString & "No Department Selected" & vbNewLine
            Valid = False
        End If
        If txtWage.Text = "" Then
            InvalidString = InvalidString & "No Wage Provided" & vbNewLine
            Valid = False
        End If
        If Not IsNumeric(txtWage.Text) Then
            InvalidString = InvalidString & "Wage Provided Not A Number" & vbNewLine
            Valid = False
        End If
        If cmbPriority.SelectedIndex = -1 Then
            InvalidString = InvalidString & "No Priority Selected" & vbNewLine
            Valid = False
        End If
    End Sub

    'Asset Related Subroutines
    Sub FindAssets()
        NoOfMyAssets = 0
        txtAssetsDes.Text = ""
        cmbCategory.Text = ""
        For C = 1 To NoOfAssets
            If Asset(C).EmployeeID = N And Not Asset(C).Archived Then
                NoOfMyAssets += 1
                ReDim Preserve MyAssets(NoOfMyAssets)
                MyAssets(NoOfMyAssets).ID = Asset(C).ID
                MyAssets(NoOfMyAssets).Category = Asset(C).Category
                MyAssets(NoOfMyAssets).DescriptionID = Asset(C).DescriptionID
                MyAssets(NoOfMyAssets).EmployeeID = Asset(C).EmployeeID
                MyAssets(NoOfMyAssets).Archived = Asset(C).Archived
                txtAssetsDes.Text = Detail(MyAssets(NoOfMyAssets).DescriptionID)
                cmbCategory.Text = MyAssets(NoOfMyAssets).Category
            End If
        Next
        CurrentAsset = NoOfMyAssets
    End Sub
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If Not NoOfMyAssets = 0 Then
            If CurrentAsset = NoOfMyAssets Then
                CurrentAsset = 1
            Else
                CurrentAsset += 1
            End If

            txtAssetsDes.Text = Detail(MyAssets(CurrentAsset).DescriptionID)
            cmbCategory.Text = MyAssets(CurrentAsset).Category
        End If
    End Sub
    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        If Not NoOfMyAssets = 0 Then
            If CurrentAsset = 1 Then
                CurrentAsset = NoOfMyAssets
            Else
                CurrentAsset -= 1
            End If
            txtAssetsDes.Text = Detail(MyAssets(CurrentAsset).DescriptionID)
            cmbCategory.Text = MyAssets(CurrentAsset).Category
        End If
    End Sub
    Sub TransferToAsset()
        If NoOfMyAssets > 0 Then
            MyAssets(CurrentAsset).Category = cmbCategory.Text
            Count = 1
            For C = 1 To NoOfAssets
                If Not Count > NoOfMyAssets Then
                    If Asset(C).ID = MyAssets(Count).ID Then
                        Asset(C).Category = MyAssets(Count).Category
                        Asset(C).Archived = MyAssets(Count).Archived
                        Count += 1
                    End If
                End If
            Next
            Detail(MyAssets(CurrentAsset).DescriptionID) = txtAssetsDes.Text
            FileOpen(11, DirectoryLocation & "\details\" & MyAssets(CurrentAsset).DescriptionID & ".txt", OpenMode.Output)
            PrintLine(11, txtAssetsDes.Text)
            FileClose(11)
            SaveAssets()
        End If
    End Sub
    Private Sub btnAstSave_Click(sender As System.Object, e As System.EventArgs) Handles btnAstSave.Click
        If NoOfMyAssets > 0 Then
            TransferToAsset()
        End If
    End Sub
    Private Sub btnAstArchive_Click(sender As System.Object, e As System.EventArgs) Handles btnAstArchive.Click
        If NoOfMyAssets > 0 Then
            MyAssets(CurrentAsset).Archived = True
            TransferToAsset()
            Me.Close()
        End If
    End Sub
    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        NewDetail()
        ReDim Preserve Detail(NoOfDetails)
        AddAssets("None", NoOfDetails, N)
        CurrentAsset = NoOfMyAssets + 1
        FindAssets()
        txtAssetsDes.Text = "Type In Description Here"
        cmbCategory.Text = MyAssets(CurrentAsset).Category
    End Sub
End Class