using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduce tu nombre: ");
        string nombreEstudiante = Console.ReadLine();

        Saludar(nombreEstudiante);
    }
    
    static void Saludar(string nombre)
    {
        Console.WriteLine("Hola, " + nombre);
    }
}