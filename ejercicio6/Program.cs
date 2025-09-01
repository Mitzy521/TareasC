using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Nota { get; set; }
    }

    public static void Main()
    {
        Console.WriteLine("Estudiantes aprobados (Nota >= 61)");

        List<Estudiante> listaEstudiantes = new List<Estudiante>
        {
            new Estudiante { Nombre = "Juan", Nota = 85 },
            new Estudiante { Nombre = "María", Nota = 58 },
            new Estudiante { Nombre = "Pedro", Nota = 92 },
            new Estudiante { Nombre = "Ana", Nota = 65 },
            new Estudiante { Nombre = "Luis", Nota = 45 }
        };

        var aprobados = listaEstudiantes.Where(e => e.Nota >= 61);

        foreach (var estudiante in aprobados)
        {
            Console.WriteLine($"-Nombre: {estudiante.Nombre} -Nota: {estudiante.Nota}");
        }
    }
}

/*
class Program
{
    public class EstudianteFiltro
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Estatura { get; set; }
    }
    
    public static void Main()
    {

        Console.WriteLine("Estudiantes mayores de edad y altos");

        List<EstudianteFiltro> listaFiltro = new List<EstudianteFiltro>
        {
            new EstudianteFiltro { Nombre = "Carlos", Edad = 20, Estatura = 1.75 },
            new EstudianteFiltro { Nombre = "Sofia", Edad = 17, Estatura = 1.68 },
            new EstudianteFiltro { Nombre = "Ricardo", Edad = 22, Estatura = 1.80 },
            new EstudianteFiltro { Nombre = "Laura", Edad = 19, Estatura = 1.60 },
            new EstudianteFiltro { Nombre = "José", Edad = 25, Estatura = 1.65 }
        };

        var estudiantesSeleccionados = listaFiltro.Where(e => e.Edad >= 18 && e.Estatura > 1.65);
        foreach (var estudiante in estudiantesSeleccionados)
        {
            Console.WriteLine($"- {estudiante.Nombre} (Edad: {estudiante.Edad}, Estatura: {estudiante.Estatura}m)");
        }
    }
}
*/