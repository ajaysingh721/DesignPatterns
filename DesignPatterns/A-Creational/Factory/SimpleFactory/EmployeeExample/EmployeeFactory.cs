namespace DesignPatterns.Creational.Factory.SimpleFactory;

public class EmployeeFactory
{
    private BaseEmployee emp;

    public EmployeeFactory()
    {
        emp = new PermanentEmployee();
    }

    public BaseEmployee GetEmployee(EmployeeType employeeType)
    {
        switch (employeeType)
        {
            case EmployeeType.Contract:
                emp = new ContractEmployee();
                break;
            case EmployeeType.Permanent:
                emp = new PermanentEmployee();
                break;
        }
        return emp;
    }
}