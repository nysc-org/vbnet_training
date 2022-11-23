Module Loops
    'Do Loop: It repeats the enclosed block of statements
    'while a boolean condition is true or until the condition
    'becomes true and can be terminated with the
    'Exit Do statement.

    'Sub Main()
    '    'Create local variable definition
    '    Dim x As Integer = 10
    '    'The do loop execution

    '    'Beginning of Do Loop
    '    Do
    '        Console.WriteLine("Value of x: {0}", x)
    '        x = x + 1
    '    Loop While (x <= 50)
    '    Console.ReadLine()
    '    'End of Do Loop
    'End Sub

    'Second example
    'Here we would use the Until keyword

    'Sub Main()
    '    Dim r As Double = 20.0
    '    Do
    '        Console.WriteLine("value of r: {0}", r)
    '        r = r + 1 'Increment R
    '    Loop Until (r = 5000.0)
    '    Console.ReadLine()
    'End Sub


    'FOR NEXT LOOP
    'It repeats a group of statements a specified number of times
    'and a loop index counts the number of loop iterations as
    'the loop executes

    'Sub Main()
    '    Dim r As Integer
    '    'Execution Loop
    '    For r = 10 To 20 Step 2 'For Loop is made up of 3 keywords
    '        'For is to select a variable and assign a value
    '        'To is to select the maximum value it should loop tp
    '        'Step defines how many steps, i.e if you say step 2,
    '        'it increments by to till 20
    '        Console.WriteLine("value of r: {0}", r)
    '    Next
    '    Console.ReadLine()

    'End Sub


    'It repeats a group of statements for each element in a
    'collection. This loop is used for accessing and manipulating
    'all elements in an array or a VB.Net collection.

    Sub Main()
        'Created a local variable with () to represent we would be 
        'storing a set of numbers in
        Dim anArray() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}
        'Created an arrayItem to represent a single item in the array
        Dim arrayItem As Integer

        'Display values
        For Each arrayItem In anArray
            Console.WriteLine(arrayItem)
        Next
    End Sub
End Module




