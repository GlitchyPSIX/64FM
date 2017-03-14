'Imports TechLifeForum 'Yeah... couldn't change it.
'Imports Transitions
'Public Class Chat
'    Public WithEvents irc As IrcClient
'    Dim Frozen As Boolean
'    Dim DirectSubjectResult As String ' Direct Command Controller

'#Region "Shakes"
'    Private Sub ShakeVeryGently(Speed As Integer) 'lel forgot to edit this commentary
'        'Thanks to LeSaN
'        'Easy code to make a form shake

'        Dim a As Integer 'Declare integer "A"

'        While a < 15 'Starting a "while loop"

'            'Setting our form's X position to 20 pixels to right from its current position.            
'            Me.Location = New Point(Me.Location.X, Me.Location.Y + 10)

'            'Telling a program to sleep for Speed miliseconds before continuing
'            System.Threading.Thread.Sleep(Speed)

'            'Setting our form's X position to 20 pixels to left from its current position.
'            Me.Location = New Point(Me.Location.X, Me.Location.Y - 10)

'            'Telling a program to sleep for 50 miliseconds before continuing            
'            System.Threading.Thread.Sleep(Speed)

'            a += 1 'Increasing integer "A" by 1 after each loop

'        End While
'    End Sub

'    Private Sub ShakeGently(Speed As Integer)
'        'Thanks to LeSaN
'        'Easy code to make a form shake

'        Dim a As Integer 'Declare integer "A"

'        While a < 10 'Starting a "while loop"

'            'Setting our form's X position to 20 pixels to right from its current position.            
'            Me.Location = New Point(Me.Location.X + 20, Me.Location.Y)

'            'Telling a program to sleep for 50 miliseconds before continuing
'            System.Threading.Thread.Sleep(Speed)

'            'Setting our form's X position to 20 pixels to left from its current position.
'            Me.Location = New Point(Me.Location.X - 20, Me.Location.Y)

'            'Telling a program to sleep for 50 miliseconds before continuing            
'            System.Threading.Thread.Sleep(Speed)

'            a += 1 'Increasing integer "A" by 1 after each loop

'        End While
'    End Sub

'    Private Sub ShakeViolently(Speed As Integer)
'        'Thanks to LeSaN
'        'Easy code to make a form shake

'        Dim A As Integer 'Declare integer "A"

'        While A < 10 'Starting a "while loop"

'            'Setting our form's X position to 20 pixels to right from its current position.            
'            Me.Location = New Point(Me.Location.X - 20, Me.Location.Y - 30)

'            'Telling a program to sleep for 50 miliseconds before 'continuing
'            System.Threading.Thread.Sleep(Speed)

'            'Setting our form's X position to 20 pixels to left from its current position.
'            Me.Location = New Point(Me.Location.X + 40, Me.Location.Y + 60)

'            'Telling a program to sleep for 50 miliseconds before continuing            
'            System.Threading.Thread.Sleep(Speed)

'            'Setting our form's X position to 20 pixels to right from its current position.            
'            Me.Location = New Point(Me.Location.X + 20, Me.Location.Y + 30)

'            'Telling a program to sleep for 50 miliseconds before continuing
'            System.Threading.Thread.Sleep(Speed)

'            'Setting our form's X position to 20 pixels to left from its current position.
'            Me.Location = New Point(Me.Location.X - 40, Me.Location.Y - 60)

'            'Telling a program to sleep for 50 miliseconds before continuing            
'            System.Threading.Thread.Sleep(Speed)

'            A += 1 'Increasing integer "A" by 1 after each loop
'        End While
'    End Sub

'    Private Sub DoWomboCombo()
'        My.Computer.Audio.Play(My.Resources.Punch, AudioPlayMode.Background)
'        ShakeVeryGently(10)
'        My.Computer.Audio.Play(My.Resources.Punch, AudioPlayMode.Background)
'        ShakeGently(10)
'        My.Computer.Audio.Play(My.Resources.GiveCrit, AudioPlayMode.Background)
'        ShakeViolently(25)
'    End Sub

'    Private Sub ReceiveWomboCombo()
'        My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)
'        ShakeVeryGently(10)
'        My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)
'        ShakeGently(10)
'        My.Computer.Audio.Play(My.Resources.Crit, AudioPlayMode.Background)
'        ShakeViolently(30)
'    End Sub
'#End Region

'    Private Sub btnConnect_Click(sender As System.Object, e As System.EventArgs) Handles btnConnect.Click
'        irc = New IrcClient("irc.mibbit.com", 6667)
'        irc.Nick = My.Settings.Name
'        irc.Connect()
'        My.Computer.Audio.Play(My.Resources.Connected, AudioPlayMode.Background)
'        btnDisconnect.Enabled = True
'        btnConnect.Enabled = False
'        rtbLog.Clear()
'        btnNudge.Enabled = True
'        btnExplode.Enabled = True
'        btnSend.Enabled = True
'    End Sub

