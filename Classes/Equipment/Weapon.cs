using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public abstract class Weapon // Esta clase perfectamente pudo ser una interfaz 
    {
        private string item;
        private string lvl;
        private string type;
        private string name;
        private string raze;
        private string fact;

        public string Type { get => type; set => type = value; }
        public string Lvl { get => lvl; set => lvl = value; }
        public string Item { get => item; set => item = value; }
        public string Name { get => name; set => name = value; }
        public string Raze { get => raze; set => raze = value; }
        public string Fact { get => fact; set => fact = value; }

        public string ShowInformation()
        {
            return "This is a weapon";
        }

        public static int DamageSword()
        {
            int sword = 9;
            Random r = new Random();
            int number = r.Next(1, 9);
            return number + sword;
        }

        public static int DamagePotion()
        {
            double potion = 2.5;
            Random r = new Random();
            int number = r.Next(1, 9);
            return (int)(number + potion);
        }
        public static int DamageOldBook()
        {
            int oldbook = 4;
            Random r = new Random();
            int number = r.Next(1,9);
            return number + oldbook;
        }
        public static int DamageManabooster()
        {
            int manabooster = 1;
            Random r = new Random();
            int number = r.Next(1,9);
            return number + manabooster;
        }
        public static int DamageRod()
        {
            int rod = 6;
            Random r = new Random();
            int number = r.Next(1, 9);
            return number + rod;
        }

        public static int DamageDagger()
        {
            int dagger = 3;
            Random r = new Random();
            int number = r.Next(1, 9);
            return number + dagger;
        }
    }
}
