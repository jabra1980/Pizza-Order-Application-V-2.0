using Fast_Food_Builder._Ibuilder;
using Fast_Food_Builder._Observer;

namespace Fast_Food_Builder._Sandwich
{
    public class MeatSandwichBuilder : ISandwichBuilder
    {
        Sandwich sandwich;
        public List<WaitersObs> waitersObs = new List<WaitersObs>();

        public MeatSandwichBuilder()
        {
            sandwich = new Sandwich();
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
            sandwich.SetDescription("Featuring our Maplewood Smoked Bacon and Deli-Style Ham, made with Canadian farm-raised pork, \nall covered in Canadian Cheddar Cheese, with Smoky Honey Mustard and mayonnaise.");
        }
        public void BuildBread()
        {
            sandwich.SetBread("ITALIAN");
        }

        public void BuildCheese()
        {
            sandwich.SetCheese("Cheddar Cheese");
        }

        public void BuildSandwichName()
        {
            sandwich.SetSandwichName("Maplewood Smoked Bacon & Ham");
        }

        public void BuildProtein()
        {
            sandwich.SetProtein("Smoked Bacon, Deli-Style Ham");
        }

        public void BuildSauce()
        {
            sandwich.SetSauce("Smoky Honey Mustard, mayonnaise");
        }

        public void BuildSize()
        {
            sandwich.SetSizeInch(12);
        }

        public void BuildVegetable()
        {
            sandwich.SetVegetable("Cucumbers, Black olives, Lettuce, Green peppers, Tomatoes");
        }

        public Sandwich GetSandwich()
        {
            return sandwich;
        }
    }
}
