using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7.Arrays
//Before taking any tasks from arrays.
//Bubble Sort is THE THING you must understand
{
    class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9 };

            int temp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
                
            }
            foreach (var VARIABLE in arr)
            {
                Console.WriteLine(VARIABLE + " ");
            }
        }
    }
}
