using System.Net.Sockets;

class Customer
{
    private String _name;
    private Address _address;

    public Customer(String name, Address address)
    {
        _name = name;
        _address = address;
    }



    public String GetInfo()
    {
        String info = $"Name: {_name}\n";
        info += _address.GetFullAddress();

        return info;
    }

    public Boolean LivesInUsa()
    {
        return _address.IsUsa();
    }
}