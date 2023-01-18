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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BT_CONNEXION = New Guna.UI2.WinForms.Guna2Button()
        Me.LBL_Login = New System.Windows.Forms.Label()
        Me.TB_PASSWORD = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TB_USERNAME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Lbl_Password = New System.Windows.Forms.Label()
        Me.Lbl_Utilisateur = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.PowderBlue
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Controls.Add(Me.Panel2)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(802, 531)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.BackgroundImage = Global.ProjetNet_RAD.My.Resources.Resources.img2
        Me.Guna2Panel2.Location = New System.Drawing.Point(12, 36)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(407, 462)
        Me.Guna2Panel2.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BT_CONNEXION)
        Me.Panel2.Controls.Add(Me.LBL_Login)
        Me.Panel2.Controls.Add(Me.TB_PASSWORD)
        Me.Panel2.Controls.Add(Me.TB_USERNAME)
        Me.Panel2.Controls.Add(Me.Lbl_Password)
        Me.Panel2.Controls.Add(Me.Lbl_Utilisateur)
        Me.Panel2.Location = New System.Drawing.Point(459, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel2.Size = New System.Drawing.Size(314, 383)
        Me.Panel2.TabIndex = 3
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
        Me.BT_CONNEXION.Location = New System.Drawing.Point(98, 290)
        Me.BT_CONNEXION.Name = "BT_CONNEXION"
        Me.BT_CONNEXION.Size = New System.Drawing.Size(108, 45)
        Me.BT_CONNEXION.TabIndex = 6
        Me.BT_CONNEXION.Text = "Valider"
        '
        'LBL_Login
        '
        Me.LBL_Login.AutoSize = True
        Me.LBL_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Login.Location = New System.Drawing.Point(61, 39)
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
        Me.TB_PASSWORD.Location = New System.Drawing.Point(51, 221)
        Me.TB_PASSWORD.Name = "TB_PASSWORD"
        Me.TB_PASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_PASSWORD.PlaceholderText = ""
        Me.TB_PASSWORD.SelectedText = ""
        Me.TB_PASSWORD.Size = New System.Drawing.Size(200, 36)
        Me.TB_PASSWORD.TabIndex = 3
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
        Me.TB_USERNAME.Location = New System.Drawing.Point(51, 123)
        Me.TB_USERNAME.Name = "TB_USERNAME"
        Me.TB_USERNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_USERNAME.PlaceholderText = ""
        Me.TB_USERNAME.SelectedText = ""
        Me.TB_USERNAME.Size = New System.Drawing.Size(200, 36)
        Me.TB_USERNAME.TabIndex = 2
        '
        'Lbl_Password
        '
        Me.Lbl_Password.AutoSize = True
        Me.Lbl_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Password.Location = New System.Drawing.Point(51, 194)
        Me.Lbl_Password.Name = "Lbl_Password"
        Me.Lbl_Password.Size = New System.Drawing.Size(106, 17)
        Me.Lbl_Password.TabIndex = 1
        Me.Lbl_Password.Text = "Mot de Passe"
        '
        'Lbl_Utilisateur
        '
        Me.Lbl_Utilisateur.AutoSize = True
        Me.Lbl_Utilisateur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Utilisateur.Location = New System.Drawing.Point(51, 98)
        Me.Lbl_Utilisateur.Name = "Lbl_Utilisateur"
        Me.Lbl_Utilisateur.Size = New System.Drawing.Size(130, 17)
        Me.Lbl_Utilisateur.TabIndex = 0
        Me.Lbl_Utilisateur.Text = "Nom d'utilisateur"
        '
        'Connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 529)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "Connexion"
        Me.Text = "Connexion"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents Panel2 As Panel
    Friend WithEvents TB_PASSWORD As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TB_USERNAME As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Lbl_Password As Label
    Friend WithEvents Lbl_Utilisateur As Label
    Friend WithEvents LBL_Login As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BT_CONNEXION As Guna.UI2.WinForms.Guna2Button
End Class
