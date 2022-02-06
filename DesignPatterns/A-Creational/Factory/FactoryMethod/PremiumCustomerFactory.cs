namespace DesignPatterns.Creational.Factory.FactoryMethod;

public class PremiumCustomerFactory : CustomerFactory
{
    public override ICustomer CreateCustomer()
    {
        PremiumCustomer customre = new PremiumCustomer();
        customre.PremiumOperations();
        return customre;
    }
}