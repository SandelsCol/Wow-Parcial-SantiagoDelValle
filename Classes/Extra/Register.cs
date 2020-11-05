using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FirstFantasy.Classes.Extra
{
    class Register
    {
        public static string ReadAllFile()
        {
            string way = @"F:\Documentos Familia Del valle Pinilla\SantiagoDelValle2020-20\Programación 1\Visual_Studio\Register.txt"; // (Archivo TXT) (Utilice la ruta de su archivo local para verificar el proceso)
            string location = File.ReadAllText(way);
            return location;
        }

        public static void Addname(string ext)
        {
            string way = @"F:\Documentos Familia Del valle Pinilla\SantiagoDelValle2020-20\Programación 1\Visual_Studio\Register.txt";
            File.AppendAllText(way, ext + "\n");
        }

        public static void Delete()
        {
            string i = "";
            string way = @"F:\Documentos Familia Del valle Pinilla\SantiagoDelValle2020-20\Programación 1\Visual_Studio\Register.txt";
            File.WriteAllText(way, i);
        }

        public static string[] Cont()
        {
            string way = @"F:\Documentos Familia Del valle Pinilla\SantiagoDelValle2020-20\Programación 1\Visual_Studio\Register.txt";
            string[] c = File.ReadAllLines(way);
            return c;
        }
    }
}
