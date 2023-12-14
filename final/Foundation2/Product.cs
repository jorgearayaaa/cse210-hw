using System;

class Product
{
    public string Name { get; }
    public string ProductId { get; }
    private double PricePerUnit { get; }
    private int Quantity { get; }

    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        Name = name;
        ProductId = productId;
        PricePerUnit = pricePerUnit;
        Quantity = quantity;
    }

    public double CalculateTotalCost()
    {
        return PricePerUnit * Quantity;
    }
}