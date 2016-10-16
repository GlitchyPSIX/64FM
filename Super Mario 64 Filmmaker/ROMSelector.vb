Imports System.IO
Public Class ROMSelector
    Private Sub Cancelbtn_Click(sender As Object, e As EventArgs) Handles Cancelbtn.Click
        Me.Close()
    End Sub

    Public Sub UpdateList()

        If Directory.Exists(Application.StartupPath + "\ROMs\") Then
            romselLB.Items.Clear()
            Dim Z64ROMS As String()
            Dim N64ROMS As String()
            Dim V64ROMS As String()
            Z64ROMS = Directory.GetFiles(Application.StartupPath + "\ROMs\", "*.z64")
            N64ROMS = Directory.GetFiles(Application.StartupPath + "\ROMs\", "*.n64")
            V64ROMS = Directory.GetFiles(Application.StartupPath + "\ROMs\", "*.v64")
            For Each file As String In Z64ROMS
                file = file.Replace(Application.StartupPath + "\ROMs\", "")
                romselLB.Items.Add(file)
            Next
            For Each file As String In N64ROMS
                file = file.Replace(Application.StartupPath + "\ROMs\", "")
                romselLB.Items.Add(file)
            Next
            For Each file As String In V64ROMS
                file = file.Replace(Application.StartupPath + "\ROMs\", "")
                romselLB.Items.Add(file)
            Next
            If Z64ROMS.Count = 0 And N64ROMS.Count = 0 And V64ROMS.Count Then
                OKbtn.Enabled = False
            End If
        Else
            Directory.CreateDirectory(Application.StartupPath + "\ROMs\")
            End If
    End Sub

    Private Sub OKbtn_Click(sender As Object, e As EventArgs) Handles OKbtn.Click
        'Search for PJ64 and start it
        If GetEmuProcess("64Player") = Nothing Then
            Try
                MainMenu.EMUProcess = Process.Start(Application.StartupPath & "\Engine\64Player.exe", Chr(34) & Application.StartupPath & "\ROMs\" + romselLB.SelectedItem + Chr(34))
            Catch ex As Exception
                MsgBox("Hold on, either the core ROM or the emulator failed to open.")
            End Try
        Else
            Dim Question As DialogResult = MsgBox("It seems PJ64 is still running. If you can't see it, it means it has crashed or ghosted in the background." + vbCrLf + "Do you want to restart it?", MessageBoxButtons.YesNo + MsgBoxStyle.Information, "PJ64 is still running.")
            If Question = DialogResult.Yes Then
                Fixes.NoGhosts(True, True, romselLB.SelectedItem.ToString)
            End If
        End If

    End Sub

    Private Sub ROMSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateList()
    End Sub
End Class