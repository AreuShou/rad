﻿Public Class Connexion
    'Private Sub CTS_DISPLAY_PASSWORD_CheckedChanged(sender As Object, e As EventArgs) Handles CTS_DISPLAY_PASSWORD.CheckedChanged
    'If (CTS_DISPLAY_PASSWORD.Checked) Then
    '  TB_PASSWORD_FIELD.PasswordChar = ""
    'Else
    'TB_PASSWORD_FIELD.PasswordChar = "*"
    'End If
    'End Sub

    Private Sub BT_CONNEXION_Click(sender As Object, e As EventArgs) Handles BT_CONNEXION.Click
        If ProjetController.Login(TB_USERNAME.Text, TB_PASSWORD.Text) Then
            Me.Visible = False
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Manager.connect()
    End Sub

    'Private Sub COB_CLOSE_Click(sender As Object, e As EventArgs) Handles COB_CLOSE.Click
    'Manager.Close()
    'End
    ' End Sub
End Class