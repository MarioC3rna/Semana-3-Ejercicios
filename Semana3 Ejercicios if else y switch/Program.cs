

Console.WriteLine("---Validar la edad para el Club---");
Console.WriteLine("");

Console.WriteLine("Ingrese su edad");


try
{
    int n1 = int.Parse(Console.ReadLine());
    if (n1 >= 18)
    {
        Console.WriteLine("Puedes entrar al Club");
    }

    else
    {
        Console.WriteLine("No puedes entrar al Club");
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: Por favor, ingrese un número válido para la edad.");
}


