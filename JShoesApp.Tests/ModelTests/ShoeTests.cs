// using Moq;
using JShoesApp.Enums;
using JShoesApp.Models;
using Xunit;
using System.Threading.Tasks;

namespace JShoesAppTests.ModelTests;
public class ShoeTests
{

    [Fact]
    public void ApplyDiscount_ShouldReturnNewPrice_WhenDiscountIsApplied()
    {
        // Arrange
        Shoe shoe = new Shoe("Louis Vuitton 975", Brand.LouisVuitton, Color.White,  100.00M);

        // Act
        decimal newPrice2 = shoe.ApplyDiscount(shoe.Price, 5);
        decimal newPrice3 = shoe.ApplyDiscount(shoe.Price, 10);
        decimal newPrice4 = shoe.ApplyDiscount(shoe.Price, 20);
        decimal newPrice5 = shoe.ApplyDiscount(shoe.Price, 50);

        // Assert
        Assert.Equal(95.00M, newPrice2);
        Assert.Equal(90.00M, newPrice3);
        Assert.Equal(80.00M, newPrice4);
        Assert.Equal(50.00M, newPrice5);
    }

}