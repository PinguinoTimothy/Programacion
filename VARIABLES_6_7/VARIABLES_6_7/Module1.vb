Module Module1

    Sub Main()

        'Realizar un programa que solicite al usuario dos números
        Dim num1, num2, suma, resta, multi As Double

        Console.WriteLine("Dame un numero")
        num1 = Console.ReadLine
        Console.WriteLine("Dame otro")
        num2 = Console.ReadLine

        suma = num1 + num2
        resta = num1 - num2
        multi = num1 * num2

        Console.WriteLine("La suma es " & suma)
        Console.WriteLine()
        Console.WriteLine("La resta es " & resta)
        Console.WriteLine()
        Console.WriteLine("La multiplicación es " & multi)

        Console.ReadLine()

        'Escribir un programa que lea la temperatura en grados 
        'centígrados y la convierta en grados Fahrenheit.

        Dim temcent, tempfar As Single

        Console.WriteLine("¿Que temperatura hace?")
        temcent = Console.ReadLine
        tempfar = (9 / 5) * temcent + 32
        Console.WriteLine("La temperatura es de " & tempfar & " grados Fahrenheit.")
        Console.ReadLine()


    End Sub

End Module
