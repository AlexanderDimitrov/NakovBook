using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6.FindingIncreasingSeqInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {2,6,5,8,6,12,4,10,14,80,16,18,20,15,1,13,16,20,12,20 };
            List<int> maxList = new List<int>();
            int[] arr2 = new int[arr.Length - 1];
            for (int mask = 0; mask <(1 << arr.Length); mask++)
            {
                List<int> list = new List<int>();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (((mask >> i) & 1) == 1)
                    {
                        if (list.Count == 0 || list[list.Count - 1] < arr[i])
                            list.Add(arr[i]);
                    }
                    if (list.Count > maxList.Count)
                    {
                        maxList = list;
                    }
                }
            }
            foreach (var element in maxList)
            {
                Console.WriteLine(element + " ");
            }

        }
    }
}
