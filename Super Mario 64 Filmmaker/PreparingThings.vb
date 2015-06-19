Imports Transitions
Public Class PreparingThings
    Dim ColorProgress As Integer
    Private Sub PreparingThings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FadeText As New Transition(New TransitionType_Deceleration(800))
        FadeText.add(ProgressLabel, "ForeColor", Color.White)
        FadeText.add(ProgressLabel, "Top", 140)
        FadeText.run()
        '----------------------- RUN THE COLOR CHANGER!! ;D
        ColorChanger.Interval = 200
        ColorChanger.Start()
    End Sub

    Private Sub ColorChanger_Tick(sender As Object, e As EventArgs) Handles ColorChanger.Tick
        Dim FadeColor As New Transition(New TransitionType_EaseInEaseOut(3000))
        If ColorProgress < 100 Then
            ColorProgress = ColorProgress + 1
        End If
        If ColorProgress = 10 Then
            FadeColor.add(Me, "BackColor", Color.RoyalBlue)
            FadeColor.run()
        ElseIf ColorProgress = 20 Then
            FadeColor.add(Me, "BackColor", Color.Turquoise)
            FadeColor.run()
        ElseIf ColorProgress = 30 Then
            FadeColor.add(Me, "BackColor", Color.Green)
            FadeColor.run()
        ElseIf ColorProgress = 40 Then
            FadeColor.add(Me, "BackColor", Color.YellowGreen)
            FadeColor.run()
        ElseIf ColorProgress = 50 Then
            FadeColor.add(Me, "BackColor", Color.DarkKhaki)
            FadeColor.run()
        ElseIf ColorProgress = 60 Then
            FadeColor.add(Me, "BackColor", Color.Orange)
            FadeColor.run()
        ElseIf ColorProgress = 70 Then
            FadeColor.add(Me, "BackColor", Color.DarkOrange)
            FadeColor.run()
        ElseIf ColorProgress = 80 Then
            FadeColor.add(Me, "BackColor", Color.OrangeRed)
            FadeColor.run()
        ElseIf ColorProgress = 90 Then
            FadeColor.add(Me, "BackColor", Color.Red)
            FadeColor.run()
        ElseIf ColorProgress = 100 Then
            FadeColor.add(Me, "BackColor", Color.Violet)
            FadeColor.run()
            ColorProgress = ColorProgress - 100
        End If
    End Sub
End Class