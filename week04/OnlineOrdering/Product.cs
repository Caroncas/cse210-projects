public class Product
{
    //Attributes:
    private string _productName;
    private string _productId;
    private double _price;
    private int _quantity;
    //Methods:
    public double CostOfProduct()
    {
        double cost = _price * _quantity;
        return cost;
    }
    public string DisplayProductLine()
    {
        string productLine = _productName + " - " + _productId;
        return productLine;
    }
    //Constructors:
    public Product(string name, string id, double price, int amount)
    {
        _productName = name;
        _productId = id;
        _price = price;
        _quantity = amount;
    }
}