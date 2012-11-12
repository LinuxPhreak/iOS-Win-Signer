Public Class Upload

    Private Sub Upload_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDone.Text = "Your Signing Key is now made. You can find it in " + System.Environment.GetEnvironmentVariable("userprofile") + " it will be called " + iOSWinSigner.lblRequest.Text + ".certSigningRequest You should upload it to http://developer.apple.com/ios/manage/certificates/team/index.action"
    End Sub
End Class