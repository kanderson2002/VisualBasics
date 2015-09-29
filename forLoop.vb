Module Module1

    Sub Main()

        Dim k = 0
        Dim w = 0

        For k = 1 To 100
            Console.WriteLine(k)

            If (k = 8) Then
                Console.WriteLine("Found Eight")
                Exit For

            End If

        Next

        For k = 5 To 100 Step 2
            Console.WriteLine(k)
        Next

        Console.ReadLine()

    End Sub

End Module
