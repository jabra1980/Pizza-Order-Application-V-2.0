using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fast_Food_Builder._Observer;

namespace Fast_Food_Builder._State
{
    public class UnderProcessOrder : OrderState
    {
        private static UnderProcessOrder underProcessOrder = new UnderProcessOrder();
        
        Random orderNo = new Random();
        CustomerObs c1 = new CustomerObs();

        private UnderProcessOrder() { }

        public static UnderProcessOrder Instance()
        {
            return underProcessOrder;
        }
        public override void RegisterOrder(CustomerObs customerObs)
        {
            Console.WriteLine("Thanks visiting us\n");
            c1.SetOrderNo(orderNo.Next(1, 100));
            Console.WriteLine("Please press 0 to get your order\n");
        }
    }
}
