﻿Public Class Employee
    Private _id As Integer
    Private _lastName As String
    Private _firstName As String
    Private _phoneNumber As String
    Private _email As String
    Private _gender As String
    Private _functionField As String

    Public Sub New(id As Integer, lastName As String, firstName As String, phoneNumber As String, email As String, gender As String, functionField As String)
        Me.Id = id
        Me.LastName = lastName
        Me.FirstName = firstName
        Me.PhoneNumber = phoneNumber
        Me.Email = email
        Me.Gender = gender
        Me.FunctionField = functionField
    End Sub

    Public Sub New(lastName As String, firstName As String, phoneNumber As String, email As String, gender As String, functionField As String)
        Me.LastName = lastName
        Me.FirstName = firstName
        Me.PhoneNumber = phoneNumber
        Me.Email = email
        Me.Gender = gender
        Me.FunctionField = functionField
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property LastName As String
        Get
            Return _lastName
        End Get
        Set(value As String)
            _lastName = value
        End Set
    End Property

    Public Property FirstName As String
        Get
            Return _firstName
        End Get
        Set(value As String)
            _firstName = value
        End Set
    End Property

    Public Property PhoneNumber As String
        Get
            Return _phoneNumber
        End Get
        Set(value As String)
            _phoneNumber = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property Gender As String
        Get
            Return _gender
        End Get
        Set(value As String)
            _gender = value
        End Set
    End Property

    Public Property FunctionField As String
        Get
            Return _functionField
        End Get
        Set(value As String)
            _functionField = value
        End Set
    End Property

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim employee = TryCast(obj, Employee)
        Return employee IsNot Nothing AndAlso
               _id = employee._id AndAlso
               _lastName = employee._lastName AndAlso
               _firstName = employee._firstName AndAlso
               _phoneNumber = employee._phoneNumber AndAlso
               _email = employee._email AndAlso
               _gender = employee._gender AndAlso
               _functionField = employee._functionField
    End Function
End Class