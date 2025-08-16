using System;

class Program
{
    static int producto(int a, int b)
    {
        return a * b;
    }

    static void Main()
    {
        Console.WriteLine("Se realizara el producto de 2 números");
        Console.WriteLine("Introduzca el primer número:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduzca el segundo número:");
        int b = int.Parse(Console.ReadLine());

        int resultado = producto(a, b);
        Console.WriteLine($"El resultado del Producto de {a} y {b} es igual a {resultado}");
    }
}

/*
using System;

class Program
{
    static int producto(int a, int b)
    {
        return a * b;
    }

    static void Main()
    {
        Console.WriteLine("Se realizara el producto de 2 números");
        Console.WriteLine("Introduzca el primer número:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduzca el segundo número:");
        int b = int.Parse(Console.ReadLine());

        int resultado = producto(a, b);
        Console.WriteLine($"El resultado del Producto de {a} y {b} es igual a {resultado}");
    }
}
*/

/*
using System;

class Program
{
    static string verificacion()
    {
        Console.WriteLine("Ingresa un número entero:");
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int numero))
        {
            if (numero % 2 == 0)
            {
                return $"El número {numero} es par.";
            }
            else
            {
                return $"El número {numero} es impar.";
            }
        }
        else
        {
            return "Error: Entrada no válida. Por favor, ingresa un número entero.";
        }
    }

    static void Main()
    {
        string resultado = verificacion();
        Console.WriteLine(resultado);
    }
}
*/

/*
using System;

class Program
{
    static int compra(int precio, int cantidad)
    {
        return precio * cantidad;
    }

    static void Main()
    {
        Console.WriteLine("¿Qué producto ha adquirido?");
        string nombre = Console.ReadLine();

        Console.WriteLine("Escriba una breve descripción del producto");
        string descripcion = Console.ReadLine();

        Console.WriteLine("¿Cuál es el precio del producto por unidad?");
        int precio = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la cantidad de productos adquiridos");
        int cantidad = int.Parse(Console.ReadLine());

        int resultado = compra(precio, cantidad);
        Console.WriteLine($"Nombre del producto: {nombre}");
        Console.WriteLine($"Breve descripción del producto: {descripcion}");
        Console.WriteLine($"Precio del producto: {precio}");
        Console.WriteLine($"Cantidad de productos adquiridas: {cantidad}");
        Console.WriteLine(" ");
        Console.WriteLine($"Su total a pagar es de: {resultado}");
    }
}
*/
