using Fast_Food_Builder._Observer;

namespace Fast_Food_Builder._Abstruct_Factories
{
    public abstract class AbstructFoodFactory
    {
        private static MeatFactory meatFactory = new MeatFactory();
        private static VeggieFactory veggieFactory = new VeggieFactory();
        private static CustomerObs customerObs = new CustomerObs();


        public static AbstructFoodFactory GetFood(FoodType foodType)
        {
            AbstructFoodFactory? factory = null;

            switch (foodType)
            {
                case FoodType.Meat:
                    factory = meatFactory;
                    break;
                case FoodType.Veggie:
                    factory = veggieFactory;
                    break;
            }
            return factory;
        }

        public static void stateOrder()
        {
            Console.WriteLine("Here is the menu, Please Check?");

            while (true)
            {
                string? answer = Console.ReadLine();
                if (string.IsNullOrEmpty(answer))
                {
                    customerObs.RegisterOrder();
                }
                else
                {
                    break;
                }
            }

        }


        public abstract void createPizza();
        public abstract void createSandwich();
    }
}
