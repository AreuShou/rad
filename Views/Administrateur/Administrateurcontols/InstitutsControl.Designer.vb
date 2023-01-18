<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstitutsControl
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
        Me.BTN_Supprime = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Recharge = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Ajour = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Insert = New Guna.UI2.WinForms.Guna2Button()
        Me.Box_Recherche = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GR_View = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.BX_SIGLE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BX_LIBELLE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.GR_View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_Supprime
        '
        Me.BTN_Supprime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Supprime.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Supprime.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Supprime.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Supprime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Supprime.FillColor = System.Drawing.Color.Red
        Me.BTN_Supprime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_Supprime.ForeColor = System.Drawing.Color.White
        Me.BTN_Supprime.Location = New System.Drawing.Point(633, 141)
        Me.BTN_Supprime.Name = "BTN_Supprime"
        Me.BTN_Supprime.Size = New System.Drawing.Size(180, 45)
        Me.BTN_Supprime.TabIndex = 23
        Me.BTN_Supprime.Text = "Supprimer"
        '
        'BTN_Recharge
        '
        Me.BTN_Recharge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Recharge.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Recharge.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Recharge.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Recharge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Recharge.FillColor = System.Drawing.Color.Gray
        Me.BTN_Recharge.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_Recharge.ForeColor = System.Drawing.Color.White
        Me.BTN_Recharge.Location = New System.Drawing.Point(819, 141)
        Me.BTN_Recharge.Name = "BTN_Recharge"
        Me.BTN_Recharge.Size = New System.Drawing.Size(180, 45)
        Me.BTN_Recharge.TabIndex = 22
        Me.BTN_Recharge.Text = "Recharger"
        '
        'BTN_Ajour
        '
        Me.BTN_Ajour.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Ajour.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Ajour.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Ajour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Ajour.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_Ajour.ForeColor = System.Drawing.Color.White
        Me.BTN_Ajour.Location = New System.Drawing.Point(348, 141)
        Me.BTN_Ajour.Name = "BTN_Ajour"
        Me.BTN_Ajour.Size = New System.Drawing.Size(180, 45)
        Me.BTN_Ajour.TabIndex = 21
        Me.BTN_Ajour.Text = "Mettre à Jour"
        '
        'BTN_Insert
        '
        Me.BTN_Insert.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Insert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Insert.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Insert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Insert.FillColor = System.Drawing.Color.Green
        Me.BTN_Insert.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_Insert.ForeColor = System.Drawing.Color.White
        Me.BTN_Insert.Location = New System.Drawing.Point(162, 141)
        Me.BTN_Insert.Name = "BTN_Insert"
        Me.BTN_Insert.Size = New System.Drawing.Size(180, 45)
        Me.BTN_Insert.TabIndex = 20
        Me.BTN_Insert.Text = "Insérer"
        '
        'Box_Recherche
        '
        Me.Box_Recherche.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Box_Recherche.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Box_Recherche.DefaultText = ""
        Me.Box_Recherche.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Box_Recherche.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Box_Recherche.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Box_Recherche.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Box_Recherche.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Box_Recherche.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Box_Recherche.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Box_Recherche.Location = New System.Drawing.Point(163, 204)
        Me.Box_Recherche.Name = "Box_Recherche"
        Me.Box_Recherche.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Box_Recherche.PlaceholderText = "Ex: FDS"
        Me.Box_Recherche.SelectedText = ""
        Me.Box_Recherche.Size = New System.Drawing.Size(837, 36)
        Me.Box_Recherche.TabIndex = 19
        '
        'GR_View
        '
        Me.GR_View.AllowUserToAddRows = False
        Me.GR_View.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.GR_View.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GR_View.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GR_View.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GR_View.ColumnHeadersHeight = 30
        Me.GR_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GR_View.DefaultCellStyle = DataGridViewCellStyle3
        Me.GR_View.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GR_View.Location = New System.Drawing.Point(3, 246)
        Me.GR_View.Name = "GR_View"
        Me.GR_View.RowHeadersVisible = False
        Me.GR_View.Size = New System.Drawing.Size(997, 301)
        Me.GR_View.TabIndex = 18
        Me.GR_View.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GR_View.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GR_View.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GR_View.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GR_View.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GR_View.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GR_View.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GR_View.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GR_View.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GR_View.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GR_View.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GR_View.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GR_View.ThemeStyle.HeaderStyle.Height = 30
        Me.GR_View.ThemeStyle.ReadOnly = False
        Me.GR_View.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GR_View.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GR_View.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GR_View.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GR_View.ThemeStyle.RowsStyle.Height = 22
        Me.GR_View.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GR_View.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'BX_SIGLE
        '
        Me.BX_SIGLE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BX_SIGLE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BX_SIGLE.DefaultText = ""
        Me.BX_SIGLE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.BX_SIGLE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BX_SIGLE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BX_SIGLE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BX_SIGLE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BX_SIGLE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BX_SIGLE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BX_SIGLE.Location = New System.Drawing.Point(162, 90)
        Me.BX_SIGLE.Name = "BX_SIGLE"
        Me.BX_SIGLE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BX_SIGLE.PlaceholderText = "Ex: FDS"
        Me.BX_SIGLE.SelectedText = ""
        Me.BX_SIGLE.Size = New System.Drawing.Size(837, 36)
        Me.BX_SIGLE.TabIndex = 17
        '
        'BX_LIBELLE
        '
        Me.BX_LIBELLE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BX_LIBELLE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BX_LIBELLE.DefaultText = ""
        Me.BX_LIBELLE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.BX_LIBELLE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BX_LIBELLE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BX_LIBELLE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BX_LIBELLE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BX_LIBELLE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BX_LIBELLE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BX_LIBELLE.Location = New System.Drawing.Point(162, 48)
        Me.BX_LIBELLE.Name = "BX_LIBELLE"
        Me.BX_LIBELLE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BX_LIBELLE.PlaceholderText = "Ex: Faculté Des Sciences"
        Me.BX_LIBELLE.SelectedText = ""
        Me.BX_LIBELLE.Size = New System.Drawing.Size(837, 36)
        Me.BX_LIBELLE.TabIndex = 16
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(93, 51)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(63, 33)
        Me.Guna2HtmlLabel2.TabIndex = 25
        Me.Guna2HtmlLabel2.Text = "Nom"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(3, 204)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(154, 33)
        Me.Guna2HtmlLabel3.TabIndex = 27
        Me.Guna2HtmlLabel3.Text = "Rechercher"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(88, 90)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(68, 33)
        Me.Guna2HtmlLabel1.TabIndex = 28
        Me.Guna2HtmlLabel1.Text = "Sigle"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(128, 12)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(28, 33)
        Me.Guna2HtmlLabel4.TabIndex = 30
        Me.Guna2HtmlLabel4.Text = "Id"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(162, 6)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = "Ex: FDS"
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(837, 36)
        Me.Guna2TextBox1.TabIndex = 29
        '
        'InstitutsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.BTN_Supprime)
        Me.Controls.Add(Me.BTN_Recharge)
        Me.Controls.Add(Me.BTN_Ajour)
        Me.Controls.Add(Me.BTN_Insert)
        Me.Controls.Add(Me.Box_Recherche)
        Me.Controls.Add(Me.GR_View)
        Me.Controls.Add(Me.BX_SIGLE)
        Me.Controls.Add(Me.BX_LIBELLE)
        Me.Name = "InstitutsControl"
        Me.Size = New System.Drawing.Size(1003, 550)
        CType(Me.GR_View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_Supprime As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Recharge As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Ajour As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Insert As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Box_Recherche As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GR_View As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BX_SIGLE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BX_LIBELLE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
End Class
