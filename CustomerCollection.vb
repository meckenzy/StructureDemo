Imports Microsoft.VisualBasic

Public Class CustomerCollection
    Inherits CollectionBase

    'Private Member
    Private objHastable As New Hashtable

    'EmailHashtable property to return the Email Hastable
    Public ReadOnly Property EmailHashtable() As Hashtable
        Get
            Return objEmailHashtalbe
        End Get
    End Property

    'Add a customer to the collection
    Public Sub Add(newCustomer As Customer)
        Me.List.Add(newCustomer)

        'Add the email address to the Hashtable
        EmailHashtable.Add(newCustomer.Email, newCustomer)
    End Sub

    'Overload Item property to find a customer by email address
    Default Public ReadOnly Property Item(email As String) As CustomerCollection
        Get
            Return CType(EmailHashtable.Item(email), Customer)
        End Get
    End Property
    'Remove a cusomter to the collection
    Public Sub Remove(oldCustomer As Customer)
        Me.List.Remove(oldCustomer)
    End Sub

    'Item property to read or update a customer at a given position
    'in the list
    Default Public Property Item(index As Integer) As Customer
        Get
            Return CType(Me.List.Item(index), Customer)
        End Get
        Set(value As Customer)
            Me.List.Item(index) = value
        End Set
    End Property

    Public Shared Widening Operator CType(v As CustomerCollection) As CustomerCollection
        Throw New NotImplementedException()
    End Operator
End Class
