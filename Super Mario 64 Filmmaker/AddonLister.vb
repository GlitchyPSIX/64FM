Imports Filmmaker.AddonModule

Public Class AddonLister
    Public Shared Sub RepopulateFromDefault(ListViewToPopulate As ListView)
        Dim Name As String = ""
        Dim Type As String = ""
        Dim ReadingEntrypoint As String = ""
        Dim Entrypoint As String = ""
        Dim IsCustomEP As Boolean
        AddonData.Addonlist.Clear()
        AddonData.RepopulateFromDefault()
        For Each addonItem As Addon In AddonData.Addonlist
            Dim ListItem As New ListViewItem
            ListItem.Text = addonItem.Name
            If addonItem.Type.Equals("eyepak") Then
                ListItem.SubItems.Add("Eyepack")
            ElseIf Type.Equals("rom") Then
                ListItem.SubItems.Add("ROM")
            ElseIf Type.Equals("tex") Then
                ListItem.SubItems.Add("Textures")
            ElseIf Type.Equals("ppf") Then
                ListItem.SubItems.Add("DLC")
            Else
                ListItem.SubItems.Add("File")
            End If
            If addonItem.IsCustomEntryPoint = True Then
                Dim CustomizedEntryPoint As String = addonItem.Entrypoint.Replace("%audioeditor%", My.Settings.AudioEditorPath).Replace("%videoeditor%", My.Settings.VideoEditorPath).Replace("%recorderpath%", My.Settings.RecorderPath).Replace("%64player%", Application.StartupPath + "\Engine\Project64.exe")
                ListItem.SubItems.Add(CustomizedEntryPoint)
                IsCustomEP = False
            ElseIf IsCustomEP = False Then
                ListItem.SubItems.Add(addonItem.Entrypoint)
            End If
            ListViewToPopulate.Items.Clear()
            ListViewToPopulate.Items.Add(ListItem)
            ' Return to the addon console: Item <name> Added.
            'debug
        Next
    End Sub
End Class
