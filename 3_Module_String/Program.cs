using System;
using System.Linq.Expressions;
using System.Net.Cache;
using System.Xml.Linq;

namespace _3_Module_String
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напиши что-нибудь");
            var str = Console.ReadLine();

            Console.WriteLine("Укажите глубину эха");
            var deep = Convert.ToInt32(Console.ReadLine());

            Echo(str, deep);
            Console.ReadKey();
        }
        static void Echo(string saidworld, int deep)
        {
            var modif = saidworld;

            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }
            Console.BackgroundColor = (ConsoleColor)deep;
            Console.WriteLine("..." + modif);
            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }
    }
}
