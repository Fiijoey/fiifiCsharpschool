using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Enter your name: ");
        string Username = Console.ReadLine();
        return Username;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Enter your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }

    static int SquareNumber(int Number)
    {
        int Squared = Number * Number;
        return Squared;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }


}