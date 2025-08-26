using System;
using System.Collections.Generic;
using System.Linq;

public class Alumno
{
    public string Nombre { get; set; }
    public int Nota { get; set; }

    public Alumno(string nombre, int nota)
    {
        Nombre = nombre;
        Nota = nota;
    }
}

class Program
{
    static void Main()
    {
        List<Alumno> listaAlumnos = new List<Alumno>();
        listaAlumnos.Add(new Alumno("Juan", 70));
        listaAlumnos.Add(new Alumno("Maria", 85));
        listaAlumnos.Add(new Alumno("Alex", 50));
        listaAlumnos.Add(new Alumno("Marta", 92));
        listaAlumnos.Add(new Alumno("Luisa", 56));
        listaAlumnos.Add(new Alumno("Angel", 87));

        Console.WriteLine("Listado de las Notas de los Alumnos:");
        Console.WriteLine("Nombre:  Nota: \t Estado:");

        foreach (var alumno in listaAlumnos)
        {
            if (alumno.Nota >= 61)
            {
                Console.WriteLine($"{alumno.Nombre} \t {alumno.Nota} \t Aprobado");
            }
            else
            {
                Console.WriteLine($"{alumno.Nombre} \t {alumno.Nota} \t No Aprobado");
            }
        }
        
        if (listaAlumnos.Any())
        {
            double promedio = listaAlumnos.Average(a => a.Nota);
            Console.WriteLine($"El promedio de notas es: {promedio:F2}");
        }
        else
        {
            Console.WriteLine("La lista de alumnos está vacía, no se puede calcular el promedio.");
        }
    }
}

/*
public class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }

    public Producto(string nombre, decimal precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
}

public class Program
{
    public static void Main()
    {
        List<Producto> listaProductos = new List<Producto>();

        listaProductos.Add(new Producto("Teclado", 50.00m));
        listaProductos.Add(new Producto("Monitor", 250.75m));
        listaProductos.Add(new Producto("Mouse", 25.00m));
        listaProductos.Add(new Producto("Auriculares", 150.00m));
        listaProductos.Add(new Producto("Impresora", 99.99m));
        listaProductos.Add(new Producto("Webcam", 75.50m));

        Console.WriteLine("Productos con precio superior a 100");


        foreach (var producto in listaProductos)
        {
            if (producto.Precio > 100)
            {
                 Console.WriteLine($"Nombre: {producto.Nombre}, Precio: ${producto.Precio}");
            }
        }
    }
}
*/

/*
class Program
{
    static void Main()
    {
        List<string> dispositivos = new List<string>();
        dispositivos.Add("Telefono");
        dispositivos.Add("Computadora");
        dispositivos.Add("Consola");
        dispositivos.Add("Televisor");
        dispositivos.Add("Impresora");
        dispositivos.Add("Escaner");
        dispositivos.Add("Reloj");
        dispositivos.Add("Auriculares");
        dispositivos.Add("Tablet");
        dispositivos.Add("Camara");

        Console.WriteLine("Lista de Dispositivos Electrónicos");
        Console.WriteLine("Ingrese el nombre del Dispositivo Electrónico para verificar si se encuentra en la Lista:");
        string disIngresado = Console.ReadLine();

        string disBuscado = disIngresado.ToLower();

        if (dispositivos.Select(d => d.ToLower()).Contains(disBuscado))
        {
            Console.WriteLine($"{disIngresado} Si forma parte de la lista de Dispositivos Electrónicos.");
        }
        else
        {
            Console.WriteLine($"{disIngresado} No forma parte de la lista de Dispositivos Electrónicos.");
        }
    }
}
*/
