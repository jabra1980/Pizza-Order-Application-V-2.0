using Fast_Food_Builder._Ibuilder;

namespace Fast_Food_Builder._Sandwich
{
    public class SandwichChief
    {
        ISandwichBuilder iSandwichBuilder;

        public SandwichChief(ISandwichBuilder iSandwichBuilder)
        {
            this.iSandwichBuilder = iSandwichBuilder;
        }

        public void ConstructPizza()
        {
            iSandwichBuilder.BuildDescription();
            iSandwichBuilder.BuildSandwichName();
            iSandwichBuilder.BuildBread();
            iSandwichBuilder.BuildSize();
            iSandwichBuilder.BuildSauce();
            iSandwichBuilder.BuildCheese();
            iSandwichBuilder.BuildProtein();
            iSandwichBuilder.BuildVegetable();
        }

        public Sandwich FinalSandwich()
        {
            return iSandwichBuilder.GetSandwich();
        }
    }
}
