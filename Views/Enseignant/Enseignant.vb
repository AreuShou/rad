Imports System.Management

Public Class Enseignant

    Private Sub TeacherView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload_CB_ECUES()
        BT_REFRESH_Click(Nothing, Nothing)
    End Sub


    Private Sub CB_ECUES_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Ecues.SelectedIndexChanged
        Reload_CB_Students("")
        DGV_EVALUATIONS.DataSource = EvaluationsController.getByECUEId(CInt(CB_Ecues.SelectedItem().Split("-")(0)))
    End Sub
    Private Sub BT_REFRESH_Click(sender As Object, e As EventArgs) Handles BT_REFRESH.Click
        Reload_CB_Students("")
        DGV_EVALUATIONS.DataSource = EvaluationsController.getByECUEId(CInt(CB_Ecues.SelectedItem().Split("-")(0)))
    End Sub
    Private Sub TB_STUDENT_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles TB_STUDENT_SEARCH.TextChanged
        Reload_CB_Students(TB_STUDENT_SEARCH.Text)
    End Sub


    Private Sub EnableButton(value As Boolean)
        BT_ADD.Enabled = value
        BT_UPDATE.Enabled = value
        BT_DELETE.Enabled = value
    End Sub
    Public Sub Reload_CB_ECUES()
        CB_Ecues.Items.Clear()
        For Each ecue As ECUE In ECUEsManager.getByEmployeeId(ProjetController.user.Employee.Id)
            CB_Ecues.Items.Add(ecue.Name)
        Next

        Dim institutesExist As Boolean = CB_Ecues.Items.Count > 0
        EnableButton(institutesExist)
        If institutesExist Then
            CB_Ecues.SelectedIndex = 0
        Else
            CB_Ecues.SelectedIndex = -1
        End If
    End Sub

    Public Sub Reload_CB_Students(word As String)
        If CB_Ecues.Items.Count > 0 Then
            CB_STUDENTS.Items.Clear()
            Dim studentsList As List(Of Student) = StudentsManager.getByECUEId(CInt(CB_Ecues.SelectedItem.Split("-")(0)))
            For Each student As Student In studentsList
                If word <> Nothing Or word = "" Then
                    If student.Name.ToLower().Contains(word.ToLower()) Or word = "" Then
                        CB_STUDENTS.Items.Add(student.Name)
                    End If
                End If
            Next

            Dim studentsExist As Boolean = CB_STUDENTS.Items.Count > 0
            EnableButton(studentsExist)
            If studentsExist Then
                CB_STUDENTS.SelectedIndex = 0
            Else
                CB_STUDENTS.SelectedIndex = -1
            End If
        End If
    End Sub
    Private Sub BT_ADD_Click(sender As Object, e As EventArgs) Handles BT_ADD.Click
        If EvaluationsController.store(CInt(CB_Ecues.SelectedItem().Split("-")(0)), CInt(CB_STUDENTS.SelectedItem().Split("-")(0)), DTP_DATE.Value, CB_Type.SelectedItem, CInt(CB_WEIGHT.SelectedItem.Split("%")(0)), CInt(CB_GRADE.SelectedItem().Split("-")(0))) Then
            BT_REFRESH_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub BT_UPDATE_Click(sender As Object, e As EventArgs) Handles BT_UPDATE.Click
        If EvaluationsController.update(CInt(CB_Ecues.SelectedItem().Split("-")(0)), CInt(CB_STUDENTS.SelectedItem().Split("-")(0)), DTP_DATE.Value, CB_Type.SelectedItem, CInt(CB_WEIGHT.SelectedItem.Split("%")(0)), CInt(CB_GRADE.SelectedItem().Split("-")(0)), CInt(DGV_EVALUATIONS.SelectedRows(0).Cells(0).Value)) Then
            BT_REFRESH_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub BT_DELETE_Click(sender As Object, e As EventArgs) Handles BT_DELETE.Click
        Dim uesIdList As New List(Of Integer)()
        If DGV_EVALUATIONS.SelectedRows.Count > 0 Then
            For Each selectedRow As DataGridViewRow In DGV_EVALUATIONS.SelectedRows
                Dim ueId As Integer = selectedRow.Cells(0).Value
                uesIdList.Add(ueId)
            Next
            If (EvaluationsController.delete(uesIdList)) Then
                BT_REFRESH_Click(Nothing, Nothing)
            End If
        Else
            MessageBox.Show("Aucune ligne n'a été sélectionnée.", "Lignes non selectionné", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BT_LOGOUT_Click(sender As Object, e As EventArgs) Handles BT_LOGOUT.Click
        ProjetController.Logout()
    End Sub

    Private Sub BT_IMPRESSION_Click(sender As Object, e As EventArgs) Handles BT_IMPRESSION.Click
        Dim report As New NotesReport()
        report.SetDataSource(EvaluationsController.getAllFromReport(CInt(CB_Ecues.SelectedItem().Split("-")(0))))
        CrystalView.CRV.ReportSource = report
        CrystalView.Show()
    End Sub
End Class