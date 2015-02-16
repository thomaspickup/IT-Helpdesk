<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJobs
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
        Me.lblJobID = New System.Windows.Forms.Label()
        Me.txtJobID = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.cmbCF = New System.Windows.Forms.ComboBox()
        Me.lblCallFrom = New System.Windows.Forms.Label()
        Me.cmbAT = New System.Windows.Forms.ComboBox()
        Me.lblAssignedTo = New System.Windows.Forms.Label()
        Me.lblDateDue = New System.Windows.Forms.Label()
        Me.btnNewJob = New System.Windows.Forms.Button()
        Me.btnSaveJob = New System.Windows.Forms.Button()
        Me.btnArchiveJob = New System.Windows.Forms.Button()
        Me.btnComplete = New System.Windows.Forms.Button()
        Me.cmbNoteSelector = New System.Windows.Forms.ComboBox()
        Me.btnSaveNote = New System.Windows.Forms.Button()
        Me.btnArchiveNote = New System.Windows.Forms.Button()
        Me.txtNoteDes = New System.Windows.Forms.TextBox()
        Me.txtProgress = New System.Windows.Forms.TextBox()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.lblDateAdded = New System.Windows.Forms.Label()
        Me.txtDateDue = New System.Windows.Forms.DateTimePicker()
        Me.txtDateAdded = New System.Windows.Forms.TextBox()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.txtTimeSpent = New System.Windows.Forms.TextBox()
        Me.lblTimeSpent = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblRef = New System.Windows.Forms.Label()
        Me.txtJobRef = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblJobID
        '
        Me.lblJobID.AutoSize = True
        Me.lblJobID.Location = New System.Drawing.Point(16, 14)
        Me.lblJobID.Name = "lblJobID"
        Me.lblJobID.Size = New System.Drawing.Size(41, 13)
        Me.lblJobID.TabIndex = 0
        Me.lblJobID.Text = "Job ID "
        '
        'txtJobID
        '
        Me.txtJobID.Location = New System.Drawing.Point(66, 10)
        Me.txtJobID.Name = "txtJobID"
        Me.txtJobID.Size = New System.Drawing.Size(52, 20)
        Me.txtJobID.TabIndex = 13
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(372, 13)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 2
        Me.lblStatus.Text = "Status"
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(414, 11)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(63, 20)
        Me.txtStatus.TabIndex = 12
        Me.txtStatus.Text = "Outstanding"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(15, 58)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(462, 161)
        Me.txtDescription.TabIndex = 3
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(12, 228)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(49, 13)
        Me.lblCategory.TabIndex = 6
        Me.lblCategory.Text = "Category"
        '
        'cmbCategory
        '
        Me.cmbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.ItemHeight = 13
        Me.cmbCategory.Location = New System.Drawing.Point(69, 226)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(408, 21)
        Me.cmbCategory.TabIndex = 4
        '
        'cmbCF
        '
        Me.cmbCF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCF.FormattingEnabled = True
        Me.cmbCF.Location = New System.Drawing.Point(69, 252)
        Me.cmbCF.Name = "cmbCF"
        Me.cmbCF.Size = New System.Drawing.Size(162, 21)
        Me.cmbCF.TabIndex = 5
        '
        'lblCallFrom
        '
        Me.lblCallFrom.AutoSize = True
        Me.lblCallFrom.Location = New System.Drawing.Point(13, 255)
        Me.lblCallFrom.Name = "lblCallFrom"
        Me.lblCallFrom.Size = New System.Drawing.Size(50, 13)
        Me.lblCallFrom.TabIndex = 8
        Me.lblCallFrom.Text = "Call From"
        '
        'cmbAT
        '
        Me.cmbAT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAT.FormattingEnabled = True
        Me.cmbAT.Location = New System.Drawing.Point(309, 252)
        Me.cmbAT.Name = "cmbAT"
        Me.cmbAT.Size = New System.Drawing.Size(168, 21)
        Me.cmbAT.TabIndex = 6
        '
        'lblAssignedTo
        '
        Me.lblAssignedTo.AutoSize = True
        Me.lblAssignedTo.Location = New System.Drawing.Point(237, 255)
        Me.lblAssignedTo.Name = "lblAssignedTo"
        Me.lblAssignedTo.Size = New System.Drawing.Size(66, 13)
        Me.lblAssignedTo.TabIndex = 10
        Me.lblAssignedTo.Text = "Assigned To"
        '
        'lblDateDue
        '
        Me.lblDateDue.AutoSize = True
        Me.lblDateDue.Location = New System.Drawing.Point(147, 14)
        Me.lblDateDue.Name = "lblDateDue"
        Me.lblDateDue.Size = New System.Drawing.Size(53, 13)
        Me.lblDateDue.TabIndex = 12
        Me.lblDateDue.Text = "Date Due"
        '
        'btnNewJob
        '
        Me.btnNewJob.Location = New System.Drawing.Point(15, 278)
        Me.btnNewJob.Name = "btnNewJob"
        Me.btnNewJob.Size = New System.Drawing.Size(76, 23)
        Me.btnNewJob.TabIndex = 14
        Me.btnNewJob.Text = "New"
        Me.btnNewJob.UseVisualStyleBackColor = True
        '
        'btnSaveJob
        '
        Me.btnSaveJob.Location = New System.Drawing.Point(96, 278)
        Me.btnSaveJob.Name = "btnSaveJob"
        Me.btnSaveJob.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveJob.TabIndex = 15
        Me.btnSaveJob.Text = "Save"
        Me.btnSaveJob.UseVisualStyleBackColor = True
        '
        'btnArchiveJob
        '
        Me.btnArchiveJob.Location = New System.Drawing.Point(177, 278)
        Me.btnArchiveJob.Margin = New System.Windows.Forms.Padding(2)
        Me.btnArchiveJob.Name = "btnArchiveJob"
        Me.btnArchiveJob.Size = New System.Drawing.Size(75, 23)
        Me.btnArchiveJob.TabIndex = 16
        Me.btnArchiveJob.Text = "Archive"
        Me.btnArchiveJob.UseVisualStyleBackColor = True
        '
        'btnComplete
        '
        Me.btnComplete.Location = New System.Drawing.Point(323, 278)
        Me.btnComplete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(75, 23)
        Me.btnComplete.TabIndex = 17
        Me.btnComplete.Text = "Complete"
        Me.btnComplete.UseVisualStyleBackColor = True
        '
        'cmbNoteSelector
        '
        Me.cmbNoteSelector.FormattingEnabled = True
        Me.cmbNoteSelector.Location = New System.Drawing.Point(16, 308)
        Me.cmbNoteSelector.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbNoteSelector.Name = "cmbNoteSelector"
        Me.cmbNoteSelector.Size = New System.Drawing.Size(462, 21)
        Me.cmbNoteSelector.TabIndex = 7
        '
        'btnSaveNote
        '
        Me.btnSaveNote.Location = New System.Drawing.Point(323, 527)
        Me.btnSaveNote.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSaveNote.Name = "btnSaveNote"
        Me.btnSaveNote.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveNote.TabIndex = 19
        Me.btnSaveNote.Text = "Save"
        Me.btnSaveNote.UseVisualStyleBackColor = True
        '
        'btnArchiveNote
        '
        Me.btnArchiveNote.Location = New System.Drawing.Point(402, 527)
        Me.btnArchiveNote.Margin = New System.Windows.Forms.Padding(2)
        Me.btnArchiveNote.Name = "btnArchiveNote"
        Me.btnArchiveNote.Size = New System.Drawing.Size(75, 23)
        Me.btnArchiveNote.TabIndex = 20
        Me.btnArchiveNote.Text = "Archive"
        Me.btnArchiveNote.UseVisualStyleBackColor = True
        '
        'txtNoteDes
        '
        Me.txtNoteDes.Location = New System.Drawing.Point(17, 357)
        Me.txtNoteDes.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNoteDes.Multiline = True
        Me.txtNoteDes.Name = "txtNoteDes"
        Me.txtNoteDes.Size = New System.Drawing.Size(462, 166)
        Me.txtNoteDes.TabIndex = 11
        '
        'txtProgress
        '
        Me.txtProgress.Location = New System.Drawing.Point(434, 334)
        Me.txtProgress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtProgress.Name = "txtProgress"
        Me.txtProgress.Size = New System.Drawing.Size(25, 20)
        Me.txtProgress.TabIndex = 10
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.Location = New System.Drawing.Point(462, 337)
        Me.lblPercent.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(15, 13)
        Me.lblPercent.TabIndex = 31
        Me.lblPercent.Text = "%"
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Location = New System.Drawing.Point(381, 337)
        Me.lblProgress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(48, 13)
        Me.lblProgress.TabIndex = 32
        Me.lblProgress.Text = "Progress"
        '
        'lblDateAdded
        '
        Me.lblDateAdded.AutoSize = True
        Me.lblDateAdded.Location = New System.Drawing.Point(16, 337)
        Me.lblDateAdded.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDateAdded.Name = "lblDateAdded"
        Me.lblDateAdded.Size = New System.Drawing.Size(64, 13)
        Me.lblDateAdded.TabIndex = 33
        Me.lblDateAdded.Text = "Date Added"
        '
        'txtDateDue
        '
        Me.txtDateDue.Location = New System.Drawing.Point(204, 11)
        Me.txtDateDue.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDateDue.Name = "txtDateDue"
        Me.txtDateDue.Size = New System.Drawing.Size(114, 20)
        Me.txtDateDue.TabIndex = 2
        '
        'txtDateAdded
        '
        Me.txtDateAdded.Location = New System.Drawing.Point(84, 334)
        Me.txtDateAdded.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDateAdded.Name = "txtDateAdded"
        Me.txtDateAdded.Size = New System.Drawing.Size(87, 20)
        Me.txtDateAdded.TabIndex = 8
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(402, 278)
        Me.btnCopy.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(75, 23)
        Me.btnCopy.TabIndex = 36
        Me.btnCopy.Text = "Copy to Live"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(414, 36)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(63, 20)
        Me.txtCost.TabIndex = 14
        Me.txtCost.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(380, 39)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(28, 13)
        Me.lblCost.TabIndex = 37
        Me.lblCost.Text = "Cost"
        '
        'txtTimeSpent
        '
        Me.txtTimeSpent.Location = New System.Drawing.Point(261, 334)
        Me.txtTimeSpent.Name = "txtTimeSpent"
        Me.txtTimeSpent.Size = New System.Drawing.Size(57, 20)
        Me.txtTimeSpent.TabIndex = 9
        '
        'lblTimeSpent
        '
        Me.lblTimeSpent.AutoSize = True
        Me.lblTimeSpent.Location = New System.Drawing.Point(194, 337)
        Me.lblTimeSpent.Name = "lblTimeSpent"
        Me.lblTimeSpent.Size = New System.Drawing.Size(61, 13)
        Me.lblTimeSpent.TabIndex = 40
        Me.lblTimeSpent.Text = "Time Spent"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(323, 337)
        Me.lblHours.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(35, 13)
        Me.lblHours.TabIndex = 41
        Me.lblHours.Text = "Hours"
        '
        'lblRef
        '
        Me.lblRef.AutoSize = True
        Me.lblRef.Location = New System.Drawing.Point(16, 39)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(44, 13)
        Me.lblRef.TabIndex = 42
        Me.lblRef.Text = "Job Ref"
        '
        'txtJobRef
        '
        Me.txtJobRef.Location = New System.Drawing.Point(66, 36)
        Me.txtJobRef.Name = "txtJobRef"
        Me.txtJobRef.Size = New System.Drawing.Size(300, 20)
        Me.txtJobRef.TabIndex = 1
        '
        'frmJobs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 560)
        Me.Controls.Add(Me.txtJobRef)
        Me.Controls.Add(Me.lblRef)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblTimeSpent)
        Me.Controls.Add(Me.txtTimeSpent)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.txtDateAdded)
        Me.Controls.Add(Me.txtDateDue)
        Me.Controls.Add(Me.lblDateAdded)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.txtProgress)
        Me.Controls.Add(Me.txtNoteDes)
        Me.Controls.Add(Me.btnArchiveNote)
        Me.Controls.Add(Me.btnSaveNote)
        Me.Controls.Add(Me.cmbNoteSelector)
        Me.Controls.Add(Me.btnComplete)
        Me.Controls.Add(Me.btnArchiveJob)
        Me.Controls.Add(Me.btnSaveJob)
        Me.Controls.Add(Me.btnNewJob)
        Me.Controls.Add(Me.lblDateDue)
        Me.Controls.Add(Me.cmbAT)
        Me.Controls.Add(Me.lblAssignedTo)
        Me.Controls.Add(Me.cmbCF)
        Me.Controls.Add(Me.lblCallFrom)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtJobID)
        Me.Controls.Add(Me.lblJobID)
        Me.Name = "frmJobs"
        Me.Text = "frmJobs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblJobID As System.Windows.Forms.Label
    Friend WithEvents txtJobID As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCF As System.Windows.Forms.ComboBox
    Friend WithEvents lblCallFrom As System.Windows.Forms.Label
    Friend WithEvents cmbAT As System.Windows.Forms.ComboBox
    Friend WithEvents lblAssignedTo As System.Windows.Forms.Label
    Friend WithEvents lblDateDue As System.Windows.Forms.Label
    Friend WithEvents btnNewJob As System.Windows.Forms.Button
    Friend WithEvents btnSaveJob As System.Windows.Forms.Button
    Friend WithEvents btnArchiveJob As System.Windows.Forms.Button
    Friend WithEvents btnComplete As System.Windows.Forms.Button
    Friend WithEvents cmbNoteSelector As System.Windows.Forms.ComboBox
    Friend WithEvents btnSaveNote As System.Windows.Forms.Button
    Friend WithEvents btnArchiveNote As System.Windows.Forms.Button
    Friend WithEvents txtNoteDes As System.Windows.Forms.TextBox
    Friend WithEvents txtProgress As System.Windows.Forms.TextBox
    Friend WithEvents lblPercent As System.Windows.Forms.Label
    Friend WithEvents lblProgress As System.Windows.Forms.Label
    Friend WithEvents lblDateAdded As System.Windows.Forms.Label
    Friend WithEvents txtDateDue As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDateAdded As System.Windows.Forms.TextBox
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents txtTimeSpent As System.Windows.Forms.TextBox
    Friend WithEvents lblTimeSpent As System.Windows.Forms.Label
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents lblRef As System.Windows.Forms.Label
    Friend WithEvents txtJobRef As System.Windows.Forms.TextBox
End Class
