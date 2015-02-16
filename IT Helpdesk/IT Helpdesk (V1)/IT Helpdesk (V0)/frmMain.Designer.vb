<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip_File = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_New = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewEmp = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewDep = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewJob = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsLoad = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_Edit = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditEmp = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditDep = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditJob = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewEmp = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDep = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewJob = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Archive = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewArchivedItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowProgressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportJobCosts = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportCurrentSelection = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnalysisPanel = New System.Windows.Forms.Panel()
        Me.gbDepartments = New System.Windows.Forms.GroupBox()
        Me.btnViewDep = New System.Windows.Forms.Button()
        Me.btnEditDep = New System.Windows.Forms.Button()
        Me.btnNewDep = New System.Windows.Forms.Button()
        Me.gbEmployee = New System.Windows.Forms.GroupBox()
        Me.btnViewEmp = New System.Windows.Forms.Button()
        Me.btnEditEmp = New System.Windows.Forms.Button()
        Me.btnNewEmp = New System.Windows.Forms.Button()
        Me.gbJobs = New System.Windows.Forms.GroupBox()
        Me.btnViewJob = New System.Windows.Forms.Button()
        Me.btnEditJob = New System.Windows.Forms.Button()
        Me.btnNewJob = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtDueDate = New System.Windows.Forms.TextBox()
        Me.lblDateDue = New System.Windows.Forms.Label()
        Me.lblCallFrom = New System.Windows.Forms.Label()
        Me.cmbCallFrom = New System.Windows.Forms.ComboBox()
        Me.lblJobPreview = New System.Windows.Forms.Label()
        Me.txtJobPreview = New System.Windows.Forms.TextBox()
        Me.btnOutstanding = New System.Windows.Forms.Button()
        Me.btnCompleted = New System.Windows.Forms.Button()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.lblITStaff = New System.Windows.Forms.Label()
        Me.cmbIT = New System.Windows.Forms.ComboBox()
        Me.Calendar = New System.Windows.Forms.MonthCalendar()
        Me.QuickAccess = New System.Windows.Forms.Panel()
        Me.btnToday = New System.Windows.Forms.Button()
        Me.lbToday = New System.Windows.Forms.ListBox()
        Me.cms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsComplete = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsArchive = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbMain = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ExportCSVCosts = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip.SuspendLayout()
        Me.AnalysisPanel.SuspendLayout()
        Me.gbDepartments.SuspendLayout()
        Me.gbEmployee.SuspendLayout()
        Me.gbJobs.SuspendLayout()
        Me.QuickAccess.SuspendLayout()
        Me.cms.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStrip_File, Me.MenuStrip_Edit, Me.ToolStripMenuItem1, Me.ToolsToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(826, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'MenuStrip_File
        '
        Me.MenuStrip_File.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStrip_New, Me.SettingsLoad, Me.MenuStrip_Exit})
        Me.MenuStrip_File.Name = "MenuStrip_File"
        Me.MenuStrip_File.Size = New System.Drawing.Size(37, 20)
        Me.MenuStrip_File.Text = "File"
        '
        'MenuStrip_New
        '
        Me.MenuStrip_New.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewEmp, Me.NewDep, Me.NewJob})
        Me.MenuStrip_New.Name = "MenuStrip_New"
        Me.MenuStrip_New.Size = New System.Drawing.Size(116, 22)
        Me.MenuStrip_New.Text = "New"
        '
        'NewEmp
        '
        Me.NewEmp.Name = "NewEmp"
        Me.NewEmp.Size = New System.Drawing.Size(137, 22)
        Me.NewEmp.Text = "Employee"
        '
        'NewDep
        '
        Me.NewDep.Name = "NewDep"
        Me.NewDep.Size = New System.Drawing.Size(137, 22)
        Me.NewDep.Text = "Department"
        '
        'NewJob
        '
        Me.NewJob.Name = "NewJob"
        Me.NewJob.Size = New System.Drawing.Size(137, 22)
        Me.NewJob.Text = "Job"
        '
        'SettingsLoad
        '
        Me.SettingsLoad.Name = "SettingsLoad"
        Me.SettingsLoad.Size = New System.Drawing.Size(116, 22)
        Me.SettingsLoad.Text = "Settings"
        '
        'MenuStrip_Exit
        '
        Me.MenuStrip_Exit.Name = "MenuStrip_Exit"
        Me.MenuStrip_Exit.Size = New System.Drawing.Size(116, 22)
        Me.MenuStrip_Exit.Text = "Exit"
        '
        'MenuStrip_Edit
        '
        Me.MenuStrip_Edit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditEmp, Me.EditDep, Me.EditJob})
        Me.MenuStrip_Edit.Name = "MenuStrip_Edit"
        Me.MenuStrip_Edit.Size = New System.Drawing.Size(39, 20)
        Me.MenuStrip_Edit.Text = "Edit"
        '
        'EditEmp
        '
        Me.EditEmp.Name = "EditEmp"
        Me.EditEmp.Size = New System.Drawing.Size(137, 22)
        Me.EditEmp.Text = "Employee"
        '
        'EditDep
        '
        Me.EditDep.Name = "EditDep"
        Me.EditDep.Size = New System.Drawing.Size(137, 22)
        Me.EditDep.Text = "Department"
        '
        'EditJob
        '
        Me.EditJob.Name = "EditJob"
        Me.EditJob.Size = New System.Drawing.Size(137, 22)
        Me.EditJob.Text = "Job"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewEmp, Me.ViewDep, Me.ViewJob})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.ToolStripMenuItem1.Text = "View"
        '
        'ViewEmp
        '
        Me.ViewEmp.Name = "ViewEmp"
        Me.ViewEmp.Size = New System.Drawing.Size(137, 22)
        Me.ViewEmp.Text = "Employee"
        '
        'ViewDep
        '
        Me.ViewDep.Name = "ViewDep"
        Me.ViewDep.Size = New System.Drawing.Size(137, 22)
        Me.ViewDep.Text = "Department"
        '
        'ViewJob
        '
        Me.ViewJob.Name = "ViewJob"
        Me.ViewJob.Size = New System.Drawing.Size(137, 22)
        Me.ViewJob.Text = "Job"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Archive, Me.ViewArchivedItemsToolStripMenuItem, Me.ShowProgressToolStripMenuItem, Me.ExportJobCosts, Me.ExportAll, Me.ExportCurrentSelection})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'Archive
        '
        Me.Archive.Name = "Archive"
        Me.Archive.Size = New System.Drawing.Size(201, 22)
        Me.Archive.Text = "Archive"
        '
        'ViewArchivedItemsToolStripMenuItem
        '
        Me.ViewArchivedItemsToolStripMenuItem.Name = "ViewArchivedItemsToolStripMenuItem"
        Me.ViewArchivedItemsToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ViewArchivedItemsToolStripMenuItem.Text = "View Archived Items"
        '
        'ShowProgressToolStripMenuItem
        '
        Me.ShowProgressToolStripMenuItem.Name = "ShowProgressToolStripMenuItem"
        Me.ShowProgressToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ShowProgressToolStripMenuItem.Text = "Show Progress"
        '
        'ExportJobCosts
        '
        Me.ExportJobCosts.Name = "ExportJobCosts"
        Me.ExportJobCosts.Size = New System.Drawing.Size(201, 22)
        Me.ExportJobCosts.Text = "Export  Job Costs"
        '
        'ExportAll
        '
        Me.ExportAll.Name = "ExportAll"
        Me.ExportAll.Size = New System.Drawing.Size(201, 22)
        Me.ExportAll.Text = "Export All Jobs"
        '
        'ExportCurrentSelection
        '
        Me.ExportCurrentSelection.Name = "ExportCurrentSelection"
        Me.ExportCurrentSelection.Size = New System.Drawing.Size(201, 22)
        Me.ExportCurrentSelection.Text = "Export Current Selection"
        '
        'AnalysisPanel
        '
        Me.AnalysisPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AnalysisPanel.Controls.Add(Me.gbDepartments)
        Me.AnalysisPanel.Controls.Add(Me.gbEmployee)
        Me.AnalysisPanel.Controls.Add(Me.gbJobs)
        Me.AnalysisPanel.Controls.Add(Me.btnSearch)
        Me.AnalysisPanel.Controls.Add(Me.txtSearch)
        Me.AnalysisPanel.Controls.Add(Me.txtDueDate)
        Me.AnalysisPanel.Controls.Add(Me.lblDateDue)
        Me.AnalysisPanel.Controls.Add(Me.lblCallFrom)
        Me.AnalysisPanel.Controls.Add(Me.cmbCallFrom)
        Me.AnalysisPanel.Controls.Add(Me.lblJobPreview)
        Me.AnalysisPanel.Controls.Add(Me.txtJobPreview)
        Me.AnalysisPanel.Controls.Add(Me.btnOutstanding)
        Me.AnalysisPanel.Controls.Add(Me.btnCompleted)
        Me.AnalysisPanel.Controls.Add(Me.btnAll)
        Me.AnalysisPanel.Controls.Add(Me.lblITStaff)
        Me.AnalysisPanel.Controls.Add(Me.cmbIT)
        Me.AnalysisPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.AnalysisPanel.Location = New System.Drawing.Point(0, 24)
        Me.AnalysisPanel.Name = "AnalysisPanel"
        Me.AnalysisPanel.Size = New System.Drawing.Size(227, 512)
        Me.AnalysisPanel.TabIndex = 1
        '
        'gbDepartments
        '
        Me.gbDepartments.Controls.Add(Me.btnViewDep)
        Me.gbDepartments.Controls.Add(Me.btnEditDep)
        Me.gbDepartments.Controls.Add(Me.btnNewDep)
        Me.gbDepartments.Location = New System.Drawing.Point(8, 442)
        Me.gbDepartments.Margin = New System.Windows.Forms.Padding(2)
        Me.gbDepartments.Name = "gbDepartments"
        Me.gbDepartments.Padding = New System.Windows.Forms.Padding(2)
        Me.gbDepartments.Size = New System.Drawing.Size(205, 59)
        Me.gbDepartments.TabIndex = 25
        Me.gbDepartments.TabStop = False
        Me.gbDepartments.Text = "Departments"
        '
        'btnViewDep
        '
        Me.btnViewDep.Location = New System.Drawing.Point(140, 24)
        Me.btnViewDep.Margin = New System.Windows.Forms.Padding(2)
        Me.btnViewDep.Name = "btnViewDep"
        Me.btnViewDep.Size = New System.Drawing.Size(60, 23)
        Me.btnViewDep.TabIndex = 16
        Me.btnViewDep.Text = "View"
        Me.btnViewDep.UseVisualStyleBackColor = True
        '
        'btnEditDep
        '
        Me.btnEditDep.Location = New System.Drawing.Point(69, 24)
        Me.btnEditDep.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditDep.Name = "btnEditDep"
        Me.btnEditDep.Size = New System.Drawing.Size(67, 23)
        Me.btnEditDep.TabIndex = 14
        Me.btnEditDep.Text = "Edit"
        Me.btnEditDep.UseVisualStyleBackColor = True
        '
        'btnNewDep
        '
        Me.btnNewDep.Location = New System.Drawing.Point(4, 24)
        Me.btnNewDep.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNewDep.Name = "btnNewDep"
        Me.btnNewDep.Size = New System.Drawing.Size(60, 23)
        Me.btnNewDep.TabIndex = 15
        Me.btnNewDep.Text = "New"
        Me.btnNewDep.UseVisualStyleBackColor = True
        '
        'gbEmployee
        '
        Me.gbEmployee.Controls.Add(Me.btnViewEmp)
        Me.gbEmployee.Controls.Add(Me.btnEditEmp)
        Me.gbEmployee.Controls.Add(Me.btnNewEmp)
        Me.gbEmployee.Location = New System.Drawing.Point(8, 381)
        Me.gbEmployee.Margin = New System.Windows.Forms.Padding(2)
        Me.gbEmployee.Name = "gbEmployee"
        Me.gbEmployee.Padding = New System.Windows.Forms.Padding(2)
        Me.gbEmployee.Size = New System.Drawing.Size(205, 56)
        Me.gbEmployee.TabIndex = 24
        Me.gbEmployee.TabStop = False
        Me.gbEmployee.Text = "Employees"
        '
        'btnViewEmp
        '
        Me.btnViewEmp.Location = New System.Drawing.Point(140, 24)
        Me.btnViewEmp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnViewEmp.Name = "btnViewEmp"
        Me.btnViewEmp.Size = New System.Drawing.Size(60, 23)
        Me.btnViewEmp.TabIndex = 16
        Me.btnViewEmp.Text = "View"
        Me.btnViewEmp.UseVisualStyleBackColor = True
        '
        'btnEditEmp
        '
        Me.btnEditEmp.Location = New System.Drawing.Point(69, 24)
        Me.btnEditEmp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditEmp.Name = "btnEditEmp"
        Me.btnEditEmp.Size = New System.Drawing.Size(67, 23)
        Me.btnEditEmp.TabIndex = 14
        Me.btnEditEmp.Text = "Edit"
        Me.btnEditEmp.UseVisualStyleBackColor = True
        '
        'btnNewEmp
        '
        Me.btnNewEmp.Location = New System.Drawing.Point(4, 24)
        Me.btnNewEmp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNewEmp.Name = "btnNewEmp"
        Me.btnNewEmp.Size = New System.Drawing.Size(60, 23)
        Me.btnNewEmp.TabIndex = 15
        Me.btnNewEmp.Text = "New"
        Me.btnNewEmp.UseVisualStyleBackColor = True
        '
        'gbJobs
        '
        Me.gbJobs.Controls.Add(Me.btnViewJob)
        Me.gbJobs.Controls.Add(Me.btnEditJob)
        Me.gbJobs.Controls.Add(Me.btnNewJob)
        Me.gbJobs.Location = New System.Drawing.Point(8, 319)
        Me.gbJobs.Margin = New System.Windows.Forms.Padding(2)
        Me.gbJobs.Name = "gbJobs"
        Me.gbJobs.Padding = New System.Windows.Forms.Padding(2)
        Me.gbJobs.Size = New System.Drawing.Size(205, 57)
        Me.gbJobs.TabIndex = 23
        Me.gbJobs.TabStop = False
        Me.gbJobs.Text = "Jobs"
        '
        'btnViewJob
        '
        Me.btnViewJob.Location = New System.Drawing.Point(140, 24)
        Me.btnViewJob.Margin = New System.Windows.Forms.Padding(2)
        Me.btnViewJob.Name = "btnViewJob"
        Me.btnViewJob.Size = New System.Drawing.Size(60, 23)
        Me.btnViewJob.TabIndex = 16
        Me.btnViewJob.Text = "View"
        Me.btnViewJob.UseVisualStyleBackColor = True
        '
        'btnEditJob
        '
        Me.btnEditJob.Location = New System.Drawing.Point(69, 24)
        Me.btnEditJob.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditJob.Name = "btnEditJob"
        Me.btnEditJob.Size = New System.Drawing.Size(67, 23)
        Me.btnEditJob.TabIndex = 14
        Me.btnEditJob.Text = "Edit"
        Me.btnEditJob.UseVisualStyleBackColor = True
        '
        'btnNewJob
        '
        Me.btnNewJob.Location = New System.Drawing.Point(4, 24)
        Me.btnNewJob.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNewJob.Name = "btnNewJob"
        Me.btnNewJob.Size = New System.Drawing.Size(60, 23)
        Me.btnNewJob.TabIndex = 15
        Me.btnNewJob.Text = "New"
        Me.btnNewJob.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(134, 13)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 23)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(13, 15)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(115, 20)
        Me.txtSearch.TabIndex = 12
        '
        'txtDueDate
        '
        Me.txtDueDate.Location = New System.Drawing.Point(70, 285)
        Me.txtDueDate.Name = "txtDueDate"
        Me.txtDueDate.Size = New System.Drawing.Size(145, 20)
        Me.txtDueDate.TabIndex = 11
        '
        'lblDateDue
        '
        Me.lblDateDue.AutoSize = True
        Me.lblDateDue.Location = New System.Drawing.Point(10, 288)
        Me.lblDateDue.Name = "lblDateDue"
        Me.lblDateDue.Size = New System.Drawing.Size(53, 13)
        Me.lblDateDue.TabIndex = 10
        Me.lblDateDue.Text = "Due Date"
        '
        'lblCallFrom
        '
        Me.lblCallFrom.AutoSize = True
        Me.lblCallFrom.Location = New System.Drawing.Point(9, 71)
        Me.lblCallFrom.Name = "lblCallFrom"
        Me.lblCallFrom.Size = New System.Drawing.Size(50, 13)
        Me.lblCallFrom.TabIndex = 9
        Me.lblCallFrom.Text = "Call From"
        '
        'cmbCallFrom
        '
        Me.cmbCallFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCallFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCallFrom.FormattingEnabled = True
        Me.cmbCallFrom.Location = New System.Drawing.Point(65, 68)
        Me.cmbCallFrom.Name = "cmbCallFrom"
        Me.cmbCallFrom.Size = New System.Drawing.Size(149, 21)
        Me.cmbCallFrom.TabIndex = 8
        '
        'lblJobPreview
        '
        Me.lblJobPreview.AutoSize = True
        Me.lblJobPreview.Location = New System.Drawing.Point(10, 128)
        Me.lblJobPreview.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblJobPreview.Name = "lblJobPreview"
        Me.lblJobPreview.Size = New System.Drawing.Size(65, 13)
        Me.lblJobPreview.TabIndex = 7
        Me.lblJobPreview.Text = "Job Preview"
        '
        'txtJobPreview
        '
        Me.txtJobPreview.Location = New System.Drawing.Point(12, 144)
        Me.txtJobPreview.Margin = New System.Windows.Forms.Padding(2)
        Me.txtJobPreview.Multiline = True
        Me.txtJobPreview.Name = "txtJobPreview"
        Me.txtJobPreview.Size = New System.Drawing.Size(203, 137)
        Me.txtJobPreview.TabIndex = 6
        '
        'btnOutstanding
        '
        Me.btnOutstanding.Location = New System.Drawing.Point(137, 97)
        Me.btnOutstanding.Name = "btnOutstanding"
        Me.btnOutstanding.Size = New System.Drawing.Size(75, 23)
        Me.btnOutstanding.TabIndex = 5
        Me.btnOutstanding.Text = "Outstanding"
        Me.btnOutstanding.UseVisualStyleBackColor = True
        '
        'btnCompleted
        '
        Me.btnCompleted.Location = New System.Drawing.Point(64, 97)
        Me.btnCompleted.Name = "btnCompleted"
        Me.btnCompleted.Size = New System.Drawing.Size(68, 23)
        Me.btnCompleted.TabIndex = 4
        Me.btnCompleted.Text = "Completed"
        Me.btnCompleted.UseVisualStyleBackColor = True
        '
        'btnAll
        '
        Me.btnAll.Location = New System.Drawing.Point(11, 97)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(49, 23)
        Me.btnAll.TabIndex = 3
        Me.btnAll.Text = "All"
        Me.btnAll.UseVisualStyleBackColor = True
        '
        'lblITStaff
        '
        Me.lblITStaff.AutoSize = True
        Me.lblITStaff.Location = New System.Drawing.Point(10, 45)
        Me.lblITStaff.Name = "lblITStaff"
        Me.lblITStaff.Size = New System.Drawing.Size(42, 13)
        Me.lblITStaff.TabIndex = 2
        Me.lblITStaff.Text = "IT Staff"
        '
        'cmbIT
        '
        Me.cmbIT.FormattingEnabled = True
        Me.cmbIT.Location = New System.Drawing.Point(65, 42)
        Me.cmbIT.Name = "cmbIT"
        Me.cmbIT.Size = New System.Drawing.Size(149, 21)
        Me.cmbIT.TabIndex = 1
        '
        'Calendar
        '
        Me.Calendar.Location = New System.Drawing.Point(7, 10)
        Me.Calendar.Margin = New System.Windows.Forms.Padding(7)
        Me.Calendar.Name = "Calendar"
        Me.Calendar.RightToLeftLayout = True
        Me.Calendar.TabIndex = 14
        '
        'QuickAccess
        '
        Me.QuickAccess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QuickAccess.Controls.Add(Me.btnToday)
        Me.QuickAccess.Controls.Add(Me.lbToday)
        Me.QuickAccess.Controls.Add(Me.Calendar)
        Me.QuickAccess.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.QuickAccess.Location = New System.Drawing.Point(227, 351)
        Me.QuickAccess.Name = "QuickAccess"
        Me.QuickAccess.Size = New System.Drawing.Size(599, 185)
        Me.QuickAccess.TabIndex = 4
        '
        'btnToday
        '
        Me.btnToday.Location = New System.Drawing.Point(512, 150)
        Me.btnToday.Name = "btnToday"
        Me.btnToday.Size = New System.Drawing.Size(75, 22)
        Me.btnToday.TabIndex = 15
        Me.btnToday.Text = "Today"
        Me.btnToday.UseVisualStyleBackColor = True
        '
        'lbToday
        '
        Me.lbToday.FormattingEnabled = True
        Me.lbToday.Location = New System.Drawing.Point(239, 11)
        Me.lbToday.Margin = New System.Windows.Forms.Padding(2)
        Me.lbToday.Name = "lbToday"
        Me.lbToday.Size = New System.Drawing.Size(348, 134)
        Me.lbToday.TabIndex = 15
        '
        'cms
        '
        Me.cms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsComplete, Me.cmsArchive})
        Me.cms.Name = "cms"
        Me.cms.Size = New System.Drawing.Size(127, 48)
        '
        'cmsComplete
        '
        Me.cmsComplete.Name = "cmsComplete"
        Me.cmsComplete.Size = New System.Drawing.Size(126, 22)
        Me.cmsComplete.Text = "Complete"
        '
        'cmsArchive
        '
        Me.cmsArchive.Name = "cmsArchive"
        Me.cmsArchive.Size = New System.Drawing.Size(126, 22)
        Me.cmsArchive.Text = "Archive"
        '
        'lbMain
        '
        Me.lbMain.BackColor = System.Drawing.SystemColors.Window
        Me.lbMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbMain.FormattingEnabled = True
        Me.lbMain.Location = New System.Drawing.Point(0, 0)
        Me.lbMain.Margin = New System.Windows.Forms.Padding(2)
        Me.lbMain.Name = "lbMain"
        Me.lbMain.Size = New System.Drawing.Size(597, 325)
        Me.lbMain.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(227, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(599, 327)
        Me.Panel1.TabIndex = 6
        '
        'ExportCSVCosts
        '
        Me.ExportCSVCosts.DefaultExt = "csv"
        Me.ExportCSVCosts.InitialDirectory = "C:\"
        Me.ExportCSVCosts.Title = "Export"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 536)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.QuickAccess)
        Me.Controls.Add(Me.AnalysisPanel)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "IT Helpdesk"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.AnalysisPanel.ResumeLayout(False)
        Me.AnalysisPanel.PerformLayout()
        Me.gbDepartments.ResumeLayout(False)
        Me.gbEmployee.ResumeLayout(False)
        Me.gbJobs.ResumeLayout(False)
        Me.QuickAccess.ResumeLayout(False)
        Me.cms.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuStrip_File As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip_New As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnalysisPanel As System.Windows.Forms.Panel
    Friend WithEvents NewEmp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewDep As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewJob As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsLoad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip_Exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblITStaff As System.Windows.Forms.Label
    Friend WithEvents cmbIT As System.Windows.Forms.ComboBox
    Friend WithEvents btnOutstanding As System.Windows.Forms.Button
    Friend WithEvents btnCompleted As System.Windows.Forms.Button
    Friend WithEvents btnAll As System.Windows.Forms.Button
    Friend WithEvents QuickAccess As System.Windows.Forms.Panel
    Friend WithEvents lblJobPreview As System.Windows.Forms.Label
    Friend WithEvents txtJobPreview As System.Windows.Forms.TextBox
    Friend WithEvents lblCallFrom As System.Windows.Forms.Label
    Friend WithEvents cmbCallFrom As System.Windows.Forms.ComboBox
    Friend WithEvents lblDateDue As System.Windows.Forms.Label
    Friend WithEvents txtDueDate As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip_Edit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditEmp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditDep As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditJob As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewEmp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDep As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewJob As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Calendar As System.Windows.Forms.MonthCalendar
    Friend WithEvents lbToday As System.Windows.Forms.ListBox
    Friend WithEvents btnToday As System.Windows.Forms.Button
    Friend WithEvents gbDepartments As System.Windows.Forms.GroupBox
    Friend WithEvents btnViewDep As System.Windows.Forms.Button
    Friend WithEvents btnEditDep As System.Windows.Forms.Button
    Friend WithEvents btnNewDep As System.Windows.Forms.Button
    Friend WithEvents gbEmployee As System.Windows.Forms.GroupBox
    Friend WithEvents btnViewEmp As System.Windows.Forms.Button
    Friend WithEvents btnEditEmp As System.Windows.Forms.Button
    Friend WithEvents btnNewEmp As System.Windows.Forms.Button
    Friend WithEvents gbJobs As System.Windows.Forms.GroupBox
    Friend WithEvents btnViewJob As System.Windows.Forms.Button
    Friend WithEvents btnEditJob As System.Windows.Forms.Button
    Friend WithEvents btnNewJob As System.Windows.Forms.Button
    Friend WithEvents Archive As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cms As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsComplete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsArchive As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbMain As System.Windows.Forms.ListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ViewArchivedItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportJobCosts As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportCSVCosts As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ExportAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportCurrentSelection As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowProgressToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
