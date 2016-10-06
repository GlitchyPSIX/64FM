Public Class AddonSettingsForm
    Private Sub AddonListView_lv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AddonListView_lv.SelectedIndexChanged

    End Sub

    Private Sub UpdateList_btn_Click(sender As Object, e As EventArgs) Handles UpdateList_btn.Click
        AddonLister.RepopulateFromDefault(AddonListView_lv)
    End Sub
End Class