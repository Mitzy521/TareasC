using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("CALCULADORA");
        Console.WriteLine("Elige una operación:");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("5. Factorial");
        Console.Write("Tu opción: ");

        string opcion = Console.ReadLine();
        if (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "5")
        {
            Console.WriteLine("No se pudo realizar ninguna operación. Por favor, elige una opción del 1 al 5.");
            return; // `return` termina la ejecución del método Main.
        }

        if (opcion != "5")
        {
        Console.Write("Ingresa el primer número: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        num2 = Convert.ToDouble(Console.ReadLine());
        }
        else
        {
        Console.Write("Ingresa el número para calcular el factorial: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        }

        double resultado = 0.0;
        long factorial = 1;

        switch (opcion)
        {
            case "1": // Suma
                resultado = num1 + num2;
                Console.WriteLine($"El resultado de la suma es: {resultado}");
                break;

            case "2": // Resta
                resultado = num1 - num2;
                Console.WriteLine($"El resultado de la resta es: {resultado}");
                break;

            case "3": // Multiplicación
                resultado = num1 * num2;
                Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
                break;

            case "4": // División
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine($"El resultado de la división es: {resultado}");
                }
                else
                {
                    Console.WriteLine("Error: No se puede dividir entre cero.");
                }
                break;

            case "5": // Factorial
                if (num1 < 0 || num1 != (int)num1)
                {
                    Console.WriteLine("Error: El factorial solo es para números enteros no negativos.");
                    break;
                }
                
                int numeroFactorial = (int)num1;
                
                if (numeroFactorial == 0)
                {
                    factorial = 1;
                }
                else
                {
                    for (int i = 1; i <= numeroFactorial; i++)
                    {
                        factorial *= i;
                    }
                }
                Console.WriteLine($"El resulatdo del factorial es {factorial}");
                break;

            default:
                break;
        }
    }
}