namespace Operaciones;

public class Matematica
{
    public static double Sumar(double a, double b)
    {
        return a + b;
    }
    public static double Resta(double a, double b)
    {
        return a - b;
    }
    public static double Multiplicacion(double a, double b)
    {
        return a * b;
    }
    public static double Division (double a, double b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            return double.NaN; 
        }
    }
}
