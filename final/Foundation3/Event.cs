using System;

class Event
{
    private string Title { get; }
    private string Description { get; }
    private DateTime Date { get; }
    private TimeSpan Time { get; }
    private Address EventAddress { get; }

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        EventAddress = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Standard Details:\nTitle: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {EventAddress.GetFullAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return $"Full Details:\n{GetStandardDetails()}";
    }

    public virtual string GetShortDescription()
    {
        return $"Short Description:\nType: {GetType().Name}\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
    }
}