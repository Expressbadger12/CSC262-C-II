using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame
{
    internal class Warrior : Character
    {
        //private attributes
        private string weapon;
        private int armor;

        //public mana property
        public string Weapon
        {
            get { return weapon; }
            set
            {
                weapon = value;
            }
        }

        public int Armor
        {
            get { return armor; }
            set
            {
                if (value < 0)
                {
                    armor = 0;
                }
                else
                {
                    armor = value;
                }
            }
        }

        //constructor for the wizard subclass

        public Warrior(int new_attack, string new_name, int new_health, int new_defense, string new_weapon, int new_armor)
            : base(new_attack, new_name, new_health, new_defense)
        {
            weapon = new_weapon;
            armor = new_armor;
        }

        public string Smack()
        {
            return "ptch!";
        }

        public override string DisplayInfo()
        {
            //We chose to return the base class's displayinfo plys the mana and magic.
            //alternatively you could return the information in a completely different formate
            return $"{Name} is a Warrior and has {Health} health, {Defense} defense, {Attack} attack, {Armor} armor, and has a {weapon}.";
        }

        //public string DisplayInfoWar()
        //{
        //    //return a formatted string with all the character's info. Return only what you think is necessary for the object to display.
        //    return $"{Name} is a Warrior and has {Health} health, {Defense} defense, {Attack} attack, {Armor} armor, and has a {weapon}.";
        //}
    }
}
