using System;
using System.Collections.Generic;
using System.Linq;
/*
class Program
{
    public class Monitor
    {
        public string Resolucion = "1920x1080";
        public string Marca = "Samsung";
    } 

    public class Teclado
    {
       public string Tipo = "Mecánico";
       public int NumeroTeclas = 105;
    }

    public class Mouse
    {
        public string TipoSensor = "Óptico";
        public int DpiMaximo = 16000;
    }

    public class Computadora
    {
        public Monitor Pantalla;
        public Teclado Entrada;
        public Mouse Raton;

    public Computadora()
    {
        Pantalla = new Monitor();
        Entrada = new Teclado();
        Raton = new Mouse();
    }

    public void Mostrar()
    {
        Console.WriteLine("Especificaciones de la Computadora");
        Console.WriteLine($"Monitor: Marca {Pantalla.Marca}, Resolución {Pantalla.Resolucion}");
        Console.WriteLine($"Teclado: Tipo {Entrada.Tipo}, {Entrada.NumeroTeclas} teclas");
        Console.WriteLine($"Mouse: Sensor {Raton.TipoSensor}, {Raton.DpiMaximo} DPI");
    }
    }


}
*/
/*
class Program
{

public class Libro
{
    public string Titulo;
    public string Autor;

    public Libro(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
    }
}
public class Estante
{
    public int NumeroEstante;
    private List<Libro> libros;

    public Estante(int numero)
    {
        NumeroEstante = numero;
        libros = new List<Libro>();
    }

    public void AgregarLibro(Libro libro)
    {
        libros.Add(libro);
    }

    public void MostrarLibros()
    {
        Console.WriteLine($"Libros en el Estante {NumeroEstante}");
        if (libros.Count == 0)
        {
            Console.WriteLine("El estante está vacío.");
            return;
        }
        foreach (var libro in libros)
        {
            Console.WriteLine($"Título: {libro.Titulo}, Autor: {libro.Autor}");
        }
    }
}

public class Bibliotecario
{
    public string Nombre;
    private List<Estante> estantesAdministrados; 

    public Bibliotecario(string nombre, List<Estante> estantes)
    {
        Nombre = nombre;
        estantesAdministrados = estantes;
    }

    public void AdministrarEstantes()
    {
        Console.WriteLine($"El Bibliotecario {Nombre} está revisando los estantes.");
        foreach (var estante in estantesAdministrados)
        {
            estante.MostrarLibros();
        }
    }
}
}
*/

class Program
{
public class Muro
{
    public string Material = "Ladrillo";
    public string Color = "Blanco";

    public void Reparar()
    {
        Console.WriteLine($"Muro de {Material} y color {Color} reparado.");
    }
}

public class Auto
{
    public string Marca;
    public string Modelo;

    public Auto(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    public void Estacionar()
    {
        Console.WriteLine($"Auto {Marca} {Modelo} estacionado.");
    }
}

public class Casa
{
    private Muro muroPrincipal; 

    public Auto Garaje;
    public Casa(Auto autoDelDueno)
    {
        muroPrincipal = new Muro(); 
    }

    public void MostrarEstructura()
    {
        Console.WriteLine("Estructura de la Casa");
        Console.Write("Muro Principal (Composición): ");
        muroPrincipal.Reparar();
        
        if (Garaje != null)
        {
            Console.Write("Auto en el Garaje (Agregación): ");
            Garaje.Estacionar();
        }
        else
        {
            Console.WriteLine("El garaje está vacío (Agregación).");
        }
    }
}
}

