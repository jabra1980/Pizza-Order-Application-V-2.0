using Fast_Food_Builder._Ibuilder;
using Fast_Food_Builder._Pizza;
using Fast_Food_Builder._Sandwich;

namespace Fast_Food_Builder._Abstruct_Factories
{
    public class MeatFactory : AbstructFoodFactory
    {

        public override void createPizza()
        {
            Console.Write("Meat Pizza ...\n");

            MeatPizzaBuilder meatPizzaBuilder = new MeatPizzaBuilder();
            IPizzaBuilder iMeatPizzaBuilder = new MeatPizzaBuilder();
            PizzaChief pizzaMeatChief = new PizzaChief(iMeatPizzaBuilder);

            meatPizzaBuilder.Notify();
            pizzaMeatChief.ConstructPizza();
            pizzaMeatChief.FinalPizza().Display();

            Console.Write("\n");

        }
        public override void createSandwich()
        {
            Console.Write("Meat Sandwich..\n");

            MeatSandwichBuilder meatSandwichBuilder = new MeatSandwichBuilder();
            ISandwichBuilder iMeatPizzaBuilder = new MeatSandwichBuilder();
            SandwichChief sandwichMeatChief = new SandwichChief(iMeatPizzaBuilder);

            meatSandwichBuilder.Notify();
            sandwichMeatChief.ConstructPizza();
            sandwichMeatChief.FinalSandwich().Display();

            Console.Write("\n");
        }
    }
}