'    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
'        My.Computer.Audio.Play(My.Resources.Disconnect, AudioPlayMode.Background)
'        irc.Disconnect()
'        rtbLog.Clear()
'        lstUsers.Items.Clear()
'        btnDisconnect.Enabled = False
'        btnConnect.Enabled = True
'        btnSend.Enabled = False
'    End Sub

'    Private Sub btnSend_Click(sender As System.Object, e As System.EventArgs) Handles btnSend.Click
'        If btnSend.Enabled = True Then
'            If tbMessage.Text.StartsWith("$buzzer", StringComparison.OrdinalIgnoreCase) Then
'                NudgeCooldown.Value = 0
'                My.Computer.Audio.Play(My.Resources.Critical, AudioPlayMode.Background)
'                irc.SendMessage("#SM64FM", "$buzzer")
'                rtbLog.AppendText(irc.Nick + " used a BUZZER!" + vbNewLine)
'                ShakeVeryGently(10)
'                tbMessage.Clear()
'                tbMessage.Focus()
'                rtbLog.ScrollToCaret()
'            ElseIf tbMessage.Text.StartsWith("$explosion", StringComparison.OrdinalIgnoreCase) Then
'                ExplodeCooldown.Value = 0
'                My.Computer.Audio.Play(My.Resources.Explosion, AudioPlayMode.Background)
'                irc.SendMessage("#SM64FM", "$explosion")
'                rtbLog.AppendText(irc.Nick + " produced an EXPLOSION!" + vbNewLine)
'                ShakeGently(50)
'                tbMessage.Clear()
'                tbMessage.Focus()
'                rtbLog.ScrollToCaret()
'            ElseIf tbMessage.Text.StartsWith("$freeze ", StringComparison.OrdinalIgnoreCase) Then
'                My.Computer.Audio.Play(My.Resources.Question, AudioPlayMode.Background)
'                DirectSubjectResult = (tbMessage.Text.Replace("$freeze ", ""))
'                Dim User As String = Split(DirectSubjectResult, " ")(0)
'                If User = "" Or User = " " Then
'                    My.Computer.Audio.Play(My.Resources.No, AudioPlayMode.Background)
'                    rtbLog.AppendText("You cooled the air a bit inside this chatroom." + vbNewLine)
'                Else
'                    rtbLog.AppendText(irc.Nick + " froze " + User + "!" + vbNewLine)
'                End If
'                irc.SendMessage("#SM64FM", tbMessage.Text)
'                tbMessage.Clear()
'                tbMessage.Focus()
'                rtbLog.ScrollToCaret()
'            ElseIf tbMessage.Text.StartsWith("$unfreeze ", StringComparison.OrdinalIgnoreCase) Then
'                My.Computer.Audio.Play(My.Resources.Question, AudioPlayMode.Background)
'                DirectSubjectResult = (tbMessage.Text.Replace("$unfreeze ", ""))
'                irc.SendMessage("#SM64FM", tbMessage.Text)
'                Dim User As String = Split(DirectSubjectResult, " ")(0)
'                If User = "" Or User = " " Then
'                    My.Computer.Audio.Play(My.Resources.No, AudioPlayMode.Background)
'                    rtbLog.AppendText("You warmed the air a bit inside this chatroom." + vbNewLine)
'                Else
'                    rtbLog.AppendText(irc.Nick + " unfroze " + User + "!" + vbNewLine)
'                End If
'                tbMessage.Clear()
'                tbMessage.Focus()
'                rtbLog.ScrollToCaret()
'            ElseIf tbMessage.Text.StartsWith("$punch ", StringComparison.OrdinalIgnoreCase) Then
'                My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)
'                DirectSubjectResult = (tbMessage.Text.Replace("$punch ", ""))
'                Dim User As String = Split(DirectSubjectResult, " ")(0)
'                Dim Reason = DirectSubjectResult.TrimStart(User.ToCharArray)
'                If User = "" Or User = " " Then
'                    My.Computer.Audio.Play(My.Resources.No, AudioPlayMode.Background)
'                    rtbLog.AppendText("You didn't punch anybody." + vbNewLine)
'                Else
'                    If Reason = "" Or Reason = " " Then
'                        rtbLog.AppendText(irc.Nick + " punched " + User + " for no reason." + vbNewLine)
'                    Else
'                        rtbLog.AppendText(irc.Nick + " punched " + User + " because " + Reason + vbNewLine)
'                    End If
'                End If
'                irc.SendMessage("#SM64FM", tbMessage.Text)
'                tbMessage.Clear()
'                tbMessage.Focus()
'                rtbLog.ScrollToCaret()
'                ShakeVeryGently(10)
'            ElseIf tbMessage.Text.StartsWith("$wombocombo ", StringComparison.OrdinalIgnoreCase) Then
'                DirectSubjectResult = (tbMessage.Text.Replace("$wombocombo ", ""))
'                Dim User As String = Split(DirectSubjectResult, " ")(0)
'                Dim Reason = DirectSubjectResult.TrimStart(User.ToCharArray)
'                If User = "" Or User = " " Then
'                    My.Computer.Audio.Play(My.Resources.No, AudioPlayMode.Background)
'                    rtbLog.AppendText("You didn't combo anybody." + vbNewLine)
'                Else
'                    If Reason = "" Or Reason = " " Then
'                        rtbLog.AppendText(irc.Nick + " WOMBO COMBO'D " + User + " for no reason." + vbNewLine)
'                    Else
'                        rtbLog.AppendText(irc.Nick + " WOMBO COMBO'D " + User + " because " + Reason + vbNewLine)
'                    End If
'                End If
'                irc.SendMessage("#SM64FM", tbMessage.Text)
'                tbMessage.Clear()
'                tbMessage.Focus()
'                rtbLog.ScrollToCaret()
'                DoWomboCombo()
'            ElseIf tbMessage.Text.StartsWith("$pm ", StringComparison.OrdinalIgnoreCase) Then
'                'Thanks to James Pelster for showing me Split()
'                DirectSubjectResult = (tbMessage.Text.Replace("$pm ", ""))
'                Dim User As String = Split(DirectSubjectResult, " ")(0)
'                Dim Message = DirectSubjectResult.TrimStart(User.ToCharArray)
'                irc.SendMessage(User, Message)
'                rtbLog.AppendText(irc.Nick + " (to " + User + ")" + Message + vbNewLine)
'                tbMessage.Clear()
'                tbMessage.Focus()
'                rtbLog.ScrollToCaret()
'            ElseIf tbMessage.Text.StartsWith("$directbuzzer ", StringComparison.OrdinalIgnoreCase) Then
'                NudgeCooldown.Value = 0
'                DirectSubjectResult = (tbMessage.Text.Replace("$directbuzzer ", ""))
'                Dim User As String = Split(DirectSubjectResult, " ")(0)
'                Dim Message = DirectSubjectResult.TrimStart(User.ToCharArray)
'                If User = "" Or User = " " Then
'                    My.Computer.Audio.Play(My.Resources.No, AudioPlayMode.Background)
'                    rtbLog.AppendText("You didn't buzz anybody.")
'                Else
'                    If Message = "" Or Message = " " Then
'                        rtbLog.AppendText(irc.Nick + "[DIRECT BUZZER]" + vbNewLine)
'                    Else
'                        rtbLog.AppendText(irc.Nick + "[DIRECT BUZZER] :" + Message + vbNewLine)
'                    End If
'                End If
'                My.Computer.Audio.Play(My.Resources.Critical, AudioPlayMode.Background)
'                irc.SendMessage(User, Message)
'                ShakeVeryGently(10)
'                tbMessage.Clear()
'                tbMessage.Focus()
'                rtbLog.ScrollToCaret()
'            ElseIf tbMessage.Text.StartsWith("$kick ", StringComparison.OrdinalIgnoreCase) Then
'                DirectSubjectResult = (tbMessage.Text.Replace("$kick ", ""))
'                Dim User As String = Split(DirectSubjectResult, " ")(0)
'                Dim Reason = DirectSubjectResult.TrimStart(User.ToCharArray)

