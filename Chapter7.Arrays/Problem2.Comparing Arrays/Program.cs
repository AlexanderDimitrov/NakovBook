using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.Comparing_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Lenght of the first array :");
            int counter = int.Parse(Console.ReadLine());
            int[] firstArray = new int[counter];

            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write("Enter {0} number of the First Array :",i+1);
                int numberEntered = int.Parse(Console.ReadLine());
                firstArray[i] = numberEntered;
            }

            Console.Write("Enter the Lenght of the second array :");
            int counter1 = int.Parse(Console.ReadLine());
            int[] secondArray = new int[counter1];

            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write("Enter {0} number of the Second Array :",i+ 1);
                int numberEntered2 = int.Parse(Console.ReadLine());
                secondArray[i] = numberEntered2;

            }
            bool areEqual = firstArray.SequenceEqual(secondArray);
            Console.WriteLine(areEqual);


        }
    }
}
