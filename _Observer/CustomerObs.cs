using Fast_Food_Builder._Pizza;
using Fast_Food_Builder._Sandwich;
using Fast_Food_Builder._SideDish;
using Fast_Food_Builder._Beverage;
using Fast_Food_Builder._State;
using System.Threading.Tasks;
using Fast_Food_Builder._Abstruct_Factories;

namespace Fast_Food_Builder._Observer
{
    
    public class CustomerObs : WaitersObs
    {
        OrderState orderCurrent;
        

        private int OrderNo;

        public CustomerObs()
        {
            this.orderCurrent = AskCustomer.Instance();
        }

        public void SetOrderState(OrderState value)
        {
            this.orderCurrent = value;
        }

        public void RegisterOrder()
        {
            this.orderCurrent.RegisterOrder(this);
        }

        public CustomerObs(MeatPizzaBuilder mpb)
        {
            MeatPizzaBuilder = mpb;
            MeatPizzaBuilder.readyOrder(this);
        }

        public CustomerObs(MeatSandwichBuilder msb)
        {
            MeatSandwichBuilder = msb;
            MeatSandwichBuilder.readyOrder(this);
        }

        public CustomerObs(VeggiePizzaBuilder vpb)
        {
            VeggiePizzaBuilder = vpb;
            VeggiePizzaBuilder.readyOrder(this);
        }

        public CustomerObs(ViggieSandwichBuilder vsb)
        {
            ViggieSandwichBuilder = vsb;
            ViggieSandwichBuilder.readyOrder(this);
        }
        
        public CustomerObs(SideDish sd)
        {
            sideDish = sd;
            sideDish.readyOrder(this);
        }

        public CustomerObs(Beverage bg)
        {
            beverage = bg;
            beverage.readyOrder(this);
        }
        
        
        public void SetOrderNo(int value)
        {
            this.OrderNo = value;
            Console.WriteLine("Order No." + OrderNo + "\nready to collect please proceed to counter No.6\n");
            
        }

        public override void Update()
        {
            
            Console.WriteLine("Order Information\n");
        }
    }
}
