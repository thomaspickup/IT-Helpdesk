<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartment
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
        Me.lblDepID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblPhoneNum = New System.Windows.Forms.Label()
        Me.txtPhoneNo = New System.Windows.Forms.TextBox()
        Me.txtPostCode = New System.Windows.Forms.TextBox()
        Me.txtCounty = New System.Windows.Forms.TextBox()
        Me.txtTown = New System.Windows.Forms.TextBox()
        Me.lblInternal = New System.Windows.Forms.Label()
        Me.lblPostCode = New System.Windows.Forms.Label()
        Me.lblCounty = New System.Windows.Forms.Label()
        Me.lblTown = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblDepName = New System.Windows.Forms.Label()
        Me.txtDepName = New System.Windows.Forms.TextBox()
        Me.btnDepArchive = New System.Windows.Forms.Button()
        Me.btnDepSave = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.cbInternal = New System.Windows.Forms.CheckBox()
        Me.lbMemb = New System.Windows.Forms.ListBox()
        Me.lblMemTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDepID
        '
        Me.lblDepID.AutoSize = True
        Me.lblDepID.Location = New System.Drawing.Point(26, 19)
        Me.lblDepID.Name = "lblDepID"
        Me.lblDepID.Size = New System.Drawing.Size(76, 13)
        Me.lblDepID.TabIndex = 49
        Me.lblDepID.Text = "Department ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(108, 16)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(217, 20)
        Me.txtID.TabIndex = 0
        '
        'lblPhoneNum
        '
        Me.lblPhoneNum.AutoSize = True
        Me.lblPhoneNum.Location = New System.Drawing.Point(24, 71)
        Me.lblPhoneNum.Name = "lblPhoneNum"
        Me.lblPhoneNum.Size = New System.Drawing.Size(78, 13)
        Me.lblPhoneNum.TabIndex = 47
        Me.lblPhoneNum.Text = "Phone Number"
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.Location = New System.Drawing.Point(108, 68)
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(217, 20)
        Me.txtPhoneNo.TabIndex = 2
        '
        'txtPostCode
        '
        Me.txtPostCode.Location = New System.Drawing.Point(108, 173)
        Me.txtPostCode.Name = "txtPostCode"
        Me.txtPostCode.Size = New System.Drawing.Size(217, 20)
        Me.txtPostCode.TabIndex = 6
        '
        'txtCounty
        '
        Me.txtCounty.Location = New System.Drawing.Point(108, 147)
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.Size = New System.Drawing.Size(217, 20)
        Me.txtCounty.TabIndex = 5
        '
        'txtTown
        '
        Me.txtTown.Location = New System.Drawing.Point(108, 121)
        Me.txtTown.Name = "txtTown"
        Me.txtTown.Size = New System.Drawing.Size(217, 20)
        Me.txtTown.TabIndex = 4
        '
        'lblInternal
        '
        Me.lblInternal.AutoSize = True
        Me.lblInternal.Location = New System.Drawing.Point(60, 202)
        Me.lblInternal.Name = "lblInternal"
        Me.lblInternal.Size = New System.Drawing.Size(42, 13)
        Me.lblInternal.TabIndex = 40
        Me.lblInternal.Text = "Internal"
        '
        'lblPostCode
        '
        Me.lblPostCode.AutoSize = True
        Me.lblPostCode.Location = New System.Drawing.Point(46, 176)
        Me.lblPostCode.Name = "lblPostCode"
        Me.lblPostCode.Size = New System.Drawing.Size(56, 13)
        Me.lblPostCode.TabIndex = 39
        Me.lblPostCode.Text = "Post Code"
        '
        'lblCounty
        '
        Me.lblCounty.AutoSize = True
        Me.lblCounty.Location = New System.Drawing.Point(62, 150)
        Me.lblCounty.Name = "lblCounty"
        Me.lblCounty.Size = New System.Drawing.Size(40, 13)
        Me.lblCounty.TabIndex = 38
        Me.lblCounty.Text = "County"
        '
        'lblTown
        '
        Me.lblTown.AutoSize = True
        Me.lblTown.Location = New System.Drawing.Point(68, 124)
        Me.lblTown.Name = "lblTown"
        Me.lblTown.Size = New System.Drawing.Size(34, 13)
        Me.lblTown.TabIndex = 37
        Me.lblTown.Text = "Town"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(57, 97)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 36
        Me.lblAddress.Text = "Address"
        '
        'lblDepName
        '
        Me.lblDepName.AutoSize = True
        Me.lblDepName.Location = New System.Drawing.Point(9, 45)
        Me.lblDepName.Name = "lblDepName"
        Me.lblDepName.Size = New System.Drawing.Size(93, 13)
        Me.lblDepName.TabIndex = 35
        Me.lblDepName.Text = "Department Name"
        '
        'txtDepName
        '
        Me.txtDepName.Location = New System.Drawing.Point(108, 42)
        Me.txtDepName.Name = "txtDepName"
        Me.txtDepName.Size = New System.Drawing.Size(217, 20)
        Me.txtDepName.TabIndex = 1
        '
        'btnDepArchive
        '
        Me.btnDepArchive.Location = New System.Drawing.Point(180, 231)
        Me.btnDepArchive.Name = "btnDepArchive"
        Me.btnDepArchive.Size = New System.Drawing.Size(144, 23)
        Me.btnDepArchive.TabIndex = 0
        Me.btnDepArchive.Text = "Archive"
        Me.btnDepArchive.UseVisualStyleBackColor = True
        '
        'btnDepSave
        '
        Me.btnDepSave.Location = New System.Drawing.Point(17, 231)
        Me.btnDepSave.Name = "btnDepSave"
        Me.btnDepSave.Size = New System.Drawing.Size(157, 23)
        Me.btnDepSave.TabIndex = 0
        Me.btnDepSave.Text = "Save"
        Me.btnDepSave.UseVisualStyleBackColor = True
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(108, 94)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(217, 20)
        Me.txtAddress.TabIndex = 3
        '
        'cbInternal
        '
        Me.cbInternal.AutoSize = True
        Me.cbInternal.Location = New System.Drawing.Point(205, 201)
        Me.cbInternal.Name = "cbInternal"
        Me.cbInternal.Size = New System.Drawing.Size(15, 14)
        Me.cbInternal.TabIndex = 7
        Me.cbInternal.UseVisualStyleBackColor = True
        '
        'lbMemb
        '
        Me.lbMemb.FormattingEnabled = True
        Me.lbMemb.Location = New System.Drawing.Point(330, 42)
        Me.lbMemb.Margin = New System.Windows.Forms.Padding(2)
        Me.lbMemb.Name = "lbMemb"
        Me.lbMemb.Size = New System.Drawing.Size(164, 212)
        Me.lbMemb.TabIndex = 0
        '
        'lblMemTitle
        '
        Me.lblMemTitle.AutoSize = True
        Me.lblMemTitle.Location = New System.Drawing.Point(350, 19)
        Me.lblMemTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMemTitle.Name = "lblMemTitle"
        Me.lblMemTitle.Size = New System.Drawing.Size(122, 13)
        Me.lblMemTitle.TabIndex = 0
        Me.lblMemTitle.Text = "Members Of Department"
        '
        'frmDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 266)
        Me.Controls.Add(Me.lblMemTitle)
        Me.Controls.Add(Me.lbMemb)
        Me.Controls.Add(Me.cbInternal)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblDepID)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblPhoneNum)
        Me.Controls.Add(Me.txtPhoneNo)
        Me.Controls.Add(Me.txtPostCode)
        Me.Controls.Add(Me.txtCounty)
        Me.Controls.Add(Me.txtTown)
        Me.Controls.Add(Me.lblInternal)
        Me.Controls.Add(Me.lblPostCode)
        Me.Controls.Add(Me.lblCounty)
        Me.Controls.Add(Me.lblTown)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblDepName)
        Me.Controls.Add(Me.txtDepName)
        Me.Controls.Add(Me.btnDepArchive)
        Me.Controls.Add(Me.btnDepSave)
        Me.Name = "frmDepartment"
        Me.Text = "frmDepartment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDepID As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblPhoneNum As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents txtPostCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCounty As System.Windows.Forms.TextBox
    Friend WithEvents txtTown As System.Windows.Forms.TextBox
    Friend WithEvents lblInternal As System.Windows.Forms.Label
    Friend WithEvents lblPostCode As System.Windows.Forms.Label
    Friend WithEvents lblCounty As System.Windows.Forms.Label
    Friend WithEvents lblTown As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblDepName As System.Windows.Forms.Label
    Friend WithEvents txtDepName As System.Windows.Forms.TextBox
    Friend WithEvents btnDepArchive As System.Windows.Forms.Button
    Friend WithEvents btnDepSave As System.Windows.Forms.Button
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents cbInternal As System.Windows.Forms.CheckBox
    Friend WithEvents lbMemb As System.Windows.Forms.ListBox
    Friend WithEvents lblMemTitle As System.Windows.Forms.Label
End Class
