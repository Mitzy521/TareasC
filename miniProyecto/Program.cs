using System;
using System.Collections.Generic;
using System.Linq;

public class Producto
{
    public string Categoria { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Cantidad { get; set; }
}

public class GestorInventario
{
    public static List<Producto> listaProductos = new List<Producto>();

    public static void Main()
    {
        listaProductos.Add(new Producto { Categoria = "Electrónica", Nombre = "Laptop", Precio = 5500.00m, Cantidad = 10 });
        listaProductos.Add(new Producto { Categoria = "Electrónica", Nombre = "Mouse", Precio = 85.50m, Cantidad = 50 });
        listaProductos.Add(new Producto { Categoria = "Electrónica", Nombre = "Teclado Mecánico", Precio = 750.00m, Cantidad = 25 });
        listaProductos.Add(new Producto { Categoria = "Hogar", Nombre = "Monitor", Precio = 1500.00m, Cantidad = 15 });
        listaProductos.Add(new Producto { Categoria = "Almacenamiento", Nombre = "USB", Precio = 50.00m, Cantidad = 100 });
        listaProductos.Add(new Producto { Categoria = "Hogar", Nombre = "Televisor", Precio = 3000.00m, Cantidad = 5 });

        bool continuar = true;
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("Opciones de Gestión de Inventario");
            Console.WriteLine("1. Registrar un nuevo producto");
            Console.WriteLine("2. Consultar productos por nombre o categoría");
            Console.WriteLine("3. Actualizar precio o cantidad de un producto");
            Console.WriteLine("4. Eliminar un producto");
            Console.WriteLine("5. Estadistica");
            Console.WriteLine("6. Salir");
            Console.WriteLine(" ");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RegistrarProducto();
                    break;
                case "2":
                    ConsultarProductos();
                    break;
                case "3":
                    ActualizarProducto();
                    break;
                case "4":
                    EliminarProducto();
                    break;
                case "5":
                    Estadistica();
                    break;
                case "6":
                    continuar = false;
                    Console.WriteLine("Fin del Proceso.");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    public static void RegistrarProducto()
    {
        Console.Clear();
        Console.WriteLine("Registrar un nuevo producto");
        Console.Write("Ingrese la categoría del producto: ");
        string categoria = Console.ReadLine();
        Console.Write("Ingrese el nombre del producto: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese el precio del producto: ");
        decimal precio = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ingrese la cantidad de productos disponibles: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());


        listaProductos.Add(new Producto { Categoria = categoria, Nombre = nombre, Precio = precio, Cantidad = cantidad });
        Console.WriteLine("El producto ha sido Registrado"); 
        Console.ReadKey();
    }

    public static void ConsultarProductos()
    {
        Console.Clear();
        Console.WriteLine("Consultar de productos disponibles");
        Console.WriteLine("Ingrese el nombre del producto que desea buscar");
        string busqueda = Console.ReadLine().ToLower();

        var resultados = listaProductos.Where(p => p.Nombre.ToLower().Contains(busqueda)).ToList();

        if (resultados.Any())
        {
            Console.WriteLine("Resultados de la búsqueda:");
            foreach (var producto in resultados)
            {
                Console.WriteLine($"Nombre: {producto.Nombre}");
                Console.WriteLine($"Categoría: {producto.Categoria}");
                Console.WriteLine($"Precio: {producto.Precio:C}");
                Console.WriteLine($"Cantidad: {producto.Cantidad}");
            }
        }
        else
        {
            Console.WriteLine("El producto no se encuentra en la lista");
        }
        Console.ReadKey();
    }

    public static void ActualizarProducto()
    {
        Console.Clear();
        Console.WriteLine("Actualización del estado de un Producto");
        Console.Write("Ingrese el nombre del producto a actualizar: ");
        string nombre = Console.ReadLine();

        Producto producto = listaProductos.FirstOrDefault(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

        if (producto != null)
        {
            Console.WriteLine("Producto encontrado. ¿Qué desea actualizar?");
            Console.WriteLine("1. Precio");
            Console.WriteLine("2. Cantidad");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.Write("Ingrese el nuevo precio: ");
                decimal nuevoPrecio;
                while (!decimal.TryParse(Console.ReadLine(), out nuevoPrecio))
                {
                    Console.Write("No válido. Ingrese un precio numérico: ");
                }
                producto.Precio = nuevoPrecio;
                Console.WriteLine("Precio actualizado exitosamente.");
            }
            else if (opcion == "2")
            {
                Console.Write("Ingrese la nueva cantidad: ");
                int nuevaCantidad;
                while (!int.TryParse(Console.ReadLine(), out nuevaCantidad))
                {
                    Console.Write("No válido. Ingrese una cantidad entera: ");
                }
                producto.Cantidad = nuevaCantidad;
                Console.WriteLine("Cantidad actualizada exitosamente.");
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }
        Console.ReadKey();
    }

    public static void EliminarProducto()
    {
        Console.Clear();
        Console.WriteLine("Eliminar producto existente");
        Console.Write("Ingrese el nombre del producto a eliminar: ");
        string nombre = Console.ReadLine();

        Producto producto = listaProductos.FirstOrDefault(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

        if (producto != null)
        {
            listaProductos.Remove(producto);
            Console.WriteLine("El producto ha sido eliminado.");
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }
        Console.ReadKey();
    }

    public static void Estadistica()
    {
        Console.Clear();
        Console.WriteLine("Estadistica de los productos existentes");
        int totalCantidad = listaProductos.Sum(p => p.Cantidad);

        if (totalCantidad == 0)
        {
            Console.WriteLine("El inventario se encuentra vacío.");
        }
        else
        {
            foreach (var producto in listaProductos)
            {
                decimal porcentaje = (decimal)producto.Cantidad / totalCantidad * 100;
                Console.WriteLine($"Producto: {producto.Nombre}, Cantidad: {producto.Cantidad}, Porcentaje: {porcentaje:F2}%");
            }
        }

        Console.ReadKey();
    }
}