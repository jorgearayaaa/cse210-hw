using System;
public class BreathingActivity : BaseActivity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."){}

    public override void PerformActivity()
    {
        base.PerformActivity();

        Console.WriteLine("Starting breathing exercise...");

        for (int i = 0; i < _durationInSeconds; i++)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(2000);

            Console.WriteLine("Breathe out...");
            Thread.Sleep(2000);
        }

        EndActivity();
    }
}