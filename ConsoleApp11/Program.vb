Module Program
    Sub Main(args As String())
        Dim myCar As New Car("Toyota", "Supra", 2018, "Blue")

        Console.WriteLine("Car Details:")
        Console.WriteLine("Make: " & myCar.Make)
        Console.WriteLine("Model: " & myCar.Model)
        Console.WriteLine("Year: " & myCar.Year)
        Console.WriteLine("Color: " & myCar.Color)


        myCar.ChangeColor("Black")

        Console.WriteLine("Updated Color: " & myCar.Color)

        Console.ReadLine()
    End Sub
End Module

Public Class Car
    Public Property Make As String
    Public Property Model As String
    Public Property Year As Integer
    Public Property Color As String

    Public Sub New(make As String, model As String, year As Integer, color As String)
        Me.Make = make
        Me.Model = model
        Me.Year = year
        Me.Color = color
    End Sub

    Public Sub ChangeColor(newColor As String)
        Me.Color = newColor
    End Sub
End Class
