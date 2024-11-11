// using Moq;
using Xunit;
using JShoesApp.Models;
using System.Threading.Tasks;

namespace JShoesAppTests.ModelTests;
public class ShoeTests
{
    [Fact]
    public void Shoe_CreatesInstanceOfShoe_Shoe()
    {
        Shoe newShoe = new Shoe("Jordan A460", Brand.Nike, Color.White, 150.99M);
        Assert.Equal(typeof(Shoe), newShoe.GetType());
    }

    [Fact]
    public void GetShoeName_GetNameOfShoe_String()
    {
        // Arrange
        string expectedShoeName = "Nike Air max 150";
        Shoe newShoe = new Shoe("Nike Air max 150", Brand.Nike, Color.White, 150.99M);

        // Act
        string actualShoeName = newShoe.ShoeName;

        // Assert
        Assert.Equal(expectedShoeName, actualShoeName);
    }

    [Fact]
    public void SetShoeName_SetNameOfShoe_Void()
    {
        // Arrange
        Shoe newShoe = new Shoe("Nike Air max 150", Brand.Nike, Color.White, 150.99M);
        string expectedShoeName = "Balenciaga A12";
        // Act
        newShoe.ShoeName = "Balenciaga A12";

        // Assert
        Assert.Equal(expectedShoeName, newShoe.ShoeName);
    }

    // Try testing just Brand and Color enums

    // Testing the enums in the Shoe class



    [Fact]
    public void GetShoePrice_GetPriceOfShoe_Decimal()
    {
        // Arrange
        decimal expectedShoePrice = 150.99M;
        Shoe newShoe = new Shoe("Nike Air max 150", Brand.Nike, Color.White, 150.99M);

        // Act
        decimal actualShoePrice = newShoe.ShoePrice;

        // Assert
        Assert.Equal(expectedShoePrice, actualShoePrice);
    }

    [Fact]
    public void SetShoePrice_SetPriceOfShoe_Void()
    {
        // Arrange
        decimal expectedShoePrice = 125.22M;
        Shoe newShoe = new Shoe("Nike Air max 150", Brand.Nike, Color.White, 150.99M);

        //  Act
        newShoe.ShoePrice = 125.22M;

        // Assert
        Assert.Equal(expectedShoePrice, newShoe.ShoePrice);
    }



}