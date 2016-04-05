Public Class frmSoftwareForm
    Private Sub frmSoftwareForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.VideoEditorPath = "" Or My.Settings.RecorderPath = "" Then
            MessageBox.Show("You don't have a recorder, or a video editor. Please set them.", "Practical Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Show()
        Else
            Me.Show()
            VideoEditortb.Text = My.Settings.VideoEditorPath
            Recordertb.Text = My.Settings.RecorderPath
            AudioEditortb.Text = My.Settings.AudioEditorPath
        End If
    End Sub

    Private Sub OKbtn_Click(sender As Object, e As EventArgs) Handles OKbtn.Click
        My.Settings.VideoEditorPath = VideoEditortb.Text
        My.Settings.AudioEditorPath = AudioEditortb.Text
        My.Settings.RecorderPath = Recordertb.Text
        Me.Close()
    End Sub

    Private Sub SearchVideoEditorbtn_Click(sender As Object, e As EventArgs) Handles SearchVideoEditorbtn.Click
        Dim OpenExe As New OpenFileDialog
        OpenExe.AddExtension = True
        OpenExe.Filter = "*.exe|Executable File"
        OpenExe.Multiselect = False
    End Sub

    Private Sub Recordertb_TextChanged(sender As Object, e As EventArgs) Handles Recordertb.TextChanged

    End Sub

    Private Sub IllegalStuff_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles IllegalStuff.LinkClicked
        'It's not our fault. We can't give away just so publicly things like that.
        'I don't know how I'll get away with this.
        'Wish me luck~
    End Sub
End Class