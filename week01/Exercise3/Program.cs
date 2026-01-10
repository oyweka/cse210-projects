using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;

        do
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);


            int guessedNumber = -1;
            int attempt = 0;

            while (guessedNumber != number)
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                guessedNumber = int.Parse(guess);

                attempt++;

                if (guessedNumber < number)
                {
                    Console.WriteLine("Higher");
                }

                else if (guessedNumber > number)
                {
                    Console.WriteLine("Lower");
                }
            }

            Console.WriteLine("You guessed it");
            Console.WriteLine($"Your total number of guesses was {attempt}.");

            Console.Write("Do you want to continue playing (yes or no)? ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");
        Console.WriteLine("Goodbye!");
    }

}