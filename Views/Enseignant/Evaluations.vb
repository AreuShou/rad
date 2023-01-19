Imports System.Management

Public Class Enseignant


    Private Sub Enseignant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload_CB_Ecues()
        btn_Recharge_Click(Nothing, Nothing)
    End Sub


    Private Sub CB_Ecues_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Ecues.SelectedIndexChanged
        Reload_CB_Student("")
        GRD_View.DataSource = EvaluationsController.getByECUEId(CInt(CB_Ecues.SelectedItem().Split("-")(0)))
    End Sub
    Private Sub btn_Recharge_Click(sender As Object, e As EventArgs) Handles btn_Recharge.Click
        Reload_CB_Student("")
        GRD_View.DataSource = EvaluationsController.getByECUEId(CInt(CB_Ecues.SelectedItem().Split("-")(0)))
    End Sub
    Private Sub TB_Recherche_TextChanged(sender As Object, e As EventArgs) Handles TB_Recherche.TextChanged
        Reload_CB_Student(TB_Recherche.Text)
    End Sub


    Private Sub EnableButton(value As Boolean)
        btn_Inserer.Enabled = value
        btn_Ajour.Enabled = value
        btn_Supprime.Enabled = value
    End Sub
    Public Sub Reload_CB_Ecues()
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

    Public Sub Reload_CB_Student(word As String)
        If CB_Ecues.Items.Count > 0 Then
            CB_Etudiant.Items.Clear()
            Dim StudentsList As List(Of Student) = StudentsManager.getByECUEId(CInt(CB_Ecues.SelectedItem.Split("-")(0)))
            For Each Student As Student In StudentsList
                If word <> Nothing Or word = "" Then
                    If Student.Name.ToLower().Contains(word.ToLower()) Or word = "" Then
                        CB_Etudiant.Items.Add(Student.Name)
                    End If
                End If
            Next

            Dim StudentsExist As Boolean = CB_Etudiant.Items.Count > 0
            EnableButton(StudentsExist)
            If StudentsExist Then
                CB_Etudiant.SelectedIndex = 0
            Else
                CB_Etudiant.SelectedIndex = -1
            End If
        End If
    End Sub
    Private Sub btn_Inserer_Click(sender As Object, e As EventArgs) Handles btn_Inserer.Click
        If EvaluationsController.store(CInt(CB_Ecues.SelectedItem().Split("-")(0)), CInt(CB_Etudiant.SelectedItem().Split("-")(0)), DTP_DATE.Value, CB_Type.SelectedItem, CInt(CB_WEIGHT.SelectedItem.Split("%")(0)), CInt(CB_GRADE.SelectedItem().Split("-")(0))) Then
            btn_Recharge_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub btn_Ajour_Click(sender As Object, e As EventArgs) Handles btn_Ajour.Click
        If EvaluationsController.update(CInt(CB_Ecues.SelectedItem().Split("-")(0)), CInt(CB_Etudiant.SelectedItem().Split("-")(0)), DTP_DATE.Value, CB_Type.SelectedItem, CInt(CB_WEIGHT.SelectedItem.Split("%")(0)), CInt(CB_GRADE.SelectedItem().Split("-")(0)), CInt(GRD_View.SelectedRows(0).Cells(0).Value)) Then
            btn_Recharge_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub btn_Supprime_Click(sender As Object, e As EventArgs) Handles btn_Supprime.Click
        Dim uesIdList As New List(Of Integer)()
        If GRD_View.SelectedRows.Count > 0 Then
            For Each selectedRow As DataGridViewRow In GRD_View.SelectedRows
                Dim ueId As Integer = selectedRow.Cells(0).Value
                uesIdList.Add(ueId)
            Next
            If (EvaluationsController.delete(uesIdList)) Then
                btn_Recharge_Click(Nothing, Nothing)
            End If
        Else
            MessageBox.Show("Aucune ligne n'a été sélectionnée.", "Lignes non selectionné", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub BT_LOGOUT_Click(sender As Object, e As EventArgs) Handles BT_LOGOUT.Click
        ProjetController.Logout()
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Lbl_Date.Click

    End Sub

    Private Sub Guna2ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles BT_LOGOUT.Click

    End Sub
End Class