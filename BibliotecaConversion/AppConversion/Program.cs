using System;
using FConversion;

class Program
{
    static void Main()
    {
        Console.WriteLine("Conversiones");
        Console.WriteLine("1. Metros a Kilometros");
        Console.WriteLine("2. Grados Celsius a Grados Fahrenheit");
        Console.Write("Ingrese el número de la operación que desea realizar: ");

        if (!int.TryParse(Console.ReadLine(), out int opcion))
        {
            Console.WriteLine("ERROR: Debe ingresar un número para la opción.");
            return;
        }

        if (opcion < 1 || opcion > 2)
        {
            Console.WriteLine("ERROR: Opción no válida. Por favor, ingrese 1 o 2.");
            return;
        }

        Console.Write("Ingrese el número a convertir: ");
        
        if (!double.TryParse(Console.ReadLine(), out double valor))
        {
            Console.WriteLine("ERROR: Entrada no válida para el valor de la conversión.");
            return;
        }

        double resultado = 0;

        switch (opcion)
        {
            case 1:
                resultado = Conversions.MetersToKilometers(valor); 
                Console.WriteLine($"{valor} metros equivalen a {resultado:F2} kilómetros.");
                break;
            case 2:
                resultado = Conversions.CelsiusToFahrenheit(valor); 
                Console.WriteLine($"{valor} °C equivalen a {resultado:F2} °F.");
                break;
        }
    }
}