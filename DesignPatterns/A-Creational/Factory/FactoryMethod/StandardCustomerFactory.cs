namespace DesignPatterns.Creational.Factory.FactoryMethod;

public class StandardCustomerFactory : CustomerFactory
{
    public override ICustomer CreateCustomer()
    {
        StanderCustomer customre = new StanderCustomer();
        customre.StandardOperations();
        return customre;
    }
}
