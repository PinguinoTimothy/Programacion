Option Strict On

Module Module1

    Sub Main()

        Dim opcion As Integer

        Console.WriteLine("1 para suma")
        Console.WriteLine("2 para resta")
        Console.WriteLine("3 para multiplicación")
        Console.WriteLine("4 para división")
        Console.WriteLine("5 para raiz")

        opcion = Convert.ToInt32(Console.ReadLine)

        Dim num1, num2, resultado As Double

        Console.WriteLine("Que dos numeros quieres utilizar?")
        num1 = Convert.ToDouble(Console.ReadLine)
        num2 = Convert.ToDouble(Console.ReadLine)

        Select Case opcion
            Case 1
                resultado = num1 + num2
                Console.WriteLine("La suma de " & num1 & " y " & num2 & " es " & resultado)
            Case 2
                resultado = num1 - num2
                Console.WriteLine("La resta de " & num1 & " y " & num2 & " es " & resultado)
            Case 3
                resultado = num1 * num2
                Console.WriteLine("La multiplicacion de " & num1 & " y " & num2 & " es " & resultado)
            Case 4
                resultado = num1 / num2
                Console.WriteLine("La division de " & num1 & " entre " & num2 & " es " & resultado)
            Case 5
                resultado = Math.Sqrt(num1 + num2)
                Console.WriteLine("La raiz cuadrada de " & num1 & " mas " & num2 & " es " & resultado)




        End Select

        Console.ReadLine()

    End Sub

End Module
