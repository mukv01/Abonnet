Imports System.Text.RegularExpressions

Public Class FrmMain
    Private clients As New List(Of Client)
    Private selectedClient As Integer
    ''' <summary>
    ''' Ajouter un nouveau client
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddNewClient_Click(sender As Object, e As EventArgs) Handles btnAddNewClient.Click
        'Vérifier si le nom est vide
        If txtName.Text = "" Then
            MessageBox.Show("Entrez un nom", "Invalide", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        'Vérifier si l'adresse est correcte
        If txtAddress.Text = "" Then
            MessageBox.Show("Entrez l'adresse", "Invalide", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        'Vérifier si le numéro de téléphone est correct
        If txtPhoneNumber.MaskFull = False Then
            MessageBox.Show("Entrez un numéro de téléphone", "Invalide", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        'Vérifier si le courriel est correct
        If validateEmail(txtEmail.Text) = False Then
            MessageBox.Show("Entrez une adresse courriel", "Invalide", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        'Créer un nouveau client
        Dim newClient As New Client
        newClient.Name = txtName.Text
        newClient.Address = txtAddress.Text
        newClient.PhoneNumber = txtPhoneNumber.Text
        newClient.Email = txtEmail.Text

        If rbStandardClient.Checked Then
            newClient.typeofClients = "Clients standards"
        End If
        If rbBusinessClient.Checked Then
            newClient.typeofClients = "Clients affaires"
        End If
        'Ajouter le client a la liste
        clients.Add(newClient)
        'Ajouter le nouveau client au listbox
        lstClients.Items.Add(newClient.Name)
        clearTextBoxes()
    End Sub
    ''' <summary>
    ''' Vider les boîtes de texte
    ''' </summary>
    Private Sub clearTextBoxes()
        txtAddress.Clear()
        txtEmail.Clear()
        txtName.Clear()
        txtPhoneNumber.Clear()
    End Sub

    ''' <summary>
    ''' Vérifier si le courriel est correct
    ''' </summary>
    ''' <param name="email_Address"></param>
    ''' <returns></returns>
    Public Function validateEmail(email_Address As String) As Boolean
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(email_Address) Then
            Return True
        Else
            Return False
        End If
    End Function
    ''' <summary>
    ''' Supprimer le client
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDeleteClient_Click(sender As Object, e As EventArgs) Handles btnDeleteClient.Click
        If lstClients.SelectedIndex = -1 Then
            MessageBox.Show("Sélectionner un client de la liste", "Erreur de sélection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        clients.RemoveAt(lstClients.SelectedIndex)
        lstClients.Items.RemoveAt(lstClients.SelectedIndex)
        clearTextBoxes()
    End Sub
    ''' <summary>
    ''' Sélectioner un client de la liste
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lstClients_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstClients.SelectedIndexChanged
        Try
            txtName.Text = clients(lstClients.SelectedIndex).Name
            txtAddress.Text = clients(lstClients.SelectedIndex).Address
            txtPhoneNumber.Text = clients(lstClients.SelectedIndex).PhoneNumber
            txtEmail.Text = clients(lstClients.SelectedIndex).Email
            If clients(lstClients.SelectedIndex).typeofClients = "Clients standards" Then
                rbStandardClient.Checked = True
            End If
            If clients(lstClients.SelectedIndex).typeofClients = "Clients affaires" Then
                rbBusinessClient.Checked = True
            End If
            selectedClient = lstClients.SelectedIndex
        Catch ex As Exception

        End Try
    End Sub
    ''' <summary>
    ''' Modifier l'information sur le client
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEditClient_Click(sender As Object, e As EventArgs) Handles btnEditClient.Click
        If selectedClient = -1 Then
            MessageBox.Show("Sélectionner un client de la liste", "Erreur de sélection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        clients.RemoveAt(selectedClient)
        lstClients.Items.RemoveAt(selectedClient)
        'Créer un nouveau client
        Dim newClient As New Client
        newClient.Name = txtName.Text
        newClient.Address = txtAddress.Text
        newClient.PhoneNumber = txtPhoneNumber.Text
        newClient.Email = txtEmail.Text
        'Si un client standard est sélecctionné
        If rbStandardClient.Checked Then
            newClient.typeofClients = "Client standard"
        End If
        'Si un client affaires est sélectionné
        If rbBusinessClient.Checked Then
            newClient.typeofClients = "Client affaire"
        End If

        clients.Insert(selectedClient, newClient)
        lstClients.Items.Insert(selectedClient, newClient.Name)
    End Sub

    ''' <summary>
    ''' Bouton accès Internet
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnInternetAccess_Click(sender As Object, e As EventArgs) Handles btnInternetAccess.Click
        If lstClients.SelectedIndex = -1 Then
            MessageBox.Show("Sélectionner un client de la liste", "Erreur de sélection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim frmInternetAccess As New frmInternetAccess(clients(lstClients.SelectedIndex))
        frmInternetAccess.ShowDialog()
    End Sub
    ''' <summary>
    ''' Bouton pour location de modem
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRentModems_Click(sender As Object, e As EventArgs) Handles btnRentModems.Click
        If lstClients.SelectedIndex = -1 Then
            MessageBox.Show("Sélectionner un client de la liste", "Erreur de sélection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim frmRentModems As New frmRentModems(clients(lstClients.SelectedIndex))
        frmRentModems.ShowDialog()
    End Sub
    ''' <summary>
    ''' Bouton pour location d'ordinateur
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRentComputers_Click(sender As Object, e As EventArgs) Handles btnRentComputers.Click
        If lstClients.SelectedIndex = -1 Then
            MessageBox.Show("Sélectionner un client de la liste", "Erreur de sélection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim frmRentComputers As New frmRentComputers(clients(lstClients.SelectedIndex))
        frmRentComputers.ShowDialog()
    End Sub
    ''' <summary>
    ''' Bouton pour assistance téléphonique
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPhoneAssistance_Click(sender As Object, e As EventArgs) Handles btnPhoneAssistance.Click
        If lstClients.SelectedIndex = -1 Then
            MessageBox.Show("Sélectionner un client de la liate", "Erreur de sélection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim frmTrainingPhoneAssistance As New frmTrainingPhoneAssistance(clients(lstClients.SelectedIndex))
        frmTrainingPhoneAssistance.ShowDialog()
    End Sub
    ''' <summary>
    ''' Sortie du programme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' Location de modems
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RentModemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RentModemsToolStripMenuItem.Click
        btnRentModems_Click(sender, e)
    End Sub
    ''' <summary>
    ''' Location d'ordinateurs
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RentComputersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RentComputersToolStripMenuItem.Click
        btnRentComputers_Click(sender, e)
    End Sub
    ''' <summary>
    ''' Accès Internet
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub InternetAccessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InternetAccessToolStripMenuItem.Click
        btnInternetAccess_Click(sender, e)
    End Sub
    ''' <summary>
    ''' Formation / assistance téléphonique
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TrainingPhoneAssistanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrainingPhoneAssistanceToolStripMenuItem.Click
        btnPhoneAssistance_Click(sender, e)
    End Sub
End Class

