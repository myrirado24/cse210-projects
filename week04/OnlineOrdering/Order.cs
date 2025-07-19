using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double totalProductCost = 0;
        foreach (Product product in _products)
        {
            totalProductCost += product.GetTotalCost();
        }

        double shippingCost = _customer.LivesInUSA() ? 5.00 : 35.00;

        return totalProductCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder("Packing Label:\n");
        foreach (Product product in _products)
        {
            label.AppendLine($"Product: {product.GetName()} (ID: {product.GetProductId()})");
        }
        return label.ToString();
    }

    public string GetShippingLabel()
    {
        StringBuilder label = new StringBuilder("Shipping Label:\n");
        label.AppendLine($"Customer Name: {_customer.GetName()}");
        label.AppendLine($"Address:\n{_customer.GetAddress().GetFullAddress()}");
        return label.ToString();
    }
}