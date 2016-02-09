using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.GreaterInArray
{
    /// <summary>
    /// Write a method that returns the positions of THE FIRST SEQUENCE
    /// of an element from an array,such that it is greater than its two neibhour
    /// simultaneously.Otherwise must return result -1;
    /// </summary>
    class Program
    {
        static void ArrayChecker(int[] arr)
        {
            int mask = 0;
            int mask1 = 2;
            int ender = 0;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[mask] < arr[i] & arr[mask1] < arr[i])
                {
                    Console.WriteLine("Position is : " + (i + 1));
                    ender = i;
                    break;
                }

            }
            if (ender == 0)
            {
                Console.WriteLine(-1);
            }
            
       
        }
        static void Main(string[] args)
        {
            int[] arr = {1,1,1,2,1,1,1};
            ArrayChecker(arr);
        }
    }
}
