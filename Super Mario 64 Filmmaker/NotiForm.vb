'Imports Transitions
'Public Class NotiForm

'#Region "Variables"
'    Dim WithEvents YouHave15SecondsToLive As New Timer
'    Dim SweepIn As New Transition(New TransitionType_Deceleration(1000))
'    Dim SweepOut As New Transition(New TransitionType_Acceleration(1000))
'    Dim GoUp As New Transition(New TransitionType_Deceleration(800))
'    Dim UserPMM As String
'    Dim Lifetime As Byte
'    Private Shared openForms As New List(Of NotiForm)
'#End Region

'#Region "Non-Designer Objects"
'    Dim WithEvents KillTimer As New Timer
'#End Region

'    Friend Sub New(ByVal UserPM As String, ByVal MessagePM As String)

'        ' This call is required by the designer.
'        InitializeComponent()
'        lbName.Text = UserPM
'        UserPMM = UserPM
'        lbMessage.Text = MessagePM
'        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Right + Me.Width - 5, Screen.PrimaryScreen.WorkingArea.Height - Me.Height - 5)
'        YouHave15SecondsToLive.Interval = 1000
'        SweepIn.add(Me, "Left", Screen.PrimaryScreen.WorkingArea.Right - Me.Width - 5)
'        SweepOut.add(Me, "Left", Screen.PrimaryScreen.WorkingArea.Right + Me.Width - 5)
'        KillTimer.Interval = 100
'        ' Add any initialization after the InitializeComponent() call.

'    End Sub

'    Private Sub Deathclock() Handles YouHave15SecondsToLive.Tick
'        If Lifetime < 15 Then
'            Lifetime = Lifetime + 1
'        ElseIf Lifetime = 15 Then
'            SweepOut.run()
'            Lifetime = 0
'            System.Threading.Thread.Sleep(500)
'            Me.Close()
'        End If
'    End Sub

'    Private Sub NotiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        Me.BackColor = My.Settings.FavColor
'        My.Computer.Audio.Play(My.Resources.Idea, AudioPlayMode.Background)
'        YouHave15SecondsToLive.Start()
'        SweepIn.run()
'        'Move each open form upwards to make room for this one.
'        For Each openForm As NotiForm In NotiForm.openForms
'            openForm.Top -= Me.Height + 5
'        Next

'        'Add this form from the open form list.
'        NotiForm.openForms.Add(Me)
'    End Sub

'    Private Sub btnReply_Click(sender As Object, e As EventArgs) Handles btnReply.Click
'        Lifetime = 15
'        Chat.Show()
'        Chat.tbMessage.Text = "$pm " + UserPMM + " "
'    End Sub

'    Private Sub JeffTheKiller() Handles KillTimer.Tick
'        If Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Right + Me.Width - 5) Then
'            Me.Close()
'            KillTimer.Stop()
'        Else
'            'Continue........
'        End If
'    End Sub
'End Class