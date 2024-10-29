using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment1.GetSummary(), "\n");

        Console.WriteLine();
        Math assignment2 = new Math("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList(), "\n");

        Console.WriteLine();
        Writing assignment3 = new Writing("Mary Waters", "European History", "The Cause of World War II");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation(), "\n");
        Console.WriteLine();
    }
}