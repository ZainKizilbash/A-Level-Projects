Module Module1

    Sub Main()
        Dim str1, charac, rcharac, nextchar, str2 As String
        Dim counter As Integer
        nextchar = " "
        str1 = " "
        charac = " "
        rcharac = " "
        str2 = " "
        counter = 0
        Console.Write("Enter Sentence: ")
        str1 = Console.ReadLine
        Console.Write("Character to remove: ")
        charac = Console.ReadLine
        Console.Write("Character to replace with: ")
        rcharac = Console.ReadLine
        For counter = 1 To Len(str1)
            nextchar = Mid(str1, counter, 1)
            If nextchar = charac Then
                nextchar = rcharac



            End If
            str2 = str2 & nextchar


        Next
        Console.Write(str2)
        Console.ReadKey()


    End Sub

End Module
