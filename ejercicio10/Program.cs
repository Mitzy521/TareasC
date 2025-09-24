/*
using System;

public abstract class Figura
{
    public abstract double CalcularArea();
}

public class Circulo : Figura
{
    public double Radio;

    public Circulo(double radio)
    {
        Radio = radio;
    }
    public override double CalcularArea()
    {
        return 3.1416 * Radio * Radio;
    }
}

public class Rectangulo : Figura
{
    public double Ancho;
    public double Alto;

    public Rectangulo(double ancho, double alto)
    {
        Ancho = ancho;
        Alto = alto;
    }
    public override double CalcularArea()
    {
        return Ancho * Alto;
    }
}

public class Program
{
    public static void Main()
    {
        Figura miCirculo = new Circulo(5);
        Figura miRectangulo = new Rectangulo(4, 6);

        Console.WriteLine($"Área del círculo: {miCirculo.CalcularArea()}");
        Console.WriteLine($"Área del rectángulo: {miRectangulo.CalcularArea()}");
    }
}
*/

using System;
using System.Collections.Generic;

public class Clima
{
    public virtual void Describir()
    {
        Console.WriteLine("El clima es normal.");
    }
}

public class Soleado : Clima
{
    public override void Describir()
    {
        Console.WriteLine("El día está soleado.");
    }
}

public class Lluvioso : Clima
{
    public override void Describir()
    {
        Console.WriteLine("El día está lluvioso.");
    }
}

public class Program
{
    public static void Main()
    {
        List<Clima> climas = new List<Clima>();
        climas.Add(new Soleado());
        climas.Add(new Lluvioso());
        climas.Add(new Clima());

        Console.WriteLine("Clima de los días:");
        foreach (var c in climas)
        {
            c.Describir(); 
        }
    }
}