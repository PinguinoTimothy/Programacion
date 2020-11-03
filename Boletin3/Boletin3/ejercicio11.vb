Option Strict On
Module ejercicio11
    Sub main()

        Dim num As Double

        Console.WriteLine("¿Numero?")
        num = Convert.ToDouble(Console.ReadLine)

        If num Mod 2 = 0 Or num Mod 3 = 0 Then
            Console.WriteLine("El numero es multiplo de 2 o 3 ")
        End If

        Console.ReadLine

    End Sub
End Module
