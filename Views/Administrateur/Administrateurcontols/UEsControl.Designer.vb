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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Id_Label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Id_TextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Faculty_Lbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Faculty_Box = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Search_Lbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Nom_Label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BTN_Supprime = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Recharge = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Ajour = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Insert = New Guna.UI2.WinForms.Guna2Button()
        Me.BX_Recherche = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Ues_View = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Nom_TextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CB_Semestre = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CLB_UEs = New System.Windows.Forms.CheckedListBox()
        Me.CB_INSTITUTE = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(Me.Ues_View, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'BTN_Supprime
        '
        Me.BTN_Supprime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Supprime.AutoRoundedCorners = True
        Me.BTN_Supprime.BorderRadius = 21
        Me.BTN_Supprime.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Supprime.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Supprime.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Supprime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Supprime.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.BTN_Supprime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_Supprime.ForeColor = System.Drawing.Color.White
        Me.BTN_Supprime.Location = New System.Drawing.Point(619, 108)
        Me.BTN_Supprime.Name = "BTN_Supprime"
        Me.BTN_Supprime.Size = New System.Drawing.Size(180, 45)
        Me.BTN_Supprime.TabIndex = 50
        Me.BTN_Supprime.Text = "Supprimer"
        '
        'BTN_Recharge
        '
        Me.BTN_Recharge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Recharge.AutoRoundedCorners = True
        Me.BTN_Recharge.BorderRadius = 21
        Me.BTN_Recharge.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Recharge.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Recharge.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Recharge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Recharge.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.BTN_Recharge.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_Recharge.ForeColor = System.Drawing.Color.White
        Me.BTN_Recharge.Location = New System.Drawing.Point(818, 108)
        Me.BTN_Recharge.Name = "BTN_Recharge"
        Me.BTN_Recharge.Size = New System.Drawing.Size(180, 45)
        Me.BTN_Recharge.TabIndex = 49
        Me.BTN_Recharge.Text = "Recharger"
        '
        'BTN_Ajour
        '
        Me.BTN_Ajour.AutoRoundedCorners = True
        Me.BTN_Ajour.BorderRadius = 21
        Me.BTN_Ajour.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Ajour.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Ajour.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Ajour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Ajour.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.BTN_Ajour.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_Ajour.ForeColor = System.Drawing.Color.White
        Me.BTN_Ajour.Location = New System.Drawing.Point(823, 24)
        Me.BTN_Ajour.Name = "BTN_Ajour"
        Me.BTN_Ajour.Size = New System.Drawing.Size(180, 45)
        Me.BTN_Ajour.TabIndex = 48
        Me.BTN_Ajour.Text = "Mettre à Jour"
        '
        'BTN_Insert
        '
        Me.BTN_Insert.AutoRoundedCorners = True
        Me.BTN_Insert.BorderRadius = 21
        Me.BTN_Insert.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Insert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Insert.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Insert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Insert.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.BTN_Insert.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_Insert.ForeColor = System.Drawing.Color.White
        Me.BTN_Insert.Location = New System.Drawing.Point(619, 24)
        Me.BTN_Insert.Name = "BTN_Insert"
        Me.BTN_Insert.Size = New System.Drawing.Size(180, 45)
        Me.BTN_Insert.TabIndex = 47
        Me.BTN_Insert.Text = "Insérer"
        '
        'BX_Recherche
        '
        Me.BX_Recherche.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BX_Recherche.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BX_Recherche.DefaultText = ""
        Me.BX_Recherche.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.BX_Recherche.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BX_Recherche.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BX_Recherche.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BX_Recherche.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BX_Recherche.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BX_Recherche.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BX_Recherche.Location = New System.Drawing.Point(161, 285)
        Me.BX_Recherche.Name = "BX_Recherche"
        Me.BX_Recherche.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BX_Recherche.PlaceholderText = ""
        Me.BX_Recherche.SelectedText = ""
        Me.BX_Recherche.Size = New System.Drawing.Size(837, 36)
        Me.BX_Recherche.TabIndex = 46
        '
        'Ues_View
        '
        Me.Ues_View.AllowUserToAddRows = False
        Me.Ues_View.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Ues_View.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Ues_View.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Ues_View.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Ues_View.ColumnHeadersHeight = 30
        Me.Ues_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Ues_View.DefaultCellStyle = DataGridViewCellStyle3
        Me.Ues_View.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Ues_View.Location = New System.Drawing.Point(1, 338)
        Me.Ues_View.Name = "Ues_View"
        Me.Ues_View.RowHeadersVisible = False
        Me.Ues_View.Size = New System.Drawing.Size(997, 323)
        Me.Ues_View.TabIndex = 45
        Me.Ues_View.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Ues_View.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Ues_View.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Ues_View.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Ues_View.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Ues_View.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Ues_View.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Ues_View.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Ues_View.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Ues_View.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ues_View.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Ues_View.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Ues_View.ThemeStyle.HeaderStyle.Height = 30
        Me.Ues_View.ThemeStyle.ReadOnly = False
        Me.Ues_View.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Ues_View.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Ues_View.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ues_View.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Ues_View.ThemeStyle.RowsStyle.Height = 22
        Me.Ues_View.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Ues_View.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Nom_TextBox
        '
        Me.Nom_TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Nom_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Nom_TextBox.DefaultText = ""
        Me.Nom_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Nom_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Nom_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Nom_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Nom_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Nom_TextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Nom_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Nom_TextBox.Location = New System.Drawing.Point(164, 66)
        Me.Nom_TextBox.Name = "Nom_TextBox"
        Me.Nom_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Nom_TextBox.PlaceholderText = ""
        Me.Nom_TextBox.SelectedText = ""
        Me.Nom_TextBox.Size = New System.Drawing.Size(379, 36)
        Me.Nom_TextBox.TabIndex = 43
        '
        'CB_Semestre
        '
        Me.CB_Semestre.BackColor = System.Drawing.Color.Transparent
        Me.CB_Semestre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_Semestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Semestre.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_Semestre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_Semestre.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CB_Semestre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_Semestre.ItemHeight = 30
        Me.CB_Semestre.Location = New System.Drawing.Point(164, 117)
        Me.CB_Semestre.Name = "CB_Semestre"
        Me.CB_Semestre.Size = New System.Drawing.Size(379, 36)
        Me.CB_Semestre.TabIndex = 58
        '
        'CLB_UEs
        '
        Me.CLB_UEs.FormattingEnabled = True
        Me.CLB_UEs.Location = New System.Drawing.Point(662, 170)
        Me.CLB_UEs.Name = "CLB_UEs"
        Me.CLB_UEs.Size = New System.Drawing.Size(120, 94)
        Me.CLB_UEs.TabIndex = 59
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
        Me.Controls.Add(Me.CB_INSTITUTE)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.CLB_UEs)
        Me.Controls.Add(Me.CB_Semestre)
        Me.Controls.Add(Me.Id_Label)
        Me.Controls.Add(Me.Id_TextBox)
        Me.Controls.Add(Me.Faculty_Lbl)
        Me.Controls.Add(Me.Faculty_Box)
        Me.Controls.Add(Me.Search_Lbl)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Nom_Label)
        Me.Controls.Add(Me.BTN_Supprime)
        Me.Controls.Add(Me.BTN_Recharge)
        Me.Controls.Add(Me.BTN_Ajour)
        Me.Controls.Add(Me.BTN_Insert)
        Me.Controls.Add(Me.BX_Recherche)
        Me.Controls.Add(Me.Ues_View)
        Me.Controls.Add(Me.Nom_TextBox)
        Me.Name = "UEsControl"
        Me.Size = New System.Drawing.Size(1003, 661)
        CType(Me.Ues_View, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BTN_Supprime As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Recharge As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Ajour As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Insert As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BX_Recherche As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Ues_View As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Nom_TextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CB_Semestre As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CLB_UEs As CheckedListBox
    Friend WithEvents CB_INSTITUTE As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
