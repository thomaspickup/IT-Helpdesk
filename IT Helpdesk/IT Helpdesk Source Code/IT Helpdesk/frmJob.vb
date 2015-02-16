Public Class frmJobs
    Dim ID As Integer
    Dim N As Integer
    Dim Count As Integer
    Dim TimeJ As Single
    Dim Valid As Boolean
    Dim InvalidString As String

    'On Load Procedures
    Private Sub EditJobs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For C = 1 To NoOfJobCat
            cmbCategory.Items.Add(JobCategory(C))
        Next
        For C = 1 To NoOfEmployees
            cmbCF.Items.Add(Employee(C).FirstName & " " & Employee(C).LastName)
        Next
        For C = 1 To NoOfITStaff
            cmbAT.Items.Add(ITEmployee(C).FirstName & " " & ITEmployee(C).LastName)
        Next
        txtStatus.Enabled = False
        txtCost.Enabled = False
        txtDateAdded.Enabled = False
        txtCost.Text = Format(0, "currency")
        If frmMain.Cause = "NEW" Then
            Me.Text = "New Job"
            txtJobID.Text = NoOfJobs + 1
            txtJobID.Enabled = False
        ElseIf frmMain.Cause = "EDIT" Then
            ID = frmMain.RecordN
            Me.Text = "Job ID - " & ID
            If NoOfEmployees = 0 Then
                Me.Text = "New Job"
                frmMain.Cause = "NEW"
                txtJobID.Text = NoOfJobs + 1
                txtJobID.Enabled = False
            Else
                ID = frmMain.RecordN
                txtJobID.Text = Job(ID).ID
                txtJobRef.Text = Job(ID).Ref
                txtDescription.Text = Detail(Job(ID).DescriptionID)
                If Job(ID).Status = 1 Then
                    txtStatus.Text = "Outstanding"
                ElseIf Job(ID).Status = 2 Then
                    txtStatus.Text = "In Progress"
                Else
                    txtStatus.Text = "Complete"
                    txtJobRef.Enabled = False
                    btnComplete.Enabled = False
                    btnSaveJob.Enabled = False
                    txtDescription.Enabled = False
                    txtStatus.Enabled = False
                    txtDateDue.Enabled = False
                    cmbCategory.Enabled = False
                    cmbCF.Enabled = False
                    cmbAT.Enabled = False
                    btnSaveJob.Enabled = False
                    btnSaveNote.Enabled = False
                    btnArchiveNote.Enabled = False
                End If
                txtDateDue.Text = Job(ID).DateDue
                cmbCategory.Text = Job(ID).Category
                cmbCF.SelectedIndex = Job(ID).EmployeeID - 1
                For C = 1 To NoOfITStaff
                    If Job(ID).ITStaffID = ITEmployee(C).ID Then
                        cmbAT.SelectedIndex = C - 1
                    End If
                Next
                FindNotes()
            End If
        ElseIf frmMain.Cause = "VIEW" Then
            ID = frmMain.RecordN
            Me.Text = "Job ID - " & ID
            ID = frmMain.RecordN
            txtJobID.Text = Job(ID).ID
            txtJobRef.Text = Job(ID).Ref
            txtDescription.Text = Detail(Job(ID).DescriptionID)
            If Job(ID).Status = 1 Then
                txtStatus.Text = "Outstanding"
            ElseIf Job(ID).Status = 2 Then
                txtStatus.Text = "In Progress"
            Else
                txtStatus.Text = "Complete"
            End If
            txtDateDue.Text = Job(ID).DateDue
            cmbCategory.Text = Job(ID).Category
            cmbCF.SelectedIndex = Job(ID).EmployeeID - 1
            For C = 1 To NoOfITStaff
                If Job(ID).ITStaffID = ITEmployee(C).ID Then
                    cmbAT.SelectedIndex = C - 1
                End If
            Next
            txtJobRef.Enabled = False
            txtDescription.Enabled = False
            txtStatus.Enabled = False
            txtDateDue.Enabled = False
            cmbCategory.Enabled = False
            cmbCF.Enabled = False
            cmbAT.Enabled = False
            btnSaveJob.Enabled = False
            btnSaveNote.Enabled = False
            btnArchiveNote.Enabled = False
            FindNotes()
        End If

    End Sub

    'Job related procedures
    Private Sub btnSaveJob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveJob.Click
        If frmMain.Cause = "NEW" Then
            ValidateJob()
            If Valid Then
                NewDetail()
                ReDim Preserve Detail(NoOfDetails)
                Detail(NoOfDetails) = txtDescription.Text
                FileOpen(11, DirectoryLocation & "\details\" & NoOfDetails & ".txt", OpenMode.Output)
                PrintLine(11, Detail(NoOfDetails))
                FileClose(11)
                AddJob(txtJobRef.Text, JobCategory(cmbCategory.SelectedIndex + 1), NoOfDetails, ITEmployee(cmbAT.SelectedIndex + 1).ID, cmbCF.SelectedIndex + 1, txtDateDue.Text)
                Me.Close()
            Else
                MsgBox("One or more items of data you are trying to input is invalid. The errors are listed below..." & vbNewLine & vbNewLine & InvalidString, MsgBoxStyle.Exclamation, "Data is Invalid")
            End If
        Else
            UpdateJobs()
            SaveJobs()
        End If
    End Sub
    Private Sub btnComplete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComplete.Click
        UpdateJobs()
        Job(ID).Status = 3
        SaveJobs()
        Me.Close()
    End Sub
    Private Sub btnArchiveJob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArchiveJob.Click
        UpdateJobs()
        Job(ID).Archived = True
        SaveJobs()
        Me.Close()
    End Sub
    Private Sub btnNewJob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewJob.Click
        frmMain.Cause = "NEW"
        Me.Text = "New Job"
        txtJobID.Text = NoOfJobs + 1
        txtJobRef.Text = ""
        txtJobID.Enabled = False
        txtDateDue.Text = ""
        txtDescription.Text = ""
        cmbCategory.SelectedIndex = 0
        cmbCF.SelectedIndex = 0
        cmbAT.SelectedIndex = 0
        txtDescription.Enabled = True
        txtStatus.Enabled = False
        txtDateDue.Enabled = True
        cmbCategory.Enabled = True
        cmbCF.Enabled = True
        cmbAT.Enabled = True
        btnSaveJob.Enabled = True
        btnSaveNote.Enabled = True
        btnArchiveNote.Enabled = False
        btnComplete.Enabled = False
        btnArchiveJob.Enabled = False
    End Sub
    Sub UpdateJobs()
        ValidateJob()
        If Valid Then
            Job(ID).Ref = txtJobRef.Text
            Job(ID).DateDue = txtDateDue.Text
            Detail(Job(ID).DescriptionID) = txtDescription.Text
            FileOpen(11, DirectoryLocation & "\details\" & Job(ID).DescriptionID & ".txt", OpenMode.Output)
            PrintLine(11, Detail(Job(ID).DescriptionID))
            FileClose(11)
            Job(ID).Category = cmbCategory.Text
            Job(ID).EmployeeID = cmbCF.SelectedIndex + 1
            Job(ID).ITStaffID = cmbAT.SelectedIndex + 1
        Else
            MsgBox("One or more items of data you are trying to input is invalid. The errors are listed below..." & vbNewLine & vbNewLine & InvalidString, MsgBoxStyle.Exclamation, "Data is Invalid")
        End If
    End Sub
    Private Sub txtJobID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJobID.TextChanged
        If Val(txtJobID.Text) = 0 Then
        ElseIf Val(txtJobID.Text) <= NoOfJobs Then
            ID = Val(txtJobID.Text)
            txtJobID.Text = Job(ID).ID
            txtJobRef.Text = Job(ID).Ref
            txtDescription.Text = Detail(Job(ID).DescriptionID)
            If Job(ID).Status = 1 Then
                txtStatus.Text = "Outstanding"
            ElseIf Job(ID).Status = 2 Then
                txtStatus.Text = "In Progress"
            Else
                txtStatus.Text = "Complete"
                txtJobRef.Enabled = False
                btnComplete.Enabled = False
                btnSaveJob.Enabled = False
                txtDescription.Enabled = False
                txtStatus.Enabled = False
                txtDateDue.Enabled = False
                cmbCategory.Enabled = False
                cmbCF.Enabled = False
                cmbAT.Enabled = False
                btnSaveJob.Enabled = False
                btnSaveNote.Enabled = False
                btnArchiveNote.Enabled = False
            End If
            txtDateDue.Text = Job(ID).DateDue
            cmbCategory.Text = Job(ID).Category
            cmbCF.SelectedIndex = Job(ID).EmployeeID - 1
            For C = 1 To NoOfITStaff
                If Job(ID).ITStaffID = ITEmployee(C).ID Then
                    cmbAT.SelectedIndex = C - 1
                End If
            Next
            FindNotes()
        End If
    End Sub
    Sub ValidateJob()
        Valid = True
        InvalidString = ""
        If txtJobRef.Text = "" Then
            InvalidString = InvalidString & "No Job Reference Provided" & vbNewLine
            Valid = False
        End If
        If txtDescription.Text = "" Then
            InvalidString = InvalidString & "No Job Description Provided" & vbNewLine
            Valid = False
        End If
        If cmbCategory.SelectedIndex = -1 Then
            InvalidString = InvalidString & "No Category Selected Provided" & vbNewLine
            Valid = False
        End If
        If cmbCF.SelectedIndex = -1 Then
            InvalidString = InvalidString & "No Call From Provided" & vbNewLine
            Valid = False
        End If
        If cmbAT.SelectedIndex = -1 Then
            InvalidString = InvalidString & "No Assigned To Provided" & vbNewLine
            Valid = False
        End If
    End Sub

    'Note related procedures
    Sub FindNotes()
        NoOfMyNotes = 0
        TimeJ = 0
        txtNoteDes.Text = ""
        cmbNoteSelector.Items.Clear()
        cmbNoteSelector.Items.Add("New Note")
        For C = 1 To NoOfNotes
            If Note(C).JobID = ID And Not Note(C).Archived Then
                NoOfMyNotes += 1
                ReDim Preserve MyNote(NoOfMyNotes)
                MyNote(NoOfMyNotes).ID = Note(C).ID
                MyNote(NoOfMyNotes).DateAdded = Note(C).DateAdded
                MyNote(NoOfMyNotes).Progress = Note(C).Progress
                MyNote(NoOfMyNotes).DescriptionID = Note(C).DescriptionID
                MyNote(NoOfMyNotes).JobID = Note(C).JobID
                MyNote(NoOfMyNotes).Archived = Note(C).Archived
                MyNote(NoOfMyNotes).Time = Note(C).Time
                TimeJ = TimeJ + Note(C).Time
            End If
        Next
        txtCost.Text = Format((TimeJ * Employee(Job(ID).ITStaffID).Wage), "currency")
        For C = 1 To NoOfMyNotes
            cmbNoteSelector.Items.Add("Note Added " & MyNote(C).DateAdded)
        Next
        N = NoOfMyNotes
        If NoOfMyNotes > 0 Then
            cmbNoteSelector.SelectedIndex = N
        End If
    End Sub
    Private Sub cmbNoteSelector_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNoteSelector.SelectedIndexChanged
        If cmbNoteSelector.Text = "New Note" Then
            txtDateAdded.Text = Today.Date
            txtProgress.Text = ""
            txtNoteDes.Text = ""
        ElseIf Not NoOfMyNotes = 0 Then
            N = cmbNoteSelector.SelectedIndex
            txtDateAdded.Text = MyNote(N).DateAdded
            txtProgress.Text = MyNote(N).Progress
            txtNoteDes.Text = Detail(MyNote(N).DescriptionID)
            txtTimeSpent.Text = MyNote(N).Time
        End If
    End Sub
    Sub UpdateNotes()
        If NoOfMyNotes > 0 Then
            Detail(Note(N).DescriptionID) = txtNoteDes.Text
            FileOpen(11, DirectoryLocation & "\details\" & Note(N).DescriptionID & ".txt", OpenMode.Output)
            PrintLine(11, Detail(Note(N).DescriptionID))
            FileClose(11)
            MyNote(N).Time = txtTimeSpent.Text
        End If
    End Sub
    Sub TransferToNotes()
        If NoOfMyNotes > 0 Then
            If Valid Then
                UpdateNotes()
                Count = 1
                For C = 1 To NoOfNotes
                    If Not Count > NoOfMyNotes Then
                        If Note(C).ID = MyNote(Count).ID Then
                            Note(C).ID = MyNote(Count).ID
                            Note(C).Progress = MyNote(Count).Progress
                            Note(C).DescriptionID = MyNote(Count).DescriptionID
                            Note(C).DateAdded = MyNote(Count).DateAdded
                            Note(C).JobID = MyNote(Count).JobID
                            Note(C).Archived = MyNote(Count).Archived
                            Note(C).Time = MyNote(Count).Time
                            Count += 1
                        End If
                    End If
                Next C
                FileOpen(11, DirectoryLocation & "\details\" & MyNote(cmbNoteSelector.SelectedIndex).DescriptionID & ".txt", OpenMode.Output)
                Print(11, txtNoteDes.Text)
                FileClose(11)
                SaveNotes()
            Else
                MsgBox("One or more items of data you are trying to input is invalid. The errors are listed below..." & vbNewLine & vbNewLine & InvalidString, MsgBoxStyle.Exclamation, "Data is Invalid")
            End If
        End If
    End Sub
    Private Sub btnSaveNote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveNote.Click
        If cmbNoteSelector.Text = "New Note" Then
            ValidateNote()
            If Valid Then
                NewDetail()
                ReDim Preserve Detail(NoOfDetails)
                N = NoOfNotes + 1
                AddNote(txtProgress.Text, NoOfDetails, txtDateAdded.Text, ID, txtTimeSpent.Text)
                Detail(Note(N).DescriptionID) = txtNoteDes.Text
                FileOpen(11, DirectoryLocation & "\details\" & Note(N).DescriptionID & ".txt", OpenMode.Output)
                PrintLine(11, Detail(Note(N).DescriptionID))
                FileClose(11)
                FindNotes()
                If txtProgress.Text = 100 Then
                    Dim Result As DialogResult
                    Result = (MsgBox("The progress related to this note has been marked as 100% complete, would you like to auto-complete this job?", MsgBoxStyle.YesNo, "Auto-Complete?"))
                    If Result = Windows.Forms.DialogResult.Yes Then
                        UpdateJobs()
                        Job(ID).Status = 3
                        SaveJobs()
                        Me.Close()
                    End If
                Else
                    Job(ID).Status = 2
                    SaveJobs()
                End If
            Else
                MsgBox("One or more items of data you are trying to input is invalid. The errors are listed below..." & vbNewLine & vbNewLine & InvalidString, MsgBoxStyle.Exclamation, "Data is Invalid")
        End If
        ElseIf NoOfMyNotes > 0 Then
            TransferToNotes()
        End If
    End Sub
    Private Sub btnArchiveNote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArchiveNote.Click
        MyNote(N).Archived = True
        TransferToNotes()
    End Sub
    Sub ValidateNote()
        Valid = True
        InvalidString = ""
        If txtNoteDes.Text = "" Then
            InvalidString = InvalidString & "No Description Provided" & vbNewLine
            Valid = False
        End If
        If txtTimeSpent.Text = "" Then
            InvalidString = InvalidString & "No Time Spent Provided" & vbNewLine
            Valid = False
        Else
            If Not IsNumeric(txtTimeSpent.Text) Then
                InvalidString = InvalidString & "Time Spent Provided Is Invalid" & vbNewLine
                Valid = False
            End If
        End If
        If txtProgress.Text = "" Then
            InvalidString = InvalidString & "No Progress Provided" & vbNewLine
            Valid = False
        Else
            If Not IsNumeric(txtTimeSpent.Text) Then
                InvalidString = InvalidString & "Progress Provided Is Invalid" & vbNewLine
                Valid = False
            End If
        End If
    End Sub

    'Any Other Procedures
    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        NewDetail()
        ReDim Preserve Detail(NoOfDetails)
        Detail(NoOfDetails) = txtDescription.Text
        FileOpen(11, DirectoryLocation & "\details\" & NoOfDetails & ".txt", OpenMode.Output)
        PrintLine(11, Detail(NoOfDetails))
        FileClose(11)
        AddJob(txtJobRef.Text, JobCategory(cmbCategory.SelectedIndex + 1), NoOfDetails, ITEmployee(cmbAT.SelectedIndex + 1).ID, cmbCF.SelectedIndex + 1, txtDateDue.Text)
        For C = 1 To NoOfMyNotes
            NewDetail()
            ReDim Preserve Detail(NoOfDetails)
            N = NoOfNotes + 1
            AddNote(MyNote(C).Progress, NoOfDetails, MyNote(C).DateAdded, Job(NoOfJobs).ID, MyNote(C).Time)
            FileOpen(11, DirectoryLocation & "\details\" & NoOfDetails & ".txt", OpenMode.Output)
            PrintLine(11, Detail(MyNote(C).DescriptionID))
            FileClose(11)
        Next
        Me.Close()
    End Sub
    Private Sub lblCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCategory.Click
        Dim Result As DialogResult
        Result = MsgBox("Do you want to add a new category?", MsgBoxStyle.YesNo, "New category")
        If Result = Windows.Forms.DialogResult.Yes Then
            Dim NewCat As String = InputBox("Please enter the new category", "New category")
            NoOfJobCat += 1
            ReDim Preserve JobCategory(NoOfJobCat)
            JobCategory(NoOfJobCat) = NewCat
            FileOpen(12, DirectoryLocation & "\category.txt", OpenMode.Output)
            For C = 1 To NoOfJobCat
                PrintLine(12, JobCategory(C))
            Next
            cmbCategory.Items.Clear()
            For C = 1 To NoOfJobCat
                cmbCategory.Items.Add(JobCategory(C))
            Next
            FileClose(12)
        End If
    End Sub
    Private Sub EditJobs_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.OnMeLoad()
        frmMain.Display()
    End Sub
    Private Sub cmbCF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCF.SelectedIndexChanged
        If Not cmbCF.SelectedIndex = -1 Then
            Dim Priority As Integer
            Priority = Employee(cmbCF.SelectedIndex + 1).PriorityRanking
            Priority = Priority * 12

            Dim today As System.DateTime
            Dim duration As System.TimeSpan
            Dim answer As System.DateTime

            today = System.DateTime.Now
            duration = TimeSpan.FromHours(Priority)
            answer = today.Add(duration)

            txtDateDue.Value = answer
        End If
    End Sub
    Private Sub lblTimeSpent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTimeSpent.DoubleClick
        frmTimeSpent.N = ID
        frmTimeSpent.Show()
    End Sub
    Private Sub lblCallFrom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCallFrom.Click
        Dim Temp As Integer
        Temp = frmMain.RecordN
        frmMain.RecordN = Employee(cmbCF.SelectedIndex + 1).ID
        frmEmployee.Show()
        frmMain.RecordN = Temp
    End Sub
End Class