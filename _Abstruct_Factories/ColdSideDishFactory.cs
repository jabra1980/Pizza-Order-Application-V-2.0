using Fast_Food_Builder._SideDish;
using Fast_Food_Builder._Observer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Food_Builder._Abstruct_Factories
{
    public class ColdSideDishFactory : AbstructSideDishFactory
    {
        
        public override void CreateSideDish()
        {
            Console.WriteLine("Cold SideDish...");
            SideDish sideDish = new SideDish(SideDishKind.Salad);
            
            sideDish.Notify();
            sideDish.GetSideDhishs();
            sideDish.Display();
            sideDish.Description();
        }

    }
}
