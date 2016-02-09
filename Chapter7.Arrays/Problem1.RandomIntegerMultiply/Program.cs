using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.RandomIntegerMultiply
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            int[] myInts = new int[counter];
            for (int i = 0; i < myInts.Length; i++)
            {
                myInts[i] += i * 5;
                Console.WriteLine(myInts[i]);
            }
        }
    }
}

