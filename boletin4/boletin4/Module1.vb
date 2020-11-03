Option Strict On
Module Module1

    Sub Main()

        Dim num, numf As Double

        Console.WriteLine("Dime un numero")
        num = Convert.ToDouble(Console.ReadLine)

        If num Mod 4 = 0 Then
            numf = num + 25

        Else
            If num Mod 5 = 0 Then
                numf = num + 50
            Else numf = num + 100
            End If
        End If

        Console.WriteLine("El numero incial era " & num & " ahora el numero es " & numf)
        Console.ReadLine()

    End Sub

End Module
