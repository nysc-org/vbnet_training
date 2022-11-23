Module Statements

    'Statements in Visual basic are complete instructions
    'that constitute vb programs.

    'THIS IS FOR THE IF THEN STATEMENT
    'Sub Main()
    '    'declare local variable 
    '    Dim x As Integer
    '    x = 10

    '    ' check the boolean condition using if statement 
    '    If ((x < 20)) Then
    '        ' if condition is true then print the following 
    '        Console.WriteLine("x is less than 20")
    '    End If
    '    Console.WriteLine("value of a is : {0}", x)
    '    Console.ReadLine()
    'End Sub

    'THE IF ELSE STATEMENT
    'Sub Main()
    '    'Create a local variable
    '    Dim y As Integer = 200

    '    'Condition to check boolean using if else statement
    '    If y < 30 Then
    '        'If condition is true then print the following
    '        Console.WriteLine("y IS LESS THAN 30")

    '        'The else statement is always within the if-then
    '        'block

    '    Else
    '        Console.WriteLine("Y is not less than 30")
    '    End If

    '    Console.WriteLine("value of y is: {0}", y)
    '    Console.ReadLine()
    'End Sub

    'THE IF, ELSE-IF  STATEMENT
    Sub Main()
        'local variable definition '
        Dim Z As Integer = 100
        ' check the boolean condition '
        If (Z = 40) Then
            ' if condition is true then print the following '
            Console.WriteLine("Value of Z is 40") '
        ElseIf (Z = 30) Then
            'if else if condition is true '
            Console.WriteLine("Value of z is 30") '
        ElseIf (Z = 60) Then
            'if else if condition is true  
            Console.WriteLine("Value of Z is 60")
        Else
            'if none of the conditions is true 
            Console.WriteLine("None of the values is matching")
        End If
        Console.WriteLine("Exact value of z is: {0}", Z)
        Console.ReadLine()
    End Sub

End Module
