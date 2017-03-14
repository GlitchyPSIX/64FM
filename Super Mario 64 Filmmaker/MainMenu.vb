'Welcome to my code... the Main Code in 64FM, formerly SM64FM.
'------------------------------------------------------------------------------------------------------------------------------------


Imports Transitions
Public Class MainMenu
    'This will help me close the processes that were opened without the need of scavenging a lot. (Except PJ64?)
    Public VEProcess As Process
    Public REProcess As Process
    Public EMUProcess As Process
    Private Sub MainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Set the "Custom Settings" feature and load the processes
        ApplyProfileSettings()
        'Version_lb.Text = "64Filmmaker v" + Application.ProductVersion.ToString + " | Build Date: " + My.Settings.BuildDate.ToString
        TenthOfASecond.Interval = 100
        TenthOfASecond.Start()
    End Sub

    Public Sub ApplyProfileSettings() 'the name says it
        MsgBox("Trying to load from: " + My.Settings.Image)
        If My.Settings.Background = 1 Then
            Me.BackgroundImage = My.Resources.white_noise
        ElseIf My.Settings.Background = 2 Then
            Me.BackgroundImage = My.Resources.dark_noise
        End If
        ImgPrw.BackColor = Color.Transparent
        Try
            ImgPrw.Image = Image.FromFile(My.Settings.Image)
        Catch ex As Exception
            ImgPrw.Image = My.Resources.PIC_EXCEPTION
        End Try
        username_lb.Text = (My.Settings.Name)
        Me.BackColor = My.Settings.FavColor
        Me.Refresh()
    End Sub

    Public Sub btnSV_Click(sender As Object, e As EventArgs) Handles btnSV.Click
        'Search for the video editor and start it
        If My.Settings.VideoEditorPath = "" Or My.Settings.RecorderPath = "" Then
            frmSoftwareForm.Show()
        Else
            VEProcess = Process.Start(My.Settings.VideoEditorPath)
        End If
    End Sub

    Public Sub btnFRPS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFRPS.Click
        'Search for the recorder and start it
        If My.Settings.VideoEditorPath = "" Or My.Settings.RecorderPath = "" Then
            frmSoftwareForm.Show()
        Else
            REProcess = Process.Start(My.Settings.RecorderPath)
        End If
    End Sub

    Public Sub btnGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGame.Click
        ROMSelector.Show()
    End Sub

    Private Sub btnEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'This was the Extras menu, but I'm thinking about changing it to the Hacker section.
    End Sub

    Private Sub btnCinema_Click(sender As Object, e As EventArgs) Handles btnCinema.Click
        'Show M64MM2.x
        MainForm.Show()
    End Sub

    ''Link (Not from Hyrule) Working. 64NeeNwork forums
    'Process.Start("http://sm64fm.officialytr.com/forum")

    Private Sub ShowChat(sender As System.Object, e As System.EventArgs) Handles btnChat.Click
        'I will scrap the chat to make it the core of the online functionality.
    End Sub
    Private Sub ExpandOrRetract_Click(sender As Object, e As EventArgs) Handles ExpandOrRetract.Click
        ' This expands the main menu.
        Dim FormWidth As Integer = Me.Width
        Dim Retract As New Transition(New TransitionType_Deceleration(800))
        Dim Expand As New Transition(New TransitionType_Acceleration(800))
        Retract.add(Me, "Width", 535)
        Expand.add(Me, "Width", 755)
        If FormWidth > 535 Then
            Retract.run()
            Me.ExpandOrRetract.Image = My.Resources.Expand
            'For x = 0 To 11
            '    Me.Width = 755 - (x * 20)
            '    Me.Refresh()
            'Next
        Else
            Expand.run()
            Me.ExpandOrRetract.Image = My.Resources.Retract
            'For x = 0 To 11
            '    Me.Width = 535 + (x * 20)
            '    Me.Refresh()
            'Next
        End If
    End Sub
    Private Sub About64FMToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Show the about box.
        AboutBox.Show()
    End Sub

    Protected Friend Sub MainMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'This is what happens when the main form is closed (While visible).
        If Me.Visible = True Then
            Me.WindowState = FormWindowState.Minimized
            Me.Visible = False
            e.Cancel = True
            noticon.Visible = True
            noticon.BalloonTipTitle = "64Filmmaker: Psst!"
            noticon.BalloonTipText = "64FM has been minimized to the taskbar. Click the icon to see extra options."
            noticon.BalloonTipIcon = ToolTipIcon.Info
            noticon.ShowBalloonTip(15000)
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub noticon_MouseClick(sender As Object, e As MouseEventArgs) Handles noticon.MouseClick
        'Show the options strip in the notification area icon.
        noticon_strip.Show(New Point(Cursor.Position.X, Cursor.Position.Y))
    End Sub

    Private Sub Show64FMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Show64FMToolStripMenuItem.Click
        'Show 64FM  from the strip command
        Me.Visible = True
        Me.WindowState = FormWindowState.Normal

        noticon.Visible = False
    End Sub

    Private Sub Exit64FMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Exit64FMToolStripMenuItem.Click
        My.Settings.Save()
        My.Application.Goodbye()
    End Sub

    Private Sub btnWorkshop_Click(sender As Object, e As EventArgs) Handles Addon_btn.Click
        AddonSettingsForm.Show()
    End Sub
End Class