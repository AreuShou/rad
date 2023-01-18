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
        Me.LBL_Login = New System.Windows.Forms.Label()
        Me.TextBx_Valide = New Guna.UI2.WinForms.Guna2TextBox()
        Me.passe = New Guna.UI2.WinForms.Guna2TextBox()
        Me.nom = New Guna.UI2.WinForms.Guna2TextBox()
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
        Me.Panel2.Controls.Add(Me.LBL_Login)
        Me.Panel2.Controls.Add(Me.TextBx_Valide)
        Me.Panel2.Controls.Add(Me.passe)
        Me.Panel2.Controls.Add(Me.nom)
        Me.Panel2.Controls.Add(Me.Lbl_Password)
        Me.Panel2.Controls.Add(Me.Lbl_Utilisateur)
        Me.Panel2.Location = New System.Drawing.Point(459, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel2.Size = New System.Drawing.Size(314, 383)
        Me.Panel2.TabIndex = 3
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
        'TextBx_Valide
        '
        Me.TextBx_Valide.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBx_Valide.AutoRoundedCorners = True
        Me.TextBx_Valide.BorderRadius = 19
        Me.TextBx_Valide.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBx_Valide.DefaultText = "VALIDER"
        Me.TextBx_Valide.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBx_Valide.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBx_Valide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBx_Valide.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBx_Valide.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBx_Valide.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TextBx_Valide.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBx_Valide.Location = New System.Drawing.Point(107, 309)
        Me.TextBx_Valide.Name = "TextBx_Valide"
        Me.TextBx_Valide.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBx_Valide.PlaceholderText = ""
        Me.TextBx_Valide.SelectedText = ""
        Me.TextBx_Valide.Size = New System.Drawing.Size(72, 41)
        Me.TextBx_Valide.TabIndex = 4
        '
        'passe
        '
        Me.passe.AutoRoundedCorners = True
        Me.passe.BorderRadius = 17
        Me.passe.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passe.DefaultText = ""
        Me.passe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.passe.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.passe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.passe.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passe.Location = New System.Drawing.Point(51, 221)
        Me.passe.Name = "passe"
        Me.passe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.passe.PlaceholderText = ""
        Me.passe.SelectedText = ""
        Me.passe.Size = New System.Drawing.Size(200, 36)
        Me.passe.TabIndex = 3
        '
        'nom
        '
        Me.nom.AutoRoundedCorners = True
        Me.nom.BorderRadius = 17
        Me.nom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nom.DefaultText = ""
        Me.nom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.nom.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.nom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.nom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.nom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.nom.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nom.Location = New System.Drawing.Point(51, 123)
        Me.nom.Name = "nom"
        Me.nom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nom.PlaceholderText = ""
        Me.nom.SelectedText = ""
        Me.nom.Size = New System.Drawing.Size(200, 36)
        Me.nom.TabIndex = 2
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
    Friend WithEvents TextBx_Valide As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents passe As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents nom As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Lbl_Password As Label
    Friend WithEvents Lbl_Utilisateur As Label
    Friend WithEvents LBL_Login As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
End Class
