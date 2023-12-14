using System;


class Order
{
    private List<Product> Products { get; }
    private Customer Customer { get; }

    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var product in Products)
        {
            totalCost += product.CalculateTotalCost();
        }

        if (Customer.IsInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in Products)
        {
            label += $"{product.Name} - ID: {product.ProductId}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "Shipping Label:\n";
        label += $"Customer: {Customer.GetAddress().GetFullAddress()}\n";
        return label;
    }
}