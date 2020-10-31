using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FirstFantasy.Classes.Equipment
{
    class Inventory : Weapon // Esta clase perfectamente pudo ser una interfaz 
    {
        public static string[] Bag()
        {
            string Bag = @"F:\Documentos Familia Del valle Pinilla\SantiagoDelValle2020-20\Programación 1\Visual_Studio\Inventory.txt";
            string[] c = File.ReadAllLines(Bag);
            return c;
        }

        public static void AddBag(string ext)
        {
            string Bag = @"F:\Documentos Familia Del valle Pinilla\SantiagoDelValle2020-20\Programación 1\Visual_Studio\Inventory.txt";
            File.AppendAllText(Bag,ext + "\n");
        }

        public static string ViewALL()
        {
            string Bag = @"F:\Documentos Familia Del valle Pinilla\SantiagoDelValle2020-20\Programación 1\Visual_Studio\Inventory.txt";
            string viewbag = File.ReadAllText(Bag);
            return viewbag;
        }

        public static void Delete()
        {
            string i = "";
            string Bag = @"F:\Documentos Familia Del valle Pinilla\SantiagoDelValle2020-20\Programación 1\Visual_Studio\Inventory.txt";
            File.WriteAllText(Bag,i);
        }
    }
}
