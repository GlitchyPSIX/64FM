Public Class cheatModeSel

    Private Sub EssentialsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EssentialsBtn.Click
        cheatEssentials.Show()
        Me.Close()
    End Sub

    Private Sub WebBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebBtn.Click
        webCheatSearch.Show()
        Me.Close()
    End Sub
End Class