<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
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
        Me.btnEmpSave = New System.Windows.Forms.Button()
        Me.btnEmpArchive = New System.Windows.Forms.Button()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhoneExt = New System.Windows.Forms.Label()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.txtPhoneExt = New System.Windows.Forms.TextBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblEmpID = New System.Windows.Forms.Label()
        Me.txtAssetsDes = New System.Windows.Forms.TextBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.lblAssetCat = New System.Windows.Forms.Label()
        Me.lblAssetDes = New System.Windows.Forms.Label()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnAstSave = New System.Windows.Forms.Button()
        Me.btnAstArchive = New System.Windows.Forms.Button()
        Me.cmbPriority = New System.Windows.Forms.ComboBox()
        Me.lblPriority = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.txtWage = New System.Windows.Forms.TextBox()
        Me.lblWage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEmpSave
        '
        Me.btnEmpSave.Location = New System.Drawing.Point(13, 252)
        Me.btnEmpSave.Name = "btnEmpSave"
        Me.btnEmpSave.Size = New System.Drawing.Size(157, 23)
        Me.btnEmpSave.TabIndex = 0
        Me.btnEmpSave.Text = "Save"
        Me.btnEmpSave.UseVisualStyleBackColor = True
        '
        'btnEmpArchive
        '
        Me.btnEmpArchive.Location = New System.Drawing.Point(176, 252)
        Me.btnEmpArchive.Name = "btnEmpArchive"
        Me.btnEmpArchive.Size = New System.Drawing.Size(144, 23)
        Me.btnEmpArchive.TabIndex = 0
        Me.btnEmpArchive.Text = "Archive"
        Me.btnEmpArchive.UseVisualStyleBackColor = True
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(103, 38)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(217, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Location = New System.Drawing.Point(40, 41)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(57, 13)
        Me.lblFName.TabIndex = 4
        Me.lblFName.Text = "First Name"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(55, 93)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(42, 13)
        Me.lblGender.TabIndex = 5
        Me.lblGender.Text = "Gender"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(65, 120)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "Email"
        '
        'lblPhoneExt
        '
        Me.lblPhoneExt.AutoSize = True
        Me.lblPhoneExt.Location = New System.Drawing.Point(10, 146)
        Me.lblPhoneExt.Name = "lblPhoneExt"
        Me.lblPhoneExt.Size = New System.Drawing.Size(87, 13)
        Me.lblPhoneExt.TabIndex = 7
        Me.lblPhoneExt.Text = "Phone Extension"
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Location = New System.Drawing.Point(59, 172)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(38, 13)
        Me.lblMobile.TabIndex = 8
        Me.lblMobile.Text = "Mobile"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Location = New System.Drawing.Point(35, 198)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(62, 13)
        Me.lblDepartment.TabIndex = 9
        Me.lblDepartment.Text = "Department"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(103, 117)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(217, 20)
        Me.txtEmail.TabIndex = 4
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.ItemHeight = 13
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(103, 90)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(217, 21)
        Me.cmbGender.TabIndex = 11
        '
        'txtPhoneExt
        '
        Me.txtPhoneExt.Location = New System.Drawing.Point(103, 143)
        Me.txtPhoneExt.Name = "txtPhoneExt"
        Me.txtPhoneExt.Size = New System.Drawing.Size(217, 20)
        Me.txtPhoneExt.TabIndex = 5
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(103, 169)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(217, 20)
        Me.txtMobile.TabIndex = 6
        '
        'cmbDepartment
        '
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Location = New System.Drawing.Point(103, 195)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(217, 21)
        Me.cmbDepartment.TabIndex = 7
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Location = New System.Drawing.Point(39, 67)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(58, 13)
        Me.lblLName.TabIndex = 16
        Me.lblLName.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(103, 64)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(217, 20)
        Me.txtLastName.TabIndex = 2
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(103, 12)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(217, 20)
        Me.txtID.TabIndex = 17
        '
        'lblEmpID
        '
        Me.lblEmpID.AutoSize = True
        Me.lblEmpID.Location = New System.Drawing.Point(30, 15)
        Me.lblEmpID.Name = "lblEmpID"
        Me.lblEmpID.Size = New System.Drawing.Size(67, 13)
        Me.lblEmpID.TabIndex = 18
        Me.lblEmpID.Text = "Employee ID"
        '
        'txtAssetsDes
        '
        Me.txtAssetsDes.Location = New System.Drawing.Point(345, 33)
        Me.txtAssetsDes.Multiline = True
        Me.txtAssetsDes.Name = "txtAssetsDes"
        Me.txtAssetsDes.Size = New System.Drawing.Size(296, 178)
        Me.txtAssetsDes.TabIndex = 10
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"PC", "Mobile Device", "Tablet Device", "Server", "IP Phone", "Other"})
        Me.cmbCategory.Location = New System.Drawing.Point(397, 217)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(244, 21)
        Me.cmbCategory.TabIndex = 11
        '
        'lblAssetCat
        '
        Me.lblAssetCat.AutoSize = True
        Me.lblAssetCat.Location = New System.Drawing.Point(342, 220)
        Me.lblAssetCat.Name = "lblAssetCat"
        Me.lblAssetCat.Size = New System.Drawing.Size(49, 13)
        Me.lblAssetCat.TabIndex = 24
        Me.lblAssetCat.Text = "Category"
        '
        'lblAssetDes
        '
        Me.lblAssetDes.AutoSize = True
        Me.lblAssetDes.Location = New System.Drawing.Point(346, 10)
        Me.lblAssetDes.Name = "lblAssetDes"
        Me.lblAssetDes.Size = New System.Drawing.Size(60, 13)
        Me.lblAssetDes.TabIndex = 25
        Me.lblAssetDes.Text = "Description"
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(345, 252)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(23, 23)
        Me.btnPrev.TabIndex = 0
        Me.btnPrev.Text = "<"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(375, 252)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(23, 23)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnAstSave
        '
        Me.btnAstSave.Location = New System.Drawing.Point(485, 252)
        Me.btnAstSave.Name = "btnAstSave"
        Me.btnAstSave.Size = New System.Drawing.Size(75, 23)
        Me.btnAstSave.TabIndex = 0
        Me.btnAstSave.Text = "Save"
        Me.btnAstSave.UseVisualStyleBackColor = True
        '
        'btnAstArchive
        '
        Me.btnAstArchive.Location = New System.Drawing.Point(566, 252)
        Me.btnAstArchive.Name = "btnAstArchive"
        Me.btnAstArchive.Size = New System.Drawing.Size(75, 23)
        Me.btnAstArchive.TabIndex = 0
        Me.btnAstArchive.Text = "Archive"
        Me.btnAstArchive.UseVisualStyleBackColor = True
        '
        'cmbPriority
        '
        Me.cmbPriority.FormattingEnabled = True
        Me.cmbPriority.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbPriority.Location = New System.Drawing.Point(282, 222)
        Me.cmbPriority.Name = "cmbPriority"
        Me.cmbPriority.Size = New System.Drawing.Size(38, 21)
        Me.cmbPriority.TabIndex = 9
        '
        'lblPriority
        '
        Me.lblPriority.AutoSize = True
        Me.lblPriority.Location = New System.Drawing.Point(238, 225)
        Me.lblPriority.Name = "lblPriority"
        Me.lblPriority.Size = New System.Drawing.Size(38, 13)
        Me.lblPriority.TabIndex = 31
        Me.lblPriority.Text = "Priority"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(404, 252)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'txtWage
        '
        Me.txtWage.Location = New System.Drawing.Point(103, 222)
        Me.txtWage.Name = "txtWage"
        Me.txtWage.Size = New System.Drawing.Size(129, 20)
        Me.txtWage.TabIndex = 8
        '
        'lblWage
        '
        Me.lblWage.AutoSize = True
        Me.lblWage.Location = New System.Drawing.Point(59, 225)
        Me.lblWage.Name = "lblWage"
        Me.lblWage.Size = New System.Drawing.Size(36, 13)
        Me.lblWage.TabIndex = 33
        Me.lblWage.Text = "Wage"
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 284)
        Me.Controls.Add(Me.txtWage)
        Me.Controls.Add(Me.lblWage)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.lblPriority)
        Me.Controls.Add(Me.cmbPriority)
        Me.Controls.Add(Me.btnAstArchive)
        Me.Controls.Add(Me.btnAstSave)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.lblAssetDes)
        Me.Controls.Add(Me.lblAssetCat)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.txtAssetsDes)
        Me.Controls.Add(Me.lblEmpID)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblLName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.cmbDepartment)
        Me.Controls.Add(Me.txtMobile)
        Me.Controls.Add(Me.txtPhoneExt)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.lblMobile)
        Me.Controls.Add(Me.lblPhoneExt)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblFName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.btnEmpArchive)
        Me.Controls.Add(Me.btnEmpSave)
        Me.Name = "frmEmployee"
        Me.Text = "EmployeeEdit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEmpSave As System.Windows.Forms.Button
    Friend WithEvents btnEmpArchive As System.Windows.Forms.Button
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblFName As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPhoneExt As System.Windows.Forms.Label
    Friend WithEvents lblMobile As System.Windows.Forms.Label
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents txtPhoneExt As System.Windows.Forms.TextBox
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents cmbDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents lblLName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblEmpID As System.Windows.Forms.Label
    Friend WithEvents txtAssetsDes As System.Windows.Forms.TextBox
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents lblAssetCat As System.Windows.Forms.Label
    Friend WithEvents lblAssetDes As System.Windows.Forms.Label
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnAstSave As System.Windows.Forms.Button
    Friend WithEvents btnAstArchive As System.Windows.Forms.Button
    Friend WithEvents cmbPriority As System.Windows.Forms.ComboBox
    Friend WithEvents lblPriority As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents txtWage As System.Windows.Forms.TextBox
    Friend WithEvents lblWage As System.Windows.Forms.Label
End Class
