using JShoesApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JShoesApp.Models;

public class Order
{
    public Guid Id { get; set; }

    public Status Status { get; set; }

    public List<Shoe> ShoeList = new List<Shoe> (){};

    public DateTime Date { get; set; } = DateTime.Now;

    public decimal TotalPrice{
        get => ShoeList.Sum(shoe => shoe.Price);
        set {}
    }


}