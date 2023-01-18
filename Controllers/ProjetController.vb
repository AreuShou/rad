Imports System.Web.UI.WebControls

Public Class ProjetController
    Public Shared user As User
    Public Shared dashboard
    Public Shared Function Login(username As String, password As String) As Boolean
        If (UsersController.verifyUser(username, password, True)) Then
            user = UsersManager.getByUsername(username)
            If user.Username = Nothing Then
                MessageBox.Show("L'utilisateur '" & username & "' n'existe pas", "Utilisateur inexistant", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If user.PasswordField = password Then
                    If user.Employee.LastName = Nothing Then
                        Administrateur.Show()
                    Else
                        If user.Employee.FunctionField = Employee.Teacher Then
                            Enseignant.Show()
                        Else
                            ServiceScolarite.Show()
                        End If
                    End If
                    Return True
                Else
                    MessageBox.Show("Le mot de passe est incorrect", "Mot de passe incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
        Return False
    End Function

    Public Shared Function Logout() As Boolean
        Connexion.Show()
        user = New User(Nothing, Nothing, Nothing)
        Administrateur.Close()
        Enseignant.Close()
        ServiceScolarite.Close()
        Return True
    End Function
End Class
