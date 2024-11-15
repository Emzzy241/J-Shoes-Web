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
    public static List<Shoe> ShoeList = new List<Shoe> (){};
    public DateOnly Date { get; set; }


    public Order(Status status, DateOnly date)
    {
        Status = status;
        Date = date;
    }


    public static decimal TotalPrice(List<Shoe> shoes)
    {
        if(shoes == null || shoes.Count == 0)
        {
            return 0m; 
        }

        return shoes.Sum(shoe => shoe.Price);
    }

  
}