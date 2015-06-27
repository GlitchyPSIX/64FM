Public NotInheritable Class AboutBox

    Private Sub AboutBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler OKButton.Click, AddressOf Me.Close

        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        MemoryNumber.Text = "Available physical RAM: " + CStr(Math.Round(My.Computer.Info.AvailablePhysicalMemory / (1024 ^ 2), 0)) + " MB/" + CStr(Math.Round(My.Computer.Info.TotalPhysicalMemory / (1024 ^ 2), 0)) + " MB" + vbCrLf + "Available virtual memory: " + CStr(Math.Round(My.Computer.Info.AvailableVirtualMemory / (1024 ^ 2), 0)) + " MB/" + CStr(Math.Round(My.Computer.Info.TotalVirtualMemory / (1024 ^ 2), 0)) + " MB"
        AssignedTo.Text = "Registered to " + My.Settings.Name + " on the computer """ + My.Computer.Name.ToString + """ running " + My.Computer.Info.OSFullName + " (" + My.Computer.Info.OSPlatform + " " + My.Computer.Info.OSVersion + ")"
    End Sub
End Class
