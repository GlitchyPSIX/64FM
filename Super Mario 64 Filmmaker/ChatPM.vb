
Imports TechLifeForum

'Public Class ChatPM
'    Friend WithEvents irc As IrcClient
'    Public UserPM As String
'    Public MessagePM As String
'    Private Sub ChatPM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'    End Sub
'    Friend Sub New(User As String)

'        ' This call is required by the designer.
'        InitializeComponent()
'        Me.Text = User
'        UserPM = User

'        ' Add any initialization after the InitializeComponent() call.

'    End Sub
'    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
'        Chat.irc.SendMessage(UserPM, tbMessage.Text)
'        rtbLog.AppendText(Chat.irc.Nick + ":" & vbTab & tbMessage.Text + vbCrLf)
'        tbMessage.Clear()
'        tbMessage.Focus()
'        rtbLog.ScrollToCaret()
'    End Sub

'    Private Sub irc_Message(sender As Object, e As PrivateMessageEventArgs) Handles irc.PrivateMessage
'        If FormWindowState.Minimized Then
'            Dim Notif As New NotiForm(e.From, e.Message)
'            Notif.Show()
'        Else
'            If Me.Text = e.From Then
'                rtbLog.AppendText(UserPM & vbTab + e.Message & vbNewLine)
'                rtbLog.ScrollToCaret()
'            Else
'                'GlitchyPSI: Hey! That means this conversation is NOT WITH YOU!
'            End If
'        End If
'    End Sub
'End Class