using System;

class Address
{
    private string Street { get; }
    private string City { get; }
    private string State { get; }
    private string Country { get; }

    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    public bool IsInUSA()
    {
        return Country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return $"{Street}, {City}, {State}, {Country}";
    }
}