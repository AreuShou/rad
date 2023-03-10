Imports System.IO

Public Class ServiceScolarite
    Private Sub TuititionServiceView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResizeDataGridViewRowHeight()
        PB_STUDENT.ImageLocation = Student.PicturePathDefault
        Reload_CB_INSTITUTE()
        Reload_CB_CAREER()
        DGV_STUDENTS.DataSource = StudentsController.getAll()

    End Sub
    Private Sub BT_REFRESH_Click(sender As Object, e As EventArgs) Handles BT_REFRESH.Click
        ResizeDataGridViewRowHeight()
        DGV_STUDENTS.DataSource = StudentsController.getAll()
    End Sub
    Private Sub CB_INSTITUTE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_INSTITUTE.SelectedIndexChanged
        Reload_CB_CAREER()
    End Sub
    Private Sub BT_ADD_Click(sender As Object, e As EventArgs) Handles BT_ADD.Click
        If StudentsController.store(TB_LAST_NAME.Text, TB_FIRST_NAME.Text, DTP_DATE.Value, CB_GENDER.SelectedItem, TB_EMAIL.Text, TB_PHONE_NUMBER.Text, PB_STUDENT.ImageLocation, CB_CAREER.SelectedItem.Split("-")(0), CInt(CB_SEMESTER.SelectedItem)) Then
            ClearForm()
            BT_REFRESH_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub BT_UPDATE_Click(sender As Object, e As EventArgs) Handles BT_UPDATE.Click
        Dim nbRowSelected = DGV_STUDENTS.SelectedRows.Count
        If nbRowSelected > 0 Then
            If nbRowSelected = 1 Then
                Dim selectedRow As DataGridViewRow = DGV_STUDENTS.SelectedRows(0)
                Dim studentId As Integer = selectedRow.Cells(1).Value
                If StudentsController.update(TB_LAST_NAME.Text, TB_FIRST_NAME.Text, DTP_DATE.Value, CB_GENDER.SelectedItem, TB_EMAIL.Text, TB_PHONE_NUMBER.Text, PB_STUDENT.ImageLocation, CB_CAREER.SelectedItem.Split("-")(0), CInt(CB_SEMESTER.SelectedItem), studentId) Then
                    ClearForm()
                    BT_REFRESH_Click(Nothing, Nothing)
                End If
            Else
                MessageBox.Show("Vous ne pouvez modifier qu'une ligne à la fois", "Modification multiple non permise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Aucune ligne n'a été sélectionnée.", "Ligne non selectionné", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub BT_DELETE_Click(sender As Object, e As EventArgs) Handles BT_DELETE.Click
        PB_STUDENT.ImageLocation = Student.PicturePathDefault
        Dim studentsIdList As New List(Of Integer)()
        Dim studentsPicturePathList As New List(Of String)()
        If DGV_STUDENTS.SelectedRows.Count > 0 Then
            For Each selectedRow As DataGridViewRow In DGV_STUDENTS.SelectedRows
                Dim studentId As Integer = selectedRow.Cells(1).Value
                studentsPicturePathList.Add(StudentsManager.getById(studentId).PicturePath)
                studentsIdList.Add(studentId)
            Next
            If (StudentsController.delete(studentsIdList)) Then
                BT_REFRESH_Click(Nothing, Nothing)
                For Each studentpicturepath As String In studentsPicturePathList
                    'File.Delete(studentpicturepath)
                Next
            End If
        Else
            MessageBox.Show("Aucune ligne n'a été sélectionnée.", "Lignes non selectionné", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CB_ADD_PICTURE_Click(sender As Object, e As EventArgs) Handles B_ADD_PICTURE.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.InitialDirectory = "."
        openFileDialog.Filter = "Images (*.BMP;*.JPG;*.JPEG;*.PNG;*.GIF)|*.BMP;*.JPG;*.JPEG;*.PNG;*.GIF|" & "All files (*.*)|*.*"
        openFileDialog.Title = "Sélectionnez une image"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = openFileDialog.FileName
            Dim sourceFile As String = openFileDialog.FileName
            PB_STUDENT.ImageLocation = sourceFile
        End If
    End Sub
    Private Sub BT_LOGOUT_Click(sender As Object, e As EventArgs) Handles BT_LOGOUT.Click
        ProjetController.Logout()
    End Sub




    Private Sub ClearForm()
        TB_FIRST_NAME.Text = ""
        TB_LAST_NAME.Text = ""
        TB_EMAIL.Text = ""
        TB_PHONE_NUMBER.Text = ""
    End Sub
    Private Sub EnableButtons(value As Boolean)
        BT_ADD.Enabled = value
        BT_UPDATE.Enabled = value
        BT_DELETE.Enabled = value
    End Sub
    Private Function selectGoodIndex(value As Boolean) As Integer
        If value Then
            Return 0
        Else
            Return -1
        End If
    End Function
    Public Sub Reload_CB_INSTITUTE()
        CB_INSTITUTE.Items.Clear()
        For Each institute As Institute In InstitutesManager.getAll()
            CB_INSTITUTE.Items.Add(institute.Name)
        Next
        Dim institutesExist As Boolean = CB_INSTITUTE.Items.Count > 0
        EnableButtons(institutesExist)
        CB_INSTITUTE.SelectedIndex = selectGoodIndex(institutesExist)
    End Sub

    Public Sub Reload_CB_CAREER()
        CB_CAREER.Items.Clear()
        If (CB_INSTITUTE.Items.Count > 0) Then
            For Each career As Career In CareersManager.getByInstituteId(CInt(CB_INSTITUTE.SelectedItem.Split("-")(0)))
                CB_CAREER.Items.Add(career.Name)
            Next
            Dim careersExist As Boolean = CB_CAREER.Items.Count > 0
            EnableButtons(careersExist)
            CB_CAREER.SelectedIndex = selectGoodIndex(careersExist)
        End If
    End Sub

    Public Sub ResizeDataGridViewRowHeight()
        DGV_STUDENTS.AutoSize = False
        DGV_STUDENTS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV_STUDENTS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        DGV_STUDENTS.DefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub

    Private Sub DGV_STUDENTS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_STUDENTS.CellClick
        Dim student As Student = StudentsManager.getById(CInt(DGV_STUDENTS.SelectedRows(0).Cells(1).Value))
        PB_STUDENT.ImageLocation = student.PicturePath
        TB_FIRST_NAME.Text = DGV_STUDENTS.SelectedRows(0).Cells(2).Value
        TB_LAST_NAME.Text = DGV_STUDENTS.SelectedRows(0).Cells(3).Value
        CB_CAREER.SelectedItem = DGV_STUDENTS.SelectedRows(0).Cells(5).Value
        TB_EMAIL.Text = DGV_STUDENTS.SelectedRows(0).Cells(6).Value
        TB_PHONE_NUMBER.Text = DGV_STUDENTS.SelectedRows(0).Cells(7).Value
        CB_CAREER.SelectedItem = DGV_STUDENTS.SelectedRows(0).Cells(8).Value
    End Sub

    Private Sub B_PRINT_Click(sender As Object, e As EventArgs) Handles B_PRINT.Click
        Dim report As New StudentsReport()
        report.SetDataSource(StudentsController.getAllFromReport())

        CrystalView.CRV.ReportSource = report
        CrystalView.Show()
    End Sub

    Private Sub PB_STUDENT_Click(sender As Object, e As EventArgs) Handles PB_STUDENT.Click

    End Sub
End Class