using Xunit;
using JShoesApp.Models;

namespace JShoesAppTests.ModelTests;
public class AddressTests
{
    [Fact]
    public void GetCountry_GetsCountryNameInAnAddress_String()
    {
        // Arrange
        string expectedCountryName = "Canada";
        Address newAddress = new Address("Canada");

        // Act
        string actualCountryName = newAddress.CountryName;

        // Assert
        Assert.Equal(expectedCountryName, actualCountryName);
    }

    [Fact]
    public void SetCountry_SetsCountryNameInAnAddress_Void()
    {
        // Arrange
        string expectedCountryName = "Mexico";
        Address newAddress = new Address("Canada");

        // Act
        newAddress.CountryName = "Mexico";

        // Assert
        Assert.Equal(expectedCountryName, newAddress.CountryName);
    }
}