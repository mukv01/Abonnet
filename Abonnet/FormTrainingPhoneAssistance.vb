Public Class FormTrainingPhoneAssistance
    Private price As Decimal
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
    ''' Bouton pour vider/clear
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPrice.Clear()
        txtTax.Clear()
        txtTotalPrice.Clear()
        rbTraining.Checked = True
    End Sub

    ''' <summary>
    ''' Bouton pour imprimer reçu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPrintReceipt_Click(sender As Object, e As EventArgs) Handles btnPrintReceipt.Click
        If AfficherResultat() Then
            'display Print Preview Dialog
            PrintPreviewDialogReceipt.Document = PrintDocumentReceipt
            PrintPreviewDialogReceipt.ShowDialog()
        End If
    End Sub
    ''' <summary>
    ''' Impression du reçu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PrintDocumentReceipt_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocumentReceipt.PrintPage
        'affiche l'information
        e.Graphics.DrawString("Information du client:", New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 15)
        e.Graphics.DrawString("Nom: " + client.Name, New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 45)
        e.Graphics.DrawString("Addresse: " + client.Address, New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 75)
        e.Graphics.DrawString("Numéro de téléphone: " + client.PhoneNumber, New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 105)
        e.Graphics.DrawString("Courriel: " + client.Email, New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 135)
        e.Graphics.DrawString("Type de client: " + client.TypeClient, New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 165)

        'si la formation est sélectionnée
        If (rbTraining.Checked) Then
            e.Graphics.DrawString("Formation:", New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 230)
        End If
        'si la réparation est sélectionné
        If (rbRepairs.Checked) Then
            e.Graphics.DrawString("Réparations:", New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 230)
        End If
        'si la programmation du site Web est sélectionné
        If (rbWebSiteProgramming.Checked) Then
            e.Graphics.DrawString("Programmation di site Web:", New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 230)
        End If
        'si l'option d'assistance téléphonique est sélectionné
        If (rbPhoneAsistance.Checked) Then
            e.Graphics.DrawString("Assistance téléphonique:", New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 230)
        End If
        'affiche le prix
        e.Graphics.DrawString("Prix: " + price.ToString("C"), New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 260)
        'print Tax
        e.Graphics.DrawString("Taxe : " + tax.ToString() + "%", New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 290)
        'affiche le prix total
        e.Graphics.DrawString("Prix total: " + totalPrice.ToString("C"), New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 320)

    End Sub
    ''' <summary>
    ''' Bouton pour fermer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        Me.Close()
    End Sub

    Private Function AfficherResultat() As Boolean
        If Not txtPrice.Text = String.Empty And Not txtTax.Text = String.Empty Then
            'Vérifier si l'usager a entré le prix
            If Decimal.TryParse(txtPrice.Text, price) = False Or price <= 0 Then
                txtTotalPrice.Text = String.Empty
                MessageBox.Show("Entrez le prix > 0!", "Recommencer", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            'Vérifier si l'usager a entré la taxe
            If Decimal.TryParse(txtTax.Text, tax) = False Or tax <= 0 Or price > 100 Then
                txtTotalPrice.Text = String.Empty
                MessageBox.Show("Entrez la taxe > 0 et le prix > 100!", "Entrée invalide", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            totalPrice = price + (price * tax) / 100D
            'afficher le total
            txtTotalPrice.Text = totalPrice.ToString("C")

            Return True
        Else
            txtTotalPrice.Text = String.Empty
            Return False
        End If
    End Function

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        AfficherResultat()
    End Sub

    Private Sub txtTax_TextChanged(sender As Object, e As EventArgs) Handles txtTax.TextChanged
        AfficherResultat()
    End Sub
End Class