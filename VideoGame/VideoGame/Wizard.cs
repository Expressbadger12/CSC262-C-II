using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame
{
    public class Wizard : Character
    {
        //private attributes
        private int mana;
        private int magic;

        //public mana property
        public int Mana
        {
            get { return mana; }
            set
            {
                if (value < 0)
                {
                    mana = 0;
                }
                else
                {
                    mana = value;
                }
            }
        }

        public int Magic
        {
            get { return magic; }
            set
            {
                if (value < 0)
                {
                    magic = 0;
                }
                else
                {
                    magic = value;
                }
            }
        }

        //constructor for the wizard subclass

        public Wizard(int new_attack, string new_name, int new_health, int new_defense, int new_mana, int new_magic)
            : base (new_attack, new_name, new_health, new_defense)
        {
            mana = new_mana;
            Magic = new_magic;
        }

        public string CastFireball()
        {
            return "FIREBALL!";
        }

        public override string DisplayInfo()
        {
            //We chose to return the base class's displayinfo plys the mana and magic.
            //alternatively you could return the information in a completely different formate
            return $"{Name} is a wizard has {Health} health, {Defense} defense, {Attack} attack, {Mana} mana, and {Magic} magic.";
        }

        public override string DisplayInfo(int num)
        {
            if (num == 2)
            {
                return mana.ToString() + " mana " + magic.ToString() + "magic";
            }
            else
            {
                return base.DisplayInfo(num);
            }
        }

        //public string DisplayInfoWiz()
        //{
        //    //return a formatted string with all the character's info. Return only what you think is necessary for the object to display.
        //    return $"{Name} is a wizard has {Health} health, {Defense} defense, {Attack} attack, {Mana} mana, and {Magic} magic.";
        //}
    }
}
