using JShoesApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JShoesApp.Models;

public class Order
{
    public Status Status { get; set; }

    public List<Shoe> ShoeList = new List<Shoe> (){};

    public DateTime Date { get; set; } = DateTime.Now;

    public Order(Status status, DateTime date)
    {
        Status = status;
        Date = date;
    }

    public decimal TotalPrice(List<Shoe> shoes)
    {
        if(shoes == null || shoes.Count == 0)
        {
            return 0m; 
        }

        return shoes.Sum(shoe => shoe.Price);
    }

}