Imports _64Parser
Imports Filmmaker.Extractor
Imports System.IO
Public Class AddonSettingsForm
    Private Sub AddonListView_lv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AddonListView_lv.SelectedIndexChanged

    End Sub

    Private Sub UpdateList_btn_Click(sender As Object, e As EventArgs) Handles UpdateList_btn.Click
        AddonLister.RepopulateFromDefault(AddonListView_lv)
    End Sub

    Private Sub AddAddon_pb_Click(sender As Object, e As EventArgs) Handles AddAddon_pb.Click
        Dim Extracted As Boolean = TempAddon("Addon", "fmz", "64Filmmaker Addon|*.fmz", False)
        Dim metadata As String = My.Computer.FileSystem.SpecialDirectories.Temp + "\64FM_addon\addon.fma"
        If Extracted = True Then
            Dim Type As String = MainFunctions.GetAddonType(metadata)
            If Type.StartsWith("autoscript") Then

            ElseIf Type.Contains("ricevideo") Then
                Dim Eyelist As List(Of String) = MainFunctions.ReadContents(metadata, True)
                Dim safename As String = MainFunctions.ReadMetadata(metadata, 4)
                Dim name As String = MainFunctions.ReadMetadata(metadata, 0)
                Dim author As String = MainFunctions.ReadMetadata(metadata, 1)
                Dim vers As String = MainFunctions.ReadMetadata(metadata, 3)
                Dim desc As String = MainFunctions.ReadMetadata(metadata, 2)
                Directory.CreateDirectory(Application.StartupPath + "\Addon\Texture\" + safename)
                Try
                    For Each Filename As String In Eyelist
                        File.Copy(My.Computer.FileSystem.SpecialDirectories.Temp + "\64FM_addon\" + Filename, Application.StartupPath + "\Addon\Texture\" + safename + "\" + Filename, True)
                    Next
                Catch ex As Exception
                    MsgBox("Unexpected error: does not commute" + vbCrLf + ex.ToString)
                End Try
                Dim UpdateAddList As New StreamWriter(Application.StartupPath + "\addonlist.cfg", True)
                UpdateAddList.WriteLine(vbCrLf + "[addon]")
                UpdateAddList.WriteLine("name=" + name)
                UpdateAddList.WriteLine("type=tex")
                UpdateAddList.WriteLine("version=" + vers)
                UpdateAddList.WriteLine("author=" + author)
                UpdateAddList.WriteLine("id=" + safename)
                UpdateAddList.WriteLine("desc=" + desc)
                UpdateAddList.WriteLine("entrypoint=" + "\Addon\Texture\" + safename)
                UpdateAddList.Write("[/addon]")
                UpdateAddList.Dispose()
                UpdateList_btn.PerformClick()
                TempAddon("", "", "", True)

            ElseIf Type.Contains("rom") Then
                Dim ROMlist As List(Of String) = MainFunctions.ReadContents(metadata, True)
                Dim safename As String = MainFunctions.ReadMetadata(metadata, 4)
                Dim name As String = MainFunctions.ReadMetadata(metadata, 0)
                Dim author As String = MainFunctions.ReadMetadata(metadata, 1)
                Dim vers As String = MainFunctions.ReadMetadata(metadata, 3)
                Dim desc As String = MainFunctions.ReadMetadata(metadata, 2)
                Try
                    For Each Filename As String In ROMlist
                        File.Copy(My.Computer.FileSystem.SpecialDirectories.Temp + "\64FM_addon\" + Filename, Application.StartupPath + "\Addon\Texture\" + safename + "\" + Filename, True)
                    Next
                Catch ex As Exception
                    MsgBox("Unexpected error: does not commute" + vbCrLf + ex.ToString)
                End Try
                Dim UpdateAddList As New StreamWriter(Application.StartupPath + "\addonlist.cfg", True)
                UpdateAddList.WriteLine(vbCrLf + "[addon]")
                UpdateAddList.WriteLine("name=" + name)
                UpdateAddList.WriteLine("type=rom")
                UpdateAddList.WriteLine("version=" + vers)
                UpdateAddList.WriteLine("author=" + author)
                UpdateAddList.WriteLine("id=" + safename)
                UpdateAddList.WriteLine("desc=" + desc)
                UpdateAddList.WriteLine("entrypoint=" + "\ROMs\" + safename)
                UpdateAddList.Write("[/addon]")
                UpdateAddList.Dispose()
                UpdateList_btn.PerformClick()
                TempAddon("", "", "", True)
            End If
        End If
    End Sub

    Private Sub AddonSettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class