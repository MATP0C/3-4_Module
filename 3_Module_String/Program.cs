using System;

namespace _3_Module_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Pet = false;

            Console.WriteLine("Enter a name :");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the age :");
            var Age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter your shoe size :");
            var ShoeSize = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your height in centimeters :");
            var Height = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Write your favorite color in English with a small letter");
            var Color = Console.ReadLine(); 

            Console.WriteLine("\n Hellow World.");
            Console.WriteLine("\t Your name is {0}", Name);
            Console.WriteLine("\t Your age is {0}", Age);
            Console.WriteLine("\t Your height is {0} and your shoe size is {1}", Height, ShoeSize);

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
            for (int i = Name.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(Name[i] + " ");
            }
            Console.WriteLine("\x23");
            Console.ReadKey();
        }
    }
}
