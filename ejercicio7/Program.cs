using System;
/*
class Program
{
    public static void Main()
    {
        Console.WriteLine("División de dos números");

        Console.Write("Ingrese el primer número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        if (numero2 == 0)
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
        }
        else
        {
            double resultado = numero1 / numero2;
            Console.WriteLine($"El resultado de la división es: {resultado}");
        }
    }
}
*/

class Program
{
    public static void Main()
    {
        Console.WriteLine("Validación de precio");

        Console.Write("Ingrese un precio (debe ser numérico y positivo): ");
        string entrada = Console.ReadLine();

        try
        {
            double precio = Convert.ToDouble(entrada);
            if (precio < 0)
            {
                throw new Exception("El precio no puede ser negativo.");
            }

            Console.WriteLine($"Precio válido ingresado: {precio}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: El valor ingresado no es un número válido.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}