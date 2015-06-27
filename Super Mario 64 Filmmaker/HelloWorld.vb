Class HelloMatey
    Public Shared Sub HelloWorld()
        If Form.ActiveForm Is MainMenu Then
            Console.WriteLine("Hola Mundo! :D")
            Console.WriteLine("That means Hello world! :D in Spanish, my main language")
            Console.WriteLine("The first Console.WriteLine was my first code ever in VB.NET.")
            Clipboard.SetText("Next step is called Birthday()")
        Else
            'NOPE.
        End If
    End Sub
End Class