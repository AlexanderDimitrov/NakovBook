using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.GreaterInArray
{
    class Program
    {
        static void IndexCheckerForGreatness(int[] arr,int checker)
        {
            int counter = arr.Length;
            if (checker > 0 & checker != counter)
            {
                if (arr[checker] > arr[checker - 1] & arr[checker] > arr[checker + 1])
                {
                    Console.WriteLine("True");
                }
                else
                    Console.WriteLine("False");
            }
            else if(checker ==0)
            {
                if (arr[checker] > arr[checker + 1])
                {
                    Console.WriteLine("True");
                }
                else
                    Console.WriteLine("False");
            }
            else
            if (checker == counter-1)
            {
                if(arr[checker] > arr[checker -1])
                {
                    Console.WriteLine("True");
                }
                else
                    Console.WriteLine("False");
            }
        }
        static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 4, 5, 4, 7};
            int checker = int.Parse(Console.ReadLine());
            IndexCheckerForGreatness(array,checker);
        }
    }
}
