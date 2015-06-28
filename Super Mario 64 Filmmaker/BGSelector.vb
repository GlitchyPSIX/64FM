Public Class BGSelector

    Private Sub BGSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FavColor
    End Sub

    Private Sub Classic_Click(sender As Object, e As EventArgs) Handles Classic.Click
        My.Settings.Background = 1
        SetUpForm.SetBackground()
        Me.Close()
    End Sub

    Private Sub Fade_Click(sender As Object, e As EventArgs) Handles Fade.Click
        My.Settings.Background = 2
        SetUpForm.SetBackground()
        Me.Close()
    End Sub

    Private Sub Harmony_Click(sender As Object, e As EventArgs) Handles Harmony.Click
        My.Settings.Background = 3
        SetUpForm.SetBackground()
        Me.Close()
    End Sub

    Private Sub Skysoarer_Click(sender As Object, e As EventArgs) Handles Skysoarer.Click
        My.Settings.Background = 4
        SetUpForm.SetBackground()
        Me.Close()
    End Sub

    Private Sub Clockwork_Click(sender As Object, e As EventArgs) Handles Clockwork.Click
        My.Settings.Background = 5
        SetUpForm.SetBackground()
        Me.Close()
    End Sub

    Private Sub Loveup_Click(sender As Object, e As EventArgs) Handles Loveup.Click
        My.Settings.Background = 6
        SetUpForm.SetBackground()
        Me.Close()
    End Sub

    Private Sub Starlight_Click(sender As Object, e As EventArgs) Handles Starlight.Click
        My.Settings.Background = 7
        SetUpForm.SetBackground()
        Me.Close()
    End Sub
End Class