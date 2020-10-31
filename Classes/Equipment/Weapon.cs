using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public abstract class Weapon : IDescribable 
    {
        public string ShowInformation()
        {
            return "This is a weapon";
        }

        public static int DamageAxe()
        {
            double axe = 8.5;
            Random r = new Random();
            int number = r.Next(1, 9);
            return (int)(number + axe);
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
        public static int OldBook()
        {
            int oldbook = 4;
            Random r = new Random();
            int number = r.Next(1,9);
            return number + oldbook;
        }
        public static int Manabooster()
        {
            int manabooster = 1;
            Random r = new Random();
            int number = r.Next(1,9);
            return number + manabooster;
        }
        public static int Rod()
        {
            int rod = 6;
            Random r = new Random();
            int number = r.Next(1, 9);
            return number + rod;
        }

        public static int Dagger()
        {
            int dagger = 3;
            Random r = new Random();
            int number = r.Next(1, 9);
            return number + dagger;
        }
    }
}
