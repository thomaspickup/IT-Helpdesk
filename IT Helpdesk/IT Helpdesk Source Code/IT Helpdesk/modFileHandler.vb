Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Module modFileHandler
    'Below is all the file handling variables...
    'All Record wide variables
    Public DirectoryLocation As String = My.Settings.Dir 'This variable holds the location of the directory all the files are stored in
    Dim WriteString As String 'This is used to hold a string at a time when saving the records
    Dim WritePara As String 'This holds all the WriteStrings and then gets written to the file
    Dim ID(5) As String 'This holds all the record ID's - it is used for finding out what the next ID available is  
    Dim N As Integer 'Used in importing to hold which field it needs to go in...
    Dim FieldString As String() 'This is used for assets to hold one record and then allows the structure to read off that

    'Below is all the file handling procedures...
    'Employee Record Handlers
    Sub NewEmployee(ByVal FName As String, ByVal LName As String, ByVal MF As String, ByVal EM As String, ByVal PExt As String, ByVal MOB As String, ByVal DID As Integer, ByVal PR As Integer, ByVal WG As Single)
        WriteString = " "
        FileOpen(1, DirectoryLocation & "\employee.txt", OpenMode.Append)
        ID(1) = Val(ID(1)) + 1
        WriteString = ID(1) & "," & FName & "," & LName & "," & MF & "," & EM & "," & PExt & "," & MOB & "," & DID & "," & PR & "," & WG & "," & False
        PrintLine(1, WriteString)
        FileClose(1)
        WriteID()
        Erase Employee
        NoOfEmployees = 0
        LoadEmployee()
        WriteID()
    End Sub
    Sub SaveEmployee()
        WritePara = ""
        FileOpen(12, DirectoryLocation & "\employee.txt", OpenMode.Output)
        For C = 1 To NoOfEmployees
            WriteString = Employee(C).ID & "," & Employee(C).FirstName & "," & Employee(C).LastName & "," & Employee(C).Gender & "," & Employee(C).Email & "," & Employee(C).PhoneExt & "," & Employee(C).Mobile & "," & Employee(C).DepartmentID & "," & Employee(C).PriorityRanking & "," & Employee(C).Wage & "," & Employee(C).Archived
            WritePara = WritePara & WriteString & vbNewLine
        Next
        PrintLine(12, WritePara)
        FileClose(12)
    End Sub
    Sub LoadEmployee()
        NoOfEmployees = 0
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(DirectoryLocation & "\employee.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    N = 0
                    NoOfEmployees += 1
                    ReDim Preserve Employee(NoOfEmployees)
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String
                    For Each currentField In currentRow
                        N += 1
                        Select Case N
                            Case 1
                                Employee(NoOfEmployees).ID = currentField
                            Case 2
                                Employee(NoOfEmployees).FirstName = currentField
                            Case 3
                                Employee(NoOfEmployees).LastName = currentField
                            Case 4
                                Employee(NoOfEmployees).Gender = currentField
                            Case 5
                                Employee(NoOfEmployees).Email = currentField
                            Case 6
                                Employee(NoOfEmployees).PhoneExt = currentField
                            Case 7
                                Employee(NoOfEmployees).Mobile = currentField
                            Case 8
                                Employee(NoOfEmployees).DepartmentID = currentField
                            Case 9
                                Employee(NoOfEmployees).PriorityRanking = currentField
                            Case 10
                                Employee(NoOfEmployees).Wage = currentField
                            Case 11
                                Employee(NoOfEmployees).Archived = currentField
                        End Select
                    Next
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                End Try
            End While
        End Using
    End Sub

    'Assets Record Handlers
    Sub AddAssets(ByVal CAT As String, ByVal DES As String, ByVal EID As Integer)
        WriteString = ""
        FileOpen(3, DirectoryLocation & "\assets.txt", OpenMode.Append)
        ID(3) = Val(ID(3)) + 1
        WriteString = vbNewLine & ID(3) & "," & CAT & "," & DES & "," & EID & "," & False
        PrintLine(3, WriteString)
        FileClose(3)
        NoOfAssets = 0
        LoadAssets()
        WriteID()
    End Sub
    Sub LoadAssets()
        NoOfAssets = 0
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(DirectoryLocation & "\assets.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            While Not MyReader.EndOfData
                FieldString = MyReader.ReadFields
                NoOfAssets += 1
                ReDim Preserve Asset(NoOfAssets)
                Asset(NoOfAssets).ID = FieldString(0)
                Asset(NoOfAssets).Category = FieldString(1)
                Asset(NoOfAssets).DescriptionID = FieldString(2)
                Asset(NoOfAssets).EmployeeID = FieldString(3)
                Asset(NoOfAssets).Archived = FieldString(4)
            End While
        End Using
    End Sub
    Sub SaveAssets()
        WritePara = ""
        FileOpen(32, DirectoryLocation & "\assets.txt", OpenMode.Output)
        For C = 1 To NoOfAssets
            WriteString = Asset(C).ID & "," & Asset(C).Category & "," & Asset(C).DescriptionID & "," & Asset(C).EmployeeID & "," & Asset(C).Archived
            WritePara = WritePara & WriteString & vbNewLine
        Next
        PrintLine(32, WritePara)
        FileClose(32)
    End Sub

    'Job Record Handlers
    Sub AddJob(ByVal Ref As String, ByVal Cat As String, ByVal Des As String, ByVal ITID As Integer, ByVal EMPID As Integer, ByVal DATEDUE As String)
        'Job ID, Category, Description, IT Staff Assigned To (Default As 0 - UnAssigned), Call From, Date In, Priority, Date Due, Completed, Archived
        WriteString = " "
        FileOpen(2, DirectoryLocation & "\jobs.txt", OpenMode.Append)
        ID(2) = Val(ID(2)) + 1
        WriteString = ID(2) & "," & Ref & "," & Cat & "," & Des & "," & ITID & "," & EMPID & "," & Date.Today.ToString() & "," & Employee(EMPID).PriorityRanking & "," & DATEDUE & "," & 1 & "," & False
        PrintLine(2, WriteString)
        FileClose(2)
        NoOfJobs = 0
        LoadJobs()
        WriteID()
    End Sub
    Sub LoadJobs()
        NoOfJobs = 0
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(DirectoryLocation & "\jobs.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    N = 0
                    NoOfJobs += 1
                    ReDim Preserve Job(NoOfJobs)
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String
                    For Each currentField In currentRow
                        N += 1
                        Select Case N
                            Case 1
                                Job(NoOfJobs).ID = currentField
                            Case 2
                                Job(NoOfJobs).Ref = currentField
                            Case 3
                                Job(NoOfJobs).Category = currentField
                            Case 4
                                Job(NoOfJobs).DescriptionID = currentField
                            Case 5
                                Job(NoOfJobs).ITStaffID = currentField
                            Case 6
                                Job(NoOfJobs).EmployeeID = currentField
                            Case 7
                                Job(NoOfJobs).DateIn = currentField
                            Case 8
                                Job(NoOfJobs).Priority = currentField
                            Case 9
                                Job(NoOfJobs).DateDue = currentField
                            Case 10
                                Job(NoOfJobs).Status = currentField
                            Case 11
                                Job(NoOfJobs).Archived = currentField
                        End Select
                    Next
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                End Try
            End While
        End Using
    End Sub
    Sub SaveJobs()
        WritePara = ""
        FileOpen(22, DirectoryLocation & "\jobs.txt", OpenMode.Output)
        For C = 1 To NoOfJobs
            WriteString = Job(C).ID & "," & Job(C).Ref & "," & Job(C).Category & "," & Job(C).DescriptionID & "," & Job(C).ITStaffID & "," & Job(C).EmployeeID & "," & Job(C).DateIn & "," & Job(C).Priority & "," & Job(C).DateDue & "," & Job(C).Status & "," & Job(C).Archived
            WritePara = WritePara & WriteString & vbNewLine
        Next
        PrintLine(22, WritePara)
        FileClose(22)
    End Sub

    'Department Record Handlers
    Sub AddDepartment(ByVal DN As String, ByVal PN As String, ByVal AD As String, ByVal TWN As String, ByVal CNT As String, ByVal PC As String, ByVal INT As Boolean)
        WriteString = " "
        FileOpen(4, DirectoryLocation & "\departments.txt", OpenMode.Append)
        ID(4) = Val(ID(4)) + 1
        WriteString = ID(4) & "," & DN & "," & PN & "," & AD & "," & TWN & "," & CNT & "," & PC & "," & INT & "," & False
        PrintLine(4, WriteString)
        FileClose(4)
        WriteID()
        Erase Department
        NoOfDepartments = 0
        LoadDepartments()
        WriteID()
    End Sub
    Sub LoadDepartments()
        NoOfDepartments = 0
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(DirectoryLocation & "\departments.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    N = 0
                    NoOfDepartments += 1
                    ReDim Preserve Department(NoOfDepartments)
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String
                    For Each currentField In currentRow
                        N += 1
                        Select Case N
                            Case 1
                                Department(NoOfDepartments).ID = currentField
                            Case 2
                                Department(NoOfDepartments).Name = currentField
                            Case 3
                                Department(NoOfDepartments).PhoneNo = currentField
                            Case 4
                                Department(NoOfDepartments).Address = currentField
                            Case 5
                                Department(NoOfDepartments).Town = currentField
                            Case 6
                                Department(NoOfDepartments).County = currentField
                            Case 7
                                Department(NoOfDepartments).Postcode = currentField
                            Case 8
                                Department(NoOfDepartments).Internal = currentField
                            Case 9
                                Department(NoOfDepartments).Archived = currentField
                        End Select
                    Next
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                End Try
            End While
        End Using
    End Sub
    Sub SaveDepartments()
        WritePara = ""
        FileOpen(42, DirectoryLocation & "\departments.txt", OpenMode.Output)
        For C = 1 To NoOfDepartments
            WriteString = Department(C).ID & "," & Department(C).Name & "," & Department(C).PhoneNo & "," & Department(C).Address & "," & Department(C).Town & "," & Department(C).County & "," & Department(C).Postcode & "," & Department(C).Internal & "," & Department(C).Archived
            WritePara = WritePara & WriteString & vbNewLine
        Next
        PrintLine(42, WritePara)
        FileClose(42)
    End Sub

    'Notes Record Handling
    Sub AddNote(ByVal Progress As Integer, ByVal DID As Integer, ByVal DA As String, ByVal JID As Integer, ByVal TM As Single)
        WriteString = " "
        FileOpen(5, DirectoryLocation & "\notes.txt", OpenMode.Append)
        ID(5) = Val(ID(5)) + 1
        WriteString = ID(5) & "," & Progress & "," & DID & "," & DA & "," & JID & "," & TM & "," & False
        PrintLine(5, WriteString)
        FileClose(5)
        NoOfNotes = 0
        LoadNotes()
        WriteID()
    End Sub
    Sub LoadNotes()
        NoOfNotes = 0
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(DirectoryLocation & "\notes.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    N = 0
                    NoOfNotes += 1
                    ReDim Preserve Note(NoOfNotes)
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String
                    For Each currentField In currentRow
                        N += 1
                        Select Case N
                            Case 1
                                Note(NoOfNotes).ID = currentField
                            Case 2
                                Note(NoOfNotes).Progress = currentField
                            Case 3
                                Note(NoOfNotes).DescriptionID = currentField
                            Case 4
                                Note(NoOfNotes).DateAdded = currentField
                            Case 5
                                Note(NoOfNotes).JobID = currentField
                            Case 6
                                Note(NoOfNotes).Time = currentField
                            Case 7
                                Note(NoOfNotes).Archived = currentField
                        End Select
                    Next
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                End Try
            End While
        End Using
    End Sub
    Sub SaveNotes()
        WritePara = ""
        FileOpen(52, DirectoryLocation & "\notes.txt", OpenMode.Output)
        For C = 1 To NoOfNotes
            WriteString = Note(C).ID & "," & Note(C).Progress & "," & Note(C).DescriptionID & "," & Note(C).DateAdded & "," & Note(C).JobID & "," & Note(C).Time & "," & Note(C).Archived
            WritePara = WritePara & WriteString & vbNewLine
        Next
        PrintLine(52, WritePara)
        FileClose(52)
    End Sub

    'All Extra Handling
    Sub LoadID()
        FileOpen(99, DirectoryLocation & "\settings.txt", OpenMode.Input)
        ID(1) = LineInput(99) 'Employee ID
        ID(2) = LineInput(99) 'Job ID
        ID(3) = LineInput(99) 'Asset ID
        ID(4) = LineInput(99) 'Department ID
        ID(5) = LineInput(99) 'Notes ID
        FileClose(99)
    End Sub
    Sub WriteID()
        FileOpen(98, DirectoryLocation & "\settings.txt", OpenMode.Output)
        PrintLine(98, ID(1)) 'Employee ID
        PrintLine(98, ID(2)) 'Job ID
        PrintLine(98, ID(3)) 'Asset ID
        PrintLine(98, ID(4)) 'Department ID
        PrintLine(98, ID(5)) 'Notes ID
        FileClose(98)
    End Sub
    Sub CreateRecord()
        'This creates all the various record files
        File.Create(DirectoryLocation & "\jobs.txt").Dispose()
        File.Create(DirectoryLocation & "\employee.txt").Dispose()
        File.Create(DirectoryLocation & "\assets.txt").Dispose()
        File.Create(DirectoryLocation & "\departments.txt").Dispose()
        File.Create(DirectoryLocation & "\notes.txt").Dispose()
        File.Create(DirectoryLocation & "\settings.txt").Dispose()
        File.Create(DirectoryLocation & "\category.txt").Dispose()
        Directory.CreateDirectory(DirectoryLocation & "\details\")
        FileOpen(18, DirectoryLocation & "\pass.txt", OpenMode.Output)
        PrintLine(18, getHash("Default"))
        FileClose(18)
        FileOpen(97, DirectoryLocation & "\settings.txt", OpenMode.Output)
        PrintLine(97, "0") 'Writes Employee ID
        PrintLine(97, "0") 'Writes Job ID
        PrintLine(97, "0") 'Writes Asset ID
        PrintLine(97, "0") 'Writes Department ID
        PrintLine(97, "0") 'Writes Notes ID
        FileClose(97)
        LoadID()
    End Sub
    Sub LoadCategories()
        NoOfJobCat = 0
        FileOpen(99, DirectoryLocation & "\category.txt", OpenMode.Input)
        N = 0
        Do Until EOF(99)
            N += 1
            NoOfJobCat = N
            ReDim Preserve JobCategory(N)
            JobCategory(N) = LineInput(99)
        Loop
        FileClose(99)
    End Sub
    Sub LoadIT()
        NoOfITStaff = 0
        For C = 1 To NoOfEmployees
            If Employee(C).DepartmentID = 1 Then
                NoOfITStaff += 1
                ReDim Preserve ITEmployee(NoOfITStaff)
                ITEmployee(NoOfITStaff).ID = Employee(C).ID
                ITEmployee(NoOfITStaff).FirstName = Employee(C).FirstName
                ITEmployee(NoOfITStaff).LastName = Employee(C).LastName
                ITEmployee(NoOfITStaff).Gender = Employee(C).Gender
                ITEmployee(NoOfITStaff).Email = Employee(C).Email
                ITEmployee(NoOfITStaff).PhoneExt = Employee(C).PhoneExt
                ITEmployee(NoOfITStaff).Mobile = Employee(C).Mobile
                ITEmployee(NoOfITStaff).DepartmentID = Employee(C).DepartmentID
                ITEmployee(NoOfITStaff).PriorityRanking = Employee(C).PriorityRanking
                ITEmployee(NoOfITStaff).Archived = Employee(C).Archived
            End If
        Next
    End Sub
    Sub LoadDetails()
        NoOfDetails = 0
        Dim N As Integer = DetailFiles.Count
        For C = 1 To N
            FileOpen(101, DetailFiles(C - 1), OpenMode.Input)
            WriteString = ""
            Do Until EOF(101)
                WriteString = WriteString & LineInput(101) & vbNewLine
            Loop
            NoOfDetails += 1
            ReDim Preserve Detail(NoOfDetails)
            Detail(NoOfDetails) = WriteString
            FileClose(101)
        Next
    End Sub
    Sub NewDetail()
        NoOfDetails += 1
        File.Create(DirectoryLocation & "\details\" & NoOfDetails & ".txt").Dispose()
    End Sub
    Function getHash(ByVal input As String)
        Dim md5Obj As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(input)
        bytesToHash = md5Obj.ComputeHash(bytesToHash)
        Dim b As Byte
        For Each b In bytesToHash
            getHash += b.ToString("x2")
        Next
    End Function
End Module
