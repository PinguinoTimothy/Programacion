Module Module1


    Sub Main()
        'Escribe un algoritmo que calcule el area de un triangulo a partir de la base y la altura.

        Dim base As Double = 5.3
        Dim altura As Double = 6.87
        Dim area As Double

        area = (base * altura) / 2
        Console.WriteLine("El area del triangulo es: " & area)
        Console.ReadLine()


        'Escribe un algoritmo que calcule la media de 3 números.
        Dim num1 As Double = 2
        Dim num2 As Double = 3
        Dim num3 As Double = 4
        Dim media As Double

        media = (num1 + num2 + num3) / 3

        Console.WriteLine("La media es " & media)

        Console.ReadLine()


        'Escribe un algoritmo que indique el precio final de un producto al que se le aplica una rebaja del 15%
        Dim pini As Double = 2.99
        Dim pfin As Double

        pfin = pini * 0.85

        Console.WriteLine("El precio del pr oducto es ahora " & pfin)
        Console.ReadLine()

    End Sub

End Module
