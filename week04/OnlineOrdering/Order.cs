public class Order
{
    //Attributes:
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    //Methods:
    public double CalculateCost()
    {
        double shippingCost;
        bool shippingCountry = _customer.IsUsa();
        if (shippingCountry == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.CostOfProduct();
        }
        total += shippingCost;
        return total;
    }
    public string ReturnPackingLabel()
    {
        //Packing label: Product name & ID (each product in order)
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += product.DisplayProductLine() + "\n";
        }
        return packingLabel;
    }
    public string ReturnShippingLabel()
    {
        //Shipping Label: Customer name & address
        string shippingLabel = _customer.DisplayCustomerLine();
        return shippingLabel;
    }
    public void SetProducts(Product item)
    {
        _products.Add(item);
    }
    //Constructors:
    public Order(Customer customer)
    {
        _customer = customer;
    }
}