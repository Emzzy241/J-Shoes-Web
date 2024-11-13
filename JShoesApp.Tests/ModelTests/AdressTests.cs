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
        Address newAddress = new Address("Canada", "Alberta", "Toronto", "439281", "Albuquerque New Mexico");

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
        Address newAddress = new Address("Canada", "Alberta", "Toronto", "439281", "Albuquerque New Mexico");

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
        Address newAddress = new Address("United States Of America", "Michigan", "Manhattan", "439281", "Albuquerque New Mexico");

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
        Address newAddress = new Address("United States Of America", "Michigan", "Manhattan", "439281", "Albuquerque New Mexico");
        
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
        Address newAddress = new Address("United States Of America", "New York", "Brooklyn", "439281", "Albuquerque New Mexico");

        // Act
        string actualCityName = "Brooklyn";

        // Assert
        Assert.Equal(expectedCityName, actualCityName);
    }

    [Fact]
    public void SetCityName_SetsCityNameInAddress_Void()
    {
        // Arrange
        Address newAddress = new Address("United States Of America", "New York", "Brooklyn", "439281", "Albuquerque New Mexico");
        string expectedCityName = "New York City";
        
        // Act
        newAddress.CityName = "New York City";

        // Assert
        Assert.Equal(expectedCityName, newAddress.CityName);
    }

    [Fact]
    public void GetPostalCode_GetsPostalCodeOfCity_String()
    {
        // Arrange
        Address newAddress = new Address("United States", "New York", "Brooklyn", "112119", "Albuquerque New Mexico");
        string expectedPostalCode = "112119";

        // Act
        string actualPostalCode = newAddress.PostalCode;

        // Assert
        Assert.Equal(expectedPostalCode, actualPostalCode);
    }

    [Fact]
    public void SetPostalCode_SetsPostalCodeOfACity_Void()
    {
        // Arrange
        Address newAddress = new Address("United States of America", "New York", "Brooklyn", "455630", "Albuquerque New Mexico");
        string expectedPostalCode = "211090";

        // Act
        newAddress.PostalCode = "211090";

        // Assert
        Assert.Equal(expectedPostalCode, newAddress.PostalCode);
    }

    [Fact]
    public void GetStreetAddress_GetsTheStreetNameOfAnAddress_String()
    {
        // Arrange
        Address newAddress = new Address("Canada", "Alberta", "Saskatchewan", "112119", "Alberta Avenue sesame street");
        string expectedStreetAddress = "Alberta Avenue sesame street";


        // Act
        string actualStreetAddress = newAddress.StreetAddress;

        // Assert
        Assert.Equal(expectedStreetAddress, actualStreetAddress);
    }

    [Fact]
    public void SetStreetAddress_SetsTheStreetNameOfAnAddress_Void()
    {
        // Arrange
        Address newAddress = new Address("Canada", "Ontario", "Toronto", "198234", "Alberta valley 1234 New Road Avenue");
        string expectedStreetAddress = "Albuquerque New Mexico, California";

        // Act
        newAddress.StreetAddress = "Albuquerque New Mexico, California";

        // Assert
        Assert.Equal(expectedStreetAddress, newAddress.StreetAddress);
    }


}