<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iOSWinSigner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(iOSWinSigner))
        Me.main = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbciOS = New System.Windows.Forms.TabControl()
        Me.tbKey = New System.Windows.Forms.TabPage()
        Me.lblRequest = New System.Windows.Forms.Label()
        Me.cbCreate = New System.Windows.Forms.Button()
        Me.tbKeyName = New System.Windows.Forms.TextBox()
        Me.lblKeyName = New System.Windows.Forms.Label()
        Me.lblCreate = New System.Windows.Forms.Label()
        Me.tbRegister = New System.Windows.Forms.TabPage()
        Me.cbSign = New System.Windows.Forms.Button()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.cbxCountry = New System.Windows.Forms.ComboBox()
        Me.tbReMail = New System.Windows.Forms.TextBox()
        Me.lblReMail = New System.Windows.Forms.Label()
        Me.tbEMail = New System.Windows.Forms.TextBox()
        Me.lblEMail = New System.Windows.Forms.Label()
        Me.tbFName = New System.Windows.Forms.TextBox()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.lblSignItInfo = New System.Windows.Forms.Label()
        Me.tbPEM = New System.Windows.Forms.TabPage()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.lblPEM = New System.Windows.Forms.Label()
        Me.cbConvert = New System.Windows.Forms.Button()
        Me.tbP12 = New System.Windows.Forms.TabPage()
        Me.cbP12 = New System.Windows.Forms.Button()
        Me.tbConfirm = New System.Windows.Forms.TextBox()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.lblPW = New System.Windows.Forms.Label()
        Me.tbPW = New System.Windows.Forms.TextBox()
        Me.tbP12Name = New System.Windows.Forms.TextBox()
        Me.lblP12Name = New System.Windows.Forms.Label()
        Me.cbKeyFile = New System.Windows.Forms.Button()
        Me.cbPEM = New System.Windows.Forms.Button()
        Me.lblP12 = New System.Windows.Forms.Label()
        Me.OpenCert = New System.Windows.Forms.OpenFileDialog()
        Me.OpenKey = New System.Windows.Forms.OpenFileDialog()
        Me.lblKeyer = New System.Windows.Forms.Label()
        Me.OpenPEM = New System.Windows.Forms.OpenFileDialog()
        Me.lblPEMer = New System.Windows.Forms.Label()
        Me.main.SuspendLayout()
        Me.tbciOS.SuspendLayout()
        Me.tbKey.SuspendLayout()
        Me.tbRegister.SuspendLayout()
        Me.tbPEM.SuspendLayout()
        Me.tbP12.SuspendLayout()
        Me.SuspendLayout()
        '
        'main
        '
        Me.main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.main.Location = New System.Drawing.Point(0, 0)
        Me.main.Name = "main"
        Me.main.Size = New System.Drawing.Size(478, 24)
        Me.main.TabIndex = 0
        Me.main.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'tbciOS
        '
        Me.tbciOS.Controls.Add(Me.tbKey)
        Me.tbciOS.Controls.Add(Me.tbRegister)
        Me.tbciOS.Controls.Add(Me.tbPEM)
        Me.tbciOS.Controls.Add(Me.tbP12)
        Me.tbciOS.Location = New System.Drawing.Point(0, 27)
        Me.tbciOS.Name = "tbciOS"
        Me.tbciOS.SelectedIndex = 0
        Me.tbciOS.Size = New System.Drawing.Size(478, 237)
        Me.tbciOS.TabIndex = 1
        '
        'tbKey
        '
        Me.tbKey.Controls.Add(Me.lblRequest)
        Me.tbKey.Controls.Add(Me.cbCreate)
        Me.tbKey.Controls.Add(Me.tbKeyName)
        Me.tbKey.Controls.Add(Me.lblKeyName)
        Me.tbKey.Controls.Add(Me.lblCreate)
        Me.tbKey.Location = New System.Drawing.Point(4, 22)
        Me.tbKey.Name = "tbKey"
        Me.tbKey.Padding = New System.Windows.Forms.Padding(3)
        Me.tbKey.Size = New System.Drawing.Size(470, 211)
        Me.tbKey.TabIndex = 0
        Me.tbKey.Text = "Key"
        Me.tbKey.UseVisualStyleBackColor = True
        '
        'lblRequest
        '
        Me.lblRequest.AutoSize = True
        Me.lblRequest.Location = New System.Drawing.Point(40, 149)
        Me.lblRequest.Name = "lblRequest"
        Me.lblRequest.Size = New System.Drawing.Size(39, 13)
        Me.lblRequest.TabIndex = 4
        Me.lblRequest.Text = "Label1"
        Me.lblRequest.Visible = False
        '
        'cbCreate
        '
        Me.cbCreate.Location = New System.Drawing.Point(387, 80)
        Me.cbCreate.Name = "cbCreate"
        Me.cbCreate.Size = New System.Drawing.Size(75, 23)
        Me.cbCreate.TabIndex = 3
        Me.cbCreate.Text = "&Create"
        Me.cbCreate.UseVisualStyleBackColor = True
        '
        'tbKeyName
        '
        Me.tbKeyName.Location = New System.Drawing.Point(73, 82)
        Me.tbKeyName.Name = "tbKeyName"
        Me.tbKeyName.Size = New System.Drawing.Size(290, 20)
        Me.tbKeyName.TabIndex = 2
        '
        'lblKeyName
        '
        Me.lblKeyName.AutoSize = True
        Me.lblKeyName.Location = New System.Drawing.Point(8, 85)
        Me.lblKeyName.Name = "lblKeyName"
        Me.lblKeyName.Size = New System.Drawing.Size(59, 13)
        Me.lblKeyName.TabIndex = 1
        Me.lblKeyName.Text = "Key Name:"
        '
        'lblCreate
        '
        Me.lblCreate.AutoSize = True
        Me.lblCreate.Location = New System.Drawing.Point(80, 14)
        Me.lblCreate.Name = "lblCreate"
        Me.lblCreate.Size = New System.Drawing.Size(321, 13)
        Me.lblCreate.TabIndex = 0
        Me.lblCreate.Text = "Create the iOS Key that will be used with the iOS App your making."
        '
        'tbRegister
        '
        Me.tbRegister.Controls.Add(Me.cbSign)
        Me.tbRegister.Controls.Add(Me.lblCountry)
        Me.tbRegister.Controls.Add(Me.cbxCountry)
        Me.tbRegister.Controls.Add(Me.tbReMail)
        Me.tbRegister.Controls.Add(Me.lblReMail)
        Me.tbRegister.Controls.Add(Me.tbEMail)
        Me.tbRegister.Controls.Add(Me.lblEMail)
        Me.tbRegister.Controls.Add(Me.tbFName)
        Me.tbRegister.Controls.Add(Me.lblFName)
        Me.tbRegister.Controls.Add(Me.lblSignItInfo)
        Me.tbRegister.Location = New System.Drawing.Point(4, 22)
        Me.tbRegister.Name = "tbRegister"
        Me.tbRegister.Padding = New System.Windows.Forms.Padding(3)
        Me.tbRegister.Size = New System.Drawing.Size(470, 211)
        Me.tbRegister.TabIndex = 1
        Me.tbRegister.Text = "Register"
        Me.tbRegister.UseVisualStyleBackColor = True
        '
        'cbSign
        '
        Me.cbSign.Location = New System.Drawing.Point(387, 110)
        Me.cbSign.Name = "cbSign"
        Me.cbSign.Size = New System.Drawing.Size(75, 23)
        Me.cbSign.TabIndex = 8
        Me.cbSign.Text = "Sign"
        Me.cbSign.UseVisualStyleBackColor = True
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(8, 114)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(46, 13)
        Me.lblCountry.TabIndex = 12
        Me.lblCountry.Text = "Country:"
        '
        'cbxCountry
        '
        Me.cbxCountry.FormattingEnabled = True
        Me.cbxCountry.Location = New System.Drawing.Point(74, 112)
        Me.cbxCountry.Name = "cbxCountry"
        Me.cbxCountry.Size = New System.Drawing.Size(121, 21)
        Me.cbxCountry.TabIndex = 7
        '
        'tbReMail
        '
        Me.tbReMail.Location = New System.Drawing.Point(74, 86)
        Me.tbReMail.Name = "tbReMail"
        Me.tbReMail.Size = New System.Drawing.Size(388, 20)
        Me.tbReMail.TabIndex = 6
        '
        'lblReMail
        '
        Me.lblReMail.AutoSize = True
        Me.lblReMail.Location = New System.Drawing.Point(8, 89)
        Me.lblReMail.Name = "lblReMail"
        Me.lblReMail.Size = New System.Drawing.Size(39, 13)
        Me.lblReMail.TabIndex = 9
        Me.lblReMail.Text = "E-Mail:"
        '
        'tbEMail
        '
        Me.tbEMail.Location = New System.Drawing.Point(74, 59)
        Me.tbEMail.Name = "tbEMail"
        Me.tbEMail.Size = New System.Drawing.Size(388, 20)
        Me.tbEMail.TabIndex = 5
        '
        'lblEMail
        '
        Me.lblEMail.AutoSize = True
        Me.lblEMail.Location = New System.Drawing.Point(8, 62)
        Me.lblEMail.Name = "lblEMail"
        Me.lblEMail.Size = New System.Drawing.Size(39, 13)
        Me.lblEMail.TabIndex = 7
        Me.lblEMail.Text = "E-Mail:"
        '
        'tbFName
        '
        Me.tbFName.Location = New System.Drawing.Point(74, 35)
        Me.tbFName.Name = "tbFName"
        Me.tbFName.Size = New System.Drawing.Size(388, 20)
        Me.tbFName.TabIndex = 2
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Location = New System.Drawing.Point(8, 38)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(57, 13)
        Me.lblFName.TabIndex = 1
        Me.lblFName.Text = "Full Name:"
        '
        'lblSignItInfo
        '
        Me.lblSignItInfo.AutoSize = True
        Me.lblSignItInfo.Location = New System.Drawing.Point(74, 15)
        Me.lblSignItInfo.Name = "lblSignItInfo"
        Me.lblSignItInfo.Size = New System.Drawing.Size(361, 13)
        Me.lblSignItInfo.TabIndex = 0
        Me.lblSignItInfo.Text = "Now that you have made the key. You will need to sign it so you can use it."
        '
        'tbPEM
        '
        Me.tbPEM.Controls.Add(Me.lblFileName)
        Me.tbPEM.Controls.Add(Me.lblPEM)
        Me.tbPEM.Controls.Add(Me.cbConvert)
        Me.tbPEM.Location = New System.Drawing.Point(4, 22)
        Me.tbPEM.Name = "tbPEM"
        Me.tbPEM.Size = New System.Drawing.Size(470, 211)
        Me.tbPEM.TabIndex = 2
        Me.tbPEM.Text = "PEM"
        Me.tbPEM.UseVisualStyleBackColor = True
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Location = New System.Drawing.Point(47, 85)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(39, 13)
        Me.lblFileName.TabIndex = 2
        Me.lblFileName.Text = "Label1"
        Me.lblFileName.Visible = False
        '
        'lblPEM
        '
        Me.lblPEM.Location = New System.Drawing.Point(115, 13)
        Me.lblPEM.Name = "lblPEM"
        Me.lblPEM.Size = New System.Drawing.Size(228, 31)
        Me.lblPEM.TabIndex = 1
        Me.lblPEM.Text = "Now that you have your certificate from Apple. You will need to convert it into a" & _
    " PEM Format."
        '
        'cbConvert
        '
        Me.cbConvert.Location = New System.Drawing.Point(183, 178)
        Me.cbConvert.Name = "cbConvert"
        Me.cbConvert.Size = New System.Drawing.Size(75, 23)
        Me.cbConvert.TabIndex = 0
        Me.cbConvert.Text = "Convert"
        Me.cbConvert.UseVisualStyleBackColor = True
        '
        'tbP12
        '
        Me.tbP12.Controls.Add(Me.lblPEMer)
        Me.tbP12.Controls.Add(Me.lblKeyer)
        Me.tbP12.Controls.Add(Me.cbP12)
        Me.tbP12.Controls.Add(Me.tbConfirm)
        Me.tbP12.Controls.Add(Me.lblConfirm)
        Me.tbP12.Controls.Add(Me.lblPW)
        Me.tbP12.Controls.Add(Me.tbPW)
        Me.tbP12.Controls.Add(Me.tbP12Name)
        Me.tbP12.Controls.Add(Me.lblP12Name)
        Me.tbP12.Controls.Add(Me.cbKeyFile)
        Me.tbP12.Controls.Add(Me.cbPEM)
        Me.tbP12.Controls.Add(Me.lblP12)
        Me.tbP12.Location = New System.Drawing.Point(4, 22)
        Me.tbP12.Name = "tbP12"
        Me.tbP12.Size = New System.Drawing.Size(470, 211)
        Me.tbP12.TabIndex = 3
        Me.tbP12.Text = "P12"
        Me.tbP12.UseVisualStyleBackColor = True
        '
        'cbP12
        '
        Me.cbP12.Location = New System.Drawing.Point(162, 178)
        Me.cbP12.Name = "cbP12"
        Me.cbP12.Size = New System.Drawing.Size(105, 23)
        Me.cbP12.TabIndex = 6
        Me.cbP12.Text = "Make P12 File"
        Me.cbP12.UseVisualStyleBackColor = True
        '
        'tbConfirm
        '
        Me.tbConfirm.Location = New System.Drawing.Point(97, 124)
        Me.tbConfirm.Name = "tbConfirm"
        Me.tbConfirm.Size = New System.Drawing.Size(365, 20)
        Me.tbConfirm.TabIndex = 5
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.Location = New System.Drawing.Point(8, 127)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(42, 13)
        Me.lblConfirm.TabIndex = 7
        Me.lblConfirm.Text = "Confirm"
        '
        'lblPW
        '
        Me.lblPW.AutoSize = True
        Me.lblPW.Location = New System.Drawing.Point(8, 101)
        Me.lblPW.Name = "lblPW"
        Me.lblPW.Size = New System.Drawing.Size(53, 13)
        Me.lblPW.TabIndex = 6
        Me.lblPW.Text = "Password"
        '
        'tbPW
        '
        Me.tbPW.Location = New System.Drawing.Point(97, 98)
        Me.tbPW.Name = "tbPW"
        Me.tbPW.Size = New System.Drawing.Size(365, 20)
        Me.tbPW.TabIndex = 4
        '
        'tbP12Name
        '
        Me.tbP12Name.Location = New System.Drawing.Point(241, 60)
        Me.tbP12Name.Name = "tbP12Name"
        Me.tbP12Name.Size = New System.Drawing.Size(221, 20)
        Me.tbP12Name.TabIndex = 3
        '
        'lblP12Name
        '
        Me.lblP12Name.AutoSize = True
        Me.lblP12Name.Location = New System.Drawing.Point(178, 63)
        Me.lblP12Name.Name = "lblP12Name"
        Me.lblP12Name.Size = New System.Drawing.Size(57, 13)
        Me.lblP12Name.TabIndex = 3
        Me.lblP12Name.Text = "P12 Name"
        '
        'cbKeyFile
        '
        Me.cbKeyFile.Location = New System.Drawing.Point(8, 58)
        Me.cbKeyFile.Name = "cbKeyFile"
        Me.cbKeyFile.Size = New System.Drawing.Size(75, 23)
        Me.cbKeyFile.TabIndex = 1
        Me.cbKeyFile.Text = "Key File"
        Me.cbKeyFile.UseVisualStyleBackColor = True
        '
        'cbPEM
        '
        Me.cbPEM.Location = New System.Drawing.Point(97, 58)
        Me.cbPEM.Name = "cbPEM"
        Me.cbPEM.Size = New System.Drawing.Size(75, 23)
        Me.cbPEM.TabIndex = 2
        Me.cbPEM.Text = "PEM File"
        Me.cbPEM.UseVisualStyleBackColor = True
        '
        'lblP12
        '
        Me.lblP12.Location = New System.Drawing.Point(94, 13)
        Me.lblP12.Name = "lblP12"
        Me.lblP12.Size = New System.Drawing.Size(270, 31)
        Me.lblP12.TabIndex = 0
        Me.lblP12.Text = "Now you will need to make a P12 file. To do this you will need both your key file" & _
    " and your PEM file."
        '
        'OpenCert
        '
        Me.OpenCert.FileName = "OpenFileDialog1"
        '
        'OpenKey
        '
        Me.OpenKey.FileName = "OpenFileDialog1"
        '
        'lblKeyer
        '
        Me.lblKeyer.AutoSize = True
        Me.lblKeyer.Location = New System.Drawing.Point(11, 161)
        Me.lblKeyer.Name = "lblKeyer"
        Me.lblKeyer.Size = New System.Drawing.Size(39, 13)
        Me.lblKeyer.TabIndex = 8
        Me.lblKeyer.Text = "Label1"
        Me.lblKeyer.Visible = False
        '
        'OpenPEM
        '
        Me.OpenPEM.FileName = "OpenFileDialog1"
        '
        'lblPEMer
        '
        Me.lblPEMer.AutoSize = True
        Me.lblPEMer.Location = New System.Drawing.Point(304, 160)
        Me.lblPEMer.Name = "lblPEMer"
        Me.lblPEMer.Size = New System.Drawing.Size(39, 13)
        Me.lblPEMer.TabIndex = 9
        Me.lblPEMer.Text = "Label1"
        Me.lblPEMer.Visible = False
        '
        'iOSWinSigner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 262)
        Me.Controls.Add(Me.tbciOS)
        Me.Controls.Add(Me.main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.main
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "iOSWinSigner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "iOS Win Signer"
        Me.main.ResumeLayout(False)
        Me.main.PerformLayout()
        Me.tbciOS.ResumeLayout(False)
        Me.tbKey.ResumeLayout(False)
        Me.tbKey.PerformLayout()
        Me.tbRegister.ResumeLayout(False)
        Me.tbRegister.PerformLayout()
        Me.tbPEM.ResumeLayout(False)
        Me.tbPEM.PerformLayout()
        Me.tbP12.ResumeLayout(False)
        Me.tbP12.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents main As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbciOS As System.Windows.Forms.TabControl
    Friend WithEvents tbKey As System.Windows.Forms.TabPage
    Friend WithEvents cbCreate As System.Windows.Forms.Button
    Friend WithEvents tbKeyName As System.Windows.Forms.TextBox
    Friend WithEvents lblKeyName As System.Windows.Forms.Label
    Friend WithEvents lblCreate As System.Windows.Forms.Label
    Friend WithEvents tbRegister As System.Windows.Forms.TabPage
    Friend WithEvents cbSign As System.Windows.Forms.Button
    Friend WithEvents lblCountry As System.Windows.Forms.Label
    Friend WithEvents cbxCountry As System.Windows.Forms.ComboBox
    Friend WithEvents tbReMail As System.Windows.Forms.TextBox
    Friend WithEvents lblReMail As System.Windows.Forms.Label
    Friend WithEvents tbEMail As System.Windows.Forms.TextBox
    Friend WithEvents lblEMail As System.Windows.Forms.Label
    Friend WithEvents tbFName As System.Windows.Forms.TextBox
    Friend WithEvents lblFName As System.Windows.Forms.Label
    Friend WithEvents lblSignItInfo As System.Windows.Forms.Label
    Friend WithEvents tbPEM As System.Windows.Forms.TabPage
    Friend WithEvents lblPEM As System.Windows.Forms.Label
    Friend WithEvents cbConvert As System.Windows.Forms.Button
    Friend WithEvents tbP12 As System.Windows.Forms.TabPage
    Friend WithEvents cbP12 As System.Windows.Forms.Button
    Friend WithEvents tbConfirm As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirm As System.Windows.Forms.Label
    Friend WithEvents lblPW As System.Windows.Forms.Label
    Friend WithEvents tbPW As System.Windows.Forms.TextBox
    Friend WithEvents tbP12Name As System.Windows.Forms.TextBox
    Friend WithEvents lblP12Name As System.Windows.Forms.Label
    Friend WithEvents cbKeyFile As System.Windows.Forms.Button
    Friend WithEvents cbPEM As System.Windows.Forms.Button
    Friend WithEvents lblP12 As System.Windows.Forms.Label
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblRequest As System.Windows.Forms.Label
    Friend WithEvents lblFileName As System.Windows.Forms.Label
    Friend WithEvents OpenCert As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenKey As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblKeyer As System.Windows.Forms.Label
    Friend WithEvents OpenPEM As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblPEMer As System.Windows.Forms.Label

End Class
