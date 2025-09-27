using System;
using System.Collections.Generic;
using System.Linq;

public class RegistroNotas
{
    private Dictionary<string, List<double>> studentNotes;

    public RegistroNotas()
    {
        studentNotes = new Dictionary<string, List<double>>();
    }

    public void AddStudent(string studentName, List<double> grades)
    {
        studentNotes[studentName] = grades;
    }

    public double CalculateAverage(string studentName)
    {
        var grades = studentNotes[studentName];
        if (!grades.Any())
        {
            throw new ArgumentException($"La lista de notas para '{studentName}' está vacía. No se puede calcular el promedio.");
        }

        return grades.Average();
    }
}
//realice una clase publica en la que almacene el orden y valores que tendra cada estudiante dentro dela lista.
//Ingrese una condicional para que si algun estudiante no tiene notas envie un error ya que no se puede ralizar un promedio cuando no se tienen valores.
public class Program
{
    public static void Main()
    {
        var registro = new RegistroNotas();

        registro.AddStudent("Carlos", new List<double> { 85, 90, 78, 92, 88, 76, 85, 95, 89, 67 });
        registro.AddStudent("Maria", new List<double> { 92, 88, 95, 85, 91, 80, 87, 93, 89, 90 });
        registro.AddStudent("Juan", new List<double> { 70, 65, 75, 80, 72, 68, 79, 74, 71, 78 });
        registro.AddStudent("Pedro", new List<double> { 60, 55, 65, 70, 62, 58, 69, 64, 61, 68 });
        registro.AddStudent("Ana", new List<double> { 99, 98, 97, 96, 95, 94, 93, 92, 91, 90 });

        try
        {
            double averageCarlos = registro.CalculateAverage("Carlos");
            Console.WriteLine($"El promedio de Carlos es: {averageCarlos}");

            double averageMaria = registro.CalculateAverage("Maria");
            Console.WriteLine($"El promedio de Maria es: {averageMaria}");

            double averageJuan = registro.CalculateAverage("Juan");
            Console.WriteLine($"El promedio de Juan es: {averageJuan}");

            double averagePedro = registro.CalculateAverage("Pedro");
            Console.WriteLine($"El promedio de Pedro es: {averagePedro}");

            double averageAna = registro.CalculateAverage("Ana");
            Console.WriteLine($"El promedio de Ana es: {averageAna}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al calcular el promedio: {ex.Message}");
        }
    }
}
//dentro de esta clase publica se encuentran los valores que se encuentran en la lista, y la realización de los promedios de cada uno de los estudiantes.
// A su vez las excepciones, que verifican que existan valores dentro de la lista para la relaización de las excepciones