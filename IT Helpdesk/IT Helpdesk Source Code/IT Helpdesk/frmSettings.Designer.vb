<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.lblFileDirectory = New System.Windows.Forms.Label()
        Me.txtFileDirectory = New System.Windows.Forms.TextBox()
        Me.btnOpenFD = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtArchiveQ = New System.Windows.Forms.TextBox()
        Me.lblArchive = New System.Windows.Forms.Label()
        Me.cbTimePeriod = New System.Windows.Forms.ComboBox()
        Me.lblCallFrom = New System.Windows.Forms.Label()
        Me.cbCF = New System.Windows.Forms.ComboBox()
        Me.cbAT = New System.Windows.Forms.ComboBox()
        Me.lblAssignedTo = New System.Windows.Forms.Label()
        Me.txtCurrentPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFileDirectory
        '
        Me.lblFileDirectory.AutoSize = True
        Me.lblFileDirectory.Location = New System.Drawing.Point(10, 13)
        Me.lblFileDirectory.Name = "lblFileDirectory"
        Me.lblFileDirectory.Size = New System.Drawing.Size(68, 13)
        Me.lblFileDirectory.TabIndex = 0
        Me.lblFileDirectory.Text = "File Directory"
        '
        'txtFileDirectory
        '
        Me.txtFileDirectory.Location = New System.Drawing.Point(141, 11)
        Me.txtFileDirectory.Name = "txtFileDirectory"
        Me.txtFileDirectory.Size = New System.Drawing.Size(158, 20)
        Me.txtFileDirectory.TabIndex = 1
        '
        'btnOpenFD
        '
        Me.btnOpenFD.Location = New System.Drawing.Point(303, 11)
        Me.btnOpenFD.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOpenFD.Name = "btnOpenFD"
        Me.btnOpenFD.Size = New System.Drawing.Size(77, 20)
        Me.btnOpenFD.TabIndex = 2
        Me.btnOpenFD.Text = "Open..."
        Me.btnOpenFD.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(314, 156)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(67, 25)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtArchiveQ
        '
        Me.txtArchiveQ.Location = New System.Drawing.Point(141, 36)
        Me.txtArchiveQ.Margin = New System.Windows.Forms.Padding(2)
        Me.txtArchiveQ.Name = "txtArchiveQ"
        Me.txtArchiveQ.Size = New System.Drawing.Size(158, 20)
        Me.txtArchiveQ.TabIndex = 5
        '
        'lblArchive
        '
        Me.lblArchive.AutoSize = True
        Me.lblArchive.Location = New System.Drawing.Point(11, 37)
        Me.lblArchive.Name = "lblArchive"
        Me.lblArchive.Size = New System.Drawing.Size(127, 13)
        Me.lblArchive.TabIndex = 6
        Me.lblArchive.Text = "Archive Items Less Than "
        '
        'cbTimePeriod
        '
        Me.cbTimePeriod.FormattingEnabled = True
        Me.cbTimePeriod.Items.AddRange(New Object() {"Days", "Weeks", "Months"})
        Me.cbTimePeriod.Location = New System.Drawing.Point(304, 34)
        Me.cbTimePeriod.Margin = New System.Windows.Forms.Padding(2)
        Me.cbTimePeriod.Name = "cbTimePeriod"
        Me.cbTimePeriod.Size = New System.Drawing.Size(77, 21)
        Me.cbTimePeriod.TabIndex = 7
        '
        'lblCallFrom
        '
        Me.lblCallFrom.AutoSize = True
        Me.lblCallFrom.Location = New System.Drawing.Point(11, 63)
        Me.lblCallFrom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCallFrom.Name = "lblCallFrom"
        Me.lblCallFrom.Size = New System.Drawing.Size(87, 13)
        Me.lblCallFrom.TabIndex = 8
        Me.lblCallFrom.Text = "Default Call From"
        '
        'cbCF
        '
        Me.cbCF.FormattingEnabled = True
        Me.cbCF.Location = New System.Drawing.Point(141, 60)
        Me.cbCF.Margin = New System.Windows.Forms.Padding(2)
        Me.cbCF.Name = "cbCF"
        Me.cbCF.Size = New System.Drawing.Size(240, 21)
        Me.cbCF.TabIndex = 9
        '
        'cbAT
        '
        Me.cbAT.FormattingEnabled = True
        Me.cbAT.Location = New System.Drawing.Point(141, 85)
        Me.cbAT.Margin = New System.Windows.Forms.Padding(2)
        Me.cbAT.Name = "cbAT"
        Me.cbAT.Size = New System.Drawing.Size(240, 21)
        Me.cbAT.TabIndex = 11
        '
        'lblAssignedTo
        '
        Me.lblAssignedTo.AutoSize = True
        Me.lblAssignedTo.Location = New System.Drawing.Point(10, 87)
        Me.lblAssignedTo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAssignedTo.Name = "lblAssignedTo"
        Me.lblAssignedTo.Size = New System.Drawing.Size(103, 13)
        Me.lblAssignedTo.TabIndex = 10
        Me.lblAssignedTo.Text = "Default Assigned To"
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.Location = New System.Drawing.Point(141, 109)
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCurrentPassword.Size = New System.Drawing.Size(240, 20)
        Me.txtCurrentPassword.TabIndex = 13
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(11, 111)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(90, 13)
        Me.lblPassword.TabIndex = 12
        Me.lblPassword.Text = "Current Password"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(141, 133)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(240, 20)
        Me.txtNewPassword.TabIndex = 15
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.Location = New System.Drawing.Point(11, 136)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(78, 13)
        Me.lblNewPassword.TabIndex = 14
        Me.lblNewPassword.Text = "New Password"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 193)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.lblNewPassword)
        Me.Controls.Add(Me.txtCurrentPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.cbAT)
        Me.Controls.Add(Me.lblAssignedTo)
        Me.Controls.Add(Me.cbCF)
        Me.Controls.Add(Me.lblCallFrom)
        Me.Controls.Add(Me.cbTimePeriod)
        Me.Controls.Add(Me.lblArchive)
        Me.Controls.Add(Me.txtArchiveQ)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnOpenFD)
        Me.Controls.Add(Me.txtFileDirectory)
        Me.Controls.Add(Me.lblFileDirectory)
        Me.Name = "frmSettings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFileDirectory As System.Windows.Forms.Label
    Friend WithEvents txtFileDirectory As System.Windows.Forms.TextBox
    Friend WithEvents btnOpenFD As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtArchiveQ As System.Windows.Forms.TextBox
    Friend WithEvents lblArchive As System.Windows.Forms.Label
    Friend WithEvents cbTimePeriod As System.Windows.Forms.ComboBox
    Friend WithEvents lblCallFrom As System.Windows.Forms.Label
    Friend WithEvents cbCF As System.Windows.Forms.ComboBox
    Friend WithEvents cbAT As System.Windows.Forms.ComboBox
    Friend WithEvents lblAssignedTo As System.Windows.Forms.Label
    Friend WithEvents txtCurrentPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblNewPassword As System.Windows.Forms.Label
End Class
