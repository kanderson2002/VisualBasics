Sub Main()
	
	'displayTheMessage()

		'Dim myValue As String = superScretFormula()
		'Dim myValue As String = superSecretFormula("Bob")
		'Console.WriteLine(myValue)

		Console.WritLine(superSecretFormula())
		Console.WriteLine(superSecretFormula("Bob"))

		Consol.ReadLine()

	End Sub

	'Sub display TheMessage()
		'Console.WriteLine("From displayTheMessage")
	'End Sub


	'Function superSecretFormula() As String
		'Return "Hello World!"
	'End Function

	Function superSecretFormula(ByVal name As String) As String
		Return ("Hello World, {0}", name)
	End Function
	
