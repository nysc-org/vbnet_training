Module Variables

    Sub Main()

        Dim Name As String
        Name = "Paul"

        Dim message As String
        Console.Write("Enter a Messsage: ")
        message = Console.ReadLine
        'This writes an empty line and does not terminate
        Console.WriteLine()
        Console.WriteLine("Your message is: {0}", message)
        'Invoke the console.readline method again after
        'console writeline is executed
        Console.ReadLine()
        Console.ReadKey()
    End Sub

    'Sub Main()
    '    'Doing more with variables

    '    'You can create a local variable and assign a type.
    '    'Dim Pi As Double
    '    'Pi = 3.141


    '    'There are two ways to intialize a variable
    '    'Method 1

    '    Dim StudentId As Integer
    '    StudentId = 1
    '    Dim StudentClass As String
    '    StudentClass = "Maroon"


    '    'Method 2
    '    Dim StaffId As Integer = 1
    '    Dim StaffOffice As String = "General Office"

    '    'Method 1
    '    'Dim x, y, z As Integer

    '    ''Method 2
    '    'Dim j As Integer
    '    'Dim k As Integer
    '    'Dim L As Integer

    '    'x = 50
    '    'y = 5
    '    'z = x / y

    '    'Console.WriteLine("x={0}, y={1}, z={2}", x, y, z)
    '    Console.WriteLine(StudentId)

    '    Console.ReadLine()
    'End Sub

End Module
