using Fast_Food_Builder._Ibuilder;
using Fast_Food_Builder._Observer;
using Fast_Food_Builder._Pizza;
using Fast_Food_Builder._Sandwich;

namespace Fast_Food_Builder._Abstruct_Factories
{
    public class VeggieFactory : AbstructFoodFactory
    {
        
        public override void createPizza()
        {
            
            Console.Write("Veggie Pizza...\n");

            VeggiePizzaBuilder veggiePizzaBuilder = new VeggiePizzaBuilder();
            IPizzaBuilder iVeggiePizzaBuilder = new VeggiePizzaBuilder();
            PizzaChief pizzaVeggieChief = new PizzaChief(iVeggiePizzaBuilder);
            
            veggiePizzaBuilder.Notify();
            pizzaVeggieChief.ConstructPizza();
            pizzaVeggieChief.FinalPizza().Display();

            Console.Write("\n");
        }

        public override void createSandwich()
        {
            Console.Write("Veggie Sandwich...\n");

            ViggieSandwichBuilder viggieSandwichBuilder = new ViggieSandwichBuilder();
            ISandwichBuilder iViggiePizzaBuilder = new ViggieSandwichBuilder();
            SandwichChief sandwichViggieChief = new SandwichChief(iViggiePizzaBuilder);
            
            viggieSandwichBuilder.Notify();
            sandwichViggieChief.ConstructPizza();
            sandwichViggieChief.FinalSandwich().Display();

            Console.Write("\n");

        }
    }
}


