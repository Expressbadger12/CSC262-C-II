using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame
{
    public class Character
    {
        //private fields/attributes
        //maybe add a fith field like charisma or speed or something
        private int attack;
        private string name;
        private int health;
        private int defense;

        //public properties
        public int Attack
        {
            get { return attack; }
            set
            {
                if (value > 0)
                {
                    attack = value;
                }
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                //make sure that the name passed in to the setter is a least one character.
                if (value.Length > 0)
                {
                    name = value;
                }
            }
        }

        public int Health
        {
            get { return health; }
            set
            {
                if (value >= 0)
                {
                    health = value;
                }
            }
        }

        public int Defense
        {
            get { return defense; }
            set { defense = value; }
        }

        //constructor - generally pass in each attribute if that makes sense for your program
        public Character(int new_attack, string new_name, int new_health, int new_defense)
        {
            Attack = new_attack;
            Name = new_name;
            Health = new_health;
            Defense = new_defense;
        }

        //Abstract methods are nto implemented by the base class but must be implemented by each subclass

        // method to display the character's info
        //the virtual keyword gives us the option to override it in subclasses.
        public virtual string DisplayInfo()
        {
            //return a formatted string with all the character's info. Return only what you think is necessary for the object to display.
            return $"{Name} has {Health} health, {Defense} defense, and {Attack} attack.";
        }

        public virtual string DisplayInfo(int num)
        {
            if (num == 0)
            {
                return "nothing";
            }
            else if (num == 1) 
            {
                return $"{Name}";
            }
            else if(num == 1)
            {
                return $"{Name} has {Health} health";
            }
            else
            {
                return DisplayInfo();
            }
        }

        //this is the default DoAttack method, you can override this in the subclasses if you need to
        public virtual string DoAttack()
        {
            int level = 0;

            if (level == 0)
            {
                return "Send angry email";
            }
            else if (level == 1)
            {
                return "Send a punch";
            }
            else
            {
                return "Weapon attack";
            }
        }
        //abstract method - every character has to have a day job that is different - the day job method has to be implemented, but you don't get a day job by default, you have to earn it
        //public abstract string DoDayJob();
    }
}
