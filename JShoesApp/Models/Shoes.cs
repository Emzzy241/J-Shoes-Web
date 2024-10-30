
namespace JShoesApp.Models;
public class Shoe
{
    public string ShoeName { get; set; }
    public enum Brand
    {
        Nike = 200,
        Balenciaga = 200,
        Jordan = 300
    }

    public enum Color
    {
        White = 52,
        Black = 37,
        Green = 19        
    }

    // public enum Size
    // {

    // }

    public decimal ShoePrice { get; set; }
    
    
    
    public Shoe(string shoeName, decimal shoePrice)
    {
        ShoeName = shoeName;
        // Brand = brand;

        ShoePrice =shoePrice;
    }

    


}