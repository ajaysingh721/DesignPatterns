using DesignPatterns.Structural.Facade;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Structural.Facade;
class TestFacadepatter
{
    [Fact]
    public void TestFacade_To_Hide_Complexcity()
    {
        // Given
        var moneyManager = new MoneyManager();
        // When
        var result = moneyManager.BuyStock("amazon", 1000);

        // Then
        result.Should().Be(true);

    }
}