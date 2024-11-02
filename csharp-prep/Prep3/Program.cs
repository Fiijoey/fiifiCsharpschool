using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;
        while (playAgain)
        {

            Random randNumbers = new Random();
            int magicNumber = randNumbers.Next(1, 100);
            int guessNumber = 0;
            int guessCount = 0;

            do
            {
                Console.Write("What is your guess?: ");
                guessNumber = int.Parse(Console.ReadLine());
                guessCount++;

                if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
            }
            while (magicNumber != guessNumber);

            Console.WriteLine($"Congratulations! You guessed the number in {guessCount} guesses.");

            Console.WriteLine("Do you want to play again? (yes/no)");
            string response = Console.ReadLine().ToLower();
            playAgain = response == "yes";
        }

    }
}