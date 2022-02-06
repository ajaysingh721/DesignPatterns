namespace DesignPatterns.Creational.Factory.AbstructFactory
{
    public class StandardPackage : PackageFactory
    {
        public override Food CreateFoodPackage(MealOption mealOption)
        {
            throw new NotImplementedException();
        }

        public override Room CreateRoom(BedType bedType, ViewType viewType)
        {
            throw new NotImplementedException();
        }
    }
}