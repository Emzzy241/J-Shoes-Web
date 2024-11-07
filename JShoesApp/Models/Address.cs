using JShoesApp.Models;

namespace JShoesApp.Models;
public class Address
{
    public string CountryName { get; set; }
    // prop 

    public Address(string countryName)
    {
        CountryName = countryName;
    }
    
}