Option Strict On
Module ejercicio8
    Sub main()

        Dim num1, num2, numf As Double
        Dim num As Char

        Console.WriteLine("A: Suma")
        Console.WriteLine("B: resta")
        Console.WriteLine("C: multiplicacion")
        Console.WriteLine("D: division")
        Console.WriteLine("E: raiz de la suma")

        num = Convert.ToChar(Console.ReadLine)
        If num <> "a"c And num <> "b"c And num <> "c"c And num <> "d"c And num <> "e"c Then
            Console.WriteLine("No has seleccionado ninguna opción, fijate bien en la selección")
            Console.ReadLine()
            End
        End If


        Console.WriteLine("Dame el primer numero")
        num1 = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("Dame el otro")
        num2 = Convert.ToDouble(Console.ReadLine)

        Select Case num
            Case "a"c
                numf = num1 + num2
                Console.WriteLine("La suma de " & num1 & " y " & num2 & " es " & numf)
            Case "b"c
                numf = num1 - num2
                Console.WriteLine("La resta de " & num1 & " menos " & num2 & " es " & numf)
            Case "c"c
                numf = num1 * num2
                Console.WriteLine("La multiplicación de " & num1 & " por " & num2 & " es " & numf)
            Case "d"c
                numf = num1 / num2
                Console.WriteLine("La division de " & num1 & " entre " & num2 & " es " & numf)
            Case "e"c
                numf = Math.Sqrt(num1 + num2)
                Console.WriteLine("La raiz cuadra de " & num1 & " mas " & num2 & " es " & numf)
        End Select



        Console.ReadLine()


    End Sub
End Module
