using Fast_Food_Builder._Abstruct_Factories;
using Fast_Food_Builder._Observer;

namespace Fast_Food_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            
            AbstructFoodFactory.stateOrder();

            AbstructFoodFactory factoryMeatPizza = AbstructFoodFactory.GetFood(FoodType.Meat);
            factoryMeatPizza.createPizza();
            
            Console.Write("+-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-+\n");

            AbstructFoodFactory factoryVeggiePizza = AbstructFoodFactory.GetFood(FoodType.Veggie);
            factoryVeggiePizza.createPizza();

            Console.Write("+-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-+\n");

            AbstructFoodFactory factoryMeatSandwich = AbstructFoodFactory.GetFood(FoodType.Meat);
            factoryMeatSandwich.createSandwich();

            Console.Write("+-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-+\n");

            AbstructFoodFactory factoryVeggieSandwich = AbstructFoodFactory.GetFood(FoodType.Veggie);
            factoryVeggiePizza.createSandwich();

            Console.Write("+-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-+\n");

            AbstructBeverageFactory coldDrindFactory = AbstructBeverageFactory.GetBeverage(DrinkType.Cold_Drink);
            coldDrindFactory.CreateBeverage();

            Console.Write("+-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-+\n");

            AbstructBeverageFactory hotDrindFactory = AbstructBeverageFactory.GetBeverage(DrinkType.Hot_Drink);
            hotDrindFactory.CreateBeverage();

            Console.Write("+-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-+\n");

            AbstructSideDishFactory coldSideDishFactory = AbstructSideDishFactory.GetSideDish(SideDishType.Cold_SideDish);
            coldSideDishFactory.CreateSideDish();

            Console.Write("+-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-++-+\n");

            AbstructSideDishFactory hotSideDishFactory = AbstructSideDishFactory.GetSideDish(SideDishType.Hot_SideDish);
            hotSideDishFactory.CreateSideDish();

        }
    }
}
