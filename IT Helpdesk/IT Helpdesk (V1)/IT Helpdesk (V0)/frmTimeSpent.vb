Public Class frmTimeSpent
    Public N As Integer
    'On load procedure
    Private Sub TimeSpent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'This loads in the time spent on each note related to job N
        'Job N is passed over when looking at this form
        Me.Text = "Time Spent On Job ID " & N
        'Clears all the items held previously in the list box
        lbTime.Items.Clear()
        'This matches up the Notes to the job and then adds the details of time and hours to the list box
        For C = 1 To NoOfNotes
            If Note(C).JobID = N And Note(C).Archived = False Then
                lbTime.Items.Add(Note(C).DateAdded & " - " & Note(C).Time & " Hours")
            End If
        Next
    End Sub

    'Listbox Selection Changed
    Private Sub lbTime_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbTime.SelectedIndexChanged
        'When the listbox index is changed this sub form will change the item selected in the job record form.
        frmJobs.cmbNoteSelector.SelectedIndex = lbTime.SelectedIndex + 1
    End Sub
End Class