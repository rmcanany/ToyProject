Module Module1

    Sub Main()
        Console.WriteLine("Hello world from Robert!") 'Francesco was here
        Console.WriteLine("Hello world from Bobbery!")
        Console.WriteLine("Hello world from Francesco!")

        Console.WriteLine("This is a great branch!")

        Dim msg As String = String.Format("{0}Press any key to exit...", vbCrLf)
        Console.WriteLine(msg)
        Console.ReadKey(True)
    End Sub

End Module
