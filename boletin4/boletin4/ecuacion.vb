Option Strict On
Module ecuacion
    Sub main()

        Dim a, b, c As Double
        Dim x1, x2 As Double





        Console.WriteLine("¿a?")
        a = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("¿b?")
        b = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("¿c?")
        c = Convert.ToDouble(Console.ReadLine)


        If a = 0 Then
            x1 = -(c / b)
            x2 = -(c / b)

            Console.WriteLine("x1 es: " & x1)
            Console.WriteLine("x2 es: " & x2)

        ElseIf b = 0 Then
            If a < 0 And c > 0 Then
                x1 = Math.Sqrt(-c / a)
                x2 = Math.Sqrt(-(-c / a))

                Console.WriteLine("x1 es: " & x1)
                Console.WriteLine("x2 es: " & x2)

            ElseIf a < 0 And c < 0 Then

                Console.WriteLine("La raiz no tiene solucion.")

            ElseIf a > 0 And c < 0 Then
                x1 = Math.Sqrt(-c / a)
                x2 = Math.Sqrt(-(-c / a))

                Console.WriteLine("x1 es: " & x1)
                Console.WriteLine("x2 es: " & x2)

            ElseIf a >= 0 And c > 0 Then

                Console.WriteLine("La raiz no tiene solucion.")
            End If

        ElseIf c = 0 Then
            x1 = 0
            x2 = -(b / a)

            Console.WriteLine("x1 es: " & x1)
            Console.WriteLine("x2 es: " & x2)

        ElseIf ((b ^ 2) - 4 * a * c) < 0 Then

            Console.WriteLine("No existe la raiz de un numero negativo")

        Else
            x1 = (-b + Math.Sqrt((b ^ 2) - 4 * a * c)) / (2 * a)
            x2 = (-b - Math.Sqrt((b ^ 2) - 4 * a * c)) / (2 * a)

            Console.WriteLine("La solucion sumando es " & x1)
            Console.WriteLine("La solucion restando es " & x2)

        End If

        Console.ReadLine()



    End Sub
End Module
