using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Reverse
{
    class Program
    {
        static void Reverse(int[] arr)
        {
            int counter = arr.Length;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[counter-1]);
                counter--;
            }
           

        }
        static void Main(string[] args)
        {
            string myString = Console.ReadLine();
            var array = myString.Select(ch => ch - '0').ToArray();
            Reverse(array);
        }
    }
}
