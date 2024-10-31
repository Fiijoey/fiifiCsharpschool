using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your first name? : ");
        string fname = Console.ReadLine();
        Console.Write("What is your last name? : ");
        string lname = Console.ReadLine();

        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");
    }
}