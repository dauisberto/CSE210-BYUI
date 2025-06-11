public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool GetUSAConfirmation()
    {
        bool usaConfirmation;
        if (_address.GetUSACountry())
        {
            usaConfirmation = true;

        }
        else
        {
            usaConfirmation = false;
        }

        return usaConfirmation;
    }

    public string GetUserAddress()
    {
        string userAddress;
        userAddress = _address.GetAddressText();
        return userAddress;
    }
    
}