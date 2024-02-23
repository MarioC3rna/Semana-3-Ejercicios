

Console.WriteLine("Calcular el Precio Final de un Producto");
try
{
    
    Console.WriteLine("Ingrese el precio original del producto:");
    double POriginal = double.Parse(Console.ReadLine());


    if (POriginal > 100)
    {
       
        double descuento = POriginal * 0.10;
        double precioFinal = POriginal - descuento;
        Console.WriteLine("El precio final con descuento es: " + precioFinal);
    }
    else
    {
       
        Console.WriteLine("El precio final sin descuento es: " + POriginal);
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: Por favor ingrese un valor numérico válido.");
}