Option Strict On

Module Module1

    Sub Main    ()

        'Ejercicio 4

        Dim radio, longitud, area, volumen As Double
        Const PI As Double = 3.141516

        Console.WriteLine("¿Cual es el radio?")
        radio = Convert.ToDouble(Console.ReadLine)

        longitud = 2 * PI * radio
        area = PI * (radio ^ 2)
        volumen = (4 / 3) * PI * (radio ^ 3)

        Console.WriteLine("La longitud es " & longitud)
        Console.WriteLine()
        Console.WriteLine("El area es " & area)
        Console.WriteLine()
        Console.WriteLine("El volumen es " & volumen)

        Console.ReadLine()


        'Ejercicio 5 

        Dim precio As Double
        Dim cantidad As Short
        Dim total As Double

        Console.WriteLine("¿Cual es el precio del producto?")
        precio = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine()
        Console.WriteLine("¿Y cuantas unidades desea?")
        cantidad = Convert.ToInt16(Console.ReadLine)

        total = precio * cantidad

        Console.WriteLine("El precio del producto es " & precio & " euros y la cantidad que compra es " & cantidad & " por lo tanto debe pagar " & total & " euros. Vuelva pronto")

        Console.ReadLine()


        'Ejercicio 8

        Dim P As Double
        Dim v As Double
        Dim n As Double
        Const r As Double = 0.082
        Dim t As Double

        Console.WriteLine("¿Cual es el volumen del gas?")
        v = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("¿Cuantos moles tiene?")
        n = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("¿Cual es la temperatura actual?")
        t = Convert.ToDouble(Console.ReadLine)

        P = (n * r * t) / v

        Console.WriteLine("Con un volumen de " & v & " litros ,y una temperatura de " & t & " kelvin, " & n & " moles de un gas ideal tienen una presión de " & P & " atmósferas.")

        Console.ReadLine()


        'Ejercicio 9

        Dim x, y, z, z1, z2, a, b, x2, y2, a2 As Double


        Console.WriteLine("¿Cuanto vale x?")
        x = Convert.ToDouble(Console.ReadLine)

        Console.WriteLine("¿Cuanto vale y?")
        y = Convert.ToDouble(Console.ReadLine)

        Console.WriteLine("¿Cuanto vale a?")
        a = Convert.ToDouble(Console.ReadLine)

        'Console.WriteLine("¿Cuanto vale b?")
        'b = Convert.ToDouble(Console.ReadLine)

        'z = x
        'z1 = a
        'z2 = b
        'x = y
        'y = z1
        'a = z2
        'b = z

        'Esto tambien sirve pero es mas casero
        x2 = x
        y2 = y
        z = x + y + a
        x = z - x - a
        y = z - y - x2
        a = z - a - y2

        Console.WriteLine("Invirtiendo valores...")
        System.Threading.Thread.Sleep(2000)
        Console.WriteLine()
        Console.WriteLine("X vale " & x)
        Console.WriteLine()
        Console.WriteLine("Y vale " & y)
        Console.WriteLine()
        Console.WriteLine("A vale " & a)
        'Console.WriteLine()
        'Console.WriteLine("B vale " & b)

        Console.ReadLine()



        'Ejercicio 10

        Dim horas, euroshora, sueldobruto, sueldoneto As Double

        Console.WriteLine("¿Cuantas horas trabajas al mes?")

        horas = Convert.ToDouble(Console.ReadLine)

        Console.WriteLine("¿A cuanto se te paga la hora?")

        euroshora = Convert.ToDouble(Console.ReadLine)

        sueldobruto = horas * euroshora
        sueldoneto = sueldobruto * 0.79

        Console.WriteLine("Tu sueldo bruto es de " & sueldobruto & " pero por el IRPF el sueldo neto se queda en " & sueldoneto)



        'Ejercicio 11

        Dim espacio, tiempo, velocidad As Double


        Console.WriteLine("¿Cuantos metros?")
        espacio = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("¿Cuantos segundos?")
        tiempo = Convert.ToDouble(Console.ReadLine)

        velocidad = espacio / tiempo

        Console.WriteLine("La velocidad es de " & velocidad & " m/s")
        Console.ReadLine()


        'Ejercicio 12

        Dim lado, area12, perimetro, diagonal As Double


        Console.WriteLine("¿Cual es el lado del cuadrado?")
        lado = Convert.ToDouble(Console.ReadLine)

        perimetro = lado * 4
        diagonal = lado * Math.Sqrt(2)
        area12 = lado ^ 2

        Console.WriteLine("El perimetro es " & perimetro)
        Console.WriteLine()
        Console.WriteLine("La diagonal es " & diagonal)
        Console.WriteLine()
        Console.WriteLine("El area es " & area12)

        Console.ReadLine()


        'Ejercicio 13

        Dim lcata, lcatb, hip As Double

        Console.WriteLine("¿Cuanto mide el cateto a?")
        lcata = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("¿Y el b?")
        lcatb = Convert.ToDouble(Console.ReadLine)

        hip = Math.Sqrt(((lcata ^ 2) + (lcatb ^ 2)))

        Console.WriteLine("La hipotenusa es " & hip)
        Console.ReadLine()


        'Ejercicio 14

        Dim pini, pfin, rebaja, pdesc, ahorro As Double

        Console.WriteLine("¿Cuanto cuesta el producto?")
        pini = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("¿Que porcentaje de descuento se le aplica?")
        pdesc = Convert.ToDouble(Console.ReadLine)

        rebaja = (pdesc / 100) * pini

        pfin = pini - rebaja
        ahorro = pini - pfin

        Console.WriteLine("Al aplicar un " & pdesc & " por ciento de descuento el precio final del producto es de " & pfin & " y por lo tanto se ahorra " & ahorro & " euros")
        Console.ReadLine()


        'Ejercicio 15

        Dim lado1, diagonal1, AL, V1 As Double

        Console.WriteLine("¿Cuanto mide el lado?")
        lado1 = Convert.ToDouble(Console.ReadLine)

        diagonal1 = Math.Sqrt(3) * lado1
        AL = 4 * lado1 ^ 2
        V1 = lado1 ^ 3

        Console.WriteLine(diagonal1)
        Console.WriteLine(AL)
        Console.WriteLine(V1)
        Console.ReadLine()

    End Sub

End Module
