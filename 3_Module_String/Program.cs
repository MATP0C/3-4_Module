using System;
using System.Net.Cache;
using System.Xml.Linq;

namespace _3_Module_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ( string Name , string LastName,string Login, int LoginLength, bool HasPet, byte Age, string[] favcolors, double ShoeSize, byte Height)User;
            bool Pet = false;

            Console.WriteLine("Enter a name :");
            Anketa.Name = Console.ReadLine();
            Anketa.NameCount = Anketa.Name.Length;
            Console.WriteLine("There are {0} letters in your name",Anketa.NameCount);
            Console.WriteLine("Enter the age :");
            Anketa.Age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter your shoe size :");
            Anketa.ShoeSize = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your height in centimeters :");
            Anketa.Height = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Write your favorite color in English with a small letter");
            var Color = Console.ReadLine();

            Console.WriteLine("\n Hellow World.");
            Console.WriteLine("\t Your name is {0}", Anketa.Name);
            Console.WriteLine("\t Your age is {0}", Anketa.Age);
            Console.WriteLine("\t Your height is {0} and your shoe size is {1}", Anketa.Height, Anketa.ShoeSize);

            Console.WriteLine("\t Do you have a pet ? " + Pet);
            switch (Color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("\tYour favorite color red");
                break;
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("\tYour favorite color green");
                break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("\tYour favorite color cyan");
                break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("\tYour favorite color yellow");
                break;
            }
            Console.ResetColor();
            Console.WriteLine("\x23");
            Console.ReadKey();
        }
    }
}
