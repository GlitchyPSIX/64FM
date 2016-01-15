
Public Class _64Tube
    Private Sub _64Tube_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Chat.Width, Chat.Height - Chat.Height)
        VideoPlayer.Source = New Uri("http://youtube.com/embed/" + "2PGK-jEIQy4")

    End Sub

    Private Sub VideoHistorySelect(sender As Object, e As EventArgs) Handles VideoHistory.SelectedIndexChanged
        Dim FullName As String
        Dim Splitten As String()
        FullName = VideoHistory.SelectedItem.ToString
        Splitten = Split(FullName, " (<->) ")
        VideoPlayer.Source = New Uri("http://youtube.com/embed/" + Splitten(1))
        Me.Text = Splitten(0)
    End Sub

End Class