'                If User = "" Or User = " " Then
'                    My.Computer.Audio.Play(My.Resources.No, AudioPlayMode.Background)
'                    rtbLog.AppendText("You didn't kick anybody.")
'                Else
'                    If Reason = "" Or Reason = " " Then
'                        rtbLog.AppendText(irc.Nick + " Kicked " + User + " for no reason." + vbNewLine)
'                    Else
'                        rtbLog.AppendText(irc.Nick + " Kicked " + User + " because " + Reason & vbNewLine)
'                    End If
'                End If
'                My.Computer.Audio.Play(My.Resources.Question, AudioPlayMode.Background)
'                irc.SendMessage("#SM64FM", tbMessage.Text)
'                tbMessage.Clear()
'                tbMessage.Focus()
'                rtbLog.ScrollToCaret()
'            Else
'                If tbMessage.Text.Contains(":O") Or tbMessage.Text.Contains("!?") Then
'                    My.Computer.Audio.Play(My.Resources.Surprise, AudioPlayMode.Background)
'                    rtbLog.AppendText(irc.Nick + ":" & vbTab + tbMessage.Text & vbNewLine)
'                    irc.SendMessage("#SM64FM", tbMessage.Text)
'                    tbMessage.Clear()
'                    tbMessage.Focus()
'                    rtbLog.ScrollToCaret()
'                ElseIf tbMessage.Text.Contains("Idea!") Or tbMessage.Text.Contains("idea") Or tbMessage.Text.Contains("!") Then
'                    My.Computer.Audio.Play(My.Resources.Idea, AudioPlayMode.Background)
'                    rtbLog.AppendText(irc.Nick + ":" & vbTab + tbMessage.Text & vbNewLine)
'                    irc.SendMessage("#SM64FM", tbMessage.Text)
'                    tbMessage.Clear()
'                    tbMessage.Focus()
'                    rtbLog.ScrollToCaret()
'                ElseIf tbMessage.Text.Contains("?") Then
'                    My.Computer.Audio.Play(My.Resources.Question, AudioPlayMode.Background)
'                    rtbLog.AppendText(irc.Nick + ":" & vbTab + tbMessage.Text & vbNewLine)
'                    irc.SendMessage("#SM64FM", tbMessage.Text)
'                    tbMessage.Clear()
'                    tbMessage.Focus()
'                    rtbLog.ScrollToCaret()
'                ElseIf tbMessage.Text.Contains("Well done!") Or tbMessage.Text.Contains("nice") Then
'                    My.Computer.Audio.Play(My.Resources.HighScore, AudioPlayMode.Background)
'                    rtbLog.AppendText(irc.Nick + ":" & vbTab + tbMessage.Text & vbNewLine)
'                    irc.SendMessage("#SM64FM", tbMessage.Text)
'                    tbMessage.Clear()
'                    tbMessage.Focus()
'                    rtbLog.ScrollToCaret()
'                ElseIf tbMessage.Text.Contains("yes") Or tbMessage.Text.Contains("yup") Or tbMessage.Text.Contains("Yup") Or tbMessage.Text.Contains("Yes") Then
'                    My.Computer.Audio.Play(My.Resources.Yes, AudioPlayMode.Background)
'                    rtbLog.AppendText(irc.Nick + ":" & vbTab + tbMessage.Text & vbNewLine)
'                    irc.SendMessage("#SM64FM", tbMessage.Text)
'                    tbMessage.Clear()
'                    tbMessage.Focus()
'                    rtbLog.ScrollToCaret()
'                ElseIf tbMessage.Text.StartsWith("no") Or tbMessage.Text.Contains(" nope") Or tbMessage.Text.Contains(" Nope") Or tbMessage.Text.Contains("No.") Then
'                    My.Computer.Audio.Play(My.Resources.No, AudioPlayMode.Background)
'                    rtbLog.AppendText(irc.Nick + ":" & vbTab + tbMessage.Text & vbNewLine)
'                    irc.SendMessage("#SM64FM", tbMessage.Text)
'                    tbMessage.Clear()
'                    tbMessage.Focus()
'                    rtbLog.ScrollToCaret()
'                ElseIf tbMessage.Text.Contains("Oh!") Or tbMessage.Text.Contains("I see") Or tbMessage.Text.Contains("Ooh!") Or tbMessage.Text.Contains("Yes!") Then
'                    My.Computer.Audio.Play(My.Resources.Gotcha, AudioPlayMode.Background)
'                    rtbLog.AppendText(irc.Nick + ":" & vbTab + tbMessage.Text & vbNewLine)
'                    irc.SendMessage("#SM64FM", tbMessage.Text)
'                    tbMessage.Clear()
'                    tbMessage.Focus()
'                    rtbLog.ScrollToCaret()
'                Else
'                    My.Computer.Audio.Play(My.Resources.Gotcha, AudioPlayMode.Background)
'                    irc.SendMessage("#SM64FM", tbMessage.Text)
'                    rtbLog.AppendText(irc.Nick + ":" & vbTab & tbMessage.Text + vbNewLine)
'                    tbMessage.Clear()
'                    tbMessage.Focus()
'                    rtbLog.ScrollToCaret()
'                End If
'            End If
'        End If
'    End Sub

