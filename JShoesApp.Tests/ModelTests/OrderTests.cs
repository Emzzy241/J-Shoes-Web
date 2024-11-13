using Xunit;
using JShoesApp.Models;

namespace JShoesAppTests.ModelTests;
public class OrderTests
{
    [Fact]
    public void OrderStatus_CreatingOrderWithValidStatus_Enum()
    {
        // Arrange
        var order = new Order(Status.Pending);

        // Assert
        Assert.Equal(Status.Pending, order.Status);
    }

    [Fact]
    public void GetTotalPrice_GetsTotalPriceForOrder_Decimal()
    {
        // Arrange
        Order order = new Order(Status.Completed, 450.99M);
        decimal expectedTotalPrice = 450.999M;
        
        // Act
        decimal actualTotalPrice = order.TotalPrice;

        // Assert
        Assert.Equal(expectedTotalPrice, actualTotalPrice);
    }


}