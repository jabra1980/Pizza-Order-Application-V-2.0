using Fast_Food_Builder._Beverage;
using Fast_Food_Builder._Pizza;
using Fast_Food_Builder._Sandwich;
using Fast_Food_Builder._SideDish;
using Fast_Food_Builder._State;

namespace Fast_Food_Builder._Observer
{
    public abstract class WaitersObs
    {
        
        public MeatPizzaBuilder? MeatPizzaBuilder;
        public VeggiePizzaBuilder? VeggiePizzaBuilder;
        public MeatSandwichBuilder? MeatSandwichBuilder;
        public ViggieSandwichBuilder? ViggieSandwichBuilder;
        public SideDish? sideDish;
        public Beverage? beverage;

       
        public abstract void Update();
    }
}
