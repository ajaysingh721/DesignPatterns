namespace DesignPatterns.Creational.Factory.AbstructFactory;

public abstract class PackageFactory
{
    public abstract Room CreateRoom(BedType bedType, ViewType viewType);
    public abstract Food CreateFoodPackage(MealOption mealOption);

    public static PackageFactory CreatePackage(PackageType packageType)
    {
        switch (packageType)
        {
            case PackageType.Premium:
                return new PremiumPackage();
            case PackageType.Standard:
                return new StandardPackage();
            default:
                throw new NotSupportedException($"{packageType} is not a supported package");
        }

    }
}



public class StandardPackageFactoty
{



}
