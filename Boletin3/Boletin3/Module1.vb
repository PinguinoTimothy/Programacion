Option Strict On
Module Module1

    Sub Main()
        'Ejercicio 5
        'Escribir un programa que decida si un número es par o impar e informe al usuario.

        Dim numero As Integer

        Console.WriteLine("Dime un numero ")
        numero = Convert.ToInt32(Console.ReadLine)

        If numero Mod 2 = 0 Then
            Console.WriteLine("Par")
        Else
            Console.WriteLine("Impar")

        End If
        Console.ReadLine()
    End Sub

End Module
