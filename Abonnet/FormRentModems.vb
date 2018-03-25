Public Class FormRentModems
    Private price As Decimal
    Private tax As Decimal
    Private totalPrice As Decimal
    Private client As Client
    ''' <summary>
    ''' Constructeur
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
        rbTPLINKTLWR841N.Checked = True
    End Sub

    ''' <summary>
    ''' Bouton pour imprimer le reçu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPrintReceipt_Click(sender As Object, e As EventArgs) Handles btnPrintReceipt.Click
        'Vérifie si l'usager a entré le prix
        If Decimal.TryParse(txtPrice.Text, price) = False Or price <= 0 Then
            MessageBox.Show("Enttrez le prix>0!", "Entrée invalide", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        'Vérifie si l'usager a entré la taxe
        If Decimal.TryParse(txtTax.Text, tax) = False Or tax <= 0 Or price > 100 Then
            MessageBox.Show("Entrez la taxe>0 and price > 100!", "Entrée invalide", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        totalPrice = price + (price * tax) / 100D
        'Affiche le total
        txtTotalPrice.Text = totalPrice.ToString("C")
        'Affiche le document
        PrintPreviewDialogReceipt.Document = PrintDocumentReceipt
        PrintPreviewDialogReceipt.ShowDialog()
    End Sub
    ''' <summary>
    ''' Imprimer document de la page du reçu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PrintDocumentReceipt_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocumentReceipt.PrintPage
        'print information
        e.Graphics.DrawString("Information du client:", New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 15)
        e.Graphics.DrawString("Nom: " + client.Name, New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 45)
        e.Graphics.DrawString("Addresse: " + client.Address, New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 75)
        e.Graphics.DrawString("Numéro de téléphone: " + client.PhoneNumber, New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 105)
        e.Graphics.DrawString("Courriel: " + client.Email, New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 135)
        e.Graphics.DrawString("Type de client: " + client.TypeClient, New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 165)

        'si TP-LINK TL-WR841N est sélectionné
        If (rbTPLINKTLWR841N.Checked) Then
            e.Graphics.DrawString("TP-LINK TL-WR841N:", New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 230)
        End If
        'si TP-LINK Archer C8 est sélectionné
        If (rbTPLINKArcherC8.Checked) Then
            e.Graphics.DrawString("TP-LINK Archer C8:", New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 230)
        End If
        'si Nighthawk AC1900 est sélectionné
        If (rbNighthawkAC1900.Checked) Then
            e.Graphics.DrawString("Nighthawk AC1900:", New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 230)
        End If
        'Affiche le prix
        e.Graphics.DrawString("Prix: " + price.ToString("C"), New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 260)
        'Affiche la taxe
        e.Graphics.DrawString("Taxe : " + tax.ToString() + "%", New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular), New SolidBrush(Color.Black), 30, 290)
        'Affiche le prix total
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
End Class