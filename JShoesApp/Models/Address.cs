using JShoesApp.Models;

namespace JShoesApp.Models;
public class Address
{
    public Guid? Id { get; set; }
    
    public string? CountryName { get; set; }
    
    public string? StateName { get; set; }
    
    public string? CityName { get; set; }
    
    public string? PostalCode { get; set; }
    
    public string? StreetAddress { get; set; }

}