Option Strict On
Module ejercicio9
    Sub main()

        Dim litros, total As Double
        Const minimo As Short = 150

        Console.WriteLine("¿Cuantos litros gastaste este mes?")
        litros = Convert.ToDouble(Console.ReadLine)

        If litros < 50 Then
            total = 0
        ElseIf litros >= 50 And litros <= 200 Then
            total = 10 * (litros - 50)
        Else
            total = (litros - 200) * 20 + 150 * 10
        End If

        If total < minimo Then
            total = minimo
        End If

        Console.WriteLine("El total a pagar es: " & total & " euros")

        Console.ReadLine()
    End Sub




End Module
