using System;
using Validacion;

class Program
{
    static void Main()
    {
        SimularFormularioRegistro();
    }

    static void SimularFormularioRegistro()
    {
        Console.WriteLine("SIMULACIÓN DE FORMULARIO DE REGISTRO");

        string nombre;
        int edad;
        string correo;
        DateTime fechaNacimiento;

        do
        {
            Console.Write("Ingrese su Nombre de Usuario: ");
            nombre = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: El nombre de usuario no puede estar vacío.");
                Console.ResetColor();
            }
        } while (string.IsNullOrWhiteSpace(nombre));

        do
        {
            Console.Write("Ingrese su Edad (número): ");
            string inputEdad = Console.ReadLine();
            
            if (Validador.ValidarNumeroEntero(inputEdad, out edad) && edad >= 18)
            {
                break;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR: Debe ingresar un número entero y ser mayor de 18 años.");
            Console.ResetColor();
        } while (true);

        do
        {
            Console.Write("Ingrese su Correo Electrónico: ");
            correo = Console.ReadLine();
            if (Validador.ValidarCorreo(correo))
            {
                break;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR: Ingrese un formato de correo válido (ej. usuario@gmail.com).");
            Console.ResetColor();
        } while (true);

        do
        {
            Console.Write("Ingrese su Fecha de Nacimiento (DD/MM/AAAA): ");
            string inputFecha = Console.ReadLine();

            if (Validador.ValidarFecha(inputFecha, out fechaNacimiento))
            {
                break;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR: Ingrese una fecha válida.");
            Console.ResetColor();
        } while (true);

        Console.WriteLine("¡REGISTRO COMPLETADO EXITOSAMENTE!");
        Console.ResetColor();
        Console.WriteLine($"Usuario: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Correo: {correo}");
        Console.WriteLine($"Fecha Nacimiento: {fechaNacimiento.ToShortDateString()}");
    }
}
