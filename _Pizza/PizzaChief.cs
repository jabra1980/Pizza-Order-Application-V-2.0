using Fast_Food_Builder._Ibuilder;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Food_Builder._Pizza
{
    public class PizzaChief
    {
        IPizzaBuilder iPizzaBuilder;

        public PizzaChief(IPizzaBuilder iPizzaBuilder)
        {
            this.iPizzaBuilder = iPizzaBuilder;
        }

        public void ConstructPizza()
        {
            iPizzaBuilder.BuildDescription();
            iPizzaBuilder.BuildPizzaName();
            iPizzaBuilder.BuildBread();
            iPizzaBuilder.BuildSize();
            iPizzaBuilder.BuildSauce();
            iPizzaBuilder.BuildCheese();
            iPizzaBuilder.BuildProtein();
            iPizzaBuilder.BuildVegetable();
        }

        public Pizza FinalPizza()
        {
            return iPizzaBuilder.GetPizza();
        }
    }
}
