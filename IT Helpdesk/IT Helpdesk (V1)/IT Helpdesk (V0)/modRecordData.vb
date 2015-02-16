Imports System.IO

Module modRecordData
    'Below is the record holders...
    Structure Employees
        'Employee ID, First Name, Last Name, Gender, Email, Phone Extension, Mobile, Department ID, Priority Ranking, Wage, Archived
        Dim ID As Integer
        Dim FirstName As String
        Dim LastName As String
        Dim Gender As String
        Dim Email As String
        Dim PhoneExt As String
        Dim Mobile As String
        Dim DepartmentID As String
        Dim PriorityRanking As Integer
        Dim Wage As Single
        Dim Archived As Boolean
    End Structure
    Structure Departments
        'DepartmentID, Department Name, Phone Number, Address, Town, County, Postcode, Internal, Archived
        Dim ID As Integer
        Dim Name As String
        Dim PhoneNo As String
        Dim Address As String
        Dim Town As String
        Dim County As String
        Dim Postcode As String
        Dim Internal As Boolean
        Dim Archived As Boolean
    End Structure
    Structure Assets
        'Asset ID, Category, Description, Employee ID Related To, Archived
        Dim ID As Integer
        Dim Category As String
        Dim DescriptionID As String
        Dim EmployeeID As Integer
        Dim Archived As Boolean
    End Structure
    Structure Jobs
        'Job ID, Category, Description, IT Staff Assigned To (Default As 0 - UnAssigned), Call From, Date In, Priority, Date Due, Status, Archived
        Dim ID As Integer
        Dim Ref As String
        Dim Category As String
        Dim DescriptionID As Integer
        Dim ITStaffID As Integer
        Dim EmployeeID As Integer
        Dim DateIn As String
        Dim Priority As Integer
        Dim DateDue As String
        Dim Status As Integer
        Dim Archived As Boolean
    End Structure
    Structure Notes
        'Notes ID, Progress, Description, Date Added, JobID Related To, Time, Archived
        Dim ID As Integer
        Dim Progress As Integer
        Dim DescriptionID As Integer
        Dim DateAdded As String
        Dim JobID As Integer
        Dim Time As Single
        Dim Archived As Boolean
    End Structure

    'Here are the variables for the structures
    Public Employee() As Employees
    Public NoOfEmployees As Integer = 0
    Public Department() As Departments
    Public NoOfDepartments As Integer = 0
    Public Asset() As Assets
    Public NoOfAssets As Integer = 0
    Public Job() As Jobs
    Public NoOfJobs As Integer = 0
    Public Note() As Notes
    Public NoOfNotes As Integer = 0
    Public MyNote() As Notes
    Public NoOfMyNotes As Integer = 0
    Public MyJobs() As Jobs
    Public NoOfMyJobs As Integer = 0
    Public JobCategory() As String
    Public NoOfJobCat As Integer = 0
    Public ITEmployee() As Employees
    Public NoOfITStaff As Integer = 0
    Public DetailFiles As String() = Directory.GetFiles(DirectoryLocation & "\details", "*.txt")
    Public Detail() As String
    Public NoOfDetails As Integer = 0
End Module
