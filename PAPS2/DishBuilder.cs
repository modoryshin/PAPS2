using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPS2
{
    abstract class DishBuilder
    {
        public Dish Dish { get; set; }
        public void CreateDish()
        {
            Dish = new Dish();
        }
        public abstract void SetIngredients();
        public abstract void SetSpices();
    }
}
