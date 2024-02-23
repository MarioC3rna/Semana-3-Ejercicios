
Console.WriteLine("---Mostrar un Mensaje de Aprobación o Rechazo de Préstamo---");
Console.WriteLine("");

Console.WriteLine("Ingrese la cantidad del prestamo");
double n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese su edad");

try
{
    int n2 = int.Parse(Console.ReadLine());

    if (n1 < 5000 || n2 > 60)
    {
        Console.WriteLine("El prestamo es Aprobado");
    }

    else
    {
        Console.WriteLine("El prestamos ha sido denegado");
    }
}
catch (FormatException)
{
    Console.WriteLine("Error:Por favor, Ingrese numeros");
}