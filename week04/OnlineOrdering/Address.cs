public class Address
{
    //Attributes:
    private string _streetLine;
    private string _city;
    private string _stateProvince;
    private string _country;
    //Methods:
    public bool IsUsa()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string PrintAddress()
    {
        string address = _streetLine + "\n" + _city + ", " + _stateProvince + "\n" + _country;
        return address;
    }
    //Constructors:
    public Address(string street, string city, string stateProvince, string country)
    {
        _streetLine = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }
}