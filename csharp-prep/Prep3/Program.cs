using System;

class Program
{
    static void Main(string[] args)
    {
        int randomNumber;
        int guess;
        string userInput;
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            /*Console.Write("\nWhat is your magic number? ");
            userInput = Console.ReadLine();
            randomNumber = int.Parse(userInput);*/

            Random randomGenerator = new Random();
            randomNumber = randomGenerator.Next(1, 100);

            do
            {
                

                Console.Write("\nWhat is your guess? ");
                userInput = Console.ReadLine();
                guess = int.Parse(userInput);

                if (guess < randomNumber)
                {
                    Console.WriteLine("\nHigher\n");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("\nLower\n");
                }
            } while (guess != randomNumber);

            Console.WriteLine("\nYou guessed it!\n");
            Console.Write("Would you like to play again? ");
            playAgain = Console.ReadLine();
        }
    }
}