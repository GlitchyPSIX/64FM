Public NotInheritable Class AboutBox

    Private Sub AboutBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        MemoryNumber.Text = "Available physical memory for your installed RAM: " + My.Computer.Info.AvailablePhysicalMemory.ToString + "/" + My.Computer.Info.TotalPhysicalMemory.ToString + vbCrLf + "Available virtual memory for " + My.Computer.Info.OSFullName.TrimEnd("Pro").ToString + ": " + My.Computer.Info.AvailableVirtualMemory.ToString + "/" + My.Computer.Info.TotalVirtualMemory.ToString
        AssignedTo.Text = "Registered under the nickname of " + My.Settings.Name + " in the computer called " + My.Computer.Name.ToString + " with the OS called " + My.Computer.Info.OSFullName + "(" + My.Computer.Info.OSPlatform + " " + My.Computer.Info.OSVersion + ")"
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub
End Class
