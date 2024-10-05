using System;

class Program
{
    static void Main(string[] args)
    {
        string run = "null";
        do
        {
            // Cear console
            Console.Clear();

            Reference r1 = new Reference("Proverbs", 3, 5, 6);
            Scripture s1 = new Scripture(r1, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");

            if (run.ToLower() != "quit")
                Console.WriteLine(s1.GetDisplayText());
                Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");

            run = Console.ReadLine();

        } while (run.ToLower() != "quit");

    }
}