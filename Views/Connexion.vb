Public Class Connexion
    Private Sub Connexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Manager.connect()
    End Sub

    Private Sub TextBx_Valide_TextChanged(sender As Object, e As EventArgs) Handles TextBx_Valide.TextChanged
        If JohnController.Login(nom.Text, passe.Text) Then
            Me.Visible = False
        End If
    End Sub
End Class