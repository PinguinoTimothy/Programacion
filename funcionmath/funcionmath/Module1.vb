Option Strict On
Module Module1

    Sub Main()

        'La libreria math contiene funciones matematicas 
        '1º Funcion, elevar: Pow ( base, exponente)

        Dim base As Short = 10
        Dim exponente As Byte = 5
        Dim resultado As Integer = Convert.ToInt32(Math.Pow(base, exponente))

        Console.WriteLine(base & " evelado a " & exponente & " = " & resultado)

        Console.ReadLine()

        '2º Funcion, raiz cuadrad: Sqrt (numero)

        Dim numero As Integer = 3
        Dim raiz As Double = (Math.Sqrt(numero))

        Console.WriteLine("La raiz cuadrada de " & numero & " es igual a " & raiz)

        Console.ReadLine()

        '3º Funcion, redondear hacia abajo: floor(valor) 

        Dim raizfloor As Integer = Convert.ToInt32(Math.Floor(raiz))

        Console.WriteLine(raiz & " redondeado hacia abajo queda " & raizfloor)
        Console.ReadLine()

        '4º Funcion, redondear hacia arriba: ceiling(valor)

        Dim raizceiling As Integer = Convert.ToInt32(Math.Ceiling(raiz))

        Console.WriteLine(raiz & " redondeado hacia arriba queda " & raizceiling)
        Console.ReadLine()

        '5º Funcion, redondeo normal: round(valor)

        Dim raizround As Integer = Convert.ToInt32(Math.Round(raiz))

        Console.WriteLine(raiz & " redondeada normal queda " & raizround)
        Console.ReadLine()

        'Math.round(valor, numerodecimales) --> Ajusta el valor a los decimales indicados
        Dim raizround2 As Double = Math.Round(raiz, 2)

        Console.WriteLine(raiz & " con dos decimales queda " & raizround2)
        Console.ReadLine()

        'Si quiero modificar la origial

        raiz = Math.Round(raiz, 2)

        Console.WriteLine(raiz)
        Console.ReadLine()

    End Sub

End Module
