using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userInput = -1;
        int sum = 0;
        float average;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (userInput != 0)
        {  
            Console.Write("Enter Number: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        }

        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine($"The sum is: {sum}");

        average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = -1;

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        Console.WriteLine($"The largest number is: {max}");
    }
}