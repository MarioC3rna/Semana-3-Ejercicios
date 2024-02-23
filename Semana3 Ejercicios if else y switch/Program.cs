
Console.WriteLine("---Evaluar la Calificación de un Examen---");
Console.WriteLine("");

try
{
    Console.WriteLine("Ingrese la calificación del examen:");
    int calificacion = int.Parse(Console.ReadLine());

    switch (calificacion)
    {
        case int n when (n >= 90 && n <= 100):
            Console.WriteLine("Sobresaliente");
            break;
        case int n when (n >= 80 && n <= 89):
            Console.WriteLine("Notable");
            break;
        case int n when (n >= 70 && n <= 79):
            Console.WriteLine("Aprobatoria");
            break;
        case int n when (n >= 60 && n <= 69):
            Console.WriteLine("No aprobatoria");
            break;
        default:
            Console.WriteLine("Calificación no válida");
            break;
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: Ingrese un numero entero.");
}
catch (OverflowException)
{
    Console.WriteLine("Error: El número que ingreso no esta en el rango.");
}

