using System;
/*
public class Producto
{
    public string Nombre;
    public double Precio;
    public int Cantidad;

    public Producto(string name, double price, int amount)
    {
        Nombre = name;
        Precio = price;
        Cantidad = amount;
    }
}

class Program
{
    static void Main()
    {
        Producto product = new Producto("Manzana", 5, 10);
        Console.WriteLine("Se ha creado producto");
    }
}
*/
/*
public class Estudiante
{
    public string Nombre;
    public double Nota;

    public Estudiante(string nombre, double nota)
    {
        Nombre = nombre;
        Nota = nota;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre}");
    }
    public void MostrarInfo(bool mostrarNota)
    {
        if (mostrarNota)
        {
            Console.WriteLine($"Nombre: {Nombre}, Nota: {Nota}");
        }
        else
        {
            MostrarInfo();
        }
    }
}

public class Program
{
    public static void Main()
    {
        Estudiante estudiante1 = new Estudiante("Ana García", 8.5);

        Console.WriteLine("Nombre del estudiante:");
        estudiante1.MostrarInfo(); 

        Console.WriteLine("Nombre y Nota del estudiante:");
        estudiante1.MostrarInfo(true);
    }
}
*/

public class Vehiculo
{
    public string Marca;
    public string Modelo;
    public int? Anio;

    public Vehiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
        Anio = null;
    }
    public Vehiculo(string marca, string modelo, int anio)
    {
        Marca = marca;
        Modelo = modelo;
        Anio = anio;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        
        if (Anio.HasValue)
        {
            Console.WriteLine($"Año: {Anio}");
        }
        else
        {
            Console.WriteLine("Año: No especificado");
        }
    }
}

public class Program
{
    public static void Main()
    {

        Vehiculo vehiculo1 = new Vehiculo("Toyota", "Corolla");
        Console.WriteLine("Marca y Modelo del vehículo:");
        vehiculo1.MostrarInfo();

        Console.WriteLine(); 

        // Usamos el segundo constructor (con año)
        Vehiculo vehiculo2 = new Vehiculo("Ford", "Mustang", 2022);
        Console.WriteLine("Marca, Modelo y año del vehículo:");
        vehiculo2.MostrarInfo();
    }
}