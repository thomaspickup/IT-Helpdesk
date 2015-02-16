Imports System.IO
Public Class frmMain
    'Variables For Whole Of Form
    Public Cause As String 'Cause allows the different forms to know what type of access it needs to perform (Edit or New)
    Public RecordN As Integer 'Allows other forms to pick up what job record is to be selected
    Dim Input As String 'Used as input for finding records
    Dim Status As Integer 'Used to hold the status to sort by
    Dim Loaded As Integer 'A boolean on startup to stop the selected indexes changing whilst loading up
    Dim MeSelected As Integer 'Holds the Selected index of lbMain
    Dim Today() As Integer 'Used in calendar view, when new date is selected 

    'On Load Routine
    Private Sub Form_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Checks to see if password file exists
        If File.Exists(modFileHandler.DirectoryLocation & "\pass.txt") Then
            'Hashes my input password and opens the password in pass.txt
            Dim Pass As String
            Dim PassCheck As String
            Pass = getHash(InputBox("Please enter your password", "Password Required", "Type Password In Here"))
            FileOpen(17, modFileHandler.DirectoryLocation & "\pass.txt", OpenMode.Input)
            PassCheck = LineInput(17)
            FileClose(17)

            'Checks to see if i've typed in the right password
            If Pass = PassCheck Then
                'If i have then it will check to see whether all the files exist
                If File.Exists(modFileHandler.DirectoryLocation & "\settings.txt") And File.Exists(modFileHandler.DirectoryLocation & "\jobs.txt") And File.Exists(modFileHandler.DirectoryLocation & "\notes.txt") And File.Exists(modFileHandler.DirectoryLocation & "\employee.txt") And File.Exists(modFileHandler.DirectoryLocation & "\assets.txt") And File.Exists(modFileHandler.DirectoryLocation & "\departments.txt") And File.Exists(modFileHandler.DirectoryLocation & "\category.txt") And Directory.Exists(modFileHandler.DirectoryLocation & "\details\") Then
                    'Loads in the files and sets up form
                    OnMeLoad()
                    Loaded = False
                    cmbIT.SelectedIndex = My.Settings.DEFAT
                    cmbCallFrom.SelectedIndex = My.Settings.DEFCF
                    Status = 1
                    Display()
                    Loaded = True
                Else
                    'Creates the record files
                    Loaded = False
                    CreateRecord()
                    Loaded = True
                End If
            Else
                MsgBox("The Password you entered is incorrect, please re-launch the program to try again", MsgBoxStyle.Information, "Password Incorrect")
                End
            End If
        Else
            'If password doesn't exist it will either create all the records again or just the pass.txt
            If File.Exists(modFileHandler.DirectoryLocation & "\settings.txt") And File.Exists(modFileHandler.DirectoryLocation & "\jobs.txt") And File.Exists(modFileHandler.DirectoryLocation & "\notes.txt") And File.Exists(modFileHandler.DirectoryLocation & "\employee.txt") And File.Exists(modFileHandler.DirectoryLocation & "\assets.txt") And File.Exists(modFileHandler.DirectoryLocation & "\departments.txt") And File.Exists(modFileHandler.DirectoryLocation & "\category.txt") And Directory.Exists(modFileHandler.DirectoryLocation & "\details\") Then
                FileOpen(18, DirectoryLocation & "\pass.txt", OpenMode.Output)
                PrintLine(18, getHash("Default"))
                FileClose(18)
                End
            Else
                Loaded = False
                CreateRecord()
                Loaded = True
                End
            End If
        End If
    End Sub
    Public Sub OnMeLoad()
        Loaded = False
        LoadID() 'Loads in the ID's
        LoadEmployee() 'Loads in the Employee Records
        LoadIT() 'Finds the IT Staff
        LoadAssets() 'Loads in the assets
        LoadDepartments() 'Loads in the departments
        LoadJobs() 'Loads in the jobs
        LoadCategories() 'Loads in the categories
        ReDim DetailFiles(NoOfDetails + 1)
        DetailFiles = Directory.GetFiles(DirectoryLocation & "\details", "*.txt")
        LoadDetails() 'Loads in the details
        LoadNotes() 'Loads in the notes
        'This populates all the employee selector boxes
        MeSelected = cmbIT.SelectedIndex
        cmbIT.Items.Clear()
        cmbIT.Items.Add("All")
        For C = 1 To NoOfITStaff
            cmbIT.Items.Add(ITEmployee(C).FirstName & " " & ITEmployee(C).LastName)
        Next
        cmbIT.SelectedIndex = MeSelected
        MeSelected = cmbCallFrom.SelectedIndex
        cmbCallFrom.Items.Clear()
        cmbCallFrom.Items.Add("All")
        For C = 1 To NoOfEmployees
            cmbCallFrom.Items.Add(Employee(C).FirstName & " " & Employee(C).LastName)
        Next
        cmbCallFrom.SelectedIndex = MeSelected
        Loaded = True
    End Sub
    Public Sub Display()
        Dim TempID As Integer
        lbMain.Items.Clear()
        NoOfMyJobs = 0
        If cmbCallFrom.SelectedIndex = 0 And Not cmbIT.SelectedIndex = 0 Then
            Select Case Status
                Case 0
                    For C = 1 To NoOfJobs
                        If Job(C).ITStaffID = ITEmployee(cmbIT.SelectedIndex).ID And Not Job(C).Archived Then
                            NoOfMyJobs += 1
                            ReDim Preserve MyJobs(NoOfMyJobs)
                            MyJobs(NoOfMyJobs).ID = Job(C).ID
                            MyJobs(NoOfMyJobs).Category = Job(C).Category
                            MyJobs(NoOfMyJobs).DescriptionID = Job(C).DescriptionID
                            MyJobs(NoOfMyJobs).ITStaffID = Job(C).ITStaffID
                            MyJobs(NoOfMyJobs).EmployeeID = Job(C).EmployeeID
                            MyJobs(NoOfMyJobs).Status = Job(C).Status
                            MyJobs(NoOfMyJobs).Archived = Job(C).Archived
                            MyJobs(NoOfMyJobs).DateDue = Job(C).DateDue
                            MyJobs(NoOfMyJobs).Ref = Job(C).Ref
                        End If
                    Next
                Case 1
                    For C = 1 To NoOfJobs
                        If Not Job(C).Status = 3 And Job(C).ITStaffID = ITEmployee(cmbIT.SelectedIndex).ID And Not Job(C).Archived Then
                            NoOfMyJobs += 1
                            ReDim Preserve MyJobs(NoOfMyJobs)
                            MyJobs(NoOfMyJobs).ID = Job(C).ID
                            MyJobs(NoOfMyJobs).Category = Job(C).Category
                            MyJobs(NoOfMyJobs).DescriptionID = Job(C).DescriptionID
                            MyJobs(NoOfMyJobs).ITStaffID = Job(C).ITStaffID
                            MyJobs(NoOfMyJobs).EmployeeID = Job(C).EmployeeID
                            MyJobs(NoOfMyJobs).Status = Job(C).Status
                            MyJobs(NoOfMyJobs).Archived = Job(C).Archived
                            MyJobs(NoOfMyJobs).DateDue = Job(C).DateDue
                            MyJobs(NoOfMyJobs).Ref = Job(C).Ref
                        End If
                    Next
                Case 2
                    For C = 1 To NoOfJobs
                        If Job(C).Status = 3 And Job(C).ITStaffID = ITEmployee(cmbIT.SelectedIndex).ID And Not Job(C).Archived Then
                            NoOfMyJobs += 1
                            ReDim Preserve MyJobs(NoOfMyJobs)
                            MyJobs(NoOfMyJobs).ID = Job(C).ID
                            MyJobs(NoOfMyJobs).Category = Job(C).Category
                            MyJobs(NoOfMyJobs).DescriptionID = Job(C).DescriptionID
                            MyJobs(NoOfMyJobs).ITStaffID = Job(C).ITStaffID
                            MyJobs(NoOfMyJobs).EmployeeID = Job(C).EmployeeID
                            MyJobs(NoOfMyJobs).Status = Job(C).Status
                            MyJobs(NoOfMyJobs).Archived = Job(C).Archived
                            MyJobs(NoOfMyJobs).DateDue = Job(C).DateDue
                            MyJobs(NoOfMyJobs).Ref = Job(C).Ref
                        End If
                    Next
            End Select
        ElseIf Not cmbCallFrom.SelectedIndex = 0 And cmbIT.SelectedIndex = 0 Then
            Select Case Status
                Case 0
                    For C = 1 To NoOfJobs
                        If Job(C).EmployeeID = Employee(cmbCallFrom.SelectedIndex).ID And Not Job(C).Archived Then
                            NoOfMyJobs += 1
                            ReDim Preserve MyJobs(NoOfMyJobs)
                            MyJobs(NoOfMyJobs).ID = Job(C).ID
                            MyJobs(NoOfMyJobs).Category = Job(C).Category
                            MyJobs(NoOfMyJobs).DescriptionID = Job(C).DescriptionID
                            MyJobs(NoOfMyJobs).ITStaffID = Job(C).ITStaffID
                            MyJobs(NoOfMyJobs).EmployeeID = Job(C).EmployeeID
                            MyJobs(NoOfMyJobs).Status = Job(C).Status
                            MyJobs(NoOfMyJobs).Archived = Job(C).Archived
                            MyJobs(NoOfMyJobs).DateDue = Job(C).DateDue
                            MyJobs(NoOfMyJobs).Ref = Job(C).Ref
                        End If
                    Next
                Case 1
                    For C = 1 To NoOfJobs
                        If Not Job(C).Status = 3 And Job(C).EmployeeID = Employee(cmbCallFrom.SelectedIndex).ID And Not Job(C).Archived Then
                            NoOfMyJobs += 1
                            ReDim Preserve MyJobs(NoOfMyJobs)
                            MyJobs(NoOfMyJobs).ID = Job(C).ID
                            MyJobs(NoOfMyJobs).Category = Job(C).Category
                            MyJobs(NoOfMyJobs).DescriptionID = Job(C).DescriptionID
                            MyJobs(NoOfMyJobs).ITStaffID = Job(C).ITStaffID
                            MyJobs(NoOfMyJobs).EmployeeID = Job(C).EmployeeID
                            MyJobs(NoOfMyJobs).Status = Job(C).Status
                            MyJobs(NoOfMyJobs).Archived = Job(C).Archived
                            MyJobs(NoOfMyJobs).DateDue = Job(C).DateDue
                            MyJobs(NoOfMyJobs).Ref = Job(C).Ref
                        End If
                    Next
                Case 2
                    For C = 1 To NoOfJobs
                        If Job(C).Status = 3 And Job(C).EmployeeID = Employee(cmbCallFrom.SelectedIndex).ID And Not Job(C).Archived Then
                            NoOfMyJobs += 1
                            ReDim Preserve MyJobs(NoOfMyJobs)
                            MyJobs(NoOfMyJobs).ID = Job(C).ID
                            MyJobs(NoOfMyJobs).Category = Job(C).Category
                            MyJobs(NoOfMyJobs).DescriptionID = Job(C).DescriptionID
                            MyJobs(NoOfMyJobs).ITStaffID = Job(C).ITStaffID
                            MyJobs(NoOfMyJobs).EmployeeID = Job(C).EmployeeID
                            MyJobs(NoOfMyJobs).Status = Job(C).Status
                            MyJobs(NoOfMyJobs).Archived = Job(C).Archived
                            MyJobs(NoOfMyJobs).DateDue = Job(C).DateDue
                            MyJobs(NoOfMyJobs).Ref = Job(C).Ref
                        End If
                    Next
            End Select
        ElseIf Not cmbCallFrom.SelectedIndex = 0 And Not cmbIT.SelectedIndex = 0 Then
            Select Case Status
                Case 0
                    For C = 1 To NoOfJobs
                        If Job(C).EmployeeID = Employee(cmbCallFrom.SelectedIndex).ID And Job(C).ITStaffID = ITEmployee(cmbIT.SelectedIndex).ID And Not Job(C).Archived Then
                            NoOfMyJobs += 1
                            ReDim Preserve MyJobs(NoOfMyJobs)
                            MyJobs(NoOfMyJobs).ID = Job(C).ID
                            MyJobs(NoOfMyJobs).Category = Job(C).Category
                            MyJobs(NoOfMyJobs).DescriptionID = Job(C).DescriptionID
                            MyJobs(NoOfMyJobs).ITStaffID = Job(C).ITStaffID
                            MyJobs(NoOfMyJobs).EmployeeID = Job(C).EmployeeID
                            MyJobs(NoOfMyJobs).Status = Job(C).Status
                            MyJobs(NoOfMyJobs).Archived = Job(C).Archived
                            MyJobs(NoOfMyJobs).DateDue = Job(C).DateDue
                            MyJobs(NoOfMyJobs).Ref = Job(C).Ref
                        End If
                    Next
                Case 1
                    For C = 1 To NoOfJobs
                        If Not Job(C).Status = 3 And Job(C).EmployeeID = Employee(cmbCallFrom.SelectedIndex).ID And Job(C).ITStaffID = ITEmployee(cmbIT.SelectedIndex).ID And Not Job(C).Archived Then
                            NoOfMyJobs += 1
                            ReDim Preserve MyJobs(NoOfMyJobs)
                            MyJobs(NoOfMyJobs).ID = Job(C).ID
                            MyJobs(NoOfMyJobs).Category = Job(C).Category
                            MyJobs(NoOfMyJobs).DescriptionID = Job(C).DescriptionID
                            MyJobs(NoOfMyJobs).ITStaffID = Job(C).ITStaffID
                            MyJobs(NoOfMyJobs).EmployeeID = Job(C).EmployeeID
                            MyJobs(NoOfMyJobs).Status = Job(C).Status
                            MyJobs(NoOfMyJobs).Archived = Job(C).Archived
                            MyJobs(NoOfMyJobs).DateDue = Job(C).DateDue
                            MyJobs(NoOfMyJobs).Ref = Job(C).Ref
                        End If
                    Next
                Case 2
                    For C = 1 To NoOfJobs
                        If Job(C).Status = 3 And Job(C).EmployeeID = Employee(cmbCallFrom.SelectedIndex).ID And Job(C).ITStaffID = ITEmployee(cmbIT.SelectedIndex).ID And Not Job(C).Archived Then
                            NoOfMyJobs += 1
                            ReDim Preserve MyJobs(NoOfMyJobs)
                            MyJobs(NoOfMyJobs).ID = Job(C).ID
                            MyJobs(NoOfMyJobs).Category = Job(C).Category
                            MyJobs(NoOfMyJobs).DescriptionID = Job(C).DescriptionID
                            MyJobs(NoOfMyJobs).ITStaffID = Job(C).ITStaffID
                            MyJobs(NoOfMyJobs).EmployeeID = Job(C).EmployeeID
                            MyJobs(NoOfMyJobs).Status = Job(C).Status
                            MyJobs(NoOfMyJobs).Archived = Job(C).Archived
                            MyJobs(NoOfMyJobs).DateDue = Job(C).DateDue
                            MyJobs(NoOfMyJobs).Ref = Job(C).Ref
                        End If
                    Next
            End Select
        Else
            Select Case Status
                Case 0
                    For C = 1 To NoOfJobs
                        If Not Job(C).Archived Then
                            NoOfMyJobs += 1
                            ReDim Preserve MyJobs(NoOfMyJobs)
                            MyJobs(NoOfMyJobs).ID = Job(C).ID
                            MyJobs(NoOfMyJobs).Category = Job(C).Category
                            MyJobs(NoOfMyJobs).DescriptionID = Job(C).DescriptionID
                            MyJobs(NoOfMyJobs).ITStaffID = Job(C).ITStaffID
                            MyJobs(NoOfMyJobs).EmployeeID = Job(C).EmployeeID
                            MyJobs(NoOfMyJobs).Status = Job(C).Status
                            MyJobs(NoOfMyJobs).Archived = Job(C).Archived
                            MyJobs(NoOfMyJobs).DateDue = Job(C).DateDue
                            MyJobs(NoOfMyJobs).Ref = Job(C).Ref
                        End If
                    Next
                Case 1
                    For C = 1 To NoOfJobs
                        If Not Job(C).Status = 3 And Not Job(C).Archived Then
                            NoOfMyJobs += 1
                            ReDim Preserve MyJobs(NoOfMyJobs)
                            MyJobs(NoOfMyJobs).ID = Job(C).ID
                            MyJobs(NoOfMyJobs).Category = Job(C).Category
                            MyJobs(NoOfMyJobs).DescriptionID = Job(C).DescriptionID
                            MyJobs(NoOfMyJobs).ITStaffID = Job(C).ITStaffID
                            MyJobs(NoOfMyJobs).EmployeeID = Job(C).EmployeeID
                            MyJobs(NoOfMyJobs).Status = Job(C).Status
                            MyJobs(NoOfMyJobs).Archived = Job(C).Archived
                            MyJobs(NoOfMyJobs).DateDue = Job(C).DateDue
                            MyJobs(NoOfMyJobs).Ref = Job(C).Ref
                        End If
                    Next
                Case 2
                    For C = 1 To NoOfJobs
                        If Job(C).Status = 3 And Not Job(C).Archived Then
                            NoOfMyJobs += 1
                            ReDim Preserve MyJobs(NoOfMyJobs)
                            MyJobs(NoOfMyJobs).ID = Job(C).ID
                            MyJobs(NoOfMyJobs).Category = Job(C).Category
                            MyJobs(NoOfMyJobs).DescriptionID = Job(C).DescriptionID
                            MyJobs(NoOfMyJobs).ITStaffID = Job(C).ITStaffID
                            MyJobs(NoOfMyJobs).EmployeeID = Job(C).EmployeeID
                            MyJobs(NoOfMyJobs).Status = Job(C).Status
                            MyJobs(NoOfMyJobs).Archived = Job(C).Archived
                            MyJobs(NoOfMyJobs).DateDue = Job(C).DateDue
                            MyJobs(NoOfMyJobs).Ref = Job(C).Ref
                        End If
                    Next
            End Select
        End If
        Calendar.RemoveAllBoldedDates()
        For C = 1 To NoOfJobs
            If Job(C).Archived = False And Not Job(C).Status = 3 Then
                Calendar.AddBoldedDate(DateTime.Parse(Job(C).DateDue))
            End If
        Next
        Dim swapmade As Boolean = True
        Do
            swapmade = False
            For j = 1 To NoOfMyJobs - 1
                If DateTime.Compare(MyJobs(j).DateDue, MyJobs(j + 1).DateDue) > 0 Then
                    TempID = MyJobs(j).ID
                    MyJobs(j).ID = MyJobs(j + 1).ID
                    MyJobs(j).Category = MyJobs(j + 1).Category
                    MyJobs(j).DescriptionID = MyJobs(j + 1).DescriptionID
                    MyJobs(j).ITStaffID = MyJobs(j + 1).ITStaffID
                    MyJobs(j).EmployeeID = MyJobs(j + 1).EmployeeID
                    MyJobs(j).Status = MyJobs(j + 1).Status
                    MyJobs(j).Archived = MyJobs(j + 1).Archived
                    MyJobs(j).DateDue = MyJobs(j + 1).DateDue
                    MyJobs(j).Ref = MyJobs(j + 1).Ref
                    MyJobs(j + 1).ID = Job(TempID).ID
                    MyJobs(j + 1).Category = Job(TempID).Category
                    MyJobs(j + 1).DescriptionID = Job(TempID).DescriptionID
                    MyJobs(j + 1).ITStaffID = Job(TempID).ITStaffID
                    MyJobs(j + 1).EmployeeID = Job(TempID).EmployeeID
                    MyJobs(j + 1).Status = Job(TempID).Status
                    MyJobs(j + 1).Archived = Job(TempID).Archived
                    MyJobs(j + 1).DateDue = Job(TempID).DateDue
                    MyJobs(j + 1).Ref = Job(TempID).Ref
                    swapmade = True
                End If
            Next j
        Loop Until swapmade = False
        For C = 1 To NoOfMyJobs
            lbMain.Items.Add("Job ID " & MyJobs(C).ID & " - " & MyJobs(C).Ref)
        Next
    End Sub

    'Employee Department and job related subroutines follow the same algorithms just doing different jobs.
    'I have documented this below...
    'View Routine
    '   Cause is set to view
    '   Asks for input
    '   If input is numeric checks to see if it is valid then loads record
    '   If input is not numeric launches Search then loads most probable record
    'End
    'New Routine
    '   Cause is set to new
    '   Loads New Record
    'End
    'Edit Routine
    '   Cause is set to edit
    '   Asks for input
    '   If input is numeric checks to see if it is valid then loads record
    '   If input is not numeric launches Search then loads most probable record
    'End

    'Employee Routines
    Private Sub MenuStrip_NewEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewEmp.Click
        Cause = "NEW"
        frmEmployee.Show()
    End Sub
    Private Sub ViewEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewEmp.Click
        Cause = "VIEW"
        Input = InputBox("Please enter an employee ID or name to view", "Employee Search")
        If IsNumeric(Input) Then
            If Not Input > NoOfEmployees Then
                If Employee(Input).Archived = False Then
                    RecordN = Input
                    frmEmployee.Show()
                Else
                    MsgBox("It appears this record is archived. Please go to View Archived Items to unarchive this item then try again.", MsgBoxStyle.Information, "Item Is Archived")
                End If
            Else
                MsgBox("The term you searched for could not be found, please try another term.", MsgBoxStyle.OkOnly, "Search Unsuccessful")
            End If
        ElseIf Not Input = " " Then
            Query = "Employees"
            SearchString = Input
            Search()
            If Not Results.Count = 0 Then
                If Employee(Results(1)).Archived = False Then
                    RecordN = Results(1)
                    frmEmployee.Show()
                Else
                    MsgBox("It appears this record is archived. Please go to View Archived Items to unarchive this item then try again.", MsgBoxStyle.Information, "Item Is Archived")
                End If
            Else
                MsgBox("The term you searched for could not be found, please try another term.", MsgBoxStyle.OkOnly, "Search Unsuccessful")
            End If
        End If
    End Sub
    Private Sub EditEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditEmp.Click
        Cause = "EDIT"
        Input = InputBox("Please enter an employee ID or name to edit")
        If IsNumeric(Input) Then
            If Not Input > NoOfEmployees Then
                If Employee(Input).Archived = False Then
                    RecordN = Input
                    frmEmployee.Show()
                Else
                    MsgBox("It appears this record is archived. Please go to View Archived Items to unarchive this item then try again.", MsgBoxStyle.Information, "Item Is Archived")
                End If
            Else
                MsgBox("The term you searched for could not be found, please try another term.", MsgBoxStyle.OkOnly, "Search Unsuccessful")
            End If
        ElseIf Not Input = " " Then
            Query = "Employees"
            SearchString = Input
            Search()
            If Not Results.Count = 0 Then
                If Employee(Results(1)).Archived = False Then
                    RecordN = Results(1)
                    frmEmployee.Show()
                Else
                    MsgBox("It appears this record is archived. Please go to View Archived Items to unarchive this item then try again.", MsgBoxStyle.Information, "Item Is Archived")
                End If
            Else
                MsgBox("The term you searched for could not be found, please try another term.", MsgBoxStyle.OkOnly, "Search Unsuccessful")
            End If
        End If
    End Sub
    Private Sub btnNewEmp_Click(sender As System.Object, e As System.EventArgs) Handles btnNewEmp.Click
        Cause = "NEW"
        frmEmployee.Show()
    End Sub
    Private Sub btnEditEmp_Click(sender As System.Object, e As System.EventArgs) Handles btnEditEmp.Click
        Cause = "EDIT"
        Input = InputBox("Please enter an employee ID or name to edit")
        If IsNumeric(Input) Then
            If Not Input > NoOfEmployees Then
                If Employee(Input).Archived = False Then
                    RecordN = Input
                    frmEmployee.Show()
                Else
                    MsgBox("It appears this record is archived. Please go to View Archived Items to unarchive this item then try again.", MsgBoxStyle.Information, "Item Is Archived")
                End If
            Else
                MsgBox("The term you searched for could not be found, please try another term.", MsgBoxStyle.OkOnly, "Search Unsuccessful")
            End If
        ElseIf Not Input = " " Then
            Query = "Employees"
            SearchString = Input
            Search()
            If Not Results.Count = 0 Then
                If Employee(Results(1)).Archived = False Then
                    RecordN = Results(1)
                    frmEmployee.Show()
                Else
                    MsgBox("It appears this record is archived. Please go to View Archived Items to unarchive this item then try again.", MsgBoxStyle.Information, "Item Is Archived")
                End If
            Else
                MsgBox("The term you searched for could not be found, please try another term.", MsgBoxStyle.OkOnly, "Search Unsuccessful")
            End If
        End If
    End Sub
    Private Sub btnViewEmp_Click(sender As System.Object, e As System.EventArgs) Handles btnViewEmp.Click
        Cause = "VIEW"
        Input = InputBox("Please enter an employee ID or name to view")
        If IsNumeric(Input) Then
            If Not Input > NoOfEmployees Then
                If Employee(Input).Archived = False Then
                    RecordN = Input
                    frmEmployee.Show()
                Else
                    MsgBox("It appears this record is archived. Please go to View Archived Items to unarchive this item then try again.", MsgBoxStyle.Information, "Item Is Archived")
                End If
            Else
                MsgBox("The term you searched for could not be found, please try another term.", MsgBoxStyle.OkOnly, "Search Unsuccessful")
            End If
        ElseIf Not Input = " " Then
            Query = "Employees"
            SearchString = Input
            Search()
            If Not Results.Count = 0 Then
                If Employee(Results(1)).Archived = False Then
                    RecordN = Results(1)
                    frmEmployee.Show()
                Else
                    MsgBox("It appears this record is archived. Please go to View Archived Items to unarchive this item then try again.", MsgBoxStyle.Information, "Item Is Archived")
                End If
            Else
                MsgBox("The term you searched for could not be found, please try another term.", MsgBoxStyle.OkOnly, "Search Unsuccessful")
            End If
        End If
    End Sub

    'Department Routines
    Private Sub NewDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewDep.Click
        Cause = "NEW"
        frmDepartment.Show()
    End Sub
    Private Sub EditDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditDep.Click
        Cause = "EDIT"
        Input = InputBox("Please enter a Department ID or the name of the department to search for...", "Department Search")
        If IsNumeric(Input) Then
            If Not Input > NoOfDepartments Then
                If Department(Input).Archived = False Then
                    RecordN = Input
                    frmDepartment.Show()
                Else
                    MsgBox("It appears this record is archived. Please go to View Archived Items to unarchive this item then try again.", MsgBoxStyle.Information, "Item Is Archived")
                End If
            Else
                MsgBox("The term you searched for could not be found, please try another term.", MsgBoxStyle.OkOnly, "Search Unsuccessful")
            End If
        ElseIf Not Input = " " Then
            Query = "Departments"
            SearchString = Input
            Search()
            If Not Results(1) = 0 Then
                If Department(Results(1)).Archived = False Then
                    RecordN = Results(1)
                    frmDepartment.Show()
                Else
                    MsgBox("It appears this record is archived. Please go to View Archived Items to unarchive this item then try again.", MsgBoxStyle.Information, "Item Is Archived")
                End If
            Else
                MsgBox("The term you searched for could not be found, please try another term.", MsgBoxStyle.OkOnly, "Search Unsuccessful")
            End If
        End If
    End Sub
    Private Sub ViewDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewDep.Click
        Cause = "VIEW"
        Input = InputBox("Please enter a Department ID or the name of the department to search for...", "Department Search")
        If IsNumeric(Input) Then
            If Not Input > NoOfDepartments Then
                If Department(Input).Archived = False Then
                    RecordN = Input
                    frmDepartment.Show()
                Else
                    MsgBox("It appears this record is archived. Please go to View Archived Items to unarchive this item then try again.", MsgBoxStyle.Information, "Item Is Archived")
                End If
            Else
                MsgBox("The term you searched for could not be found, please try another term.", MsgBoxStyle.OkOnly, "Search Unsuccessful")
            End If
        ElseIf Not Input = " " Then
            Query = "Departments"
            SearchString = Input
            Search()
            If Not Results(1) = 0 Then
                If Department(Results(1)).Archived = False Then
                    RecordN = Results(1)
                    frmDepartment.Show()
                Else
                    MsgBox("It appears this record is archived. Please go to View Archived Items to unarchive this item then try again.", MsgBoxStyle.Information, "Item Is Archived")
                End If
            Else
                MsgBox("The term you searched for could not be found, please try another term.", MsgBoxStyle.OkOnly, "Search Unsuccessful")
            End If
        End If
    End Sub
    Private Sub btnNewDep_Click(sender As System.Object, e As System.EventArgs) Handles btnNewDep.Click
        Cause = "NEW"
        frmDepartment.Show()
    End Sub
    Private Sub btnEditDep_Click(sender As System.Object, e As System.EventArgs) Handles btnEditDep.Click
        Cause = "EDIT"
        Input = InputBox("Please enter a Department ID or the name of the department to search for...", "Department Search")
        If IsNumeric(Input) Then
            If Not Input > NoOfDepartments Then
                If Department(Input).Archived = False Then
                    RecordN = Input
                    frmDepartment.Show()
                Else
                    MsgBox("It appears this record is archived. Please go to View Archived Items to unarchive this item then try again.", MsgBoxStyle.Information, "Item Is Archived")
                End If
            Else
                MsgBox("The term you searched for could not be found, please try another term.", MsgBoxStyle.OkOnly, "Search Unsuccessful")
            End If
        ElseIf Not Input = " " Then
            Query = "Departments"
            SearchString = Input
            Search()
            If Not Results(1) = 0 Then
                If Department(Results(1)).Archived = False Then
                    RecordN = Results(1)
                    frmDepartment.Show()
                Else
                    MsgBox("It appears this record is archived. Please go to View Archived Items to unarchive this item then try again.", MsgBoxStyle.Information, "Item Is Archived")
                End If
            Else
                MsgBox("The term you searched for could not be found, please try another term.", MsgBoxStyle.OkOnly, "Search Unsuccessful")
            End If
        End If
    End Sub
    Private Sub btnViewDep_Click(sender As System.Object, e As System.EventArgs) Handles btnViewDep.Click
        Cause = "VIEW"
        Input = InputBox("Please enter a Department ID or the name of the department to search for...", "Department Search")
        If IsNumeric(Input) Then
            If Not Input > NoOfDepartments Then
                If Department(Input).Archived = False Then
                    RecordN = Input
                    frmDepartment.Show()
                Else
                    MsgBox("It appears this record is archived. Please go to View Archived Items to unarchive this item then try again.", MsgBoxStyle.Information, "Item Is Archived")
                End If
            Else
                MsgBox("The term you searched for could not be found, please try another term.", MsgBoxStyle.OkOnly, "Search Unsuccessful")
            End If
        ElseIf Not Input = " " Then
            Query = "Departments"
            SearchString = Input
            Search()
            If Not Results(1) = 0 Then
                If Department(Results(1)).Archived = False Then
                    RecordN = Results(1)
                    frmDepartment.Show()
                Else
                    MsgBox("It appears this record is archived. Please go to View Archived Items to unarchive this item then try again.", MsgBoxStyle.Information, "Item Is Archived")
                End If
            Else
                MsgBox("The term you searched for could not be found, please try another term.", MsgBoxStyle.OkOnly, "Search Unsuccessful")
            End If
        End If
    End Sub

    'Job Routines
    Private Sub JobToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewJob.Click
        Cause = "NEW"
        frmJobs.Show()
    End Sub
    Private Sub ViewJob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewJob.Click
        Cause = "VIEW"
        Input = InputBox("Please enter a Job ID or a basic description of the job to search for...", "Job Search")
        If IsNumeric(Input) Then
            If Not Input > NoOfJobs Then
                If Job(Input).Archived = False Then
                    RecordN = Input
                    frmJobs.Show()
                Else
                    MsgBox("It appears this record is archived. Please go to View Archived Items to unarchive this item then try again.", MsgBoxStyle.Information, "Item Is Archived")
                End If
            Else
                MsgBox("The term you searched for could not be found, please try another term.", MsgBoxStyle.OkOnly, "Search Unsuccessful")
            End If
        ElseIf Not Input = " " Then
            Query = "Jobs"
            SearchString = Input
            Search()
            If Not Results(1) = 0 Then
                If Job(Results(1)).Archived = False Then
                    RecordN = Results(1)
                    frmJobs.Show()
                Else
                    MsgBox("It appears this record is archived. Please go to View Archived Items to unarchive this item then try again.", MsgBoxStyle.Information, "Item Is Archived")
                End If
            Else
                MsgBox("The term you searched for could not be found, please try another term.", MsgBoxStyle.OkOnly, "Search Unsuccessful")
            End If
        End If
    End Sub
    Private Sub EditJob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditJob.Click
        Cause = "EDIT"
        Input = InputBox("Please enter a Job ID or a basic description of the job to search for...", "Job Search")
        If IsNumeric(Input) Then
            If Not Input > NoOfJobs Then
                If Job(Input).Archived = False Then
                    RecordN = Input
                    frmJobs.Show()
                Else
                    MsgBox("It appears this record is archived. Please go to View Archived Items to unarchive this item then try again.", MsgBoxStyle.Information, "Item Is Archived")
                End If
            Else
                MsgBox("The term you searched for could not be found, please try another term.", MsgBoxStyle.OkOnly, "Search Unsuccessful")
            End If
        ElseIf Not Input = " " Then
            Query = "Jobs"
            SearchString = Input
            Search()
            If Not Results(1) = 0 Then
                If Job(Results(1)).Archived = False Then
                    RecordN = Results(1)
                    frmJobs.Show()
                Else
                    MsgBox("It appears this record is archived. Please go to View Archived Items to unarchive this item then try again.", MsgBoxStyle.Information, "Item Is Archived")
                End If
            Else
                MsgBox("The term you searched for could not be found, please try another term.", MsgBoxStyle.OkOnly, "Search Unsuccessful")
            End If
        End If
    End Sub
    Private Sub btnNewJob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewJob.Click
        Cause = "NEW"
        frmJobs.Show()
    End Sub
    Private Sub btnEditJob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditJob.Click
        Cause = "EDIT"
        Input = InputBox("Please enter a Job ID or a basic description of the job to search for...", "Job Search")
        If IsNumeric(Input) Then
            If Not Input > NoOfJobs Then
                If Job(Input).Archived = False Then
                    RecordN = Input
                    frmJobs.Show()
                Else
                    MsgBox("It appears this record is archived. Please go to View Archived Items to unarchive this item then try again.", MsgBoxStyle.Information, "Item Is Archived")
                End If
            Else
                MsgBox("The term you searched for could not be found, please try another term.", MsgBoxStyle.OkOnly, "Search Unsuccessful")
            End If
        ElseIf Not Input = " " Then
            Query = "Jobs"
            SearchString = Input
            Search()
            If Not Results(1) = 0 Then
                If Job(Results(1)).Archived = False Then
                    RecordN = Results(1)
                    frmJobs.Show()
                Else
                    MsgBox("It appears this record is archived. Please go to View Archived Items to unarchive this item then try again.", MsgBoxStyle.Information, "Item Is Archived")
                End If
            Else
                MsgBox("The term you searched for could not be found, please try another term.", MsgBoxStyle.OkOnly, "Search Unsuccessful")
            End If
        End If
    End Sub
    Private Sub btnViewJob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewJob.Click
        Cause = "VIEW"
        Input = InputBox("Please enter a Job ID or a basic description of the job to search for...", "Job Search")
        If IsNumeric(Input) Then
            If Not Input > NoOfJobs Then
                If Job(Input).Archived = False Then
                    RecordN = Input
                    frmJobs.Show()
                Else
                    MsgBox("It appears this record is archived. Please go to View Archived Items to unarchive this item then try again.", MsgBoxStyle.Information, "Item Is Archived")
                End If
            Else
                MsgBox("The term you searched for could not be found, please try another term.", MsgBoxStyle.OkOnly, "Search Unsuccessful")
            End If
        ElseIf Not Input = " " Then
            Query = "Jobs"
            SearchString = Input
            Search()
            If Not Results(1) = 0 Then
                If Job(Results(1)).Archived = False Then
                    RecordN = Results(1)
                    frmJobs.Show()
                Else
                    MsgBox("It appears this record is archived. Please go to View Archived Items to unarchive this item then try again.", MsgBoxStyle.Information, "Item Is Archived")
                End If
            Else
                MsgBox("The term you searched for could not be found, please try another term.", MsgBoxStyle.OkOnly, "Search Unsuccessful")
            End If
        End If
    End Sub

    'Analysis Routines
    Private Sub cmbIT_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbIT.SelectedIndexChanged
        'If the form is loaded it will change what's displayed it the lbMain to the status of the combobox
        If Loaded Then
            Display()
        End If
    End Sub
    Private Sub cmbCallFrom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCallFrom.SelectedIndexChanged
        'If the form is loaded it will change what's displayed it the lbMain to the status of the combobox
        If Loaded Then
            Display()
        End If
    End Sub
    Private Sub btnAll_Click(sender As System.Object, e As System.EventArgs) Handles btnAll.Click
        'Sets the status to everything and then changes what's displayed it the lbMain
        Status = 0
        Display()
    End Sub
    Private Sub btnCompleted_Click(sender As System.Object, e As System.EventArgs) Handles btnCompleted.Click
        'Sets the status to completed and then changes what's displayed it the lbMain
        Status = 2
        Display()
    End Sub
    Private Sub btnOutstanding_Click(sender As System.Object, e As System.EventArgs) Handles btnOutstanding.Click
        'Sets the status to outstanding/in progress and then changes what's displayed it the lbMain
        Status = 1
        Display()
    End Sub
    Private Sub lbMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbMain.DoubleClick
        'Checks to see if there is things in the listbox
        'If there is then it will load up the selected item
        If lbMain.Items.Count > 0 Then
            Cause = "EDIT"
            RecordN = MyJobs(lbMain.SelectedIndex + 1).ID
            frmJobs.Show()
        End If
    End Sub
    Private Sub lbMain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbMain.SelectedIndexChanged
        'Erases everything in the preview textboxes
        'Changes the preview textboxes to display the Description and due date to the selected record's
        txtJobPreview.Text = ""
        txtDueDate.Text = ""
        If lbMain.Items.Count > 0 Then
            txtJobPreview.Text = Detail(MyJobs(lbMain.SelectedIndex + 1).DescriptionID)
            txtDueDate.Text = Job(MyJobs(lbMain.SelectedIndex + 1).ID).DateDue
            MeSelected = lbMain.SelectedIndex
        End If
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        'Changes to query to search jobs
        Query = "Jobs"
        'Takes the search string from txtSearch (The thing we want to search for) and initiates the search algorithm
        SearchString = txtSearch.Text
        Search()

        'Clears lbMain and then displays all the results
        lbMain.Items.Clear()
        NoOfMyJobs = 0
        Dim N As Integer = 1
        For C = 1 To NoOfResults
            NoOfMyJobs += 1
            ReDim Preserve MyJobs(NoOfMyJobs)
            MyJobs(NoOfMyJobs).ID = Job(Results(C)).ID
            MyJobs(NoOfMyJobs).Category = Job(Results(C)).Category
            MyJobs(NoOfMyJobs).DescriptionID = Job(Results(C)).DescriptionID
            MyJobs(NoOfMyJobs).ITStaffID = Job(Results(C)).ITStaffID
            MyJobs(NoOfMyJobs).EmployeeID = Job(Results(C)).EmployeeID
            MyJobs(NoOfMyJobs).Status = Job(Results(C)).Status
            MyJobs(NoOfMyJobs).Archived = Job(Results(C)).Archived
            MyJobs(NoOfMyJobs).Ref = Job(Results(C)).Ref
        Next
        For C = 1 To NoOfMyJobs
            lbMain.Items.Add("Job ID " & MyJobs(C).ID & " - " & MyJobs(C).Ref)
        Next
    End Sub

    'Export to CSV Routines
    Private Sub ExportJobCostsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportJobCosts.Click
        If Not NoOfJobs = 0 Then
            Dim WriteString As String = "Job ID, Assigned To, Hours, Cost"
            Dim TotalHours As Single
            Dim TotalCost As Single
            Dim Hours As Single
            Dim Cost As Single
            For C = 1 To NoOfJobs
                Hours = 0
                For D = 1 To NoOfNotes
                    If Note(D).JobID = C Then
                        Hours = Hours + Note(D).Time
                    End If
                Next
                Cost = Hours * Employee(Job(C).ITStaffID).Wage
                WriteString = WriteString & vbNewLine & C & "," & Employee(Job(C).ITStaffID).FirstName & " " & Employee(Job(C).ITStaffID).LastName & "," & Hours & "," & Format(Cost, "currency")
                TotalCost = TotalCost + Cost
                TotalHours = TotalHours + Hours
            Next
            WriteString = WriteString & vbNewLine & ",Totals," & TotalHours & "," & Format(TotalCost, "currency")
            ExportCSVCosts.Filter = "Excel File | *.csv"
            ExportCSVCosts.DefaultExt = "csv"
            Dim result As System.Nullable(Of Boolean) = ExportCSVCosts.ShowDialog()
            If result = True Then
                FileOpen(11, ExportCSVCosts.FileName, OpenMode.Output)
                Print(11, WriteString)
                FileClose(11)
            End If
        End If
    End Sub
    Private Sub ExportCurrentSelection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportCurrentSelection.Click
        Dim WriteString As String = "Job ID,Job Reference,Assigned To,Call From,Date Added,Date Due,Status"
        For C = 1 To NoOfMyJobs
            Dim myStatus As String
            If MyJobs(C).Status = 1 Then
                myStatus = "Outstanding"
            ElseIf MyJobs(C).Status = 2 Then
                myStatus = "In Progress"
            Else
                myStatus = "Completed"
            End If
            WriteString = WriteString & vbNewLine & MyJobs(C).ID & "," & MyJobs(C).Ref & "," & Employee(MyJobs(C).ITStaffID).FirstName & " " & Employee(MyJobs(C).ITStaffID).LastName & "," & Employee(MyJobs(C).EmployeeID).FirstName & " " & Employee(MyJobs(C).EmployeeID).LastName & "," & MyJobs(C).DateIn & "," & MyJobs(C).DateDue & "," & myStatus
        Next
        ExportCSVCosts.Filter = "Excel File | *.csv"
        ExportCSVCosts.DefaultExt = "csv"
        Dim result As System.Nullable(Of Boolean) = ExportCSVCosts.ShowDialog()
        If result = True Then
            FileOpen(11, ExportCSVCosts.FileName, OpenMode.Output)
            Print(11, WriteString)
            FileClose(11)
        End If
    End Sub
    Private Sub ExportAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportAll.Click
        Dim WriteString As String = "Job ID,Job Reference,Assigned To,Call From,Date Added,Date Due,Status"
        For C = 1 To NoOfJobs
            Dim myStatus As String
            If Job(C).Status = 1 Then
                myStatus = "Outstanding"
            ElseIf Job(C).Status = 2 Then
                myStatus = "In Progress"
            Else
                myStatus = "Completed"
            End If
            WriteString = WriteString & vbNewLine & Job(C).ID & "," & Job(C).Ref & "," & Employee(Job(C).ITStaffID).FirstName & " " & Employee(Job(C).ITStaffID).LastName & "," & Employee(Job(C).EmployeeID).FirstName & " " & Employee(Job(C).EmployeeID).LastName & "," & Job(C).DateIn & "," & Job(C).DateDue & "," & myStatus
        Next
        ExportCSVCosts.Filter = "Excel File | *.csv"
        ExportCSVCosts.DefaultExt = "csv"
        Dim result As System.Nullable(Of Boolean) = ExportCSVCosts.ShowDialog()
        If result = True Then
            FileOpen(11, ExportCSVCosts.FileName, OpenMode.Output)
            Print(11, WriteString)
            FileClose(11)
        End If
    End Sub

    'Month Calendar Routines
    Private Sub Calendar_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendar.DateChanged
        lbToday.Items.Clear()
        Dim NoToday As Integer = 0
        For C = 1 To NoOfJobs
            If Not Job(C).Status = 3 And Not Job(C).Archived And DateTime.Parse(Job(C).DateDue) = Calendar.SelectionStart.ToShortDateString Then
                NoToday += 1
                ReDim Preserve Today(NoToday)
                Today(NoToday) = Job(C).ID
            End If
        Next
        For C = 1 To NoToday
            lbToday.Items.Add("Job ID - " & Today(C))
        Next
    End Sub
    Private Sub btnToday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToday.Click
        Calendar.SelectionStart = DateTime.Parse(Date.Today)
    End Sub
    Private Sub lbToday_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbToday.DoubleClick
        If lbToday.Items.Count > 0 Then
            Cause = "EDIT"
            RecordN = Today(lbToday.SelectedIndex + 1)
            frmJobs.Show()
        End If
    End Sub

    'List box extra routines
    Private Sub lbMain_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbMain.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If Not lbMain.SelectedIndex = -1 Then
                cms.Show(MousePosition.X, MousePosition.Y)
            End If
        End If
    End Sub
    Private Sub cmsComplete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsComplete.Click
        If Not Status = 3 Then
            Job(MyJobs(lbMain.SelectedIndex + 1).ID).Status = 3
            SaveJobs()
            OnMeLoad()
            Display()
        Else
            MsgBox("This job is already complete", MsgBoxStyle.Information, "Error")
        End If
    End Sub
    Private Sub cmsArchive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsArchive.Click
        Job(MyJobs(lbMain.SelectedIndex + 1).ID).Archived = True
        SaveJobs()
        OnMeLoad()
        Display()
    End Sub

    'Any Other Rotuines
    Private Sub ArchivedItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewArchivedItemsToolStripMenuItem.Click
        frmArchivedView.Show()
    End Sub
    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuStrip_Exit.Click
        End
    End Sub
    Private Sub MenuStrip_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsLoad.Click
        frmSettings.Show()
    End Sub
    Private Sub Archive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Archive.Click
        For C = 1 To NoOfJobs
            If Job(C).DateDue < DateTime.Now.AddDays(-My.Settings.AAD) Then
                Job(C).Archived = True
            End If
        Next
        SaveJobs()
    End Sub
    Private Sub lblITStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblITStaff.DoubleClick
        frmProgress.Show()
    End Sub
    Private Sub ShowProgressToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowProgressToolStripMenuItem.Click
        frmProgress.Show()
    End Sub
End Class
