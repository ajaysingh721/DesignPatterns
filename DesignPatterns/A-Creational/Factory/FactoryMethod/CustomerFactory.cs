namespace DesignPatterns.Creational.Factory.FactoryMethod;

public abstract class CustomerFactory
{
    public ICustomer GetCustomer()
    {
        ICustomer customer = this.CreateCustomer();
        customer.AddDiscount();
        customer.AddPoints();

        return customer;
    }

    public abstract ICustomer CreateCustomer();
}