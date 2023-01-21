using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Food_Builder._Abstruct_Factories
{
    public abstract class AbstructSideDishFactory
    {
        private static ColdSideDishFactory coldSideDishFactory = new ColdSideDishFactory();
        private static HotSideDishFactory hotSideDishFactory = new HotSideDishFactory();

        public static AbstructSideDishFactory GetSideDish(SideDishType sideDishType)
        {
            AbstructSideDishFactory? factory = null;

            switch (sideDishType)
            {
                case SideDishType.Cold_SideDish:
                    factory = coldSideDishFactory;
                    break;
                case SideDishType.Hot_SideDish:
                    factory= hotSideDishFactory;
                    break;
            }
            return factory;
        }


        public abstract void CreateSideDish();
    }
}
