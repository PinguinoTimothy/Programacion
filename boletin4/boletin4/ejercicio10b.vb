Option Strict On
Module ejercicio10b
    Sub main()

        Dim x, y, z, suma As Double


        Console.WriteLine("Primer articulo")
        x = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("Segundo articulo")
        y = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("Tercer articulo")
        z = Convert.ToDouble(Console.ReadLine)


        suma = x + y + z

        Console.WriteLine("El total sin descuento es de " & suma & " euros")



        If suma < 500 Then
            suma = suma
        ElseIf suma >= 500 And suma <= 1000 Then
            suma = suma * 0.97
        ElseIf suma > 1000 And suma < 2000 Then
            suma = suma * 0.95
        ElseIf suma >= 2000 And suma <= 3000 Then
            suma = suma * 0.93
        ElseIf suma > 3000 Then
            suma = suma * 0.9
        End If

        Console.WriteLine("El total con descuento es de " & suma & " euros")

        Console.ReadLine()

    End Sub
End Module



