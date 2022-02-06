namespace DesignPatterns.Creational.Factory.AbstructFactory
{
    public class PremiumPackage : PackageFactory
    {
        public override Food CreateFoodPackage(MealOption mealOption)
        {
            switch (mealOption)
            {
                case MealOption.Breakfast:
                    return new StandardBreakFast();
                default:
                    throw new NotSupportedException($"{mealOption} is not supported");
            }
        }

        public override Room CreateRoom(BedType bedType, ViewType viewType)
        {
            throw new NotImplementedException();
        }
    }
}