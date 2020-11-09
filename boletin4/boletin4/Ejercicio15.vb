Option Strict On
Module Ejercicio15
    Sub main()

        Dim año As Short

        Console.WriteLine("Año")
        año = Convert.ToInt16(Console.ReadLine)

        If año Mod 100 = 0 Then
            If año Mod 400 = 0 Then
                Console.WriteLine("Bisiesto")
            Else
                Console.WriteLine("No bisiesto")
            End If
        ElseIf año Mod 4 = 0 Then
            Console.WriteLine("Bisiesto")
        Else
            Console.WriteLine("No bisiesto")
        End If

        Console.ReadLine()

    End Sub
End Module
