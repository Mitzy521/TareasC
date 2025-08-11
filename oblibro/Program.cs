using System;

class libro
{
    public string nombrelibro;
    public string autor;
    public int decada;
    public string genero;

    public void datos()
    {
        Console.WriteLine($"{nombrelibro} es un libro de {genero} del año {decada} escrito por {autor}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        libro libro1 = new libro();
        
        Console.WriteLine("Ingrese el nombre del libro: ");
        libro1.nombrelibro = Console.ReadLine();
        
        Console.WriteLine("Ingrese el autor del libro: ");
        libro1.autor = Console.ReadLine();
        
        Console.WriteLine("Ingrese el año de creación del libro:");
        libro1.decada = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Ingrese el genero al que pertenece el libro:");
        libro1.genero = Console.ReadLine();

        libro1.datos();
    }
}