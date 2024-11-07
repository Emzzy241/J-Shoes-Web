using JShoesApp.Models;

namespace JShoesApp.Models;
public class Address
{
    public string CountryName { get; set; }
    public string StateName { get; set; }
    public string CityName { get; set; }
    
    
    

    public Address(string countryName, string stateName, string cityName)
    {
        CountryName = countryName;
        StateName = stateName;
        CityName = cityName;
    }
    
}