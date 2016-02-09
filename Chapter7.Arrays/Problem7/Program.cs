using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program ,which reads from the 
//console two integer numbers N and K(K<N)
//and array  of N integers.Find those K consecutive elements 
//in the array which have maximum sum.
namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter K : ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Enter N where(K<N) : ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            List<int> maxSumList = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter array value for index [{0}]",i);
                arr[i] = int.Parse(Console.ReadLine());
                for (int len = 0,sum = arr[0]; len <= k-1 && sum>= len -1; len++,sum += arr[len])
                {
                    for (int len1 = 1,sum1 = arr[1]; len1 <= k&& sum1 >= len1 - 1; len1++,sum1 += arr[len])
                    {
                        Console.WriteLine(sum + " " + sum1 );
                    }    
                }
            }

        }
    }
}
