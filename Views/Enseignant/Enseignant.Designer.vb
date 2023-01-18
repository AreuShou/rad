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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_Date = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lbl_Type = New System.Windows.Forms.Label()
        Me.Lbl_pourcent = New System.Windows.Forms.Label()
        Me.Lbl_Note = New System.Windows.Forms.Label()
        Me.CB_Ecues = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CB_Date = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CB_Note = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CB_Pourcent = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CB_Type = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TB_Etudiant = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CB_Etudiant = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GRD_View = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btn_Inserer = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_Ajour = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_Supprime = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_Recharge = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.GRD_View, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Lbl_Date
        '
        Me.Lbl_Date.AutoSize = True
        Me.Lbl_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Date.Location = New System.Drawing.Point(27, 113)
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
        Me.Lbl_Type.Location = New System.Drawing.Point(271, 116)
        Me.Lbl_Type.Name = "Lbl_Type"
        Me.Lbl_Type.Size = New System.Drawing.Size(44, 17)
        Me.Lbl_Type.TabIndex = 4
        Me.Lbl_Type.Text = "Type"
        '
        'Lbl_pourcent
        '
        Me.Lbl_pourcent.AutoSize = True
        Me.Lbl_pourcent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_pourcent.Location = New System.Drawing.Point(553, 116)
        Me.Lbl_pourcent.Name = "Lbl_pourcent"
        Me.Lbl_pourcent.Size = New System.Drawing.Size(100, 17)
        Me.Lbl_pourcent.TabIndex = 5
        Me.Lbl_pourcent.Text = "Pourcentage"
        '
        'Lbl_Note
        '
        Me.Lbl_Note.AutoSize = True
        Me.Lbl_Note.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Note.Location = New System.Drawing.Point(809, 116)
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
        Me.CB_Ecues.Size = New System.Drawing.Size(848, 36)
        Me.CB_Ecues.TabIndex = 7
        '
        'CB_Date
        '
        Me.CB_Date.BackColor = System.Drawing.Color.Transparent
        Me.CB_Date.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_Date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Date.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_Date.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_Date.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CB_Date.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_Date.ItemHeight = 30
        Me.CB_Date.Location = New System.Drawing.Point(75, 105)
        Me.CB_Date.Name = "CB_Date"
        Me.CB_Date.Size = New System.Drawing.Size(140, 36)
        Me.CB_Date.TabIndex = 8
        '
        'CB_Note
        '
        Me.CB_Note.BackColor = System.Drawing.Color.Transparent
        Me.CB_Note.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_Note.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Note.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_Note.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_Note.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CB_Note.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_Note.ItemHeight = 30
        Me.CB_Note.Location = New System.Drawing.Point(857, 105)
        Me.CB_Note.Name = "CB_Note"
        Me.CB_Note.Size = New System.Drawing.Size(66, 36)
        Me.CB_Note.TabIndex = 9
        '
        'CB_Pourcent
        '
        Me.CB_Pourcent.BackColor = System.Drawing.Color.Transparent
        Me.CB_Pourcent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_Pourcent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Pourcent.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_Pourcent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_Pourcent.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CB_Pourcent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_Pourcent.ItemHeight = 30
        Me.CB_Pourcent.Location = New System.Drawing.Point(659, 105)
        Me.CB_Pourcent.Name = "CB_Pourcent"
        Me.CB_Pourcent.Size = New System.Drawing.Size(87, 36)
        Me.CB_Pourcent.TabIndex = 10
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
        Me.CB_Type.Location = New System.Drawing.Point(321, 105)
        Me.CB_Type.Name = "CB_Type"
        Me.CB_Type.Size = New System.Drawing.Size(181, 36)
        Me.CB_Type.TabIndex = 11
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(97, 234)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(826, 36)
        Me.Guna2TextBox1.TabIndex = 12
        '
        'TB_Etudiant
        '
        Me.TB_Etudiant.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_Etudiant.DefaultText = ""
        Me.TB_Etudiant.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_Etudiant.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_Etudiant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_Etudiant.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_Etudiant.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_Etudiant.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_Etudiant.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_Etudiant.Location = New System.Drawing.Point(75, 54)
        Me.TB_Etudiant.Name = "TB_Etudiant"
        Me.TB_Etudiant.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_Etudiant.PlaceholderText = ""
        Me.TB_Etudiant.SelectedText = ""
        Me.TB_Etudiant.Size = New System.Drawing.Size(274, 36)
        Me.TB_Etudiant.TabIndex = 13
        '
        'CB_Etudiant
        '
        Me.CB_Etudiant.BackColor = System.Drawing.Color.Transparent
        Me.CB_Etudiant.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_Etudiant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Etudiant.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_Etudiant.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_Etudiant.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CB_Etudiant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_Etudiant.ItemHeight = 30
        Me.CB_Etudiant.Location = New System.Drawing.Point(399, 54)
        Me.CB_Etudiant.Name = "CB_Etudiant"
        Me.CB_Etudiant.Size = New System.Drawing.Size(524, 36)
        Me.CB_Etudiant.TabIndex = 14
        '
        'GRD_View
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.GRD_View.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GRD_View.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GRD_View.ColumnHeadersHeight = 4
        Me.GRD_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRD_View.DefaultCellStyle = DataGridViewCellStyle3
        Me.GRD_View.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GRD_View.Location = New System.Drawing.Point(-1, 276)
        Me.GRD_View.Name = "GRD_View"
        Me.GRD_View.RowHeadersVisible = False
        Me.GRD_View.Size = New System.Drawing.Size(924, 266)
        Me.GRD_View.TabIndex = 15
        Me.GRD_View.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GRD_View.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GRD_View.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GRD_View.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GRD_View.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GRD_View.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GRD_View.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GRD_View.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GRD_View.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GRD_View.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRD_View.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GRD_View.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GRD_View.ThemeStyle.HeaderStyle.Height = 4
        Me.GRD_View.ThemeStyle.ReadOnly = False
        Me.GRD_View.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GRD_View.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GRD_View.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRD_View.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GRD_View.ThemeStyle.RowsStyle.Height = 22
        Me.GRD_View.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GRD_View.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btn_Inserer
        '
        Me.btn_Inserer.AutoRoundedCorners = True
        Me.btn_Inserer.BorderRadius = 21
        Me.btn_Inserer.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Inserer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Inserer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Inserer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Inserer.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_Inserer.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Inserer.ForeColor = System.Drawing.Color.White
        Me.btn_Inserer.Location = New System.Drawing.Point(75, 173)
        Me.btn_Inserer.Name = "btn_Inserer"
        Me.btn_Inserer.Size = New System.Drawing.Size(180, 45)
        Me.btn_Inserer.TabIndex = 16
        Me.btn_Inserer.Text = "Insérer"
        '
        'btn_Ajour
        '
        Me.btn_Ajour.AutoRoundedCorners = True
        Me.btn_Ajour.BorderRadius = 21
        Me.btn_Ajour.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Ajour.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Ajour.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Ajour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Ajour.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_Ajour.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Ajour.ForeColor = System.Drawing.Color.White
        Me.btn_Ajour.Location = New System.Drawing.Point(274, 173)
        Me.btn_Ajour.Name = "btn_Ajour"
        Me.btn_Ajour.Size = New System.Drawing.Size(180, 45)
        Me.btn_Ajour.TabIndex = 20
        Me.btn_Ajour.Text = "Mise à jour"
        '
        'btn_Supprime
        '
        Me.btn_Supprime.AutoRoundedCorners = True
        Me.btn_Supprime.BorderRadius = 21
        Me.btn_Supprime.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Supprime.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Supprime.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Supprime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Supprime.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_Supprime.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Supprime.ForeColor = System.Drawing.Color.White
        Me.btn_Supprime.Location = New System.Drawing.Point(533, 173)
        Me.btn_Supprime.Name = "btn_Supprime"
        Me.btn_Supprime.Size = New System.Drawing.Size(180, 45)
        Me.btn_Supprime.TabIndex = 21
        Me.btn_Supprime.Text = "Supprimer"
        '
        'btn_Recharge
        '
        Me.btn_Recharge.AutoRoundedCorners = True
        Me.btn_Recharge.BorderRadius = 21
        Me.btn_Recharge.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Recharge.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Recharge.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Recharge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Recharge.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_Recharge.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Recharge.ForeColor = System.Drawing.Color.White
        Me.btn_Recharge.Location = New System.Drawing.Point(743, 173)
        Me.btn_Recharge.Name = "btn_Recharge"
        Me.btn_Recharge.Size = New System.Drawing.Size(180, 45)
        Me.btn_Recharge.TabIndex = 22
        Me.btn_Recharge.Text = "Recharger"
        '
        'Enseignant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(927, 544)
        Me.Controls.Add(Me.btn_Recharge)
        Me.Controls.Add(Me.btn_Supprime)
        Me.Controls.Add(Me.btn_Ajour)
        Me.Controls.Add(Me.btn_Inserer)
        Me.Controls.Add(Me.GRD_View)
        Me.Controls.Add(Me.CB_Etudiant)
        Me.Controls.Add(Me.TB_Etudiant)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.Controls.Add(Me.CB_Type)
        Me.Controls.Add(Me.CB_Pourcent)
        Me.Controls.Add(Me.CB_Note)
        Me.Controls.Add(Me.CB_Date)
        Me.Controls.Add(Me.CB_Ecues)
        Me.Controls.Add(Me.Lbl_Note)
        Me.Controls.Add(Me.Lbl_pourcent)
        Me.Controls.Add(Me.Lbl_Type)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Lbl_Date)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lbl_Etudiant)
        Me.Name = "Enseignant"
        Me.Text = "Enseignant"
        CType(Me.GRD_View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Etudiant As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Lbl_Date As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Lbl_Type As Label
    Friend WithEvents Lbl_pourcent As Label
    Friend WithEvents Lbl_Note As Label
    Friend WithEvents CB_Ecues As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CB_Date As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CB_Note As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CB_Pourcent As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CB_Type As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TB_Etudiant As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CB_Etudiant As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GRD_View As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btn_Inserer As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_Ajour As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_Supprime As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_Recharge As Guna.UI2.WinForms.Guna2Button
End Class
