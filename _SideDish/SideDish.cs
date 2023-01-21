using Fast_Food_Builder._Observer;

namespace Fast_Food_Builder._SideDish
{
    public class SideDish : SideDishs
    {
        SideDishKind sideDishKind;

        public List<WaitersObs> waitersObs = new List<WaitersObs>();

        public SideDish(SideDishKind sideDishKind)
        {
            this.sideDishKind = sideDishKind;
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



        public override string GetSideDhishs()
        {
            return this.sideDishKind.ToString();
        }

        public override void Display()
        {
            Console.WriteLine("Side Dish Name: " + GetSideDhishs());
        }

        public void Description()
        {
            Console.WriteLine("\nDescription");
            Console.WriteLine($"Enjoy your favorite meal with {GetSideDhishs()}.");
        }
    }
}
