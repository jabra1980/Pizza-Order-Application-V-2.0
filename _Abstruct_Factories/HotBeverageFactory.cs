using Fast_Food_Builder._Beverage;
using Fast_Food_Builder._Observer;


namespace Fast_Food_Builder._Abstruct_Factories
{
    public class HotBeverageFactory : AbstructBeverageFactory
    {
        
        public override void CreateBeverage()
        {
            Console.WriteLine("Hot Drink Order");
            Beverage beverage = new Beverage(DrinkKind.Espresso);
            
            beverage.Notify();
            beverage.GetDrinks();
            beverage.Display();
            beverage.Description();
        }
    }
}
