Public Class ExceptionUnhandledForm

    Private Sub btnCopy_Click(sender As System.Object, e As System.EventArgs) Handles btnCopy.Click

        My.Computer.Clipboard.Clear()
        My.Computer.Clipboard.SetText(rtbException.Text, TextDataFormat.Text)
        My.Computer.Clipboard.SetText(rtbException.Rtf, TextDataFormat.Rtf)

    End Sub
    Private Sub ExceptionUnhandledForm_Load(sender As Object, ex As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.RoyalBlue
        Me.BackgroundImage = My.Resources.froze ' I will make a "Crackled Down" one
        rtbException.AppendText("OS: " + My.Computer.Info.OSFullName + vbNewLine + vbNewLine)
        rtbException.AppendText(UnhandledExceptionString)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles IssueTrackerLink.LinkClicked
        Process.Start("https://github.com/Starlight-Project/SM64FM/issues/new")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Application.Restart()
    End Sub
End Class