'    Private Sub irc_ChannelMessage(Channel As String, User As String, Message As String) Handles irc.ChannelMessage
'        If Message.ToString.StartsWith("$buzzer", StringComparison.OrdinalIgnoreCase) Then
'            My.Computer.Audio.Play(My.Resources.Critical, AudioPlayMode.Background)
'            ShakeGently(20)
'            rtbLog.AppendText(User + " used a BUZZER!" & vbNewLine)
'            rtbLog.ScrollToCaret()
'        ElseIf Message.ToString.StartsWith("$explosion", StringComparison.OrdinalIgnoreCase) Then
'            My.Computer.Audio.Play(My.Resources.Explosion, AudioPlayMode.Background)
'            ExplodeCooldown.Value = 0
'            ShakeViolently(30)
'            rtbLog.AppendText(User + " produced an EXPLOSION!" & vbNewLine)
'            rtbLog.ScrollToCaret()
'        ElseIf Message.ToString.StartsWith("$kick ", StringComparison.OrdinalIgnoreCase) Then
'            If Message.ToString.Contains(My.Settings.Name) Then
'                DirectSubjectResult = (Message.Replace("$kick ", ""))
'                Dim FirstTrim As String = Split(DirectSubjectResult, " ")(0)
'                Dim ReasonTrim = DirectSubjectResult.TrimStart(FirstTrim.ToCharArray)
'                irc.Disconnect()
'                My.Computer.Audio.Play(My.Resources.Surprise, AudioPlayMode.Background)
'                If ReasonTrim = "" Or ReasonTrim = " " Then
'                    MsgBox(User + " has kicked you for no reason")
'                Else
'                    MsgBox(User + " has kicked you. Reason: " + vbCrLf + ReasonTrim)
'                End If
'                Me.Close()
'            Else
'                DirectSubjectResult = (Message.Replace("$kick ", ""))
'                DirectSubjectResult = (tbMessage.Text.Replace("$kick ", ""))
'                Dim AffectedUser As String = Split(DirectSubjectResult, " ")(0)
'                Dim Reason = DirectSubjectResult.TrimStart(AffectedUser.ToCharArray)

