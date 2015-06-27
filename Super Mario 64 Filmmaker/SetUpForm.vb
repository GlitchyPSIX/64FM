Imports System.Text
Imports System.Diagnostics.ConditionalAttribute
Imports Transitions
Imports System.IO

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
                    MsgBox(ImageS) 'DEBUG FEATURE: Check if everything worked, by showing the image's path.
                End If
                'Nothing
            End If
        Else
            OpenFileDlg.ShowDialog()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If NameBox.Text = "" Or ImageS = "" Then
            MsgBox("Please fill all forms before continuing.")
        Else
            My.Settings.Name = NameBox.Text 'Make M.S.Name have what it said in the TextBox called NameBox
            My.Settings.Image = ImageS ' Set the ImageS Placeholder to M.S.Image
            My.Settings.FavColor = ColorZ
            My.Settings.Save()
            MainMenu.Show() 'Show the main menu
            Me.Close() 'Say goodbye
        End If
    End Sub

    Private Sub NameBox_TextChanged(sender As Object, e As EventArgs) Handles NameBox.TextChanged
        MyNameIsLabel.Text = "Hello there!" + vbCrLf + "My name is" + vbCrLf + NameBox.Text
    End Sub

    Private Sub PickColor_Click(sender As Object, e As EventArgs) Handles PickColor.Click
        Dim Panel2Fade As New Transition(New TransitionType_EaseInEaseOut(800))
        ColorSelector.ShowDialog()
        If DialogResult.OK Then
            If ColorSelector.Color.R < 49 And ColorSelector.Color.G < 49 And ColorSelector.Color.B < 49 And ColorSelector.Color = Color.Black Or ColorSelector.Color.ToKnownColor.ToString.Contains("Dark") Then
                MsgBox("Sorry, no black/dark colors. You wouldn't be able to see the text...")
            Else
                Panel2Fade.add(Me.NotHaali.Panel2, "BackColor", ColorSelector.Color)
                Panel2Fade.add(Me.ImgPrw, "BackColor", ColorSelector.Color)
                ColorZ = ColorSelector.Color
                Panel2Fade.run()
            End If
        Else
            MsgBox("Canceled? Awww...")
        End If
    End Sub

    Private Sub SetUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetBackground.Interval = 500
        SetBackground.Enabled = True
    End Sub

    Private Sub SelBGBTN_Click(sender As Object, e As EventArgs) Handles SelBGBTN.Click
        BGSelector.Show()
    End Sub

    Private Sub SetBackground_Tick(sender As Object, e As EventArgs) Handles SetBackground.Tick
        If My.Settings.Background = 1 Then
            NotHaali.Panel2.BackgroundImage = My.Resources.Background
        ElseIf My.Settings.Background = 2 Then
            NotHaali.Panel2.BackgroundImage = My.Resources.Background2
        ElseIf My.Settings.Background = 3 Then
            NotHaali.Panel2.BackgroundImage = My.Resources.Background3
        ElseIf My.Settings.Background = 4 Then
            NotHaali.Panel2.BackgroundImage = My.Resources.Background4
        ElseIf My.Settings.Background = 5 Then
            NotHaali.Panel2.BackgroundImage = My.Resources.Background5
        ElseIf My.Settings.Background = 6 Then
            NotHaali.Panel2.BackgroundImage = My.Resources.Background6
        ElseIf My.Settings.Background = 7 Then
            NotHaali.Panel2.BackgroundImage = My.Resources.Background7
        End If
    End Sub
End Class