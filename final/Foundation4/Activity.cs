using System;

class Activity
{
    private DateTime Date { get; }
    public int LengthInMinutes { get; }

    public Activity(DateTime date, int lengthInMinutes)
    {
        Date = date;
        LengthInMinutes = lengthInMinutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{Date.ToShortDateString()} - Activity";
    }
}