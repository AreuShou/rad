﻿Public Class InstitutesManager
    Inherits Manager
    Private Shared Function getInsitutueGenerique() As Institute
        Dim insitute As Institute = New Institute(Nothing, Nothing, Nothing)
        Try
            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)

            dataTable = New DataTable
            Manager.dataAdapater.Fill(Manager.dataTable)

            For Each row As DataRow In Manager.dataTable.Rows
                insitute = New Institute(CInt(row("id")), row("libelle"), row("sigle"))
            Next
            disposeManager()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return insitute
    End Function
    Public Shared Function getById(id As Integer) As Institute
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM Institutes WHERE id = @id;", Manager.connection)
        command.Parameters.AddWithValue("@id", id)
        Return getInsitutueGenerique()
    End Function

    Public Shared Function getByLibelle(libelle As String) As Institute
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM Institutes WHERE libelle = @libelle;", Manager.connection)
        command.Parameters.AddWithValue("@libelle", libelle)
        Return getInsitutueGenerique()
    End Function

    Public Shared Function getInstitutesGenerique() As List(Of Institute)
        Dim insituteList As New List(Of Institute)()
        Try
            command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM Institutes;", Manager.connection)

            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)

            dataTable = New DataTable
            Manager.dataAdapater.Fill(Manager.dataTable)

            For Each row As DataRow In Manager.dataTable.Rows
                insituteList.Add(New Institute(CInt(row("id")), row("libelle"), row("sigle")))
            Next
            disposeManager()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return insituteList
    End Function

    Public Shared Function getAll() As List(Of Institute)
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM Institutes;", Manager.connection)
        Return getInstitutesGenerique()
    End Function

    Public Shared Function search(word As String) As List(Of Institute)
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM Institutes WHERE libelle LIKE @word;", Manager.connection)
        command.Parameters.AddWithValue("@word", "%" & word & "%")
        Return getInstitutesGenerique()
    End Function

    Public Shared Function store(institute As Institute) As Boolean
        Try
            command = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO Institutes(libelle, sigle) VALUES(@libelle, @sigle);", Manager.connection)
            command.Parameters.AddWithValue("@libelle", institute.Libelle)
            command.Parameters.AddWithValue("@sigle", institute.Sigle)
            If (command.ExecuteNonQuery = 0) Then
                Return False
            Else
                Return True
            End If
            disposeManager()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Public Shared Function update(institute As Institute, id As Integer) As Boolean
        Try
            command = New MySql.Data.MySqlClient.MySqlCommand("UPDATE Institutes(libelle, sigle) SET libelle = @libelle, sigle = @sigle WHERE id = @id;", Manager.connection)
            command.Parameters.AddWithValue("@libelle", institute.Libelle)
            command.Parameters.AddWithValue("@sigle", institute.Sigle)
            command.Parameters.AddWithValue("@id", id)
            If (command.ExecuteNonQuery = 0) Then
                Return False
            Else
                Return True
            End If
            disposeManager()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Public Shared Function delete(id As Integer) As Boolean
        Try
            command = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM Institutes WHERE id = @id;", Manager.connection)
            command.Parameters.AddWithValue("@id", id)
            If (command.ExecuteNonQuery = 0) Then
                Return False
            Else
                Return True
            End If
            disposeManager()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function
End Class