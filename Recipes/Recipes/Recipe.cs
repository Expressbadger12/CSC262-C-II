using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes
{
    public abstract class Recipe
    {
        //private attributes here

        //exammple 5 or 20
        private int prepTimeMinutes;
        //example pizza or pancakes
        private string recipeName;
        //example type of food (italian)
        private string catagory;
        //example flour salt
        private string ingredients;
        //example if no meat this would be true
        private bool isVegitarian;
        //example person's name
        private string submittedBy;


        public string RecipeName { get; set; }
        public string Ingredients { get; set; }
        public string SubmittedBy { get; set; }
        public string Catagory { get; set; }


        public int PrepTimeMinutes
        {
            get { return prepTimeMinutes; }
            set
            {
                if (value > 0)
                {
                    prepTimeMinutes = value;

                }
                else
                {
                    prepTimeMinutes = 1;
                }
            }
        }

        public bool IsVegitarian { get; set; }

        //methods

        public abstract string Display();

        public virtual string Display(int num)
        {
            if (num == 1)
            {
                return RecipeName;
            }
            else if (num == 2) 
            {
                 return RecipeName + " " + Ingredients;
            }
            else
            {
                return RecipeName + " " + Catagory + " " + Ingredients;
            }

        }
    }
}
