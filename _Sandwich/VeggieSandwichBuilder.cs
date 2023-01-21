using Fast_Food_Builder._Ibuilder;
using Fast_Food_Builder._Observer;

namespace Fast_Food_Builder._Sandwich
{
    public class ViggieSandwichBuilder : ISandwichBuilder
    {
        Sandwich sandwich;
        public List<WaitersObs> waitersObs = new List<WaitersObs>();

        public ViggieSandwichBuilder()
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
            sandwich.SetDescription("Crispy, crunchy. The Veggie Delite is proof that a veggie sandwich can be high in flavour. \nTry a delicious combination of lettuce, tomatoes, green peppers, cucumbers and onions");
        }
        public void BuildBread()
        {
            sandwich.SetBread("Wheat bread");
        }

        public void BuildCheese()
        {
            sandwich.SetCheese("Not Apply");
        }

        public void BuildSandwichName()
        {
            sandwich.SetSandwichName("Veggie Delite");
        }

        public void BuildProtein()
        {
            sandwich.SetProtein("Not Apply");
        }

        public void BuildSauce()
        {
            sandwich.SetSauce("Mustard, Sweet Onion");
        }

        public void BuildSize()
        {
            sandwich.SetSizeInch(6);
        }

        public void BuildVegetable()
        {
            sandwich.SetVegetable("lettuce, tomatoes, green peppers, cucumbers and onions");
        }

        public Sandwich GetSandwich()
        {
            return sandwich;
        }
    }
}
