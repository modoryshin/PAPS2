using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPS2
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            DishBuilder db = new RussianDishBuilder();
            Dish dish = chef.Cook(db);
            Console.WriteLine(dish.ToString());
            db = new ItalianDishBuilder();
            dish = chef.Cook(db);
            Console.WriteLine(dish.ToString());
            Console.ReadKey();
        }
    }
}
