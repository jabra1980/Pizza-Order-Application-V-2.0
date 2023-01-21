using Fast_Food_Builder._Observer;

namespace Fast_Food_Builder._State
{
    public class AskCustomer : OrderState
    {
        private static AskCustomer askCustomer = new AskCustomer();

        private AskCustomer() { }

        public static AskCustomer Instance()
        {

            return askCustomer;
        }

        public override void RegisterOrder(CustomerObs customerObs)
        {
            customerObs.SetOrderState(CheckMenu.Instance());
            Console.WriteLine("Checking the Menu...!");
        }
    }
}
