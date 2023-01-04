Imports Mysqlx.XDevAPI.Relational

Public Class EmployeesController
    Public Shared Function getAll() As DataTable
        Dim table As DataTable = New DataTable
        table.Columns.Add("Identifiant", GetType(Integer))
        table.Columns.Add("Nom", GetType(String))
        table.Columns.Add("Prénoms", GetType(String))
        table.Columns.Add("Téléphone", GetType(String))
        table.Columns.Add("Email", GetType(String))
        table.Columns.Add("Genre", GetType(String))
        table.Columns.Add("Fonction", GetType(String))


        For Each employee As Employee In EmployeesManager.getAll()
            table.LoadDataRow(New Object() {employee.Id, employee.LastName, employee.FirstName, employee.PhoneNumber, employee.Email, employee.Gender, employee.FunctionField}, True)
        Next
        Return table
    End Function
End Class
