Option Strict On
Module Ejercicio8
    Sub main()

        Dim contraseña1 As String
        Const contraseña2 As String = "tambor"

        Console.WriteLine("Introduzca la contraseña: ")
        contraseña1 = Console.ReadLine

        If contraseña1 = contraseña2 Then
            Console.WriteLine("Contraseña correcta, accediendo...")

        Else Console.WriteLine("Contraseña incorrecta, cerrando")

        End If

        Console.ReadLine()
    End Sub
End Module
