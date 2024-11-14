using System;
using System.Collections.Generic;
using System.Linq;

namespace JShoesApp.Models;

public enum Status
{
    NoOrder,
    Pending, 
    Shipped,
    Cancelled    
}
public class Order
{
    public Status Status { get; set; }
    private static List<Shoe> _shoeList = new List<Shoe> (){};
    // public decimal TotalPrice { get; set; }
    public DateOnly Date { get; set; }


    public Order(Status status, DateOnly date)
    {
        Status = status;
        Date = date;
    }

    public static List<Shoe> GetAll()
    {
        return _shoeList;
    }

    // public static decimal TotalPrice(List<Shoe> shoes)
    // {
    //     if(shoes == null || shoes.Count == 0)
    //     {
    //         return 0m; 
    //     }

    //     return shoes.Sum(shoe => shoe.Price);
    // }

    public static decimal TotalPrice(List<Shoe> shoes)
    {
        decimal TotalPrice = 0.00M;
        foreach (var shoe in shoes)
        {   
            TotalPrice += shoe.Price;
        }
        return TotalPrice;
    }
}