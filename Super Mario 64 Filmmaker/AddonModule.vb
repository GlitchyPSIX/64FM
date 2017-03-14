Imports System.IO
Public Class AddonModule
    Public Class AddonData
        Public Shared Addonlist As New List(Of Addon)
        Public Shared Sub RepopulateFromDefault()
            Dim Name As String = ""
            Dim Type As String = ""
            Dim ReadingEntrypoint As String = ""
            Dim Entrypoint As String = ""
            Dim Description As String = "No description"
            Dim DescriptionCheck As String = ""
            Dim Identifier As String = ""
            Dim Author As String = ""
            Dim IsCustomEP As Boolean = False
            Dim AVersion As String = ""
            Dim LoadedAddonsList As New StreamReader(Application.StartupPath + "\addonlist.cfg")
            Dim EveryLine As String() = LoadedAddonsList.ReadToEnd().Split(vbLf)
            Dim ReadingMetadataMode As Boolean
            Try
                For Each Line As String In EveryLine
                    If Line.StartsWith(";") Then
                        ' This is a comment, do nothing.
                    ElseIf Line.StartsWith("[addon]") Then
                        ReadingMetadataMode = True 'Started reading an addon
                    ElseIf Line.StartsWith("[/addon]") Then
                        ReadingMetadataMode = False 'Stopped reading an addon
                    End If
                    If ReadingMetadataMode = True And Line.StartsWith(";") = False Then
                        If Line.StartsWith("name=") Then
                            Name = Line.Replace("name=", "").Replace(vbCrLf, "").TrimEnd(vbCrLf) 'Found Name
                        ElseIf Line.StartsWith("id=") Then
                            Identifier = Line.Replace("id=", "").Replace(vbCrLf, "").TrimEnd(vbCrLf) ' Found ID (safename)
                        ElseIf Line.StartsWith("type=") Then
                            Type = Line.Replace("type=", "").Replace(vbCrLf, "").TrimEnd(vbCrLf) 'found type
                        ElseIf Line.StartsWith("author=") Then
                            Author = Line.Replace("author=", "").Replace(vbCrLf, "").TrimEnd(vbCrLf) 'found author
                        ElseIf Line.StartsWith("ver=") Then
                            AVersion = Line.Replace("ver=", "").Replace(vbCrLf, "").TrimEnd(vbCrLf) 'found version
                        ElseIf Line.StartsWith("desc=") Then
                            DescriptionCheck = Line.Replace("desc=", "").Replace(vbCrLf, "").TrimEnd(vbCrLf).Replace("[nl]", vbCrLf) 'found description, format it.
                            If DescriptionCheck = Nothing Or DescriptionCheck = " " Then 'if the description is empty
                                Description = "No description" 'keep this saying "No description"
                            Else
                                Description = DescriptionCheck 'or else paste what we found
                            End If
                        ElseIf Line.StartsWith("entrypoint=") Then
                            ReadingEntrypoint = Line.Replace("entrypoint=", "").Replace(vbCrLf, "").TrimEnd(vbCrLf) 'found entrypoint
                            If ReadingEntrypoint.StartsWith("[custom]") Then 'is it custom?
                                IsCustomEP = True 'if it is, keep this on true and save entrypoint
                                Entrypoint = ReadingEntrypoint.Replace("[custom]", "").Replace(vbCrLf, "").TrimEnd(vbCrLf)
                            Else
                                Entrypoint = Line.Replace("entrypoint=", "").Replace(vbCrLf, "").TrimEnd(vbCrLf) 'if not keep it false (default) and save entrypoint
                            End If
                        End If
                    ElseIf ReadingMetadataMode = False And Line.StartsWith(";") = False Then 'if we reach end of file (absolutely nothing else)

                        'TODO: uncomment the next block of code somewhere else the custom entrypoint IS used

                        'If IsCustomEP = True Then
                        '    Dim CustomizedEntryPoint As String = Entrypoint.Replace("%audioeditor%", My.Settings.AudioEditorPath).Replace("%videoeditor%", My.Settings.VideoEditorPath).Replace("%recorderpath%", My.Settings.RecorderPath).Replace("%64player", Application.StartupPath + "\Engine\64Player.exe")
                        'ElseIf IsCustomEP = False Then
                        '    nothing
                        'End If
                        ' Return to the addon console: Item <name> Added.
                        'debug
                        Addonlist.Add(New Addon(Name, Type, Description, AVersion, Identifier, Entrypoint, IsCustomEP, Author))
                        IsCustomEP = False
                    End If
                Next
                LoadedAddonsList.Dispose()
            Catch ex As IO.DirectoryNotFoundException
                ''Return to the console: ADDON INSTALL ERROR <exception>
                MsgBox("WARNING: Could not load the addon list. Exception: " + ex.ToString, MsgBoxStyle.OkOnly, "OOPS!")
            End Try
        End Sub
    End Class
    Public Function GetDataFromID(id As String, info As Byte)
        For Each AddonItem As Addon In AddonData.Addonlist
            If AddonItem.ID = id Then
                If info = 0 Then 'get name
                    Return AddonItem.Name
                ElseIf info = 1 Then 'get type
                    Return AddonItem.Type
                ElseIf info = 2 Then 'get description
                    Return AddonItem.Version
                ElseIf info = 3 Then 'get version
                    Return AddonItem.Version
                ElseIf info = 4 Then 'get entrypoint
                    Return AddonItem.Entrypoint
                ElseIf info = 5 Then 'get if it has a custom entrypoint
                    Return AddonItem.Description.ToString
                End If
            Else
                Return "!nothing" 'return a tag that should be used as an identifier so we know the search had no matches
            End If
        Next
    End Function
    Public Class Addon
        Public Name As String
        Public Type As String
        Public Description As String
        Public Version As String
        Public ID As String
        Public Entrypoint As String
        Public IsCustomEntryPoint As Boolean
        Public Author As String

        Public Sub New(nname As String, ntype As String, ndesc As String, nvers As String, nid As String, nentry As String, ncustomentry As Boolean, nauthor As String)
            Name = nname
            Type = ntype
            Description = ndesc
            Version = nvers
            ID = nid
            Entrypoint = nentry
            IsCustomEntryPoint = ncustomentry
            Author = nauthor
        End Sub
    End Class

End Class
