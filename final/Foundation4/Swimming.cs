using System;

class Swimming : Activity
{
    private int Laps { get; }

    public Swimming(DateTime date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() != 0 ? (GetDistance() / LengthInMinutes) * 60 : 0;
    }

    public override double GetPace()
    {
        return GetDistance() != 0 ? LengthInMinutes / GetDistance() : 0;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Swimming ({LengthInMinutes} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}