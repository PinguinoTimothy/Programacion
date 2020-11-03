Option Strict On
Module Ejercicio9
    Sub main()

        Dim numero1, numero2, resultado As Double

        Console.WriteLine("Dime un numero")
        numero1 = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("Dime otro numero")
        numero2 = Convert.ToDouble(Console.ReadLine)

        If numero1 > numero2 Then
            resultado = Math.Pow(numero1, numero2)
            Console.WriteLine("El resultado es " & resultado)
        Else
            resultado = Math.Pow(numero2, numero1)
            Console.WriteLine("El resultado es " & resultado)
        End If

        Console.ReadLine()

    End Sub


End Module
