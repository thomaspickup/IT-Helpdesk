Public Class frmArchivedView
    Dim AID As Integer

    'On Load Procedures
    Private Sub ArchivedView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Populate()
    End Sub
    Sub Populate()
        dgvJobs.Rows.Clear()
        dgvNotes.Rows.Clear()
        dgvEmp.Rows.Clear()
        dgvAssets.Rows.Clear()
        dgvDep.Rows.Clear()

        For C = 1 To NoOfJobs
            If Job(C).Archived Then
                dgvJobs.Rows.Add({Job(C).ID, Job(C).Category, Job(C).Ref, Employee(Job(C).ITStaffID).FirstName, Employee(Job(C).EmployeeID).FirstName, Job(C).DateIn, Job(C).Priority, Job(C).DateDue, Job(C).Status})
            End If
        Next
        For C = 1 To NoOfNotes
            If Note(C).Archived Or Job(Note(C).JobID).Archived Then
                dgvNotes.Rows.Add({Note(C).ID, Note(C).Progress & "%", Detail(Note(C).DescriptionID), Note(C).DateAdded, Note(C).JobID})
            End If
        Next
        For C = 1 To NoOfEmployees
            If Employee(C).Archived Then
                dgvEmp.Rows.Add({Employee(C).ID, Employee(C).FirstName, Employee(C).LastName, Employee(C).Gender, Employee(C).Email, Employee(C).PhoneExt, Employee(C).Mobile, Employee(C).Wage, Employee(C).DepartmentID, Employee(C).PriorityRanking})
            End If
        Next
        For C = 1 To NoOfAssets
            If Asset(C).Archived Or Employee(Asset(C).EmployeeID).Archived Then
                dgvAssets.Rows.Add({Asset(C).ID, Asset(C).Category, Detail(Asset(C).DescriptionID), Employee(Asset(C).EmployeeID).FirstName})
            End If
        Next
        For C = 1 To NoOfDepartments
            If Department(C).Archived Then
                dgvDep.Rows.Add({Department(C).ID, Department(C).Name, Department(C).PhoneNo, Department(C).Address, Department(C).Town, Department(C).County, Department(C).Postcode, Department(C).Internal})
            End If
        Next
    End Sub

    'UnArchive Button Clicks
    Private Sub dgvJobs_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvJobs.CellContentClick
        Dim colName As String = dgvJobs.Columns(e.ColumnIndex).Name
        If colName = "UnArchive" Then
            AID = dgvJobs.Rows(e.RowIndex).Cells(0).Value
            Job(AID).Archived = False
            SaveJobs()
            Populate()
        End If
    End Sub
    Private Sub dgvNotes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvNotes.CellContentClick
        Dim colName As String = dgvNotes.Columns(e.ColumnIndex).Name
        If colName = "UnArchiveNote" Then
            AID = dgvNotes.Rows(e.RowIndex).Cells(0).Value
            If Job(Note(AID).JobID).Archived Then
                Dim Result As DialogResult
                Result = MsgBox("The Note you want to unarchive is tied to a job that is archived, do you want to unarchive the job?", MsgBoxStyle.YesNo, "Job Is Archived")
                If Result = Windows.Forms.DialogResult.Yes Then
                    Job(Note(AID).JobID).Archived = False
                    SaveJobs()
                    Populate()
                End If
            Else
                Note(AID).Archived = False
                SaveNotes()
                Populate()
            End If
        End If
    End Sub
    Private Sub dgvEmp_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEmp.CellContentClick
        Dim colName As String = dgvEmp.Columns(e.ColumnIndex).Name
        If colName = "UnArchiveEmp" Then
            AID = dgvEmp.Rows(e.RowIndex).Cells(0).Value
            Employee(AID).Archived = False
            SaveEmployee()
            Populate()
        End If
    End Sub
    Private Sub dgvAssets_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAssets.CellContentClick
        Dim colName As String = dgvAssets.Columns(e.ColumnIndex).Name
        If colName = "UnArchiveAsset" Then
            AID = dgvAssets.Rows(e.RowIndex).Cells(0).Value
            If Employee(Asset(AID).EmployeeID).Archived Then
                Dim Result As DialogResult
                Result = MsgBox("The Asset you want to unarchive is tied to an Employee that is archived, do you want to unarchive the Employee?", MsgBoxStyle.YesNo, "Employee Is Archived")
                If Result = Windows.Forms.DialogResult.Yes Then
                    Employee(Asset(AID).EmployeeID).Archived = False
                    SaveEmployee()
                    Populate()
                End If
            Else
                Asset(AID).Archived = False
                SaveAssets()
                Populate()
            End If
        End If
    End Sub
    Private Sub dgvDep_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDep.CellContentClick
        Dim colName As String = dgvDep.Columns(e.ColumnIndex).Name
        If colName = "UnArchiveDep" Then
            AID = dgvDep.Rows(e.RowIndex).Cells(0).Value
            Department(AID).Archived = False
            SaveDepartments()
            Populate()
        End If
    End Sub

    'Any Other Procedures
    Private Sub ArchivedView_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.OnMeLoad()
        frmMain.Display()
    End Sub
End Class