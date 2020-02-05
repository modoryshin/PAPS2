using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPS2
{
    class Chef
    {
        public Dish Cook(DishBuilder DishBuilder)
        {
            DishBuilder.CreateDish();
            DishBuilder.SetIngredients();
            DishBuilder.SetSpices();
            return DishBuilder.Dish;
        }
    }
}
