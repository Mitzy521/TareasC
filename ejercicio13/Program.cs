using System;
using System.Collections.Generic;
/*
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
*/
/*
interface IImprimible
{
    void Imprimir();
}

class Factura : IImprimible
{
    public void Imprimir()
    {
        Console.WriteLine("Factura: Documento fiscal generado y listo para entrega al cliente.");
    }
}

class Reporte : IImprimible
{
    public void Imprimir()
    {
        Console.WriteLine("Reporte: Datos estadísticos compilados y listos para revisión gerencial.");
    }
}

class Etiqueta : IImprimible
{
    public void Imprimir()
    {
        Console.WriteLine("Etiqueta: Código de barras y descripción del producto listos para el inventario.");
    }
}

class ProgramaImpresion
{
    public static void Main()
    {
        List<IImprimible> documentos = new List<IImprimible>
        {
            new Factura(),
            new Reporte(),
            new Etiqueta()
        };

        Console.WriteLine("Ejecutando proceso de impresión:");
        foreach (IImprimible doc in documentos)
        {
            doc.Imprimir();
        }
    }
}
*/
interface IAutenticable
{
    bool Autenticar(string usuario, string clave);
}

class UsuarioWeb : IAutenticable
{
    public bool Autenticar(string usuario, string clave)
    {
        bool exito = usuario == "user" && clave == "user123";
        Console.WriteLine($"Autenticando Usuario Web {usuario}... Resultado: {(exito ? "ÉXITO" : "FALLO")}.");
        return exito;
    }
}

class Administrador : IAutenticable
{
    public bool Autenticar(string usuario, string clave)
    {
        bool exito = usuario == "admin" && clave == "admin123";
        Console.WriteLine($"Autenticando Administrador '{usuario}'... Resultado: {(exito ? "ÉXITO" : "FALLO")}.");
        return exito;
    }
}

class Invitado : IAutenticable
{
    public bool Autenticar(string usuario, string clave)
    {
        Console.WriteLine("Autenticando Invitado... Resultado: ÉXITO.");
        return true; 
    }
}

class ProgramaLogin
{
    public static void Main()
    {

        IAutenticable userWeb = new UsuarioWeb();
        userWeb.Autenticar("user", "user123");

        IAutenticable admin = new Administrador();
        admin.Autenticar("admin", "admin124"); 

        IAutenticable invitado = new Invitado();
        invitado.Autenticar(null, null);
    }
}
