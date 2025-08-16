/*
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escriba su edad:");
        int edad = int.Parse(Console.ReadLine());

        if (edad >= 18) {
            Console.WriteLine("Usted puede votar.");
        }
        else {
                Console.WriteLine("Usted no cumple con la edad requerida para votar.");
        }
    }
    
}
*/

/*
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduzca el nombre del día de hoy (Escriba la primera letra mayuscula):");
        string dia = Console.ReadLine();

        if (dia != "Domingo" && dia != "Lunes" && dia != "Martes" && dia != "Miercoles" && dia != "Jueves" && dia != "Viernes" && dia != "Sabado")
        {
            Console.WriteLine("La opcion selecionada no es valido");
            return;
        }
        switch (dia)
        {
            case "Domingo":
                Console.WriteLine("Hoy es Fin de Semana");
                break;

            case "Lunes":
                Console.WriteLine("Hoy es Inicio de Semana");
                break;

            case "Martes":
                Console.WriteLine("Hoy es Inicio de Semana");
                break;

            case "Miercoles":
                Console.WriteLine("Hoy es Mediado de Semana");
                break;
            
            case "Jueves":
                Console.WriteLine("Hoy es casi Fin de Semana");
                break;

            case "Viernes":
                Console.WriteLine("Hoy es casi Fin de Semana");
                break;

            case "Sabado":
                Console.WriteLine("Hoy es Fin de Semana");
                break;

            default:
                break;
        }
    }
}
*/

/*
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Tabla de multiplicación del número 7:");

        for (int i = 1; i <= 10; i++)
        {
            int resultado = 7 * i;
            Console.WriteLine($"7 x {i} = {resultado}");
        }
    }
}
*/