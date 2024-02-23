
Console.WriteLine("---Calcular el Importe a Pagar por un Servicio---");
Console.WriteLine("");
Console.WriteLine("Elige que servicio quiere");
Console.WriteLine("1.Lavado de Auto");
Console.WriteLine("2.Cambio de aceite");
Console.WriteLine("3.Revision Mecanica");
try
{
    int n1 = int.Parse(Console.ReadLine());
    string Ser;
    switch (n1)
    {
        case 1:

            Ser = "Lavado de Auto ";
            Console.WriteLine("El servicio que elijo es " + Ser + " el importe a pagar es de 100");
            break;

        case 2:
            Ser = "Cambio de Aceite ";
            Console.WriteLine("El servicio que elijo es " + Ser + " el importe a pagar es de 200");
            break;

        case 3:
            Ser = "Revision Mecanica ";
            Console.WriteLine("El servicio que elijo es " + Ser + " el importe a pagar es de 300");
            break;


        default:
            throw new Exception("Ese numero no esta en el rango ");

    }
}
catch (FormatException)
{
    Console.WriteLine("Error: Ingrese numeros validos");
}