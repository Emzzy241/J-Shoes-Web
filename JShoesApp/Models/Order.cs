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

    public Order(Status status, decimal totalPrice)
    {
        Status = status;
        TotalPrice = totalPrice;
    }
}