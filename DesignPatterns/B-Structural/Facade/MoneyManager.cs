namespace DesignPatterns.Structural.Facade
{
    public class MoneyManager
    {
        public bool BuyStock(string name, decimal amount)
        {
            var stock = new Stock();
            var mapper = new Mapper();
            var stockId = mapper.GetStockId(name);
            var money = new Money(MoneyType.Dollar, 100);
            return stock.Invest(stockId, money);
        }

        public void BuyGold(GoldType goldType, decimal amount)
        {


        }

        public void BuyGovBond(string name, decimal amount)
        {


        }
    }
}