using JShoesApp.Enums;

namespace JShoesApp.Models;

public class Shoe
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }

    public Brand Brand { get; set; }

    public Color Color { get; set; }

    private decimal _price;

    // Using a property setter that enforces 2 decimal places
    public decimal Price { 
        get => _price; 
        set => _price = Math.Round(value, 2);
    }

    public decimal Discount { get; set; }
    
    public Shoe(string name, Brand brand, Color color, decimal price)
    {
        Name = name;
        Brand = brand;
        Color = color;
        Price = price;
    }

    


}