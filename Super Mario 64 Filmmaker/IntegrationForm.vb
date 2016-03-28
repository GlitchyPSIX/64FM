Public Class IntegrationForm

    Private Sub LogoPB_Click(sender As Object, e As EventArgs) Handles LogoPB.Click

    End Sub

    Private Sub IntegrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.lastUsername = "" AndAlso My.Settings.lastPassword = "" Then
            'Just show up.
        Else
            'Show the relogin/relogin.
        End If
    End Sub

    Private Sub Loginbtn_Click(sender As Object, e As EventArgs) Handles Loginbtn.Click
        'This is not finished.
        'Gotta find a way to finish it, though.
    End Sub
End Class