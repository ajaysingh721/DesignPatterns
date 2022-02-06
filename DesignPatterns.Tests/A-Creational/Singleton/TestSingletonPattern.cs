using Xunit;
using FluentAssertions;
using DesignPatterns.Creational.Singleton;
using System.Threading.Tasks;

namespace DesignPatterns.Tests.Creational.Factory.SimpleFactory;

public class TestSingletonPatttern
{
    [Fact]

    public void Test_Logger_With_Multiple_Object_Creation_Returns_Single_Instance()
    {
        // Arrange
        var systemUnderTest1 = Logger.GetInstance;
        var systemUnderTest2 = Logger.GetInstance;

        // Act

        var result1 = systemUnderTest1.LogError("GetInstance Information");
        var result2 = systemUnderTest1.LogError("GetInstance Exception");

        // Assert
        result1.Should().Be(1);
        result2.Should().Be(1);
    }

    [Fact]
    public void Test_Logger_With_Parallel_Object_Creation_Allways_Returns_Single_Instance()
    {
        var systemUnderTest1 = () =>
        {
            // Arrrange
            var logger = Logger.GetInstance;

            // Act
            var count = logger.LogError("Parallel GetInstance Information");

            // Assert
            count.Should().Be(1);
        };

        var systemUnderTest2 = () =>
        {
            // Arrrange
            var logger = Logger.GetInstance;

            // Act
            var count = logger.LogError("Parallel GetInstance Information");

            // Assert
            count.Should().Be(1);
        };


        // Test
        Parallel.Invoke(() => systemUnderTest1(), () => systemUnderTest2());
    }
}