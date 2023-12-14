using System;

class Cycling : Activity
{
    private double Speed { get; }

    public Cycling(DateTime date, int lengthInMinutes, double speed)
        : base(date, lengthInMinutes)
    {
        Speed = speed;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return Speed != 0 ? 60 / Speed : 0;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Cycling ({LengthInMinutes} min) - Speed: {Speed} mph, Pace: {GetPace()} min per mile";
    }
}