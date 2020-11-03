Option Strict On
Module ejercicio12
    Sub main()

        Dim producto As Double

        Console.WriteLine("¿Cuanto cuesta el producto?")
        producto = Convert.ToDouble(Console.ReadLine)

        If producto < 100 Then
            producto = producto * 0.9
        Else
            producto = producto * 0.85
        End If
        Console.WriteLine("Ahora el producto vale " & producto & " euros")
        Console.ReadLine()

    End Sub
End Module
