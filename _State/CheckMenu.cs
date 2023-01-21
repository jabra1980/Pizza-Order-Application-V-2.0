using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fast_Food_Builder._Observer;

namespace Fast_Food_Builder._State
{
    public class CheckMenu : OrderState
    {
        private static CheckMenu checkMenu = new CheckMenu();

        private CheckMenu() { }

        public static CheckMenu Instance()
        {
            
            return checkMenu;
        }

        public override void RegisterOrder(CustomerObs customerObs)
        {
            customerObs.SetOrderState(TakeOrder.Instance());
            Console.WriteLine("Taking the Order...!");
        }
    }
}
