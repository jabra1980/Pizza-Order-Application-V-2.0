using Fast_Food_Builder._Sandwich;

namespace Fast_Food_Builder._Ibuilder
{
    public interface ISandwichBuilder
    {
        public void BuildDescription();
        public void BuildBread();
        public void BuildSize();
        public void BuildSauce();
        public void BuildCheese();
        public void BuildProtein();
        public void BuildVegetable();
        public void BuildSandwichName();


        public Sandwich GetSandwich();
    }
}
