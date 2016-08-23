Imports _64Parser
Module StartUp

    Sub Main()
        Console.WriteLine("64READER for 64FM/M64MM2.0 Addon files.")
        Console.WriteLine("WARNING: This console application depends on the file ""64Parser.dll"". Make sure it's there!")
        Console.WriteLine("Load the .fma/.aus file to read.")
        Dim File As String = Console.ReadLine()
        Console.Clear()
        Console.WriteLine("Reading file..." + vbCrLf)
        Console.WriteLine("Addon Name: " + MainFunctions.ReadMetadata(File, 0) + vbCrLf)
        Console.WriteLine("Addon Author: " + MainFunctions.ReadMetadata(File, 1) + vbCrLf)
        Console.WriteLine("Addon Description: " + MainFunctions.ReadMetadata(File, 2) + vbCrLf)
        Console.WriteLine("Addon Version: " + MainFunctions.ReadMetadata(File, 3) + vbCrLf)
        Console.ReadKey()
        Console.Clear()
        Dim AddonType As String = MainFunctions.GetAddonType(File)
        Console.WriteLine("ADDON TYPE (internal name): " + AddonType)
        If AddonType.StartsWith("autoscript") Then
            Console.WriteLine("ADDON TYPE: M64MM2Auto Script" + vbCrLf)
            Console.WriteLine("COMMANDS: " + vbCrLf)
            Dim Commandslist As List(Of String) = MainFunctions.ReadContents(File)
            For Each line As String In Commandslist
                Console.WriteLine(line)
            Next
        Else
            Console.WriteLine("ADDON TYPE: FILE" + vbCrLf)
            Console.WriteLine("FILELIST: " + vbCrLf)
            Dim filelist As List(Of String) = MainFunctions.ReadContents(File, True)
            For Each line As String In filelist
                Console.WriteLine(line)
            Next
        End If
        Console.ReadKey()
    End Sub

End Module
