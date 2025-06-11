using System.Diagnostics.Contracts;

public class Order
{
    private List<Product> _products;
    Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        double shippingCost = 0;

        foreach (Product p in _products)
        {
            totalCost += p.GetProductCost();
        }

        if (_customer.GetUSAConfirmation())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        totalCost = totalCost + shippingCost;

        return totalCost;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void GetPackingLabel()
    {

        foreach (Product p in _products)
        {
            Console.WriteLine($"{p.GetPacking()}");
        }

    }

    public void GetShippingLabel()
    {
        foreach (Product p in _products)
        {
            Console.WriteLine($"{p.GetShipping()} - {_customer.GetUserAddress()}");
        }
    }
    
}