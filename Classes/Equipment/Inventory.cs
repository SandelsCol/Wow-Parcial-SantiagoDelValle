using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    class Inventory : Weapon
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
    }
}
