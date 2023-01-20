Public Class Connexion

    Private Sub BT_CONNEXION_Click(sender As Object, e As EventArgs) Handles BT_CONNEXION.Click
        If ProjetController.Login(TB_USERNAME.Text, TB_PASSWORD.Text) Then
            Me.Visible = False
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Manager.connect()
    End Sub

    Private Sub TB_USERNAME_TextChanged(sender As Object, e As EventArgs) Handles TB_USERNAME.TextChanged

    End Sub

    Private Sub CTS_DISPLAY_PASSWORD_CheckedChanged(sender As Object, e As EventArgs) Handles CTS_DISPLAY_PASSWORD.CheckedChanged
        If (CTS_DISPLAY_PASSWORD.Checked) Then
            TB_PASSWORD.UseSystemPasswordChar = False
        Else
            TB_PASSWORD.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class