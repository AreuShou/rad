<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Connexion
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CTS_DISPLAY_PASSWORD = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.BT_CONNEXION = New Guna.UI2.WinForms.Guna2Button()
        Me.LBL_Login = New System.Windows.Forms.Label()
        Me.TB_PASSWORD = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TB_USERNAME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Lbl_Password = New System.Windows.Forms.Label()
        Me.Lbl_Utilisateur = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.CTS_DISPLAY_PASSWORD)
        Me.Panel2.Controls.Add(Me.BT_CONNEXION)
        Me.Panel2.Controls.Add(Me.LBL_Login)
        Me.Panel2.Controls.Add(Me.TB_PASSWORD)
        Me.Panel2.Controls.Add(Me.TB_USERNAME)
        Me.Panel2.Controls.Add(Me.Lbl_Password)
        Me.Panel2.Controls.Add(Me.Lbl_Utilisateur)
        Me.Panel2.Location = New System.Drawing.Point(425, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel2.Size = New System.Drawing.Size(339, 462)
        Me.Panel2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(113, 297)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Cacher "
        '
        'CTS_DISPLAY_PASSWORD
        '
        Me.CTS_DISPLAY_PASSWORD.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CTS_DISPLAY_PASSWORD.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CTS_DISPLAY_PASSWORD.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.CTS_DISPLAY_PASSWORD.CheckedState.InnerColor = System.Drawing.Color.White
        Me.CTS_DISPLAY_PASSWORD.Location = New System.Drawing.Point(77, 297)
        Me.CTS_DISPLAY_PASSWORD.Name = "CTS_DISPLAY_PASSWORD"
        Me.CTS_DISPLAY_PASSWORD.Size = New System.Drawing.Size(35, 20)
        Me.CTS_DISPLAY_PASSWORD.TabIndex = 7
        Me.CTS_DISPLAY_PASSWORD.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CTS_DISPLAY_PASSWORD.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CTS_DISPLAY_PASSWORD.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.CTS_DISPLAY_PASSWORD.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'BT_CONNEXION
        '
        Me.BT_CONNEXION.AutoRoundedCorners = True
        Me.BT_CONNEXION.BorderRadius = 21
        Me.BT_CONNEXION.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_CONNEXION.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_CONNEXION.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_CONNEXION.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_CONNEXION.FillColor = System.Drawing.Color.Black
        Me.BT_CONNEXION.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BT_CONNEXION.ForeColor = System.Drawing.Color.White
        Me.BT_CONNEXION.Location = New System.Drawing.Point(123, 369)
        Me.BT_CONNEXION.Name = "BT_CONNEXION"
        Me.BT_CONNEXION.Size = New System.Drawing.Size(108, 45)
        Me.BT_CONNEXION.TabIndex = 6
        Me.BT_CONNEXION.Text = "Valider"
        '
        'LBL_Login
        '
        Me.LBL_Login.AutoSize = True
        Me.LBL_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Login.Location = New System.Drawing.Point(81, 52)
        Me.LBL_Login.Name = "LBL_Login"
        Me.LBL_Login.Size = New System.Drawing.Size(171, 20)
        Me.LBL_Login.TabIndex = 5
        Me.LBL_Login.Text = "CONNECTEZ-VOUS"
        '
        'TB_PASSWORD
        '
        Me.TB_PASSWORD.AutoRoundedCorners = True
        Me.TB_PASSWORD.BorderRadius = 17
        Me.TB_PASSWORD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_PASSWORD.DefaultText = ""
        Me.TB_PASSWORD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_PASSWORD.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_PASSWORD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_PASSWORD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_PASSWORD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_PASSWORD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_PASSWORD.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_PASSWORD.Location = New System.Drawing.Point(71, 234)
        Me.TB_PASSWORD.Name = "TB_PASSWORD"
        Me.TB_PASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_PASSWORD.PlaceholderText = "PASSWORD"
        Me.TB_PASSWORD.SelectedText = ""
        Me.TB_PASSWORD.Size = New System.Drawing.Size(200, 36)
        Me.TB_PASSWORD.TabIndex = 3
        Me.TB_PASSWORD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TB_USERNAME
        '
        Me.TB_USERNAME.AutoRoundedCorners = True
        Me.TB_USERNAME.BorderRadius = 17
        Me.TB_USERNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_USERNAME.DefaultText = ""
        Me.TB_USERNAME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_USERNAME.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_USERNAME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_USERNAME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_USERNAME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_USERNAME.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_USERNAME.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_USERNAME.Location = New System.Drawing.Point(71, 136)
        Me.TB_USERNAME.Name = "TB_USERNAME"
        Me.TB_USERNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_USERNAME.PlaceholderText = "USERNAME"
        Me.TB_USERNAME.SelectedText = ""
        Me.TB_USERNAME.Size = New System.Drawing.Size(200, 36)
        Me.TB_USERNAME.TabIndex = 2
        Me.TB_USERNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lbl_Password
        '
        Me.Lbl_Password.AutoSize = True
        Me.Lbl_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Password.Location = New System.Drawing.Point(71, 207)
        Me.Lbl_Password.Name = "Lbl_Password"
        Me.Lbl_Password.Size = New System.Drawing.Size(106, 17)
        Me.Lbl_Password.TabIndex = 1
        Me.Lbl_Password.Text = "Mot de Passe"
        '
        'Lbl_Utilisateur
        '
        Me.Lbl_Utilisateur.AutoSize = True
        Me.Lbl_Utilisateur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Utilisateur.Location = New System.Drawing.Point(71, 111)
        Me.Lbl_Utilisateur.Name = "Lbl_Utilisateur"
        Me.Lbl_Utilisateur.Size = New System.Drawing.Size(130, 17)
        Me.Lbl_Utilisateur.TabIndex = 0
        Me.Lbl_Utilisateur.Text = "Nom d'utilisateur"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BackColor = System.Drawing.Color.PowderBlue
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Controls.Add(Me.Panel2)
        Me.Guna2Panel1.Location = New System.Drawing.Point(-1, 2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(799, 528)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.BackgroundImage = Global.ProjetNet_RAD.My.Resources.Resources.img2
        Me.Guna2Panel2.Location = New System.Drawing.Point(12, 36)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(380, 462)
        Me.Guna2Panel2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(305, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "BIENVENUE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 529)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "Connexion"
        Me.Text = "Connexion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents Panel2 As Panel
    Friend WithEvents BT_CONNEXION As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LBL_Login As Label
    Friend WithEvents TB_PASSWORD As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TB_USERNAME As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Lbl_Password As Label
    Friend WithEvents Lbl_Utilisateur As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CTS_DISPLAY_PASSWORD As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents Label2 As Label
End Class
