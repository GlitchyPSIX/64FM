﻿Namespace My
    Partial Friend Class MyApplication

        Private Sub ShakeVeryGently(Speed As Integer) 'lel forgot to edit this commentary
            'Thanks to LeSaN
            'Easy code to make a form shake

            Dim a As Integer 'Declare integer "A"

            While a < 15 'Starting a "while loop"

                'Setting our form's X position to 20 pixels to right from its current position.            
                Form.ActiveForm.Location = New Point(Form.ActiveForm.Location.X, Form.ActiveForm.Location.Y + 10)

                'Telling a program to sleep for Speed miliseconds before continuing
                System.Threading.Thread.Sleep(Speed)

                'Setting our form's X position to 20 pixels to left from its current position.
                Form.ActiveForm.Location = New Point(Form.ActiveForm.Location.X, Form.ActiveForm.Location.Y - 10)

                'Telling a program to sleep for 50 miliseconds before continuing            
                System.Threading.Thread.Sleep(Speed)

                a += 1 'Increasing integer "A" by 1 after each loop

            End While
        End Sub
        'One of the global exceptions we are catching is not thread safe, 
        'so we need to make it thread safe first.
        Private Delegate Sub SafeApplicationThreadException(sender As Object, e As Threading.ThreadExceptionEventArgs)

        Private Sub MyApplication_StartupNextInstance(sender As Object, e As ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            MainMenu.Visible = True
            MainMenu.WindowState = FormWindowState.Normal
        End Sub

        Private Sub ExceptionHandler(ex As Exception)
            ShakeVeryGently(10)
            UnhandledExceptionString = ex.ToString
            ExceptionUnhandledForm.ShowDialog()
            MainForm.Close()
            MainMenu.Visible = False
            Chat.Close()
        End Sub

        Private Sub MyApplication_Startup(sender As Object, e As ApplicationServices.StartupEventArgs) Handles Me.Startup

            'There are three places to catch all global unhandled exceptions:
            'AppDomain.CurrentDomain.UnhandledException event.
            'System.Windows.Forms.Application.ThreadException event.
            'MyApplication.UnhandledException event.
            AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf AppDomain_UnhandledException
            AddHandler System.Windows.Forms.Application.ThreadException, AddressOf app_ThreadException
            ' --------------------------------
            Settings.Upgrade()
        End Sub

        Private Sub app_ThreadException(sender As Object, e As Threading.ThreadExceptionEventArgs)

            'This is not thread safe, so make it thread safe.
            If MainForm.InvokeRequired Then
                ' Invoke back to the main thread
                UnhandledExceptionString = e.ToString
                MainForm.Invoke(New SafeApplicationThreadException(AddressOf app_ThreadException),
                    New Object() {sender, e})
            Else
                ExceptionHandler(e.Exception)
            End If

        End Sub

        Private Sub AppDomain_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs)
            ExceptionHandler(DirectCast(e.ExceptionObject, Exception))
        End Sub
        Public Sub Goodbye()
            Dim Response As DialogResult = MsgBox("You're sure you want to exit 64Filmmaker?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "You're sure?")
            If Response = DialogResult.No Then
                'no
            ElseIf Response = DialogResult.Yes Then
                Try 'try to kill the video editor process
                    MainMenu.VEProcess.Kill()
                Catch e As Exception
                    'no video editor found
                End Try
                Try 'try to kill the recorder process
                    MainMenu.REProcess.Kill()
                Catch e As Exception
                    'no recorder process found
                End Try
                'For Each p As Process In Process.GetProcessesByName("Project64")
                '	p.Kill()
                'Next
                Settings.Save()
                If Settings.IsSynchronized = True Then
                    MainMenu.noticon.Visible = False
                    MainMenu.Close()
                Else
                    'should happen if for some reasons the saved my.settings aren't in sync AFTER "saving"
                    MsgBox("Practical Problemo")
                End If
                'TODO: close the app entirely while saving settings
                'damn m9 i can't get to do so
            End If
        End Sub
    End Class
End Namespace

