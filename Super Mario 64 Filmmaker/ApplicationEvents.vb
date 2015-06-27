Namespace My
    Partial Friend Class MyApplication
        Private Sub MyApplication_StartupNextInstance(sender As Object, e As ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            MsgBox("SM64FM Is already running.")
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            MsgBox("Found a exception which couldn't be controlled, and SM64FM will be closed. Sorry for the incoveniences.")
        End Sub
    End Class
End Namespace

