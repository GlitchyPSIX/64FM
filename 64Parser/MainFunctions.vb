Imports System.IO
Public Class MainFunctions
    ''' <summary>
    ''' Reads the metadata from an addon/autoscript file.
    ''' </summary>
    ''' <param name="filepath">The path to the file to load.</param>
    ''' <param name="Type">The analyzing type.
    ''' 1: Addon Name
    ''' 2: Author Name
    ''' 3: Addon Description
    ''' 4: Addon Version</param>
    ''' <returns>What was requested in Type</returns>
    Public Shared Function ReadMetadata(filepath As String, Type As Byte)
        Try
            Using SelectedFile As New StreamReader(filepath) 'Declare the selected file as the file path specified
                Dim SplittedFile As String() = SelectedFile.ReadToEnd.Split(vbLf)
                If Type = 0 Then
                    ' Get Name and return name.
                    For Each Line As String In SplittedFile
                        If Line.StartsWith("name=") Then
                            Return Line.Replace("name=""", "").Replace(ControlChars.Quote, "")
                        End If
                    Next
                End If
                If Type = 1 Then
                    ' Get Author and return the author's nick.
                    For Each Line As String In SplittedFile
                        If Line.StartsWith("author=") Then
                            Return Line.Replace("author=""", "").Replace(ControlChars.Quote, "")
                        End If
                    Next
                End If
                If Type = 2 Then
                    ' Get Description and return the addon's description.
                    For Each Line As String In SplittedFile
                        If Line.StartsWith("description=") Then
                            Return Line.Replace("description=""", "").Replace(" [nl] ", vbCrLf).Replace(ControlChars.Quote, "")
                        End If
                    Next
                End If
                If Type = 3 Then
                    ' Get Version and return the addon's version.
                    For Each Line As String In SplittedFile
                        If Line.StartsWith("version=") Then
                            Return Line.Replace("version=""", "").Replace(ControlChars.Quote, "")
                        End If
                    Next
                End If
                If Type > 4 Or Type < 0 Then
                    Return "Invalid Instruction" 'Invalid
                End If
            End Using
        Catch ex As Exception
            Return "ERROR404_NOTFOUND"
        End Try
    End Function

    'omg i am so bad at coding that i had to go to stackoverflow for this one (sorta)

    ''' <summary>
    ''' Gets the Addon type from the loaded file.
    ''' </summary>
    ''' <param name="filepath">The file path of the .fma/.aus to load</param>
    ''' <returns>The addon type.</returns>
    Public Shared Function GetAddonType(filepath As String)
        Using LoadedFile As New StreamReader(filepath) 'Load file
            Dim SplittedFile As String() = LoadedFile.ReadToEnd.Split(vbLf) 'SPLITTO
            Dim AddonStyle As String 'Say we want to have a string that says the addon type as a string (the end program must do something with this!)
            For Each line As String In SplittedFile 'check for each line if it starts with "type="
                If line.StartsWith("type=") Then
                    AddonStyle = line.Replace("type=", "")
                    Return AddonStyle 'in case yes, return the addontype that we got as a string
                Else
                    'IN CASE NOT, DO NOTHING BECAUSE WE'RE LAZEH
                End If
            Next
        End Using
    End Function

    ''' <summary>
    ''' Reads the [content] section of a .fma/.aus file (Used to know what to do with it.)
    ''' FMA: File list bundled into the .zip.
    ''' AUS: M64MM Commands to execute.
    ''' </summary>
    ''' <param name="filepath">The path to the file.</param>
    ''' <param name="FileContentMode">Are we loading as FMA mode? (Use in logical conjuction with "GetAddonType()")</param>
    ''' <returns>A list of commands/files.</returns>
    Public Shared Function ReadContents(filepath As String, Optional FileContentMode As Boolean = False)
        If FileContentMode = False Then 'If it's not the FMA mode...
            Dim Commandlist = New List(Of String)
            Try
                Using File As New StreamReader(filepath)
                    Dim line As String = File.ReadLine()
                    Dim take = False
                    Do While line IsNot Nothing 'let's clean
                        If line.StartsWith("[content]") Then 'If we hit the [content] tag, PASS
                            take = True
                        End If
                        If take And Not String.IsNullOrEmpty(line) And Not String.Equals("[content]", line) Then
                            If line.Equals("[/content]") Or line.StartsWith("type=") Then 'if it's either the type string or the end tag for [content]
                                'Nothing
                            Else 'or else, add it to the commandlist
                                Commandlist.Add(line)
                            End If
                        End If
                        If String.Equals("[/content]", line) Then 'if we hit the end tag for [content] simply not take it (will reach end of file and streamreader will end)
                            take = False
                        End If
                        line = File.ReadLine()
                    Loop
                End Using
                Return Commandlist
            Catch ex As Exception
                Return ex 'WHAT IS THIS, EXCEPTION? HERESY!!!!1!!!!
            End Try
        ElseIf FileContentMode = True Then 'In case it's the FMA mode
            Dim Filelist = New List(Of String)
            Try
                Using File As New StreamReader(filepath)
                    Dim line As String = File.ReadLine()
                    Dim take = False
                    Do While line IsNot Nothing
                        If line.StartsWith("[content]") Then
                            take = True
                        End If
                        If take And Not String.IsNullOrEmpty(line) And Not String.Equals("[content]", line) Then
                            'do same but just the filenames (64FM will append
                            'the temp extracted directory to copy the required files in certain modes)
                            If line.Equals("[/content]") Or line.StartsWith("type=") Then
                                'Nothing
                            Else
                                Filelist.Add(line.Replace("file ", ""))
                            End If
                        End If
                        If String.Equals("[/content]", line) Then
                            take = False
                        End If
                        line = File.ReadLine()
                    Loop
                End Using
                Return Filelist
            Catch ex As Exception
                Return ex 'WHAT DO YOU CALL AN INTELLIGENT ITALIAN?
                'AN EXCEPTIONNNNNNNNNN
                '-Zenon, 2016
                'ok no i actually said that but it was a voice acting script but IT STILL COUNTS SHUNKSGSJSHGS
            End Try
        End If
    End Function
End Class
