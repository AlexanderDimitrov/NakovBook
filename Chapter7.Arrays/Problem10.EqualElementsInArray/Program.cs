using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads equal numbers in array 
//sorts the longest sequence of them
//prints it in the console.
namespace Problem10.EqualElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {4,1,1,4,2,3,4,4,1,2,4,9,3};
            Array.Sort(arr);
            int current = 0;
            int count = 0;
            int tempValue = 0;
            int maxCount = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                count = 1;
                for (int j = i+1; j < arr.Length -1; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                    else break;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    tempValue = arr[i];
                    i += maxCount;
                }
            }
            Console.WriteLine("Variable :{0} ,{1} Times ",tempValue,count);
        }
    }
}
