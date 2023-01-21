using Fast_Food_Builder._Observer;

namespace Fast_Food_Builder._State
{
    public class TakeOrder : OrderState
    {
        private static TakeOrder takeOrder = new TakeOrder();

        private TakeOrder() { }

        public static TakeOrder Instance()
        {
            return takeOrder;
        }

        public override void RegisterOrder(CustomerObs customerObs)
        {
            customerObs.SetOrderState(UnderProcessOrder.Instance());
            Console.WriteLine("Under Processing the Order...!");
        }
    }
}