'                If AffectedUser = "" Or AffectedUser = " " Then
'                    My.Computer.Audio.Play(My.Resources.No, AudioPlayMode.Background)
'                    rtbLog.AppendText(User + " didn't kick anybody.")
'                Else
'                    If Reason = "" Or Reason = " " Then
'                        rtbLog.AppendText(User + " Kicked " + AffectedUser + " for no reason." + vbNewLine)
'                    Else
'                        rtbLog.AppendText(User + " Kicked " + AffectedUser + " because " + Reason & vbNewLine)
'                    End If
'                    My.Computer.Audio.Play(My.Resources.Surprise, AudioPlayMode.Background)
'                End If
'            End If
'        ElseIf Message.ToString.StartsWith("$freeze ", StringComparison.OrdinalIgnoreCase) Then
'            If Message.ToString.Contains(My.Settings.Name) Then
'                DirectSubjectResult = (Message.Replace("$freeze ", ""))
'                Dim FirstTrim As String = Split(DirectSubjectResult, " ")(0)
'                Dim ReasonTrim = DirectSubjectResult.TrimStart(FirstTrim.ToCharArray)
'                Me.BackgroundImage = My.Resources.froze
'                Me.BackgroundImageLayout = ImageLayout.Stretch
'                My.Computer.Audio.Play(My.Resources.Frozen, AudioPlayMode.Background)
'                btnSend.Enabled = False
'                Frozen = True
'                ShakeVeryGently(10)
'                rtbLog.AppendText(User + " froze you! Someone must unfreeze you in order to continue talking." + vbNewLine)
'            Else
'                DirectSubjectResult = (Message.Replace("$freeze ", ""))
'                Dim AffectedUser As String = Split(DirectSubjectResult, " ")(0)
'                If AffectedUser = "" Or AffectedUser = " " Then
'                    My.Computer.Audio.Play(My.Resources.No, AudioPlayMode.Background)
'                    rtbLog.AppendText(User + " cooled the air in this chatbox." + vbNewLine)
'                Else
'                    rtbLog.AppendText(User + " froze " + AffectedUser + "!" + vbNewLine)
'                End If
'                rtbLog.ScrollToCaret()
'                DirectSubjectResult = ""
'            End If
'        ElseIf Message.ToString.StartsWith("$unfreeze ", StringComparison.OrdinalIgnoreCase) Then
'            If Message.ToString.Contains(My.Settings.Name) Then
'                Me.BackgroundImage = Nothing
'                btnSend.Enabled = True
'                Frozen = False
'                My.Computer.Audio.Play(My.Resources.Gotcha, AudioPlayMode.Background)
'                rtbLog.AppendText(User + " unfroze you!")
'            Else
'                DirectSubjectResult = (Message.Replace("$unfreeze ", ""))
'                Dim AffectedUser As String = Split(DirectSubjectResult, " ")(0)
'                If AffectedUser = "" Or AffectedUser = " " Then
'                    My.Computer.Audio.Play(My.Resources.No, AudioPlayMode.Background)
'                    rtbLog.AppendText(User + " warmed the air in this chatbox." + vbNewLine)
'                Else
'                    My.Computer.Audio.Play(My.Resources.Gotcha, AudioPlayMode.Background)
'                    rtbLog.AppendText(User + " unfroze " + AffectedUser + "!" + vbNewLine)
'                End If
'            End If
'        ElseIf Message.ToString.StartsWith("$directbuzzer ", StringComparison.OrdinalIgnoreCase) Then
'            If Message.ToString.Contains(My.Settings.Name) Then
'                DirectSubjectResult = (Message.Replace("$directbuzzer ", ""))
'                Dim ChainToCut As String = Split(DirectSubjectResult, " ")(0)
'                Dim MessageTrim = DirectSubjectResult.TrimStart(ChainToCut.ToCharArray)
'                My.Computer.Audio.Play(My.Resources.Critical, AudioPlayMode.Background)
'                ShakeGently(20)
'                If MessageTrim = "" Or MessageTrim = " " Then
'                    rtbLog.AppendText(User + " sent you a DIRECT BUZZER!" & vbNewLine)
'                Else
'                    rtbLog.AppendText(User + " [DIRECT BUZZER]: " + MessageTrim & vbNewLine)
'                End If
'                rtbLog.ScrollToCaret()
'            Else
'                My.Computer.Audio.Play(My.Resources.Question, AudioPlayMode.Background)
'                DirectSubjectResult = (Message.Replace("$directbuzzer", ""))
'                Dim FirstTrim As String = Split(DirectSubjectResult, " ")(0)
'                Dim AffectedTrim = DirectSubjectResult.TrimStart(FirstTrim.ToCharArray)
'                rtbLog.AppendText(User + " used a DIRECT BUZZER on" + AffectedTrim + vbNewLine)
'                rtbLog.ScrollToCaret()
'                DirectSubjectResult = ""
'            End If
'        ElseIf Message.ToString.StartsWith("$punch ", StringComparison.OrdinalIgnoreCase) Then
'            If Message.ToString.Contains(My.Settings.Name) Then
'                DirectSubjectResult = (Message.Replace("$punch ", ""))
'                Dim AffectedUser As String = Split(DirectSubjectResult, " ")(0)
'                Dim Reason = DirectSubjectResult.TrimStart(AffectedUser.ToCharArray)
'                If AffectedUser = "" Or AffectedUser = " " Then
'                    My.Computer.Audio.Play(My.Resources.No, AudioPlayMode.Background)
'                    rtbLog.AppendText(User + " didn't punch anybody.")
'                Else
'                    If Reason = "" Or Reason = " " Then
'                        My.Computer.Audio.Play(My.Resources.Punch, AudioPlayMode.Background)
'                        rtbLog.AppendText(User + " punched " + AffectedUser + " for no reason." + vbNewLine)
'                    Else
'                        My.Computer.Audio.Play(My.Resources.Punch, AudioPlayMode.Background)
'                        rtbLog.AppendText(User + " punched " + AffectedUser + " because " + Reason + vbNewLine)
'                    End If
'                End If

