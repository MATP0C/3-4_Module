using System;
using System.Linq.Expressions;
using System.Net.Cache;
using System.Xml.Linq;

namespace _3_Module_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ( string Name , string LastName,string Login, int LoginLength, bool HasPet, byte Age, string[] favcolors, double ShoeSize, byte Height) User;

            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine("Введите ваше имя:");
                User.Name = Console.ReadLine();

                Console.WriteLine("Введите вашу фамилию:");
                User.LastName = Console.ReadLine();

                Console.WriteLine("Есть ли у вас животные? Да или нет");
                var result = Console.ReadLine();
                if (result == "Да")
                {
                    User.HasPet = true;
                }
                else
                {
                    User.HasPet = false;
                }

                Console.WriteLine("Введите ваш логин:");
                User.Login = Console.ReadLine();
                User.LoginLength = User.Login.Length;
                Console.WriteLine("Длина вашего логина {0}", User.LoginLength);

                Console.WriteLine("Введите ваш возраст:");
                User.Age = Convert.ToByte(Console.ReadLine());

                Console.WriteLine("Введите ваш размер обуви:");
                User.ShoeSize = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите ваш рост:");
                User.Height = Convert.ToByte(Console.ReadLine());

                User.favcolors = new string[3];
                Console.WriteLine("Введите три любимых цвета:");
                for (int i = 0; i < User.favcolors.Length; i++)
                {
                    User.favcolors[i] = Console.ReadLine();
                }
            }

            Console.WriteLine("Write your favorite color in English with a small letter");
            var Color = Console.ReadLine();
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
