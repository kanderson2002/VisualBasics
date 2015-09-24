

    Sub Main()

        'Dim myNewCar As Car = New Car
        Dim myNewCar As Car = New Car

        myNewCar.Make = "Oldsmobile"
        myNewCar.Model = "Cutless Supreme"
        myNewCar.Year = 1986
        myNewCar.Color = "Silver"

        ' With myNewCar
        '   .Make = "Olds"
        '   .Model = "Cutless"
        '   .Year = 1986
        '   .Color = "Silver"
        '  End With

        'Console.WriteLine("{0} - {1} - {2}", myNewCar.Make, myNewCar.Model, myNewCar.Year.ToString())
        'Console.WriteLine(determineMarketValue(myNewCar))

        Console.WriteLine(determineMarketValue(myNewCar))

        Console.ReadLine()


    End Sub

    'Function determineMarketValue(ByVal myCar As Car) As Double
    '    'Super secret formula

    '    Return 100.0

    'End Function



End Module

