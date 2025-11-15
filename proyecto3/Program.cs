using System;
using System.Collections.Generic;

class Empleado
{
    public string Nombre;
    public string Departamento;
    public double SalarioBase;

    public Empleado(string nombre, string departamento, double salarioBase)
    {
        Nombre = nombre;
        Departamento = departamento;
        SalarioBase = salarioBase;
    }

    public virtual double CalcularSalario()
    {
        return SalarioBase;
    }
}

class Administrador : Empleado
{
    public double AntiguedadAnios;
    public double BonoPorAnio;

    public Administrador(string nombre, string departamento, double salarioBase, double antiguedadAnios, double bonoPorAnio)
        : base(nombre, departamento, salarioBase)
    {
        AntiguedadAnios = antiguedadAnios;
        BonoPorAnio = bonoPorAnio;
    }

    public override double CalcularSalario()
    {
        return SalarioBase + (AntiguedadAnios * BonoPorAnio);
    }
}
class Tecnico : Empleado
{
    public double BonoEspecializacion;
    public double PagoPorProyecto;

    public Tecnico(string nombre, string departamento, double salarioBase, double bonoEspecializacion, double pagoPorProyecto)
        : base(nombre, departamento, salarioBase)
    {
        BonoEspecializacion = bonoEspecializacion;
        PagoPorProyecto = pagoPorProyecto;
    }

    public override double CalcularSalario()
    {
        return SalarioBase + BonoEspecializacion + PagoPorProyecto;
    }
}
class Vendedor : Empleado
{
    public double ComisionGanada;
    public double BonoPorObjetivo;

    public Vendedor(string nombre, string departamento, double salarioBase, double comisionGanada, double bonoPorObjetivo)
        : base(nombre, departamento, salarioBase)
    {
        ComisionGanada = comisionGanada;
        BonoPorObjetivo = bonoPorObjetivo;
    }

    public override double CalcularSalario()
    {
        return SalarioBase + ComisionGanada + BonoPorObjetivo;
    }
}

class Program
{
    static void Main()
    {
    List<Empleado> empleados = new List<Empleado>();
    bool agregarMas = true;

    Console.WriteLine("Gestión de Salarios de TechSolutions");

        while (agregarMas)
        {
            Console.WriteLine("Seleccione el tipo de empleado a agregar:");
            Console.WriteLine("1: Administrador");
            Console.WriteLine("2: Técnico");
            Console.WriteLine("3: Vendedor");
            Console.Write("Opción: 1 - 2 - 3: ");

            string? opcion = Console.ReadLine();
            Empleado? nuevoEmpleado = null;

            Console.Write("Ingrese el nombre del empleado: ");
            string? nombre = Console.ReadLine() ?? "Sin Nombre";

            Console.Write("Ingrese el Salario Base: ");
            double salarioBase = double.TryParse(Console.ReadLine(), out double sb) ? sb : 0;

            string departamentoAsignado = "Sin Asignar";

            switch (opcion)
            {
                case "1":
                    departamentoAsignado = "Administración";
                    Console.WriteLine($"Departamento Asignado: {departamentoAsignado}");

                    Console.Write("Años de Antigüedad: ");
                    double old = double.TryParse(Console.ReadLine(), out double o) ? o : 0;

                    Console.Write("Bono por Antigüedad (monto por año): ");
                    double bono = double.TryParse(Console.ReadLine(), out double b) ? b : 0;

                    nuevoEmpleado = new Administrador(nombre, departamentoAsignado, salarioBase, old, bono);
                    break;

                case "2":
                    departamentoAsignado = "Técnico";
                    Console.WriteLine($"Departamento Asignado: {departamentoAsignado}");

                    Console.Write("Monto de Bono por Especialización: ");
                    double especializacion = double.TryParse(Console.ReadLine(), out double esp) ? esp : 0;

                    Console.Write("Monto de Pago por Proyecto: ");
                    double proyecto = double.TryParse(Console.ReadLine(), out double pro) ? pro : 0;

                    nuevoEmpleado = new Tecnico(nombre, departamentoAsignado, salarioBase, especializacion, proyecto);
                    break;

                case "3":
                    departamentoAsignado = "Ventas";
                    Console.WriteLine($"Departamento Asignado: {departamentoAsignado}");

                    Console.Write("Monto de Comisión Ganada (total del mes): ");
                    double comision = double.TryParse(Console.ReadLine(), out double com) ? com : 0;

                    Console.Write("Monto de Bono por Objetivo Alcanzado: ");
                    double objetivo = double.TryParse(Console.ReadLine(), out double obj) ? obj : 0;

                    nuevoEmpleado = new Vendedor(nombre, departamentoAsignado, salarioBase, comision, objetivo);
                    break;

                default:
                    Console.WriteLine("Opción no válida. No se agregó ningún empleado.");
                    break;
            }

            if (nuevoEmpleado != null)
            {
                empleados.Add(nuevoEmpleado);
            }

            Console.Write("¿Desea agregar otro empleado? (s/n): ");
            agregarMas = Console.ReadLine()?.ToLower() == "s";
        }

        Console.WriteLine(" ");
        Console.WriteLine("          REPORTE DE CÁLCULO DE SALARIOS        ");

        if (empleados.Count == 0)
        {
            Console.WriteLine("No se agregaron empleados al sistema.");
        }
        else
        {
            foreach (Empleado e in empleados)
            {
                Console.WriteLine(" ");
                Console.WriteLine($"Empleado: {e.Nombre}");
                Console.WriteLine($"Del Departamento: {e.Departamento}");
                Console.WriteLine($"Salario Obtenido: Q{e.CalcularSalario()}"); 
            }
        }
    }
}