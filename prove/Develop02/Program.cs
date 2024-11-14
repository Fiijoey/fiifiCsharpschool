using System;
using System.Collections.Generic;

public class Program
{
    private static List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "How did you serve others today?"
    };

    private static Journal journal = new Journal();

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    SaveJournal();
                    break;
                case "4":
                    LoadJournal();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private static void WriteNewEntry()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        journal.AddEntry(new Entry(prompt, response, date));
    }

    private static void SaveJournal()
    {
        Console.Write("Enter filename to save the journal: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
        Console.WriteLine("Journal saved.");
    }

    private static void LoadJournal()
    {
        Console.Write("Enter filename to load the journal: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
        Console.WriteLine("Journal loaded.");
    }
}
