using Xunit;
using JShoesApp.Models;

namespace JShoesAppTests.ModelTests;
public class OrderTests
{
    [Fact]
    public void OrderStatus_CreatingOrderWithValidStatus_Enum()
    {
        // Arrange
        var order = new Order(Status.Pending, 330.20M);

        // Assert
        Assert.Equal(Status.Pending, order.Status);
    }

    [Fact]
    public void GetTotalPrice_GetsTotalPriceForOrder_Decimal()
    {
        // Arrange
        Order order = new Order(Status.Completed, 450.99M);
        decimal expectedTotalPrice = 450.99M;
        
        // Act
        decimal actualTotalPrice = order.TotalPrice;

        // Assert
        Assert.Equal(expectedTotalPrice, actualTotalPrice);
    }
    
    [Fact]
    public void SetTotalPrice_SetsTotalPriceForOrder_Void()
    {
        // Arrange
        Order order = new Order(Status.NotYetCompleted, 220.43M);
        decimal expectedTotalPrice = 330.33M;

        // Act
        order.TotalPrice = 330.33M;

        // Assert
        Assert.Equal(expectedTotalPrice, order.TotalPrice);
    }


}