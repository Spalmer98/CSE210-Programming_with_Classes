using System;

class Program
{
    static void Main(string[] args)
    {
        int run = 0;

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Start breathing activity");
            Console.WriteLine("    2. Start reflection activity");
            Console.WriteLine("    3. Start listening activity");
            Console.WriteLine("    4.Quit");
            Console.Write("Select a choice from the menu: ");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {

            }
            else if (option == 2)
            {

            }
            else if (option == 3)
            {

            }
            else if (option == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("You did not enter a valid option.");
            }

        }
        while (run != 4);
    }
}