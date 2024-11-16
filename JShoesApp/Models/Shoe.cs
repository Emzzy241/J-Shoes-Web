using JShoesApp.Enums;

namespace JShoesApp.Models;

public class Shoe
{
    public string Name { get; set; }

    public Brand Brand { get; set; }

    public Color Color { get; set; }

    private decimal _price;

    // Using a property setter that enforces 2 decimal places
    public decimal Price { 
        get => _price; 
        set => _price = Math.Round(value, 2);

    }

    public PriceRange PriceRange { get; set; }
    
    public int Stock { get; set; }

    public decimal Discount { get; set; }
    
    public Shoe(string name, Brand brand, Color color, decimal price, PriceRange range, int stock)
    {
        Name = name;
        Brand = brand;
        Color = color;
        Price = price;
        PriceRange = range;
        Stock = stock;
    }

    public bool IsAvailable()
    {
        if(Stock > 0)
            return true;

        return false;
    }

    public decimal ApplyDiscount(decimal oldPrice, int discount)
    {
        decimal newPrice = 0.00M;
        switch (discount)
        {
           
            case 5:
                newPrice = oldPrice - (oldPrice * 0.05M);
                break;
            case 10:
                newPrice = oldPrice - (oldPrice * 0.10M);
                break;
            case 20:
                newPrice = oldPrice - (oldPrice * 0.20M);
                break;
            case 50:
                newPrice = oldPrice - (oldPrice * 0.50M);
                break;
            default:
                return newPrice;
        }
        return newPrice;
    } 


}