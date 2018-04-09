Public Class FormLogin
    Private Sub btnConnexion_Click(sender As Object, e As EventArgs) Handles btnConnexion.Click
        If Not Me.txtNomUtilisateur.Text = "abonnet" Then
            MessageBox.Show("Votre nom d'utilisateur n'est pas reconnu par le système", "Entrée invalide", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Not Me.txtMotDePasse.Text = "test" Then
            MessageBox.Show("Retapez le mot de passe", "Entrée invalide", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtMotDePasse.Text = ""
        Else
            Me.Hide()
            Dim frmMain As New FormMain()
            frmMain.ShowDialog()
        End If


    End Sub
End Class