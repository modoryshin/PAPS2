using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPS2
{
    class ItalianDishBuilder:DishBuilder
    {
        public override void SetIngredients()
        {
            this.Dish.Ingredients = new Ingredients { ingredientsList = new List<string>() { "Помидоы", "Тесто", "Солями", "Перец" } };
        }
        public override void SetSpices()
        {
            this.Dish.Spices = new Spices { spicesList = new List<string>() { "Соль", "Перец", "Корица" } };
        }
    }
}
