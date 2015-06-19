Imports System.Text
Imports Ionic.Zip
Public Class Extractor
    Public Shared Function LoadAndDecompress(ByVal FileName As String, ByVal Extension As String, ByVal Filter As String)
        Dim OpenFileDlg As New OpenFileDialog
        OpenFileDlg.FileName = FileName ' Default file name
        OpenFileDlg.DefaultExt = Extension ' Default file extension
        OpenFileDlg.Filter = Filter 'The files... extensions to search.
        OpenFileDlg.Multiselect = False 'Please, only one file.
        OpenFileDlg.RestoreDirectory = True 'In calse of the dialogbox closing, restore the last seen directory in the dialogbox.
        Dim ButtonResult As Boolean = DialogResult.OK
        ' Show open file dialog box and set the "Opened?" boolean value
        Dim result As Boolean = OpenFileDlg.ShowDialog()
        ' Process open file dialog box results
        If result = True Then
            If DialogResult.OK Then
                MsgBox(OpenFileDlg.FileName) 'DEBUG FEATURE: Make sure you know the path
                My.Computer.FileSystem.CurrentDirectory = My.Computer.FileSystem.SpecialDirectories.Temp 'Scope to the user's TEMP folder
                If My.Computer.FileSystem.DirectoryExists("SM64FM") = True Then 'If SM64FM Temp folder exists...
                    MsgBox("There is a temporal folder already...") 'Show it in a MSGBOX
                    My.Computer.FileSystem.DeleteDirectory("SM64FM", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing) 'Delete temp folder
                    My.Computer.FileSystem.CreateDirectory("SM64FM") 'Create a temporal folder to extract the files
                Else 'If it doesn't exists...
                    My.Computer.FileSystem.CreateDirectory("SM64FM") 'Create a temporal folder to extract the files
                    MsgBox("Sucess: Directory Found") 'DEBUG FEATURE: Tell that the directory has been created by finding it
                End If
                Dim ZipToUnpack As String = OpenFileDlg.FileName 'The file to unpack there (Filename)
                Dim UnpackDirectory As String = My.Computer.FileSystem.SpecialDirectories.Temp + "/SM64FM" 'Set the unpack directory, i.e. SM64FM's recently created temp folder
                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack) 'Ionic.Zip Extract
                    Dim ze As ZipEntry
                    For Each ze In zip1
                        ze.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently) 'Extract in temp folder
                    Next
                End Using 'After extracting...
                My.Computer.FileSystem.CurrentDirectory = Application.StartupPath 'Scope to SM64FM's root
                My.Computer.FileSystem.CreateDirectory("Addons/addon") 'Create the addon folder.
                My.Computer.FileSystem.CopyDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "SM64FM", Application.StartupPath + "/Addons/addon") 'Copy the contents of the temp folder to the addon folder
                My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "SM64FM", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing) 'Delete temp
                Return True 'Filler
            Else 'In case user click Exit or Cancel
                'do nothing.
                Return False 'Filler.
            End If
        ElseIf DialogResult.OK = False Then 'If dialogbox doesn't appear...
            Return Nothing 'Filler
        End If
        Return Nothing 'Filler
    End Function
End Class
