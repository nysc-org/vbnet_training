Module OOP
    'Create class called "Box"
    'A class should be within module
    Class Box
        'Define objects
        Public length As Double
        Public breadth As Double
        Public height As Double
    End Class

    Sub Main()
        'Create box1 as var
        '"As Box" is calling into the 
        'box class
        'New Box creates a new instance
        'of the class Box
        Dim Box1 As Box = New Box()
        'There is no limit to how many
        'you can assign to a specific
        'class
        Dim Box2 As Box = New Box()

        'Inheritance example:

        'This is for Box 1
        Box1.height = 2.0
        Box1.length = 3.0
        Box1.breadth = 3.0

        'This is for Box 2
        Box2.height = 2.0
        Box2.length = 3.0
        Box2.breadth = 3.0
        'Volume of the box 1

        Console.WriteLine("Volume of our box1: {0}", VolCompute(Box1, Box2))

        Console.WriteLine("Volume of our box2: {0}", VolCompute(Box1, Box2))
    End Sub
    Function VolCompute(ByVal Box1, ByVal Box2) As Double
        Dim volume As Double = 0.0
        volume = Box1.length * Box1.height * Box1.breadth
        VolCompute = volume

        volume = Box2.length * Box2.height * Box2.breadth
        VolCompute = volume
    End Function

    'Module mybox
    '    Class Box
    '        Public length As Double
    '        Public breadth As Double
    '        Public height As Double
    '    End Class
    '    Sub Main()
    '        Dim Box1 As Box = New Box()
    '        Dim Box2 As Box = New Box()
    '        Dim volume As Double = 0.0

    '        ' box 1 specification
    '        Box1.height = 2.0
    '        Box1.length = 3.0
    '        Box1.breadth = 3.0

    '        ' box 2 specification
    '        Box2.height = 2.0
    '        Box2.length = 3.0
    '        Box2.breadth = 3.0

    '        'volume of box 1
    '        volume = Box1.height * Box1.length * Box1.breadth
    '        Console.WriteLine("Volume of Box1 : {0}", volume)

    '        'volume of box 2
    '        volume = Box2.height * Box2.length * Box2.breadth
    '        Console.WriteLine("Volume of Box2 : {0}", volume)
    '        Console.ReadKey()
    '    End Sub
    'End Module
End Module
