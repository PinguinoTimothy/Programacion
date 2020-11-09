Option Strict On
Module Ejercicio16
    Sub main()

        Dim x, y, z, min, max, med As Double

        Console.WriteLine("Primero")
        x = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("Segundo")
        y = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("Tercero")
        z = Convert.ToDouble(Console.ReadLine)


        If x > y Then
            If x > z Then
                If z < y Then
                    max = x
                    med = y
                    min = z
                Else
                    max = x
                    med = z
                    min = y
                End If
            Else
                max = z
                med = x
                min = y
            End If
        Else ''x < y
            If x < z Then
                If z < y Then
                    max = y
                    med = z
                    min = x
                Else
                    max = z
                    med = y
                    min = x
                End If
            Else
                max = y
                med = x
                min = z
            End If

        End If

        Console.WriteLine("El mayor es: " & max)
        Console.WriteLine("El mediano es: " & med)
        Console.WriteLine("El menor es: " & min)

        Console.ReadLine()
    End Sub
End Module
