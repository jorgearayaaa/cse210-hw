using System;

class Running : Activity
{
    private double Distance { get; }

    public Running(DateTime date, int lengthInMinutes, double distance)
        : base(date, lengthInMinutes)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return Distance != 0 ? (Distance / LengthInMinutes) * 60 : 0;
    }

    public override double GetPace()
    {
        return Distance != 0 ? LengthInMinutes / Distance : 0;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Running ({LengthInMinutes} min) - Distance: {Distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}