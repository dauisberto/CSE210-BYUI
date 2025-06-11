public class Product
{
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string name, string productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public double GetProductCost()
    {
        double totalPrice = _price * _quantity;
        return totalPrice;
    }

    public string GetPacking()
    {
        string packingLabel;
        packingLabel = ($"{_name} - {_productID}");
        return packingLabel;
    }

    public string GetShipping()
    {
        string shippingLabel;
        shippingLabel = ($"{_name}");
        return shippingLabel;
    }
}