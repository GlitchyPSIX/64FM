Public Class extractSel
    Private Sub btnShowPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowPath.Click
        Try
            Process.Start(Application.StartupPath)
        Catch ex As System.ComponentModel.Win32Exception
            MsgBox("Is SM64FM correctly installed?")
        End Try
    End Sub

    Private Sub btnSFX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSFX.Click
        Try
            Process.Start(Application.StartupPath + "\Engine\SFX.exe")
        Catch ex As System.ComponentModel.Win32Exception
            MsgBox("Couldn't find the required file... Is SM64FM correctly installed?")
        End Try
    End Sub

    Private Sub btnSND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSND.Click
        Try
            Process.Start(Application.StartupPath + "\Engine\ST.exe")
        Catch ex As System.ComponentModel.Win32Exception
            MsgBox("Couldn't find the required file... Is SM64FM correctly installed?")
        End Try
    End Sub

    Private Sub btnCHR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCHR.Click
        Try
            Process.Start(Application.StartupPath + "\Engine\CHR.exe")
        Catch ex As System.ComponentModel.Win32Exception
            MsgBox("Couldn't find the required file... Is SM64FM correctly installed?")
        End Try
    End Sub

    Private Sub btnWLD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWLD.Click
        Try
            Process.Start(Application.StartupPath + "\Engine\WLD.exe")
        Catch ex As System.ComponentModel.Win32Exception
            MsgBox("Couldn't find the required file... Is SM64FM correctly installed?")
        End Try
    End Sub

    Private Sub btnVC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVC.Click
        Try
            Process.Start(Application.StartupPath + "\Engine\VFX.exe")
        Catch ex As System.ComponentModel.Win32Exception
            MsgBox("Couldn't find the required file... Is SM64FM correctly installed?")
        End Try
    End Sub
End Class