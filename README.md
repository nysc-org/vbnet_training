# Visual Basic Net Training.

Visual Basic is an object-oriented programming language.
There are four properties that are used within the Visual Basic Programming
Language, for the Object Oriented Programming Paradigm. These are:

1. Objects
2. Class
3. Methods
4. Instance Variables

Let us create a Square Class in Visual Basic Net to illustrate the concept
of OOP.

## Things to note
1. Double is used for decimals, otherwise floats.
2. Integer is used for numbers with no decimal point.
3. A `Sub` is a method that returns no value.
4. `Shared` specifies that one or more declared programming elements 
are associated
with an instance or class.

Length and breadth was declared, therefore we assign numbers/values to it.
Then we created a public function to handle the calculation of area in a double.
Then we created a method to display the method.
Then lastly, a `Shared Pub Main` consolidating all our methods, and
implementing the Console.ReadLine method.

## Identifiers

An identifier is simply any keyword associated with a class or function that
is used to identify a class, function, variable.

### Rules Of Identifiers.
1. Special characters such as "$%*" are not allowed.
2. It only accepts underscores(_) at most
3. There should be no embedded space within identifiers.

## Keywords
The following are examples of the important Visual Basic Keywords

1. Double
2. Class
3. Handles
4. Loop
5. Interface
6. Set, Sop, To
7. Declare
8. Each
9. Error
10. If
11. Namespace
12. Or
13. Private, Public, Protected
14. String
15. Default
16. Let, Module, New, TypeOf, For, GoTo, Static

## Data Types

1. Boolean - (True/False)
2. Byte
3. Single
4. Char - (Character)
5. Double - (For Floats)
6. Integer
7. Long - 8bytes
8. Object
9. String
10. Short

## Variables

Variable Initialization is done, when a variable is assigned a value.
You CREATE a variable by using the `Dim` keyword and declaring the letter of the variable.
A variable could also be a word.
A variable name is a simple name used to store data in the computer memory.

## LValues and RValues

An LValue refers to the memory location of storing the address of a variable in computer
memory. An Lvalue is a variable that can appear on the left or right hand side of the assignment
Example of LValue

```vb
Dim l As Integer = 1
```
OR

```vb
Dim l As Integer
l =  1
```

An RValue refers to the memory location of storing the address of a variable in computer
An Rvalue is a variable that can appear on the right hand side of the assignment because
it os a value of the variable that defines the right-hand side.
Example of RValue, where the assignment is done on the right

```vb
Dim Name as String
Name = "Paul"
```