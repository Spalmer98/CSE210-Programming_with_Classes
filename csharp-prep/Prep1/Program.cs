using System;

class Program
{
    static void Main(string[] args)
    {
        //First Name
        Console.Write("\nWhat is your first Name? ");
        string firstName = Console.ReadLine();
        
        //Last Name
        Console.Write("What is your last Name? ");
        string lastName = Console.ReadLine();

        //Print out name
        Console.WriteLine($"\nYour name is {lastName}, {firstName} {lastName}.\n");
    }
}