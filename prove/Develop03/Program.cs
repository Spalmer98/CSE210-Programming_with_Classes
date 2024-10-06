using System;

class Program
{
    static void Main(string[] args)
    {
        string run = "null";
        Reference r1 = new Reference("Proverbs", 3, 5, 6);
        var scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture s1 = new Scripture(r1, scriptureText);
        Random random = new Random();

        do
        {
            // Cear console
            Console.Clear();

            
            if (run.ToLower() != "quit")
                s1.GetDisplayText();
                Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");

            run = Console.ReadLine();

            s1.HideRandomWords(random);

            if (s1.AllWordsHidden)
                {
                    break;
                }

        } while (run.ToLower() != "quit");

    }
}