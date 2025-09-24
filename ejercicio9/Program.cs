/*
using System;

public class Vehiculo
{
    public string Marca;
    public string Modelo;
    public Vehiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }
    public void MostrarInfo()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}");
    }
}

public class Motocicleta : Vehiculo
{
    public int Cilindrada;
    public Motocicleta(string marca, string modelo, int cilindrada) : base(marca, modelo)
    {
        Cilindrada = cilindrada;
    }
    public new void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Cilindrada: {Cilindrada}");
    }
}

public class Camion : Vehiculo
{
    public double CapacidadCarga;
    public Camion(string marca, string modelo, double capacidadCarga) : base(marca, modelo)
    {
        CapacidadCarga = capacidadCarga;
    }
    public new void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Capacidad de Carga: {CapacidadCarga} kg");
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Vehículos");
        
        Motocicleta moto = new Motocicleta("Yamaha", "MT-07", 700);
        Console.WriteLine("Motocicleta:");
        moto.MostrarInfo();

        Camion camion = new Camion("Volvo", "FH16", 44000);
        Console.WriteLine("Camión:");
        camion.MostrarInfo();
    }
}
*/

using System;
using System.Collections.Generic;

public class Empleado
{
    public string Nombre;
    public string Puesto;
    public List<string> Certificaciones = new List<string>();

    public Empleado(string nombre, string puesto)
    {
        Nombre = nombre;
        Puesto = puesto;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre}, Puesto: {Puesto}");
        Console.Write("Certificaciones: ");
        if (Certificaciones.Count > 0)
        {
            Console.WriteLine(string.Join(", ", Certificaciones));
        }
        else
        {
            Console.WriteLine("Ninguna");
        }
    }
}

public class Gerente : Empleado
{
    public int CantidadEmpleados;
    public Gerente(string nombre, string puesto, int cantidadEmpleados) : base(nombre, puesto)
    {
        CantidadEmpleados = cantidadEmpleados;
    }
    public new void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Empleados a cargo: {CantidadEmpleados}");
    }
}

public class Programador : Empleado
{
    public string Especialidad;

    public Programador(string nombre, string puesto, string especialidad) : base(nombre, puesto)
    {
        Especialidad = especialidad;
    }

    public new void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Especialidad: {Especialidad}");
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Empleados");

        Gerente gerente = new Gerente("Juan Pérez", "Gerente de Proyectos", 5);
        Console.WriteLine("Gerente:");
        gerente.MostrarInfo();

        Console.WriteLine(); 

        Programador programador = new Programador("María López", "Desarrolladora", "C#");
        programador.Certificaciones.Add("Fullstack Developer");
        Console.WriteLine("Programador:");
        programador.MostrarInfo();
    }
}
