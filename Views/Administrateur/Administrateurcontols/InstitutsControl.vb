Public Class InstitutsControl
    Private Sub InstitutesControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GR_View.DataSource = InstitutesController.getAll()
    End Sub
    Private Sub ClearForm()
        BX_LIBELLE.Text = ""
        BX_SIGLE.Text = ""
    End Sub

    Private Sub BTN_Insert_Click(sender As Object, e As EventArgs) Handles BTN_Insert.Click
        If InstitutesController.store(BX_LIBELLE.Text, BX_SIGLE.Text) Then
            ClearForm()
            BTN_Insert_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub BTN_Recharge_Click(sender As Object, e As EventArgs) Handles BTN_Recharge.Click
        GR_View.DataSource = InstitutesController.getAll()
    End Sub

    Private Sub GR_View_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GR_View.CellContentClick
        BX_LIBELLE.Text = GR_View.SelectedRows(0).Cells(1).Value
        BX_SIGLE.Text = GR_View.SelectedRows(0).Cells(2).Value
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
                If InstitutesController.update(BX_LIBELLE.Text, BX_SIGLE.Text, institutId) Then
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

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged

    End Sub

    Private Sub Guna2HtmlLabel4_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel4.Click

    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel2.Click

    End Sub

    Private Sub BX_LIBELLE_TextChanged(sender As Object, e As EventArgs) Handles BX_LIBELLE.TextChanged

    End Sub

    Private Sub BX_SIGLE_TextChanged(sender As Object, e As EventArgs) Handles BX_SIGLE.TextChanged

    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

    End Sub

    Private Sub Guna2HtmlLabel3_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel3.Click

    End Sub
End Class