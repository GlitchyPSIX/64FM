Public Class Fixes
    ''' <summary>
    ''' Attempts to avoid EEPROM errors by closing any invisible instances of PJ64 (1.7) in the background.
    ''' </summary>
    ''' <param name="Restart">Shall it restart rather than just closing?</param>
    ''' <param name="Forced">Shouldn't ask for confirmation?</param>
    Public Shared Sub NoGhosts(ByVal Restart As Boolean, ByVal Forced As Boolean, ByVal ROM As String)
        If Forced = False Then
            If Restart = True Then
                Dim Question As DialogResult = MsgBox("Attempt to restart PJ64." + vbCrLf + "Do you want to restart it?", MessageBoxButtons.YesNo + MsgBoxStyle.Information, "Attempt.")
                If Question = DialogResult.Yes Then
                    For Each p As Process In Process.GetProcessesByName("project64")
                        p.Kill()
                    Next
                    MainMenu.EMUProcess = Process.Start(Application.StartupPath & "\Core\Emu\Project64.exe", Chr(34) & Application.StartupPath & "\ROMs\" + ROM + Chr(34))
                End If
            Else
                Dim Question As DialogResult = MsgBox("Attempt to restart/close PJ64." + vbCrLf + "Do you want to restart/close it?", MessageBoxButtons.YesNo + MsgBoxStyle.Information, "Attempt.")
                If Question = DialogResult.Yes Then
                    For Each p As Process In Process.GetProcessesByName("project64")
                        p.Kill()
                    Next
                    MainMenu.EMUProcess = Process.Start(Application.StartupPath & "\Core\Emu\Project64.exe", Chr(34) & Application.StartupPath & "\ROMs\" + ROM + Chr(34))
                End If
            End If
        End If
        If Restart = True Then

            For Each p As Process In Process.GetProcessesByName("project64")
                p.Kill()
            Next
            MainMenu.EMUProcess = Process.Start(Application.StartupPath & "\Core\Emu\Project64.exe", Chr(34) & Application.StartupPath & "\ROMs\" + ROM + Chr(34))
        Else
            For Each p As Process In Process.GetProcessesByName("project64")
                p.Kill()
            Next
        End If

    End Sub
End Class
