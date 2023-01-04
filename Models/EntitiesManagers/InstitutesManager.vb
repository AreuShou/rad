Public Class InstitutesManager
    Inherits Manager

    Public Shared Function getById(id As Integer) As Institute
        Dim insitute As Institute = Nothing
        Try
            command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM Institutes WHERE id = @id;", Manager.connection)
            command.Parameters.AddWithValue("@id", id)

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

    Public Shared Function getAll() As List(Of Institute)
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

    Public Shared Function store(institute As Institute) As Boolean
        Try
            command = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO Institutes VALUES(@libelle, @sigle);", Manager.connection)
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
            command = New MySql.Data.MySqlClient.MySqlCommand("UPDATE Institutes SET libelle = @libelle, sigle = @sigle WHERE id = @id;", Manager.connection)
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
