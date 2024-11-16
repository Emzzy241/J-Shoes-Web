using JShoesApp.Models;
using JShoesApp.Enums;
using Xunit;
using System;
using System.Collections.Generic;


namespace JShoesAppTests.ModelTests;
public class OrderTests
{

    [Fact]
    public void TotalPrice_ValidatingTotalAmountOfShoes_WhenUserPlaceAnOrder()
    {
        // Arrange
        Shoe shoe = new Shoe("Louis Vuitton 975", Brand.LouisVuitton, Color.Black,  100.00M);
        Shoe shoe2 = new Shoe("Air max 150", Brand.Nike, Color.Red,  49.99M);
        Shoe shoe3 = new Shoe("Balenciaga Y9", Brand.Balenciaga, Color.White, 56.27M);
        Shoe shoe4 = new Shoe("Balenciaga Y9", Brand.Balenciaga, Color.White, 99.99M);
        decimal expectedTotal = 306.25M;

        Order newOrder = new Order(Status.Pending, DateTime.Now)

        // Act
        newOrder.ShoeList.Add(shoe);
        newOrder.ShoeList.Add(shoe2);
        newOrder.ShoeList.Add(shoe3);
        newOrder.ShoeList.Add(shoe4);
        decimal actualTotal = newOrder.TotalPrice(Order.ShoeList);

        // Assert
        Assert.Equal(expectedTotal, actualTotal);
    }

}