<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConnexion = New System.Windows.Forms.Button()
        Me.txtNomUtilisateur = New System.Windows.Forms.TextBox()
        Me.txtMotDePasse = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(647, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(125, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom d'utilisateur"
        '
        'btnConnexion
        '
        Me.btnConnexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnexion.Location = New System.Drawing.Point(241, 265)
        Me.btnConnexion.Name = "btnConnexion"
        Me.btnConnexion.Size = New System.Drawing.Size(135, 45)
        Me.btnConnexion.TabIndex = 5
        Me.btnConnexion.Text = "Se connecter"
        Me.btnConnexion.UseVisualStyleBackColor = True
        '
        'txtNomUtilisateur
        '
        Me.txtNomUtilisateur.Location = New System.Drawing.Point(295, 161)
        Me.txtNomUtilisateur.Name = "txtNomUtilisateur"
        Me.txtNomUtilisateur.Size = New System.Drawing.Size(165, 20)
        Me.txtNomUtilisateur.TabIndex = 2
        '
        'txtMotDePasse
        '
        Me.txtMotDePasse.Location = New System.Drawing.Point(295, 202)
        Me.txtMotDePasse.Name = "txtMotDePasse"
        Me.txtMotDePasse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMotDePasse.Size = New System.Drawing.Size(165, 20)
        Me.txtMotDePasse.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(125, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mot de passe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(124, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(405, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Veuillez vous connecter pour accéder au système"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 390)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMotDePasse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNomUtilisateur)
        Me.Controls.Add(Me.btnConnexion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connexion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConnexion As Button
    Friend WithEvents txtNomUtilisateur As TextBox
    Friend WithEvents txtMotDePasse As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
