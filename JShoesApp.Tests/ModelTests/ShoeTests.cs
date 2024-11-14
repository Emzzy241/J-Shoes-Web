// using Moq;
using Xunit;
using JShoesApp.Models;
using System.Threading.Tasks;

namespace JShoesAppTests.ModelTests;
public class ShoeTests
{
    [Fact]
    public void IsAvailable_ShouldReturnTrue_WhenStockIsGreaterThanZero()
    {
        // Arrange
        Shoe shoe = new Shoe("Nike Air max 123", Brand.Nike, Color.Red,  10.67M, PriceRange.TwentyDollarsOrLess, 10);

        // Act
        bool isAvailable = shoe.IsAvailable();

        // Assert
        Assert.True(isAvailable, "Shoe should be available when stock is greater than zero");
    }

    [Fact]
    public void IsAvailable_ShouldReturnFalse_WhenStockIsZero()
    {
        // Arrange
        Shoe shoe = new Shoe("Louis Vuitton 975", Brand.LouisVuitton, Color.White,  99.99M, PriceRange.HundredDollarsOrLess, 1);
        shoe.Stock--; // simulate purchase reducing stock to 0

        // Act
        bool isAvailable = shoe.IsAvailable();

        // Assert
        Assert.False(isAvailable, "Shoe should not be available when stock is zero");
    }

    [Fact]
    public void ApplyDiscount_ShouldReturnNewPrice_WhenDiscountIsApplied()
    {
        // Arrange
        Shoe shoe = new Shoe("Louis Vuitton 975", Brand.LouisVuitton, Color.White,  100.00M, PriceRange.HundredDollarsOrLess, 0);

        // Act
        decimal newPrice = shoe.ApplyDiscount(shoe.Price, 0);
        decimal newPrice2 = shoe.ApplyDiscount(shoe.Price, 5);
        decimal newPrice3 = shoe.ApplyDiscount(shoe.Price, 10);
        decimal newPrice4 = shoe.ApplyDiscount(shoe.Price, 20);
        decimal newPrice5 = shoe.ApplyDiscount(shoe.Price, 50);

        // Assert
        Assert.Equal(100.00M, newPrice);
        Assert.Equal(95.00M, newPrice2);
        Assert.Equal(90.00M, newPrice3);
        Assert.Equal(80.00M, newPrice4);
        Assert.Equal(50.00M, newPrice5);
    }

}