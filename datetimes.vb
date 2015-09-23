Module Module1

	Sub Main()
		
		Dim myValue As Date = Now()
		
		'Console.WriteLine(myValue.ToShortDateString())
		'Console.WriteLine(myValue.ToShortTimeString())
		'Console.WriteLine(myValue.AddDays(3).ToShortDateString())
		'Console.WriteLine(myValue.AddHours(-3)ToShortTimeString())
		'Console.WriteLine(myValue.DayOfWeek)
		'Console.WriteLine(myValue.Month)
		
		'Dim myBirthdate As New Date(1980, 3, 15)
		
		'Dim myBirthdate As New Date
		'myBirthdate = Date.Parse("03/15/1980")
		
		'Dim myBirthdate = #03/15/1980#
		
		Dim myAge = Date.Now.Subtract(myBirthdate)
		Console.WriteLine(myAge.TotalDays.ToString())
		
		'Console.WriteLine(myBirthdate)
		Console.ReadLine()
		
	End Sub

End Module
