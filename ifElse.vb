Module Module1

  Sub Main()
  
    'Console.WriteLine("Please type something and press Enter")
    'Dim userValue As String
    
    'userValue = Console.ReadLine()
    'Console.WriteLine("You typed: " & userValue)
    'Console.ReadLine()
    
    'Console.WriteLine("Would your perfer what is behind door number 1, 2 or 3?")
    
    'Dim userValue As String = Console.ReadLine()
    
    'If userValue = "1" Then
    '  Console.WriteLine("You won a car!")
    '  Console.ReadLine()
      
    'ElseIf userValue = "2" Then
    '  Console.WriteLine("You won a boat!")
    '  Console.ReadLine()
    
    'ElseIf userValue = "3" Then
    '  Console.WriteLine("You won a truck!")
    '  Console.ReadLine()
    
    'Else
    '  Console.WriteLine("Sorry, we did not understand your response. You lose!")
  
    'End If
    
    'Dim message = ""
    
    'If userValue = "1" Then
    '  message = "You won a car!"
      
    'ElseIf userValue = "2" Then
    '  message = "You won a boat!"
    
    'ElseIf userValue = "3" Then
    '  message = "You won a truck!
    
    'Else
    '  message = "Sorry, we did not understand your response. You lose!"
  
    'End If
    
    'Console.WriteLine(message)
    'Console.ReadLine()
  
    Console.WriteLine("Would your perfer #1 or #2?")
    
    Dim userValue As String = Console.ReadLine()
    Dim message = IIf(userValue = "1", "car", "cat")
    Console.WriteLine("You won a {0}!", message)
    Console.ReadLine()
  
  End Sub

End Module
