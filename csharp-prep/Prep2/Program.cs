using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        int grade;
        string letter;
        string userInput;

        Console.Write("\nPlease enter your grade. ");
        userInput = Console.ReadLine();
        grade = int.Parse(userInput);

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";;
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("You passed!!\n");
        }
        else 
        {
            Console.WriteLine("You didn't pass, better luck next time.");
        }
    }
}