'                My.Computer.Audio.Play(My.Resources.Hit, AudioPlayMode.Background)
'                ShakeGently(20)
'            Else
'                DirectSubjectResult = (Message.Replace("$punch ", ""))
'                Dim AffectedUser As String = Split(DirectSubjectResult, " ")(0)
'                Dim Reason = DirectSubjectResult.TrimStart(AffectedUser.ToCharArray)
'                If AffectedUser = "" Or AffectedUser = " " Then
'                    My.Computer.Audio.Play(My.Resources.No, AudioPlayMode.Background)
'                    rtbLog.AppendText(User + " didn't punch anybody." + vbNewLine)
'                Else
'                    If Reason = "" Or Reason = " " Then
'                        rtbLog.AppendText(User + " punched " + AffectedUser + " for no reason." + vbNewLine)
'                    Else
'                        rtbLog.AppendText(User + " punched " + AffectedUser + " because " + Reason + vbNewLine)
'                    End If
'                End If
'                rtbLog.ScrollToCaret()
'                DirectSubjectResult = ""
'            End If
'        ElseIf Message.ToString.StartsWith("$wombocombo ", StringComparison.OrdinalIgnoreCase) Then
'            If Message.ToString.Contains(My.Settings.Name) Then
'                ReceiveWomboCombo()
'                DirectSubjectResult = (Message.Replace("$wombocombo ", ""))
'                Dim AffectedUser As String = Split(DirectSubjectResult, " ")(0)
'                Dim Reason = DirectSubjectResult.TrimStart(AffectedUser.ToCharArray)
'                If AffectedUser = "" Or AffectedUser = " " Then
'                    My.Computer.Audio.Play(My.Resources.No, AudioPlayMode.Background)
'                    rtbLog.AppendText(User + " didn't punch anybody." + vbNewLine)
'                Else
'                    If Reason = "" Or Reason = " " Then
'                        My.Computer.Audio.Play(My.Resources.Punch, AudioPlayMode.Background)
'                        rtbLog.AppendText(User + " punched " + AffectedUser + " for no reason." + vbNewLine)
'                    Else
'                        My.Computer.Audio.Play(My.Resources.Punch, AudioPlayMode.Background)
'                        rtbLog.AppendText(User + " punched " + AffectedUser + " because " + Reason + vbNewLine)
'                    End If
'                End If
'            Else
'                DirectSubjectResult = (Message.Replace("$wombocombo ", ""))
'                Dim AffectedUser As String = Split(DirectSubjectResult, " ")(0)
'                Dim Reason = DirectSubjectResult.TrimStart(AffectedUser.ToCharArray)
'                If AffectedUser = "" Or AffectedUser = " " Then
'                    My.Computer.Audio.Play(My.Resources.No, AudioPlayMode.Background)
'                    rtbLog.AppendText(User + " didn't combo anybody." + vbNewLine)
'                Else
'                    If Reason = "" Or Reason = " " Then
'                        rtbLog.AppendText(User + " WOMBO COMBO'D " + AffectedUser + " for no reason." + vbNewLine)
'                    Else
'                        rtbLog.AppendText(User + " WOMBO COMBO'D " + AffectedUser + " because " + Reason + vbNewLine)
'                    End If
'                End If
'            End If
'        Else
'            If Message.ToString.Contains(":O") Or Message.ToString.Contains("!?") Then
'                My.Computer.Audio.Play(My.Resources.Surprise, AudioPlayMode.Background)
'                rtbLog.AppendText(User + ":" & vbTab + Message & vbNewLine)
'                rtbLog.ScrollToCaret()
'            ElseIf Message.ToString.Contains("Idea!") Or Message.ToString.Contains("idea") Or Message.ToString.Contains("!") Then
'                My.Computer.Audio.Play(My.Resources.Idea, AudioPlayMode.Background)
'                rtbLog.AppendText(User + ":" & vbTab + Message & vbNewLine)
'                rtbLog.ScrollToCaret()
'            ElseIf Message.ToString.Contains("?") Then
'                My.Computer.Audio.Play(My.Resources.Question, AudioPlayMode.Background)
'                rtbLog.AppendText(User + ":" & vbTab + Message & vbNewLine)
'                rtbLog.ScrollToCaret()
'            ElseIf Message.ToString.Contains("Well done!") Or Message.ToString.Contains("nice") Then
'                My.Computer.Audio.Play(My.Resources.HighScore, AudioPlayMode.Background)
'                rtbLog.AppendText(User + ":" & vbTab + Message & vbNewLine)
'                rtbLog.ScrollToCaret()
'            ElseIf Message.ToString.Contains("yes") Or Message.ToString.Contains("yup") Or Message.ToString.Contains("Yup") Or Message.ToString.Contains("Yes") Then
'                My.Computer.Audio.Play(My.Resources.Yes, AudioPlayMode.Background)
'                rtbLog.AppendText(User + ":" & vbTab + Message & vbNewLine)
'                rtbLog.ScrollToCaret()
'            ElseIf Message.ToString.StartsWith("no") Or Message.ToString.Contains(" nope") Or Message.ToString.Contains(" Nope") Or Message.ToString.Contains("No.") Then
'                My.Computer.Audio.Play(My.Resources.No, AudioPlayMode.Background)
'                rtbLog.AppendText(User + ":" & vbTab + Message & vbNewLine)
'                rtbLog.ScrollToCaret()
'            ElseIf Message.ToString.Contains("Oh!") Or Message.ToString.Contains("I see") Or Message.ToString.Contains("Ooh!") Or Message.ToString.Contains("Yes!") Then
'                My.Computer.Audio.Play(My.Resources.Gotcha, AudioPlayMode.Background)
'                rtbLog.AppendText(User + ":" & vbTab + Message & vbNewLine)
'                rtbLog.ScrollToCaret()
'            Else
'                My.Computer.Audio.Play(My.Resources.Message, AudioPlayMode.Background)
'                rtbLog.AppendText(User + ":" & vbTab + Message & vbNewLine)
'                rtbLog.ScrollToCaret()
'            End If
'        End If
'    End Sub

