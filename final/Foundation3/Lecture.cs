using System;

class Lecture : Event
{
    private string Speaker { get; }
    private int Capacity { get; }

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"Full Details:\n{base.GetFullDetails()}\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}