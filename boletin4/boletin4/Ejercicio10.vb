Option Strict On
Module Ejercicio10
    Sub main()

        Dim salarioBruto, salarioNeto As Double
        Dim horas As Short
        Dim salario As Short

        Console.WriteLine("¿Cuantas horas trabaja al mes?")
        horas = Convert.ToByte(Console.ReadLine)
        Console.WriteLine("¿Cuanto cobra a la hora?")
        salario = Convert.ToByte(Console.ReadLine)

        Console.WriteLine()
        Console.WriteLine("Usted trabaja " & horas & " horas a la semana y cobra " & salario & " euros cada hora.")
        Console.WriteLine()

        If horas <= 38 Then
            salarioBruto = (horas * salario)
        Else
            salarioBruto = (38 * salario) + ((horas - 38) * salario) * 1.5
        End If

        If salarioBruto < 300 Then
            salarioNeto = salarioBruto
        Else
            salarioNeto = salarioBruto * 0.9
        End If

        Console.WriteLine("El salario neto es igual a " & salarioNeto)
        Console.ReadLine()



    End Sub



End Module
