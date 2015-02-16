Imports System.IO
Public Class frmSettings
    'On Load Procedure
    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Imports the settings from the application settings and displays them on the form...
        txtFileDirectory.Text = My.Settings.Dir
        If My.Settings.AAD Mod 30 = 0 Then
            cbTimePeriod.SelectedIndex = 2
            txtArchiveQ.Text = My.Settings.AAD / 30
        ElseIf My.Settings.AAD Mod 7 = 0 Then
            cbTimePeriod.SelectedIndex = 1
            txtArchiveQ.Text = My.Settings.AAD / 7
        Else
            cbTimePeriod.SelectedIndex = 0
            txtArchiveQ.Text = My.Settings.AAD
        End If
        cbAT.Items.Add("All")
        cbCF.Items.Add("All")
        For C = 1 To NoOfITStaff
            cbAT.Items.Add(ITEmployee(C).FirstName & " " & ITEmployee(C).LastName)
        Next
        For C = 1 To NoOfEmployees
            cbCF.Items.Add(Employee(C).FirstName & " " & Employee(C).LastName)
        Next
        cbAT.SelectedIndex = My.Settings.DEFAT
        cbCF.SelectedIndex = My.Settings.DEFCF
    End Sub

    'Form Buttons
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Save()
    End Sub
    Private Sub btnOpenFD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenFD.Click
        'This opens the folder browser to select a file directory to change...
        Dim OD As New FolderBrowserDialog
        OD.Description = "Please select the folder that your records are in or will be stored in..." & vbNewLine & "For network users you may have to set up a temporary link to this folder..."
        OD.ShowDialog()
        txtFileDirectory.Text = OD.SelectedPath
    End Sub

    'Save Procedure
    Private Sub Save()
        'Checks to see if the files that are needed to run the program exist...
        If File.Exists(txtFileDirectory.Text & "\settings.txt") And File.Exists(txtFileDirectory.Text & "\jobs.txt") And File.Exists(txtFileDirectory.Text & "\notes.txt") And File.Exists(txtFileDirectory.Text & "\employee.txt") And File.Exists(txtFileDirectory.Text & "\assets.txt") And File.Exists(txtFileDirectory.Text & "\departments.txt") And File.Exists(txtFileDirectory.Text & "\category.txt") And Directory.Exists(txtFileDirectory.Text & "\details\") Then
            'Checks to see if the password in txtCurrentPassword matches the current password
            Dim PassToCheck As String
            FileOpen(18, DirectoryLocation & "\pass.txt", OpenMode.Input)
            PassToCheck = LineInput(18)
            FileClose(18)
            If PassToCheck = getHash(txtCurrentPassword.Text) And Not txtNewPassword.Text = "" Then
                'Changes all the settings to the ones entered
                My.Settings.Dir = txtFileDirectory.Text
                Select Case cbTimePeriod.SelectedIndex
                    Case 0
                        My.Settings.AAD = Val(txtArchiveQ.Text)
                    Case 1
                        My.Settings.AAD = Val(txtArchiveQ.Text) * 7
                    Case 2
                        My.Settings.AAD = Val(txtArchiveQ.Text) * 30
                End Select
                My.Settings.DEFAT = cbAT.SelectedIndex
                My.Settings.DEFCF = cbCF.SelectedIndex

                'Changes the password 
                FileOpen(16, txtFileDirectory.Text & "\pass.txt", OpenMode.Output)
                PrintLine(16, getHash(txtNewPassword.Text))
                FileClose(16)
                MsgBox("Please restart the application to allow the changes made to take effect...", MsgBoxStyle.Information, "Please Restart")
            ElseIf Not txtNewPassword.Text = "" Then
                'Password entered was incorrect so no changes made
                MsgBox("The Password You Entered Was Incorrect, settings have not been changed...", MsgBoxStyle.Information, "Incorrect Password")
            Else
                'Changes all the settings to the ones entered
                My.Settings.Dir = txtFileDirectory.Text
                Select Case cbTimePeriod.SelectedIndex
                    Case 0
                        My.Settings.AAD = Val(txtArchiveQ.Text)
                    Case 1
                        My.Settings.AAD = Val(txtArchiveQ.Text) * 7
                    Case 2
                        My.Settings.AAD = Val(txtArchiveQ.Text) * 30
                End Select
                My.Settings.DEFAT = cbAT.SelectedIndex
                My.Settings.DEFCF = cbCF.SelectedIndex
                MsgBox("Please restart the application to allow the changes made to take effect...", MsgBoxStyle.Information, "Please Restart")
            End If
        Else
            'Files needed to run don't exist, advises user that the directory is invalid
            Dim Result As DialogResult
            Result = MsgBox("Warning, the directory you have selected does not contain the required resources. Do you wish to restart the program to apply changes or cancel the changes you are about to make?", MsgBoxStyle.YesNo, "Error - Records not found")

            'If the user decides to change directory will change settings...
            If Result = Windows.Forms.DialogResult.Yes Then
                'No password file will exist so changes settings without need of password... 
                My.Settings.Dir = txtFileDirectory.Text
                Select Case cbTimePeriod.SelectedIndex
                    Case 0
                        My.Settings.AAD = Val(txtArchiveQ.Text)
                    Case 1
                        My.Settings.AAD = Val(txtArchiveQ.Text) * 7
                    Case 2
                        My.Settings.AAD = Val(txtArchiveQ.Text) * 30
                End Select
                My.Settings.DEFAT = cbAT.SelectedIndex
                My.Settings.DEFCF = cbCF.SelectedIndex

                'User needs to restart to apply changes - advises user to do so...
                MsgBox("Please restart the application to allow the changes made to take effect...", MsgBoxStyle.Information, "Please Restart")
            End If
        End If
    End Sub
End Class