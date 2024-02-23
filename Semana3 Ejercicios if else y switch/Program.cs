
Console.WriteLine("---Mostrar el Día de la Semana a partir de un Número---");
Console.WriteLine("");
Console.WriteLine("Ingresa un numero del 1 al 7");

try
{
    int n1 = int.Parse(Console.ReadLine());
    string Dia;
    switch (n1)
    {
        case 1:
            Dia = "Lunes";
            Console.WriteLine(Dia);
            break;

        case 2:
            Dia = "Martes";
            Console.WriteLine(Dia);
            break;

        case 3:
            Dia = "Miercoles";
            Console.WriteLine(Dia);
            break;

        case 4:
            Dia = "Jueves";
            Console.WriteLine(Dia);
            break;

        case 5:
            Dia = "Viernes";
            Console.WriteLine(Dia);
            break;

        case 6:
            Dia = "Sabado";
            Console.WriteLine(Dia);
            break;

        case 7:
            Dia = "Domingo";
            Console.WriteLine(Dia);
            break;

        default:
            throw new Exception("Ese numero no esta en el rango ");

    }
}
catch (FormatException)
{
    Console.WriteLine("Error: Ingrese numeros validos");
}