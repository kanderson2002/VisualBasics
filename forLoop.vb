Module Module1

    Sub Main()

        Dim userNumber As String
        Dim k = userNumber

        Console.Write("Choose a number between numbers 1-50? ")

        userNumber = Console.ReadLine()

        If userNumber <= 25 Then
            Console.WriteLine("You choose a number less than or equal to 25.")
            For k = userNumber To 0
                Console.WriteLine(k)
            Next
        End If

        If userNumber >= 26 Then
            Console.WriteLine("You choose a number greater than or equal to 26.")
            For k = userNumber To 0
                Console.WriteLine(k)
                Console.WriteLine()
            Next

            Console.WriteLine()
        End If
        Console.ReadLine()


    End Sub

End Module
