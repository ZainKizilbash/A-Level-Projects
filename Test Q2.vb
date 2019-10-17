Module Module1

    Sub Main()
        Dim str1, str2, str3, char1, char2, nextchar As String
        Dim counter, s As Integer
        Dim validBinaryString, validbinarystring1 As Boolean
        Dim n As Long
        str1 = " "
        str2 = ""
        char1 = "0"
        char2 = "1"
        nextchar = " "
        counter = 0
        s = 0
        n = 0
        str3 = " "

        validBinaryString = True
        validbinarystring1 = True

        Console.Write("Enter a binary number: ")
        str1 = Console.ReadLine
        For counter = 1 To Len(str1)
            nextchar = Mid(str1, counter, 1)
            If nextchar = char1 Then
                validBinaryString = True
            ElseIf nextchar = char2 Then
                validBinaryString = True
            Else
                validBinaryString = False

            End If
            str2 = str2 & nextchar
        Next
        If Len(str2) < 8 Then
            validbinarystring1 = True
        ElseIf Len(str2) = 8 Then
            validbinarystring1 = True
        Else
            validbinarystring1 = False
        End If
        For s = 1 To Len(str2)
            n = n + (Mid(str2, Len(str2) - s + 1, 1) * (2 ^ _
            (s - 1)))

        Next
        str3 = n
        Console.Write("Denary Value: " & str3)
        Console.ReadKey()
    End Sub

End Module
