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
        Address newAddress = new Address("Canada", "Alberta");

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
        Address newAddress = new Address("Canada", "Alberta");

        // Act
        newAddress.CountryName = "Mexico";

        // Assert
        Assert.Equal(expectedCountryName, newAddress.CountryName);
    }

    [Fact]
    public void GetStateName_GetsStateNameInAnAddress_String()
    {
        // Arrange
        string expectedStateName = "Michigan";
        Address newAddress = new Address("United States Of America", "Michigan");

        // Act
        string actualStateName = newAddress.StateName;

        // Assert
        Assert.Equal(expectedStateName, actualStateName);
    }

    [Fact]
    public void SetStateName_SetsStateNameInAddress_Void()
    {
        // Arrange
        string expectedStateName = "Washington DC";
        Address newAddress = new Address("United States Of America", "Michigan");
        
        // Act
        newAddress.StateName = "Washington DC";

        // Assert
        Assert.Equal(expectedStateName, newAddress.StateName);
    }
}