using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Food_Builder
{

    public enum FactoryType
    {
        Food,
        Beverage,
        Side_Dish
    }



    public enum FoodType
    {
        Meat,
        Veggie
    }

    public enum DrinkType
    {
        Cold_Drink,
        Hot_Drink
    }
    public enum DrinkKind
    {
        Coca_Cola,
        Water,
        Coffee,
        Espresso
    }

    public enum SideDishType
    {
        Cold_SideDish,
        Hot_SideDish
    }
    public enum SideDishKind
    {
        Salad,
        Poutine
    }
}
