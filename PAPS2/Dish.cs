using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPS2
{
    class Dish
    {
        public Ingredients Ingredients { get; set; }
        public Spices Spices { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Ingredients != null)
            {
                sb.Append("Ингридиенты: ");
                foreach (string obj in Ingredients.ingredientsList)
                {
                    sb.Append(obj + ", ");
                }
            }
            sb.Remove(sb.Length - 2, 2);
            sb.Append("\n");
            if (Spices!=null)
            {
                sb.Append("Приправы: ");
                foreach(string obj in Spices.spicesList)
                {
                    sb.Append(obj + ", ");
                }
            }
            sb.Remove(sb.Length - 2, 2);
            return sb.ToString();
        }
    }
}
