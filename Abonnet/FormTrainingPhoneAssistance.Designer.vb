<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTrainingPhoneAssistance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTrainingPhoneAssistance))
        Me.rbTraining = New System.Windows.Forms.RadioButton()
        Me.bntClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnPrintReceipt = New System.Windows.Forms.Button()
        Me.rbRepairs = New System.Windows.Forms.RadioButton()
        Me.rbWebSiteProgramming = New System.Windows.Forms.RadioButton()
        Me.rbPhoneAsistance = New System.Windows.Forms.RadioButton()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrintDocumentReceipt = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialogReceipt = New System.Windows.Forms.PrintPreviewDialog()
        Me.SuspendLayout()
        '
        'rbTraining
        '
        Me.rbTraining.AutoSize = True
        Me.rbTraining.Checked = True
        Me.rbTraining.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.rbTraining.Location = New System.Drawing.Point(12, 20)
        Me.rbTraining.Name = "rbTraining"
        Me.rbTraining.Size = New System.Drawing.Size(113, 28)
        Me.rbTraining.TabIndex = 1
        Me.rbTraining.TabStop = True
        Me.rbTraining.Text = "Formation"
        Me.rbTraining.UseVisualStyleBackColor = True
        '
        'bntClose
        '
        Me.bntClose.Location = New System.Drawing.Point(312, 167)
        Me.bntClose.Name = "bntClose"
        Me.bntClose.Size = New System.Drawing.Size(133, 35)
        Me.bntClose.TabIndex = 15
        Me.bntClose.Text = "Fermer"
        Me.bntClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(34, 167)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(133, 35)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Vider"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnPrintReceipt
        '
        Me.btnPrintReceipt.Location = New System.Drawing.Point(173, 167)
        Me.btnPrintReceipt.Name = "btnPrintReceipt"
        Me.btnPrintReceipt.Size = New System.Drawing.Size(133, 35)
        Me.btnPrintReceipt.TabIndex = 14
        Me.btnPrintReceipt.Text = "Imprimer le reçcu"
        Me.btnPrintReceipt.UseVisualStyleBackColor = True
        '
        'rbRepairs
        '
        Me.rbRepairs.AutoSize = True
        Me.rbRepairs.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.rbRepairs.Location = New System.Drawing.Point(12, 54)
        Me.rbRepairs.Name = "rbRepairs"
        Me.rbRepairs.Size = New System.Drawing.Size(128, 28)
        Me.rbRepairs.TabIndex = 2
        Me.rbRepairs.TabStop = True
        Me.rbRepairs.Text = "Réparations"
        Me.rbRepairs.UseVisualStyleBackColor = True
        '
        'rbWebSiteProgramming
        '
        Me.rbWebSiteProgramming.AutoSize = True
        Me.rbWebSiteProgramming.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.rbWebSiteProgramming.Location = New System.Drawing.Point(12, 88)
        Me.rbWebSiteProgramming.Name = "rbWebSiteProgramming"
        Me.rbWebSiteProgramming.Size = New System.Drawing.Size(109, 28)
        Me.rbWebSiteProgramming.TabIndex = 3
        Me.rbWebSiteProgramming.TabStop = True
        Me.rbWebSiteProgramming.Text = "Site Web "
        Me.rbWebSiteProgramming.UseVisualStyleBackColor = True
        '
        'rbPhoneAsistance
        '
        Me.rbPhoneAsistance.AutoSize = True
        Me.rbPhoneAsistance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.rbPhoneAsistance.Location = New System.Drawing.Point(12, 122)
        Me.rbPhoneAsistance.Name = "rbPhoneAsistance"
        Me.rbPhoneAsistance.Size = New System.Drawing.Size(234, 28)
        Me.rbPhoneAsistance.TabIndex = 4
        Me.rbPhoneAsistance.TabStop = True
        Me.rbPhoneAsistance.Text = "Assistance téléphonique"
        Me.rbPhoneAsistance.UseVisualStyleBackColor = True
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtTotalPrice.Location = New System.Drawing.Point(349, 89)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(100, 26)
        Me.txtTotalPrice.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(245, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Total prix:"
        '
        'txtTax
        '
        Me.txtTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtTax.Location = New System.Drawing.Point(349, 56)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(100, 26)
        Me.txtTax.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(279, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Taxe %:"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(349, 22)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 26)
        Me.txtPrice.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(286, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Prix:"
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
        'frmTrainingPhoneAssistance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 221)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bntClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrintReceipt)
        Me.Controls.Add(Me.rbPhoneAsistance)
        Me.Controls.Add(Me.rbWebSiteProgramming)
        Me.Controls.Add(Me.rbRepairs)
        Me.Controls.Add(Me.rbTraining)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTrainingPhoneAssistance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formation et assistance téléphonique"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbTraining As RadioButton
    Friend WithEvents bntClose As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnPrintReceipt As Button
    Friend WithEvents rbRepairs As RadioButton
    Friend WithEvents rbWebSiteProgramming As RadioButton
    Friend WithEvents rbPhoneAsistance As RadioButton
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTax As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PrintDocumentReceipt As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialogReceipt As PrintPreviewDialog
End Class
