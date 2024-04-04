Module Program
    Sub Main(args As String())
        ' Creating an instance of the Car class
        Dim myCar As New Car("Toyota", "Supra", 2018, "Blue")

        ' Displaying car information
        Console.WriteLine("Car Details:")
        Console.WriteLine("Make: " & myCar.Make)
        Console.WriteLine("Model: " & myCar.Model)
        Console.WriteLine("Year: " & myCar.Year)
        Console.WriteLine("Color: " & myCar.Color)

        ' Modifying car color
        myCar.ChangeColor("Black")

        ' Displaying updated car information
        Console.WriteLine("Updated Color: " & myCar.Color)

        Console.ReadLine()
    End Sub
End Module

Public Class Car
    Public Property Make As String
    Public Property Model As String
    Public Property Year As Integer
    Public Property Color As String

    ' Constructor to initialize car details
    Public Sub New(make As String, model As String, year As Integer, color As String)
        Me.Make = make
        Me.Model = model
        Me.Year = year
        Me.Color = color
    End Sub

    ' Function to change car's color
    Public Sub ChangeColor(newColor As String)
        Me.Color = newColor
    End Sub
End Class
