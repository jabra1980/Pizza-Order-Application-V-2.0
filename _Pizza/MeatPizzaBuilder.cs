using Fast_Food_Builder._Observer;
using Fast_Food_Builder._Ibuilder;

namespace Fast_Food_Builder._Pizza
{
    public class MeatPizzaBuilder : IPizzaBuilder
    {
        Pizza pizza;

        public List<WaitersObs> waitersObs = new List<WaitersObs>();

        public MeatPizzaBuilder()
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
            pizza.SetDescription("A Ranch Sauce base with a Mozzarella_Cheddar Cheese blend,\nfresh tomatoes, green peppers, all white-meat chicken and bacon.");
        }
        public void BuildBread()
        {
            pizza.SetBread("Thin and crispy");
        }
        
        public void BuildCheese()
        {
            pizza.SetCheese("Cheddar - Medium");
        }

        public void BuildPizzaName()
        {
            pizza.SetPizzaName("Chicken Bacon Ranch Pizza");
        }

        public void BuildProtein()
        {
            pizza.SetProtein("Bacon and Chicken");
        }

        public void BuildSauce()
        {
            pizza.SetSauce("Ranch Dressing - Extra");
        }

        public void BuildSize()
        {
            pizza.SetSizeInch(12);
        }

        public void BuildVegetable()
        {
            pizza.SetVegetable("Green Pepper and Tomatoes");
        }

        public Pizza GetPizza()
        {
            return pizza;
        }
    }
}
