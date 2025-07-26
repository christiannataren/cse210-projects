class Address
{
    private String _street;
    private String _city;
    private String _state;
    private String _country;


    public Address(String street, String city, String state, String country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;




    }


    public Boolean IsUsa()
    {
        return _country == "USA";
    }
    public String GetFullAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }

}