<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UEsControl
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Id_Label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Id_TextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Faculty_Lbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Faculty_Box = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Search_Lbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Nom_Label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BT_DELETE = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_REFRESH = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_UPDATE = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_ADD = New Guna.UI2.WinForms.Guna2Button()
        Me.TB_SEARCH = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DGV_UES = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TB_LIBELLE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CB_SEMESTER = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CLB_CAREERS = New System.Windows.Forms.CheckedListBox()
        Me.CB_INSTITUTE = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(Me.DGV_UES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_Label
        '
        Me.Id_Label.BackColor = System.Drawing.Color.Transparent
        Me.Id_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_Label.Location = New System.Drawing.Point(130, 13)
        Me.Id_Label.Name = "Id_Label"
        Me.Id_Label.Size = New System.Drawing.Size(28, 33)
        Me.Id_Label.TabIndex = 57
        Me.Id_Label.Text = "Id"
        '
        'Id_TextBox
        '
        Me.Id_TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Id_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Id_TextBox.DefaultText = ""
        Me.Id_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Id_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Id_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Id_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Id_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Id_TextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Id_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Id_TextBox.Location = New System.Drawing.Point(164, 13)
        Me.Id_TextBox.Name = "Id_TextBox"
        Me.Id_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Id_TextBox.PlaceholderText = ""
        Me.Id_TextBox.SelectedText = ""
        Me.Id_TextBox.Size = New System.Drawing.Size(379, 36)
        Me.Id_TextBox.TabIndex = 56
        '
        'Faculty_Lbl
        '
        Me.Faculty_Lbl.BackColor = System.Drawing.Color.Transparent
        Me.Faculty_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Faculty_Lbl.Location = New System.Drawing.Point(18, 170)
        Me.Faculty_Lbl.Name = "Faculty_Lbl"
        Me.Faculty_Lbl.Size = New System.Drawing.Size(140, 33)
        Me.Faculty_Lbl.TabIndex = 55
        Me.Faculty_Lbl.Text = "Faculty_Id"
        '
        'Faculty_Box
        '
        Me.Faculty_Box.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Faculty_Box.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Faculty_Box.DefaultText = ""
        Me.Faculty_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Faculty_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Faculty_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Faculty_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Faculty_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Faculty_Box.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Faculty_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Faculty_Box.Location = New System.Drawing.Point(164, 170)
        Me.Faculty_Box.Name = "Faculty_Box"
        Me.Faculty_Box.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Faculty_Box.PlaceholderText = ""
        Me.Faculty_Box.SelectedText = ""
        Me.Faculty_Box.Size = New System.Drawing.Size(379, 36)
        Me.Faculty_Box.TabIndex = 54
        '
        'Search_Lbl
        '
        Me.Search_Lbl.BackColor = System.Drawing.Color.Transparent
        Me.Search_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_Lbl.Location = New System.Drawing.Point(1, 285)
        Me.Search_Lbl.Name = "Search_Lbl"
        Me.Search_Lbl.Size = New System.Drawing.Size(154, 33)
        Me.Search_Lbl.TabIndex = 53
        Me.Search_Lbl.Text = "Rechercher"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(31, 120)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(127, 33)
        Me.Guna2HtmlLabel1.TabIndex = 52
        Me.Guna2HtmlLabel1.Text = "Semestre"
        '
        'Nom_Label
        '
        Me.Nom_Label.BackColor = System.Drawing.Color.Transparent
        Me.Nom_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom_Label.Location = New System.Drawing.Point(95, 69)
        Me.Nom_Label.Name = "Nom_Label"
        Me.Nom_Label.Size = New System.Drawing.Size(63, 33)
        Me.Nom_Label.TabIndex = 51
        Me.Nom_Label.Text = "Nom"
        '
        'BT_DELETE
        '
        Me.BT_DELETE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_DELETE.AutoRoundedCorners = True
        Me.BT_DELETE.BorderRadius = 21
        Me.BT_DELETE.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_DELETE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_DELETE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_DELETE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_DELETE.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.BT_DELETE.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BT_DELETE.ForeColor = System.Drawing.Color.White
        Me.BT_DELETE.Location = New System.Drawing.Point(619, 108)
        Me.BT_DELETE.Name = "BT_DELETE"
        Me.BT_DELETE.Size = New System.Drawing.Size(180, 45)
        Me.BT_DELETE.TabIndex = 50
        Me.BT_DELETE.Text = "Supprimer"
        '
        'BT_REFRESH
        '
        Me.BT_REFRESH.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_REFRESH.AutoRoundedCorners = True
        Me.BT_REFRESH.BorderRadius = 21
        Me.BT_REFRESH.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_REFRESH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_REFRESH.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_REFRESH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_REFRESH.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.BT_REFRESH.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BT_REFRESH.ForeColor = System.Drawing.Color.White
        Me.BT_REFRESH.Location = New System.Drawing.Point(818, 108)
        Me.BT_REFRESH.Name = "BT_REFRESH"
        Me.BT_REFRESH.Size = New System.Drawing.Size(180, 45)
        Me.BT_REFRESH.TabIndex = 49
        Me.BT_REFRESH.Text = "Recharger"
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
        Me.BT_UPDATE.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BT_UPDATE.ForeColor = System.Drawing.Color.White
        Me.BT_UPDATE.Location = New System.Drawing.Point(823, 24)
        Me.BT_UPDATE.Name = "BT_UPDATE"
        Me.BT_UPDATE.Size = New System.Drawing.Size(180, 45)
        Me.BT_UPDATE.TabIndex = 48
        Me.BT_UPDATE.Text = "Mettre à Jour"
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
        Me.BT_ADD.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BT_ADD.ForeColor = System.Drawing.Color.White
        Me.BT_ADD.Location = New System.Drawing.Point(619, 24)
        Me.BT_ADD.Name = "BT_ADD"
        Me.BT_ADD.Size = New System.Drawing.Size(180, 45)
        Me.BT_ADD.TabIndex = 47
        Me.BT_ADD.Text = "Insérer"
        '
        'TB_SEARCH
        '
        Me.TB_SEARCH.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_SEARCH.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_SEARCH.DefaultText = ""
        Me.TB_SEARCH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_SEARCH.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_SEARCH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_SEARCH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_SEARCH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_SEARCH.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_SEARCH.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_SEARCH.Location = New System.Drawing.Point(161, 285)
        Me.TB_SEARCH.Name = "TB_SEARCH"
        Me.TB_SEARCH.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_SEARCH.PlaceholderText = ""
        Me.TB_SEARCH.SelectedText = ""
        Me.TB_SEARCH.Size = New System.Drawing.Size(837, 36)
        Me.TB_SEARCH.TabIndex = 46
        '
        'DGV_UES
        '
        Me.DGV_UES.AllowUserToAddRows = False
        Me.DGV_UES.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.DGV_UES.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_UES.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_UES.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_UES.ColumnHeadersHeight = 30
        Me.DGV_UES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_UES.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_UES.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_UES.Location = New System.Drawing.Point(1, 338)
        Me.DGV_UES.Name = "DGV_UES"
        Me.DGV_UES.RowHeadersVisible = False
        Me.DGV_UES.Size = New System.Drawing.Size(997, 323)
        Me.DGV_UES.TabIndex = 45
        Me.DGV_UES.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_UES.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGV_UES.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGV_UES.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGV_UES.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGV_UES.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_UES.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_UES.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_UES.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_UES.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_UES.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_UES.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_UES.ThemeStyle.HeaderStyle.Height = 30
        Me.DGV_UES.ThemeStyle.ReadOnly = False
        Me.DGV_UES.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_UES.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_UES.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_UES.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_UES.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_UES.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_UES.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'TB_LIBELLE
        '
        Me.TB_LIBELLE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_LIBELLE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_LIBELLE.DefaultText = ""
        Me.TB_LIBELLE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_LIBELLE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_LIBELLE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_LIBELLE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_LIBELLE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_LIBELLE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_LIBELLE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_LIBELLE.Location = New System.Drawing.Point(164, 66)
        Me.TB_LIBELLE.Name = "TB_LIBELLE"
        Me.TB_LIBELLE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_LIBELLE.PlaceholderText = ""
        Me.TB_LIBELLE.SelectedText = ""
        Me.TB_LIBELLE.Size = New System.Drawing.Size(379, 36)
        Me.TB_LIBELLE.TabIndex = 43
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
        Me.CB_SEMESTER.Location = New System.Drawing.Point(164, 117)
        Me.CB_SEMESTER.Name = "CB_SEMESTER"
        Me.CB_SEMESTER.Size = New System.Drawing.Size(379, 36)
        Me.CB_SEMESTER.TabIndex = 58
        '
        'CLB_CAREERS
        '
        Me.CLB_CAREERS.FormattingEnabled = True
        Me.CLB_CAREERS.Location = New System.Drawing.Point(662, 170)
        Me.CLB_CAREERS.Name = "CLB_CAREERS"
        Me.CLB_CAREERS.Size = New System.Drawing.Size(120, 94)
        Me.CLB_CAREERS.TabIndex = 59
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
        Me.CB_INSTITUTE.Location = New System.Drawing.Point(164, 228)
        Me.CB_INSTITUTE.Name = "CB_INSTITUTE"
        Me.CB_INSTITUTE.Size = New System.Drawing.Size(379, 36)
        Me.CB_INSTITUTE.TabIndex = 61
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(65, 228)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(93, 33)
        Me.Guna2HtmlLabel2.TabIndex = 60
        Me.Guna2HtmlLabel2.Text = "Institut"
        '
        'UEsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.CB_INSTITUTE)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.CLB_CAREERS)
        Me.Controls.Add(Me.CB_SEMESTER)
        Me.Controls.Add(Me.Id_Label)
        Me.Controls.Add(Me.Id_TextBox)
        Me.Controls.Add(Me.Faculty_Lbl)
        Me.Controls.Add(Me.Faculty_Box)
        Me.Controls.Add(Me.Search_Lbl)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Nom_Label)
        Me.Controls.Add(Me.BT_DELETE)
        Me.Controls.Add(Me.BT_REFRESH)
        Me.Controls.Add(Me.BT_UPDATE)
        Me.Controls.Add(Me.BT_ADD)
        Me.Controls.Add(Me.TB_SEARCH)
        Me.Controls.Add(Me.DGV_UES)
        Me.Controls.Add(Me.TB_LIBELLE)
        Me.Name = "UEsControl"
        Me.Size = New System.Drawing.Size(1003, 661)
        CType(Me.DGV_UES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Id_Label As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Id_TextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Faculty_Lbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Faculty_Box As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Search_Lbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Nom_Label As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BT_DELETE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_REFRESH As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_UPDATE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_ADD As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TB_SEARCH As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DGV_UES As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TB_LIBELLE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CB_SEMESTER As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CLB_CAREERS As CheckedListBox
    Friend WithEvents CB_INSTITUTE As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
