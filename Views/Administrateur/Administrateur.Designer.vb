<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrateur
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel_ADMIN = New Guna.UI2.WinForms.Guna2Panel()
        Me.PanelTitleBar = New Guna.UI2.WinForms.Guna2Panel()
        Me.BT_MAXIMISE = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.BT_MINIMISE = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.BT_CLOSE = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.IblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PanelMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnUser = New FontAwesome.Sharp.IconButton()
        Me.btnUEs = New FontAwesome.Sharp.IconButton()
        Me.btnECUEs = New FontAwesome.Sharp.IconButton()
        Me.btnInstitutes = New FontAwesome.Sharp.IconButton()
        Me.btnEmployees = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New Guna.UI2.WinForms.Guna2Panel()
        Me.ImageHome = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.btnFaculties = New FontAwesome.Sharp.IconButton()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.ImageHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_ADMIN
        '
        Me.Panel_ADMIN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_ADMIN.Location = New System.Drawing.Point(238, 82)
        Me.Panel_ADMIN.Name = "Panel_ADMIN"
        Me.Panel_ADMIN.Size = New System.Drawing.Size(744, 475)
        Me.Panel_ADMIN.TabIndex = 0
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTitleBar.BackColor = System.Drawing.Color.Transparent
        Me.PanelTitleBar.Controls.Add(Me.BT_MAXIMISE)
        Me.PanelTitleBar.Controls.Add(Me.BT_MINIMISE)
        Me.PanelTitleBar.Controls.Add(Me.BT_CLOSE)
        Me.PanelTitleBar.Controls.Add(Me.IblFormTitle)
        Me.PanelTitleBar.Controls.Add(Me.IconCurrentForm)
        Me.PanelTitleBar.Controls.Add(Me.Guna2PictureBox1)
        Me.PanelTitleBar.Location = New System.Drawing.Point(238, 1)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(744, 75)
        Me.PanelTitleBar.TabIndex = 5
        '
        'BT_MAXIMISE
        '
        Me.BT_MAXIMISE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_MAXIMISE.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.BT_MAXIMISE.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.BT_MAXIMISE.IconColor = System.Drawing.Color.White
        Me.BT_MAXIMISE.Location = New System.Drawing.Point(678, 0)
        Me.BT_MAXIMISE.Name = "BT_MAXIMISE"
        Me.BT_MAXIMISE.Size = New System.Drawing.Size(30, 30)
        Me.BT_MAXIMISE.TabIndex = 6
        '
        'BT_MINIMISE
        '
        Me.BT_MINIMISE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_MINIMISE.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.BT_MINIMISE.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.BT_MINIMISE.IconColor = System.Drawing.Color.White
        Me.BT_MINIMISE.Location = New System.Drawing.Point(642, 0)
        Me.BT_MINIMISE.Name = "BT_MINIMISE"
        Me.BT_MINIMISE.Size = New System.Drawing.Size(30, 30)
        Me.BT_MINIMISE.TabIndex = 5
        '
        'BT_CLOSE
        '
        Me.BT_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_CLOSE.FillColor = System.Drawing.Color.Red
        Me.BT_CLOSE.IconColor = System.Drawing.Color.White
        Me.BT_CLOSE.Location = New System.Drawing.Point(714, 0)
        Me.BT_CLOSE.Name = "BT_CLOSE"
        Me.BT_CLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BT_CLOSE.TabIndex = 4
        '
        'IblFormTitle
        '
        Me.IblFormTitle.AutoSize = True
        Me.IblFormTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IblFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.IblFormTitle.Location = New System.Drawing.Point(53, 21)
        Me.IblFormTitle.Name = "IblFormTitle"
        Me.IblFormTitle.Size = New System.Drawing.Size(39, 13)
        Me.IblFormTitle.TabIndex = 2
        Me.IblFormTitle.Text = "Home"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.Honeydew
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.Color.PaleTurquoise
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.Location = New System.Drawing.Point(15, 12)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(32, 32)
        Me.IconCurrentForm.TabIndex = 1
        Me.IconCurrentForm.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(15, 12)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(0, 0)
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelMenu.BackColor = System.Drawing.Color.Transparent
        Me.PanelMenu.Controls.Add(Me.btnFaculties)
        Me.PanelMenu.Controls.Add(Me.btnUser)
        Me.PanelMenu.Controls.Add(Me.btnUEs)
        Me.PanelMenu.Controls.Add(Me.btnECUEs)
        Me.PanelMenu.Controls.Add(Me.btnInstitutes)
        Me.PanelMenu.Controls.Add(Me.btnEmployees)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Location = New System.Drawing.Point(2, 1)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(230, 556)
        Me.PanelMenu.TabIndex = 4
        '
        'btnUser
        '
        Me.btnUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUser.FlatAppearance.BorderSize = 0
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnUser.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.btnUser.IconColor = System.Drawing.Color.Gainsboro
        Me.btnUser.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUser.IconSize = 32
        Me.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUser.Location = New System.Drawing.Point(0, 440)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnUser.Size = New System.Drawing.Size(230, 60)
        Me.btnUser.TabIndex = 5
        Me.btnUser.Text = "Utilisateurs"
        Me.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'btnUEs
        '
        Me.btnUEs.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUEs.FlatAppearance.BorderSize = 0
        Me.btnUEs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUEs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUEs.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnUEs.IconChar = FontAwesome.Sharp.IconChar.BookOpen
        Me.btnUEs.IconColor = System.Drawing.Color.Gainsboro
        Me.btnUEs.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUEs.IconSize = 32
        Me.btnUEs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUEs.Location = New System.Drawing.Point(0, 380)
        Me.btnUEs.Name = "btnUEs"
        Me.btnUEs.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnUEs.Size = New System.Drawing.Size(230, 60)
        Me.btnUEs.TabIndex = 4
        Me.btnUEs.Text = "UEs"
        Me.btnUEs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUEs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUEs.UseVisualStyleBackColor = True
        '
        'btnECUEs
        '
        Me.btnECUEs.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnECUEs.FlatAppearance.BorderSize = 0
        Me.btnECUEs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnECUEs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnECUEs.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnECUEs.IconChar = FontAwesome.Sharp.IconChar.Forward
        Me.btnECUEs.IconColor = System.Drawing.Color.Gainsboro
        Me.btnECUEs.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnECUEs.IconSize = 32
        Me.btnECUEs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnECUEs.Location = New System.Drawing.Point(0, 320)
        Me.btnECUEs.Name = "btnECUEs"
        Me.btnECUEs.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnECUEs.Size = New System.Drawing.Size(230, 60)
        Me.btnECUEs.TabIndex = 3
        Me.btnECUEs.Text = "ECUEs"
        Me.btnECUEs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnECUEs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnECUEs.UseVisualStyleBackColor = True
        '
        'btnInstitutes
        '
        Me.btnInstitutes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInstitutes.FlatAppearance.BorderSize = 0
        Me.btnInstitutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInstitutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstitutes.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnInstitutes.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        Me.btnInstitutes.IconColor = System.Drawing.Color.Gainsboro
        Me.btnInstitutes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnInstitutes.IconSize = 32
        Me.btnInstitutes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInstitutes.Location = New System.Drawing.Point(0, 260)
        Me.btnInstitutes.Name = "btnInstitutes"
        Me.btnInstitutes.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnInstitutes.Size = New System.Drawing.Size(230, 60)
        Me.btnInstitutes.TabIndex = 2
        Me.btnInstitutes.Text = "Instituts"
        Me.btnInstitutes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInstitutes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInstitutes.UseVisualStyleBackColor = True
        '
        'btnEmployees
        '
        Me.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEmployees.FlatAppearance.BorderSize = 0
        Me.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmployees.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployees.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnEmployees.IconChar = FontAwesome.Sharp.IconChar.PeopleCarryBox
        Me.btnEmployees.IconColor = System.Drawing.Color.Gainsboro
        Me.btnEmployees.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEmployees.IconSize = 32
        Me.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmployees.Location = New System.Drawing.Point(0, 200)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnEmployees.Size = New System.Drawing.Size(230, 60)
        Me.btnEmployees.TabIndex = 1
        Me.btnEmployees.Text = "Employées"
        Me.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEmployees.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.ImageHome)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(230, 200)
        Me.PanelLogo.TabIndex = 0
        '
        'ImageHome
        '
        Me.ImageHome.Image = Global.ProjetNet_RAD.My.Resources.Resources.img3
        Me.ImageHome.ImageRotate = 0!
        Me.ImageHome.Location = New System.Drawing.Point(12, 12)
        Me.ImageHome.Name = "ImageHome"
        Me.ImageHome.Size = New System.Drawing.Size(196, 172)
        Me.ImageHome.TabIndex = 0
        Me.ImageHome.TabStop = False
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 0
        Me.Guna2Elipse1.TargetControl = Me
        '
        'btnFaculties
        '
        Me.btnFaculties.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFaculties.FlatAppearance.BorderSize = 0
        Me.btnFaculties.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFaculties.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFaculties.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnFaculties.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        Me.btnFaculties.IconColor = System.Drawing.Color.Gainsboro
        Me.btnFaculties.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnFaculties.IconSize = 32
        Me.btnFaculties.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFaculties.Location = New System.Drawing.Point(0, 500)
        Me.btnFaculties.Name = "btnFaculties"
        Me.btnFaculties.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnFaculties.Size = New System.Drawing.Size(230, 60)
        Me.btnFaculties.TabIndex = 6
        Me.btnFaculties.Text = "Facultés"
        Me.btnFaculties.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFaculties.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFaculties.UseVisualStyleBackColor = True
        '
        'Administrateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(984, 557)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.Panel_ADMIN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Administrateur"
        Me.Text = "AdminView"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.ImageHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_ADMIN As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PanelTitleBar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents IblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents PanelMenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnUser As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUEs As FontAwesome.Sharp.IconButton
    Friend WithEvents btnECUEs As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInstitutes As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEmployees As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelLogo As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ImageHome As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BT_MAXIMISE As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents BT_MINIMISE As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents BT_CLOSE As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnFaculties As FontAwesome.Sharp.IconButton
End Class
