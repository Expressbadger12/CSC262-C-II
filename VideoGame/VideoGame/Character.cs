using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame
{
    public class Character
    {
        //private fields/attributes
        private int attack;
        private string name;
        private int health;
        private int defense;

        //public properties
        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
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

    }
}
