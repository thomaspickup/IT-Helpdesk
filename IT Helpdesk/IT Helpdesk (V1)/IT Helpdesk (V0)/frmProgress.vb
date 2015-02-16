Public Class frmProgress
    'Holds the most recent Progress Value
    Dim Progress As Integer = 0

    'On Load Sub
    Private Sub Progress_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'This sets all the counters to 0
        Dim lbl As Integer = 0
        Dim pgb As Integer = 0
        'Old location used to keep the Y coordinate of the last placed progress bar
        Dim OldLocation As Integer = 0
        'If the selected index of the form is ALL
        If frmMain.cmbIT.SelectedIndex = 0 Then
            'Loops for all the jobs
            For C = 1 To NoOfJobs
                Progress = 0
                'If the job is not completed and not archived
                If Not Job(C).Status = 3 And Job(C).Archived = False Then
                    'Takes the progress from the most recent note
                    For D = 1 To NoOfNotes
                        If Note(D).JobID = Job(C).ID And Note(D).Archived = False Then
                            Progress = Note(D).Progress
                        End If
                    Next

                    'Creates a new label with the format Job ID - (JOBID)
                    Dim Label As New Label()
                    Label.Text = "Job ID - " & Job(C).ID
                    Label.Name = lbl
                    Label.Location = New Point(15, OldLocation + 15)
                    lbl += 1
                    Me.Controls.Add(Label)

                    'Creates a new progress bar along side the Label created
                    Dim progbar As New ProgressBar
                    progbar.Name = pgb
                    progbar.Increment(1)
                    progbar.Maximum = 100
                    progbar.Value = Progress
                    progbar.Size = New Size(301, 22)
                    progbar.Location = New Point(122, OldLocation + 15)
                    OldLocation = progbar.Location.Y + 22
                    pgb += 1
                    Me.Controls.Add(progbar)

                    'Changes the size of the form to accomodate progress bar
                    Me.Size = New Size(Me.Width, OldLocation + 57)
                End If
            Next
            'If the selected index isn't ALL or blank
        ElseIf frmMain.cmbIT.SelectedIndex <> -1 Then
            For C = 1 To NoOfJobs
                'If the job is not completed and not archived and the IT Staff Assigned to it is the same as the selected one
                If Not Job(C).Status = 3 And Job(C).Archived = False And Job(C).ITStaffID = ITEmployee(frmMain.cmbIT.SelectedIndex).ID Then
                    'Takes the progress from the most recent note
                    For D = 1 To NoOfNotes
                        If Note(D).JobID = Job(C).ID And Note(D).Archived = False Then
                            Progress = Note(D).Progress
                        End If
                    Next

                    'Creates a new label with the format Job ID - (JOBID)
                    Dim Label As New Label()
                    Label.Text = "Job ID - " & Job(C).ID
                    Label.Name = lbl
                    Label.Location = New Point(15, OldLocation + 15)
                    lbl += 1
                    Me.Controls.Add(Label)

                    'Creates a new progress bar along side the Label created
                    Dim progbar As New ProgressBar
                    progbar.Name = pgb
                    progbar.Increment(1)
                    progbar.Maximum = 100
                    progbar.Value = Progress
                    progbar.Size = New Size(301, 22)
                    progbar.Location = New Point(122, OldLocation + 15)
                    OldLocation = progbar.Location.Y + 22
                    pgb += 1
                    Me.Controls.Add(progbar)

                    'Changes the size of the form to accomodate progress bar
                    Me.Size = New Size(Me.Width, OldLocation + 62)
                End If
            Next
        End If

        'If there is no jobs found then it sets a label to "No Jobs Have Been Found"
        If pgb = 0 And lbl = 0 Then
            Me.Size = New Size(Me.Width, 92)
            Dim NF As New Label
            NF.Name = "lblNoneFound"
            NF.Text = "No Jobs Have Been Found"
            NF.Size = New Size(178, 22)
            NF.Location = New Point(137, 15)
            Me.Controls.Add(NF)
        End If
    End Sub
End Class