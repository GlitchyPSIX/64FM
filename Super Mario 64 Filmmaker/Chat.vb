Imports TechLifeForum 'Yeah... couldn't change it.
Imports Transitions
Public Class Chat
    Public WithEvents irc As IrcClient
    Dim Frozen As Boolean
    Dim FlashForm As New Transition(New TransitionType_Flash(9, 800))
    Dim userlist As IrcClient.oUserList

    Private Sub ShakeVeryGently()
        'Thanks to LeSaN
        'Easy code to make a form shake

        Dim a As Integer 'Declaring integer "a"

        While a < 15 'Starting a "while loop"

            'Setting our form's X position to 20 pixels to right from its current position.            
            Me.Location = New Point(Me.Location.X, Me.Location.Y + 10)

            'Telling a program to sleep for 50 miliseconds before continuing
            System.Threading.Thread.Sleep(10)

            'Setting our form's X position to 20 pixels to left from its current position.
            Me.Location = New Point(Me.Location.X, Me.Location.Y - 10)

            'Telling a program to sleep for 50 miliseconds before continuing            
            System.Threading.Thread.Sleep(10)

            a += 1 'Increasing integer "a" by 1 after each loop

        End While
    End Sub

    Private Sub ShakeGently()
        'Thanks to LeSaN
        'Easy code to make a form shake

        Dim a As Integer 'Declaring integer "a"

        While a < 10 'Starting a "while loop"

            'Setting our form's X position to 20 'pixels to right from its current position.            
            Me.Location = New Point(Me.Location.X + 20, Me.Location.Y)

            'Telling a program to sleep for 50 miliseconds before continuing
            System.Threading.Thread.Sleep(50)

            'Setting our form's X position to 20 'pixels to left from its current position.
            Me.Location = New Point(Me.Location.X - 20, Me.Location.Y)

            'Telling a program to sleep for 50 miliseconds before continuing            
            System.Threading.Thread.Sleep(50)

            a += 1 'Increasing integer "a" by 1 after each loop

        End While
    End Sub

    Private Sub ShakeViolently()
        'Thanks to LeSaN
        'Easy code to make a form shake

        Dim A As Integer 'Declaring integer "a"

        While A < 10 'Starting a "while loop"

            'Setting our form's X position to 20 pixels to right from its current position.            
            Me.Location = New Point(Me.Location.X - 20, Me.Location.Y - 30)

            'Telling a program to sleep for 50 miliseconds before continuing
            System.Threading.Thread.Sleep(30)

            'Setting our form's X position to 20 pixels to left from its current position.
            Me.Location = New Point(Me.Location.X + 40, Me.Location.Y + 60)

            'Telling a program to sleep for 50 miliseconds before continuing            
            System.Threading.Thread.Sleep(30)

            'Setting our form's X position to 20 pixels to right from its current position.            
            Me.Location = New Point(Me.Location.X + 20, Me.Location.Y + 30)

            'Telling a program to sleep for 50 miliseconds before continuing
            System.Threading.Thread.Sleep(30)

            'Setting our form's X position to 20 pixels to left from its current position.
            Me.Location = New Point(Me.Location.X - 40, Me.Location.Y - 60)

            'Telling a program to sleep for 50 miliseconds before continuing            
            System.Threading.Thread.Sleep(30)

            A += 1 'Increasing integer "a" by 1 after each loop

        End While
    End Sub

    Private Sub btnConnect_Click(sender As System.Object, e As System.EventArgs) Handles btnGoLive.Click
        irc = New IrcClient("irc.mibbit.com", 6667)
        irc.Nick = My.Settings.Name
        irc.Connect()
        My.Computer.Audio.Play(My.Resources.Connected, AudioPlayMode.Background)
        btnGoDead.Enabled = True
        btnGoLive.Enabled = False
        rtbLog.Clear()
        btnNudge.Enabled = True
        btnExplode.Enabled = True
    End Sub

    Private Sub btnSend_Click(sender As System.Object, e As System.EventArgs) Handles btnSend.Click
        If tbMessage.Text.StartsWith("$buzzer") Then
            My.Computer.Audio.Play(My.Resources.Critical, AudioPlayMode.Background)
            ShakeGently()
            irc.SendMessage("#SM64FM", "$buzzer")
            rtbLog.AppendText(irc.Nick + " used a BUZZER!" + vbNewLine)
            tbMessage.Clear()
            tbMessage.Focus()
            rtbLog.ScrollToCaret()
        ElseIf tbMessage.Text.StartsWith("$explosion") Then
            My.Computer.Audio.Play(My.Resources.Explosion, AudioPlayMode.Background)
            ShakeViolently()
            irc.SendMessage("#SM64FM", "$explosion")
            rtbLog.AppendText(irc.Nick + " produced an EXPLOSION!" + vbNewLine)
            tbMessage.Clear()
            tbMessage.Focus()
            rtbLog.ScrollToCaret()
        Else
            My.Computer.Audio.Play(My.Resources.Gotcha, AudioPlayMode.Background)
            irc.SendMessage("#SM64FM", tbMessage.Text)
            rtbLog.AppendText(irc.Nick + ":" & vbTab & tbMessage.Text + vbNewLine)
            tbMessage.Clear()
            tbMessage.Focus()
            rtbLog.ScrollToCaret()
        End If
    End Sub

    Private Sub tbMessage_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles tbMessage.KeyDown
        If e.KeyCode = Keys.Enter And btnSend.Enabled = True Then
            btnSend.PerformClick()
        End If
    End Sub

    Private Sub irc_UserJoin(Channel As String, User As String) Handles irc.UserJoined
        My.Computer.Audio.Play(My.Resources.Connected, AudioPlayMode.Background)
        rtbLog.AppendText(User + " has joined the chatroom." + vbNewLine)
        lstUsers.Items.Add(User)
    End Sub

    Private Sub irc_UserLeave(Channel As String, User As String) Handles irc.UserLeft
        My.Computer.Audio.Play(My.Resources.Disconnect, AudioPlayMode.Background)
        rtbLog.AppendText(User + " has left the chatroom." + vbNewLine)
        lstUsers.Items.Remove(User)
    End Sub

    Private Sub irc_ChannelMessage(Channel As String, User As String, Message As String) Handles irc.ChannelMessage
        If Message.ToString.StartsWith("$buzzer") Then
            My.Computer.Audio.Play(My.Resources.Critical, AudioPlayMode.Background)
            ShakeGently()
            rtbLog.AppendText(User + " used a BUZZER!" & vbNewLine)
            rtbLog.ScrollToCaret()
        ElseIf Message.ToString.StartsWith("$explosion") Then
            My.Computer.Audio.Play(My.Resources.Explosion, AudioPlayMode.Background)
            ShakeViolently()
            rtbLog.AppendText(User + " produced an EXPLOSION!" & vbNewLine)
            rtbLog.ScrollToCaret()
        ElseIf Message.ToString.StartsWith("$kick") Then
            If Message.ToString.Contains(My.Settings.Name) Then
                irc.Disconnect()
                MsgBox("You have been kicked. Please be nice next time.")
                Me.Close()
            End If
        ElseIf Message.ToString.StartsWith("$freeze") Then
            If Message.ToString.Contains(My.Settings.Name) Then
                Me.BackgroundImage = My.Resources.froze
                Me.BackgroundImageLayout = ImageLayout.Stretch
                My.Computer.Audio.Play(My.Resources.Frozen, AudioPlayMode.Background)
                MsgBox("You have been frozen. Someone must unfreeze you in order to continue chatting.")
                btnSend.Enabled = False
                Frozen = True
            End If
        ElseIf Message.ToString.StartsWith("$unfreeze") And Frozen = True Then
            Me.BackgroundImage = Nothing
            If Message.ToString.Contains(My.Settings.Name) Then
                MsgBox("You have been unfrozen. Congratulations.")
                btnSend.Enabled = True
                Frozen = False
            End If
        Else
            If Message.ToString.Contains(":O") Or Message.ToString.Contains("!?") Then
                My.Computer.Audio.Play(My.Resources.Surprise, AudioPlayMode.Background)
                rtbLog.AppendText(User + ":" & vbTab + Message & vbNewLine)
                rtbLog.ScrollToCaret()
            ElseIf Message.ToString.Contains("Idea!") Or Message.ToString.Contains("idea") Or Message.ToString.Contains("!") Then
                My.Computer.Audio.Play(My.Resources.Idea, AudioPlayMode.Background)
                rtbLog.AppendText(User + ":" & vbTab + Message & vbNewLine)
                rtbLog.ScrollToCaret()
            ElseIf Message.ToString.Contains("?") Then
                My.Computer.Audio.Play(My.Resources.Question, AudioPlayMode.Background)
                rtbLog.AppendText(User + ":" & vbTab + Message & vbNewLine)
                rtbLog.ScrollToCaret()
            ElseIf Message.ToString.Contains("Well done!") Or Message.ToString.Contains("nice") Then
                My.Computer.Audio.Play(My.Resources.HighScore, AudioPlayMode.Background)
                rtbLog.AppendText(User + ":" & vbTab + Message & vbNewLine)
                rtbLog.ScrollToCaret()
            ElseIf Message.ToString.Contains("yes") Or Message.ToString.Contains("yup") Or Message.ToString.Contains("Yup") Or Message.ToString.Contains("Yes") Then
                My.Computer.Audio.Play(My.Resources.Yes, AudioPlayMode.Background)
                rtbLog.AppendText(User + ":" & vbTab + Message & vbNewLine)
                rtbLog.ScrollToCaret()
            ElseIf Message.ToString.Contains(" no") Or Message.ToString.Contains(" nope") Or Message.ToString.Contains(" Nope") Or Message.ToString.Contains("No") Then
                My.Computer.Audio.Play(My.Resources.No, AudioPlayMode.Background)
                rtbLog.AppendText(User + ":" & vbTab + Message & vbNewLine)
                rtbLog.ScrollToCaret()
            ElseIf Message.ToString.Contains("Oh!") Or Message.ToString.Contains("I see") Or Message.ToString.Contains("Ooh!") Or Message.ToString.Contains("Yes!") Then
                My.Computer.Audio.Play(My.Resources.Gotcha, AudioPlayMode.Background)
                rtbLog.AppendText(User + ":" & vbTab + Message & vbNewLine)
                rtbLog.ScrollToCaret()
            Else
                My.Computer.Audio.Play(My.Resources.Message, AudioPlayMode.Background)
                rtbLog.AppendText(User + ":" & vbTab + Message & vbNewLine)
                rtbLog.ScrollToCaret()
            End If
        End If
    End Sub

    Private Sub irc_ExceptionThrown(ex As System.Exception) Handles irc.ExceptionThrown
        MessageBox.Show(ex.Message)
    End Sub

    Private Sub irc_OnConnect() Handles irc.OnConnect
        rtbLog.AppendText("Connected to server!" & vbNewLine)
        irc.JoinChannel("#SM64FM")
        tbMessage.Enabled = True
        btnGoDead.Enabled = True
        btnSend.Enabled = True
        ExplosionCooldownControl.Interval = 1000
        BuzzerCooldownControl.Interval = 1000
        ExplosionCooldownControl.Start()
        BuzzerCooldownControl.Start()
    End Sub

    Private Sub irc_ServerMessage(message As String) Handles irc.ServerMessage
        'rtbLog.AppendText(message & vbNewLine)
        rtbLog.ScrollToCaret()
    End Sub

    Private Sub irc_UpdateUsers(Channel As String, userlist() As String) Handles irc.UpdateUsers
        lstUsers.Items.Clear()
        lstUsers.Items.AddRange(userlist)
    End Sub

    Private Sub Chat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshList.Interval = 500
        RefreshList.Start()
        tbMessage.Enabled = False
        btnExplode.Enabled = False
        btnGoDead.Enabled = False
        btnNudge.Enabled = False
        btnSend.Enabled = False
        lbNick.Text = "Your nickname is:" + vbCrLf + My.Settings.Name
        BuzzerTooltip.SetToolTip(btnNudge, "Throws a buzz that inflicts a gentle nudge in the whole room you're chatting on, avoiding everyone from typing. (Cooldown 6s)")
        ExplosionToolTip.SetToolTip(btnExplode, "Throws an explosion that inflicts a severily big nudge in the whole room you're chatting on, avoiding everyone from typing. (Cooldown 20s)")
    End Sub

    Private Sub btnGoDead_Click(sender As Object, e As EventArgs) Handles btnGoDead.Click
        My.Computer.Audio.Play(My.Resources.Disconnect, AudioPlayMode.Background)
        lstUsers.Items.Clear()
        irc.Disconnect()
        rtbLog.Clear()
        ExplosionCooldownControl.Stop()
        BuzzerCooldownControl.Stop()
        tbMessage.Enabled = False
        btnSend.Enabled = False
        btnNudge.Enabled = False
        btnExplode.Enabled = False
        btnGoDead.Enabled = False
        btnGoLive.Enabled = True
    End Sub

    Private Sub Nudge_Click(sender As Object, e As EventArgs) Handles btnNudge.Click
        tbMessage.Text = "$buzzer"
        btnSend.PerformClick()
        NudgeCooldown.Value = 0
    End Sub

    Private Sub Explode_Click(sender As Object, e As EventArgs) Handles btnExplode.Click
        tbMessage.Text = "$explosion"
        btnSend.PerformClick()
        ExplodeCooldown.Value = 0
    End Sub

    Private Sub BuzzerCooldownControl_Tick(sender As Object, e As EventArgs) Handles BuzzerCooldownControl.Tick
        If Frozen = False Then
            If NudgeCooldown.Value < 6 Then
                btnNudge.Enabled = False
                NudgeCooldown.Value += 1
            ElseIf NudgeCooldown.Value = 6 Then
                btnNudge.Enabled = True
            End If
        ElseIf Frozen = True Then
            btnNudge.Enabled = False
            NudgeCooldown.Value = 0
        End If
    End Sub

    Private Sub ExplosionCooldownControl_Tick(sender As Object, e As EventArgs) Handles ExplosionCooldownControl.Tick
        If Frozen = False Then
            If ExplodeCooldown.Value < 20 Then
                btnExplode.Enabled = False
                ExplodeCooldown.Value += 1
            ElseIf ExplodeCooldown.Value = 20 Then
                btnExplode.Enabled = True
            End If
        ElseIf Frozen = True Then
            btnExplode.Enabled = False
            ExplodeCooldown.Value = 0
        End If
    End Sub
End Class