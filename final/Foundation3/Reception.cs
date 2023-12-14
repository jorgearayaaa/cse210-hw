using System;

class Reception : Event
{
    private string RsvpEmail { get; }

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        RsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"Full Details (Reception):\n{base.GetFullDetails()}\nRSVP Email: {RsvpEmail}";
    }
}