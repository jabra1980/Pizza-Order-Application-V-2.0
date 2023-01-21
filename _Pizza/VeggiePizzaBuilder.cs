using Fast_Food_Builder._Observer;
using Fast_Food_Builder._Ibuilder;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Food_Builder._Pizza
{
    public class VeggiePizzaBuilder : IPizzaBuilder
    {
        Pizza pizza;
        public List<WaitersObs> waitersObs = new List<WaitersObs>();

        public VeggiePizzaBuilder()
        {
            pizza = new Pizza();
        }

        public void readyOrder(WaitersObs wa)
        {
            waitersObs.Add(wa);
        }

        public void Notify()
        {
            foreach (WaitersObs o in waitersObs)
            {
                o.Update();
            }
        }



        public void BuildDescription()
        {
            pizza.SetDescription("Creamy Alfredo sauce, fresh baby spinach, fresh onions,\nfeta, Parmesan-Asiago, provolone and cheese made with 100% real mozzarella.");
        }
        public void BuildBread()
        {
            pizza.SetBread("hand-engineered crust");
        }

        public void BuildCheese()
        {
            pizza.SetCheese("Feta and Parmesan Asiago and Provolone");
        }

        public void BuildPizzaName()
        {
            pizza.SetPizzaName("Spinach and Feta Pizza");
        }

        public void BuildProtein()
        {
            pizza.SetProtein("Not Apply");
        }

        public void BuildSauce()
        {
            pizza.SetSauce("Alfredo Sauce");
        }

        public void BuildSize()
        {
            pizza.SetSizeInch(10);
        }

        public void BuildVegetable()
        {
            pizza.SetVegetable("Mushroom and Onion and Onion");
        }


        public Pizza GetPizza()
        {
            return pizza;
        }
    }
}
