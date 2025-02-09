using System;

public class Product
{
    public string Name { get; private set; }
    public int ProductId { get; private set; }
    public double Price { get; private set; }
    public int Quantity { get; private set; }

    public Product(string name, int productId, double price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public double GetTotalCost()
    {
        return Price * Quantity;
    }

    public string GetDisplayText()
    {
        return $"{Name} (ID: {ProductId}) - ${Price} x {Quantity}";
    }
}
