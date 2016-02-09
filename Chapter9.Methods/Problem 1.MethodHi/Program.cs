using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.MethodHi
{
    class Program
    {
        public static void PrintMe(string str)
        {
            Console.WriteLine("Hi {0}",str);
        } 
        static void Main(string[] args)
        {
            string yourName = Console.ReadLine();
            PrintMe(yourName);
        }
    }
}
