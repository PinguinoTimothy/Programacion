Option Strict On
Module Ejercicio12
    Sub main()
        Dim color As Char

        Console.WriteLine("Elige una letra")
        color = Convert.ToChar(Console.ReadLine)



        Select Case color
            Case "R"c, "r"c
                Console.Write("Rojo")
            Case "V"c, "v"c
                Console.Write("Verde")
            Case "A"c, "a"c
                Console.Write("Azul")
            Case Else
                Console.WriteLine("Negro")

        End Select



        Console.ReadLine()

    End Sub

End Module
