Imports System.IO
Public Class GPLForm
    Private Sub GPLForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim LicenseText As String
        Dim LicenseFile As New StreamReader(Application.StartupPath + "\license.txt")
        LicenseText = LicenseFile.ReadToEnd
        LicenseBox.Text = LicenseText
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class