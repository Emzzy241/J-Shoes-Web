using Xunit;
using JShoesApp.Models;

namespace JShoesAppTests.ModelTests;
public class AddressTests
{
    [Fact]
    public void GetCountry_ReturnsCountryNameInAnAddress_String()
    {
        // Arrange
        string expectedCountryName = "Canada";
        Address newAddress = new Address("Canada", "Alberta", "Toronto");

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
        Address newAddress = new Address("Canada", "Alberta", "Toronto");

        // Act
        newAddress.CountryName = "Mexico";

        // Assert
        Assert.Equal(expectedCountryName, newAddress.CountryName);
    }

    [Fact]
    public void GetStateName_ReturnsStateNameInAnAddress_String()
    {
        // Arrange
        string expectedStateName = "Michigan";
        Address newAddress = new Address("United States Of America", "Michigan", "Manhattan");

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
        Address newAddress = new Address("United States Of America", "Michigan", "Manhattan");
        
        // Act
        newAddress.StateName = "Washington DC";

        // Assert
        Assert.Equal(expectedStateName, newAddress.StateName);
    }

    [Fact]
    public void GetCityName_ReturnsCityNameInAnAddress_String()
    {
        // Arrange
        string expectedCityName = "Brooklyn";
        Address newAddress = new Address("United States Of America", "New York", "Brooklyn");

        // Act
        string actualCityName = "Brooklyn";

        // Assert
        Assert.Equal(expectedCityName, actualCityName);
    }

    [Fact]
    public void SetCityName_SetsCityNameInAddress_Void()
    {
        // Arrange
        Address newAddress = new Address("United States Of America", "New York", "Brooklyn");
        string expectedCityName = "New York City";
        
        // Act
        newAddress.CityName = "New York City";

        // Assert
        Assert.Equal(expectedCityName, newAddress.CityName);
    }
}