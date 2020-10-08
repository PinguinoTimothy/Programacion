Module Module1

    Sub Main()
        'Declaración de variables sin inicializar
        'Las variables numericas sin inicilizar, se ponen por defecto con un valor de 0
        Dim edad As Byte
        Dim numloteria As Integer
        Dim notaAcceso As Single
        Dim temperatura As Double
        Dim sueldo As Short
        Dim Letradni As Char
        Dim email As String
        'Comprobación de valores
        Console.WriteLine(edad)

        'Modificar valor de una variable
        edad = 17
        temperatura = 19.23

        'Incrementar valor de una variable
        temperatura = temperatura + 2
        edad = edad + 1

        'Declarar e inicializar las variables
        Dim num1 As Integer = 4
        Dim num2 As Integer = 9
        Dim caracter As Char = "e"c
        Dim dni As String = "12345678A"
        Dim condición As Boolean = True

        'Reglas para los nombres de las variables:
        '1ª Representativo de la utilidad de la variable.
        '2ª No pueden contener espacios.
        '3ª No pueden empezar por un digito pero puedo contenerlo.
        '4ª No pueden tener caracteres especiales, excepto el guión bajo.
        '5ª No pueden ser palabras reservadas para el lenguaje.  



        Console.ReadLine()

    End Sub

End Module
