using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8.Sorting_an_Array
{
    //Sorting an array in a sequance
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {5,3,4,2,1};
            int minimumPosition;
            int temp;
            for (int i = 0; i <arr.Length - 1; i++)
            {
                minimumPosition = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[j] < arr[minimumPosition])
                    {
                        minimumPosition = j;
                    }
                }
                if (minimumPosition != i)
                {
                    temp = arr[i];
                    arr[i] = arr[minimumPosition];
                    arr[minimumPosition] = temp;
                }

            }
            foreach (var VARIABLE in arr)
            {
                Console.Write(VARIABLE + " ");
            }
        }
    }
}