'    Private Sub tbMessage_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles tbMessage.KeyDown
'        If e.KeyCode = Keys.Enter Then
'            If e.KeyCode = Keys.Shift Then
'                tbMessage.Text = (tbMessage.Text + vbNewLine)
'            ElseIf btnSend.Enabled = True Then
'                btnSend.PerformClick()
'            End If
'        End If
'    End Sub

'    Private Sub irc_PM(User As String, Message As String) Handles irc.PrivateMessage
'        If User = "IRC" Then
'            'LALALALALA I DONT WANT TO HEAR AN IRC BOT XD
'        Else
'            If Me.WindowState = FormWindowState.Minimized Or ActiveForm IsNot Me Then
'                Dim Notif As New NotiForm(User, Message)
'                Notif.Show()
'            Else
'                rtbLog.AppendText("(From " + User + " to " + irc.Nick + ")" & vbTab & Message + vbNewLine)
'            End If
'        End If
'    End Sub

'    Private Sub irc_UserJoin(Channel As String, User As String) Handles irc.UserJoined
'        My.Computer.Audio.Play(My.Resources.Connected, AudioPlayMode.Background)
'        rtbLog.AppendText(User + " has joined the chatroom." + vbNewLine)
'        lstUsers.Items.Add(User.Trim("@"))
'    End Sub

'    Private Sub irc_UserLeave(Channel As String, User As String) Handles irc.UserLeft
'        My.Computer.Audio.Play(My.Resources.Disconnect, AudioPlayMode.Background)
'        rtbLog.AppendText(User + " has left the chatroom." + vbNewLine)
'        lstUsers.Items.Remove(User)
'    End Sub

'    Private Sub irc_ExceptionThrown(ex As System.Exception) Handles irc.ExceptionThrown
'        MessageBox.Show(ex.Message)
'    End Sub

'    Private Sub irc_OnConnect() Handles irc.OnConnect
'        rtbLog.AppendText("Connected!" & vbNewLine)
'        irc.JoinChannel("#SM64FM")
'        tbMessage.Enabled = True
'        btnDisconnect.Enabled = True
'        btnSend.Enabled = True
'        ExplosionCooldownControl.Interval = 1000
'        BuzzerCooldownControl.Interval = 1000
'        ExplosionCooldownControl.Start()
'        BuzzerCooldownControl.Start()
'    End Sub

