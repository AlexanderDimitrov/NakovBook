using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.BiggestElement
{
    /// <summary>
    /// Write a method that finds the biggest element of an array.
    /// Use that method to implement sorting in descending order.
    /// </summary>
    class Program
    {
        static void BiggestElFinder(int[] array)
        {
            int floatingNumber = 0;
            int currNumber = 0;
            int counter = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                currNumber = array[i];
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (currNumber > array[j])
                    {
                        floatingNumber = array[j];
                        array[j] = array[i];
                        array[i] = floatingNumber;

                    }
                }
            }
            foreach (var value in array)
            {
                Console.Write(value + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] arr =
                {1, 56, 20, 30, 100,
                128, 321, 123, 5152,
                123, 1541, 123, 312};
            BiggestElFinder(arr);

        }
    }
}
