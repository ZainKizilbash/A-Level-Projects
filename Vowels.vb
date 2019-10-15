Module Module1

    Sub Main()
        Dim name, vowels, vowels2, vowels3, vowels4, vowels5, str2, nextchar As String
        Dim counter As Integer
        name = " "
        vowels = "A"
        vowels2 = "E"
        vowels3 = "I"
        vowels4 = "O"
        vowels5 = "U"
        nextchar = " "
        str2 = ""
        counter = 0
        Console.Write("Enter Name: ")
        name = Console.ReadLine
        For counter = 1 To Len(name)
            nextchar = Mid(name, counter, 1)
            If nextchar = vowels Then
                str2 = str2 & nextchar
            ElseIf nextchar = vowels2 Then
                str2 = str2 & nextchar
            ElseIf nextchar = vowels3 Then
                str2 = str2 & nextchar
            ElseIf nextchar = vowels4 Then
                str2 = str2 & nextchar
            ElseIf nextchar = vowels5 Then
                str2 = str2 & nextchar
            End If

        Next
        Console.Write("Vowels in the name: " & Len(str2))
        Console.ReadKey()







    End Sub

End Module
