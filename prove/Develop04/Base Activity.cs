using System;
public class BaseActivity
{
    private string _activityName;
    private string _description;
    protected int _durationInSeconds;

    public BaseActivity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Starting {_activityName} activity...");
        Console.WriteLine(_description);
        Console.WriteLine("Please set the duration of the activity in seconds: ");
        _durationInSeconds = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000);
    }

    public virtual void PerformActivity(){}

    public void EndActivity()
    {
        Console.WriteLine($"You did a great job with the {_activityName} activity!");
        Console.WriteLine($"You have completed the {_activityName} activity in {_durationInSeconds} seconds.");
        Thread.Sleep(3000);
    }
}