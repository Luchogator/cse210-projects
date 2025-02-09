using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    public Customer Customer { get; private set; }

    public Order(Customer customer)
    {
        Customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }
        return total + (Customer.IsInUSA() ? 5 : 35);
    }

    public string GetShippingLabel()
    {
        return $"Shipping to: \n{Customer.Name}\n{Customer.Address.GetAddress()}";
    }

    public string GetPackingLabel()
    {
        string packingList = "Packing List:\n";
        foreach (var product in _products)
        {
            packingList += $"- {product.GetDisplayText()}\n";
        }
        return packingList;
    }
}
