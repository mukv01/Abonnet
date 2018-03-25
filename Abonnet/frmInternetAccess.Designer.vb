<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInternetAccess
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInternetAccess))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnPrintReceipt = New System.Windows.Forms.Button()
        Me.bntClose = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbPaidAnnually = New System.Windows.Forms.RadioButton()
        Me.rbPaidMonthly = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbMoneyOrder = New System.Windows.Forms.RadioButton()
        Me.rbCheque = New System.Windows.Forms.RadioButton()
        Me.rbCreditCard = New System.Windows.Forms.RadioButton()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCostForShipping = New System.Windows.Forms.TextBox()
        Me.PrintDocumentReceipt = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialogReceipt = New System.Windows.Forms.PrintPreviewDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Location Internet sur base annuelle"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prix:"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(161, 37)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 26)
        Me.txtPrice.TabIndex = 1
        '
        'btnPrintReceipt
        '
        Me.btnPrintReceipt.Location = New System.Drawing.Point(157, 244)
        Me.btnPrintReceipt.Name = "btnPrintReceipt"
        Me.btnPrintReceipt.Size = New System.Drawing.Size(133, 35)
        Me.btnPrintReceipt.TabIndex = 11
        Me.btnPrintReceipt.Text = "Imprimer reçu"
        Me.btnPrintReceipt.UseVisualStyleBackColor = True
        '
        'bntClose
        '
        Me.bntClose.Location = New System.Drawing.Point(296, 244)
        Me.bntClose.Name = "bntClose"
        Me.bntClose.Size = New System.Drawing.Size(133, 35)
        Me.bntClose.TabIndex = 12
        Me.bntClose.Text = "Fermer"
        Me.bntClose.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(91, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Taxe %:"
        '
        'txtTax
        '
        Me.txtTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtTax.Location = New System.Drawing.Point(161, 103)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(100, 26)
        Me.txtTax.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Coût total:"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtTotalPrice.Location = New System.Drawing.Point(161, 136)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(100, 26)
        Me.txtTotalPrice.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbPaidAnnually)
        Me.GroupBox1.Controls.Add(Me.rbPaidMonthly)
        Me.GroupBox1.Location = New System.Drawing.Point(272, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(205, 93)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Paiement(s)"
        '
        'rbPaidAnnually
        '
        Me.rbPaidAnnually.AutoSize = True
        Me.rbPaidAnnually.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.rbPaidAnnually.Location = New System.Drawing.Point(20, 48)
        Me.rbPaidAnnually.Name = "rbPaidAnnually"
        Me.rbPaidAnnually.Size = New System.Drawing.Size(161, 24)
        Me.rbPaidAnnually.TabIndex = 6
        Me.rbPaidAnnually.Text = "Paiement annuel"
        Me.rbPaidAnnually.UseVisualStyleBackColor = True
        '
        'rbPaidMonthly
        '
        Me.rbPaidMonthly.AutoSize = True
        Me.rbPaidMonthly.Checked = True
        Me.rbPaidMonthly.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.rbPaidMonthly.Location = New System.Drawing.Point(20, 19)
        Me.rbPaidMonthly.Name = "rbPaidMonthly"
        Me.rbPaidMonthly.Size = New System.Drawing.Size(174, 24)
        Me.rbPaidMonthly.TabIndex = 5
        Me.rbPaidMonthly.TabStop = True
        Me.rbPaidMonthly.Text = "Paiement mensuel"
        Me.rbPaidMonthly.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbMoneyOrder)
        Me.GroupBox2.Controls.Add(Me.rbCheque)
        Me.GroupBox2.Controls.Add(Me.rbCreditCard)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(481, 60)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Méthode de paiement"
        '
        'rbMoneyOrder
        '
        Me.rbMoneyOrder.AutoSize = True
        Me.rbMoneyOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.rbMoneyOrder.Location = New System.Drawing.Point(307, 21)
        Me.rbMoneyOrder.Name = "rbMoneyOrder"
        Me.rbMoneyOrder.Size = New System.Drawing.Size(137, 24)
        Me.rbMoneyOrder.TabIndex = 9
        Me.rbMoneyOrder.Text = "Mandat poste"
        Me.rbMoneyOrder.UseVisualStyleBackColor = True
        '
        'rbCheque
        '
        Me.rbCheque.AutoSize = True
        Me.rbCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.rbCheque.Location = New System.Drawing.Point(200, 21)
        Me.rbCheque.Name = "rbCheque"
        Me.rbCheque.Size = New System.Drawing.Size(89, 24)
        Me.rbCheque.TabIndex = 8
        Me.rbCheque.Text = "Chèque"
        Me.rbCheque.UseVisualStyleBackColor = True
        '
        'rbCreditCard
        '
        Me.rbCreditCard.AutoSize = True
        Me.rbCreditCard.Checked = True
        Me.rbCreditCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.rbCreditCard.Location = New System.Drawing.Point(36, 21)
        Me.rbCreditCard.Name = "rbCreditCard"
        Me.rbCreditCard.Size = New System.Drawing.Size(146, 24)
        Me.rbCreditCard.TabIndex = 7
        Me.rbCreditCard.TabStop = True
        Me.rbCreditCard.Text = "Carte de crédit"
        Me.rbCreditCard.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(18, 244)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(133, 35)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Supprimer"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Coût de livraison:"
        '
        'txtCostForShipping
        '
        Me.txtCostForShipping.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtCostForShipping.Location = New System.Drawing.Point(161, 70)
        Me.txtCostForShipping.Name = "txtCostForShipping"
        Me.txtCostForShipping.Size = New System.Drawing.Size(100, 26)
        Me.txtCostForShipping.TabIndex = 2
        '
        'PrintDocumentReceipt
        '
        '
        'PrintPreviewDialogReceipt
        '
        Me.PrintPreviewDialogReceipt.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogReceipt.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogReceipt.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialogReceipt.Enabled = True
        Me.PrintPreviewDialogReceipt.Icon = CType(resources.GetObject("PrintPreviewDialogReceipt.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialogReceipt.Name = "PrintPreviewDialogMember"
        Me.PrintPreviewDialogReceipt.Visible = False
        '
        'frmInternetAccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 287)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bntClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrintReceipt)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCostForShipping)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInternetAccess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accès Internet"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents btnPrintReceipt As Button
    Friend WithEvents bntClose As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTax As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbPaidAnnually As RadioButton
    Friend WithEvents rbPaidMonthly As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbMoneyOrder As RadioButton
    Friend WithEvents rbCheque As RadioButton
    Friend WithEvents rbCreditCard As RadioButton
    Friend WithEvents btnClear As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCostForShipping As TextBox
    Friend WithEvents PrintDocumentReceipt As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialogReceipt As PrintPreviewDialog
End Class
