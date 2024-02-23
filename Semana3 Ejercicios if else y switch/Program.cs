

Console.WriteLine("---Validar Usuario y contraseña---");
Console.WriteLine("");

try
{
    int contra = 12345;
    string user = "Mario";
    Console.WriteLine("Ingrese su Usuario");
    string usuario = Console.ReadLine();
    Console.WriteLine("Ingrese su Contraseña");
    int n1 = int.Parse(Console.ReadLine());

    if (usuario == user && n1 == contra)
    {
        Console.WriteLine("Acceso Permitido");
    }

    else
    {
        Console.WriteLine("Acceso Denegado");
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: Por favor, Ingrese un numero valido");
}