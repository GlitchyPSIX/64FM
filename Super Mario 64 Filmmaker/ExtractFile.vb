Imports System.Text
Imports Ionic.Zip

Public Class Extractor
    Public Shared Function TempAddon(ByVal FileName As String, ByVal Extension As String, ByVal Filter As String, DelTemp As Boolean, Optional passwordzip As String = "1234")
        If DelTemp = False Then
            Dim OpenFileDlg As New OpenFileDialog
            OpenFileDlg.FileName = FileName ' Default file name
            OpenFileDlg.DefaultExt = Extension ' Default file extension
            OpenFileDlg.Filter = Filter 'The files... extensions to search.
            OpenFileDlg.Multiselect = False 'Please, only one file.
            OpenFileDlg.RestoreDirectory = True 'In calse of the dialogbox closing, restore the last seen directory in the dialogbox.
            Dim ButtonResult As Boolean = DialogResult.OK
            ' Show open file dialog box and set the "Opened?" boolean value
            Dim result As DialogResult = OpenFileDlg.ShowDialog()
            ' Process open file dialog box results
            If result = DialogResult.OK Then
                MsgBox(OpenFileDlg.FileName) 'DEBUG FEATURE: Make sure you know the path
                My.Computer.FileSystem.CurrentDirectory = My.Computer.FileSystem.SpecialDirectories.Temp 'Scope to the user's TEMP folder
                If My.Computer.FileSystem.DirectoryExists("64FM_addon") = True Then 'If SM64FM Temp folder exists...
                    MsgBox("There is a temporary folder there already...") 'DEBUG FEATURE: Show it in a MSGBOX
                    My.Computer.FileSystem.DeleteDirectory("64FM_addon", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing) 'Delete temp folder
                    My.Computer.FileSystem.CreateDirectory("64FM_addon") 'Create a temporal folder to extract the files
                Else 'If it doesn't exist...
                    My.Computer.FileSystem.CreateDirectory("64FM_addon") 'Create a temporal folder to extract the files
                    MsgBox("Success: Directory Found") 'DEBUG FEATURE: Tell that the directory has been created by finding it
                End If
                Dim ZipToUnpack As String = OpenFileDlg.FileName 'The file to unpack there (Filename)
                Dim UnpackDirectory As String = My.Computer.FileSystem.SpecialDirectories.Temp + "/64FM_addon" 'Set the unpack directory, i.e. 64FM's recently created temp folder
                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack) 'Ionic.Zip Extract
                    Dim ze As ZipEntry
                    Try
                        For Each ze In zip1
                            ze.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently) 'Extract in temp folder
                        Next
                        Return True
                    Catch ex As BadPasswordException
                        Try
                            For Each ze In zip1
                                ze.ExtractWithPassword(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently, passwordzip)
                            Next
                            Return True
                        Catch exo As BadPasswordException
                            MsgBox("(Possibly the password is wrong.)")
                            Return False
                        End Try
                    End Try
                End Using
                Return True 'Filler
            Else 'In case user click Exit or Cancel
                'do nothing.
                Return False 'Filler.
            End If
        ElseIf DelTemp = True Then
            My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\64FM_addon", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing) 'Delete temp
        End If
        Return Nothing 'Filler
    End Function
End Class
