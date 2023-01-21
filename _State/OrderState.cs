using Fast_Food_Builder._Observer;

namespace Fast_Food_Builder._State
{
    public abstract class OrderState
    {
        public abstract void RegisterOrder(CustomerObs customerObs);
    }
}
