using System;
using System.Collections.Generic;

public class Productos
{
    public static void Main()
    {
        List<string> productos = new List<string> { "Leche", "Pan", "Huevos", "Queso", "Arroz" };

        Console.WriteLine("Por favor, ingrese el nombre del producto que desea buscar:");
        string productoBuscado = Console.ReadLine();

        bool estaDisponible = false;
        foreach (string producto in productos)
        {
            if (producto.Equals(productoBuscado, StringComparison.OrdinalIgnoreCase))
            {
                estaDisponible = true;
                break;
            }
        }

        if (estaDisponible)
        {
            Console.WriteLine($"El producto '{productoBuscado}' está disponible.");
        }
        else
        {
            Console.WriteLine($"El producto '{productoBuscado}' no está disponible.");
        }
    }
}

/*
public class ObjetosProducto
{
    public class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
    }

    public static void Main()
    {
        List<Producto> listaProductos = new List<Producto>
        {
            new Producto { Nombre = "Laptop", Precio = 5500.00m },
            new Producto { Nombre = "Mouse", Precio = 85.50m },
            new Producto { Nombre = "Teclado Mecánico", Precio = 750.00m },
            new Producto { Nombre = "Monitor", Precio = 1500.00m },
            new Producto { Nombre = "USB", Precio = 50.00m }
        };

        Console.WriteLine("Productos con un precio mayor a Q100:");

        foreach (Producto p in listaProductos)
        {
            if (p.Precio > 100.00m)
            {
                Console.WriteLine($"- {p.Nombre} (Q{p.Precio})");
            }
        }
    }
}
*/

/*
public class Estudiantes
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Nota { get; set; }
    }

    public static void Main()
    {
        List<Estudiante> listaEstudiantes = new List<Estudiante>
        {
            new Estudiante { Nombre = "Juan", Nota = 85 },
            new Estudiante { Nombre = "María", Nota = 58 },
            new Estudiante { Nombre = "Pedro", Nota = 92 },
            new Estudiante { Nombre = "Ana", Nota = 65 },
            new Estudiante { Nombre = "Luis", Nota = 45 }
        };

        Console.WriteLine("Estudiantes aprobados (Nota >= 61):");
        int sumaNotas = 0;

        foreach (Estudiante e in listaEstudiantes)
        {
            sumaNotas += e.Nota;
            if (e.Nota >= 61)
            {
                Console.WriteLine($"- {e.Nombre} (Nota: {e.Nota})");
            }
        }

        double promedio = (double)sumaNotas / listaEstudiantes.Count;
        Console.WriteLine($"\nEl promedio general de las notas es: {promedio:F2}");
    }
}
*/
