Module Module1
	
	Sub Main()
		
		'Dim myString = "Go to the folder called 'My Documents' on your c:\ drive ..."
		
		'Dim myString = "Go to the folder " & _
		'	"called 'My Documents' " & _
		'	"on your c:\ " _
		'	& "drive."
		
		'Dim myString = "My ""so called"" life"
		
		'Dim myString = "What if I need" & vbCrLf & "a new line?"
		
		'Dim myString = String.Format("{0}!", "Hello")
		
		'Dim myString = String.Format("Make: {0} Model: {1}", "BMW", "745li")
		
		'Dim myString = String.Format("{0:C}", 23.35)
		
		'Dim myString = String.Format("{0:N}", 1234567890)
		
		'Dim myString = String.Format("{0:P}", 0.123)
		
		'Dim myString = String.Format("Phone Number: {0:(###) ###-####}", 1234567890)
		
		'Dim myString = ""
		
		'Dim myString As StringBuilder = New StringBuilder
		'Dim myString As New StringBuilder
		
		'For i = 1 To 100
			'myString = myString & "--" & CStr(i)
			'myString += "--" & CStr(i)
			
		'	myString.Append("--")
		'	myString.Append(i)
			
		'Next
		
		'Console.WriteLine(myString.ToString())
		'Console.WriteLine(myString)
		'Console.WriteLine("{0}!", "Hello")
		
		Dim myString = "It's better to be lucky than good.  "
		
		'myString = myString.Substring(5, 12)
		
		'myString = myString.ToUpper()
		
		'myString = myString.Replace(" ", "--")
		
		myString = myString.Format("Length before: {0} -- After: {1}", 
			myString.Length, myString.Trim().Length)
		
		Console.WriteLine(myString)
		Console.ReadLine()
		
	End Sub
	
End Module
