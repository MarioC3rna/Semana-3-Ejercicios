
Console.WriteLine("Determinar si un numero es Par o Impar");
try
{    
    
    Console.WriteLine("Ingrese un número:");
    int numero = int.Parse(Console.ReadLine());

   
    if (numero % 2 == 0)
    {
        Console.WriteLine("El número ingresado es par.");
    }
    else
    {
        Console.WriteLine("El número ingresado es impar.");
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: Por favor ingrese un número válido.");
}