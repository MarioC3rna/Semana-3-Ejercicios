
Console.WriteLine("---Convertir un Numero de Letra a Numero---");
Console.WriteLine("");
Console.WriteLine("Escribe en letras un numero del 1 al 5 en minusculas");

try
{
    string Npalabra = Console.ReadLine().ToLower();
    int n1;
    switch (Npalabra)
    {
        case "uno":
            n1 = 1;
            Console.WriteLine("Este es su numero convertido " + n1);
            break;

        case "Dos":
            n1 = 2;
            Console.WriteLine("Este es su numero convertido " + n1);
            break;

        case "tres":
            n1 = 3;
            Console.WriteLine("Este es su numero convertido " + n1);
            break;

        case "cuatro":
            n1 = 4;
            Console.WriteLine("Este es su numero convertido " + n1);
            break;

        case "cinco":
            n1 = 5;
            Console.WriteLine("Este es su numero convertido " + n1);
            break;


        default:
            throw new Exception("Ese numero no esta en el rango ");
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: Ingrese numeros validos");
}