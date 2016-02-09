using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.NumberFinder
{
    class Program
    {
        static void NumberFinder(int[] arr,int numberToBeFound)
        {
          
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (numberToBeFound == arr[i])
                {
                    counter ++;
                }               
            }
            Console.WriteLine("{0} found {1} times in the array",numberToBeFound,counter);
            
        }

        static void Main(string[] args)
        {
            
            int numberToBeFound = int.Parse((Console.ReadLine()));
            int[] arr1 = {1,2,3,4,1,2,3,4,5};
            NumberFinder(arr1,numberToBeFound);
        }
    }
}
