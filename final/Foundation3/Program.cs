using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("123 Main St", "Anytown", "CA", "USA");
        Address receptionAddress = new Address("456 Park Ave", "Sometown", "NY", "USA");
        Address outdoorGatheringAddress = new Address("894 Beach St", "Beachtown", "FL", "USA");

        Event lectureEvent = new Lecture("Tech Talk", "Latest Tech Trends", DateTime.Parse("2023-12-20"), TimeSpan.Parse("18:00"), lectureAddress, "Jorge Araya", 100);
        Event receptionEvent = new Reception("Networking Event", "Meet and Greet", DateTime.Parse("2023-12-25"), TimeSpan.Parse("19:00"), receptionAddress, "eventinfo@byu.com");
        Event outdoorGatheringEvent = new OutdoorGathering("Beach Party", "Fun in the Sun", DateTime.Parse("2023-12-30"), TimeSpan.Parse("12:00"), outdoorGatheringAddress, "Sunny");

        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine("\n---\n");
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine("\n---\n");
        Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine("\n---\n");
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine("\n---\n");
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine("\n---\n");
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine("\n---\n");
        Console.WriteLine(outdoorGatheringEvent.GetStandardDetails());
        Console.WriteLine("\n---\n");
        Console.WriteLine(outdoorGatheringEvent.GetFullDetails());
        Console.WriteLine("\n---\n");
        Console.WriteLine(outdoorGatheringEvent.GetShortDescription());
    }
}
