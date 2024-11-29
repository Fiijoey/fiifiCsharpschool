public class Product
{
    private string _name;
    private string _productId;
    private int _quantity;
    private double _price;

    public Product(string name, string productId, int quantity, double price)
    {
        _name = name;
        _productId = productId;
        _quantity = quantity;
        _price = price;
    }

    public string GetProductName()
    {
        return _name;
    }

    public string GetProductID()
    {
        return _productId;
    }

    public double GetTotalCost()
    {
        return _quantity * _price;
    }
}
