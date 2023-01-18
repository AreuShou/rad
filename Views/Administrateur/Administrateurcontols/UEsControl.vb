Public Class UEsControl


    Private Sub UEsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            BT_REFRESH_Click(Nothing, Nothing)
        Reload_CLB_UEs()
        ResizeDataGridViewRowHeight()
    End Sub
    Public Sub BT_REFRESH_Click(sender As Object, e As EventArgs) Handles BTN_Recharge.Click
        ReloadCB_INSTITUTE()
        Ues_View.DataSource = UEsController.getAll()
        checkButtons()
    End Sub
    Private Sub BT_ADD_Click(sender As Object, e As EventArgs) Handles BTN_Insert.Click
        If (UEsController.store(Nom_TextBox.Text, CB_Semestre.SelectedItem, getCareerSelectedIdList())) Then
            ClearForm()
            BT_REFRESH_Click(Nothing, Nothing)
        End If
        checkButtons()
    End Sub
    Private Sub BTN_Ajour_Click(sender As Object, e As EventArgs) Handles BTN_Ajour.Click
        Dim nbRowSelected = Ues_View.SelectedRows.Count
        If nbRowSelected > 0 Then
            If nbRowSelected = 1 Then
                Dim selectedRow As DataGridViewRow = Ues_View.SelectedRows(0)
                Dim ueId As Integer = selectedRow.Cells(0).Value
                If (UEsController.update(Nom_TextBox.Text, CB_Semestre.SelectedItem, getCareerSelectedIdList(), ueId)) Then
                    ClearForm()
                    BT_REFRESH_Click(Nothing, Nothing)
                End If
            Else
                MessageBox.Show("Vous ne pouvez modifier qu'une ligne à la fois", "Modification multiple non permise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Aucune ligne n'a été sélectionnée.", "Ligne non selectionné", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        checkButtons()
    End Sub

    Private Sub BTN_Supprime_Click(sender As Object, e As EventArgs) Handles BTN_Supprime.Click
        Dim uesIdList As New List(Of Integer)()
        If Ues_View.SelectedRows.Count > 0 Then
            For Each selectedRow As DataGridViewRow In Ues_View.SelectedRows
                Dim ueId As Integer = selectedRow.Cells(0).Value
                uesIdList.Add(ueId)
            Next
            If (UEsController.delete(uesIdList)) Then
                BT_REFRESH_Click(Nothing, Nothing)
            End If
        Else
            MessageBox.Show("Aucune ligne n'a été sélectionnée.", "Lignes non selectionné", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        checkButtons()
    End Sub

    Private Sub Ues_View_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Ues_View.CellClick
        Nom_TextBox.Text = Ues_View.SelectedRows(0).Cells(1).Value
        CB_Semestre.SelectedItem = Ues_View.SelectedRows(0).Cells(2).Value
        UnCheckCLB_UEs()
        For i As Integer = 0 To CLB_UEs.Items.Count - 1
            If Ues_View.SelectedRows(0).Cells(3).Value.Contains(CLB_UEs.Items(i).Split(" - ")(0).Split("-")(1)) Then
                CLB_UEs.SetItemChecked(i, True)
            End If
        Next
    End Sub


    Private Sub BX_Recherche_TextChanged(sender As Object, e As EventArgs) Handles BX_Recherche.TextChanged
        Ues_View.DataSource = UEsController.search(BX_Recherche.Text)
    End Sub

    Private Sub CB_INSTITUTE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_INSTITUTE.SelectedIndexChanged
        Reload_CLB_UEs()
    End Sub

    Public Sub ClearForm()
        Nom_TextBox.Text = ""
    End Sub
    Public Sub checkButtons()
        Dim nbRowSelected = Ues_View.SelectedRows.Count
        If nbRowSelected > 0 Then
            BTN_Supprime.Enabled = True
            BTN_Ajour.Enabled = True
        Else
            BTN_Supprime.Enabled = False
            BTN_Ajour.Enabled = False
        End If
    End Sub
    Public Sub ResizeDataGridViewRowHeight()
        Ues_View.AutoSize = False
        Ues_View.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Ues_View.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        Ues_View.DefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub
    Public Sub ReloadCB_INSTITUTE()
        CB_INSTITUTE.Items.Clear()
        For Each institute As Institute In InstitutesManager.getAll()
            CB_INSTITUTE.Items.Add(institute.Id & "-" & institute.Sigle & " - " & institute.Libelle)
        Next

        Dim instituteExist As Boolean = CB_INSTITUTE.Items.Count > 0
        BTN_Insert.Enabled = instituteExist
        BTN_Ajour.Enabled = instituteExist
        BTN_Supprime.Enabled = instituteExist
        If instituteExist Then
            CB_INSTITUTE.SelectedIndex = 0
        Else
            CB_INSTITUTE.SelectedIndex = -1
        End If
    End Sub
    Private Sub Reload_CLB_UEs()
        CLB_UEs.BeginUpdate()
        CLB_UEs.Items.Clear()
        For Each career In CareersManager.getByInstituteId(CInt(CB_INSTITUTE.SelectedItem().split("-")(0)))
            CLB_UEs.Items.Add(career.Name)
        Next

        CLB_UEs.EndUpdate()
    End Sub
    Private Sub UnCheckCLB_UEs()
        For i As Integer = 0 To CLB_UEs.Items.Count - 1
            CLB_UEs.SetItemChecked(i, False)
        Next
    End Sub
    Private Function getCareerSelectedIdList() As List(Of Integer)
        Dim careerIdList As New List(Of Integer)()
        For Each selectedItem In CLB_UEs.CheckedItems
            careerIdList.Add(CInt(selectedItem.ToString().Split("-")(0)))
        Next
        Return careerIdList
        End Function

End Class
