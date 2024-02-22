
    Console.WriteLine("---Calcular el Mayor de Tres numeros---");
    Console.WriteLine("");

    try
    {
        Console.WriteLine("Ingrese tres numeros ");
        Console.WriteLine("Primer numero");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Segundo numero");
        int n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Tercer numero");
        int n3 = int.Parse(Console.ReadLine());

        if (n2 < n1 && n3 < n1)
        {
            Console.WriteLine("El numero mayor es " + n1);
        }

        else if (n1 < n2 && n3 < n2)
        {
            Console.WriteLine("El numero mayor es " + n2);
        }

        else if (n1 < n3 && n2 < n3)
        {
            Console.WriteLine("El numero mayor es " + n1);
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Ingrese numeros validos");
    }