<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enseignant
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Lbl_Etudiant = New System.Windows.Forms.Label()
        Me.Lbl_Date = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lbl_Type = New System.Windows.Forms.Label()
        Me.Lbl_Note = New System.Windows.Forms.Label()
        Me.CB_Ecues = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CB_GRADE = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CB_Type = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TB_STUDENT_SEARCH = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CB_STUDENTS = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.DGV_EVALUATIONS = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ecues = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BT_ADD = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_UPDATE = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_DELETE = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_REFRESH = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_LOGOUT = New Guna.UI2.WinForms.Guna2Button()
        Me.DTP_DATE = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.CB_WEIGHT = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BT_IMPRESSION = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DGV_EVALUATIONS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_Etudiant
        '
        Me.Lbl_Etudiant.AutoSize = True
        Me.Lbl_Etudiant.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Etudiant.Location = New System.Drawing.Point(17, 9)
        Me.Lbl_Etudiant.Name = "Lbl_Etudiant"
        Me.Lbl_Etudiant.Size = New System.Drawing.Size(52, 17)
        Me.Lbl_Etudiant.TabIndex = 0
        Me.Lbl_Etudiant.Text = "Ecues"
        '
        'Lbl_Date
        '
        Me.Lbl_Date.AutoSize = True
        Me.Lbl_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Date.Location = New System.Drawing.Point(111, 125)
        Me.Lbl_Date.Name = "Lbl_Date"
        Me.Lbl_Date.Size = New System.Drawing.Size(42, 17)
        Me.Lbl_Date.TabIndex = 2
        Me.Lbl_Date.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Recherche"
        '
        'Lbl_Type
        '
        Me.Lbl_Type.AutoSize = True
        Me.Lbl_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Type.Location = New System.Drawing.Point(521, 125)
        Me.Lbl_Type.Name = "Lbl_Type"
        Me.Lbl_Type.Size = New System.Drawing.Size(44, 17)
        Me.Lbl_Type.TabIndex = 4
        Me.Lbl_Type.Text = "Type"
        '
        'Lbl_Note
        '
        Me.Lbl_Note.AutoSize = True
        Me.Lbl_Note.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Note.Location = New System.Drawing.Point(1126, 188)
        Me.Lbl_Note.Name = "Lbl_Note"
        Me.Lbl_Note.Size = New System.Drawing.Size(42, 17)
        Me.Lbl_Note.TabIndex = 6
        Me.Lbl_Note.Text = "Note"
        '
        'CB_Ecues
        '
        Me.CB_Ecues.BackColor = System.Drawing.Color.Transparent
        Me.CB_Ecues.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_Ecues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Ecues.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_Ecues.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_Ecues.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CB_Ecues.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_Ecues.ItemHeight = 30
        Me.CB_Ecues.Location = New System.Drawing.Point(75, 3)
        Me.CB_Ecues.Name = "CB_Ecues"
        Me.CB_Ecues.Size = New System.Drawing.Size(1025, 36)
        Me.CB_Ecues.TabIndex = 7
        '
        'CB_GRADE
        '
        Me.CB_GRADE.BackColor = System.Drawing.Color.Transparent
        Me.CB_GRADE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_GRADE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_GRADE.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_GRADE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_GRADE.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CB_GRADE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_GRADE.ItemHeight = 30
        Me.CB_GRADE.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.CB_GRADE.Location = New System.Drawing.Point(1174, 177)
        Me.CB_GRADE.Name = "CB_GRADE"
        Me.CB_GRADE.Size = New System.Drawing.Size(66, 36)
        Me.CB_GRADE.StartIndex = 0
        Me.CB_GRADE.TabIndex = 9
        '
        'CB_Type
        '
        Me.CB_Type.BackColor = System.Drawing.Color.Transparent
        Me.CB_Type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Type.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_Type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_Type.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CB_Type.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_Type.ItemHeight = 30
        Me.CB_Type.Items.AddRange(New Object() {"Devoir", "Examen", "Rattrape", "Session Spécial"})
        Me.CB_Type.Location = New System.Drawing.Point(571, 114)
        Me.CB_Type.Name = "CB_Type"
        Me.CB_Type.Size = New System.Drawing.Size(235, 36)
        Me.CB_Type.TabIndex = 11
        '
        'TB_STUDENT_SEARCH
        '
        Me.TB_STUDENT_SEARCH.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_STUDENT_SEARCH.DefaultText = ""
        Me.TB_STUDENT_SEARCH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_STUDENT_SEARCH.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_STUDENT_SEARCH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_STUDENT_SEARCH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_STUDENT_SEARCH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_STUDENT_SEARCH.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_STUDENT_SEARCH.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_STUDENT_SEARCH.Location = New System.Drawing.Point(97, 234)
        Me.TB_STUDENT_SEARCH.Name = "TB_STUDENT_SEARCH"
        Me.TB_STUDENT_SEARCH.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_STUDENT_SEARCH.PlaceholderText = ""
        Me.TB_STUDENT_SEARCH.SelectedText = ""
        Me.TB_STUDENT_SEARCH.Size = New System.Drawing.Size(1224, 36)
        Me.TB_STUDENT_SEARCH.TabIndex = 12
        '
        'CB_STUDENTS
        '
        Me.CB_STUDENTS.BackColor = System.Drawing.Color.Transparent
        Me.CB_STUDENTS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_STUDENTS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_STUDENTS.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_STUDENTS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_STUDENTS.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CB_STUDENTS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_STUDENTS.ItemHeight = 30
        Me.CB_STUDENTS.Items.AddRange(New Object() {"AMELINA Coli", "DALMEDA Franc", "JOSHN Class"})
        Me.CB_STUDENTS.Location = New System.Drawing.Point(75, 54)
        Me.CB_STUDENTS.Name = "CB_STUDENTS"
        Me.CB_STUDENTS.Size = New System.Drawing.Size(1025, 36)
        Me.CB_STUDENTS.TabIndex = 14
        '
        'DGV_EVALUATIONS
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGV_EVALUATIONS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_EVALUATIONS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_EVALUATIONS.ColumnHeadersHeight = 4
        Me.DGV_EVALUATIONS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_EVALUATIONS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Nom, Me.Ecues, Me.Column1, Me.Column2})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_EVALUATIONS.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_EVALUATIONS.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_EVALUATIONS.Location = New System.Drawing.Point(-1, 276)
        Me.DGV_EVALUATIONS.Name = "DGV_EVALUATIONS"
        Me.DGV_EVALUATIONS.RowHeadersVisible = False
        Me.DGV_EVALUATIONS.Size = New System.Drawing.Size(1322, 266)
        Me.DGV_EVALUATIONS.TabIndex = 15
        Me.DGV_EVALUATIONS.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_EVALUATIONS.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGV_EVALUATIONS.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGV_EVALUATIONS.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGV_EVALUATIONS.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGV_EVALUATIONS.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_EVALUATIONS.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_EVALUATIONS.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_EVALUATIONS.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_EVALUATIONS.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_EVALUATIONS.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_EVALUATIONS.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_EVALUATIONS.ThemeStyle.HeaderStyle.Height = 4
        Me.DGV_EVALUATIONS.ThemeStyle.ReadOnly = False
        Me.DGV_EVALUATIONS.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_EVALUATIONS.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_EVALUATIONS.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_EVALUATIONS.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_EVALUATIONS.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_EVALUATIONS.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_EVALUATIONS.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        '
        'Nom
        '
        Me.Nom.DataPropertyName = "Nom"
        Me.Nom.HeaderText = "Nom"
        Me.Nom.Name = "Nom"
        '
        'Ecues
        '
        Me.Ecues.DataPropertyName = "Ecues"
        Me.Ecues.HeaderText = "Ecues"
        Me.Ecues.Name = "Ecues"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'BT_ADD
        '
        Me.BT_ADD.AutoRoundedCorners = True
        Me.BT_ADD.BorderRadius = 21
        Me.BT_ADD.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_ADD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_ADD.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_ADD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_ADD.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.BT_ADD.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BT_ADD.ForeColor = System.Drawing.Color.White
        Me.BT_ADD.Location = New System.Drawing.Point(75, 173)
        Me.BT_ADD.Name = "BT_ADD"
        Me.BT_ADD.Size = New System.Drawing.Size(180, 45)
        Me.BT_ADD.TabIndex = 16
        Me.BT_ADD.Text = "Insérer"
        '
        'BT_UPDATE
        '
        Me.BT_UPDATE.AutoRoundedCorners = True
        Me.BT_UPDATE.BorderRadius = 21
        Me.BT_UPDATE.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_UPDATE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_UPDATE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_UPDATE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_UPDATE.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.BT_UPDATE.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BT_UPDATE.ForeColor = System.Drawing.Color.White
        Me.BT_UPDATE.Location = New System.Drawing.Point(274, 173)
        Me.BT_UPDATE.Name = "BT_UPDATE"
        Me.BT_UPDATE.Size = New System.Drawing.Size(180, 45)
        Me.BT_UPDATE.TabIndex = 20
        Me.BT_UPDATE.Text = "Mise à jour"
        '
        'BT_DELETE
        '
        Me.BT_DELETE.AutoRoundedCorners = True
        Me.BT_DELETE.BorderRadius = 21
        Me.BT_DELETE.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_DELETE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_DELETE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_DELETE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_DELETE.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.BT_DELETE.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BT_DELETE.ForeColor = System.Drawing.Color.White
        Me.BT_DELETE.Location = New System.Drawing.Point(533, 173)
        Me.BT_DELETE.Name = "BT_DELETE"
        Me.BT_DELETE.Size = New System.Drawing.Size(180, 45)
        Me.BT_DELETE.TabIndex = 21
        Me.BT_DELETE.Text = "Supprimer"
        '
        'BT_REFRESH
        '
        Me.BT_REFRESH.AutoRoundedCorners = True
        Me.BT_REFRESH.BorderRadius = 21
        Me.BT_REFRESH.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_REFRESH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_REFRESH.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_REFRESH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_REFRESH.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.BT_REFRESH.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BT_REFRESH.ForeColor = System.Drawing.Color.White
        Me.BT_REFRESH.Location = New System.Drawing.Point(743, 173)
        Me.BT_REFRESH.Name = "BT_REFRESH"
        Me.BT_REFRESH.Size = New System.Drawing.Size(180, 45)
        Me.BT_REFRESH.TabIndex = 22
        Me.BT_REFRESH.Text = "Recharger"
        '
        'BT_LOGOUT
        '
        Me.BT_LOGOUT.AutoRoundedCorners = True
        Me.BT_LOGOUT.BorderRadius = 21
        Me.BT_LOGOUT.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_LOGOUT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_LOGOUT.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_LOGOUT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_LOGOUT.FillColor = System.Drawing.Color.Red
        Me.BT_LOGOUT.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BT_LOGOUT.ForeColor = System.Drawing.Color.White
        Me.BT_LOGOUT.Location = New System.Drawing.Point(1183, 3)
        Me.BT_LOGOUT.Name = "BT_LOGOUT"
        Me.BT_LOGOUT.Size = New System.Drawing.Size(138, 45)
        Me.BT_LOGOUT.TabIndex = 23
        Me.BT_LOGOUT.Text = "Déconnexion"
        '
        'DTP_DATE
        '
        Me.DTP_DATE.AutoRoundedCorners = True
        Me.DTP_DATE.BorderRadius = 17
        Me.DTP_DATE.Checked = True
        Me.DTP_DATE.CustomFormat = ""
        Me.DTP_DATE.FillColor = System.Drawing.Color.White
        Me.DTP_DATE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DTP_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_DATE.Location = New System.Drawing.Point(159, 114)
        Me.DTP_DATE.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTP_DATE.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTP_DATE.Name = "DTP_DATE"
        Me.DTP_DATE.Size = New System.Drawing.Size(190, 36)
        Me.DTP_DATE.TabIndex = 24
        Me.DTP_DATE.Value = New Date(2023, 1, 19, 17, 13, 0, 522)
        '
        'CB_WEIGHT
        '
        Me.CB_WEIGHT.BackColor = System.Drawing.Color.Transparent
        Me.CB_WEIGHT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_WEIGHT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_WEIGHT.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_WEIGHT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_WEIGHT.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CB_WEIGHT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_WEIGHT.ItemHeight = 30
        Me.CB_WEIGHT.Items.AddRange(New Object() {"0%", "20%", "40%", "60%", "80%", "100%"})
        Me.CB_WEIGHT.Location = New System.Drawing.Point(1174, 105)
        Me.CB_WEIGHT.Name = "CB_WEIGHT"
        Me.CB_WEIGHT.Size = New System.Drawing.Size(66, 36)
        Me.CB_WEIGHT.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1120, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Poids"
        '
        'BT_IMPRESSION
        '
        Me.BT_IMPRESSION.AutoRoundedCorners = True
        Me.BT_IMPRESSION.BorderRadius = 17
        Me.BT_IMPRESSION.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_IMPRESSION.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_IMPRESSION.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_IMPRESSION.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_IMPRESSION.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.BT_IMPRESSION.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BT_IMPRESSION.ForeColor = System.Drawing.Color.White
        Me.BT_IMPRESSION.Location = New System.Drawing.Point(948, 105)
        Me.BT_IMPRESSION.Name = "BT_IMPRESSION"
        Me.BT_IMPRESSION.Size = New System.Drawing.Size(115, 36)
        Me.BT_IMPRESSION.TabIndex = 27
        Me.BT_IMPRESSION.Text = "Imprimer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Etudiant"
        '
        'Enseignant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1324, 544)
        Me.Controls.Add(Me.BT_IMPRESSION)
        Me.Controls.Add(Me.CB_WEIGHT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTP_DATE)
        Me.Controls.Add(Me.BT_LOGOUT)
        Me.Controls.Add(Me.BT_REFRESH)
        Me.Controls.Add(Me.BT_DELETE)
        Me.Controls.Add(Me.BT_UPDATE)
        Me.Controls.Add(Me.BT_ADD)
        Me.Controls.Add(Me.DGV_EVALUATIONS)
        Me.Controls.Add(Me.CB_STUDENTS)
        Me.Controls.Add(Me.TB_STUDENT_SEARCH)
        Me.Controls.Add(Me.CB_Type)
        Me.Controls.Add(Me.CB_GRADE)
        Me.Controls.Add(Me.CB_Ecues)
        Me.Controls.Add(Me.Lbl_Note)
        Me.Controls.Add(Me.Lbl_Type)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Lbl_Date)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lbl_Etudiant)
        Me.Name = "Enseignant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Enseignant"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGV_EVALUATIONS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Etudiant As Label
    Friend WithEvents Lbl_Date As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Lbl_Type As Label
    Friend WithEvents Lbl_Note As Label
    Friend WithEvents CB_Ecues As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CB_GRADE As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CB_Type As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TB_STUDENT_SEARCH As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CB_STUDENTS As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents DGV_EVALUATIONS As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BT_ADD As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_UPDATE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_DELETE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_REFRESH As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_LOGOUT As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DTP_DATE As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents CB_WEIGHT As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BT_IMPRESSION As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents Ecues As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
End Class
