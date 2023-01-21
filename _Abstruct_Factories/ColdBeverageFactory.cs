using Fast_Food_Builder._Beverage;
using Fast_Food_Builder._Observer;


namespace Fast_Food_Builder._Abstruct_Factories
{
    public class ColdBeverageFactory : AbstructBeverageFactory
    {
        
        public override void CreateBeverage()
        {
            Console.WriteLine("Cold Drink Order");
            Beverage beverage = new Beverage(DrinkKind.Coca_Cola);
            
            beverage.Notify();
            beverage.GetDrinks();
            beverage.Display();
            beverage.Description();
        }
        
    }
    
}
