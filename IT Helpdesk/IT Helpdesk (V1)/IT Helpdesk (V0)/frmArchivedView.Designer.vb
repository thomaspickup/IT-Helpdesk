<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArchivedView
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
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.dgvDep = New System.Windows.Forms.DataGridView()
        Me.DepartmentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Town = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.County = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Postcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Internal = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.UnArchiveDep = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgvEmp = New System.Windows.Forms.DataGridView()
        Me.EmpID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneExt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mobile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Wage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriorityRanking = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnArchiveEmp = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvNotes = New System.Windows.Forms.DataGridView()
        Me.NoteID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Progress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteDateAdded = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobIDRT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnArchiveNote = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvJobs = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITStaff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Priority = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnArchive = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dgvAssets = New System.Windows.Forms.DataGridView()
        Me.AssetID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssetCat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssetDes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeRel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnArchiveAsset = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabPage5.SuspendLayout()
        CType(Me.dgvDep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvJobs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvAssets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.dgvDep)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(886, 303)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Departments"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'dgvDep
        '
        Me.dgvDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDep.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DepartmentID, Me.DepName, Me.PhoneNum, Me.Address, Me.Town, Me.County, Me.Postcode, Me.Internal, Me.UnArchiveDep})
        Me.dgvDep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDep.Location = New System.Drawing.Point(0, 0)
        Me.dgvDep.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvDep.Name = "dgvDep"
        Me.dgvDep.Size = New System.Drawing.Size(886, 303)
        Me.dgvDep.TabIndex = 0
        '
        'DepartmentID
        '
        Me.DepartmentID.HeaderText = "ID"
        Me.DepartmentID.Name = "DepartmentID"
        Me.DepartmentID.ReadOnly = True
        '
        'DepName
        '
        Me.DepName.HeaderText = "Name"
        Me.DepName.Name = "DepName"
        Me.DepName.ReadOnly = True
        '
        'PhoneNum
        '
        Me.PhoneNum.HeaderText = "Phone Number"
        Me.PhoneNum.Name = "PhoneNum"
        Me.PhoneNum.ReadOnly = True
        '
        'Address
        '
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        '
        'Town
        '
        Me.Town.HeaderText = "Town"
        Me.Town.Name = "Town"
        Me.Town.ReadOnly = True
        '
        'County
        '
        Me.County.HeaderText = "County"
        Me.County.Name = "County"
        Me.County.ReadOnly = True
        '
        'Postcode
        '
        Me.Postcode.HeaderText = "Postcode"
        Me.Postcode.Name = "Postcode"
        Me.Postcode.ReadOnly = True
        '
        'Internal
        '
        Me.Internal.HeaderText = "Internal"
        Me.Internal.Name = "Internal"
        Me.Internal.ReadOnly = True
        '
        'UnArchiveDep
        '
        Me.UnArchiveDep.HeaderText = "UnArchive"
        Me.UnArchiveDep.Name = "UnArchiveDep"
        Me.UnArchiveDep.ReadOnly = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgvEmp)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(886, 303)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Employees"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgvEmp
        '
        Me.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpID, Me.FName, Me.LName, Me.Gender, Me.Email, Me.PhoneExt, Me.Mobile, Me.Wage, Me.DepID, Me.PriorityRanking, Me.UnArchiveEmp})
        Me.dgvEmp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEmp.Location = New System.Drawing.Point(0, 0)
        Me.dgvEmp.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvEmp.Name = "dgvEmp"
        Me.dgvEmp.Size = New System.Drawing.Size(886, 303)
        Me.dgvEmp.TabIndex = 0
        '
        'EmpID
        '
        Me.EmpID.HeaderText = "Employee ID"
        Me.EmpID.Name = "EmpID"
        Me.EmpID.ReadOnly = True
        '
        'FName
        '
        Me.FName.HeaderText = "First Name"
        Me.FName.Name = "FName"
        Me.FName.ReadOnly = True
        '
        'LName
        '
        Me.LName.HeaderText = "Last Name"
        Me.LName.Name = "LName"
        Me.LName.ReadOnly = True
        '
        'Gender
        '
        Me.Gender.HeaderText = "Gender"
        Me.Gender.Name = "Gender"
        Me.Gender.ReadOnly = True
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        '
        'PhoneExt
        '
        Me.PhoneExt.HeaderText = "Phone Extension"
        Me.PhoneExt.Name = "PhoneExt"
        Me.PhoneExt.ReadOnly = True
        '
        'Mobile
        '
        Me.Mobile.HeaderText = "Mobile"
        Me.Mobile.Name = "Mobile"
        Me.Mobile.ReadOnly = True
        '
        'Wage
        '
        Me.Wage.HeaderText = "Wage"
        Me.Wage.Name = "Wage"
        Me.Wage.ReadOnly = True
        '
        'DepID
        '
        Me.DepID.HeaderText = "Department"
        Me.DepID.Name = "DepID"
        Me.DepID.ReadOnly = True
        '
        'PriorityRanking
        '
        Me.PriorityRanking.HeaderText = "Priority Ranking"
        Me.PriorityRanking.Name = "PriorityRanking"
        Me.PriorityRanking.ReadOnly = True
        '
        'UnArchiveEmp
        '
        Me.UnArchiveEmp.HeaderText = "UnArchive"
        Me.UnArchiveEmp.Name = "UnArchiveEmp"
        Me.UnArchiveEmp.ReadOnly = True
        Me.UnArchiveEmp.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UnArchiveEmp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvNotes)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(886, 303)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Notes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvNotes
        '
        Me.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoteID, Me.Progress, Me.NoteDescription, Me.NoteDateAdded, Me.JobIDRT, Me.UnArchiveNote})
        Me.dgvNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvNotes.Location = New System.Drawing.Point(2, 2)
        Me.dgvNotes.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvNotes.Name = "dgvNotes"
        Me.dgvNotes.Size = New System.Drawing.Size(882, 299)
        Me.dgvNotes.TabIndex = 0
        '
        'NoteID
        '
        Me.NoteID.HeaderText = "ID"
        Me.NoteID.Name = "NoteID"
        Me.NoteID.ReadOnly = True
        '
        'Progress
        '
        Me.Progress.HeaderText = "Progress"
        Me.Progress.Name = "Progress"
        '
        'NoteDescription
        '
        Me.NoteDescription.HeaderText = "Description"
        Me.NoteDescription.Name = "NoteDescription"
        Me.NoteDescription.ReadOnly = True
        '
        'NoteDateAdded
        '
        Me.NoteDateAdded.HeaderText = "Date Added"
        Me.NoteDateAdded.Name = "NoteDateAdded"
        Me.NoteDateAdded.ReadOnly = True
        '
        'JobIDRT
        '
        Me.JobIDRT.HeaderText = "Job ID"
        Me.JobIDRT.Name = "JobIDRT"
        Me.JobIDRT.ReadOnly = True
        '
        'UnArchiveNote
        '
        Me.UnArchiveNote.HeaderText = "Unarchive"
        Me.UnArchiveNote.Name = "UnArchiveNote"
        Me.UnArchiveNote.ReadOnly = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvJobs)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(886, 303)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Jobs"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvJobs
        '
        Me.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJobs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Category, Me.Description, Me.ITStaff, Me.EmployeeID, Me.DateIn, Me.Priority, Me.DateDue, Me.Status, Me.UnArchive})
        Me.dgvJobs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvJobs.Location = New System.Drawing.Point(2, 2)
        Me.dgvJobs.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvJobs.Name = "dgvJobs"
        Me.dgvJobs.RowTemplate.Height = 24
        Me.dgvJobs.Size = New System.Drawing.Size(882, 299)
        Me.dgvJobs.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Category
        '
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'ITStaff
        '
        Me.ITStaff.HeaderText = "IT Staff"
        Me.ITStaff.Name = "ITStaff"
        Me.ITStaff.ReadOnly = True
        '
        'EmployeeID
        '
        Me.EmployeeID.HeaderText = "Employee"
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.ReadOnly = True
        '
        'DateIn
        '
        Me.DateIn.HeaderText = "Date Logged"
        Me.DateIn.Name = "DateIn"
        Me.DateIn.ReadOnly = True
        '
        'Priority
        '
        Me.Priority.HeaderText = "Priority"
        Me.Priority.Name = "Priority"
        Me.Priority.ReadOnly = True
        '
        'DateDue
        '
        Me.DateDue.HeaderText = "Date Due"
        Me.DateDue.Name = "DateDue"
        Me.DateDue.ReadOnly = True
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'UnArchive
        '
        Me.UnArchive.HeaderText = "Unarchive"
        Me.UnArchive.Name = "UnArchive"
        Me.UnArchive.ReadOnly = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(894, 329)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dgvAssets)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(886, 303)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Assets"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dgvAssets
        '
        Me.dgvAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAssets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AssetID, Me.AssetCat, Me.AssetDes, Me.EmployeeRel, Me.UnArchiveAsset})
        Me.dgvAssets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAssets.Location = New System.Drawing.Point(0, 0)
        Me.dgvAssets.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvAssets.Name = "dgvAssets"
        Me.dgvAssets.Size = New System.Drawing.Size(886, 303)
        Me.dgvAssets.TabIndex = 0
        '
        'AssetID
        '
        Me.AssetID.HeaderText = "ID"
        Me.AssetID.Name = "AssetID"
        Me.AssetID.ReadOnly = True
        '
        'AssetCat
        '
        Me.AssetCat.HeaderText = "Category"
        Me.AssetCat.Name = "AssetCat"
        Me.AssetCat.ReadOnly = True
        '
        'AssetDes
        '
        Me.AssetDes.HeaderText = "Description"
        Me.AssetDes.Name = "AssetDes"
        Me.AssetDes.ReadOnly = True
        '
        'EmployeeRel
        '
        Me.EmployeeRel.HeaderText = "Employee"
        Me.EmployeeRel.Name = "EmployeeRel"
        Me.EmployeeRel.ReadOnly = True
        '
        'UnArchiveAsset
        '
        Me.UnArchiveAsset.HeaderText = "UnArchive"
        Me.UnArchiveAsset.Name = "UnArchiveAsset"
        Me.UnArchiveAsset.ReadOnly = True
        '
        'frmArchivedView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 329)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmArchivedView"
        Me.Text = "Archived"
        Me.TabPage5.ResumeLayout(False)
        CType(Me.dgvDep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgvEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvJobs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dgvAssets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents dgvDep As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgvEmp As System.Windows.Forms.DataGridView
    Friend WithEvents EmpID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Gender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneExt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mobile As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Wage As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriorityRanking As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnArchiveEmp As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgvNotes As System.Windows.Forms.DataGridView
    Friend WithEvents NoteID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Progress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoteDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoteDateAdded As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JobIDRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnArchiveNote As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgvJobs As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ITStaff As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateIn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Priority As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnArchive As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents dgvAssets As System.Windows.Forms.DataGridView
    Friend WithEvents AssetID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AssetCat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AssetDes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeRel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnArchiveAsset As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DepartmentID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Town As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents County As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Postcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Internal As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents UnArchiveDep As System.Windows.Forms.DataGridViewButtonColumn
End Class
