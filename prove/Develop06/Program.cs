using System;

public class Program
{
    public static void Main()
    {
        GoalManager goalManager = new GoalManager();

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Create Simple Goal");
            Console.WriteLine("2. Create Eternal Goal");
            Console.WriteLine("3. Create Checklist Goal");
            Console.WriteLine("4. Complete Goal");
            Console.WriteLine("5. Display Score");
            Console.WriteLine("6. Display Goals");
            Console.WriteLine("7. Save Goals");
            Console.WriteLine("8. Load Goals");
            Console.WriteLine("9. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter goal name: ");
                    string simpleName = Console.ReadLine();
                    Console.Write("Enter goal description: ");
                    string simpleDescription = Console.ReadLine();
                    Console.Write("Enter goal points: ");
                    int simplePoints = int.Parse(Console.ReadLine());
                    goalManager.CreateGoal(new SimpleGoal(simpleName, simpleDescription, simplePoints));
                    break;
                case "2":
                    Console.Write("Enter goal name: ");
                    string eternalName = Console.ReadLine();
                    Console.Write("Enter goal description: ");
                    string eternalDescription = Console.ReadLine();
                    Console.Write("Enter goal points: ");
                    int eternalPoints = int.Parse(Console.ReadLine());
                    goalManager.CreateGoal(new EternalGoal(eternalName, eternalDescription, eternalPoints));
                    break;
                case "3":
                    Console.Write("Enter goal name: ");
                    string checklistName = Console.ReadLine();
                    Console.Write("Enter goal description: ");
                    string checklistDescription = Console.ReadLine();
                    Console.Write("Enter goal points: ");
                    int checklistPoints = int.Parse(Console.ReadLine());
                    Console.Write("Enter target to complete: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Enter bonus points: ");
                    int bonus = int.Parse(Console.ReadLine());
                    goalManager.CreateGoal(new ChecklistGoal(checklistName, checklistDescription, checklistPoints, target, bonus));
                    break;
                case "4":
                    Console.Write("Enter goal name to complete: ");
                    string goalName = Console.ReadLine();
                    goalManager.MarkGoalCompleted(goalName);
                    break;
                case "5":
                    goalManager.DisplayScore();
                    break;
                case "6":
                    goalManager.DisplayDetails();
                    break;
                case "7":
                    Console.Write("Enter filename to save: ");
                    string saveFilename = Console.ReadLine();
                    goalManager.SaveGoalList(saveFilename);
                    break;
                case "8":
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine();
                    goalManager.LoadGoalList(loadFilename);
                    break;
                case "9":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
