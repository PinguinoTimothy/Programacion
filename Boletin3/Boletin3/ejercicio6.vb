Option Strict On
Module ejercicio6
    Sub main()
        'Ejercicio 6
        'Escribir un programa que lea tres números y muestre por pantalla la 
        'media aritmética. Si la media es superior a 5 mandará un mensaje de  
        '“Alumno aprobado”. En cualquier otro caso el mensaje indica: 
        '“Alumno suspenso”. 

        Dim nota1, nota2, nota3 As Single
        Dim media As Single
        Dim aprobado As Boolean

        Console.WriteLine("Introduzca la nota 1: ")
        nota1 = Convert.ToSingle(Console.ReadLine())
        Console.WriteLine("Introduzca la nota 2: ")
        nota2 = Convert.ToSingle(Console.ReadLine())
        Console.WriteLine("Introduzca la nota 3: ")
        nota3 = Convert.ToSingle(Console.ReadLine())


        media = (nota1 + nota2 + nota3) / 3
        aprobado = media >= 5


        If aprobado Then
            Console.WriteLine("El alumno ha aprobado")
        Else
            Console.WriteLine("El alumno ha suspendido.")
        End If
        Console.ReadLine()

    End Sub

End Module
