Imports Newtonsoft.Json
Imports System.IO
Public Class JsonDeSeserializerTest
    Public Sub DeserializeFile()
        Dim FileDialog As New OpenFileDialog
        Dim result As DialogResult = FileDialog.ShowDialog()
        If result = DialogResult.OK Then
            For Each filename As String In FileDialog.FileNames
                Dim sr As New StreamReader(filename)
                Dim addon As Addon = JsonConvert.DeserializeObject(Of Addon)(sr.ReadToEnd)
                MsgBox(addon.Name + vbCrLf + addon.Type + vbCrLf + addon.Version)
            Next
        End If
    End Sub
End Class

Public Class Addon
    Public Name As String
    Public Version As String
    Public Type As String
End Class
