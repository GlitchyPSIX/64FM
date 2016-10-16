Public Class BGSelector

    Private Sub BGSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.FavColor
    End Sub

    Private Sub Classic_Click(sender As Object, e As EventArgs) Handles whitenoise.Click
        My.Settings.Background = 1
        SetUpForm.SetBackground()
    End Sub

    Private Sub Clockwork_Click(sender As Object, e As EventArgs) Handles darknoise.Click
        My.Settings.Background = 2
        SetUpForm.SetBackground()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles OK_btn.Click
        Me.Close()
    End Sub
End Class