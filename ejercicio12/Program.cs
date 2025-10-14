using System;
using System.Collections.Generic;
/*
class Forms
{
    public string? Nombre;
    public virtual double CalcularArea()
    {
        return 0;
    }
}

class Triangulo : Forms
{
    public double Base;
    public double Altura;
    
    public override double CalcularArea()
    {
        return (Base * Altura) / 2;
    }
}

class Rectangulo : Forms
{
    public double Ancho;
    public double Largo;
    
    public override double CalcularArea()
    {
        return Ancho * Largo;
    }
}

class Circulo : Forms
{
    public double Radio ;
    
    public override double CalcularArea()
    {
        return Math.PI * (Radio * Radio);
    }
}

class Program
{
    static void Main()
    {
        List<Forms> figuras = new List<Forms>
        {
            new Triangulo {Nombre = "triangulo", Base = 5, Altura = 10},
            new Rectangulo {Nombre = "rectangulo", Ancho = 10, Largo = 15},
            new Circulo {Nombre = "circulo", Radio = 5}
        };

        foreach (Forms f in figuras)
        {
            Console.WriteLine($"El área del {f.Nombre} es {f.CalcularArea()}");
        }
    }
}*/
/*
class Product
{
    public string? NameP;
    public virtual void MostrarDescripcion()
    {
        Console.WriteLine("No se encuntra ninguna descripción de los productos.");
    }
}

class Electronic : Product
{
    public override void MostrarDescripcion()
    {
        Console.WriteLine("Esta categoría incluye dispositivos portátiles como smartphones, laptops y smartwatches, enfocados en optimizar la vida digital diaria.");
    }
}

class Food : Product
{
    public override void MostrarDescripcion()
    {
        Console.WriteLine("La oferta alimentaria es diversa: desde productos frescos y básicos hasta alimentos procesados y funcionales.");
    }
}

class Clothes : Product
{
    public override void MostrarDescripcion()
    {
        Console.WriteLine("Las tendencias clave son la sostenibilidad, la ropa deportiva y el diseño que combina estilo y durabilidad en prendas para cualquier ocasión.");
    }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Electronic {NameP = "Electronica"},
            new Food {NameP = "Alimento"},
            new Clothes {NameP = "Ropa"}
        };

        foreach (Product p in products)
        {
            Console.WriteLine(p.NameP);
            p.MostrarDescripcion();
        }
        ;
    }
}
*/

using System;
using System.Collections.Generic;

abstract class Pago
{
    public string? Metodo;
    public abstract void Procesar(double monto);
}

class PagoEfectivo : Pago
{
    public PagoEfectivo()
    {
        Metodo = "Efectivo";
    }

    public override void Procesar(double monto)
    {
        Console.WriteLine($"Procesando Pago por {Metodo}");
        Console.WriteLine($"Validación: El cliente paga {monto:C} en físico.");
        Console.WriteLine("Confirmación: Pago recibido. Pendiente de entregar el cambio.");
    }
}
class PagoTarjeta : Pago
{
    public PagoTarjeta()
    {
        Metodo = "Tarjeta de Crédito/Débito";
    }

    public override void Procesar(double monto)
    {
        Console.WriteLine($"Procesando Pago con {Metodo}");
        Console.WriteLine("Validación: Conectando, Solicitando autorización bancaria...");
        Console.WriteLine($"Confirmación: Transacción de {monto:C} aprobada. Imprimiendo recibo.");
    }
}

class PagoTransferencia : Pago
{
    public PagoTransferencia()
    {
        Metodo = "Transferencia Bancaria";
    }

    public override void Procesar(double monto)
    {
        Console.WriteLine($"Procesando Pago por {Metodo}");
        Console.WriteLine("Validación: Esperando confirmación de la transferencia en la cuenta bancaria.");
        Console.WriteLine($"Confirmación: Referencia de transferencia verificada. Monto {monto:C} acreditado.");
    }
}

class Program
{
    static void Main()
    {
        double montoCompra = 150.75;
        List<Pago> metodosDePago = new List<Pago>
        {
            new PagoEfectivo(),
            new PagoTarjeta(),
            new PagoTransferencia()
        };

        Console.WriteLine($"Monto Total a Pagar: {montoCompra:C}");
        Console.WriteLine(new string('-', 30));

        foreach (Pago p in metodosDePago)
        {
            p.Procesar(montoCompra);
            Console.WriteLine(new string('-', 30));
        }
    }
}