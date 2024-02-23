
Console.WriteLine("---Mostrar un Mensaje de Bienvenida en Diferentes Idiomas---");
Console.WriteLine("");
Console.WriteLine("Eliga el idioma que desee");
Console.WriteLine("1.Español");
Console.WriteLine("2.Ingles");
Console.WriteLine("3.Frances");
try
{
    int n1 = int.Parse(Console.ReadLine());
    string Idioma;
    switch (n1)
    {
        case 1:

            Idioma = "Español";
            Console.WriteLine("--Bienvenido--");
            break;

        case 2:
            Idioma = "Ingles";
            Console.WriteLine("--Welcome--");
            break;

        case 3:
            Idioma = "Frances";
            Console.WriteLine("--Accueillir-");
            break;


        default:
            throw new Exception("Ese numero no esta en el rango");

    }
}
catch (FormatException)
{
    Console.WriteLine("Error: Ingrese numeros validos");
}