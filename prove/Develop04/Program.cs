using System;

class Program
{
    static void Main(string[] args)
    {
        BaseActivity breathingActivity = new BreathingActivity();
        BaseActivity reflectionActivity = new ReflectionActivity();
        BaseActivity listingActivity = new ListingActivity();

        while (true)
        {
            Console.WriteLine("Select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    breathingActivity.StartActivity();
                    breathingActivity.PerformActivity();
                    break;
                case 2:
                    reflectionActivity.StartActivity();
                    reflectionActivity.PerformActivity();
                    break;
                case 3:
                    listingActivity.StartActivity();
                    listingActivity.PerformActivity();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select again.");
                    break;
            }
        }
    }
}