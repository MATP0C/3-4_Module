﻿using System;
using System.Linq.Expressions;
using System.Net.Cache;
using System.Xml.Linq;

namespace _3_Module_String
{
    internal class Class1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(PowerUp(2, 3));
        }
        private static int PowerUp(int N, byte pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            else
            {
                if(pow == 1)
                {
                    return N;
                }
                else
                {
                    return N * PowerUp(N, --pow);
                }
            }
        }
    }
}
