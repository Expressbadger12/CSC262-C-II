using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes
{
    public class DesertRecipe : Recipe, IServingSuggestion
    {
        private bool requiresBaking;

        public bool RequiresBaking { get; set; }

        //we have to override the absract display method from the base class in each subclass
        public override string Display()
        {
            return "Dessert name: " + RecipeName + " | Requires Baking " + RequiresBaking;
        }

        public string GetServingSuggestion()
        {
            return "This dessert should be eaten in 1 setting";
        }
    }
}
