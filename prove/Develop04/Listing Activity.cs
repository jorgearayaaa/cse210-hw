using System;
public class ListingActivity : BaseActivity
{
    private string[] listingPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void PerformActivity()
    {
        base.PerformActivity();

        Console.WriteLine("Starting listing exercise...");
        Random random = new Random();

        Console.WriteLine(listingPrompts[random.Next(listingPrompts.Length)]);
        Console.WriteLine("Get ready to start listing...");
        Thread.Sleep(5000);

        Console.WriteLine("List as many items as you can...");

        int itemCount = random.Next(5, 15);
        Thread.Sleep(itemCount * 1000);

        Console.WriteLine($"You listed {itemCount} items.");

        EndActivity();
    }
}