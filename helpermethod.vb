Module Module1
	
	Sub Main()
		
		'displayTheMessage()
		
		'Dim myValue As String = superSecertFormula()
		'Dim myValue As String = superSecertFormula("Bob")
		'Console.WriteLine(myValue)
		
		Console.WriteLine(superSecertFormula())
		Console.WriteLine(superSecertFormula("Bob"))
				
		Console.ReadLine()
		
	End Sub
	
	Sub displayTheMessage()
		Console.WriteLine("From displayTheMessage")
	End Sub
	
	'Function superSecertFormula() As String
	'	Return "Hello World!"
	'End Function
	
	Function superSecertFormula(ByVal name As String) As String
		Return String.Format("Hello World, {0}", name)
	End Function
	
End Module