'    Private Sub irc_ServerMessage(message As String) Handles irc.ServerMessage
'        'rtbLog.AppendText(message & vbNewLine)
'        rtbLog.ScrollToCaret()
'    End Sub

'    Private Sub irc_UpdateUsers(Channel As String, userlist() As String) Handles irc.UpdateUsers
'        lstUsers.Items.Clear()
'        lstUsers.Items.AddRange(userlist)
'    End Sub

'    Private Sub Chat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        tbMessage.Enabled = False
'        btnExplode.Enabled = False
'        btnDisconnect.Enabled = False
'        btnNudge.Enabled = False
'        btnSend.Enabled = False
'        lbNick.Text = "Your nickname is:" + vbCrLf + My.Settings.Name
'        BuzzerTooltip.SetToolTip(btnNudge, "Causes a buzz that shakes the screens of everyone in the room you're chatting in, preventing everyone from typing. (Cooldown 6s)")
'        ExplosionToolTip.SetToolTip(btnExplode, "Causes an explosion that violently shakes the screens of everyone in the room you're chatting in, preventing everyone from typing. (Cooldown 20s)")
'    End Sub

'    Private Sub Nudge_Click(sender As Object, e As EventArgs) Handles btnNudge.Click
'        btnNudge.Enabled = False
'        NudgeCooldown.Value = 0
'        tbMessage.Text = "$buzzer"
'        btnSend.PerformClick()
'    End Sub

'    Private Sub Explode_Click(sender As Object, e As EventArgs) Handles btnExplode.Click
'        btnExplode.Enabled = False
'        ExplodeCooldown.Value = 0
'        tbMessage.Text = "$explosion"
'        btnSend.PerformClick()
'    End Sub

'    Private Sub BuzzerCooldownControl_Tick(sender As Object, e As EventArgs) Handles BuzzerCooldownControl.Tick
'        If Frozen = False Then
'            If NudgeCooldown.Value < 6 Then
'                btnNudge.Enabled = False
'                NudgeCooldown.Value += 1
'            ElseIf NudgeCooldown.Value = 6 Then
'                btnNudge.Enabled = True
'            End If
'        ElseIf Frozen = True Then
'            btnNudge.Enabled = False
'            NudgeCooldown.Value = 0
'        End If
'    End Sub

'    Private Sub ExplosionCooldownControl_Tick(sender As Object, e As EventArgs) Handles ExplosionCooldownControl.Tick
'        If Frozen = False Then
'            If ExplodeCooldown.Value < 20 Then
'                btnExplode.Enabled = False
'                ExplodeCooldown.Value += 1
'            ElseIf ExplodeCooldown.Value = 20 Then
'                btnExplode.Enabled = True
'            End If
'        ElseIf Frozen = True Then
'            btnExplode.Enabled = False
'            ExplodeCooldown.Value = 0
'        End If
'    End Sub
'    Private Sub PMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PMToolStripMenuItem.Click
'        tbMessage.Text = ("$pm " + lstUsers.SelectedItem.ToString.TrimStart("@") + " ")
'    End Sub

'    Private Sub FreezeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FreezeToolStripMenuItem.Click
'        If btnSend.Enabled = True Then
'            tbMessage.Text = ("$freeze " + lstUsers.SelectedItem.ToString.TrimStart("@"))
'            btnSend.PerformClick()
'        End If
'    End Sub

'    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
'        If btnSend.Enabled = True Then
'            tbMessage.Text = ("$unfreeze " + lstUsers.SelectedItem.ToString.TrimStart("@"))
'            btnSend.PerformClick()
'        End If
'    End Sub

'    Private Sub DirectBuzzToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DirectBuzzToolStripMenuItem.Click
'        If btnSend.Enabled = True Then
'            tbMessage.Text = ("$directbuzz " + lstUsers.SelectedItem.ToString.TrimStart("@"))
'            btnSend.PerformClick()
'        End If
'    End Sub

'    Private Sub PunchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PunchToolStripMenuItem.Click
'        If btnSend.Enabled = True Then
'            tbMessage.Text = ("$punch " + lstUsers.SelectedItem.ToString.TrimStart("@"))
'            btnSend.PerformClick()
'        End If
'    End Sub

'    Private Sub SecretToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SecretToolStripMenuItem.Click
'        If btnSend.Enabled = True Then
'            tbMessage.Text = ("$wombocombo " + lstUsers.SelectedItem.ToString.TrimStart("@"))
'            btnSend.PerformClick()
'        End If
'    End Sub

'    Private Sub KickToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KickToolStripMenuItem.Click
'        If btnSend.Enabled = True Then
'            tbMessage.Text = ("$kick " + lstUsers.SelectedItem.ToString.TrimStart("@"))
'            btnSend.PerformClick()
'        End If
'    End Sub
'End Class