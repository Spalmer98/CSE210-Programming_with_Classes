using System;

class Program
{
    static void Main(string[] args)
    {
        Journal newJournal = new Journal();
        int _userChoice = 0;

        Console.WriteLine("\nWelcome to the Journal Program!");

        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            _userChoice = int.Parse(Console.ReadLine());

            if (_userChoice == 1)
            {
                Entry newEntry = new Entry();
                newJournal.AddEntry(newEntry);
            }
            else if (_userChoice == 2)
            {
                newJournal.DisplayAll();
            }
            else if (_userChoice == 3)
            {

            }
            else if (_userChoice == 4)
            {

            }
            else if (_userChoice == 5)
            {
                Console.WriteLine("Have a wonderful day!");
            }
            else
            {
                Console.WriteLine("You did not enter in a correct option, Please try again.");
            }

        } while (_userChoice != 5);
    }
}