Imports System.Globalization
Imports System.Threading
Imports Abonnet
''' <summary>
''' Formulaire accès Internet
''' </summary>
Public Class FormInternetAccess
    Private price As Decimal
    Private costForShipping As Decimal
    Private tax As Decimal
    Private totalPrice As Decimal
    Private client As Client
    ''' <summary>
    '''
    ''' </summary>
    ''' <param name="client"></param>
    Public Sub New(client As Client)
        InitializeComponent()
        Me.client = client
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
    End Sub

    ''' <summary>
    ''' Bouton pour effacer les données
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'effacer les données
        txtPrice.Clear()
        txtCostForShipping.Clear()
        txtTax.Clear()
        txtTotalPrice.Clear()
        rbPaidMonthly.Checked = True
        rbCreditCard.Checked = True
    End Sub
    ''' <summary>
    ''' Imprimer reçu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPrintReceipt_Click(sender As Object, e As EventArgs) Handles btnPrintReceipt.Click
        'Verifier si l'usager a entré le bon prix
        If Decimal.TryParse(txtPrice.Text, price) = False Or price <= 0 Then
            MessageBox.Show("Entrer le bon prix>0!", "Entrée invalide", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        'Vérifier si l'utilisateur a entré le bon prix pour le shipping
        If Decimal.TryParse(txtCostForShipping.Text, costForShipping) = False Or price <= 0 Then
            MessageBox.Show("Entrer le bon coût du shipping >0!", "Entrée invalide", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        'Vérification si l'usager a entré le bon montant pour la taxe
        If Decimal.TryParse(txtTax.Text, tax) = False Or tax <= 0 Or price > 100 Then
            MessageBox.Show("Entrer la taxe>0 and price > 100!", "Entrée invalide", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        'calculer le sous-total
        Dim subTotal As Decimal = price + costForShipping
        'calculer le total
        totalPrice = subTotal + (subTotal * tax) / 100D
        'afficher le total
        txtTotalPrice.Text = totalPrice.ToString("C")
        'affiche le document pour impression
        PrintPreviewDialogReceipt.Document = PrintDocumentReceipt
        PrintPreviewDialogReceipt.ShowDialog()
    End Sub
    ''' <summary>
    ''' Ferme le formulaire
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        Me.Close() 'Ferme le formulaire
    End Sub
    ''' <summary>
    ''' Imprimer le document / reçu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PrintDocumentReceipt_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocumentReceipt.PrintPage
        'imprimer l'information
        e.Graphics.DrawString("Profile du client:", New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 15)
        e.Graphics.DrawString("Nom: " + client.Name, New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 45)
        e.Graphics.DrawString("Addresse: " + client.Address, New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 75)
        e.Graphics.DrawString("Téléphone: " + client.PhoneNumber, New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 105)
        e.Graphics.DrawString("Courriel: " + client.Email, New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 135)
        e.Graphics.DrawString("Type de client: " + client.TypeClient, New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 165)

        e.Graphics.DrawString("Accès Internet sur base annuelle: ", New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 230)
        e.Graphics.DrawString("Prix: " + price.ToString("C"), New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 260)
        e.Graphics.DrawString("Prix du shipping au client: " + costForShipping.ToString("C"), New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 290)
        e.Graphics.DrawString("Taxe : " + tax.ToString() + "%", New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 320)
        e.Graphics.DrawString("Prix total: " + totalPrice.ToString("C"), New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 350)

        If rbPaidMonthly.Checked Then
            e.Graphics.DrawString("Montant a payer " + (totalPrice / 12D).ToString("C") + " par mois", New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 380)
            e.Graphics.DrawString("pour l'accès Internet", New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 410)
        Else
            e.Graphics.DrawString("Montant a payer " + totalPrice.ToString("C") + " par mois", New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 380)
            e.Graphics.DrawString("pour l'accès Internet", New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 410)
        End If
        If (rbCreditCard.Checked) Then
            e.Graphics.DrawString("Méthode de paiement: carte de crédit", New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 440)
        End If
        If (rbCheque.Checked) Then
            e.Graphics.DrawString("Méthode de paiement: chèque", New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 440)
        End If
        If (rbMoneyOrder.Checked) Then
            e.Graphics.DrawString("Méthode de paiement: mandat poste", New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 440)
        End If
    End Sub
End Class