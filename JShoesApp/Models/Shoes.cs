
namespace JShoesApp.Models;


public enum Brand
{
    Nike,
    Balenciaga,
    Jordan
}

public enum Color
{
    White,
    Black,
    Green       
}


public class Shoe
{
    public string ShoeName { get; set; }

    public Brand Brand { get; set; }

    public Color Color { get; set; }

    public decimal ShoePrice { get; set; }
    
    
    
    public Shoe(string shoeName, Brand brand, Color color, decimal shoePrice)
    {
        ShoeName = shoeName;
        Brand = brand;
        Color = color;
        ShoePrice = shoePrice;
    }

    


}