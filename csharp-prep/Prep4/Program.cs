using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;
        int sum = 0;
        int max = int.MinValue;
        int min = int.MaxValue;
        List<int> set = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number :");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                set.Add(number);
            }
        }
        while (number != 0);

        foreach (int num in set)
        {
            sum += num;
        }

        double average = (double)sum / set.Count;

        foreach (int numb in set)
        {
            if (numb > max)
            {
                max = numb;
            }
        }

        foreach (int item in set)
        {
            if (item < 0 && item < min)
            {
                min = item;
            }
        }

        Console.WriteLine($"Tge sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest postive number is: {min}");
        set.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int digit in set)
        {
            Console.WriteLine(digit);
        }
    }
}