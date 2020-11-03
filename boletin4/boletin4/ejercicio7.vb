Option Strict On

Module ejercicio7
    Sub main()

        Dim temp As Decimal

        Console.WriteLine("¿Cual es la temperatura?")
        temp = Convert.ToDecimal(Console.ReadLine)

        If temp < 0 Then
            Console.WriteLine("Hielo")
        ElseIf temp >= 0 And temp < 100 Then
            Console.WriteLine("Agua")
        Else
            Console.WriteLine("Vapor")

        End If

        Console.ReadLine()

    End Sub
End Module
