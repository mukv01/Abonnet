Imports System.Text.RegularExpressions

Public Class FormMain
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
            newClient.TypeClient = "Clients standards"
        End If
        If rbBusinessClient.Checked Then
            newClient.TypeClient = "Clients affaires"
        End If

        If Not VerifierClientExistence(newClient) Then
            'Ajouter le client a la liste
            clients.Insert(0, newClient)

            'Ajouter le nouveau client au listbox
            lstClients.Items.Insert(0, newClient.Name)

            clearTextBoxes()
        End If
    End Sub

    Function VerifierClientExistence(ByVal newClient As Client) As Boolean
        For Each monClient In clients
            If (newClient.Name = monClient.Name) Then
                MessageBox.Show("Le nom existe déjà", "Invalide", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            End If

            If (newClient.Email = monClient.Email) Then
                MessageBox.Show("Le courriel existe déjà", "Invalide", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            End If
        Next

        Return False
    End Function
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
            If clients(lstClients.SelectedIndex).TypeClient = "Clients standards" Then
                rbStandardClient.Checked = True
            End If
            If clients(lstClients.SelectedIndex).TypeClient = "Clients affaires" Then
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
            newClient.TypeClient = "Client standard"
        End If
        'Si un client affaires est sélectionné
        If rbBusinessClient.Checked Then
            newClient.TypeClient = "Client affaire"
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
        Dim frmInternetAccess As New FormInternetAccess(clients(lstClients.SelectedIndex))
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
        Dim frmRentModems As New FormRentModems(clients(lstClients.SelectedIndex))
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
        Dim frmRentComputers As New FormRentComputers(clients(lstClients.SelectedIndex))
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
        Dim frmTrainingPhoneAssistance As New FormTrainingPhoneAssistance(clients(lstClients.SelectedIndex))
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

    ''' <summary>
    ''' Sous routine de chargement par défaut
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Créer un nouveau client
        Dim newClient As New Client
        newClient.Name = ""
        newClient.Address = ""
        newClient.PhoneNumber = ""
        newClient.Email = ""
        newClient.TypeClient = "Clients standards"

        'Ajouter le client a la liste
        clients.Insert(0, newClient)
        'Ajouter le nouveau client au listbox
        lstClients.Items.Insert(0, newClient.Name)

        newClient = New Client
        newClient.Name = "Jonathan Tremblay"
        newClient.Address = "144 Boulevard de la paix"
        newClient.PhoneNumber = "6131234566"
        newClient.Email = "jonathan.tremblay@hotmail.com"
        newClient.TypeClient = "Clients standards"

        'Ajouter le client a la liste
        clients.Insert(0, newClient)
        'Ajouter le nouveau client au listbox
        lstClients.Items.Insert(0, newClient.Name)

        newClient = New Client
        newClient.Name = "Sophie Charbonneau"
        newClient.Address = "23 Boulevard Maisoneuve"
        newClient.PhoneNumber = "6134564567"
        newClient.Email = "sophie.charbonneau@hotmail.com"
        newClient.TypeClient = "Clients standards"

        'Ajouter le client a la liste
        clients.Insert(0, newClient)
        'Ajouter le nouveau client au listbox
        lstClients.Items.Insert(0, newClient.Name)

        newClient = New Client
        newClient.Name = "Imaginatif Inc."
        newClient.Address = "45 Boulevard Maisoneuve"
        newClient.PhoneNumber = "8194564567"
        newClient.Email = "info@imaginatif.com"
        newClient.TypeClient = "Clients affaires"

        'Ajouter le client a la liste
        clients.Insert(0, newClient)
        'Ajouter le nouveau client au listbox
        lstClients.Items.Insert(0, newClient.Name)
    End Sub
End Class

