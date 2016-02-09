using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.Not_Divisible_By_3_and_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                if (!(i%3==0 & i%7==0))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
