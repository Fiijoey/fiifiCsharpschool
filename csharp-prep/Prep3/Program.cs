using System;

class Program
{
    static void Main(string[] args)
    {
        Random randNumbers = new Random();
        int magicNumber = randNumbers.Next(1, 100);
        int guessNumber = 0;

        do
        {
            Console.Write("What is your guess?: ");
            guessNumber = int.Parse(Console.ReadLine());

            if (magicNumber == guessNumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
        }
        while (magicNumber != guessNumber);
    }
}