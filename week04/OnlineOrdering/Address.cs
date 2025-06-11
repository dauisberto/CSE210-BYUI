public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;

    }

    public bool GetUSACountry()
    {
        bool isUSA;

        string countryChecker;
        countryChecker = _country.ToUpper();

        if (countryChecker == "UNITED STATES")
        {
            isUSA = true;
        }
        else
        {
            isUSA = false;
        }

        return isUSA;
    }

    public string GetAddressText()
    {
        string addressString;
        addressString = ($"Street: {_street} City: {_city} State/Province: {_state} Country: {_country}");
        return addressString;
    }
}