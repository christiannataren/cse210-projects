class Product
{
    private int _productId;
    private String _productName;
    private double _price;
    private int _quantity;


    public Product(int productId, String productName, double price, int quantity)
    {
        _productId = productId;
        _productName = productName;
        _price = price;
        _quantity = quantity;
    }



    public double GetTotalCost()
    {
        return _quantity * _price;
    }

    public String GetLabel()
    {
        return $"{_productName}, Quantity: {_quantity}, ID: {_productId}";
    }
}