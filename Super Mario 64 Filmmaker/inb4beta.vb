Imports System.IO

Public Class inb4beta
    Dim Playlist As List(Of Track)
    Private Sub rafBtn_Click(sender As Object, Exception As EventArgs) Handles rafBtn.Click
        Dim Selector As New OpenFileDialog
        Dim Metadata As String
        Dim Step1 As String()
        Dim TrackName As String
        Dim AlbumImage As String
        Dim AlbumName As String
        Selector.Multiselect = False 'Please, only one file.
        Selector.RestoreDirectory = True 'In calse of the dialogbox closing, restore the last seen directory in the dialogbox.
        Dim ButtonResult As Boolean = DialogResult.OK
        ' Show open file dialog box and set the "Opened?" boolean value
        Dim result As DialogResult = Selector.ShowDialog()
        ' Process open file dialog box results
        If result = DialogResult.OK Then
            Try
                Using reader As New StreamReader(Selector.FileName)
                    Do While reader.Peek() >= 0
                        Metadata = reader.ReadToEnd()
                        Step1 = Split(Metadata.Replace("[sm64fm_track]" + vbCrLf, ""), vbCrLf)
                        TrackName = (Step1(0).ToString.Replace("Name = ", ""))
                        AlbumImage = (Step1(1).ToString.Replace("AlbumImage = ", ""))
                        AlbumName = (Step1(2).ToString.Replace("AlbumName = ", ""))
                        nameLb.Text = ("Track Name = " + TrackName)
                        imgptLb.Text = ("Image Path = " + AlbumImage)
                        albnmLb.Text = ("Album Name = " + AlbumName)
                    Loop
                End Using
            Catch exc As System.Exception
                MessageBox.Show(exc.Message)
            End Try
        Else
            'Do Nothing
        End If
    End Sub

    Private Sub btnLoadCHTSHT_Click(sender As Object, Exception As EventArgs) Handles btnLoadCHTSHT.Click
        Dim Selector As New OpenFileDialog
        Dim Metadata As String
        Dim Step1 As String()
        Dim TrackName As String
        Dim AlbumImage As String
        Dim AlbumName As String
        Selector.Multiselect = False 'Please, only one file.
        Selector.RestoreDirectory = True 'In calse of the dialogbox closing, restore the last seen directory in the dialogbox.
        Dim ButtonResult As Boolean = DialogResult.OK
        ' Show open file dialog box and set the "Opened?" boolean value
        Dim result As DialogResult = Selector.ShowDialog()
        ' Process open file dialog box results
        If result = DialogResult.OK Then
            Try
                Using reader As New StreamReader(Selector.FileName)
                    Do While reader.Peek() >= 0
                        Metadata = reader.ReadToEnd()
                        Step1 = Split(Metadata.Replace("[sm64fm_track]" + vbCrLf, ""), vbCrLf)
                        TrackName = (Step1(0).ToString.Replace("Name = ", ""))
                        AlbumImage = (Step1(1).ToString.Replace("AlbumImage = ", ""))
                        AlbumName = (Step1(2).ToString.Replace("AlbumName = ", ""))
                        nameLb.Text = ("Track Name = " + TrackName)
                        imgptLb.Text = ("Image Path = " + AlbumImage)
                        albnmLb.Text = ("Album Name = " + AlbumName)
                    Loop
                End Using
            Catch exc As System.Exception
                MessageBox.Show(exc.Message)
            End Try
        Else
            'Do Nothing
        End If
    End Sub
End Class

Public Class Track
        Public Name As String
        Public AlbumIMG As String
    Public AlbumNM As String

    Public Sub New(nm As String, img As String, anm As String)
        Name = nm
        AlbumIMG = img
        AlbumNM = anm
    End Sub
End Class