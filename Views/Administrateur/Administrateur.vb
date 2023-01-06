﻿Imports FontAwesome.Sharp
Public Class Administrateur
    Dim institutsControl As InstitutsControl

    Private Sub AdminView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Manager.connect()
        institutsControl = New InstitutsControl()



        institutsControl.Dock = DockStyle.Fill


        Panel_ADMIN.Controls.Add(institutsControl)

        btnInstitutes_Click(Nothing, Nothing)
    End Sub

    'Field
    Private currentBtn As IconButton
    Private leflBorderBtn As Panel
    Private currentChildForm As Form

    'Constructor
    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        leflBorderBtn = New Panel()
        leflBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leflBorderBtn)
    End Sub

    'Methods
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button
            currentBtn = CType(senderBtn, IconButton)
            'currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border
            leflBorderBtn.BackColor = customColor
            leflBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leflBorderBtn.Visible = True
            leflBorderBtn.BringToFront()
            'current form icon
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor

        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            'currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        'Open only form
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelMenu.Controls.Add(childForm)
        PanelMenu.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        IblFormTitle.Text = childForm.Text
    End Sub

    'Events
    Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        ActivateButton(sender, RGBColor.color1)
        'OpenChildForm(New EmployeesView)
    End Sub

    Private Sub btnInstitutes_Click(sender As Object, e As EventArgs) Handles btnInstitutes.Click
        ActivateButton(sender, RGBColor.color2)
        institutsControl.Show()
        'OpenChildForm(New InstitutesView)
    End Sub

    Private Sub btnECUEs_Click(sender As Object, e As EventArgs) Handles btnECUEs.Click
        ActivateButton(sender, RGBColor.color3)
        'OpenChildForm(New ECUEsView)
    End Sub

    Private Sub btnUEs_Click(sender As Object, e As EventArgs) Handles btnUEs.Click
        ActivateButton(sender, RGBColor.color4)
        'OpenChildForm(New UEsView)
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        ActivateButton(sender, RGBColor.color5)
        'OpenChildForm(New UserView)
    End Sub

    Private Sub ImageHome_Click(sender As Object, e As EventArgs) Handles ImageHome.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        'Reset()
    End Sub


    Private Sub Reset()
        DisableButton()
        leflBorderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.Honeydew
        IblFormTitle.Text = "Home"

    End Sub

    Private Sub btnFaculties_Click(sender As Object, e As EventArgs) Handles btnFaculties.Click
        ActivateButton(sender, RGBColor.color6)
    End Sub


    'Private Sub Panel_ADMIN_Paint(sender As Object, e As PaintEventArgs) Handles Panel_ADMIN.Paint

    'End Sub
End Class