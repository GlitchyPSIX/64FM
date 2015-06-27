Imports TechLifeForum
Public Class ChatPM
    Friend WithEvents irc As IrcClient
    Public UserPM As String
    Private Sub ChatPM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        irc = New IrcClient("irc.mibbit.com", 6667)
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        irc.SendMessage(UserPM, tbMessage.Text)
        rtbLog.AppendText(irc.Nick + ":" & vbTab & tbMessage.Text + vbCrLf)
        tbMessage.Clear()
        tbMessage.Focus()
        rtbLog.ScrollToCaret()
    End Sub

    Private Sub irc_ChannelMessage(Channel As String, User As String, Message As String) Handles irc.ChannelMessage
        rtbLog.AppendText(User & vbTab + Message & vbNewLine)
        rtbLog.ScrollToCaret()
    End Sub
End Class