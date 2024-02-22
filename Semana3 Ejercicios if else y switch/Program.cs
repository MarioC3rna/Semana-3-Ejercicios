{
    Console.WriteLine("---Calcular el Área de una Figura Geométrica---");
    Console.WriteLine("");

    Console.WriteLine("Elija que figura quiere calcular");
    Console.WriteLine("1. Triangulo");
    Console.WriteLine("2. Cuadrado");
    Console.WriteLine("3. Circulo");

    try
    {
        int opcionEle = int.Parse(Console.ReadLine());

        if (opcionEle == 1)
        {
            CalcularTriangulo();
        }
        else if (opcionEle == 2)
        {
            CalcularCuadrado();
        }
        else if (opcionEle == 3)
        {
            CalcularCirculo();
        }
        else
        {
            Console.WriteLine("Opcion no valida");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Por favor, introduzca un numero valido.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Error: El numero introducido no esta en el rango");
    }
}

static void CalcularTriangulo()
{
    Console.WriteLine("Ingrese la base");
    double baseT = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la altura");
    double alturaT = double.Parse(Console.ReadLine());
    double areaT = (baseT * alturaT) / 2;
    Console.WriteLine("El area del Triangulo es " + areaT);
}

static void CalcularCuadrado()
{
    Console.WriteLine("Ingrese el lado del cuadrado");
    double ladoC = double.Parse(Console.ReadLine());
    double areaC = ladoC * ladoC;
    Console.WriteLine("El área del cuadrado es: " + areaC);
}

static void CalcularCirculo()
{
    Console.WriteLine("Ingrese el radio del círculo:");
    double radioC = double.Parse(Console.ReadLine());
    double areaC = Math.PI * Math.Pow(radioC, 2);
    Console.WriteLine("El área del círculo es: " + areaC);
}
