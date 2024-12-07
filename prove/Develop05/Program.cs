public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                "4" => null,
                _ => throw new InvalidOperationException("Invalid choice")
            };

            if (activity == null)
            {
                Activity.DisplayActivityLog();
                break;
            }

            activity.PerformActivity();

            //I included interactive demos for each activity,
            //allowing users to experience the activities firsthand. 
            //This was implemented in the PerformActivity method of each activity class.
        }
    }
}
