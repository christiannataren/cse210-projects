using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

class Order
{
    private Customer _customer;
    private List<Product> _products;


    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }


    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }
        if (_customer.LivesInUsa())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }

    public String GetPackingLabel()
    {
        String label = $"****Packing Label****\n";
        foreach (Product p in _products)
        {
            label += $"{p.GetLabel()}\n";
        }
        label += $"Total Cost: {GetTotalCost():F2}";
        return label;
    }

    public String GetShippingLabel()
    {
        return $"****Shipping Label****\n{_customer.GetInfo()}";

    }
}