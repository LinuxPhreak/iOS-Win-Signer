Imports System.IO

Public Class iOSWinSigner

    Private Sub cbCreate_Click(sender As Object, e As EventArgs) Handles cbCreate.Click
        Dim key As String

        key = tbKey.Text

        Shell(System.Environment.GetEnvironmentVariable("systemdrive") + "\OpenSSL-Win32\bin\openssl genrsa -out " + System.Environment.GetEnvironmentVariable("userprofile") + "\iOS-Keys\" + key + ".key 2048")
        tbciOS.SelectedIndex = 1
    End Sub

    Private Sub tbKey_Leave(sender As Object, e As EventArgs) Handles tbKey.Leave
        lblRequest.Text = tbKey.Text
    End Sub

    Private Sub cbSign_Click(sender As Object, e As EventArgs) Handles cbSign.Click
        Dim key As String
        Dim fname As String
        Dim email As String
        Dim country As String
        Dim signreq As String

        key = tbKey.Text
        fname = tbFName.Text
        email = tbEMail.Text
        country = cbxCountry.Text
        signreq = lblRequest.Text

        If email.Contains("@") And email.Contains(".") Then
            Shell(System.Environment.GetEnvironmentVariable("systemdrive") + "\OpenSSL-Win32\bin\openssl req -new -key " + System.Environment.GetEnvironmentVariable("userprofile") + "\iOS-Keys\" + key + ".key -out " + signreq + ".certSigningRequest -subj " + Chr(34) + "/emailAddress=" + email + ",CN=" + fname + ",C=" + country + Chr(34))
            Upload.Show()
            tbciOS.SelectedIndex = 2
        Else : MessageBox.Show("Invalid E-Mail. Your E-Mail should look like name@example.com")
        End If
    End Sub

    Private Sub cbConvert_Click(sender As Object, e As EventArgs) Handles cbConvert.Click
        OpenCert.InitialDirectory = System.Environment.GetEnvironmentVariable("userprofile") + "\iOS-Keys\"
        OpenCert.Filter = "cer files (*.cer)|*.cer"
        If OpenCert.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            lblFileName.Text = OpenCert.FileName
        End If

        Dim certname As String

        certname = lblFileName.Text
        Shell(System.Environment.GetEnvironmentVariable("systemdrive") + "\OpenSSL-Win32\bin\openssl x509 -in " + certname + "-inform DER -out " + System.Environment.GetEnvironmentVariable("userprofile") + "\iOS-Keys\" + "developer_identity.pem -outform PEM")
        tbciOS.SelectedIndex = 3
    End Sub

    Private Sub cbKeyFile_Click(sender As Object, e As EventArgs) Handles cbKeyFile.Click
        OpenKey.InitialDirectory = System.Environment.GetEnvironmentVariable("userprofile") + "\iOS-Keys\"
        OpenKey.Filter = "key files (*.key)|*.key"
        If OpenKey.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            lblKeyer.Text = OpenKey.FileName
        End If
    End Sub

    Private Sub cbPEM_Click(sender As Object, e As EventArgs) Handles cbPEM.Click
        OpenPEM.InitialDirectory = System.Environment.GetEnvironmentVariable("userprofile") + "\iOS-Keys\"
        OpenPEM.Filter = "pem files (*.pem)|*.pem"
        If OpenPEM.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            lblPEMer.Text = OpenPEM.FileName
        End If
    End Sub

    Private Sub cbP12_Click(sender As Object, e As EventArgs) Handles cbP12.Click
        Dim key As String
        Dim pem As String
        Dim p12 As String
        Dim password As String
        Dim password1 As String

        key = lblKeyer.Text
        pem = lblPEMer.Text
        p12 = tbP12.Text
        password = tbPW.Text
        password1 = tbConfirm.Text

        If password = password1 Then
            If key = "" Or pem = "" Or p12 = "" Then
                MessageBox.Show("You need to select your Key & Pem files")
            Else
                Shell(System.Environment.GetEnvironmentVariable("systemdrive") + "\OpenSSL-Win32\bin\openssl pkcs12 -export -inkey " + key + " -in " + pem + " -out " + System.Environment.GetEnvironmentVariable("userprofile") + "\iOS-Keys\" + p12 + ".p12 -password pass:" + password)
                MessageBox.Show("Great You Can Now Upload to Phone Gap")
            End If
        Else
            MessageBox.Show("Password Doesn't Match")
        End If
    End Sub

    Private Sub iOSWinSigner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Directory.Exists(System.Environment.GetEnvironmentVariable("userprofile") + "\iOS-Keys") Then
            Directory.CreateDirectory(System.Environment.GetEnvironmentVariable("userprofile") + "\iOS-Keys")
        End If
    End Sub
End Class
