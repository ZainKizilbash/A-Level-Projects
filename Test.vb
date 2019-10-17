Module Module1

    Sub Main()
        Dim str1, str2, char1, char2, nextchar As String
        Dim counter As Integer
        Dim validBinaryString, validbinarystring1 As Boolean
        str1 = " "
        str2 = ""
        char1 = "0"
        char2 = "1"
        nextchar = " "
        counter = 0
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
        If validBinaryString And validbinarystring1 = True Then
            Console.Write("a valid binary number...")
        Else
            Console.Write("not a valid binary number....")
        End If
        Console.ReadKey()
    End Sub

End Module
