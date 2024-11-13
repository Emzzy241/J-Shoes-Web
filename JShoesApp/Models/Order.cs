using  System.Globalization;

namespace JShoesApp.Models;

public enum Status
{
    NotYetCompleted,
    Pending, 
    Completed,
    Cancelled    
}
public class Order
{
    public Status Status { get; set; }
    public decimal TotalPrice { get; set; }
    public DateOnly Date { get; set; }


    public Order(Status status, decimal totalPrice, DateOnly date)
    {
        Status = status;
        TotalPrice = totalPrice;
        Date = date;
    }
}