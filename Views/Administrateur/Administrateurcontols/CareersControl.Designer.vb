<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CareersControl
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
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TB_LIBELLE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BT_DELETE = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_REFRESH = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_UPDATE = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_ADD = New Guna.UI2.WinForms.Guna2Button()
        Me.TB_SEARCH = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DGV_CAREERS = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TB_SIGLE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CB_INSTITUTE = New Guna.UI2.WinForms.Guna2ComboBox()
        CType(Me.DGV_CAREERS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(24, 16)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(88, 33)
        Me.Guna2HtmlLabel4.TabIndex = 43
        Me.Guna2HtmlLabel4.Text = "Libellé"
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
        Me.TB_LIBELLE.Location = New System.Drawing.Point(118, 13)
        Me.TB_LIBELLE.Name = "TB_LIBELLE"
        Me.TB_LIBELLE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_LIBELLE.PlaceholderText = ""
        Me.TB_LIBELLE.SelectedText = ""
        Me.TB_LIBELLE.Size = New System.Drawing.Size(904, 36)
        Me.TB_LIBELLE.TabIndex = 42
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(44, 58)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(68, 33)
        Me.Guna2HtmlLabel1.TabIndex = 41
        Me.Guna2HtmlLabel1.Text = "Sigle"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(4, 211)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(154, 33)
        Me.Guna2HtmlLabel3.TabIndex = 40
        Me.Guna2HtmlLabel3.Text = "Rechercher"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(4, 97)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(108, 33)
        Me.Guna2HtmlLabel2.TabIndex = 39
        Me.Guna2HtmlLabel2.Text = "Instituts"
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
        Me.BT_DELETE.Location = New System.Drawing.Point(656, 148)
        Me.BT_DELETE.Name = "BT_DELETE"
        Me.BT_DELETE.Size = New System.Drawing.Size(180, 45)
        Me.BT_DELETE.TabIndex = 38
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
        Me.BT_REFRESH.Location = New System.Drawing.Point(842, 148)
        Me.BT_REFRESH.Name = "BT_REFRESH"
        Me.BT_REFRESH.Size = New System.Drawing.Size(180, 45)
        Me.BT_REFRESH.TabIndex = 37
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
        Me.BT_UPDATE.Location = New System.Drawing.Point(304, 148)
        Me.BT_UPDATE.Name = "BT_UPDATE"
        Me.BT_UPDATE.Size = New System.Drawing.Size(180, 45)
        Me.BT_UPDATE.TabIndex = 36
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
        Me.BT_ADD.Location = New System.Drawing.Point(118, 148)
        Me.BT_ADD.Name = "BT_ADD"
        Me.BT_ADD.Size = New System.Drawing.Size(180, 45)
        Me.BT_ADD.TabIndex = 35
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
        Me.TB_SEARCH.Location = New System.Drawing.Point(164, 211)
        Me.TB_SEARCH.Name = "TB_SEARCH"
        Me.TB_SEARCH.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_SEARCH.PlaceholderText = ""
        Me.TB_SEARCH.SelectedText = ""
        Me.TB_SEARCH.Size = New System.Drawing.Size(861, 36)
        Me.TB_SEARCH.TabIndex = 34
        '
        'DGV_CAREERS
        '
        Me.DGV_CAREERS.AllowUserToAddRows = False
        Me.DGV_CAREERS.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGV_CAREERS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_CAREERS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_CAREERS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_CAREERS.ColumnHeadersHeight = 30
        Me.DGV_CAREERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_CAREERS.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_CAREERS.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_CAREERS.Location = New System.Drawing.Point(0, 250)
        Me.DGV_CAREERS.Name = "DGV_CAREERS"
        Me.DGV_CAREERS.RowHeadersVisible = False
        Me.DGV_CAREERS.Size = New System.Drawing.Size(1022, 320)
        Me.DGV_CAREERS.TabIndex = 33
        Me.DGV_CAREERS.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_CAREERS.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGV_CAREERS.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGV_CAREERS.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGV_CAREERS.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGV_CAREERS.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_CAREERS.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_CAREERS.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_CAREERS.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_CAREERS.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_CAREERS.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_CAREERS.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_CAREERS.ThemeStyle.HeaderStyle.Height = 30
        Me.DGV_CAREERS.ThemeStyle.ReadOnly = False
        Me.DGV_CAREERS.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_CAREERS.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_CAREERS.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_CAREERS.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_CAREERS.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_CAREERS.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_CAREERS.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'TB_SIGLE
        '
        Me.TB_SIGLE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_SIGLE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_SIGLE.DefaultText = ""
        Me.TB_SIGLE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_SIGLE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_SIGLE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_SIGLE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_SIGLE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_SIGLE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_SIGLE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_SIGLE.Location = New System.Drawing.Point(118, 55)
        Me.TB_SIGLE.Name = "TB_SIGLE"
        Me.TB_SIGLE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_SIGLE.PlaceholderText = ""
        Me.TB_SIGLE.SelectedText = ""
        Me.TB_SIGLE.Size = New System.Drawing.Size(904, 36)
        Me.TB_SIGLE.TabIndex = 31
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
        Me.CB_INSTITUTE.Location = New System.Drawing.Point(118, 97)
        Me.CB_INSTITUTE.Name = "CB_INSTITUTE"
        Me.CB_INSTITUTE.Size = New System.Drawing.Size(904, 36)
        Me.CB_INSTITUTE.TabIndex = 44
        '
        'CareersControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.CB_INSTITUTE)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.TB_LIBELLE)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.BT_DELETE)
        Me.Controls.Add(Me.BT_REFRESH)
        Me.Controls.Add(Me.BT_UPDATE)
        Me.Controls.Add(Me.BT_ADD)
        Me.Controls.Add(Me.TB_SEARCH)
        Me.Controls.Add(Me.DGV_CAREERS)
        Me.Controls.Add(Me.TB_SIGLE)
        Me.Name = "CareersControl"
        Me.Size = New System.Drawing.Size(1025, 573)
        CType(Me.DGV_CAREERS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TB_LIBELLE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BT_DELETE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_REFRESH As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_UPDATE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_ADD As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TB_SEARCH As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DGV_CAREERS As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TB_SIGLE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CB_INSTITUTE As Guna.UI2.WinForms.Guna2ComboBox
End Class
