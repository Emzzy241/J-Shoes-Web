
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

public enum PriceRange
{
    TwentyDollarsOrLess, // $0-$20
    FiftyDollarsOrLess, // $21-$50
    HundredDollarsOrLess, // $51-$100
    MoreThanHundredDollars // $100+
}


public class Shoe
{
    public string ShoeName { get; set; }

    public Brand Brand { get; set; }

    public Color Color { get; set; }

    public decimal ShoePrice { get; set; }

    public PriceRange PriceRange { get; set; }
    
    
    
    public Shoe(string shoeName, Brand brand, Color color, decimal shoePrice, PriceRange priceRange)
    {
        ShoeName = shoeName;
        Brand = brand;
        Color = color;
        ShoePrice = shoePrice;
        PriceRange = priceRange;
    }

    


}