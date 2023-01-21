using Fast_Food_Builder._SideDish;
using Fast_Food_Builder._Observer;


namespace Fast_Food_Builder._Abstruct_Factories
{
    public class HotSideDishFactory : AbstructSideDishFactory
    {
        
        public override void CreateSideDish()
        {
            Console.Write("Cold SideDish...\n");

            SideDish sideDish = new SideDish(SideDishKind.Poutine);
            
            sideDish.Notify();
            sideDish.GetSideDhishs();
            sideDish.Display();
            sideDish.Description();
        }
    }
}
