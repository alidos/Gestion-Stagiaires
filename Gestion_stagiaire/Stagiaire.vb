Imports Gestion_stagiaire

Public Class Stagiaire
    Private id As Integer
    Private firstName As String
    Private lastName As String
    Private age As Integer
    Private note As Double


    Public Sub New()

    End Sub

    Public Sub New(id As Integer, firstName As String, lastName As String, age As Integer, note As Double)
        Me.id = id
        Me.firstName = firstName
        Me.lastName = lastName
        Me.age = age
        Me.note = note
    End Sub

    Public Function getId()
        Return Me.id
    End Function

    Public Function getFirstName()
        Return Me.firstName
    End Function

    Public Function getLastName()
        Return Me.lastName
    End Function

    Public Function getAge()
        Return Me.age
    End Function

    Public Function getNote()
        Return Me.age
    End Function

    Public Sub setId(id As Integer)
        Me.id = id
    End Sub

    Public Sub setFirstName(firstName As String)
        Me.firstName = firstName
    End Sub

    Public Sub setLastName(lastName As String)
        Me.lastName = lastName
    End Sub

    Public Sub setAge(age As Integer)
        Me.age = age
    End Sub

    Public Sub setNote(note As Integer)
        Me.note = note
    End Sub


    Public Sub afficher()
        Console.WriteLine("Id = " & id & " ,FirstName = " & firstName & " , LastName = " & lastName & " , Age = " & age & " , Note = " & note)
    End Sub

    Public Function Affiche()
        Return "Id = " & id & " ,FirstName = " & firstName & " , LastName = " & lastName & " , Age = " & age & " , Note = " & note
    End Function


End Class
