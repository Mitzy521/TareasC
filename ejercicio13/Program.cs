using System;
using System.Collections.Generic;

interface IPago
{
    void Procesar(double cantidad);
}
class PagoEfectivo : IPago
{
    public void Procesar(double cantidad)
    {
        Console.WriteLine($"Validación del pago en efectivo: El cliente paga {cantidad:C} en físico.");
        Console.WriteLine("Confirmación: Pago recibido");
    }
}
class PagoTarjeta : IPago
{
    public void Procesar(double cantidad)
    {
        Console.WriteLine("Validación del pago con tarjeta: Conectando...");
        Console.WriteLine($"Confirmación: Transacción de {cantidad:C} aprobada. Imprimiendo recibo.");
    }
}
class PagoTransferencia : IPago
{
    public void Procesar(double cantidad)
    {
        Console.WriteLine("Validación del pago con tranferencia: Esperando confirmación de la transferencia en la cuenta bancaria.");
        Console.WriteLine($"Confirmación: Referencia de transferencia verificada. Monto {cantidad:C} acreditado.");
    }
}

class Program
{
    static void Main()
    {
        double montoCompra = 250.75;
        List<IPago> metodosDePago = new List<IPago> 
        {
            new PagoEfectivo(),
            new PagoTarjeta(),
            new PagoTransferencia()
        };

        Console.WriteLine($"Monto Total a Pagar: {montoCompra:C}");
        Console.WriteLine();

        foreach (IPago p in metodosDePago)
        {
            p.Procesar(montoCompra);
            Console.WriteLine();
        }
    }
}