Imports System

Public Class Square
    Private length As Double
    Private breadth As Double

    'For Our Public Methods
    Public Sub AcceptData()
        length = 10.0
        breadth = 10.0
    End Sub

    'To Calculate the Area of the Square
    'Area of a Square = Side x Side (Length x Breadth)
    Public Function CalculateArea() As Double
        CalculateArea = length * breadth
    End Function

    'Then we need to display our calculation
    Public Sub DisplayCalculation()
        Console.WriteLine("length: {0}", length)
        Console.WriteLine("breadth: {0}", breadth)
        Console.WriteLine("area: {0}", CalculateArea())
    End Sub

    'This is our Main Sub Method
    Shared Sub Main()
        'Declared s as a local variable in place of Square.
        Dim s As New Square()
        s.AcceptData()
        s.DisplayCalculation()
        Console.ReadLine()
    End Sub
End Class