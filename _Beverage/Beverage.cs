using Fast_Food_Builder._Observer;

namespace Fast_Food_Builder._Beverage
{
    public class Beverage : Beverages
    {
        DrinkKind drinkKind;
        public List<WaitersObs> waitersObs = new List<WaitersObs>();


        public Beverage(DrinkKind drinkKind)
        {
            this.drinkKind = drinkKind;
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

        public override string GetDrinks()
        {
            return this.drinkKind.ToString();
        }
        public override void Display()
        {
            Console.WriteLine("Drink Name: " + GetDrinks());
        }

        public void Description()
        {
            Console.WriteLine("\nDescription");
            Console.WriteLine($"Enjoy your favorite meal with {GetDrinks()}.");
        }
    }
}
