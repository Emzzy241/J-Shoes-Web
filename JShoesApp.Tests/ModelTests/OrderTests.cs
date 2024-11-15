using Xunit;
using JShoesApp.Models;
using System;
using System.Collections.Generic;


namespace JShoesAppTests.ModelTests;
public class OrderTests
{
    [Fact]
    public void TotalPrice_ValidatingTotalAmountOfShoes_WhenUserPlaceAnOrder()
    {
        // Arrange
        Shoe shoe = new Shoe("Louis Vuitton 975", Brand.LouisVuitton, Color.Black,  100.00M, PriceRange.HundredDollarsOrLess, 10);
        Shoe shoe2 = new Shoe("Air max 150", Brand.Nike, Color.Red,  49.99M, PriceRange.FiftyDollarsOrLess, 40);
        Shoe shoe3 = new Shoe("Balenciaga Y9", Brand.Balenciaga, Color.White,  135.00M, PriceRange.MoreThanHundredDollars, 60);
        Shoe shoe4 = new Shoe("Balenciaga Y9", Brand.Balenciaga, Color.White,  125.00M, PriceRange.MoreThanHundredDollars, 60);
        decimal expectedTotal = 409.99m;

        // Act
        Order.ShoeList.Add(shoe);
        Order.ShoeList.Add(shoe2);
        Order.ShoeList.Add(shoe3);
        Order.ShoeList.Add(shoe4);

        decimal actualTotal = Order.TotalPrice(Order.ShoeList);

        // Assert
        Assert.Equal(expectedTotal, actualTotal);
    }

}