Option Strict On
Module ejercicio10
    Sub main()

        Dim presion, temperatura As Double

        Console.WriteLine("¿Cual es la presion del nucleo?")
        presion = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("¿Cual es la temperatura actual del nucleo?(en kelvin)")
        temperatura = Convert.ToDouble(Console.ReadLine)
        If presion > 2 Then
            Console.WriteLine("Abrir válvula de seguridad")
        End If
        If temperatura > 500 Then
            Console.WriteLine("Reducir temperatura del nucleo")
        End If

        If presion < 2 And temperatura < 500 Then
            Console.WriteLine("Todo en orden")
        End If

        Console.ReadLine()

    End Sub
End Module
