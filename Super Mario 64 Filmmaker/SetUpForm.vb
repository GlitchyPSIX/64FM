Imports System.Text
Imports Transitions
Imports System.IO
Imports System.Text.RegularExpressions

Public Class SetUpForm
    Dim ImageS As String 'Same as above, but for My.Settings.Image
    Dim ColorZ As System.Drawing.Color 'Yay! technicolor variable!

    Public Sub SelImgBtn_Click(sender As Object, e As EventArgs) Handles SelImgBtn.Click
        Dim OpenFileDlg As New OpenFileDialog
        OpenFileDlg.FileName = "" ' Default file name
        OpenFileDlg.DefaultExt = "" ' Default file extension
        OpenFileDlg.Filter = "PNG files (*.png)|*.png|JPEG files (*.jpg)|*.jpg|All files (*.*)|*.*"
        OpenFileDlg.Multiselect = False
        OpenFileDlg.RestoreDirectory = True
        Dim PressedButton As Boolean = DialogResult.OK
        Dim result As Boolean = OpenFileDlg.ShowDialog()
        ' Process open file dialog box results
        If result = True Then
            If PressedButton = True Then
                Try
                    ImgPrw.Image = Image.FromFile(OpenFileDlg.FileName) 'Set the image to a preview Picture Box called ImgPrw
                Catch ex As Exception
                    MsgBox("Unable to load the file. Maybe it was deleted?") 'Exception
                End Try
                ImageS = OpenFileDlg.FileName 'Set the placeholder variable for Image.
                If Debug Then
                    Tooltipo.ToolTipTitle = "Image's path:"
                    Tooltipo.ToolTipIcon = ToolTipIcon.Info
                    Tooltipo.UseAnimation = True
                    Tooltipo.Show(String.Empty, SelImgBtn)
                    Tooltipo.Show(ImageS, SelImgBtn) 'DEBUG FEATURE: Check if everything worked, by showing the image's path.
                End If
                'Nothing
            End If
        Else
            OpenFileDlg.ShowDialog()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If NameBox.Text = "" And ImageS = "" Then
            NameLabel.Text = NameBox.Text
            NameLabel.ForeColor = Color.Red
            Tooltipo.ToolTipTitle = "???"
            Tooltipo.ToolTipIcon = ToolTipIcon.Error
            Tooltipo.Show(String.Empty, NameLabel)
            Tooltipo.Show("you seem upset.\nCome and fill the forms please", NameLabel)
        ElseIf ImageS = ""Then
            NameLabel.Text = NameBox.Text
            NameLabel.ForeColor = Color.Red
            Tooltipo.ToolTipTitle = "???"
            Tooltipo.ToolTipIcon = ToolTipIcon.Error
            Tooltipo.Show(String.Empty, ImgPrw)
            Tooltipo.Show("show us your face\nPlease put in an image.", NameLabel)
        ElseIf NameBox.Text = ""Then
            NameLabel.Text = NameBox.Text
            NameLabel.ForeColor = Color.Red
            Tooltipo.ToolTipTitle = "???"
            Tooltipo.ToolTipIcon = ToolTipIcon.Error
            Tooltipo.Show(String.Empty, NameLabel)
            Tooltipo.Show("NaN\nPlease tell us your nickname.", NameLabel)
        Else
            My.Settings.Name = NameBox.Text 'Make M.S.Name have what it said in the TextBox called NameBox
            My.Settings.Image = ImageS ' Set the ImageS Placeholder to M.S.Image
            My.Settings.FavColor = ColorZ
            My.Settings.Save()
            MainMenu.ApplyProfileSettings()
            MainMenu.Show() 'Show the main menu
            Me.Close() 'Say goodbye
        End If
    End Sub

    Private Sub NameBox_TextChanged(sender As Object, e As EventArgs) Handles NameBox.TextChanged
        If Regex.IsMatch(NameBox.Text, "^[A-Za-z0-9]+$") Then
            NameLabel.Text = NameBox.Text
            NameLabel.ForeColor = Color.Black
        ElseIf NameBox.Text = ""
            NameLabel.Text = NameBox.Text
            My.Computer.Audio.Play(My.Resources.Message, AudioPlayMode.Background)
            Tooltipo.ToolTipTitle = "Empty name"
            Tooltipo.ToolTipIcon = ToolTipIcon.Info
            Tooltipo.Show(String.Empty, NameLabel)
        Else
            My.Computer.Audio.Play(My.Resources.Idea, AudioPlayMode.Background)
            NameLabel.Text = NameBox.Text
            NameLabel.ForeColor = Color.Red
            Tooltipo.ToolTipTitle = "Hey, look here."
            Tooltipo.ToolTipIcon = ToolTipIcon.Error
            Tooltipo.Show(String.Empty, NameLabel)
            Tooltipo.Show("Please refrain from using characters that aren't allowed, like !, "", @ or the Space key.", NameLabel)
        End If
    End Sub

    Private Sub PickColor_Click(sender As Object, e As EventArgs) Handles PickColor.Click
        Dim Panel2Fade As New Transition(New TransitionType_EaseInEaseOut(800))
        ColorSelector.ShowDialog()
        If DialogResult.OK Then
            Panel2Fade.add(Me.PanelControl.Panel2, "BackColor", ColorSelector.Color)
            Panel2Fade.add(Me.ImgPrw, "BackColor", ColorSelector.Color)
            ColorZ = ColorSelector.Color
            Panel2Fade.run()
        Else
            MsgBox("Cancelled? Awww...")
        End If
    End Sub

    Private Sub SetUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NameBox.Text = My.Settings.Name
        NameLabel.Text = My.Settings.Name
        SetBackground()
        Try
            ImgPrw.Image = Image.FromFile(My.Settings.Image) 'Set the image to a preview Picture Box called ImgPrw
            ImageS = My.Settings.Image
        Catch ex As Exception
            MsgBox("Unable to load the file. Maybe it was deleted?") 'Exception
        End Try
        ColorZ = My.Settings.FavColor
        Dim Panel2Fade As New Transition(New TransitionType_EaseInEaseOut(800))
        Panel2Fade.add(Me.PanelControl.Panel2, "BackColor", ColorZ)
        Panel2Fade.add(Me.ImgPrw, "BackColor", ColorZ)
        Panel2Fade.run()
    End Sub

    Private Sub SelBGBTN_Click(sender As Object, e As EventArgs) Handles SelBGBTN.Click
        BGSelector.Show()
    End Sub

    Public Sub SetBackground()
        If My.Settings.Background = 1 Then
            PanelControl.Panel2.BackgroundImage = My.Resources.Background
        ElseIf My.Settings.Background = 2 Then
            PanelControl.Panel2.BackgroundImage = My.Resources.Background2
        ElseIf My.Settings.Background = 3 Then
            PanelControl.Panel2.BackgroundImage = My.Resources.Background3
        ElseIf My.Settings.Background = 4 Then
            PanelControl.Panel2.BackgroundImage = My.Resources.Background4
        ElseIf My.Settings.Background = 5 Then
            PanelControl.Panel2.BackgroundImage = My.Resources.Background5
        ElseIf My.Settings.Background = 6 Then
            PanelControl.Panel2.BackgroundImage = My.Resources.Background6
        ElseIf My.Settings.Background = 7 Then
            PanelControl.Panel2.BackgroundImage = My.Resources.Background7
        ElseIf My.Settings.Background = 8 Then
            PanelControl.Panel2.BackgroundImage = My.Resources.Background8
        Else
            PanelControl.Panel2.BackgroundImage = My.Resources.Background
        End If
    End Sub
End Class