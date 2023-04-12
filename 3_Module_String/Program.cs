using System;

namespace _3_Module_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = "Bogdan";
            byte Age = 21;
            bool Pet = false;
            double ShoeSize = 43.5;
            Console.WriteLine("Hellow World.");
            Console.WriteLine("\t My name is "+ Name);
            Console.WriteLine("\t My age is "+ Age);
            Console.WriteLine("\n\t Do you have a pet ? "+ Pet);
            Console.WriteLine("\t My shoe size is "+ ShoeSize);
            Console.WriteLine("\x23");
            Console.ReadKey();
        }
    }
}
