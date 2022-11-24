Module Strings

    'In VB.Net, you can use strings as array of characters, however, 
    'more common practice Is To use the String keyword To Declare a 
    'String variable.The string keyword Is an alias for the S
    'ystem.String class.

    'Creating a String Object

    '1. By assigning a string literal to a String variable

    '2. By using a String class constructor

    '3. By using the string concatenation operator (+)

    '4. By retrieving a property Or calling a method that returns a string

    '5. By calling a formatting method to convert
    'a value Or object to its string representation

    Sub Main()
        'Working with strings
        Dim firstName, lastName, fullName, greetings As String
        firstName = "Gerald"
        lastName = "Okereke"
        fullName = firstName + " " + lastName
        Console.WriteLine("Full Name: {0}", fullName)

        '2. Using a string constructor
        Dim letters As Char() = {"H", "I"}
        greetings = New String(letters)
        Console.WriteLine("Greetings: {0}", greetings)

        '3. Methods returning a string
        Dim secondArray() As String = {"Hey", "From", "Gerald"}
        Dim message As String = String.Join(" ", secondArray)
        Console.WriteLine("Message: {0}", message)

        '4. Formatting method to value
        Dim waiting As DateTime
        waiting = New DateTime(2022, 11, 11, 17, 57, 1)
        Dim echo As String =
            String.Format("Message sent at {0:t} on {0:d}", waiting)
        Console.WriteLine("Message: {0}", echo)
        Console.ReadLine()
    End Sub
End Module
