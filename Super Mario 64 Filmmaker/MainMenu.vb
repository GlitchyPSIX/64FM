'Welcome to my code... the Main Code in SM64FM.
'It was started in 2014 under the same name, but with a whole different UI and Icon.
'Both based in what was Source Filmmaker. (The name stays!)
'The old icon and a screenshot from the old interface can be found laying there in the resources. (!aera niatrec a ni noitcnuf niatrec a rO)
'This was the second thing I did when I learnt Visual Basic in a weekend.
'While I was coding this one, I was learning more... and more looking at another code examples.
'This was always the thing I was doing when I always said to my mom: "I'm programming"...
'The first thing I coded was a simple Windows Forms Application, that was based in a WebBrowser with many buttons.
'It was a IM for my school, tho it has never been used and it's still in my PC.
'This is my second, and my longest project in code, and that means this code, in its enterity, is my biggest achievement in my 
'computer life since the installation of Windows 8.1 in a PC with an Intel Atom Processor... Heh.
'This code means too much to me.
'If somehow I lose it, My.Resources.Heart would be actually... broken.
'This code will give me nostalgia sometimes because as I'm writing this, and the more code 
'I write, more things in my life happen, and they are grateful.
'I hope the best for this program.
'and I hope I, and other developers help the whole SM64 Community, aswell other ... "mateys".
'If you are reading this, you are a developer. Just by the fact I have enough trust in you,
'to lend ya my code, means you're a really good person, or I saw something very nice in you.
'Thanks for reading this, and now let's begin.
'© Starlight Project 2014-2015, All Rights Reserved.
'------------------------------------------------------------------------------------------------------------------------------------
'!krow snoitcnuf niatrec erehw gnichraes nuf evaH .saera niatrec ni tceffe ...emos evah ereht gniyal snoitcnuf emoS :GGE RETSAE
'.gnihtrmos ...reggirt ot bv.uneMniaM ni ()dlroWolleH esU :eno wonk uoy tel lliw I
Imports System.Web
Imports System.IO
Imports System.Text
Imports System.Runtime.InteropServices
Imports Ionic.Zip
Imports Transitions
Imports Filmmaker.Extractor 'This is a class xD
Imports Filmmaker.HelloMatey

Public Class MainMenu

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Search the recorder and start it
        Try
            Process.Start(Application.StartupPath & "\Engine\Fraps.exe")
        Catch ex As Exception
            MsgBox("Couldn't find the required file... Is SM64FM correctly installed?")
        End Try
    End Sub

    Private Sub btnGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Search PJ64 and start it
        Try
            Process.Start(Application.StartupPath & "\Engine\PJ64.exe")
        Catch ex As Exception
            MsgBox("Couldn't find the required file... Is SM64FM correctly installed?")
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Show "GlitchyPSIX's Essentials"
        glitchyessentials.Show()
        Me.Hide()
    End Sub

    Private Sub btnCHT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCHT.Click
        'Show Cheat Search Mode Select
        cheatModeSel.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Search Color Code Suite and start it
        Try
            Process.Start(Application.StartupPath & "\Engine\CCGEN.exe")
        Catch ex As Exception
            MsgBox("Couldn't find the required file... Is SM64FM correctly installed?")
        End Try
    End Sub

    Private Sub btnSC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSC.Click
        'Do nothing... for now
    End Sub

    Private Sub btnEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Show Extras Menu
        extractSel.Show()
    End Sub

    Private Sub MainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Set the "Custom Settings" feature
        HelloWorld()
        If My.Settings.Background = 1 Then
            Me.BackgroundImage = My.Resources.Background
        ElseIf My.Settings.Background = 2 Then
            Me.BackgroundImage = My.Resources.Background2
        ElseIf My.Settings.Background = 3 Then
            Me.BackgroundImage = My.Resources.Background3
        ElseIf My.Settings.Background = 4 Then
            Me.BackgroundImage = My.Resources.Background4
        ElseIf My.Settings.Background = 5 Then
            Me.BackgroundImage = My.Resources.Background5
        ElseIf My.Settings.Background = 6 Then
            Me.BackgroundImage = My.Resources.Background6
        ElseIf My.Settings.Background = 7 Then
            Me.BackgroundImage = My.Resources.Background7
        End If
        ImgPrw.BackColor = My.Settings.FavColor
        ImgPrw.Image = Image.FromFile(My.Settings.Image)
        WelcomeLabel.Text = ("Welcome Back," + vbCrLf + My.Settings.Name)
        AppVer.Text = "Super Mario 64 Filmmaker BETA Version " + Application.ProductVersion.ToString + " Build No. " + My.Settings.Build.ToString
        Me.BackColor = My.Settings.FavColor
    End Sub
    Private Sub ToolStripStatusLabel1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripStatusLabel1.Click
        'Link not working - Leaded to the donation site
        Process.Start("http://sm64fm.pe.hu/donatenow.html")
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        ' THere is something wrong and don't worry, I will erase it
        extractSel.Show()
    End Sub

    Private Sub ShowChat(sender As System.Object, e As System.EventArgs) Handles btnChat.Click
        Chat.Show()
    End Sub

    Private Sub btnWorkshop_Click_1(sender As Object, e As EventArgs) Handles btnWorkshop.Click
        ' Coming from Super_Mario_64_Filmmaker.Extractor, loads the OpenFileDialog to search a ZIP to extract. I have to change the extensions.
        LoadAndDecompress("Project64", ".fmcht", "Super Mario 64 Filmmaker Cheat File (*.fmcht)|*.fmcht|Project64 Cheat File (*.cht)|*.cht")
    End Sub

    Private Sub ImgPrw_Click(sender As Object, e As EventArgs) Handles ImgPrw.Click
        ' This will open Settings window... I haven't even designed it yet...
    End Sub

    Private Sub LoadAddonImporterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadAddonImporterToolStripMenuItem.Click

    End Sub

    Private Sub AboutSM64FMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutSM64FMToolStripMenuItem.Click
        AboutBox.Show()
    End Sub

    Private Sub ExpandOrRetract_Click(sender As Object, e As EventArgs) Handles ExpandOrRetract.Click
        Dim FormWidth As Integer = Me.Width
        Dim Retract As New Transition(New TransitionType_Deceleration(800))
        Dim Expand As New Transition(New TransitionType_Acceleration(800))
        Retract.add(Me, "Width", 547)
        Expand.add(Me, "Width", 757)
        If FormWidth < 547 Or FormWidth > 547 Then
            Retract.run()
            Me.ExpandOrRetract.Image = My.Resources.Expand
        Else
            Expand.run()
            Me.ExpandOrRetract.Image = My.Resources.Retract
        End If
    End Sub
End Class