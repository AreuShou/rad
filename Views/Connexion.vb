Public Class Connexion

    Private Sub BT_CONNEXION_Click(sender As Object, e As EventArgs) Handles BT_CONNEXION.Click
        If ProjetController.Login(TB_USERNAME.Text, TB_PASSWORD.Text) Then
            Me.Visible = False
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Manager.connect()
    End Sub

End Class