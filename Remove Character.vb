Module Module1

    Sub Main()
        Dim sen, charac, nextchar, str2 As String
        Dim counter As Integer
        sen = " "
        charac = " "
        nextchar = " "
        str2 = " "
        counter = 0
        Console.Write("Enter Sentence: ")
        sen = Console.ReadLine
        Console.Write("Character to remove: ")
        charac = Console.ReadLine
        For counter = 1 To Len(sen)
            nextchar = Mid(sen, counter, 1)
            If nextchar <> charac Then
                str2 = str2 & nextchar

            End If
        Next
        Console.Write("Final Name: " & str2)
        Console.ReadKey()


    End Sub

End Module
