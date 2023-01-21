using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Food_Builder._Abstruct_Factories
{
    public abstract class AbstructBeverageFactory
    {
        private static ColdBeverageFactory coldBeverageFactory = new ColdBeverageFactory();
        private static HotBeverageFactory hotdBeverageFactory = new HotBeverageFactory();

        public static AbstructBeverageFactory GetBeverage(DrinkType drinkType)
        {
            AbstructBeverageFactory? factory = null;

            switch (drinkType)
            {
                case DrinkType.Cold_Drink:
                    factory = coldBeverageFactory;
                    break;
                case DrinkType.Hot_Drink:
                    factory= hotdBeverageFactory;
                    break;
            }

            return factory;


        }




        public abstract void CreateBeverage();
    }
}
