Public Class InstitutesControl
    Private Sub InstitutesControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GR_View.DataSource = InstitutesController.getAll()
    End Sub
    Private Sub ClearForm()
        BX_Institute1.Text = ""
        BX_IB.Text = ""
    End Sub
    Private Sub BX_IB_TextChanged(sender As Object, e As EventArgs) Handles BX_IB.TextChanged

    End Sub

    Private Sub BTN_Insert_Click(sender As Object, e As EventArgs) Handles BTN_Insert.Click
        If InstitutesController.store(BX_Institute1.Text, BX_IB.Text) Then
            ClearForm()
            BTN_Insert_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub BTN_Recharge_Click(sender As Object, e As EventArgs) Handles BTN_Recharge.Click
        GR_View.DataSource = InstitutesController.getAll()
    End Sub

    Private Sub GR_View_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GR_View.CellContentClick
        BX_Institute1.Text = GR_View.SelectedRows(0).Cells(1).Value
        BX_IB.Text = GR_View.SelectedRows(0).Cells(2).Value
    End Sub

    Private Sub Box_Recherche_TextChanged(sender As Object, e As EventArgs) Handles Box_Recherche.TextChanged
        GR_View.DataSource = InstitutesController.searchInstitutes(Box_Recherche.Text)
    End Sub

    Private Sub BTN_Ajour_Click(sender As Object, e As EventArgs) Handles BTN_Ajour.Click
        Dim nbRowSelected = GR_View.SelectedRows.Count
        If (nbRowSelected > 0) Then
            If nbRowSelected = 1 Then
                Dim selectedRow As DataGridViewRow = GR_View.SelectedRows(0)
                Dim institutId As Integer = selectedRow.Cells(0).Value
                If InstitutesController.update(BX_Institute1.Text, BX_IB.Text, institutId) Then
                    ClearForm()
                    BTN_Recharge_Click(Nothing, Nothing)
                End If
            Else
                MessageBox.Show("Vous ne pouvez mettre à jour qu'un seul élément à la fois", "Mise à jour multiple", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Aucune ligne sélectionnée", "Aucune ligne sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BTN_Supprime_Click(sender As Object, e As EventArgs) Handles BTN_Supprime.Click
        Dim institutesIdList As New List(Of Integer)()
        If GR_View.SelectedRows.Count > 0 Then
            For Each selectedRow As DataGridViewRow In GR_View.SelectedRows
                institutesIdList.Add(selectedRow.Cells(0).Value)
            Next
            If InstitutesController.delete(institutesIdList) Then
                ClearForm()
                BTN_Recharge_Click(Nothing, Nothing)
            End If
        Else
            MessageBox.Show("Aucune ligne sélectionnée", "Aucune ligne sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class