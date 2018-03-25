<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Me.lstClients = New System.Windows.Forms.ListBox()
        Me.btnAddNewClient = New System.Windows.Forms.Button()
        Me.btnDeleteClient = New System.Windows.Forms.Button()
        Me.btnEditClient = New System.Windows.Forms.Button()
        Me.gbClientInformation = New System.Windows.Forms.GroupBox()
        Me.txtPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbBusinessClient = New System.Windows.Forms.RadioButton()
        Me.rbStandardClient = New System.Windows.Forms.RadioButton()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RentModemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RentComputersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InternetAccessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrainingPhoneAssistanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnRentComputers = New System.Windows.Forms.Button()
        Me.btnPhoneAssistance = New System.Windows.Forms.Button()
        Me.btnRentModems = New System.Windows.Forms.Button()
        Me.btnInternetAccess = New System.Windows.Forms.Button()
        Me.gbClientInformation.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstClients
        '
        Me.lstClients.FormattingEnabled = True
        Me.lstClients.Location = New System.Drawing.Point(15, 27)
        Me.lstClients.Name = "lstClients"
        Me.lstClients.Size = New System.Drawing.Size(220, 264)
        Me.lstClients.TabIndex = 10
        '
        'btnAddNewClient
        '
        Me.btnAddNewClient.Location = New System.Drawing.Point(252, 257)
        Me.btnAddNewClient.Name = "btnAddNewClient"
        Me.btnAddNewClient.Size = New System.Drawing.Size(68, 36)
        Me.btnAddNewClient.TabIndex = 7
        Me.btnAddNewClient.Text = "Ajouter Client"
        Me.btnAddNewClient.UseVisualStyleBackColor = True
        '
        'btnDeleteClient
        '
        Me.btnDeleteClient.Location = New System.Drawing.Point(326, 257)
        Me.btnDeleteClient.Name = "btnDeleteClient"
        Me.btnDeleteClient.Size = New System.Drawing.Size(68, 36)
        Me.btnDeleteClient.TabIndex = 8
        Me.btnDeleteClient.Text = "Supprimer Client"
        Me.btnDeleteClient.UseVisualStyleBackColor = True
        '
        'btnEditClient
        '
        Me.btnEditClient.Location = New System.Drawing.Point(400, 257)
        Me.btnEditClient.Name = "btnEditClient"
        Me.btnEditClient.Size = New System.Drawing.Size(68, 36)
        Me.btnEditClient.TabIndex = 9
        Me.btnEditClient.Text = "Modifier Client"
        Me.btnEditClient.UseVisualStyleBackColor = True
        '
        'gbClientInformation
        '
        Me.gbClientInformation.Controls.Add(Me.txtPhoneNumber)
        Me.gbClientInformation.Controls.Add(Me.GroupBox1)
        Me.gbClientInformation.Controls.Add(Me.txtEmail)
        Me.gbClientInformation.Controls.Add(Me.Label4)
        Me.gbClientInformation.Controls.Add(Me.Label3)
        Me.gbClientInformation.Controls.Add(Me.txtAddress)
        Me.gbClientInformation.Controls.Add(Me.Label2)
        Me.gbClientInformation.Controls.Add(Me.txtName)
        Me.gbClientInformation.Controls.Add(Me.Label1)
        Me.gbClientInformation.Location = New System.Drawing.Point(241, 27)
        Me.gbClientInformation.Name = "gbClientInformation"
        Me.gbClientInformation.Size = New System.Drawing.Size(239, 224)
        Me.gbClientInformation.TabIndex = 2
        Me.gbClientInformation.TabStop = False
        Me.gbClientInformation.Text = "Information du Client"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(93, 80)
        Me.txtPhoneNumber.Mask = "(999) 000-0000"
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(127, 20)
        Me.txtPhoneNumber.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbBusinessClient)
        Me.GroupBox1.Controls.Add(Me.rbStandardClient)
        Me.GroupBox1.Location = New System.Drawing.Point(93, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 73)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type de client"
        '
        'rbBusinessClient
        '
        Me.rbBusinessClient.AutoSize = True
        Me.rbBusinessClient.Location = New System.Drawing.Point(6, 48)
        Me.rbBusinessClient.Name = "rbBusinessClient"
        Me.rbBusinessClient.Size = New System.Drawing.Size(88, 17)
        Me.rbBusinessClient.TabIndex = 6
        Me.rbBusinessClient.Text = "Client affaires"
        Me.rbBusinessClient.UseVisualStyleBackColor = True
        '
        'rbStandardClient
        '
        Me.rbStandardClient.AutoSize = True
        Me.rbStandardClient.Checked = True
        Me.rbStandardClient.Location = New System.Drawing.Point(6, 25)
        Me.rbStandardClient.Name = "rbStandardClient"
        Me.rbStandardClient.Size = New System.Drawing.Size(95, 17)
        Me.rbStandardClient.TabIndex = 5
        Me.rbStandardClient.TabStop = True
        Me.rbStandardClient.Text = "Client standard"
        Me.rbStandardClient.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(93, 106)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(127, 20)
        Me.txtEmail.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "No Téléphone:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(93, 54)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(127, 20)
        Me.txtAddress.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Addresse:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(93, 28)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(127, 20)
        Me.txtName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom: "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ServicesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(647, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.FileToolStripMenuItem.Text = "Programme"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ServicesToolStripMenuItem
        '
        Me.ServicesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RentModemsToolStripMenuItem, Me.RentComputersToolStripMenuItem, Me.InternetAccessToolStripMenuItem, Me.TrainingPhoneAssistanceToolStripMenuItem})
        Me.ServicesToolStripMenuItem.Name = "ServicesToolStripMenuItem"
        Me.ServicesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ServicesToolStripMenuItem.Text = "Services"
        '
        'RentModemsToolStripMenuItem
        '
        Me.RentModemsToolStripMenuItem.Name = "RentModemsToolStripMenuItem"
        Me.RentModemsToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.RentModemsToolStripMenuItem.Text = "Location de modems"
        '
        'RentComputersToolStripMenuItem
        '
        Me.RentComputersToolStripMenuItem.Name = "RentComputersToolStripMenuItem"
        Me.RentComputersToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.RentComputersToolStripMenuItem.Text = "Location de PC"
        '
        'InternetAccessToolStripMenuItem
        '
        Me.InternetAccessToolStripMenuItem.Name = "InternetAccessToolStripMenuItem"
        Me.InternetAccessToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.InternetAccessToolStripMenuItem.Text = "Accès Internet"
        '
        'TrainingPhoneAssistanceToolStripMenuItem
        '
        Me.TrainingPhoneAssistanceToolStripMenuItem.Name = "TrainingPhoneAssistanceToolStripMenuItem"
        Me.TrainingPhoneAssistanceToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.TrainingPhoneAssistanceToolStripMenuItem.Text = "Assistance téléphonique et coaching"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnRentComputers)
        Me.GroupBox2.Controls.Add(Me.btnPhoneAssistance)
        Me.GroupBox2.Controls.Add(Me.btnRentModems)
        Me.GroupBox2.Controls.Add(Me.btnInternetAccess)
        Me.GroupBox2.Location = New System.Drawing.Point(486, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(155, 266)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Services offerts"
        '
        'btnRentComputers
        '
        Me.btnRentComputers.Location = New System.Drawing.Point(6, 76)
        Me.btnRentComputers.Name = "btnRentComputers"
        Me.btnRentComputers.Size = New System.Drawing.Size(140, 42)
        Me.btnRentComputers.TabIndex = 0
        Me.btnRentComputers.Text = "Location de PC"
        Me.btnRentComputers.UseVisualStyleBackColor = True
        '
        'btnPhoneAssistance
        '
        Me.btnPhoneAssistance.Location = New System.Drawing.Point(6, 172)
        Me.btnPhoneAssistance.Name = "btnPhoneAssistance"
        Me.btnPhoneAssistance.Size = New System.Drawing.Size(140, 42)
        Me.btnPhoneAssistance.TabIndex = 0
        Me.btnPhoneAssistance.Text = "Assistance et coaching"
        Me.btnPhoneAssistance.UseVisualStyleBackColor = True
        '
        'btnRentModems
        '
        Me.btnRentModems.Location = New System.Drawing.Point(6, 28)
        Me.btnRentModems.Name = "btnRentModems"
        Me.btnRentModems.Size = New System.Drawing.Size(140, 42)
        Me.btnRentModems.TabIndex = 0
        Me.btnRentModems.Text = "Location de modems"
        Me.btnRentModems.UseVisualStyleBackColor = True
        '
        'btnInternetAccess
        '
        Me.btnInternetAccess.Location = New System.Drawing.Point(6, 124)
        Me.btnInternetAccess.Name = "btnInternetAccess"
        Me.btnInternetAccess.Size = New System.Drawing.Size(140, 42)
        Me.btnInternetAccess.TabIndex = 0
        Me.btnInternetAccess.Text = "Accès Internet"
        Me.btnInternetAccess.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 305)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbClientInformation)
        Me.Controls.Add(Me.btnEditClient)
        Me.Controls.Add(Me.btnDeleteClient)
        Me.Controls.Add(Me.btnAddNewClient)
        Me.Controls.Add(Me.lstClients)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compagnie Abonnet"
        Me.gbClientInformation.ResumeLayout(False)
        Me.gbClientInformation.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstClients As ListBox
    Friend WithEvents btnAddNewClient As Button
    Friend WithEvents btnDeleteClient As Button
    Friend WithEvents btnEditClient As Button
    Friend WithEvents gbClientInformation As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbBusinessClient As RadioButton
    Friend WithEvents rbStandardClient As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnInternetAccess As Button
    Friend WithEvents txtPhoneNumber As MaskedTextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnRentComputers As Button
    Friend WithEvents btnPhoneAssistance As Button
    Friend WithEvents btnRentModems As Button
    Friend WithEvents RentModemsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RentComputersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InternetAccessToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrainingPhoneAssistanceToolStripMenuItem As ToolStripMenuItem
End Class
