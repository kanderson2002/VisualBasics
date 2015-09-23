Module Module1

	Sub Main()

		'Dim numbers(0 to 4) As Integer
		'Dim numbers(4) As Interger

		'numbers(0) = 4
		'numbers(1) = 8
		'numbers(2) = 15
		'numbers(3) = 16
		'numbers(4) = 23
		
		'Dim numbers() As Integer = {4, 8, 15, 16, 23}

		'Console.WriteLine(“The third element of the array contains: “ & numbers(2) )

		'Console.ReadLine()

		'Console.WriteLine(“Iterating through the entire array:”)
	
		'For index = 0 to numbers.Length - 1
		'	Console.WriteLine(numbers(index))
		'Next
		
		'Dim names() As String = {"Bob", "Steve", "Brain", "Chuck"}
		'For Each name As String In names
		'	Console.WriteLine(name)
		'Next
		
		Dim myText As String = "Now is the time for all good men to come to the aid of their contury"
		
		Dim charArray() As Char = myText.ToCharArray()
		
		Arry.Reverse(charArray)
		
		For Each myChar As Char in charArray
			Console.Write(myChar)
		Next
			
		Console.ReadLine()

	End Sub

End Module
