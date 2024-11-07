using JShoesApp.Models;

namespace JShoesApp.Models;
public class Address
{
    public string CountryName { get; set; }
    public string StateName { get; set; }
    
    

    public Address(string countryName, string stateName)
    {
        CountryName = countryName;
        StateName = stateName;
    }
    
}