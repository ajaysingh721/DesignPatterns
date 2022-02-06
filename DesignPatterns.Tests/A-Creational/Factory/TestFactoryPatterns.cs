using DesignPatterns.Creational.Factory;
using DesignPatterns.Creational.Factory.AbstructFactory;
using DesignPatterns.Creational.Factory.FactoryMethod;
using DesignPatterns.Creational.Factory.SimpleFactory;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Creational.Factory;


public class TestFactoryPattern
{
    [Fact]
    public void Test_SimpleFactoryPattern_Employee()
    {
        // Arrange
        var emp = new EmployeeFactory();
        // Act
        var cEmp = emp.GetEmployee(EmployeeType.Contract);
        // Assert
        cEmp.Should().BeOfType<ContractEmployee>();
    }


    [Fact]
    public void Test_SimpleFactoryPattern_Device()
    {
        // Arrange
        var device = new DeviceFactory(DeviceType.GoogleAssistant);
        // Act
        var gDevice = device.Create();
        // Assert
        gDevice.Should().BeOfType<GoogleAssistant>();
    }


    [Fact]
    public void Test_FactoryMathodPattern()
    {
        // Arrange
        var factory = new StandardCustomerFactory();
        // Act
        var customer = factory.GetCustomer();
        // Assert
        customer.Should().BeOfType<StanderCustomer>();
    }

    [Fact]
    public void Test_AbstructFactoryPattern()
    {
        // Arrange
        var factory = PackageFactory.CreatePackage(PackageType.Standard);

        // Act
        var room = factory.CreateRoom(BedType.KingSize, ViewType.MountanView);
        var food = factory.CreateFoodPackage(MealOption.FullDay);

        // Assert
        factory.Should().BeOfType<StandardCustomerFactory>();
    }


}