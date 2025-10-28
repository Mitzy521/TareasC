using System;
using Operaciones;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora básica");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.Write("Ingrese el número de la operación que desea realizar: ");

        int opcion;
        if (!int.TryParse(Console.ReadLine(), out opcion))
        {
            Console.WriteLine("Debe ingresar un número para la opción.");
            return;
        }

        bool opcionValida = opcion >= 1 && opcion <= 4; 

        if (opcionValida)
        {   
            Console.Write("Ingrese el primer número: ");
            double a; 
            if (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Entrada no válida para el primer número.");
                return;
            }

            Console.Write("Ingrese el segundo número: ");
            double b;
            if (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Entrada no válida para el segundo número.");
                return;
            }

            double resultado = 0;
            bool operacionExitosa = true;

            switch (opcion)
            {
                case 1:
                    resultado = Matematica.Sumar(a, b); 
                    break;
                case 2:
                    resultado = Matematica.Resta(a, b); 
                    break;
                case 3:
                    resultado = Matematica.Multiplicacion(a, b); 
                    break;
                case 4:
                    if (b == 0)
                    {
                        Console.WriteLine("Error: No se puede dividir por cero.");
                        operacionExitosa = false;
                    }
                    else
                    {
                        resultado = Matematica.Division(a, b); 
                    }
                    break;
            }

            if (operacionExitosa)
            {
                Console.WriteLine($"El resultado de la operación es: {resultado}");
            }
        }
        else
        {
            Console.WriteLine("Opción no válida. Por favor, ingrese un número del 1 al 4.");
        }
    }
}