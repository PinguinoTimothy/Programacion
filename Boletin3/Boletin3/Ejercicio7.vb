Option Strict On
Module Ejercicio7
    Sub main()

        'Diseñar un programa que lea(es decir solicita al usuario que
        'los introduzca por teclado) dos números reales, los guarde 
        'en dos variables de tipo double calcule su suma guardándola
        'en una variable, SI ES POSITIVA  mostrar por pantalla la raíz
        'cuadrada de la suma (usar la clase Math.sqrt(variable)),  en 
        'cualquier otro caso muestra un mensaje informando de que no se 
        'puede calcular la raíz.

        Dim num1, num2 As Double
        Dim suma As Double
        Dim raiz As Double

        Console.WriteLine("Dime un numero")
        num1 = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("Dime otro")
        num2 = Convert.ToDouble(Console.ReadLine)

        suma = num1 + num2

        If suma > 0 Then
            raiz = Math.Sqrt(suma)
            Console.WriteLine("La raiz del numero es " & raiz)

        Else
            Console.WriteLine(suma & " No es un numero positivo, por tanto no tiene raiz")

        End If

        Console.ReadLine()

    End Sub

End Module
