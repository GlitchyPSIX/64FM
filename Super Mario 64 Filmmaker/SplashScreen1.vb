Imports Transitions 'Helps me a lot.
Imports System.IO

Public Class SplashScreen1
    'This will be checked lotsa times.
    Dim Percentage As Integer = 0
    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If the program is compiled in DEBUG mode, then enable the "Debug" flag in Globals.vb
#If DEBUG Then
        Debug = True
#End If
        'Start the timer and make every tick be half a second.
        PercentagedTime.Interval = 500
        PercentagedTime.Start()
        'Declare the transition for the TitleLabel
        Dim t1 As New Transition(New TransitionType_EaseInEaseOut(1000))
        Dim t2 As New Transition(New TransitionType_Linear(800))
        Dim t3 As New Transition(New TransitionType_EaseInEaseOut(900))
        Dim t4 As New Transition(New TransitionType_EaseInEaseOut(100))
        t2.add(TitleLabel, "ForeColor", Color.White)
        t1.add(TitleLabel, "Left", 20)
        t3.add(progressbar1, "Left", 10)
        t4.add(StatusLabel, "Left", 60)
        'Run transitions
        t1.run()
        t2.run()
        t3.run()
        t4.run()
    End Sub

    Private Sub PercentagedTime_Tick(sender As Object, e As EventArgs) Handles PercentagedTime.Tick
        'In every tick, say the percentage, making the Percentage Integer a string, and adding a "%"
        PercentageLabel.Text = Percentage.ToString + "%"
        'After certain "Percentage", change interval of the PercentagedTime Timer and change the String
        If Percentage >= 25 Then
            ProgressLabel.Text = "Loading UI"
            PercentagedTime.Interval = 90
        End If
        If Percentage >= 50 Then
            PercentagedTime.Interval = 50
            ProgressLabel.Text = "Loading UI Images"
        End If
        If Percentage >= 75 Then
            PercentagedTime.Interval = 150
            ProgressLabel.Text = "Deploying Addons"
        End If
        If Percentage >= 80 Then
            PercentagedTime.Interval = 100
            ProgressLabel.Text = "Creating Windows"
        End If
        If Percentage < 100 Then
            Percentage = Percentage + 1
        ElseIf Percentage = 100 Then
            If My.Settings.Name = "" And My.Settings.Image = "" Then
                SetUpForm.Show()
                Me.Close()
            Else
                MainMenu.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub TitleLabel_Click(sender As Object, e As EventArgs) Handles TitleLabel.Click
        'DEBUG FEATURE: Reset "Custom Greeting" data.
        If Debug Then
            My.Settings.Name = ""
            My.Settings.Image = ""
        End If
    End Sub

    Private Sub progressbar1_Click(sender As Object, e As EventArgs) Handles progressbar1.Click
        Percentage = 99
    End Sub
End Class
