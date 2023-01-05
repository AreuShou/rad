<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstitutesControl
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BTN_Supprime = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Recharge = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Ajour = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Insert = New Guna.UI2.WinForms.Guna2Button()
        Me.Box_Recherche = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GR_View = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.BX_IB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BX_Institute1 = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.GR_View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_Supprime
        '
        Me.BTN_Supprime.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Supprime.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Supprime.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Supprime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Supprime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_Supprime.ForeColor = System.Drawing.Color.White
        Me.BTN_Supprime.Location = New System.Drawing.Point(572, 707)
        Me.BTN_Supprime.Name = "BTN_Supprime"
        Me.BTN_Supprime.Size = New System.Drawing.Size(180, 45)
        Me.BTN_Supprime.TabIndex = 23
        Me.BTN_Supprime.Text = "Supprimer"
        '
        'BTN_Recharge
        '
        Me.BTN_Recharge.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Recharge.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Recharge.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Recharge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Recharge.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_Recharge.ForeColor = System.Drawing.Color.White
        Me.BTN_Recharge.Location = New System.Drawing.Point(243, 707)
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
        Me.BTN_Ajour.Location = New System.Drawing.Point(572, 640)
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
        Me.BTN_Insert.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_Insert.ForeColor = System.Drawing.Color.White
        Me.BTN_Insert.Location = New System.Drawing.Point(243, 640)
        Me.BTN_Insert.Name = "BTN_Insert"
        Me.BTN_Insert.Size = New System.Drawing.Size(180, 45)
        Me.BTN_Insert.TabIndex = 20
        Me.BTN_Insert.Text = "Insérer"
        '
        'Box_Recherche
        '
        Me.Box_Recherche.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Box_Recherche.DefaultText = "Institut Bllla"
        Me.Box_Recherche.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Box_Recherche.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Box_Recherche.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Box_Recherche.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Box_Recherche.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Box_Recherche.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Box_Recherche.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Box_Recherche.Location = New System.Drawing.Point(64, 97)
        Me.Box_Recherche.Name = "Box_Recherche"
        Me.Box_Recherche.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Box_Recherche.PlaceholderText = ""
        Me.Box_Recherche.SelectedText = ""
        Me.Box_Recherche.Size = New System.Drawing.Size(850, 36)
        Me.Box_Recherche.TabIndex = 19
        '
        'GR_View
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.GR_View.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GR_View.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.GR_View.ColumnHeadersHeight = 4
        Me.GR_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GR_View.DefaultCellStyle = DataGridViewCellStyle9
        Me.GR_View.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GR_View.Location = New System.Drawing.Point(64, 139)
        Me.GR_View.Name = "GR_View"
        Me.GR_View.RowHeadersVisible = False
        Me.GR_View.Size = New System.Drawing.Size(850, 474)
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
        Me.GR_View.ThemeStyle.HeaderStyle.Height = 4
        Me.GR_View.ThemeStyle.ReadOnly = False
        Me.GR_View.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GR_View.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GR_View.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GR_View.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GR_View.ThemeStyle.RowsStyle.Height = 22
        Me.GR_View.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GR_View.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'BX_IB
        '
        Me.BX_IB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BX_IB.DefaultText = "IB"
        Me.BX_IB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.BX_IB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BX_IB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BX_IB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BX_IB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BX_IB.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BX_IB.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BX_IB.Location = New System.Drawing.Point(647, 28)
        Me.BX_IB.Name = "BX_IB"
        Me.BX_IB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BX_IB.PlaceholderText = ""
        Me.BX_IB.SelectedText = ""
        Me.BX_IB.Size = New System.Drawing.Size(267, 36)
        Me.BX_IB.TabIndex = 17
        '
        'BX_Institute1
        '
        Me.BX_Institute1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BX_Institute1.DefaultText = "Institut Bllla"
        Me.BX_Institute1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.BX_Institute1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BX_Institute1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BX_Institute1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BX_Institute1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BX_Institute1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BX_Institute1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BX_Institute1.Location = New System.Drawing.Point(64, 28)
        Me.BX_Institute1.Name = "BX_Institute1"
        Me.BX_Institute1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BX_Institute1.PlaceholderText = ""
        Me.BX_Institute1.SelectedText = ""
        Me.BX_Institute1.Size = New System.Drawing.Size(266, 36)
        Me.BX_Institute1.TabIndex = 16
        '
        'InstitutesControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BTN_Supprime)
        Me.Controls.Add(Me.BTN_Recharge)
        Me.Controls.Add(Me.BTN_Ajour)
        Me.Controls.Add(Me.BTN_Insert)
        Me.Controls.Add(Me.Box_Recherche)
        Me.Controls.Add(Me.GR_View)
        Me.Controls.Add(Me.BX_IB)
        Me.Controls.Add(Me.BX_Institute1)
        Me.Name = "InstitutesControl"
        Me.Size = New System.Drawing.Size(979, 781)
        CType(Me.GR_View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTN_Supprime As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Recharge As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Ajour As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Insert As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Box_Recherche As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GR_View As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BX_IB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BX_Institute1 As Guna.UI2.WinForms.Guna2TextBox
End Class
