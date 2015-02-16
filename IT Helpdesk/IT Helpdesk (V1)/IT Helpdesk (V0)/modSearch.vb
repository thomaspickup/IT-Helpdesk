Module modSearch
    Public Results() As Integer
    Public NoOccurances() As Integer
    Public NoOfResults As Integer
    Public Query As String
    Public SearchString As String
    Public Sub Search()
        If Query = "Jobs" Then
            SearchJobs()
        ElseIf Query = "Employees" Then
            SearchEmployees()
        ElseIf Query = "Departments" Then
            SearchDepartments()
        End If
    End Sub
    Private Sub SearchJobs()
        Dim str As String
        Dim strsearch As String
        NoOfResults = 0
        For C = 1 To NoOfJobs
            If UCase(Detail(Job(C).DescriptionID)).Contains(UCase(SearchString)) And Not Job(C).Archived Then
                NoOfResults += 1
                ReDim Preserve Results(NoOfResults)
                ReDim Preserve NoOccurances(NoOfResults)

                Results(NoOfResults) = Job(C).ID
                str = Detail(Job(Results(NoOfResults)).DescriptionID)
                strsearch = SearchString
                If Not strsearch = "" Then
                    NoOccurances(NoOfResults) = (str.Length - UCase(str).Replace(UCase(strsearch), String.Empty).Length) / strsearch.Length
                End If
            End If
        Next
        Dim swapmade As Boolean = True
        Dim temp(1, 2) As Integer
        Do
            swapmade = False
            For j = 1 To NoOfResults - 1
                If NoOccurances(j) < NoOccurances(j + 1) Then
                    temp(1, 1) = Results(j)
                    temp(1, 2) = NoOccurances(j)
                    Results(j) = Results(j + 1)
                    NoOccurances(j) = NoOccurances(j + 1)
                    Results(j + 1) = temp(1, 1)
                    NoOccurances(j + 1) = temp(1, 2)
                    swapmade = True
                End If
            Next j
        Loop Until swapmade = False
    End Sub
    Private Sub SearchEmployees()
        NoOfResults = 0
        For C = 1 To NoOfEmployees
            If UCase(Employee(C).FirstName).Contains(UCase(SearchString)) Or UCase(Employee(C).LastName).Contains(UCase(SearchString)) Then
                NoOfResults += 1
                ReDim Preserve Results(NoOfResults)
                Results(NoOfResults) = Employee(C).ID
            End If
        Next
    End Sub
    Private Sub SearchDepartments()
        NoOfResults = 0
        For C = 1 To NoOfDepartments
            If UCase(Department(C).Name).Contains(UCase(SearchString)) Then
                NoOfResults += 1
                ReDim Preserve Results(NoOfResults)
                Results(NoOfResults) = Department(C).ID
            End If
        Next
    End Sub
End Module
