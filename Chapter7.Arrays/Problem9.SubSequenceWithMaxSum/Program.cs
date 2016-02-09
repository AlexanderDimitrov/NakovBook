using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9.SubSequenceWithMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {2, 3, -6, -1, 2, -1, 6, 4, -8, 8};
            int[] maxArray = new int[1];
            int maxTotal = int.MinValue;
            int curIndex = 0;
            int tmpTotal = 0;
            List<int> tmpArray = new List<int>();

            if (arr.Length != 1)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    tmpTotal = 0;
                    curIndex = i;
                    tmpArray.Clear();

                    while (curIndex < arr.Length)
                    {
                        tmpTotal += arr[curIndex];
                        tmpArray.Add(arr[curIndex]);

                        if (tmpTotal > maxTotal)
                        {
                            maxTotal = tmpTotal;
                            maxArray = tmpArray.ToArray();
                        }

                        curIndex++;
                    }
                }
            }
            else
            {
                maxTotal = arr[0];
                maxArray = arr;
            }
            Console.WriteLine(maxTotal);
        }
    }
}
