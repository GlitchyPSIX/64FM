Public Class glitchyessentials

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start(Application.StartupPath & "\Engine\Vegas10.exe")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cheat1.Click
        cheatBox.Text = "D133AFA0 8000" + vbCrLf + "8133B1BC 4220"
        infoBox.Text = "This will allow you to go up while on air. Press A to go up when in-air. This moonjump does not break behaviours."
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles copyCodebtn.Click
        Clipboard.SetText(cheatBox.Text)
        cheatBox.Text = ""
        MsgBox("Copied to Clipboard!")
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If cheatBox.Text = "" Then
            copyCodebtn.Enabled = False
            clearBtn.Enabled = False
        Else
            copyCodebtn.Enabled = True
            clearBtn.Enabled = True
        End If
    End Sub

    Private Sub clearBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearBtn.Click
        cheatBox.Text = ""
        infoBox.Text = ""
        Timer1.Enabled = True
        Timer1.Interval = 1
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cheatBox.Text = "D033AFA1 0001" + vbCrLf + "8033B205 0001" + vbCrLf + "D033AFA1 0002" + vbCrLf + "8033B205 0033"
        infoBox.Text = "This cheat will allow you to freeze the camera to where you are at that moment. C-RIGHT to freeze it, C-LEFT to unfreeze it."
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cheat3.Click
        cheatBox.Text = "8033B177 0001"
        infoBox.Text = "This cheat allows Mario to be capless instantly you activate this cheat. Non-F2P TF2 Players maybe don't like this option..."
    End Sub

    Private Sub cheat4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cheat4.Click
        cheatBox.Text = "812689C0 2400"
        infoBox.Text = "This code avoids Mario's blinking when gets damage from any source that is not fire, because fire doesn't blink when hit. Perfect for Green Screens."
    End Sub

    Private Sub cheat5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cheat5.Click
        cheatBox.Text = "D033AFA0 0008" + vbCrLf + "8033D3D0 0001" + vbCrLf + "D033AFA0 0004" + vbCrLf + "8033D3D0 0000" + vbCrLf + "8133D2D0 27BD" + vbCrLf + "8133D2D2 FFE8" + vbCrLf + "8133D2D4 AFBF" + vbCrLf + "8133D2D6 0014" + vbCrLf + "8133D2D8 3C04" + vbCrLf + "8133D2DA 8034" + vbCrLf + "8133D2DC 0C0A" + vbCrLf + "8133D2DE 943F" + vbCrLf + "8133D2E0 9084" + vbCrLf + "8133D2E2 D3D0" + vbCrLf + "8133D2E4 8FBF" + vbCrLf + "8133D2E6 0014" + vbCrLf + "8133D2E8 27BD" + vbCrLf + "8133D2EA 0018" + vbCrLf + "8133D2EC 03E0" + vbCrLf + "8133D2EE 0008" + vbCrLf + "810EE060 8033" + vbCrLf + "810EE062 D2D0"
        infoBox.Text = "This will make your screen rumble like if a Thwomp hit the ground. Credit to Yoshielectron. D-PAD Up to make screen rumble. D-Pad Down to make it stop."
    End Sub

    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cheat6.Click
        cheatBox.Text = "D033AFA0 0008" + vbCrLf + "8133B1BC 41F8" + vbCrLf + "D033AFA0 0004" + vbCrLf + "8133B1BC C1F8" + vbCrLf + "D033AFA0 0002" + vbCrLf + "8133B1BC 3000" + vbCrLf + "D033AFA0 0001" + vbCrLf + "812569AC 2400" + vbCrLf + "D133AFA0 0110" + vbCrLf + "812569AC E708"
        infoBox.Text = "The name says all. Press D-Pad Right to set it to 0, and R+Dpad Right to make it Normal. Only applies to Mario, though."
    End Sub

    Private Sub cheat7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cheat7.Click
        cheatBox.Text = "812E3DB0 0000" + vbCrLf + "812E3DB2 0000" + vbCrLf + "812E3DE0 0000" + vbCrLf + "812E3DE2 0000" + vbCrLf + "812E3E18 0000" + vbCrLf + "812E3E1A 0000" + vbCrLf + "812E3DC8 0000" + vbCrLf + "812E3DCA 0000"
        infoBox.Text = "THIS IS REQUIRED TO MAKE GOOD VIDEOS, USING GREEN SCREEN OR NOT." + vbCrLf + "This removes the 90% of the HUD, making everything look less -game-."
    End Sub

    Private Sub cheat8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cheat8.Click
        cheatBox.Text = "8134125C 8017" + vbCrLf + "8134125E 58C0" + vbCrLf + "81341284 8013" + vbCrLf + "81341286 6620" + vbCrLf + "8134141E D0BC" + vbCrLf + "8034124B 0021" + vbCrLf + "8133B424 5959" + vbCrLf + "81161D04 1111" + vbCrLf + "81161D06 1111" + vbCrLf + "811623C4 1111" + vbCrLf + "811623C6 1111" + vbCrLf + "812FC70E 2EC0" + vbCrLf + "8107EC80 7F60" + vbCrLf + "8107EC82 3C00" + vbCrLf + "8107EC84 7F60" + vbCrLf + "8107EC86 3C00" + vbCrLf + "8107EC88 7F60" + vbCrLf + "8107EC8A 3C00" + vbCrLf + "8107EC8C 7F60" + vbCrLf + "8107EC8E 3C00" + vbCrLf + "8107EC98 3903" + vbCrLf + "8107EC9A 0000" + vbCrLf + "8107EC9C 3903" + vbCrLf + "8107EC9E 0000" + vbCrLf + "8107ECA0 3903" + vbCrLf + "8107ECA2 0000" + vbCrLf + "8107ECA4 3903" + vbCrLf + "8107ECA6 0000" + vbCrLf + "8107EC68 390E" + vbCrLf + "8107EC6A 0700" + vbCrLf + "8107EC6C 390E" + vbCrLf + "8107EC6E 0700" + vbCrLf + "8107EC70 390E" + vbCrLf + "8107EC72 0700" + vbCrLf + "8107EC74 390E" + vbCrLf + "8107EC76 0700" + vbCrLf + "8107EC50 7F7F" + vbCrLf + "8107EC52 7F00" + vbCrLf + "8107EC54 7F7F" + vbCrLf + "8107EC56 7F00" + vbCrLf + "8107EC58 7F7F" + vbCrLf + "8107EC5A 7F00" + vbCrLf + "8107EC5C 7F7F" + vbCrLf + "8107EC5E 7F00" + vbCrLf + "8107EC20 0000" + vbCrLf + "8107EC22 7F00" + vbCrLf + "8107EC24 0000" + vbCrLf + "8107EC26 7F00" + vbCrLf + "8107EC28 0000" + vbCrLf + "8107EC2A 7F00" + vbCrLf + "8107EC2C 0000" + vbCrLf + "8107EC2E 7F00" + vbCrLf + "8107EC38 0040" + vbCrLf + "8107EC3A 0000" + vbCrLf + "8107EC3C 0040" + vbCrLf + "8107EC3E 0000" + vbCrLf + "8107EC40 0040" + vbCrLf + "8107EC42 0000" + vbCrLf + "8107EC44 0040" + vbCrLf + "8107EC46 0000" + vbCrLf + "812535C2 3FC0" + vbCrLf + "812535BE 3F40" + vbCrLf + "8133D2D0 27BD" + vbCrLf + "8133D2D2 FFE8" + vbCrLf + "8133D2D4 AFBF" + vbCrLf + "8133D2D6 0014" + vbCrLf + "8133D2D8 3C06" + vbCrLf + "8133D2DA 8034" + vbCrLf + "8133D2DC 90C4" + vbCrLf + "8133D2DE D3D0" + vbCrLf + "8133D2E0 2484" + vbCrLf + "8133D2E2 0001" + vbCrLf + "8133D2E4 A0C4" + vbCrLf + "8133D2E6 D3D0" + vbCrLf + "8133D2E8 2405" + vbCrLf + "8133D2EA 0010" + vbCrLf + "8133D2EC 0C0B" + vbCrLf + "8133D2EE 59B0" + vbCrLf + "8133D2F0 24C6" + vbCrLf + "8133D2F2 D3E0" + vbCrLf + "8133D2F4 8FBF" + vbCrLf + "8133D2F6 0014" + vbCrLf + "8133D2F8 27BD" + vbCrLf + "8133D2FA 0018" + vbCrLf + "8133D2FC 03E0" + vbCrLf + "8133D2FE 0008" + vbCrLf + "810EE060 8033" + vbCrLf + "810EE062 D2D0" + vbCrLf + "8133D3E0 4C55" + vbCrLf + "8133D3E2 4947" + vbCrLf + "8133D3E4 4920" + vbCrLf + "8133D3E6 554E" + vbCrLf + "8133D3E8 4C4F" + vbCrLf + "8133D3EA 434B" + vbCrLf + "8133D3EC 4544" + vbCrLf + "8131CC02 3F00" + vbCrLf + "8126B828 8FAD" + vbCrLf + "8126B832 1080" + vbCrLf + "8126B836 08A4" + vbCrLf + "8033B3BC 0000" + vbCrLf + "D033AFA1 0020" + vbCrLf + "8133B1BC 4220" + vbCrLf + "D033B1BD 0020" + vbCrLf + "8133B17C 0300" + vbCrLf + "D033B1BD 0020" + vbCrLf + "8133B17E 0880" + vbCrLf + "812FE0A6 0020"
        infoBox.Text = "This cheat changes the color code from red cap and shirt, to grenn ones, makes you taller and also has the sparkly triple jump that was in the BETA. You need to activate this before the title screen in order to work."
    End Sub

    Private Sub cheatLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cheatLast.Click
        cheatBox.Text = "8026B88B 0018"
        infoBox.Text = "Triple Jump, after you're freezed in the ground, press B to make like you actually didn't land, making you go with more strength."
    End Sub

End Class
