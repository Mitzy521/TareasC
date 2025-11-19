using System;
using Descuentos;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el nombre del cliente: ");
        string name = Console.ReadLine();

        Console.WriteLine("Ingrese la edad del cliente: ");
        int edad = (int)(double.TryParse(Console.ReadLine(), out double e) ? e : 13);

        Console.WriteLine("Ingrese una breve descripción de la compra: ");
        string descrition = Console.ReadLine();

        Console.WriteLine("Ingrese el total de la compra: ");
        double monto = double.TryParse(Console.ReadLine(), out double m) ? m : 0;


        double montoDescuento1 = DDescuentos.descuento1(edad, monto);
        double montoDescuento2 = DDescuentos.descuento2(monto);

        double montoFinal = monto;
        string descuentosAplicados = "Ninguno";
       
        if (montoDescuento1 < monto)
        {
            montoFinal = montoDescuento1;
            descuentosAplicados = "Descuento por Edad";
        }
        
        if (montoDescuento2 < monto && montoDescuento2 < montoFinal)
        {
            montoFinal = montoDescuento2;
            descuentosAplicados = "Descuento por Monto";
        }
        
        if (montoDescuento1 < monto && montoDescuento1 == montoDescuento2)
        {
            montoFinal = montoDescuento1;
            descuentosAplicados = "Ambos Descuentos (Edad y Monto) - Se aplicó el mejor.";
        }

        Console.WriteLine(" ");
        Console.WriteLine("                    FACTURA FINAL");
        Console.WriteLine("                   Tienda en Línea");
        Console.WriteLine(" ");

        Console.WriteLine($"Nombre del cliente: {name}");
        Console.WriteLine($"Edad del cliente: {edad} años");
        Console.WriteLine($"Descripción: {descrition}");
        Console.WriteLine($"Monto Original: {monto}");
        Console.WriteLine(" ");

        Console.WriteLine($"Descuentos Aplicados: {descuentosAplicados}");
        Console.WriteLine($"MONTO TOTAL A PAGAR: {montoFinal}");

        Console.ReadKey();
    }
}