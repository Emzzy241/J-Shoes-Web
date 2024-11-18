using JShoesApp.Models;

namespace JShoesApp.Functions;

public abstract class Discount
{
    
    public static decimal ApplyDiscount(decimal oldPrice, int discount)
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