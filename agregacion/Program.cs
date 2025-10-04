using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Program1();
        Program2();
        Program3();
        Program4();
    }

    static void Program1()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        int sum = numbers.Aggregate
        ((currentSum, nextNumber) => currentSum + nextNumber);
        
        Console.WriteLine($"Program 1 Result: {sum}");
        // El resultado es 15
    }

    static void Program2()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        int sum = numbers.Aggregate
        (10, (currentSum, nextNumber) => currentSum + nextNumber);
        Console.WriteLine($"Program 2 Result: {sum}");
        // El resultado es 25 (10 + 1 + 2 + 3 + 4 + 5)
    }

    static void Program3()
    {
        List<string> words = new List<string> { "hello", "world" };
        string result = words.Aggregate("START",
        (currentString, nextWord) => currentString + " " + nextWord, finalString => finalString);
        Console.WriteLine($"Program 3 Result: {result}");
        // El resultado es "START HELLO WORLD"
    }

    static void Program4()
    {
        List<string> fruits = new List<string>{ "manzana", "mango", "naranja", "granada", "uva" };
        string longestName =fruits.Aggregate
        ("banano", (longest, next) => next.Length > longest.Length ? next : longest, fruit => fruit);

        Console.WriteLine($"Program 4 Result: {longestName}");
    }
}