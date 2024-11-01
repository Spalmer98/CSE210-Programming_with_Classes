using System;

class Program
{
    static void Run()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("    1. Start breathing activity");
        Console.WriteLine("    2. Start reflection activity");
        Console.WriteLine("    3. Start listening activity");
        Console.WriteLine("    4. Quit");
        Console.Write("Select a choice from the menu: ");
        int option = int.Parse(Console.ReadLine());

        if (option == 1)
        {
            Console.Clear();
            Breathing b1 = new Breathing("Breating Activity", "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.");
            b1.DisplayStartingMessage();
            b1.Run();
            Run();
        }
        else if (option == 2)
        {
            Console.Clear();
            Reflection r1 = new Reflection("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            r1.DisplayStartingMessage();
            r1.Run();
            Run();
        }
        else if (option == 3)
        {
            Console.Clear();
            Listening l1 = new Listening("Lisening Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            l1.DisplayStartingMessage();
            l1.Run();
            Run();
        }
        else if (option == 4)
        {
            
        }
        else
        {
            Console.WriteLine("You did not enter a valid option.");
            Thread.Sleep(2000);
            Run();
        }
    }
    static void Main(string[] args)
    {
        Run();

    }
}