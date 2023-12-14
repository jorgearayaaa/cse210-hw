using System;

class OutdoorGathering : Event
{
    private string WeatherForecast { get; }

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        WeatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"Full Details (Outdoor Gathering):\n{base.GetFullDetails()}\nWeather Forecast: {WeatherForecast}";
    }
}