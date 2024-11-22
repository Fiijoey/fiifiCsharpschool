using System;

public class Program
{
    public static void Main(string[] args)
    {
        ScriptureReference reference = new ScriptureReference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.DisplayText());
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Thank you for playing!");
                break;
            }
            else
            {
                scripture.HideRandomWords();

                if (scripture.CheckHiddenAmount())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.DisplayText());
                    Console.WriteLine("All words are hidden. Thank you for playing!");
                    break;
                }
            }
        }
    }
}
