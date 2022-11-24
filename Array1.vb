'Creating an Array
'An array is data structure that stores a fixed-size sequential collection of elements of
'the same type. An array is used to store a collection of data, but it is often more useful
'to think of an array as a collection of variables of the same type.
Module Array1
    'Sub Main()
    '    Dim n(10) As Integer
    '    Dim i, j As Integer
    '    ' initialize elements of the array

    '    For i = 0 To 10
    '        n(i) = i + 100
    '    Next i
    '    ' output each array element's value '

    '    For j = 0 To 10
    '        Console.WriteLine("Element({0}) = {1}", j, n(j))
    '    Next j
    '    Console.ReadKey()
    'End Sub


    'Creating multi-dimensional arrays
    'These are also called 2d arrays
    Sub Main()
        'Array with five rows and 2 columns
        'Create a local variable assigninf (,) as a multidimensional
        'array 

        'Multi-dimensional
        'Dim a(,) As Integer = {{1, 2}, {3, 4}, {5, 6}, {7, 8}}
        ''Normal array 
        'Dim b() As Integer = {1, 2, 4, 5, 6, 6}
        'Dim j, k
        ''You can have a for loop inside another for loop
        'For j = 0 To 4
        '    For k = 0 To 1
        '        Console.WriteLine("a[{0}, {1}] = {2}", j, k, a(j, k))
        '    Next k
        'Next j 'Next makes the program iterate/loop till the condition
        ''Is fulfilled

        'Jagged Array
        'is an Array of Arrays

        Dim b As Integer()() = New Integer(4)() {}
        b(0) = New Integer() {1, 0}
        b(1) = New Integer() {3, 2}
        b(2) = New Integer() {5, 4}
        b(3) = New Integer() {7, 6}
        b(4) = New Integer() {9, 8}
        b(5) = New Integer() {11, 10}
        b(6) = New Integer() {13, 12}
        b(7) = New Integer() {15, 14}

        Dim c, d As Integer

        'Output each array element's value
        For c = 0 To 4
            For d = 0 To 1
                Console.WriteLine("b[{0}, {1}]= {2}", c, d, b(c)(d))
            Next d
        Next c
        Console.ReadKey()
    End Sub
    'Normal array: array()
    'Multi-dim array: array(,)
    'jagged array: array()()
End Module
