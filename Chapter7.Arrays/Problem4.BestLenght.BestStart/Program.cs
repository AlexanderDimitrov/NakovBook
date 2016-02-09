using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4.BestLenght.BestStart
{
    //Gathering Equal Numbers From a sequance
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            string input = Console.ReadLine();
            var numbers = input.Split(',').Select(Int32.Parse).ToList();
            int curNumber = 0;
            numbers.Add(curNumber);
            int nextNumber = 0;
            for (int i = 0; i < numbers.Count-1; i++)
            {
                curNumber = numbers[i];
                nextNumber = numbers[i + 1];
                if(curNumber==nextNumber)
                {
                    list.Add(curNumber);
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item + " ");
            }


        }
    }
}
