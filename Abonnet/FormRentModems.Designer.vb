<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRentModems
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRentModems))
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbNighthawkAC1900 = New System.Windows.Forms.RadioButton()
        Me.rbTPLINKArcherC8 = New System.Windows.Forms.RadioButton()
        Me.rbTPLINKTLWR841N = New System.Windows.Forms.RadioButton()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.pb2 = New System.Windows.Forms.PictureBox()
        Me.pb3 = New System.Windows.Forms.PictureBox()
        Me.bntClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnPrintReceipt = New System.Windows.Forms.Button()
        Me.PrintDocumentReceipt = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialogReceipt = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtTotalPrice.Location = New System.Drawing.Point(410, 170)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(100, 26)
        Me.txtTotalPrice.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(306, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Coût total:"
        '
        'txtTax
        '
        Me.txtTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtTax.Location = New System.Drawing.Point(410, 137)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(100, 26)
        Me.txtTax.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(340, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Taxe %:"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(410, 103)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 26)
        Me.txtPrice.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(347, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Prix:"
        '
        'rbNighthawkAC1900
        '
        Me.rbNighthawkAC1900.AutoSize = True
        Me.rbNighthawkAC1900.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.rbNighthawkAC1900.Location = New System.Drawing.Point(112, 211)
        Me.rbNighthawkAC1900.Name = "rbNighthawkAC1900"
        Me.rbNighthawkAC1900.Size = New System.Drawing.Size(187, 28)
        Me.rbNighthawkAC1900.TabIndex = 30
        Me.rbNighthawkAC1900.TabStop = True
        Me.rbNighthawkAC1900.Text = "Nighthawk AC1900"
        Me.rbNighthawkAC1900.UseVisualStyleBackColor = True
        '
        'rbTPLINKArcherC8
        '
        Me.rbTPLINKArcherC8.AutoSize = True
        Me.rbTPLINKArcherC8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.rbTPLINKArcherC8.Location = New System.Drawing.Point(111, 128)
        Me.rbTPLINKArcherC8.Name = "rbTPLINKArcherC8"
        Me.rbTPLINKArcherC8.Size = New System.Drawing.Size(188, 28)
        Me.rbTPLINKArcherC8.TabIndex = 29
        Me.rbTPLINKArcherC8.TabStop = True
        Me.rbTPLINKArcherC8.Text = "TP-LINK Archer C8"
        Me.rbTPLINKArcherC8.UseVisualStyleBackColor = True
        '
        'rbTPLINKTLWR841N
        '
        Me.rbTPLINKTLWR841N.AutoSize = True
        Me.rbTPLINKTLWR841N.Checked = True
        Me.rbTPLINKTLWR841N.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.rbTPLINKTLWR841N.Location = New System.Drawing.Point(111, 41)
        Me.rbTPLINKTLWR841N.Name = "rbTPLINKTLWR841N"
        Me.rbTPLINKTLWR841N.Size = New System.Drawing.Size(206, 28)
        Me.rbTPLINKTLWR841N.TabIndex = 28
        Me.rbTPLINKTLWR841N.TabStop = True
        Me.rbTPLINKTLWR841N.Text = "TP-LINK TL-WR841N"
        Me.rbTPLINKTLWR841N.UseVisualStyleBackColor = True
        '
        'pb1
        '
        Me.pb1.BackgroundImage = Global.Abonnet.My.Resources.Resources.TL_WR841N_un_V2_1041_large_0_20150724113937_620x465
        Me.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pb1.Location = New System.Drawing.Point(7, 12)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(98, 80)
        Me.pb1.TabIndex = 31
        Me.pb1.TabStop = False
        '
        'pb2
        '
        Me.pb2.BackgroundImage = Global.Abonnet.My.Resources.Resources.Archer_C8_01
        Me.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pb2.Location = New System.Drawing.Point(7, 98)
        Me.pb2.Name = "pb2"
        Me.pb2.Size = New System.Drawing.Size(98, 80)
        Me.pb2.TabIndex = 31
        Me.pb2.TabStop = False
        '
        'pb3
        '
        Me.pb3.BackgroundImage = Global.Abonnet.My.Resources.Resources.router_620x462
        Me.pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pb3.Location = New System.Drawing.Point(7, 184)
        Me.pb3.Name = "pb3"
        Me.pb3.Size = New System.Drawing.Size(98, 80)
        Me.pb3.TabIndex = 31
        Me.pb3.TabStop = False
        '
        'bntClose
        '
        Me.bntClose.Location = New System.Drawing.Point(352, 287)
        Me.bntClose.Name = "bntClose"
        Me.bntClose.Size = New System.Drawing.Size(133, 35)
        Me.bntClose.TabIndex = 34
        Me.bntClose.Text = "Fermer"
        Me.bntClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(74, 287)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(133, 35)
        Me.btnClear.TabIndex = 32
        Me.btnClear.Text = "Vider"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnPrintReceipt
        '
        Me.btnPrintReceipt.Location = New System.Drawing.Point(213, 287)
        Me.btnPrintReceipt.Name = "btnPrintReceipt"
        Me.btnPrintReceipt.Size = New System.Drawing.Size(133, 35)
        Me.btnPrintReceipt.TabIndex = 33
        Me.btnPrintReceipt.Text = "Imprimer le reçu"
        Me.btnPrintReceipt.UseVisualStyleBackColor = True
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
        'FormRentModems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 338)
        Me.Controls.Add(Me.bntClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrintReceipt)
        Me.Controls.Add(Me.pb3)
        Me.Controls.Add(Me.pb2)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.rbNighthawkAC1900)
        Me.Controls.Add(Me.rbTPLINKArcherC8)
        Me.Controls.Add(Me.rbTPLINKTLWR841N)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormRentModems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Location de modems"
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTax As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rbNighthawkAC1900 As RadioButton
    Friend WithEvents rbTPLINKArcherC8 As RadioButton
    Friend WithEvents rbTPLINKTLWR841N As RadioButton
    Friend WithEvents pb1 As PictureBox
    Friend WithEvents pb2 As PictureBox
    Friend WithEvents pb3 As PictureBox
    Friend WithEvents bntClose As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnPrintReceipt As Button
    Friend WithEvents PrintDocumentReceipt As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialogReceipt As PrintPreviewDialog
End Class
