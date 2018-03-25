<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRentComputers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRentComputers))
        Me.bntClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnPrintReceipt = New System.Windows.Forms.Button()
        Me.rbDesktopComputer = New System.Windows.Forms.RadioButton()
        Me.rbNotebook = New System.Windows.Forms.RadioButton()
        Me.rbAppleiPad = New System.Windows.Forms.RadioButton()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pb3 = New System.Windows.Forms.PictureBox()
        Me.pb2 = New System.Windows.Forms.PictureBox()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.PrintDocumentReceipt = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialogReceipt = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bntClose
        '
        Me.bntClose.Location = New System.Drawing.Point(360, 286)
        Me.bntClose.Name = "bntClose"
        Me.bntClose.Size = New System.Drawing.Size(133, 35)
        Me.bntClose.TabIndex = 49
        Me.bntClose.Text = "Fermer"
        Me.bntClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(82, 286)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(133, 35)
        Me.btnClear.TabIndex = 47
        Me.btnClear.Text = "Supprimer"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnPrintReceipt
        '
        Me.btnPrintReceipt.Location = New System.Drawing.Point(221, 286)
        Me.btnPrintReceipt.Name = "btnPrintReceipt"
        Me.btnPrintReceipt.Size = New System.Drawing.Size(133, 35)
        Me.btnPrintReceipt.TabIndex = 48
        Me.btnPrintReceipt.Text = "Imprimer le reçu"
        Me.btnPrintReceipt.UseVisualStyleBackColor = True
        '
        'rbDesktopComputer
        '
        Me.rbDesktopComputer.AutoSize = True
        Me.rbDesktopComputer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.rbDesktopComputer.Location = New System.Drawing.Point(120, 210)
        Me.rbDesktopComputer.Name = "rbDesktopComputer"
        Me.rbDesktopComputer.Size = New System.Drawing.Size(53, 28)
        Me.rbDesktopComputer.TabIndex = 43
        Me.rbDesktopComputer.TabStop = True
        Me.rbDesktopComputer.Text = "PC"
        Me.rbDesktopComputer.UseVisualStyleBackColor = True
        '
        'rbNotebook
        '
        Me.rbNotebook.AutoSize = True
        Me.rbNotebook.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.rbNotebook.Location = New System.Drawing.Point(119, 127)
        Me.rbNotebook.Name = "rbNotebook"
        Me.rbNotebook.Size = New System.Drawing.Size(90, 28)
        Me.rbNotebook.TabIndex = 42
        Me.rbNotebook.TabStop = True
        Me.rbNotebook.Text = " Laptop"
        Me.rbNotebook.UseVisualStyleBackColor = True
        '
        'rbAppleiPad
        '
        Me.rbAppleiPad.AutoSize = True
        Me.rbAppleiPad.Checked = True
        Me.rbAppleiPad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.rbAppleiPad.Location = New System.Drawing.Point(119, 40)
        Me.rbAppleiPad.Name = "rbAppleiPad"
        Me.rbAppleiPad.Size = New System.Drawing.Size(120, 28)
        Me.rbAppleiPad.TabIndex = 41
        Me.rbAppleiPad.TabStop = True
        Me.rbAppleiPad.Text = "Apple iPad"
        Me.rbAppleiPad.UseVisualStyleBackColor = True
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtTotalPrice.Location = New System.Drawing.Point(418, 169)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(100, 26)
        Me.txtTotalPrice.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(314, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Prix Total:"
        '
        'txtTax
        '
        Me.txtTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtTax.Location = New System.Drawing.Point(418, 136)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(100, 26)
        Me.txtTax.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(348, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Taxe %:"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(418, 102)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 26)
        Me.txtPrice.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(355, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 20)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Prix:"
        '
        'pb3
        '
        Me.pb3.BackgroundImage = Global.AbonnentCompany.My.Resources.Resources.PC
        Me.pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pb3.Location = New System.Drawing.Point(15, 183)
        Me.pb3.Name = "pb3"
        Me.pb3.Size = New System.Drawing.Size(98, 80)
        Me.pb3.TabIndex = 44
        Me.pb3.TabStop = False
        '
        'pb2
        '
        Me.pb2.BackgroundImage = Global.AbonnentCompany.My.Resources.Resources.notebook_9_pen___frontrrr
        Me.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pb2.Location = New System.Drawing.Point(15, 97)
        Me.pb2.Name = "pb2"
        Me.pb2.Size = New System.Drawing.Size(98, 80)
        Me.pb2.TabIndex = 45
        Me.pb2.TabStop = False
        '
        'pb1
        '
        Me.pb1.BackgroundImage = Global.AbonnentCompany.My.Resources.Resources.Ipad
        Me.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pb1.Location = New System.Drawing.Point(15, 11)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(98, 80)
        Me.pb1.TabIndex = 46
        Me.pb1.TabStop = False
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
        'frmRentComputers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 331)
        Me.Controls.Add(Me.bntClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrintReceipt)
        Me.Controls.Add(Me.pb3)
        Me.Controls.Add(Me.pb2)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.rbDesktopComputer)
        Me.Controls.Add(Me.rbNotebook)
        Me.Controls.Add(Me.rbAppleiPad)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRentComputers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Location d'ordinateurs"
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bntClose As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnPrintReceipt As Button
    Friend WithEvents pb3 As PictureBox
    Friend WithEvents pb2 As PictureBox
    Friend WithEvents pb1 As PictureBox
    Friend WithEvents rbDesktopComputer As RadioButton
    Friend WithEvents rbNotebook As RadioButton
    Friend WithEvents rbAppleiPad As RadioButton
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTax As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PrintDocumentReceipt As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialogReceipt As PrintPreviewDialog
End Class
