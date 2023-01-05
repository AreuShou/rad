Imports FontAwesome.Sharp
Public Class AdminView
    'Field
    Private currentBtn As IconButton
    Private leflBorderBtn As Panel

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
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
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
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub
    'Events
    Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        ActivateButton(sender, RGBColor.color1)
    End Sub

    Private Sub btnInstitutes_Click(sender As Object, e As EventArgs) Handles btnInstitutes.Click
        ActivateButton(sender, RGBColor.color2)
    End Sub

    Private Sub btnECUEs_Click(sender As Object, e As EventArgs) Handles btnECUEs.Click
        ActivateButton(sender, RGBColor.color3)
    End Sub

    Private Sub btnUEs_Click(sender As Object, e As EventArgs) Handles btnUEs.Click
        ActivateButton(sender, RGBColor.color4)
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        ActivateButton(sender, RGBColor.color5)
    End Sub
End Class