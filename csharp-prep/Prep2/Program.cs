using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your grade percentage? : ");
        int grades = int.Parse(Console.ReadLine());

        if (grades < 60)
        {
            Console.WriteLine("You scored F");
        }
        else if (grades >= 60)
        {
            Console.WriteLine("You scored D");
        }
        else if (grades >= 70)
        {
            Console.WriteLine("You scored C");
        }
        else if (grades >= 80)
        {
            Console.WriteLine("You scored B");
        }
        else
        {
            Console.WriteLine("You scored A");
        }


        if (grades < 70)
        {
            Console.WriteLine("Unfortunately, you failed to pass. You can do better next time. ");
        }
        else
        {
            Console.WriteLine("Congratulations. You have passed.");
        }
    }
}