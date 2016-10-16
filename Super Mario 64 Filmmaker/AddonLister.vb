Imports System.IO
Public Class AddonLister
    Public Shared Sub RepopulateFromDefault(ListViewToPopulate As ListView)
        ListViewToPopulate.Items.Clear()
        Dim Name As String = ""
        Dim Type As String = ""
        Dim ReadingEntrypoint As String = ""
        Dim Entrypoint As String = ""
        Dim IsCustomEP As Boolean
        Dim LoadedAddonsList As New StreamReader(Application.StartupPath + "\addonlist.cfg")
        Dim EveryLine As String() = LoadedAddonsList.ReadToEnd().Split(vbLf)
        Dim ReadingMetadataMode As Boolean
        Try
            For Each Line As String In EveryLine
                If Line.StartsWith(";") Then
                    ' This is a comment, do nothing.
                ElseIf Line.StartsWith("<addon>") Then
                    ReadingMetadataMode = True
                ElseIf Line.StartsWith("[addon]") Then
                    ReadingMetadataMode = False
                End If
                If ReadingMetadataMode = True And Line.StartsWith(";") = False Then
                    If Line.StartsWith("name=") Then
                        Name = Line.Replace("name=", "").Replace(vbLf, "")
                    ElseIf Line.StartsWith("type=") Then
                        Type = Line.Replace("type=", "").Replace(vbLf, "")
                    ElseIf Line.StartsWith("entrypoint=") Then
                        ReadingEntrypoint = Line.Replace("entrypoint=", "").Replace(vbLf, "")
                        If ReadingEntrypoint.StartsWith("/custom/=") Then
                            IsCustomEP = True
                            Entrypoint = ReadingEntrypoint.Replace("/custom/=", "").Replace(vbLf, "")
                        Else
                            Entrypoint = Line.Replace("entrypoint=", "").Replace(vbLf, "")
                        End If
                    End If
                ElseIf ReadingMetadataMode = False And Line.StartsWith(";") = False Then
                    Dim ListItem As New ListViewItem
                    ListItem.Text = Name
                    If Type.Equals("eyepak") Then 'TODO: make this work
                        ListItem.SubItems.Add("Eyepack")
                    ElseIf Type.Equals("rom") Then
                        ListItem.SubItems.Add("ROM")
                    ElseIf Type.Equals("tex") Then
                        ListItem.SubItems.Add("Texture Pack")
                    Else
                        ListItem.SubItems.Add("File")
                    End If
                    If IsCustomEP = True Then
                        Dim CustomizedEntryPoint As String = Entrypoint.Replace("%audioeditor%", My.Settings.AudioEditorPath).Replace("%videoeditor%", My.Settings.VideoEditorPath).Replace("%recorderpath%", My.Settings.RecorderPath).Replace("%64player", Application.StartupPath + "\Engine\64Player.exe")
                        ListItem.SubItems.Add(CustomizedEntryPoint)
                        IsCustomEP = False
                    ElseIf IsCustomEP = False Then
                        ListItem.SubItems.Add(Entrypoint)
                    End If
                    ListViewToPopulate.Items.Add(ListItem)
                    ' Return to the addon console: Item <name> Added.
                    'debug
                End If
            Next
            LoadedAddonsList.Dispose()
        Catch ex As Exception
            'Return to the console: ERROR <exception>
            MsgBox("Could not load addon file. Exception: " + ex.ToString, MsgBoxStyle.OkOnly, "OOPS!")
        End Try
    End Sub
End Class
