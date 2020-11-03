Option Strict On
Private Sub TextBoxOnKeyPress(sender As Object, e As KeyPressEventArgs)

Module Module1

    Sub Main()

        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            '
            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If


        'Programa que calcula la nota media y si supera el cinco indica que está aprobado
        Dim nota1, nota2, nota3 As Single
        Dim media As Single
        Dim aprobado As Boolean
        'Solicitamos las notas
        Console.WriteLine("Introduzca la nota 1: ")
        nota1 = Convert.ToSingle(Console.ReadLine())
        Console.WriteLine("Introduzca la nota 2: ")
        nota2 = Convert.ToSingle(Console.ReadLine())
        Console.WriteLine("Introduzca la nota 3: ")
        nota3 = Convert.ToSingle(Console.ReadLine())

        'Calculamos la media de las 3 notas
        media = (nota1 + nota2 + nota3) / 3
        'Establecer variable booleana aprobado

        aprobado = media >= 5

        Console.WriteLine("La media es de" & media)

        'Evaluamos variable booleana
        If aprobado Then
            Console.WriteLine("Alumno aprobado")
        Else
            Console.WriteLine("Alumno suspenso.")
        End If
        Console.ReadLine()

    End Sub

End Module
