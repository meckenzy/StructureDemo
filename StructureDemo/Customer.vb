Public Structure Customer
    'Public members
    Public FirstName As String
    Public LastName As String
    Public Email As String

    'Name property
    Public ReadOnly Property Name() As String
        Get
            Return FirstName & " " & LastName
        End Get
    End Property
End Structure
