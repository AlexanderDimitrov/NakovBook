using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11.SeqOfNeighbourNumbers
{
    //Write a program to find a sequance of neighour 
    //    numbers in an array
    //    ,which has a sum of certain numbers S
    class Program
    {
        static void Main(string[] args)
        {
            int S = 11;
            int[] arr = {4, 3, 1, 4, 2, 5, 8};
            int currSum = 0;
            int startLoopInd = 0;
            int endLoopInd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                currSum = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    if (currSum < S)
                    {
                        currSum += arr[j];
                        if (currSum == S)
                        {
                            startLoopInd = i;
                            endLoopInd = j;
                        }
                    }
                }
            }
            for (int i = startLoopInd; i <= endLoopInd; i++)
            {
                Console.Write(arr[i] + " ");
            }           
        }
    }
}
