using System.Reflection.Metadata.Ecma335;

public class Customer
{
    //Attributes:
    private string _name;
    private Address _address;
    //Methods:
    public bool IsUsa()
    {
        bool address = _address.IsUsa();
        if (address == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string DisplayCustomerLine()
    {
        string shippingLabel = _name + "\n" + _address.PrintAddress() + "\n";
        return shippingLabel;
    }
    //Constructors:
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
}