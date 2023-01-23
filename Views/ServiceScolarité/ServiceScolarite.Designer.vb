<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ServiceScolarite
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGV_STUDENTS = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_FIRST_NAME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_LAST_NAME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TB_EMAIL = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CB_CAREER = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CB_GENDER = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.BT_REFRESH = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_ADD = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_UPDATE = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_DELETE = New Guna.UI2.WinForms.Guna2Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_PHONE_NUMBER = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2ComboBox5 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CB_INSTITUTE = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CB_SEMESTER = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BT_LOGOUT = New Guna.UI2.WinForms.Guna2Button()
        Me.DTP_DATE = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.PB_STUDENT = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.B_PRINT = New Guna.UI2.WinForms.Guna2Button()
        Me.B_ADD_PICTURE = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.DGV_STUDENTS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_STUDENT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_STUDENTS
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.DGV_STUDENTS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_STUDENTS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DGV_STUDENTS.ColumnHeadersHeight = 4
        Me.DGV_STUDENTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_STUDENTS.DefaultCellStyle = DataGridViewCellStyle9
        Me.DGV_STUDENTS.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_STUDENTS.Location = New System.Drawing.Point(9, 344)
        Me.DGV_STUDENTS.Name = "DGV_STUDENTS"
        Me.DGV_STUDENTS.RowHeadersVisible = False
        Me.DGV_STUDENTS.Size = New System.Drawing.Size(1359, 381)
        Me.DGV_STUDENTS.TabIndex = 0
        Me.DGV_STUDENTS.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_STUDENTS.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGV_STUDENTS.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGV_STUDENTS.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGV_STUDENTS.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGV_STUDENTS.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_STUDENTS.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_STUDENTS.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_STUDENTS.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_STUDENTS.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_STUDENTS.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_STUDENTS.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_STUDENTS.ThemeStyle.HeaderStyle.Height = 4
        Me.DGV_STUDENTS.ThemeStyle.ReadOnly = False
        Me.DGV_STUDENTS.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_STUDENTS.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_STUDENTS.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_STUDENTS.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_STUDENTS.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_STUDENTS.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_STUDENTS.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(214, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(215, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Genre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(215, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Faculté"
        '
        'TB_FIRST_NAME
        '
        Me.TB_FIRST_NAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_FIRST_NAME.DefaultText = "PALOU"
        Me.TB_FIRST_NAME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_FIRST_NAME.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_FIRST_NAME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_FIRST_NAME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_FIRST_NAME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_FIRST_NAME.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_FIRST_NAME.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_FIRST_NAME.Location = New System.Drawing.Point(309, 26)
        Me.TB_FIRST_NAME.Name = "TB_FIRST_NAME"
        Me.TB_FIRST_NAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_FIRST_NAME.PlaceholderText = ""
        Me.TB_FIRST_NAME.SelectedText = ""
        Me.TB_FIRST_NAME.Size = New System.Drawing.Size(200, 36)
        Me.TB_FIRST_NAME.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(515, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Prénoms"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(546, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Email"
        '
        'TB_LAST_NAME
        '
        Me.TB_LAST_NAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_LAST_NAME.DefaultText = "Arlette"
        Me.TB_LAST_NAME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_LAST_NAME.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_LAST_NAME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_LAST_NAME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_LAST_NAME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_LAST_NAME.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_LAST_NAME.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_LAST_NAME.Location = New System.Drawing.Point(615, 28)
        Me.TB_LAST_NAME.Name = "TB_LAST_NAME"
        Me.TB_LAST_NAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_LAST_NAME.PlaceholderText = ""
        Me.TB_LAST_NAME.SelectedText = ""
        Me.TB_LAST_NAME.Size = New System.Drawing.Size(200, 36)
        Me.TB_LAST_NAME.TabIndex = 9
        '
        'TB_EMAIL
        '
        Me.TB_EMAIL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_EMAIL.DefaultText = "palouarlette@gmail.com" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TB_EMAIL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_EMAIL.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_EMAIL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_EMAIL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_EMAIL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_EMAIL.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_EMAIL.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_EMAIL.Location = New System.Drawing.Point(615, 91)
        Me.TB_EMAIL.Name = "TB_EMAIL"
        Me.TB_EMAIL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_EMAIL.PlaceholderText = ""
        Me.TB_EMAIL.SelectedText = ""
        Me.TB_EMAIL.Size = New System.Drawing.Size(200, 36)
        Me.TB_EMAIL.TabIndex = 10
        '
        'CB_CAREER
        '
        Me.CB_CAREER.BackColor = System.Drawing.Color.Transparent
        Me.CB_CAREER.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_CAREER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_CAREER.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_CAREER.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_CAREER.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CB_CAREER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_CAREER.ItemHeight = 30
        Me.CB_CAREER.Location = New System.Drawing.Point(309, 156)
        Me.CB_CAREER.Name = "CB_CAREER"
        Me.CB_CAREER.Size = New System.Drawing.Size(200, 36)
        Me.CB_CAREER.TabIndex = 15
        '
        'CB_GENDER
        '
        Me.CB_GENDER.BackColor = System.Drawing.Color.Transparent
        Me.CB_GENDER.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_GENDER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_GENDER.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_GENDER.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_GENDER.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CB_GENDER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_GENDER.ItemHeight = 30
        Me.CB_GENDER.Items.AddRange(New Object() {"Homme"})
        Me.CB_GENDER.Location = New System.Drawing.Point(309, 88)
        Me.CB_GENDER.Name = "CB_GENDER"
        Me.CB_GENDER.Size = New System.Drawing.Size(200, 36)
        Me.CB_GENDER.TabIndex = 16
        '
        'BT_REFRESH
        '
        Me.BT_REFRESH.AutoRoundedCorners = True
        Me.BT_REFRESH.BorderRadius = 21
        Me.BT_REFRESH.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_REFRESH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_REFRESH.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_REFRESH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_REFRESH.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BT_REFRESH.ForeColor = System.Drawing.Color.White
        Me.BT_REFRESH.Location = New System.Drawing.Point(1178, 242)
        Me.BT_REFRESH.Name = "BT_REFRESH"
        Me.BT_REFRESH.Size = New System.Drawing.Size(180, 45)
        Me.BT_REFRESH.TabIndex = 22
        Me.BT_REFRESH.Text = "Recharger"
        '
        'BT_ADD
        '
        Me.BT_ADD.AutoRoundedCorners = True
        Me.BT_ADD.BorderRadius = 21
        Me.BT_ADD.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_ADD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_ADD.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_ADD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_ADD.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BT_ADD.ForeColor = System.Drawing.Color.White
        Me.BT_ADD.Location = New System.Drawing.Point(1178, 191)
        Me.BT_ADD.Name = "BT_ADD"
        Me.BT_ADD.Size = New System.Drawing.Size(180, 45)
        Me.BT_ADD.TabIndex = 21
        Me.BT_ADD.Text = "Ajouter"
        '
        'BT_UPDATE
        '
        Me.BT_UPDATE.AutoRoundedCorners = True
        Me.BT_UPDATE.BorderRadius = 21
        Me.BT_UPDATE.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_UPDATE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_UPDATE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_UPDATE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_UPDATE.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BT_UPDATE.ForeColor = System.Drawing.Color.White
        Me.BT_UPDATE.Location = New System.Drawing.Point(1178, 140)
        Me.BT_UPDATE.Name = "BT_UPDATE"
        Me.BT_UPDATE.Size = New System.Drawing.Size(180, 45)
        Me.BT_UPDATE.TabIndex = 20
        Me.BT_UPDATE.Text = "Modifier"
        '
        'BT_DELETE
        '
        Me.BT_DELETE.AutoRoundedCorners = True
        Me.BT_DELETE.BorderRadius = 21
        Me.BT_DELETE.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_DELETE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_DELETE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_DELETE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_DELETE.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BT_DELETE.ForeColor = System.Drawing.Color.White
        Me.BT_DELETE.Location = New System.Drawing.Point(1178, 87)
        Me.BT_DELETE.Name = "BT_DELETE"
        Me.BT_DELETE.Size = New System.Drawing.Size(180, 45)
        Me.BT_DELETE.TabIndex = 19
        Me.BT_DELETE.Text = "Supprimer"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(842, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 24)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Naissance"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(837, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 24)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Téléphone"
        '
        'TB_PHONE_NUMBER
        '
        Me.TB_PHONE_NUMBER.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_PHONE_NUMBER.DefaultText = "+221 89546213"
        Me.TB_PHONE_NUMBER.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_PHONE_NUMBER.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_PHONE_NUMBER.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_PHONE_NUMBER.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_PHONE_NUMBER.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_PHONE_NUMBER.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_PHONE_NUMBER.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_PHONE_NUMBER.Location = New System.Drawing.Point(955, 89)
        Me.TB_PHONE_NUMBER.Name = "TB_PHONE_NUMBER"
        Me.TB_PHONE_NUMBER.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_PHONE_NUMBER.PlaceholderText = ""
        Me.TB_PHONE_NUMBER.SelectedText = ""
        Me.TB_PHONE_NUMBER.Size = New System.Drawing.Size(200, 43)
        Me.TB_PHONE_NUMBER.TabIndex = 26
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Location = New System.Drawing.Point(124, 301)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderText = ""
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.Size = New System.Drawing.Size(1244, 37)
        Me.Guna2TextBox2.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 24)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Recherche"
        '
        'Guna2ComboBox5
        '
        Me.Guna2ComboBox5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox5.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox5.ItemHeight = 30
        Me.Guna2ComboBox5.Location = New System.Drawing.Point(535, 251)
        Me.Guna2ComboBox5.Name = "Guna2ComboBox5"
        Me.Guna2ComboBox5.Size = New System.Drawing.Size(200, 36)
        Me.Guna2ComboBox5.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(436, 261)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 24)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Parcours"
        '
        'CB_INSTITUTE
        '
        Me.CB_INSTITUTE.BackColor = System.Drawing.Color.Transparent
        Me.CB_INSTITUTE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_INSTITUTE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_INSTITUTE.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_INSTITUTE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_INSTITUTE.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CB_INSTITUTE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_INSTITUTE.ItemHeight = 30
        Me.CB_INSTITUTE.Location = New System.Drawing.Point(124, 251)
        Me.CB_INSTITUTE.Name = "CB_INSTITUTE"
        Me.CB_INSTITUTE.Size = New System.Drawing.Size(200, 36)
        Me.CB_INSTITUTE.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(49, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 24)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Institut"
        '
        'CB_SEMESTER
        '
        Me.CB_SEMESTER.BackColor = System.Drawing.Color.Transparent
        Me.CB_SEMESTER.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_SEMESTER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_SEMESTER.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_SEMESTER.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_SEMESTER.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CB_SEMESTER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_SEMESTER.ItemHeight = 30
        Me.CB_SEMESTER.Location = New System.Drawing.Point(955, 251)
        Me.CB_SEMESTER.Name = "CB_SEMESTER"
        Me.CB_SEMESTER.Size = New System.Drawing.Size(200, 36)
        Me.CB_SEMESTER.TabIndex = 41
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(851, 261)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 24)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Semestre"
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
        Me.BT_LOGOUT.Location = New System.Drawing.Point(1178, 3)
        Me.BT_LOGOUT.Name = "BT_LOGOUT"
        Me.BT_LOGOUT.Size = New System.Drawing.Size(180, 45)
        Me.BT_LOGOUT.TabIndex = 45
        Me.BT_LOGOUT.Text = "Déconnexion"
        '
        'DTP_DATE
        '
        Me.DTP_DATE.Checked = True
        Me.DTP_DATE.CustomFormat = "yyyy/MM/dd HH:mm:ii"
        Me.DTP_DATE.FillColor = System.Drawing.Color.White
        Me.DTP_DATE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DTP_DATE.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DTP_DATE.Location = New System.Drawing.Point(955, 28)
        Me.DTP_DATE.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTP_DATE.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTP_DATE.Name = "DTP_DATE"
        Me.DTP_DATE.Size = New System.Drawing.Size(200, 43)
        Me.DTP_DATE.TabIndex = 46
        Me.DTP_DATE.Value = New Date(2023, 1, 19, 22, 20, 54, 792)
        '
        'PB_STUDENT
        '
        Me.PB_STUDENT.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal
        Me.PB_STUDENT.ImageRotate = 0!
        Me.PB_STUDENT.Location = New System.Drawing.Point(9, 12)
        Me.PB_STUDENT.Name = "PB_STUDENT"
        Me.PB_STUDENT.Size = New System.Drawing.Size(172, 180)
        Me.PB_STUDENT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_STUDENT.TabIndex = 42
        Me.PB_STUDENT.TabStop = False
        '
        'B_PRINT
        '
        Me.B_PRINT.AutoRoundedCorners = True
        Me.B_PRINT.BorderRadius = 21
        Me.B_PRINT.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.B_PRINT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.B_PRINT.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.B_PRINT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.B_PRINT.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.B_PRINT.ForeColor = System.Drawing.Color.White
        Me.B_PRINT.Location = New System.Drawing.Point(890, 165)
        Me.B_PRINT.Name = "B_PRINT"
        Me.B_PRINT.Size = New System.Drawing.Size(180, 45)
        Me.B_PRINT.TabIndex = 48
        Me.B_PRINT.Text = "Imprimer"
        '
        'B_ADD_PICTURE
        '
        Me.B_ADD_PICTURE.AutoRoundedCorners = True
        Me.B_ADD_PICTURE.BorderRadius = 21
        Me.B_ADD_PICTURE.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.B_ADD_PICTURE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.B_ADD_PICTURE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.B_ADD_PICTURE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.B_ADD_PICTURE.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.B_ADD_PICTURE.ForeColor = System.Drawing.Color.White
        Me.B_ADD_PICTURE.Location = New System.Drawing.Point(9, 201)
        Me.B_ADD_PICTURE.Name = "B_ADD_PICTURE"
        Me.B_ADD_PICTURE.Size = New System.Drawing.Size(172, 45)
        Me.B_ADD_PICTURE.TabIndex = 50
        Me.B_ADD_PICTURE.Text = "Afficher L'image"
        '
        'ServiceScolarite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(1370, 726)
        Me.Controls.Add(Me.B_ADD_PICTURE)
        Me.Controls.Add(Me.B_PRINT)
        Me.Controls.Add(Me.DTP_DATE)
        Me.Controls.Add(Me.BT_LOGOUT)
        Me.Controls.Add(Me.PB_STUDENT)
        Me.Controls.Add(Me.CB_SEMESTER)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Guna2ComboBox5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CB_INSTITUTE)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Guna2TextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TB_PHONE_NUMBER)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BT_REFRESH)
        Me.Controls.Add(Me.BT_ADD)
        Me.Controls.Add(Me.BT_UPDATE)
        Me.Controls.Add(Me.BT_DELETE)
        Me.Controls.Add(Me.CB_GENDER)
        Me.Controls.Add(Me.CB_CAREER)
        Me.Controls.Add(Me.TB_EMAIL)
        Me.Controls.Add(Me.TB_LAST_NAME)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TB_FIRST_NAME)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV_STUDENTS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ServiceScolarite"
        Me.Text = "TuitionServiceViews"
        CType(Me.DGV_STUDENTS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_STUDENT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_STUDENTS As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_FIRST_NAME As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_LAST_NAME As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TB_EMAIL As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CB_CAREER As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CB_GENDER As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BT_REFRESH As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_ADD As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_UPDATE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_DELETE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TB_PHONE_NUMBER As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2ComboBox5 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CB_INSTITUTE As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CB_SEMESTER As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents PB_STUDENT As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BT_LOGOUT As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DTP_DATE As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents B_PRINT As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents B_ADD_PICTURE As Guna.UI2.WinForms.Guna2Button
End Class
