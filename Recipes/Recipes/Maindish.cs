using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Recipes
{
    public class Maindish : Recipe, IServingSuggestion
    {
        private bool isSpicy;

        public bool IsSpicy { get; set; }

        public override string Display()
        {
            return "Main Dish name: " + RecipeName + " | Spicy? " + IsSpicy;
        }

        //this implements the required method from the Iservingsuggestion intergface
        public string GetServingSuggestion()
        {
            return "This dish should be eaten with friends";
        }
    }
}
